namespace trade.client
{
    partial class FrmBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBar));
            this.Menus = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickBar = new System.Windows.Forms.ToolStrip();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Icon = new System.Windows.Forms.Panel();
            this.Menus.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menus
            // 
            this.Menus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Menus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu});
            this.Menus.Location = new System.Drawing.Point(0, 0);
            this.Menus.Name = "Menus";
            this.Menus.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Menus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menus.Size = new System.Drawing.Size(757, 24);
            this.Menus.TabIndex = 0;
            this.Menus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menus_ItemClicked);
            this.Menus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            // 
            // MainMenu
            // 
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExit});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(56, 24);
            this.MainMenu.Text = "客户端";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(100, 22);
            this.MenuExit.Text = "退出";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // QuickBar
            // 
            this.QuickBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuickBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuickBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.QuickBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.QuickBar.Location = new System.Drawing.Point(0, 33);
            this.QuickBar.Name = "QuickBar";
            this.QuickBar.Size = new System.Drawing.Size(834, 25);
            this.QuickBar.Stretch = true;
            this.QuickBar.TabIndex = 0;
            this.QuickBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopPanel.Controls.Add(this.ButtonExit);
            this.TopPanel.Controls.Add(this.MenuPanel);
            this.TopPanel.Controls.Add(this.TitlePanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(834, 30);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonExit.Location = new System.Drawing.Point(787, 0);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(47, 27);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuPanel.Controls.Add(this.Menus);
            this.MenuPanel.Location = new System.Drawing.Point(30, 3);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(757, 24);
            this.MenuPanel.TabIndex = 1;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TitlePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TitlePanel.Controls.Add(this.Icon);
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(30, 30);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            // 
            // Icon
            // 
            this.Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Icon.BackgroundImage")));
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon.Location = new System.Drawing.Point(2, 2);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(26, 26);
            this.Icon.TabIndex = 0;
            this.Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            // 
            // FrmBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(834, 58);
            this.ControlBox = false;
            this.Controls.Add(this.QuickBar);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.Menus;
            this.MaximizeBox = false;
            this.Name = "FrmBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNavBar_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menus;
        private System.Windows.Forms.ToolStrip QuickBar;
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel Icon;
    }
}