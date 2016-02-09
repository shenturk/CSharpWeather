namespace HavaDurumu
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loaderTimer = new System.Windows.Forms.Timer(this.components);
            this.tempLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.skyTextLabel = new System.Windows.Forms.Label();
            this.dayLabel1 = new System.Windows.Forms.Label();
            this.dayLabel2 = new System.Windows.Forms.Label();
            this.dayLabel3 = new System.Windows.Forms.Label();
            this.tempLabel1 = new System.Windows.Forms.Label();
            this.tempLabel2 = new System.Windows.Forms.Label();
            this.tempLabel3 = new System.Windows.Forms.Label();
            this.skytextLabel1 = new System.Windows.Forms.Label();
            this.skytextLabel2 = new System.Windows.Forms.Label();
            this.skytextLabel3 = new System.Windows.Forms.Label();
            this.feelslikeLabel = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ImageColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UseCompatibleTextRenderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RunStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowHideBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlwaysTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HibernateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyTimer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.skySmallPicture3 = new System.Windows.Forms.PictureBox();
            this.skySmallPicture2 = new System.Windows.Forms.PictureBox();
            this.skySmallPicture1 = new System.Windows.Forms.PictureBox();
            this.skyBigPicture = new System.Windows.Forms.PictureBox();
            this.backBox = new System.Windows.Forms.PictureBox();
            this.settingsBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.versionLabel = new System.Windows.Forms.Label();
            this.reflectionBox = new System.Windows.Forms.PictureBox();
            this.skytextLabel4 = new System.Windows.Forms.Label();
            this.tempLabel4 = new System.Windows.Forms.Label();
            this.skySmallPicture4 = new System.Windows.Forms.PictureBox();
            this.dayLabel4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skySmallPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skySmallPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skySmallPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyBigPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflectionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skySmallPicture4)).BeginInit();
            this.SuspendLayout();
            // 
            // loaderTimer
            // 
            this.loaderTimer.Interval = 50;
            this.loaderTimer.Tick += new System.EventHandler(this.loaderTimer_Tick);
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tempLabel.Enabled = false;
            this.tempLabel.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(29, 48);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(118, 61);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.Text = "--°";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.locationLabel.ForeColor = System.Drawing.Color.White;
            this.locationLabel.Location = new System.Drawing.Point(29, 30);
            this.locationLabel.MaximumSize = new System.Drawing.Size(174, 18);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(107, 18);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Bağlanılıyor...";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.locationLabel, "Şehir seçmek için tıklatın...");
            this.locationLabel.MouseLeave += new System.EventHandler(this.locationLabel_MouseLeave);
            this.locationLabel.Click += new System.EventHandler(this.locationLabel_Click);
            this.locationLabel.MouseEnter += new System.EventHandler(this.locationLabel_MouseEnter);
            // 
            // skyTextLabel
            // 
            this.skyTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skyTextLabel.Enabled = false;
            this.skyTextLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skyTextLabel.ForeColor = System.Drawing.Color.White;
            this.skyTextLabel.Location = new System.Drawing.Point(34, 96);
            this.skyTextLabel.Name = "skyTextLabel";
            this.skyTextLabel.Size = new System.Drawing.Size(169, 24);
            this.skyTextLabel.TabIndex = 4;
            this.skyTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dayLabel1
            // 
            this.dayLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dayLabel1.Enabled = false;
            this.dayLabel1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dayLabel1.ForeColor = System.Drawing.Color.White;
            this.dayLabel1.Location = new System.Drawing.Point(20, 142);
            this.dayLabel1.Name = "dayLabel1";
            this.dayLabel1.Size = new System.Drawing.Size(87, 21);
            this.dayLabel1.TabIndex = 5;
            this.dayLabel1.Text = "Pazartesi";
            this.dayLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayLabel2
            // 
            this.dayLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dayLabel2.Enabled = false;
            this.dayLabel2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dayLabel2.ForeColor = System.Drawing.Color.White;
            this.dayLabel2.Location = new System.Drawing.Point(20, 188);
            this.dayLabel2.Name = "dayLabel2";
            this.dayLabel2.Size = new System.Drawing.Size(87, 21);
            this.dayLabel2.TabIndex = 6;
            this.dayLabel2.Text = "Salı";
            this.dayLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayLabel3
            // 
            this.dayLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dayLabel3.Enabled = false;
            this.dayLabel3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dayLabel3.ForeColor = System.Drawing.Color.White;
            this.dayLabel3.Location = new System.Drawing.Point(20, 235);
            this.dayLabel3.Name = "dayLabel3";
            this.dayLabel3.Size = new System.Drawing.Size(87, 21);
            this.dayLabel3.TabIndex = 7;
            this.dayLabel3.Text = "Çarşamba";
            this.dayLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempLabel1
            // 
            this.tempLabel1.BackColor = System.Drawing.Color.Gray;
            this.tempLabel1.Enabled = false;
            this.tempLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tempLabel1.ForeColor = System.Drawing.Color.White;
            this.tempLabel1.Location = new System.Drawing.Point(147, 150);
            this.tempLabel1.Name = "tempLabel1";
            this.tempLabel1.Size = new System.Drawing.Size(66, 21);
            this.tempLabel1.TabIndex = 11;
            this.tempLabel1.Text = "--°/--°";
            this.tempLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempLabel2
            // 
            this.tempLabel2.BackColor = System.Drawing.Color.Gray;
            this.tempLabel2.Enabled = false;
            this.tempLabel2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tempLabel2.ForeColor = System.Drawing.Color.White;
            this.tempLabel2.Location = new System.Drawing.Point(147, 195);
            this.tempLabel2.Name = "tempLabel2";
            this.tempLabel2.Size = new System.Drawing.Size(66, 21);
            this.tempLabel2.TabIndex = 12;
            this.tempLabel2.Text = "--°/--°";
            this.tempLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempLabel3
            // 
            this.tempLabel3.BackColor = System.Drawing.Color.Gray;
            this.tempLabel3.Enabled = false;
            this.tempLabel3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tempLabel3.ForeColor = System.Drawing.Color.White;
            this.tempLabel3.Location = new System.Drawing.Point(147, 241);
            this.tempLabel3.Name = "tempLabel3";
            this.tempLabel3.Size = new System.Drawing.Size(66, 21);
            this.tempLabel3.TabIndex = 13;
            this.tempLabel3.Text = "--°/--°";
            this.tempLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skytextLabel1
            // 
            this.skytextLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skytextLabel1.Enabled = false;
            this.skytextLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skytextLabel1.ForeColor = System.Drawing.Color.White;
            this.skytextLabel1.Location = new System.Drawing.Point(20, 163);
            this.skytextLabel1.Name = "skytextLabel1";
            this.skytextLabel1.Size = new System.Drawing.Size(87, 13);
            this.skytextLabel1.TabIndex = 14;
            this.skytextLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skytextLabel2
            // 
            this.skytextLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skytextLabel2.Enabled = false;
            this.skytextLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skytextLabel2.ForeColor = System.Drawing.Color.White;
            this.skytextLabel2.Location = new System.Drawing.Point(20, 209);
            this.skytextLabel2.Name = "skytextLabel2";
            this.skytextLabel2.Size = new System.Drawing.Size(87, 13);
            this.skytextLabel2.TabIndex = 15;
            this.skytextLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skytextLabel3
            // 
            this.skytextLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skytextLabel3.Enabled = false;
            this.skytextLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skytextLabel3.ForeColor = System.Drawing.Color.White;
            this.skytextLabel3.Location = new System.Drawing.Point(20, 254);
            this.skytextLabel3.Name = "skytextLabel3";
            this.skytextLabel3.Size = new System.Drawing.Size(87, 13);
            this.skytextLabel3.TabIndex = 16;
            this.skytextLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // feelslikeLabel
            // 
            this.feelslikeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.feelslikeLabel.Enabled = false;
            this.feelslikeLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feelslikeLabel.ForeColor = System.Drawing.Color.White;
            this.feelslikeLabel.Location = new System.Drawing.Point(34, 117);
            this.feelslikeLabel.Name = "feelslikeLabel";
            this.feelslikeLabel.Size = new System.Drawing.Size(113, 15);
            this.feelslikeLabel.TabIndex = 17;
            this.feelslikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.UpdateToolStripMenuItem,
            this.toolStripSeparator1,
            this.SelectCityToolStripMenuItem,
            this.toolStripSeparator2,
            this.ImageColorToolStripMenuItem,
            this.ForeColorToolStripMenuItem,
            this.UseCompatibleTextRenderingToolStripMenuItem,
            this.toolStripMenuItem2,
            this.RunStartupToolStripMenuItem,
            this.toolStripSeparator3,
            this.ShowHideBackgroundToolStripMenuItem,
            this.AlwaysTopToolStripMenuItem,
            this.HibernateToolStripMenuItem,
            this.toolStripMenuItem3,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 282);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.AboutToolStripMenuItem.Text = "Hakkında";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 6);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.UpdateToolStripMenuItem.Text = "Güncelle";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // SelectCityToolStripMenuItem
            // 
            this.SelectCityToolStripMenuItem.Name = "SelectCityToolStripMenuItem";
            this.SelectCityToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.SelectCityToolStripMenuItem.Text = "Şehir Seç";
            this.SelectCityToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // ImageColorToolStripMenuItem
            // 
            this.ImageColorToolStripMenuItem.Name = "ImageColorToolStripMenuItem";
            this.ImageColorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ImageColorToolStripMenuItem.Text = "Resim Rengi";
            this.ImageColorToolStripMenuItem.Click += new System.EventHandler(this.ImageColorToolStripMenuItem_Click);
            // 
            // ForeColorToolStripMenuItem
            // 
            this.ForeColorToolStripMenuItem.Name = "ForeColorToolStripMenuItem";
            this.ForeColorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ForeColorToolStripMenuItem.Text = "Yazı Rengi";
            this.ForeColorToolStripMenuItem.Click += new System.EventHandler(this.ForeColorToolStripMenuItem_Click);
            // 
            // UseCompatibleTextRenderingToolStripMenuItem
            // 
            this.UseCompatibleTextRenderingToolStripMenuItem.CheckOnClick = true;
            this.UseCompatibleTextRenderingToolStripMenuItem.Name = "UseCompatibleTextRenderingToolStripMenuItem";
            this.UseCompatibleTextRenderingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.UseCompatibleTextRenderingToolStripMenuItem.Text = "Keskin Yazı Biçimi";
            this.UseCompatibleTextRenderingToolStripMenuItem.Click += new System.EventHandler(this.UseCompatibleTextRenderingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // RunStartupToolStripMenuItem
            // 
            this.RunStartupToolStripMenuItem.CheckOnClick = true;
            this.RunStartupToolStripMenuItem.Name = "RunStartupToolStripMenuItem";
            this.RunStartupToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.RunStartupToolStripMenuItem.Text = "Otomatik Başlat";
            this.RunStartupToolStripMenuItem.Click += new System.EventHandler(this.RunStartupToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // ShowHideBackgroundToolStripMenuItem
            // 
            this.ShowHideBackgroundToolStripMenuItem.Name = "ShowHideBackgroundToolStripMenuItem";
            this.ShowHideBackgroundToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ShowHideBackgroundToolStripMenuItem.Text = "Arkaplanı Gizle";
            this.ShowHideBackgroundToolStripMenuItem.Click += new System.EventHandler(this.ShowHideBackgroundToolStripMenuItem_Click);
            // 
            // AlwaysTopToolStripMenuItem
            // 
            this.AlwaysTopToolStripMenuItem.CheckOnClick = true;
            this.AlwaysTopToolStripMenuItem.Name = "AlwaysTopToolStripMenuItem";
            this.AlwaysTopToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.AlwaysTopToolStripMenuItem.Text = "Her Zaman Üstte";
            this.AlwaysTopToolStripMenuItem.Click += new System.EventHandler(this.AlwaysTopToolStripMenuItem_Click);
            // 
            // HibernateToolStripMenuItem
            // 
            this.HibernateToolStripMenuItem.Name = "HibernateToolStripMenuItem";
            this.HibernateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.HibernateToolStripMenuItem.Text = "Kış Uykusu";
            this.HibernateToolStripMenuItem.Click += new System.EventHandler(this.HibernateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ExitToolStripMenuItem.Text = "Kapat";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // keyTimer
            // 
            this.keyTimer.Tick += new System.EventHandler(this.keyTimer_Tick);
            // 
            // skySmallPicture3
            // 
            this.skySmallPicture3.Enabled = false;
            this.skySmallPicture3.Image = global::HavaDurumu.Properties.Resources.na;
            this.skySmallPicture3.Location = new System.Drawing.Point(107, 232);
            this.skySmallPicture3.Name = "skySmallPicture3";
            this.skySmallPicture3.Size = new System.Drawing.Size(40, 40);
            this.skySmallPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skySmallPicture3.TabIndex = 10;
            this.skySmallPicture3.TabStop = false;
            // 
            // skySmallPicture2
            // 
            this.skySmallPicture2.Enabled = false;
            this.skySmallPicture2.Image = global::HavaDurumu.Properties.Resources.na;
            this.skySmallPicture2.Location = new System.Drawing.Point(107, 185);
            this.skySmallPicture2.Name = "skySmallPicture2";
            this.skySmallPicture2.Size = new System.Drawing.Size(40, 40);
            this.skySmallPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skySmallPicture2.TabIndex = 9;
            this.skySmallPicture2.TabStop = false;
            // 
            // skySmallPicture1
            // 
            this.skySmallPicture1.Enabled = false;
            this.skySmallPicture1.Image = global::HavaDurumu.Properties.Resources.na;
            this.skySmallPicture1.Location = new System.Drawing.Point(107, 139);
            this.skySmallPicture1.Name = "skySmallPicture1";
            this.skySmallPicture1.Size = new System.Drawing.Size(40, 40);
            this.skySmallPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skySmallPicture1.TabIndex = 8;
            this.skySmallPicture1.TabStop = false;
            // 
            // skyBigPicture
            // 
            this.skyBigPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skyBigPicture.Enabled = false;
            this.skyBigPicture.Image = global::HavaDurumu.Properties.Resources.na;
            this.skyBigPicture.Location = new System.Drawing.Point(88, 11);
            this.skyBigPicture.Name = "skyBigPicture";
            this.skyBigPicture.Size = new System.Drawing.Size(120, 120);
            this.skyBigPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.skyBigPicture.TabIndex = 1;
            this.skyBigPicture.TabStop = false;
            // 
            // backBox
            // 
            this.backBox.Enabled = false;
            this.backBox.Image = global::HavaDurumu.Properties.Resources.BackLight5;
            this.backBox.Location = new System.Drawing.Point(0, 0);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(230, 348);
            this.backBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backBox.TabIndex = 0;
            this.backBox.TabStop = false;
            this.backBox.Tag = "";
            // 
            // settingsBox
            // 
            this.settingsBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBox.Image = ((System.Drawing.Image)(resources.GetObject("settingsBox.Image")));
            this.settingsBox.Location = new System.Drawing.Point(187, 23);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(20, 20);
            this.settingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.settingsBox.TabIndex = 18;
            this.settingsBox.TabStop = false;
            this.settingsBox.Tag = "1";
            this.toolTip1.SetToolTip(this.settingsBox, "Seçenekler");
            this.settingsBox.Click += new System.EventHandler(this.settingsBox_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.versionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(22, 316);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(185, 13);
            this.versionLabel.TabIndex = 19;
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.versionLabel.UseCompatibleTextRendering = true;
            this.versionLabel.Visible = false;
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // reflectionBox
            // 
            this.reflectionBox.Enabled = false;
            this.reflectionBox.Image = global::HavaDurumu.Properties.Resources.Reflect;
            this.reflectionBox.Location = new System.Drawing.Point(0, 0);
            this.reflectionBox.Name = "reflectionBox";
            this.reflectionBox.Size = new System.Drawing.Size(230, 144);
            this.reflectionBox.TabIndex = 20;
            this.reflectionBox.TabStop = false;
            // 
            // skytextLabel4
            // 
            this.skytextLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skytextLabel4.Enabled = false;
            this.skytextLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skytextLabel4.ForeColor = System.Drawing.Color.White;
            this.skytextLabel4.Location = new System.Drawing.Point(19, 299);
            this.skytextLabel4.Name = "skytextLabel4";
            this.skytextLabel4.Size = new System.Drawing.Size(87, 13);
            this.skytextLabel4.TabIndex = 24;
            this.skytextLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempLabel4
            // 
            this.tempLabel4.BackColor = System.Drawing.Color.Gray;
            this.tempLabel4.Enabled = false;
            this.tempLabel4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tempLabel4.ForeColor = System.Drawing.Color.White;
            this.tempLabel4.Location = new System.Drawing.Point(146, 286);
            this.tempLabel4.Name = "tempLabel4";
            this.tempLabel4.Size = new System.Drawing.Size(66, 21);
            this.tempLabel4.TabIndex = 23;
            this.tempLabel4.Text = "--°/--°";
            this.tempLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skySmallPicture4
            // 
            this.skySmallPicture4.Enabled = false;
            this.skySmallPicture4.Image = global::HavaDurumu.Properties.Resources.na;
            this.skySmallPicture4.Location = new System.Drawing.Point(106, 277);
            this.skySmallPicture4.Name = "skySmallPicture4";
            this.skySmallPicture4.Size = new System.Drawing.Size(40, 40);
            this.skySmallPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skySmallPicture4.TabIndex = 22;
            this.skySmallPicture4.TabStop = false;
            // 
            // dayLabel4
            // 
            this.dayLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dayLabel4.Enabled = false;
            this.dayLabel4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dayLabel4.ForeColor = System.Drawing.Color.White;
            this.dayLabel4.Location = new System.Drawing.Point(19, 280);
            this.dayLabel4.Name = "dayLabel4";
            this.dayLabel4.Size = new System.Drawing.Size(87, 21);
            this.dayLabel4.TabIndex = 21;
            this.dayLabel4.Text = "Perşembe";
            this.dayLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 348);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.skytextLabel4);
            this.Controls.Add(this.tempLabel4);
            this.Controls.Add(this.skySmallPicture4);
            this.Controls.Add(this.dayLabel4);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.feelslikeLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.skytextLabel3);
            this.Controls.Add(this.skytextLabel2);
            this.Controls.Add(this.skytextLabel1);
            this.Controls.Add(this.tempLabel3);
            this.Controls.Add(this.tempLabel2);
            this.Controls.Add(this.tempLabel1);
            this.Controls.Add(this.skySmallPicture3);
            this.Controls.Add(this.skySmallPicture2);
            this.Controls.Add(this.skySmallPicture1);
            this.Controls.Add(this.dayLabel3);
            this.Controls.Add(this.dayLabel2);
            this.Controls.Add(this.dayLabel1);
            this.Controls.Add(this.skyTextLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.skyBigPicture);
            this.Controls.Add(this.reflectionBox);
            this.Controls.Add(this.backBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hava Durumu";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skySmallPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skySmallPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skySmallPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyBigPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflectionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skySmallPicture4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer loaderTimer;
        private System.Windows.Forms.PictureBox backBox;
        private System.Windows.Forms.PictureBox skyBigPicture;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label skyTextLabel;
        private System.Windows.Forms.Label dayLabel1;
        private System.Windows.Forms.Label dayLabel2;
        private System.Windows.Forms.Label dayLabel3;
        private System.Windows.Forms.PictureBox skySmallPicture1;
        private System.Windows.Forms.PictureBox skySmallPicture2;
        private System.Windows.Forms.PictureBox skySmallPicture3;
        private System.Windows.Forms.Label tempLabel1;
        private System.Windows.Forms.Label tempLabel2;
        private System.Windows.Forms.Label tempLabel3;
        private System.Windows.Forms.Label skytextLabel1;
        private System.Windows.Forms.Label skytextLabel2;
        private System.Windows.Forms.Label skytextLabel3;
        private System.Windows.Forms.Label feelslikeLabel;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SelectCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HibernateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Timer keyTimer;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem ImageColorToolStripMenuItem;
        private System.Windows.Forms.PictureBox settingsBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlwaysTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowHideBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ForeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem UseCompatibleTextRenderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox reflectionBox;
        private System.Windows.Forms.Label skytextLabel4;
        private System.Windows.Forms.Label tempLabel4;
        private System.Windows.Forms.PictureBox skySmallPicture4;
        private System.Windows.Forms.Label dayLabel4;
    }
}

