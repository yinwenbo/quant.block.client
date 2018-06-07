namespace trade.client
{
    partial class FrmQueryOrders
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
            this.groupPlacmentQuery = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPlacementsOriginalId = new System.Windows.Forms.TextBox();
            this.txtPlacementsExchangeId = new System.Windows.Forms.TextBox();
            this.rdPlacementsNormal = new System.Windows.Forms.RadioButton();
            this.rdPlacementsCancel = new System.Windows.Forms.RadioButton();
            this.rdPlacementsCanCancel = new System.Windows.Forms.RadioButton();
            this.rdPlacementsAll = new System.Windows.Forms.RadioButton();
            this.RefreshQuery = new System.Windows.Forms.Button();
            this.groupPlacements = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.cboPlacementsExchange = new System.Windows.Forms.ComboBox();
            this.cboPlacementsOrderSide = new System.Windows.Forms.ComboBox();
            this.txtPlacementsCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PageSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusBar = new trade.client.Controls.StatusBar();
            this.accountToolbar = new trade.client.AccountBar();
            this.groupPlacmentQuery.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupPlacements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPlacmentQuery
            // 
            this.groupPlacmentQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPlacmentQuery.Controls.Add(this.NextPage);
            this.groupPlacmentQuery.Controls.Add(this.groupBox1);
            this.groupPlacmentQuery.Controls.Add(this.groupBox2);
            this.groupPlacmentQuery.Controls.Add(this.RefreshQuery);
            this.groupPlacmentQuery.Location = new System.Drawing.Point(0, 38);
            this.groupPlacmentQuery.Name = "groupPlacmentQuery";
            this.groupPlacmentQuery.Size = new System.Drawing.Size(759, 94);
            this.groupPlacmentQuery.TabIndex = 13;
            this.groupPlacmentQuery.TabStop = false;
            this.groupPlacmentQuery.Text = "条件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PageSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdPlacementsNormal);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.rdPlacementsCancel);
            this.groupBox2.Controls.Add(this.cboPlacementsOrderSide);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.rdPlacementsCanCancel);
            this.groupBox2.Controls.Add(this.txtPlacementsOriginalId);
            this.groupBox2.Controls.Add(this.rdPlacementsAll);
            this.groupBox2.Controls.Add(this.txtPlacementsExchangeId);
            this.groupBox2.Location = new System.Drawing.Point(164, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(134, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 12);
            this.label22.TabIndex = 3;
            this.label22.Text = "原始号:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "单号:";
            // 
            // txtPlacementsOriginalId
            // 
            this.txtPlacementsOriginalId.Location = new System.Drawing.Point(187, 42);
            this.txtPlacementsOriginalId.Name = "txtPlacementsOriginalId";
            this.txtPlacementsOriginalId.Size = new System.Drawing.Size(64, 21);
            this.txtPlacementsOriginalId.TabIndex = 1;
            // 
            // txtPlacementsExchangeId
            // 
            this.txtPlacementsExchangeId.Location = new System.Drawing.Point(46, 42);
            this.txtPlacementsExchangeId.Name = "txtPlacementsExchangeId";
            this.txtPlacementsExchangeId.Size = new System.Drawing.Size(64, 21);
            this.txtPlacementsExchangeId.TabIndex = 0;
            // 
            // rdPlacementsNormal
            // 
            this.rdPlacementsNormal.AutoSize = true;
            this.rdPlacementsNormal.Location = new System.Drawing.Point(324, 44);
            this.rdPlacementsNormal.Name = "rdPlacementsNormal";
            this.rdPlacementsNormal.Size = new System.Drawing.Size(47, 16);
            this.rdPlacementsNormal.TabIndex = 3;
            this.rdPlacementsNormal.Text = "委托";
            this.rdPlacementsNormal.UseVisualStyleBackColor = true;
            // 
            // rdPlacementsCancel
            // 
            this.rdPlacementsCancel.AutoSize = true;
            this.rdPlacementsCancel.Location = new System.Drawing.Point(271, 44);
            this.rdPlacementsCancel.Name = "rdPlacementsCancel";
            this.rdPlacementsCancel.Size = new System.Drawing.Size(47, 16);
            this.rdPlacementsCancel.TabIndex = 2;
            this.rdPlacementsCancel.Text = "撤单";
            this.rdPlacementsCancel.UseVisualStyleBackColor = true;
            // 
            // rdPlacementsCanCancel
            // 
            this.rdPlacementsCanCancel.AutoSize = true;
            this.rdPlacementsCanCancel.Location = new System.Drawing.Point(324, 18);
            this.rdPlacementsCanCancel.Name = "rdPlacementsCanCancel";
            this.rdPlacementsCanCancel.Size = new System.Drawing.Size(47, 16);
            this.rdPlacementsCanCancel.TabIndex = 1;
            this.rdPlacementsCanCancel.Text = "可撤";
            this.rdPlacementsCanCancel.UseVisualStyleBackColor = true;
            // 
            // rdPlacementsAll
            // 
            this.rdPlacementsAll.AutoSize = true;
            this.rdPlacementsAll.Checked = true;
            this.rdPlacementsAll.Location = new System.Drawing.Point(271, 18);
            this.rdPlacementsAll.Name = "rdPlacementsAll";
            this.rdPlacementsAll.Size = new System.Drawing.Size(47, 16);
            this.rdPlacementsAll.TabIndex = 0;
            this.rdPlacementsAll.TabStop = true;
            this.rdPlacementsAll.Text = "全部";
            this.rdPlacementsAll.UseVisualStyleBackColor = true;
            // 
            // RefreshQuery
            // 
            this.RefreshQuery.Location = new System.Drawing.Point(553, 28);
            this.RefreshQuery.Name = "RefreshQuery";
            this.RefreshQuery.Size = new System.Drawing.Size(75, 23);
            this.RefreshQuery.TabIndex = 0;
            this.RefreshQuery.Text = "刷新";
            this.RefreshQuery.UseVisualStyleBackColor = true;
            this.RefreshQuery.Click += new System.EventHandler(this.BtnQueryPlacements_Click);
            // 
            // groupPlacements
            // 
            this.groupPlacements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPlacements.Controls.Add(this.Grid);
            this.groupPlacements.Location = new System.Drawing.Point(3, 138);
            this.groupPlacements.Name = "groupPlacements";
            this.groupPlacements.Size = new System.Drawing.Size(753, 351);
            this.groupPlacements.TabIndex = 12;
            this.groupPlacements.TabStop = false;
            this.groupPlacements.Text = "委托";
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 17);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.RowTemplate.Height = 23;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(747, 331);
            this.Grid.TabIndex = 0;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // cboPlacementsExchange
            // 
            this.cboPlacementsExchange.FormattingEnabled = true;
            this.cboPlacementsExchange.Items.AddRange(new object[] {
            "",
            "上海",
            "深圳"});
            this.cboPlacementsExchange.Location = new System.Drawing.Point(70, 16);
            this.cboPlacementsExchange.Name = "cboPlacementsExchange";
            this.cboPlacementsExchange.Size = new System.Drawing.Size(69, 20);
            this.cboPlacementsExchange.TabIndex = 0;
            // 
            // cboPlacementsOrderSide
            // 
            this.cboPlacementsOrderSide.FormattingEnabled = true;
            this.cboPlacementsOrderSide.Items.AddRange(new object[] {
            "",
            "买入",
            "卖出"});
            this.cboPlacementsOrderSide.Location = new System.Drawing.Point(46, 16);
            this.cboPlacementsOrderSide.Name = "cboPlacementsOrderSide";
            this.cboPlacementsOrderSide.Size = new System.Drawing.Size(64, 20);
            this.cboPlacementsOrderSide.TabIndex = 1;
            // 
            // txtPlacementsCode
            // 
            this.txtPlacementsCode.Location = new System.Drawing.Point(70, 42);
            this.txtPlacementsCode.Name = "txtPlacementsCode";
            this.txtPlacementsCode.Size = new System.Drawing.Size(69, 21);
            this.txtPlacementsCode.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "股票代码:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlacementsCode);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cboPlacementsExchange);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "委托:";
            // 
            // NextPage
            // 
            this.NextPage.Location = new System.Drawing.Point(553, 53);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(75, 23);
            this.NextPage.TabIndex = 5;
            this.NextPage.Text = "下一页";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "市场:";
            // 
            // PageSize
            // 
            this.PageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PageSize.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PageSize.Location = new System.Drawing.Point(187, 16);
            this.PageSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PageSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageSize.Name = "PageSize";
            this.PageSize.Size = new System.Drawing.Size(64, 21);
            this.PageSize.TabIndex = 12;
            this.PageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PageSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "每页条数:";
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = true;
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.Location = new System.Drawing.Point(0, 495);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(759, 22);
            this.StatusBar.TabIndex = 14;
            // 
            // accountToolbar
            // 
            this.accountToolbar.ClientChanged = null;
            this.accountToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountToolbar.Location = new System.Drawing.Point(0, 0);
            this.accountToolbar.Name = "accountToolbar";
            this.accountToolbar.Size = new System.Drawing.Size(759, 32);
            this.accountToolbar.TabIndex = 0;
            // 
            // FrmQueryOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 517);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.accountToolbar);
            this.Controls.Add(this.groupPlacmentQuery);
            this.Controls.Add(this.groupPlacements);
            this.Name = "FrmQueryOrders";
            this.Text = "委托查询";
            this.Shown += new System.EventHandler(this.FrmQueryOrders_Shown);
            this.groupPlacmentQuery.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupPlacements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPlacmentQuery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtPlacementsOriginalId;
        private System.Windows.Forms.TextBox txtPlacementsExchangeId;
        private System.Windows.Forms.RadioButton rdPlacementsNormal;
        private System.Windows.Forms.RadioButton rdPlacementsCancel;
        private System.Windows.Forms.RadioButton rdPlacementsCanCancel;
        private System.Windows.Forms.RadioButton rdPlacementsAll;
        private System.Windows.Forms.Button RefreshQuery;
        private System.Windows.Forms.GroupBox groupPlacements;
        private System.Windows.Forms.DataGridView Grid;
        private AccountBar accountToolbar;
        private Controls.StatusBar StatusBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlacementsCode;
        private System.Windows.Forms.ComboBox cboPlacementsOrderSide;
        private System.Windows.Forms.ComboBox cboPlacementsExchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PageSize;
        private System.Windows.Forms.Label label3;
    }
}