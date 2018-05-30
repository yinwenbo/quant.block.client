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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtFillSize = new System.Windows.Forms.TextBox();
            this.txtFillOffset = new System.Windows.Forms.TextBox();
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
            this.groupFillQuery.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupFills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFillQuery
            // 
            this.groupFillQuery.Controls.Add(this.chkFillIncludeCancel);
            this.groupFillQuery.Controls.Add(this.groupBox4);
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
            this.chkFillIncludeCancel.Location = new System.Drawing.Point(381, 35);
            this.chkFillIncludeCancel.Name = "chkFillIncludeCancel";
            this.chkFillIncludeCancel.Size = new System.Drawing.Size(72, 16);
            this.chkFillIncludeCancel.TabIndex = 8;
            this.chkFillIncludeCancel.Text = "包含撤单";
            this.chkFillIncludeCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtFillSize);
            this.groupBox4.Controls.Add(this.txtFillOffset);
            this.groupBox4.Location = new System.Drawing.Point(275, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(97, 74);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "分页";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 3;
            this.label23.Text = "行数:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "位置:";
            // 
            // txtFillSize
            // 
            this.txtFillSize.Location = new System.Drawing.Point(50, 46);
            this.txtFillSize.Name = "txtFillSize";
            this.txtFillSize.Size = new System.Drawing.Size(40, 21);
            this.txtFillSize.TabIndex = 1;
            // 
            // txtFillOffset
            // 
            this.txtFillOffset.Location = new System.Drawing.Point(50, 20);
            this.txtFillOffset.Name = "txtFillOffset";
            this.txtFillOffset.Size = new System.Drawing.Size(40, 21);
            this.txtFillOffset.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtFillOriginalId);
            this.groupBox5.Controls.Add(this.txtFillExchangeId);
            this.groupBox5.Location = new System.Drawing.Point(141, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 74);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 12);
            this.label25.TabIndex = 3;
            this.label25.Text = "原始号:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 2;
            this.label26.Text = "单号:";
            // 
            // txtFillOriginalId
            // 
            this.txtFillOriginalId.Location = new System.Drawing.Point(59, 46);
            this.txtFillOriginalId.Name = "txtFillOriginalId";
            this.txtFillOriginalId.Size = new System.Drawing.Size(63, 21);
            this.txtFillOriginalId.TabIndex = 1;
            // 
            // txtFillExchangeId
            // 
            this.txtFillExchangeId.Location = new System.Drawing.Point(59, 19);
            this.txtFillExchangeId.Name = "txtFillExchangeId";
            this.txtFillExchangeId.Size = new System.Drawing.Size(63, 21);
            this.txtFillExchangeId.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.txtFillCode);
            this.groupBox6.Controls.Add(this.cboFillOrderSide);
            this.groupBox6.Controls.Add(this.cboFillExchange);
            this.groupBox6.Location = new System.Drawing.Point(6, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(129, 74);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 3;
            this.label27.Text = "股票代码:";
            // 
            // txtFillCode
            // 
            this.txtFillCode.Location = new System.Drawing.Point(70, 46);
            this.txtFillCode.Name = "txtFillCode";
            this.txtFillCode.Size = new System.Drawing.Size(52, 21);
            this.txtFillCode.TabIndex = 2;
            // 
            // cboFillOrderSide
            // 
            this.cboFillOrderSide.FormattingEnabled = true;
            this.cboFillOrderSide.Items.AddRange(new object[] {
            "",
            "买入",
            "卖出"});
            this.cboFillOrderSide.Location = new System.Drawing.Point(70, 22);
            this.cboFillOrderSide.Name = "cboFillOrderSide";
            this.cboFillOrderSide.Size = new System.Drawing.Size(52, 20);
            this.cboFillOrderSide.TabIndex = 1;
            // 
            // cboFillExchange
            // 
            this.cboFillExchange.FormattingEnabled = true;
            this.cboFillExchange.Items.AddRange(new object[] {
            "",
            "上海",
            "深圳"});
            this.cboFillExchange.Location = new System.Drawing.Point(8, 22);
            this.cboFillExchange.Name = "cboFillExchange";
            this.cboFillExchange.Size = new System.Drawing.Size(56, 20);
            this.cboFillExchange.TabIndex = 0;
            // 
            // btnQueryFills
            // 
            this.btnQueryFills.Location = new System.Drawing.Point(378, 64);
            this.btnQueryFills.Name = "btnQueryFills";
            this.btnQueryFills.Size = new System.Drawing.Size(75, 23);
            this.btnQueryFills.TabIndex = 0;
            this.btnQueryFills.Text = "刷新";
            this.btnQueryFills.UseVisualStyleBackColor = true;
            this.btnQueryFills.Click += new System.EventHandler(this.btnQueryFills_Click);
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
            this.groupFillQuery.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupFills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupFillQuery;
        private System.Windows.Forms.CheckBox chkFillIncludeCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtFillSize;
        private System.Windows.Forms.TextBox txtFillOffset;
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
    }
}