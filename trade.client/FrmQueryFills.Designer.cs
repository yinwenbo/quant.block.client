namespace trade.client
{
    partial class FrmQueryFills
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
            this.groupFillQuery = new System.Windows.Forms.GroupBox();
            this.chkFillIncludeCancel = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtFillOriginalId = new System.Windows.Forms.TextBox();
            this.txtFillExchangeId = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtFillCode = new System.Windows.Forms.TextBox();
            this.cboFillOrderSide = new System.Windows.Forms.ComboBox();
            this.cboFillExchange = new System.Windows.Forms.ComboBox();
            this.btnQueryFills = new System.Windows.Forms.Button();
            this.groupFills = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.StatusBar = new trade.client.Controls.StatusBar();
            this.AccountToolbar = new trade.client.AccountBar();
            this.PageSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextPage = new System.Windows.Forms.Button();
            this.groupFillQuery.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupFills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFillQuery
            // 
            this.groupFillQuery.Controls.Add(this.NextPage);
            this.groupFillQuery.Controls.Add(this.groupBox5);
            this.groupFillQuery.Controls.Add(this.groupBox6);
            this.groupFillQuery.Controls.Add(this.btnQueryFills);
            this.groupFillQuery.Location = new System.Drawing.Point(0, 38);
            this.groupFillQuery.Name = "groupFillQuery";
            this.groupFillQuery.Size = new System.Drawing.Size(800, 94);
            this.groupFillQuery.TabIndex = 3;
            this.groupFillQuery.TabStop = false;
            this.groupFillQuery.Text = "条件";
            // 
            // chkFillIncludeCancel
            // 
            this.chkFillIncludeCancel.AutoSize = true;
            this.chkFillIncludeCancel.Checked = true;
            this.chkFillIncludeCancel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFillIncludeCancel.Location = new System.Drawing.Point(260, 18);
            this.chkFillIncludeCancel.Name = "chkFillIncludeCancel";
            this.chkFillIncludeCancel.Size = new System.Drawing.Size(72, 16);
            this.chkFillIncludeCancel.TabIndex = 8;
            this.chkFillIncludeCancel.Text = "包含撤单";
            this.chkFillIncludeCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PageSize);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.chkFillIncludeCancel);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.cboFillOrderSide);
            this.groupBox5.Controls.Add(this.txtFillOriginalId);
            this.groupBox5.Controls.Add(this.txtFillExchangeId);
            this.groupBox5.Location = new System.Drawing.Point(164, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 74);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(129, 46);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 12);
            this.label25.TabIndex = 3;
            this.label25.Text = "原始号:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 2;
            this.label26.Text = "单号:";
            // 
            // txtFillOriginalId
            // 
            this.txtFillOriginalId.Location = new System.Drawing.Point(182, 42);
            this.txtFillOriginalId.Name = "txtFillOriginalId";
            this.txtFillOriginalId.Size = new System.Drawing.Size(72, 21);
            this.txtFillOriginalId.TabIndex = 1;
            // 
            // txtFillExchangeId
            // 
            this.txtFillExchangeId.Location = new System.Drawing.Point(48, 42);
            this.txtFillExchangeId.Name = "txtFillExchangeId";
            this.txtFillExchangeId.Size = new System.Drawing.Size(63, 21);
            this.txtFillExchangeId.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.txtFillCode);
            this.groupBox6.Controls.Add(this.cboFillExchange);
            this.groupBox6.Location = new System.Drawing.Point(6, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(152, 74);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 46);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 3;
            this.label27.Text = "股票代码:";
            // 
            // txtFillCode
            // 
            this.txtFillCode.Location = new System.Drawing.Point(70, 42);
            this.txtFillCode.Name = "txtFillCode";
            this.txtFillCode.Size = new System.Drawing.Size(69, 21);
            this.txtFillCode.TabIndex = 2;
            // 
            // cboFillOrderSide
            // 
            this.cboFillOrderSide.FormattingEnabled = true;
            this.cboFillOrderSide.Items.AddRange(new object[] {
            "",
            "买入",
            "卖出"});
            this.cboFillOrderSide.Location = new System.Drawing.Point(48, 16);
            this.cboFillOrderSide.Name = "cboFillOrderSide";
            this.cboFillOrderSide.Size = new System.Drawing.Size(63, 20);
            this.cboFillOrderSide.TabIndex = 1;
            // 
            // cboFillExchange
            // 
            this.cboFillExchange.FormattingEnabled = true;
            this.cboFillExchange.Items.AddRange(new object[] {
            "",
            "上海",
            "深圳"});
            this.cboFillExchange.Location = new System.Drawing.Point(70, 16);
            this.cboFillExchange.Name = "cboFillExchange";
            this.cboFillExchange.Size = new System.Drawing.Size(69, 20);
            this.cboFillExchange.TabIndex = 0;
            // 
            // btnQueryFills
            // 
            this.btnQueryFills.Location = new System.Drawing.Point(511, 28);
            this.btnQueryFills.Name = "btnQueryFills";
            this.btnQueryFills.Size = new System.Drawing.Size(75, 23);
            this.btnQueryFills.TabIndex = 0;
            this.btnQueryFills.Text = "刷新";
            this.btnQueryFills.UseVisualStyleBackColor = true;
            this.btnQueryFills.Click += new System.EventHandler(this.BtnQueryFills_Click);
            // 
            // groupFills
            // 
            this.groupFills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFills.Controls.Add(this.grid);
            this.groupFills.Location = new System.Drawing.Point(3, 138);
            this.groupFills.Name = "groupFills";
            this.groupFills.Size = new System.Drawing.Size(794, 284);
            this.groupFills.TabIndex = 2;
            this.groupFills.TabStop = false;
            this.groupFills.Text = "成交";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(3, 17);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 23;
            this.grid.Size = new System.Drawing.Size(788, 264);
            this.grid.TabIndex = 0;
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = true;
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.Location = new System.Drawing.Point(0, 428);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(800, 22);
            this.StatusBar.TabIndex = 5;
            // 
            // AccountToolbar
            // 
            this.AccountToolbar.ClientChanged = null;
            this.AccountToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountToolbar.Location = new System.Drawing.Point(0, 0);
            this.AccountToolbar.Name = "AccountToolbar";
            this.AccountToolbar.Size = new System.Drawing.Size(800, 32);
            this.AccountToolbar.TabIndex = 4;
            // 
            // PageSize
            // 
            this.PageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PageSize.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PageSize.Location = new System.Drawing.Point(182, 16);
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
            this.PageSize.Size = new System.Drawing.Size(72, 21);
            this.PageSize.TabIndex = 15;
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
            this.label3.Location = new System.Drawing.Point(117, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "每页条数:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "委托:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "市场:";
            // 
            // NextPage
            // 
            this.NextPage.Location = new System.Drawing.Point(511, 53);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(75, 23);
            this.NextPage.TabIndex = 7;
            this.NextPage.Text = "下一页";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // FrmQueryFills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.AccountToolbar);
            this.Controls.Add(this.groupFillQuery);
            this.Controls.Add(this.groupFills);
            this.Name = "FrmQueryFills";
            this.Text = "成交查询";
            this.Shown += new System.EventHandler(this.FrmQueryFills_Shown);
            this.groupFillQuery.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupFills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupFillQuery;
        private System.Windows.Forms.CheckBox chkFillIncludeCancel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtFillOriginalId;
        private System.Windows.Forms.TextBox txtFillExchangeId;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtFillCode;
        private System.Windows.Forms.ComboBox cboFillOrderSide;
        private System.Windows.Forms.ComboBox cboFillExchange;
        private System.Windows.Forms.Button btnQueryFills;
        private System.Windows.Forms.GroupBox groupFills;
        private System.Windows.Forms.DataGridView grid;
        private AccountBar AccountToolbar;
        private Controls.StatusBar StatusBar;
        private System.Windows.Forms.NumericUpDown PageSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextPage;
    }
}