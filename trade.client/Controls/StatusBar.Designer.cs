namespace trade.client.Controls
{
    partial class StatusBar
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
            this.Status = new System.Windows.Forms.StatusStrip();
            this.TradeMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.QuoteMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TradeMessage,
            this.toolStripStatusLabel2,
            this.QuoteMessage});
            this.Status.Location = new System.Drawing.Point(0, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(766, 22);
            this.Status.TabIndex = 0;
            this.Status.Text = "statusStrip1";
            // 
            // TradeMessage
            // 
            this.TradeMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TradeMessage.Name = "TradeMessage";
            this.TradeMessage.Size = new System.Drawing.Size(95, 17);
            this.TradeMessage.Text = "TradeMessage";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // QuoteMessage
            // 
            this.QuoteMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.QuoteMessage.Name = "QuoteMessage";
            this.QuoteMessage.Size = new System.Drawing.Size(97, 17);
            this.QuoteMessage.Text = "QuoteMessage";
            // 
            // StatusBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Status);
            this.Name = "StatusBar";
            this.Size = new System.Drawing.Size(766, 22);
            this.Load += new System.EventHandler(this.StatusBar_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel TradeMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel QuoteMessage;
    }
}
