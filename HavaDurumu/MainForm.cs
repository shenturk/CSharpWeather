﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml;
using System.Web;
using System.Reflection;
using Microsoft.Win32;

namespace HavaDurumu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string appVersion = "5.0.0";
        private Graphics graphics = null;
        private Bitmap bitmap = null;
        private byte opacity = 0xff;
        private Color imageColor = Color.White;
        private Color foreColor = Color.White;
        private bool runStartup = false;
        private bool showBackground = true;
        private bool useCompatibleTextRendering = false;
        private string locationCode = "wc:TUXX0014"; // Istanbul
        private string locationName = "İstanbul";
        private string degreeType = "C";
        private string culture = "tr-TR"; //"en-US";//"de-DE"
        private string dataFormat = 
            "http://weather.service.msn.com/data.aspx?" + 
            "src=vista" + 
            "&wealocations={0}" + 
            "&weadegreetype={1}" + 
            "&culture={2}";
        private int refreshInterval = 1000 * 60 * 5; // 5 dakika
        private bool hibernate = false;

        private void RefreshLayeredForm()
        {
            RepaintLayeredForm();
            UpdateLayeredForm();
        }

        private void LoadSettings()
        {
            int left = Properties.Settings.Default.Left;
            if (left == 0xffff) left = (SystemInformation.WorkingArea.Width - this.Width) / 2;
            int top = Properties.Settings.Default.Top;
            if (top == 0xffff) top = (SystemInformation.WorkingArea.Height - this.Height) / 2;
            this.Left = left;
            this.Top = top;
            locationCode = Properties.Settings.Default.LocationCode;
            imageColor = Properties.Settings.Default.ImageColor;
            foreColor = Properties.Settings.Default.ForeColor;
            this.TopMost = Properties.Settings.Default.AlwaysTop;
            AlwaysTopToolStripMenuItem.Checked = this.TopMost;
            runStartup = Properties.Settings.Default.RunStartup;
            RunStartupToolStripMenuItem.Checked = runStartup;
            locationName = Properties.Settings.Default.LocationName;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Left = this.Left;
            Properties.Settings.Default.Top = this.Top;
            Properties.Settings.Default.LocationCode = locationCode;
            Properties.Settings.Default.ImageColor = imageColor;
            Properties.Settings.Default.ForeColor = foreColor;
            Properties.Settings.Default.AlwaysTop = this.TopMost;
            Properties.Settings.Default.ShowBackground = showBackground;
            Properties.Settings.Default.RunStartup = runStartup;
            Properties.Settings.Default.UseCompatibleTextRendering = useCompatibleTextRendering;
            Properties.Settings.Default.LocationName = locationName;
            Properties.Settings.Default.Save();
        }

        private void DisplayError()
        {
            locationLabel.Text = Properties.Resources.ErrorMessage;
            RefreshLayeredForm();
        }

        private void OnDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                DisplayError();
                return;
            }

            string strData = e.Result;
            if (strData == "")
            {
                DisplayError();
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
            //doc.Save("data.xml");
            */

            //doc.Save("data.xml");

            XmlNode node = doc.SelectSingleNode("/weatherdata/weather/@errormessage");
            if (node != null)
            {
                DisplayError();
                return;
            }

            node = doc.SelectSingleNode("/weatherdata/weather/current/@skycode");
            string textValue = node.Value;
            textValue = "Light" + textValue;
            skyBigPicture.Image = Properties.Resources.ResourceManager.GetObject(textValue) as Bitmap;

            node = doc.SelectSingleNode("/weatherdata/weather/@weatherlocationname");
            textValue = node.Value;
            int pos = textValue.IndexOf(',');
            if (pos > 0) textValue = textValue.Substring(0, pos);
            locationLabel.Text = textValue;
            locationName = textValue;

            node = doc.SelectSingleNode("/weatherdata/weather/current/@temperature");
            textValue = node.Value;
            tempLabel.Text = textValue + '\u00b0';

            node = doc.SelectSingleNode("/weatherdata/weather/current/@skytext");
            textValue = node.Value;
            skyTextLabel.Text = textValue;

            node = doc.SelectSingleNode("/weatherdata/weather/current/@feelslike");
            feelslikeLabel.Text = String.Format(Properties.Resources.FeelsLike, node.Value + '\u00b0');

            XmlNodeList list = doc.SelectNodes("/weatherdata/weather/forecast");
            if (list.Count > 0)
            {

                XmlElement element;

                element = list.Item(1) as XmlElement;
                dayLabel1.Text = element.GetAttribute("day");
                skytextLabel1.Text = element.GetAttribute("skytextday");
                textValue = element.GetAttribute("skycodeday");
                textValue = "Light" + textValue;
                skySmallPicture1.Image = Properties.Resources.ResourceManager.GetObject(textValue) as Bitmap;
                tempLabel1.Text = element.GetAttribute("high") + '\u00b0' + "/ " + element.GetAttribute("low") + '\u00b0';

                element = list.Item(2) as XmlElement;
                dayLabel2.Text = element.GetAttribute("day");
                skytextLabel2.Text = element.GetAttribute("skytextday");
                textValue = element.GetAttribute("skycodeday");
                textValue = "Light" + textValue;
                skySmallPicture2.Image = Properties.Resources.ResourceManager.GetObject(textValue) as Bitmap;
                tempLabel2.Text = element.GetAttribute("high") + '\u00b0' + "/ " + element.GetAttribute("low") + '\u00b0';

                element = list.Item(3) as XmlElement;
                dayLabel3.Text = element.GetAttribute("day");
                skytextLabel3.Text = element.GetAttribute("skytextday");
                textValue = element.GetAttribute("skycodeday");
                textValue = "Light" + textValue;
                skySmallPicture3.Image = Properties.Resources.ResourceManager.GetObject(textValue) as Bitmap;
                tempLabel3.Text = element.GetAttribute("high") + '\u00b0' + "/ " + element.GetAttribute("low") + '\u00b0';

                element = list.Item(4) as XmlElement;
                dayLabel4.Text = element.GetAttribute("day");
                skytextLabel4.Text = element.GetAttribute("skytextday");
                textValue = element.GetAttribute("skycodeday");
                textValue = "Light" + textValue;
                skySmallPicture4.Image = Properties.Resources.ResourceManager.GetObject(textValue) as Bitmap;
                tempLabel4.Text = element.GetAttribute("high") + '\u00b0' + "/ " + element.GetAttribute("low") + '\u00b0';

            }

            RefreshLayeredForm();
        }

        private void GetWeatherData()
        {

            locationLabel.Text = Properties.Resources.Connecting;

            RefreshLayeredForm();

            string requestURL = String.Format(dataFormat, locationCode, degreeType, culture);

            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.UTF8;
            webclient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnDownloadStringCompleted);
            webclient.DownloadStringAsync(new Uri(requestURL));
            
        }

        private void OnCheckVersionCompleted(object sender, DownloadStringCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                return;
            }

            string strData = e.Result;
            if (strData == "")
            {
                return;
            }

            XmlDocument doc = new XmlDocument();

            byte[] data = Encoding.UTF8.GetBytes(strData);

            using (var xmlStream = new MemoryStream(data))
            {
                using (var xmlReader = new XmlTextReader(xmlStream))
                {
                    doc.Load(xmlReader);
                }
            }

            //doc.Save("data.xml");

            XmlNode node = doc.SelectSingleNode("/data/version");
            if (node != null)
            {
                appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                string textValue = node.InnerText;
                if (appVersion.CompareTo(textValue) < 0)
                {
                    versionLabel.Text = Properties.Resources.NewVersionText;
                    toolTip1.SetToolTip(versionLabel, versionLabel.Text);
                    versionLabel.Visible = true;
                    RefreshLayeredForm();
                }
            }
            
        }

        private void CheckVersion()
        {
            Random random = new Random();
            int value = random.Next();
            string requestURL = "http://www.shenturk.com/havadurumu.xml?rand=" + value.ToString();
            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.UTF8;
            webclient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnCheckVersionCompleted);
            webclient.DownloadStringAsync(new Uri(requestURL));
        }

        private void DrawTransparentLabel(Label label)
        {

            using (Brush foreBrush = new SolidBrush(label.ForeColor))
            using (StringFormat format = new StringFormat())
            {

                switch (label.TextAlign)
                {
                    case ContentAlignment.TopLeft:
                        format.Alignment = StringAlignment.Near;
                        format.LineAlignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.TopRight:
                        format.Alignment = StringAlignment.Far;
                        format.LineAlignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.TopCenter:
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Near;
                        break;

                    case ContentAlignment.MiddleLeft:
                        format.Alignment = StringAlignment.Near;
                        format.LineAlignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.MiddleRight:
                        format.Alignment = StringAlignment.Far;
                        format.LineAlignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.MiddleCenter:
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;
                        break;

                    case ContentAlignment.BottomLeft:
                        format.Alignment = StringAlignment.Near;
                        format.LineAlignment = StringAlignment.Far;
                        break;
                    case ContentAlignment.BottomRight:
                        format.Alignment = StringAlignment.Far;
                        format.LineAlignment = StringAlignment.Far;
                        break;
                    case ContentAlignment.BottomCenter:
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Far;
                        break;

                }

                System.Drawing.Text.TextRenderingHint saveValue = graphics.TextRenderingHint;
                if (label.UseCompatibleTextRendering == true)
                {
                    graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                }
                /* Tek satira cizim yapmak icin ayarla */
                format.FormatFlags = StringFormatFlags.NoWrap;
                /* Satira sigmazsa ... karakterlerini goruntule */
                format.Trimming = StringTrimming.EllipsisCharacter;
                Rectangle rect = label.Bounds;
                /* Koordinatlari 1 piksel saga ve asagiya kaydir */
                rect.Offset(1, 1);
                /* Siyah golge etkisi vermek icin cizim */
                graphics.DrawString(label.Text, label.Font, Brushes.Black, rect, format);
                /* Normal cizim */
                graphics.DrawString(label.Text, label.Font, foreBrush, label.Bounds, format);
                graphics.TextRenderingHint = saveValue;
            }

        }

        private void DrawColorizedPicture(PictureBox picture, Color color)
        {
            ColorMatrix matrix = new ColorMatrix(new float[][]
            {
                new float[]{ 1f, 0f, 0f, 0f, 0f },
                new float[]{ 0f, 1f, 0f, 0f, 0f },
                new float[]{ 0f, 0f, 1f, 0f, 0f },
                new float[]{ 0f, 0f, 0f, 1f, 0f },
                new float[]{ 0f, 0f, 0f, 0f, 1f }
            });
            matrix.Matrix00 = (float)color.R / (float)255;
            matrix.Matrix11 = (float)color.G / (float)255;
            matrix.Matrix22 = (float)color.B / (float)255;
            using (ImageAttributes attr = new ImageAttributes())
            {
                attr.SetColorMatrix(matrix);
                graphics.DrawImage(picture.Image, picture.Bounds, 0f, 0f, picture.Image.Width, picture.Image.Height, GraphicsUnit.Pixel, attr);
            }
        }

        private void RepaintLayeredForm()
        {

            /* Herseyi sil */
            graphics.Clear(Color.FromArgb(0));

            /* Dikkat form uzerindeki bilesenler tersten siralanir */
            for (int index = this.Controls.Count - 1; index >= 0; index--)
            {

                Control control = this.Controls[index];

                /* Bilesen gorunmezse cizim yapma */
                if (!control.Visible) continue;

                if (control is PictureBox)
                {
                    /* Bilesen PictureBox turundense Image ozelligini ciz  */
                    PictureBox picture = control as PictureBox;
                    /* Renklendirme isleminde settingsBox ve reflectionBox haric tutulacak */
                    if ((picture.Name == "settingsBox") || (picture.Name == "reflectionBox"))
                    {
                        /* Sadece settingsBox dugmesini normal ciz */
                        graphics.DrawImage(picture.Image, picture.Bounds);
                    }
                    else
                    {
                        /* Diger pictureBox nesnelerini renklendirilmis olarak ciz */
                        this.DrawColorizedPicture(picture, imageColor);
                    }
                }
                else if (control is Label)
                {
                    /* Bilesen Label turundense durum biraz karisik. Normalde DrawToBitmap fonksiyonu
                     * transparent cizim yapmaz. Biz zeminin cizilmesini istemiyoruz. Orjinalden biraz
                     * farkli bir cizim yapiyoruz.
                     */
                    Label label = control as Label;
                    label.ForeColor = foreColor;
                    label.UseCompatibleTextRendering = useCompatibleTextRendering;
                    this.DrawTransparentLabel(label);
                }
                else
                {
                    /* Diger turdense varsayilan cizim */
                    control.DrawToBitmap(bitmap, control.Bounds);
                }
            }

        }

        private void UpdateLayeredForm()
        {
            /* Desktop ile uyumlu bir DC olustur. */
            IntPtr SrcDC = Win32.CreateCompatibleDC(IntPtr.Zero);

            /* Olusturdugumuz DC ile uyumlu yeni bir DC daha olusturmaliyiz. Kopyalama icin. */
            IntPtr DestDC = Win32.CreateCompatibleDC(SrcDC);

            /* Cizim yaptigimiz resmin Windows tarafidan anlasilan HBITMAP turunden degiskene ata.
               Bu kisim onemli. Cizim yaptigimiz resmi gercek dunyaya getiriyoruz.
               BitmapHandle degiskeni artik Windows tarafindan kullanilanilabilir duruma geldi. */
            IntPtr BitmapHandle = bitmap.GetHbitmap(Color.FromArgb(0));

            /* SrcDC de bitmap secilmeli */
            IntPtr PrevBitmap = Win32.SelectObject(DestDC, BitmapHandle);

            /* Boyutlar ve konum */
            Win32.Size Size = new Win32.Size()
            {
                X = Width,
                Y = Height
            };

            Win32.Point S = new Win32.Point()
            {
                X = 0,
                Y = 0
            };

            Win32.Point P = new Win32.Point()
            {
                X = Left,
                Y = Top
            };

            Win32.BlendFunction BlendFunc = new Win32.BlendFunction()
            {
                BlendOp = Win32.AC_SRC_OVER,
                BlendFlags = 0x00, /* Sifir olmali */
                AlphaFormat = Win32.AC_SRC_ALPHA,
                SourceConstantAlpha = opacity /* Ana formun donukluk degeri. 0 = tam saydam, 255 = tam donuk. */
            };

            /* Microsoft'un sihirli fonksiyonu! Oylesine onemli ki, aslinda butun kiyamet burada kopuyor.
              Detayli aciklamayi MSDN' den mutlaka okuyunuz. http://msdn.microsoft.com/en-us/library/ms633556(VS.85).aspx */
            Win32.UpdateLayeredWindow(this.Handle, SrcDC, ref P, ref Size, DestDC,
                ref S, 0, ref BlendFunc, Win32.ULW_ALPHA);

            /* SrcDC yi eski haline getir. */
            Win32.SelectObject(SrcDC, PrevBitmap);

            /* ve Bitmap'i yok et. Yoksa hafiza sizmasi olur. */
            Win32.DeleteObject(BitmapHandle);

            /* DC leri yok et. */
            Win32.DeleteDC(DestDC);
            Win32.DeleteDC(SrcDC);

        }

        private void BeginLoader()
        {
            refreshTimer.Interval = refreshInterval;
            refreshTimer.Enabled = true;
            GetWeatherData();
            CheckVersion();
            RefreshLayeredForm();
        }

        private void loaderTimer_Tick(object sender, EventArgs e)
        {
            loaderTimer.Enabled = false;
            BeginLoader();
        }

        private void SetLayeredForm()
        {
            long style = CreateParams.ExStyle;

            // Bu fromun window styles ozelliginden WS_EX_LAYERED bitini varsa kaldir
            if ((style & Win32.WS_EX_LAYERED) != 0)
            {
                style &= ~Win32.WS_EX_LAYERED;
                Win32.SetWindowLong(this.Handle, Win32.GWL_EXSTYLE, (IntPtr)style);
            }

            // Simdi WS_EX_LAYERED bitini set et
            style |= Win32.WS_EX_LAYERED;
            Win32.SetWindowLong(this.Handle, Win32.GWL_EXSTYLE, (IntPtr)style);

            /* Form boyutlarinda bir Bitmap olustur */
            bitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);

            /* Bitmap ile baglantili ana Graphics nesnesi */
            graphics = Graphics.FromImage(bitmap);

            /* Yumusak metin etkisi. Eger AntiAliasGridFit yaparsaniz keskin bir metin elde edersiniz. */
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            /* Resimleri olceklendirilmesi en iyi kalitede olsun. Dikkat islemci tuketimi artar. */
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            /* Uygulamadan cikildiginda ayarlarin kaydedilmesi icin gerekli */
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            /* Loader' dan once yapilmasi gerekiyor  */
            showBackground = Properties.Settings.Default.ShowBackground;
            backBox.Visible = showBackground;
            reflectionBox.Visible = backBox.Visible;
            SetShowHideMenuItemText(showBackground);

            /* Keskin yazi bicimi */
            useCompatibleTextRendering = Properties.Settings.Default.UseCompatibleTextRendering;
            UseCompatibleTextRenderingToolStripMenuItem.Checked = useCompatibleTextRendering;

            /* Saydamlik icin formun Opacity ozelligini kullanin */
            opacity = Convert.ToByte(this.Opacity * 0xff);

            /* Formu katmanli hale getir */
            SetLayeredForm();

            /* Baslangic ayarlarini yukle */
            LoadSettings();

            /* Yukleme zamanlayicisini etkinlestir */
            loaderTimer.Enabled = true;
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            refreshTimer.Enabled = false;
            GetWeatherData();
            RefreshLayeredForm();
            refreshTimer.Enabled = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(AboutBox1 AboutBox = new AboutBox1())
            {
                AboutBox.ShowDialog(this);
            }
        }

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SelectCityForm SelectCity = new SelectCityForm())
            {
                DialogResult result = SelectCity.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    string code = SelectCity.locationCode;
                    if (code != "")
                    {
                        locationCode = code;
                        refreshTimer_Tick(sender, e);
                    }
                }
            }
        }

        private void DoHibernate()
        {

            long style = Win32.GetWindowLong(this.Handle, Win32.GWL_EXSTYLE).ToInt32();

            if ((style & Win32.WS_EX_TRANSPARENT) == 0)
            {
                style |= Win32.WS_EX_TRANSPARENT;
                Win32.SetWindowLong(this.Handle, Win32.GWL_EXSTYLE, (IntPtr)style);
                opacity = 0x80;
            }

        }

        private void DoWakeup()
        {
            long style = Win32.GetWindowLong(this.Handle, Win32.GWL_EXSTYLE).ToInt32();

            if ((style & Win32.WS_EX_TRANSPARENT) != 0)
            {
                style &= ~Win32.WS_EX_TRANSPARENT;
                Win32.SetWindowLong(this.Handle, Win32.GWL_EXSTYLE, (IntPtr)style);
                opacity = 0xff;
            }

        }

        private void SetHibernateState(bool state)
        {
            if (state) DoHibernate();
            else DoWakeup();
            HibernateToolStripMenuItem.Checked = state;
            keyTimer.Enabled = state;
            RefreshLayeredForm();
        }

        private void HibernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hibernate = !hibernate;
            SetHibernateState(hibernate);
        }

        private void keyTimer_Tick(object sender, EventArgs e)
        {
            Win32.Rect rect = new Win32.Rect();
            Win32.GetWindowRect(this.Handle, ref rect);
            Win32.Point p = new Win32.Point();
            Win32.GetCursorPos(ref p);
            if (Win32.PtInRect(ref rect, p))
            {
                short keyState = Win32.GetKeyState(Win32.VK_CONTROL);
                if ((keyState & 0x8000) != 0)
                {
                    hibernate = false;
                    SetHibernateState(hibernate);
                }
            }
        }

        private void locationLabel_Click(object sender, EventArgs e)
        {
            ChangeToolStripMenuItem_Click(sender, e);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            try
            {
                this.SaveSettings();
            }
            catch { }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            settingsBox.Visible = true;
            RefreshLayeredForm();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            settingsBox.Visible = false;
            RefreshLayeredForm();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshTimer_Tick(sender, e);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(this.Handle, Win32.WM_SYSCOMMAND, Win32.SC_DRAGMOVE, 0x0);
            }
        }

        private void AlwaysTopToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.TopMost = !this.TopMost;
            AlwaysTopToolStripMenuItem.Checked = this.TopMost;
        }

        private void SetShowHideMenuItemText(bool value)
        {
            if (value)
            {
                ShowHideBackgroundToolStripMenuItem.Text = Properties.Resources.HideBackground;
            }
            else
            {
                ShowHideBackgroundToolStripMenuItem.Text = Properties.Resources.ShowBackground;
            }
        }

        private void ShowHideBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showBackground = !showBackground;
            backBox.Visible = showBackground;
            reflectionBox.Visible = backBox.Visible;
            SetShowHideMenuItemText(showBackground);
            RefreshLayeredForm();
        }

        private void ForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = foreColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                foreColor = colorDialog1.Color;
                RefreshLayeredForm();
            }
        }

        private void ImageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = imageColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                imageColor = colorDialog1.Color;
                RefreshLayeredForm();
            }
        }

        private void settingsBox_Click(object sender, EventArgs e)
        {
            Win32.Point p = new Win32.Point();
            Win32.GetCursorPos(ref p);
            contextMenuStrip1.Show(p.X, p.Y);
        }

        private string GetAssemblyProduct()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyProductAttribute)attributes[0]).Product;
        }

        private void RunStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = GetAssemblyProduct();
            if (name == "") return;
            RegistryKey keyRun = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            try
            {
                runStartup = !runStartup;
                //RunStartupToolStripMenuItem.Checked = runStartup;
                if (runStartup)
                {
                    string value = Assembly.GetExecutingAssembly().Location;
                    keyRun.SetValue(name, value);
                }
                else
                {
                    keyRun.DeleteValue(name, false);
                }
            }
            finally
            {
                keyRun.Close();
            }
        }

        private void versionLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.shenturk.com/?ref=havadurumu");
        }

        private void UseCompatibleTextRenderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            useCompatibleTextRendering = !useCompatibleTextRendering;
            //UseCompatibleTextRenderingToolStripMenuItem.Checked = useCompatibleTextRendering;
            RefreshLayeredForm();
        }

        private void locationLabel_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            Font font = new Font(label.Font, label.Font.Style | FontStyle.Underline);
            label.Font = font;
            RefreshLayeredForm();
        }

        private void locationLabel_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            Font font = new Font(label.Font, label.Font.Style & ~FontStyle.Underline);
            label.Font = font;
            RefreshLayeredForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            /*
            if (e.CloseReason = CloseReason.WindowsShutDown)
            {
            }
            */
        }

    }
}
