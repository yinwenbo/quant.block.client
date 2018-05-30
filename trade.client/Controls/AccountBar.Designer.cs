namespace trade.client
{
    partial class AccountBar
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountBar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboAccountNo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AvailableCash = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.FrozenCash = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.MarketValue = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.TotalAsset = new System.Windows.Forms.ToolStripTextBox();
            this.QueryCapital = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.comboAccountNo,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.AvailableCash,
            this.toolStripLabel3,
            this.FrozenCash,
            this.toolStripLabel4,
            this.MarketValue,
            this.toolStripLabel5,
            this.TotalAsset,
            this.QueryCapital});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4);
            this.toolStrip1.Size = new System.Drawing.Size(812, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 20);
            this.toolStripLabel1.Text = "账户:";
            // 
            // comboAccountNo
            // 
            this.comboAccountNo.BackColor = System.Drawing.SystemColors.Info;
            this.comboAccountNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountNo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboAccountNo.Name = "comboAccountNo";
            this.comboAccountNo.Size = new System.Drawing.Size(120, 23);
            this.comboAccountNo.TextChanged += new System.EventHandler(this.comboAccountNo_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 20);
            this.toolStripLabel2.Text = "可用:";
            // 
            // AvailableCash
            // 
            this.AvailableCash.BackColor = System.Drawing.SystemColors.Info;
            this.AvailableCash.ForeColor = System.Drawing.SystemColors.InfoText;
            this.AvailableCash.Name = "AvailableCash";
            this.AvailableCash.ReadOnly = true;
            this.AvailableCash.Size = new System.Drawing.Size(100, 23);
            this.AvailableCash.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 20);
            this.toolStripLabel3.Text = "冻结:";
            // 
            // FrozenCash
            // 
            this.FrozenCash.BackColor = System.Drawing.SystemColors.Info;
            this.FrozenCash.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FrozenCash.Name = "FrozenCash";
            this.FrozenCash.ReadOnly = true;
            this.FrozenCash.Size = new System.Drawing.Size(100, 23);
            this.FrozenCash.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 20);
            this.toolStripLabel4.Text = "市值:";
            // 
            // MarketValue
            // 
            this.MarketValue.BackColor = System.Drawing.SystemColors.Info;
            this.MarketValue.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MarketValue.Name = "MarketValue";
            this.MarketValue.ReadOnly = true;
            this.MarketValue.Size = new System.Drawing.Size(100, 23);
            this.MarketValue.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 20);
            this.toolStripLabel5.Text = "资产:";
            // 
            // TotalAsset
            // 
            this.TotalAsset.BackColor = System.Drawing.SystemColors.Info;
            this.TotalAsset.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TotalAsset.Name = "TotalAsset";
            this.TotalAsset.ReadOnly = true;
            this.TotalAsset.Size = new System.Drawing.Size(100, 23);
            this.TotalAsset.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // QueryCapital
            // 
            this.QueryCapital.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.QueryCapital.Image = ((System.Drawing.Image)(resources.GetObject("QueryCapital.Image")));
            this.QueryCapital.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QueryCapital.Name = "QueryCapital";
            this.QueryCapital.Size = new System.Drawing.Size(36, 21);
            this.QueryCapital.Text = "刷新";
            // 
            // AccountBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "AccountBar";
            this.Size = new System.Drawing.Size(812, 32);
            this.Load += new System.EventHandler(this.AccountToolbar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comboAccountNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox AvailableCash;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox FrozenCash;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox MarketValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox TotalAsset;
        private System.Windows.Forms.ToolStripButton QueryCapital;
    }
}
