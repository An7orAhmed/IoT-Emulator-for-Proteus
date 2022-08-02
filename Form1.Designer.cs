namespace IoT_Emulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.PostCTCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListenerList = new System.Windows.Forms.FlowLayoutPanel();
            this.ListenAddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListenInterval = new System.Windows.Forms.NumericUpDown();
            this.ListenToTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AuthTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioPOST = new System.Windows.Forms.RadioButton();
            this.radioGET = new System.Windows.Forms.RadioButton();
            this.UrlSetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.URLTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BlynkRunBtn = new System.Windows.Forms.Button();
            this.PortListCombo = new System.Windows.Forms.ComboBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.IoTTab = new System.Windows.Forms.TabPage();
            this.UpdateLbl = new System.Windows.Forms.Label();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.TerminalTab = new System.Windows.Forms.TabPage();
            this.RemoveCmdBtn = new System.Windows.Forms.Button();
            this.AddCmdTxt = new System.Windows.Forms.TextBox();
            this.SendTxt = new System.Windows.Forms.TextBox();
            this.TerminalTxt = new System.Windows.Forms.RichTextBox();
            this.AddCmdBtn = new System.Windows.Forms.Button();
            this.CommandList = new System.Windows.Forms.FlowLayoutPanel();
            this.SendBtn = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.GSMTab = new System.Windows.Forms.TabPage();
            this.GSMPanel = new System.Windows.Forms.Panel();
            this.GSMSMSBtn = new System.Windows.Forms.Button();
            this.GSMCallBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.GSMMSGTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GSMNumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneTerminalTxt = new System.Windows.Forms.RichTextBox();
            this.LoopCheck = new System.Windows.Forms.CheckBox();
            this.SettingsTab.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListenInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.IoTTab.SuspendLayout();
            this.TerminalTab.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.GSMTab.SuspendLayout();
            this.GSMPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsTab.Controls.Add(this.SettingPanel);
            this.SettingsTab.Location = new System.Drawing.Point(4, 29);
            this.SettingsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsTab.Size = new System.Drawing.Size(856, 568);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            // 
            // SettingPanel
            // 
            this.SettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SettingPanel.BackColor = System.Drawing.Color.White;
            this.SettingPanel.Controls.Add(this.PostCTCombo);
            this.SettingPanel.Controls.Add(this.label6);
            this.SettingPanel.Controls.Add(this.linkLabel1);
            this.SettingPanel.Controls.Add(this.groupBox3);
            this.SettingPanel.Controls.Add(this.groupBox2);
            this.SettingPanel.Controls.Add(this.groupBox1);
            this.SettingPanel.Location = new System.Drawing.Point(8, 8);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(840, 552);
            this.SettingPanel.TabIndex = 0;
            // 
            // PostCTCombo
            // 
            this.PostCTCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PostCTCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostCTCombo.FormattingEnabled = true;
            this.PostCTCombo.Items.AddRange(new object[] {
            "application/x-www-form-urlencoded",
            "application/json",
            "application/xml",
            "text/html",
            "text/plain",
            "text/csv"});
            this.PostCTCombo.Location = new System.Drawing.Point(343, 521);
            this.PostCTCombo.Name = "PostCTCombo";
            this.PostCTCombo.Size = new System.Drawing.Size(275, 28);
            this.PostCTCombo.TabIndex = 15;
            this.PostCTCombo.SelectedIndexChanged += new System.EventHandler(this.PostCTCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "POST -> example.com?data   |   Content-type:\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(633, 524);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(203, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developed by Antor Ahmed";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.LoopCheck);
            this.groupBox3.Controls.Add(this.ListenerList);
            this.groupBox3.Controls.Add(this.ListenAddBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ListenInterval);
            this.groupBox3.Controls.Add(this.ListenToTxt);
            this.groupBox3.Location = new System.Drawing.Point(3, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(833, 360);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Web Listener";
            // 
            // ListenerList
            // 
            this.ListenerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListenerList.AutoScroll = true;
            this.ListenerList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListenerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenerList.Location = new System.Drawing.Point(19, 72);
            this.ListenerList.Name = "ListenerList";
            this.ListenerList.Padding = new System.Windows.Forms.Padding(10);
            this.ListenerList.Size = new System.Drawing.Size(788, 268);
            this.ListenerList.TabIndex = 5;
            // 
            // ListenAddBtn
            // 
            this.ListenAddBtn.Location = new System.Drawing.Point(716, 30);
            this.ListenAddBtn.Name = "ListenAddBtn";
            this.ListenAddBtn.Size = new System.Drawing.Size(91, 27);
            this.ListenAddBtn.TabIndex = 4;
            this.ListenAddBtn.Text = "Add";
            this.ListenAddBtn.UseVisualStyleBackColor = true;
            this.ListenAddBtn.Click += new System.EventHandler(this.ListenAddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Interval:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Listen to:";
            // 
            // ListenInterval
            // 
            this.ListenInterval.Location = new System.Drawing.Point(616, 31);
            this.ListenInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.ListenInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ListenInterval.Name = "ListenInterval";
            this.ListenInterval.Size = new System.Drawing.Size(82, 26);
            this.ListenInterval.TabIndex = 1;
            this.ListenInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListenInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ListenToTxt
            // 
            this.ListenToTxt.Location = new System.Drawing.Point(95, 30);
            this.ListenToTxt.Name = "ListenToTxt";
            this.ListenToTxt.Size = new System.Drawing.Size(369, 26);
            this.ListenToTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.AuthTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioPOST);
            this.groupBox2.Controls.Add(this.radioGET);
            this.groupBox2.Controls.Add(this.UrlSetBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.URLTxt);
            this.groupBox2.Location = new System.Drawing.Point(337, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 143);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Website Setup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Auth:";
            // 
            // AuthTxt
            // 
            this.AuthTxt.Location = new System.Drawing.Point(85, 96);
            this.AuthTxt.Name = "AuthTxt";
            this.AuthTxt.Size = new System.Drawing.Size(269, 26);
            this.AuthTxt.TabIndex = 6;
            this.AuthTxt.TextChanged += new System.EventHandler(this.AuthTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Method:";
            // 
            // radioPOST
            // 
            this.radioPOST.AutoSize = true;
            this.radioPOST.Location = new System.Drawing.Point(162, 66);
            this.radioPOST.Name = "radioPOST";
            this.radioPOST.Size = new System.Drawing.Size(69, 24);
            this.radioPOST.TabIndex = 4;
            this.radioPOST.Text = "POST";
            this.radioPOST.UseVisualStyleBackColor = true;
            this.radioPOST.CheckedChanged += new System.EventHandler(this.radioPOST_CheckedChanged);
            // 
            // radioGET
            // 
            this.radioGET.AutoSize = true;
            this.radioGET.Checked = true;
            this.radioGET.Location = new System.Drawing.Point(85, 66);
            this.radioGET.Name = "radioGET";
            this.radioGET.Size = new System.Drawing.Size(60, 24);
            this.radioGET.TabIndex = 3;
            this.radioGET.TabStop = true;
            this.radioGET.Text = "GET";
            this.radioGET.UseVisualStyleBackColor = true;
            this.radioGET.CheckedChanged += new System.EventHandler(this.radioGET_CheckedChanged);
            // 
            // UrlSetBtn
            // 
            this.UrlSetBtn.Location = new System.Drawing.Point(371, 77);
            this.UrlSetBtn.Name = "UrlSetBtn";
            this.UrlSetBtn.Size = new System.Drawing.Size(107, 47);
            this.UrlSetBtn.TabIndex = 2;
            this.UrlSetBtn.Text = "Set";
            this.UrlSetBtn.UseVisualStyleBackColor = true;
            this.UrlSetBtn.Click += new System.EventHandler(this.UrlSetBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL:";
            // 
            // URLTxt
            // 
            this.URLTxt.Location = new System.Drawing.Point(85, 34);
            this.URLTxt.Name = "URLTxt";
            this.URLTxt.Size = new System.Drawing.Size(393, 26);
            this.URLTxt.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BlynkRunBtn);
            this.groupBox1.Controls.Add(this.PortListCombo);
            this.groupBox1.Controls.Add(this.RefreshBtn);
            this.groupBox1.Controls.Add(this.ConnectBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // BlynkRunBtn
            // 
            this.BlynkRunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlynkRunBtn.Location = new System.Drawing.Point(17, 77);
            this.BlynkRunBtn.Name = "BlynkRunBtn";
            this.BlynkRunBtn.Size = new System.Drawing.Size(130, 50);
            this.BlynkRunBtn.TabIndex = 3;
            this.BlynkRunBtn.Text = "Run Blynk";
            this.BlynkRunBtn.UseVisualStyleBackColor = true;
            this.BlynkRunBtn.Click += new System.EventHandler(this.BlynkRunBtn_Click);
            // 
            // PortListCombo
            // 
            this.PortListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortListCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortListCombo.FormattingEnabled = true;
            this.PortListCombo.Location = new System.Drawing.Point(17, 36);
            this.PortListCombo.Name = "PortListCombo";
            this.PortListCombo.Size = new System.Drawing.Size(156, 32);
            this.PortListCombo.TabIndex = 0;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(183, 34);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(114, 37);
            this.RefreshBtn.TabIndex = 1;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBtn.Location = new System.Drawing.Point(158, 77);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(139, 50);
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // IoTTab
            // 
            this.IoTTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IoTTab.Controls.Add(this.UpdateLbl);
            this.IoTTab.Controls.Add(this.Browser);
            this.IoTTab.Location = new System.Drawing.Point(4, 29);
            this.IoTTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IoTTab.Name = "IoTTab";
            this.IoTTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IoTTab.Size = new System.Drawing.Size(856, 568);
            this.IoTTab.TabIndex = 0;
            this.IoTTab.Text = "IoT Website";
            // 
            // UpdateLbl
            // 
            this.UpdateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateLbl.BackColor = System.Drawing.Color.White;
            this.UpdateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLbl.Location = new System.Drawing.Point(8, 246);
            this.UpdateLbl.Name = "UpdateLbl";
            this.UpdateLbl.Size = new System.Drawing.Size(840, 45);
            this.UpdateLbl.TabIndex = 1;
            this.UpdateLbl.Text = "Update URL from Settings tab...";
            this.UpdateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(4, 5);
            this.Browser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Browser.MinimumSize = new System.Drawing.Size(30, 31);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.Size = new System.Drawing.Size(848, 558);
            this.Browser.TabIndex = 0;
            // 
            // TerminalTab
            // 
            this.TerminalTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TerminalTab.Controls.Add(this.RemoveCmdBtn);
            this.TerminalTab.Controls.Add(this.AddCmdTxt);
            this.TerminalTab.Controls.Add(this.SendTxt);
            this.TerminalTab.Controls.Add(this.TerminalTxt);
            this.TerminalTab.Controls.Add(this.AddCmdBtn);
            this.TerminalTab.Controls.Add(this.CommandList);
            this.TerminalTab.Controls.Add(this.SendBtn);
            this.TerminalTab.Location = new System.Drawing.Point(4, 29);
            this.TerminalTab.Name = "TerminalTab";
            this.TerminalTab.Padding = new System.Windows.Forms.Padding(3);
            this.TerminalTab.Size = new System.Drawing.Size(856, 568);
            this.TerminalTab.TabIndex = 3;
            this.TerminalTab.Text = "Terminal";
            // 
            // RemoveCmdBtn
            // 
            this.RemoveCmdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveCmdBtn.BackColor = System.Drawing.Color.White;
            this.RemoveCmdBtn.Location = new System.Drawing.Point(823, 49);
            this.RemoveCmdBtn.Name = "RemoveCmdBtn";
            this.RemoveCmdBtn.Size = new System.Drawing.Size(26, 38);
            this.RemoveCmdBtn.TabIndex = 20;
            this.RemoveCmdBtn.Text = "-";
            this.RemoveCmdBtn.UseVisualStyleBackColor = false;
            this.RemoveCmdBtn.Click += new System.EventHandler(this.RemoveCmdBtn_Click);
            // 
            // AddCmdTxt
            // 
            this.AddCmdTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCmdTxt.BackColor = System.Drawing.Color.White;
            this.AddCmdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCmdTxt.Location = new System.Drawing.Point(680, 10);
            this.AddCmdTxt.Name = "AddCmdTxt";
            this.AddCmdTxt.Size = new System.Drawing.Size(169, 31);
            this.AddCmdTxt.TabIndex = 19;
            // 
            // SendTxt
            // 
            this.SendTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTxt.BackColor = System.Drawing.Color.White;
            this.SendTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTxt.Location = new System.Drawing.Point(7, 528);
            this.SendTxt.Name = "SendTxt";
            this.SendTxt.Size = new System.Drawing.Size(566, 31);
            this.SendTxt.TabIndex = 15;
            this.SendTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTxt_KeyDown);
            // 
            // TerminalTxt
            // 
            this.TerminalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TerminalTxt.BackColor = System.Drawing.Color.White;
            this.TerminalTxt.Location = new System.Drawing.Point(7, 10);
            this.TerminalTxt.Name = "TerminalTxt";
            this.TerminalTxt.ReadOnly = true;
            this.TerminalTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TerminalTxt.Size = new System.Drawing.Size(667, 505);
            this.TerminalTxt.TabIndex = 14;
            this.TerminalTxt.Text = "";
            // 
            // AddCmdBtn
            // 
            this.AddCmdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCmdBtn.BackColor = System.Drawing.Color.White;
            this.AddCmdBtn.Location = new System.Drawing.Point(680, 49);
            this.AddCmdBtn.Name = "AddCmdBtn";
            this.AddCmdBtn.Size = new System.Drawing.Size(137, 38);
            this.AddCmdBtn.TabIndex = 18;
            this.AddCmdBtn.Text = "Add Command";
            this.AddCmdBtn.UseVisualStyleBackColor = false;
            this.AddCmdBtn.Click += new System.EventHandler(this.AddCmdBtn_Click);
            // 
            // CommandList
            // 
            this.CommandList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandList.AutoScroll = true;
            this.CommandList.BackColor = System.Drawing.Color.White;
            this.CommandList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandList.Location = new System.Drawing.Point(680, 95);
            this.CommandList.Name = "CommandList";
            this.CommandList.Padding = new System.Windows.Forms.Padding(8);
            this.CommandList.Size = new System.Drawing.Size(169, 463);
            this.CommandList.TabIndex = 17;
            // 
            // SendBtn
            // 
            this.SendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBtn.BackColor = System.Drawing.Color.White;
            this.SendBtn.Location = new System.Drawing.Point(585, 528);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(89, 31);
            this.SendBtn.TabIndex = 16;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.TerminalTab);
            this.Tabs.Controls.Add(this.GSMTab);
            this.Tabs.Controls.Add(this.IoTTab);
            this.Tabs.Controls.Add(this.SettingsTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(864, 601);
            this.Tabs.TabIndex = 0;
            // 
            // GSMTab
            // 
            this.GSMTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GSMTab.Controls.Add(this.GSMPanel);
            this.GSMTab.Location = new System.Drawing.Point(4, 29);
            this.GSMTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GSMTab.Name = "GSMTab";
            this.GSMTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GSMTab.Size = new System.Drawing.Size(856, 568);
            this.GSMTab.TabIndex = 2;
            this.GSMTab.Text = "GSM Tools";
            // 
            // GSMPanel
            // 
            this.GSMPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GSMPanel.BackColor = System.Drawing.Color.White;
            this.GSMPanel.Controls.Add(this.GSMSMSBtn);
            this.GSMPanel.Controls.Add(this.GSMCallBtn);
            this.GSMPanel.Controls.Add(this.label9);
            this.GSMPanel.Controls.Add(this.GSMMSGTxt);
            this.GSMPanel.Controls.Add(this.label8);
            this.GSMPanel.Controls.Add(this.GSMNumberTxt);
            this.GSMPanel.Controls.Add(this.label1);
            this.GSMPanel.Controls.Add(this.PhoneTerminalTxt);
            this.GSMPanel.Location = new System.Drawing.Point(8, 8);
            this.GSMPanel.MaximumSize = new System.Drawing.Size(840, 552);
            this.GSMPanel.Name = "GSMPanel";
            this.GSMPanel.Size = new System.Drawing.Size(840, 552);
            this.GSMPanel.TabIndex = 0;
            // 
            // GSMSMSBtn
            // 
            this.GSMSMSBtn.Location = new System.Drawing.Point(565, 256);
            this.GSMSMSBtn.Name = "GSMSMSBtn";
            this.GSMSMSBtn.Size = new System.Drawing.Size(143, 47);
            this.GSMSMSBtn.TabIndex = 8;
            this.GSMSMSBtn.Text = "Send SMS";
            this.GSMSMSBtn.UseVisualStyleBackColor = true;
            this.GSMSMSBtn.Click += new System.EventHandler(this.GSMSMSBtn_Click);
            // 
            // GSMCallBtn
            // 
            this.GSMCallBtn.Location = new System.Drawing.Point(723, 256);
            this.GSMCallBtn.Name = "GSMCallBtn";
            this.GSMCallBtn.Size = new System.Drawing.Size(102, 47);
            this.GSMCallBtn.TabIndex = 7;
            this.GSMCallBtn.Text = "Call";
            this.GSMCallBtn.UseVisualStyleBackColor = true;
            this.GSMCallBtn.Click += new System.EventHandler(this.GSMCallBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Message Body:";
            // 
            // GSMMSGTxt
            // 
            this.GSMMSGTxt.Location = new System.Drawing.Point(457, 127);
            this.GSMMSGTxt.MaxLength = 160;
            this.GSMMSGTxt.Multiline = true;
            this.GSMMSGTxt.Name = "GSMMSGTxt";
            this.GSMMSGTxt.Size = new System.Drawing.Size(368, 114);
            this.GSMMSGTxt.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phone Number:";
            // 
            // GSMNumberTxt
            // 
            this.GSMNumberTxt.Location = new System.Drawing.Point(457, 70);
            this.GSMNumberTxt.Name = "GSMNumberTxt";
            this.GSMNumberTxt.Size = new System.Drawing.Size(368, 26);
            this.GSMNumberTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobile Phone Display:";
            // 
            // PhoneTerminalTxt
            // 
            this.PhoneTerminalTxt.BackColor = System.Drawing.Color.White;
            this.PhoneTerminalTxt.Location = new System.Drawing.Point(17, 44);
            this.PhoneTerminalTxt.Name = "PhoneTerminalTxt";
            this.PhoneTerminalTxt.ReadOnly = true;
            this.PhoneTerminalTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.PhoneTerminalTxt.Size = new System.Drawing.Size(420, 493);
            this.PhoneTerminalTxt.TabIndex = 1;
            this.PhoneTerminalTxt.Text = "";
            // 
            // LoopCheck
            // 
            this.LoopCheck.AutoSize = true;
            this.LoopCheck.Checked = true;
            this.LoopCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoopCheck.Location = new System.Drawing.Point(475, 32);
            this.LoopCheck.Name = "LoopCheck";
            this.LoopCheck.Size = new System.Drawing.Size(64, 24);
            this.LoopCheck.TabIndex = 6;
            this.LoopCheck.Text = "Loop";
            this.LoopCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 601);
            this.Controls.Add(this.Tabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(880, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoT Emulator for Proteus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SettingsTab.ResumeLayout(false);
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListenInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.IoTTab.ResumeLayout(false);
            this.TerminalTab.ResumeLayout(false);
            this.TerminalTab.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.GSMTab.ResumeLayout(false);
            this.GSMPanel.ResumeLayout(false);
            this.GSMPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TabPage IoTTab;
        private System.Windows.Forms.Label UpdateLbl;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.TabPage TerminalTab;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.Button RemoveCmdBtn;
        private System.Windows.Forms.TextBox AddCmdTxt;
        private System.Windows.Forms.TextBox SendTxt;
        private System.Windows.Forms.RichTextBox TerminalTxt;
        private System.Windows.Forms.Button AddCmdBtn;
        private System.Windows.Forms.FlowLayoutPanel CommandList;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TabPage GSMTab;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.ComboBox PostCTCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel ListenerList;
        private System.Windows.Forms.Button ListenAddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ListenInterval;
        private System.Windows.Forms.TextBox ListenToTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AuthTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioPOST;
        private System.Windows.Forms.RadioButton radioGET;
        private System.Windows.Forms.Button UrlSetBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox URLTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BlynkRunBtn;
        private System.Windows.Forms.ComboBox PortListCombo;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Panel GSMPanel;
        private System.Windows.Forms.RichTextBox PhoneTerminalTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GSMSMSBtn;
        private System.Windows.Forms.Button GSMCallBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GSMMSGTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GSMNumberTxt;
        private System.Windows.Forms.CheckBox LoopCheck;
    }
}

