namespace trade.client
{
    partial class FrmLogin
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
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.ShowConfig = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountList = new System.Windows.Forms.ComboBox();
            this.TradeServerList = new System.Windows.Forms.ComboBox();
            this.Level2ServerList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TradeItemSave = new System.Windows.Forms.Button();
            this.TradeItemDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TradeQueryPort = new System.Windows.Forms.TextBox();
            this.TradeReportPort = new System.Windows.Forms.TextBox();
            this.TradeOrderPort = new System.Windows.Forms.TextBox();
            this.TradeHost = new System.Windows.Forms.TextBox();
            this.TradeConfigList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Level2Address = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Level2ItemDelete = new System.Windows.Forms.Button();
            this.Level2ItemSave = new System.Windows.Forms.Button();
            this.Level2ConfigList = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grpAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.ShowConfig);
            this.grpAccount.Controls.Add(this.label7);
            this.grpAccount.Controls.Add(this.label6);
            this.grpAccount.Controls.Add(this.AccountList);
            this.grpAccount.Controls.Add(this.TradeServerList);
            this.grpAccount.Controls.Add(this.Level2ServerList);
            this.grpAccount.Controls.Add(this.label5);
            this.grpAccount.Controls.Add(this.label4);
            this.grpAccount.Controls.Add(this.Login);
            this.grpAccount.Controls.Add(this.txtPassword);
            this.grpAccount.Location = new System.Drawing.Point(12, 22);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(217, 177);
            this.grpAccount.TabIndex = 2;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "账户";
            // 
            // ShowConfig
            // 
            this.ShowConfig.AutoSize = true;
            this.ShowConfig.Location = new System.Drawing.Point(55, 152);
            this.ShowConfig.Name = "ShowConfig";
            this.ShowConfig.Size = new System.Drawing.Size(53, 12);
            this.ShowConfig.TabIndex = 6;
            this.ShowConfig.TabStop = true;
            this.ShowConfig.Text = "服务配置";
            this.ShowConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowConfig_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "行情服务:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "交易服务:";
            // 
            // AccountList
            // 
            this.AccountList.FormattingEnabled = true;
            this.AccountList.Location = new System.Drawing.Point(83, 81);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(111, 20);
            this.AccountList.TabIndex = 3;
            // 
            // TradeServerList
            // 
            this.TradeServerList.FormattingEnabled = true;
            this.TradeServerList.Location = new System.Drawing.Point(83, 55);
            this.TradeServerList.Name = "TradeServerList";
            this.TradeServerList.Size = new System.Drawing.Size(111, 20);
            this.TradeServerList.TabIndex = 2;
            // 
            // Level2ServerList
            // 
            this.Level2ServerList.FormattingEnabled = true;
            this.Level2ServerList.Location = new System.Drawing.Point(83, 29);
            this.Level2ServerList.Name = "Level2ServerList";
            this.Level2ServerList.Size = new System.Drawing.Size(111, 20);
            this.Level2ServerList.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "账号:";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(114, 139);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(80, 28);
            this.Login.TabIndex = 5;
            this.Login.Text = "login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(111, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(254, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器配置";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(252, 157);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TradeItemSave);
            this.tabPage1.Controls.Add(this.TradeItemDelete);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TradeQueryPort);
            this.tabPage1.Controls.Add(this.TradeReportPort);
            this.tabPage1.Controls.Add(this.TradeOrderPort);
            this.tabPage1.Controls.Add(this.TradeHost);
            this.tabPage1.Controls.Add(this.TradeConfigList);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(244, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "交易";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TradeItemSave
            // 
            this.TradeItemSave.Location = new System.Drawing.Point(189, 98);
            this.TradeItemSave.Name = "TradeItemSave";
            this.TradeItemSave.Size = new System.Drawing.Size(47, 23);
            this.TradeItemSave.TabIndex = 15;
            this.TradeItemSave.Text = "保存";
            this.TradeItemSave.UseVisualStyleBackColor = true;
            this.TradeItemSave.Click += new System.EventHandler(this.TradeItemSave_Click);
            // 
            // TradeItemDelete
            // 
            this.TradeItemDelete.Location = new System.Drawing.Point(136, 98);
            this.TradeItemDelete.Name = "TradeItemDelete";
            this.TradeItemDelete.Size = new System.Drawing.Size(47, 23);
            this.TradeItemDelete.TabIndex = 16;
            this.TradeItemDelete.Text = "删除";
            this.TradeItemDelete.UseVisualStyleBackColor = true;
            this.TradeItemDelete.Click += new System.EventHandler(this.TradeItemDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "主机:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "查询:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "回报:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "交易:";
            // 
            // TradeQueryPort
            // 
            this.TradeQueryPort.Location = new System.Drawing.Point(202, 65);
            this.TradeQueryPort.Name = "TradeQueryPort";
            this.TradeQueryPort.Size = new System.Drawing.Size(34, 21);
            this.TradeQueryPort.TabIndex = 14;
            this.TradeQueryPort.Text = "9003";
            // 
            // TradeReportPort
            // 
            this.TradeReportPort.Location = new System.Drawing.Point(124, 65);
            this.TradeReportPort.Name = "TradeReportPort";
            this.TradeReportPort.Size = new System.Drawing.Size(34, 21);
            this.TradeReportPort.TabIndex = 13;
            this.TradeReportPort.Text = "9002";
            // 
            // TradeOrderPort
            // 
            this.TradeOrderPort.Location = new System.Drawing.Point(45, 65);
            this.TradeOrderPort.Name = "TradeOrderPort";
            this.TradeOrderPort.Size = new System.Drawing.Size(34, 21);
            this.TradeOrderPort.TabIndex = 12;
            this.TradeOrderPort.Text = "9001";
            // 
            // TradeHost
            // 
            this.TradeHost.Location = new System.Drawing.Point(45, 35);
            this.TradeHost.Name = "TradeHost";
            this.TradeHost.Size = new System.Drawing.Size(191, 21);
            this.TradeHost.TabIndex = 11;
            // 
            // TradeConfigList
            // 
            this.TradeConfigList.FormattingEnabled = true;
            this.TradeConfigList.Location = new System.Drawing.Point(45, 9);
            this.TradeConfigList.Name = "TradeConfigList";
            this.TradeConfigList.Size = new System.Drawing.Size(191, 20);
            this.TradeConfigList.TabIndex = 10;
            this.TradeConfigList.SelectedIndexChanged += new System.EventHandler(this.TradeConfigList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "配置:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Level2Address);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.Level2ItemDelete);
            this.tabPage2.Controls.Add(this.Level2ItemSave);
            this.tabPage2.Controls.Add(this.Level2ConfigList);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(244, 131);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "L2行情";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Level2Address
            // 
            this.Level2Address.Location = new System.Drawing.Point(59, 45);
            this.Level2Address.Name = "Level2Address";
            this.Level2Address.Size = new System.Drawing.Size(177, 21);
            this.Level2Address.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 18;
            this.label16.Text = "地址:";
            // 
            // Level2ItemDelete
            // 
            this.Level2ItemDelete.Location = new System.Drawing.Point(136, 98);
            this.Level2ItemDelete.Name = "Level2ItemDelete";
            this.Level2ItemDelete.Size = new System.Drawing.Size(47, 23);
            this.Level2ItemDelete.TabIndex = 23;
            this.Level2ItemDelete.Text = "删除";
            this.Level2ItemDelete.UseVisualStyleBackColor = true;
            this.Level2ItemDelete.Click += new System.EventHandler(this.Level2ItemDelete_Click);
            // 
            // Level2ItemSave
            // 
            this.Level2ItemSave.Location = new System.Drawing.Point(189, 98);
            this.Level2ItemSave.Name = "Level2ItemSave";
            this.Level2ItemSave.Size = new System.Drawing.Size(47, 23);
            this.Level2ItemSave.TabIndex = 22;
            this.Level2ItemSave.Text = "保存";
            this.Level2ItemSave.UseVisualStyleBackColor = true;
            this.Level2ItemSave.Click += new System.EventHandler(this.Level2ItemSave_Click);
            // 
            // Level2ConfigList
            // 
            this.Level2ConfigList.FormattingEnabled = true;
            this.Level2ConfigList.Location = new System.Drawing.Point(59, 13);
            this.Level2ConfigList.Name = "Level2ConfigList";
            this.Level2ConfigList.Size = new System.Drawing.Size(177, 20);
            this.Level2ConfigList.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "配置:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 217);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AccountList;
        private System.Windows.Forms.ComboBox TradeServerList;
        private System.Windows.Forms.ComboBox Level2ServerList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TradeQueryPort;
        private System.Windows.Forms.TextBox TradeReportPort;
        private System.Windows.Forms.TextBox TradeOrderPort;
        private System.Windows.Forms.TextBox TradeHost;
        private System.Windows.Forms.ComboBox TradeConfigList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button TradeItemSave;
        private System.Windows.Forms.Button TradeItemDelete;
        private System.Windows.Forms.Button Level2ItemDelete;
        private System.Windows.Forms.Button Level2ItemSave;
        private System.Windows.Forms.ComboBox Level2ConfigList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Level2Address;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel ShowConfig;
    }
}