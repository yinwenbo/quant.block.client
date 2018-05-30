namespace trade.client.Controls
{
    partial class QuoteL2
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
            this.handicapL21 = new trade.client.HandicapL2();
            this.SuspendLayout();
            // 
            // handicapL21
            // 
            this.handicapL21.BackColor = System.Drawing.Color.DarkRed;
            this.handicapL21.Location = new System.Drawing.Point(0, 0);
            this.handicapL21.Name = "handicapL21";
            this.handicapL21.Padding = new System.Windows.Forms.Padding(2);
            this.handicapL21.Size = new System.Drawing.Size(222, 503);
            this.handicapL21.TabIndex = 0;
            // 
            // QuoteL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.handicapL21);
            this.Name = "QuoteL2";
            this.Size = new System.Drawing.Size(398, 531);
            this.ResumeLayout(false);

        }

        #endregion

        private HandicapL2 handicapL21;
    }
}
