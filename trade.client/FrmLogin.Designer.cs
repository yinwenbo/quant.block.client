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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConfigDel = new System.Windows.Forms.Button();
            this.ConfigAdd = new System.Windows.Forms.Button();
            this.ConfigGrid = new System.Windows.Forms.PropertyGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.ShowConfig = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountList = new System.Windows.Forms.ComboBox();
            this.ConfigList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConfigDel);
            this.groupBox1.Controls.Add(this.ConfigAdd);
            this.groupBox1.Controls.Add(this.ConfigGrid);
            this.groupBox1.Location = new System.Drawing.Point(242, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器配置";
            // 
            // ConfigDel
            // 
            this.ConfigDel.Location = new System.Drawing.Point(300, 212);
            this.ConfigDel.Name = "ConfigDel";
            this.ConfigDel.Size = new System.Drawing.Size(59, 23);
            this.ConfigDel.TabIndex = 8;
            this.ConfigDel.Text = "删除";
            this.ConfigDel.UseVisualStyleBackColor = true;
            this.ConfigDel.Click += new System.EventHandler(this.ConfigDel_Click);
            // 
            // ConfigAdd
            // 
            this.ConfigAdd.Location = new System.Drawing.Point(235, 212);
            this.ConfigAdd.Name = "ConfigAdd";
            this.ConfigAdd.Size = new System.Drawing.Size(59, 23);
            this.ConfigAdd.TabIndex = 7;
            this.ConfigAdd.Text = "添加";
            this.ConfigAdd.UseVisualStyleBackColor = true;
            this.ConfigAdd.Click += new System.EventHandler(this.ConfigAdd_Click);
            // 
            // ConfigGrid
            // 
            this.ConfigGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigGrid.HelpVisible = false;
            this.ConfigGrid.Location = new System.Drawing.Point(6, 20);
            this.ConfigGrid.Name = "ConfigGrid";
            this.ConfigGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.ConfigGrid.Size = new System.Drawing.Size(353, 186);
            this.ConfigGrid.TabIndex = 6;
            this.ConfigGrid.ToolbarVisible = false;
            this.ConfigGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ConfigGrid_PropertyValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(7, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 65);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(79, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "账户登录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 12;
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpAccount.Controls.Add(this.ShowConfig);
            this.grpAccount.Controls.Add(this.label6);
            this.grpAccount.Controls.Add(this.AccountList);
            this.grpAccount.Controls.Add(this.ConfigList);
            this.grpAccount.Controls.Add(this.label5);
            this.grpAccount.Controls.Add(this.label4);
            this.grpAccount.Controls.Add(this.Login);
            this.grpAccount.Controls.Add(this.txtPassword);
            this.grpAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAccount.Location = new System.Drawing.Point(7, 83);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(216, 170);
            this.grpAccount.TabIndex = 15;
            this.grpAccount.TabStop = false;
            // 
            // ShowConfig
            // 
            this.ShowConfig.AutoSize = true;
            this.ShowConfig.Location = new System.Drawing.Point(81, 121);
            this.ShowConfig.Name = "ShowConfig";
            this.ShowConfig.Size = new System.Drawing.Size(29, 12);
            this.ShowConfig.TabIndex = 6;
            this.ShowConfig.TabStop = true;
            this.ShowConfig.Text = "配置";
            this.ShowConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowConfig_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "配置:";
            // 
            // AccountList
            // 
            this.AccountList.FormattingEnabled = true;
            this.AccountList.Location = new System.Drawing.Point(83, 57);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(111, 20);
            this.AccountList.TabIndex = 3;
            // 
            // ConfigList
            // 
            this.ConfigList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigList.FormattingEnabled = true;
            this.ConfigList.Location = new System.Drawing.Point(83, 31);
            this.ConfigList.Name = "ConfigList";
            this.ConfigList.Size = new System.Drawing.Size(111, 20);
            this.ConfigList.TabIndex = 2;
            this.ConfigList.SelectedIndexChanged += new System.EventHandler(this.ConfigList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "账号:";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(114, 113);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(80, 28);
            this.Login.TabIndex = 5;
            this.Login.Text = "login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(111, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 265);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PropertyGrid ConfigGrid;
        private System.Windows.Forms.Button ConfigDel;
        private System.Windows.Forms.Button ConfigAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.LinkLabel ShowConfig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AccountList;
        private System.Windows.Forms.ComboBox ConfigList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox txtPassword;
    }
}