using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net;
using System.Xml;

namespace HavaDurumu
{
    public partial class SelectCityForm : Form
    {
        public SelectCityForm()
        {
            InitializeComponent();
        }

        private string findFormat = 
            "http://weather.service.msn.com/find.aspx?" + 
            "outputview=search" + 
            "&src=vista" + 
            "&weasearchstr={0}" + 
            "&weadegreetype=F" + 
            "&culture=tr-TR";
        public string locationCode = "";
        public List<string> codeList = new List<string>();

        private void DisplayError(string errorText)
        {
            statusLabel.Text = errorText;
            cityTextBox.Focus();
        }

        private void OnDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            
            string strData = e.Result;
            if (strData == "")
            {
                DisplayError(Properties.Resources.NoResultsFound);
                return;
            }

            /* UTF-8 de BOM sorunu icin eklendim. Aslinda basit string islemi de olurdu
             * ama ben en garanti yoldan yapayim dedim. (22/07/2013) */

            //strData = strData.Substring(strData.IndexOf("<?xml"));

            XmlDocument doc = new XmlDocument();

            byte[] data = Encoding.UTF8.GetBytes(strData);

            using (var xmlStream = new MemoryStream(data))
            {
                using (var xmlReader = new XmlTextReader(xmlStream))
                {
                    doc.Load(xmlReader);
                }
            }

            /*
            doc.LoadXml(strData);
            //doc.Save("find.xml");
            */

            XmlNodeList list = doc.SelectNodes("/weatherdata/weather");
            if (list.Count > 0)
            {
                XmlElement element;
                for (int index = 0; index < list.Count; index++)
                {
                    element = list.Item(index) as XmlElement;
                    string code = element.GetAttribute("weatherlocationcode");
                    codeList.Add(code);
                    resultListBox.Items.Add(element.GetAttribute("weatherfullname"));
                }
                statusLabel.Text = String.Format(Properties.Resources.ResultText, list.Count);
                resultListBox.SelectedIndex = 0;
                locationCode = codeList[resultListBox.SelectedIndex];
                resultListBox.Focus();
            }
            else
            {
                DisplayError(Properties.Resources.NoResultsFound);
            }
        }
        
        private void findButton_Click(object sender, EventArgs e)
        {
            
            string cityName = cityTextBox.Text;
            if (cityName == "")
            {
                DisplayError(Properties.Resources.EnterCityName);
                return;
            }

            statusLabel.Text = Properties.Resources.Searching;
            locationCode = "";
            resultListBox.Items.Clear();
            codeList.Clear();

            cityName = HttpUtility.UrlEncode(cityName, Encoding.UTF8);
            string requestURL = String.Format(findFormat, cityName);
            
            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.UTF8;
            webclient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnDownloadStringCompleted);
            webclient.DownloadStringAsync(new Uri(requestURL));
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int index = resultListBox.SelectedIndex;
            if ((index >= 0) && (index < codeList.Count))
            {
                locationCode = codeList[index];
            }
        }

        private void SelectCityForm_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void cityTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = findButton;
        }

        private void resultListBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = okButton;
        }

        private void resultListBox_DoubleClick(object sender, EventArgs e)
        {
            if ((resultListBox.Items.Count > 0) && (resultListBox.SelectedIndex >= 0))
            {
                okButton.PerformClick();
            }
        }
        
    }
}
