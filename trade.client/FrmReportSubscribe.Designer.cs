namespace trade.client
{
    partial class FrmReportSubscribe
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
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.rtxtReport = new System.Windows.Forms.RichTextBox();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.rtxtReport);
            this.grpReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReport.Location = new System.Drawing.Point(0, 0);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(800, 450);
            this.grpReport.TabIndex = 5;
            this.grpReport.TabStop = false;
            // 
            // rtxtReport
            // 
            this.rtxtReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtReport.Location = new System.Drawing.Point(3, 17);
            this.rtxtReport.Name = "rtxtReport";
            this.rtxtReport.Size = new System.Drawing.Size(794, 430);
            this.rtxtReport.TabIndex = 4;
            this.rtxtReport.Text = "";
            // 
            // FrmReportSubscribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpReport);
            this.Name = "FrmReportSubscribe";
            this.Text = "交易回报";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReportSubscribe_FormClosing);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.RichTextBox rtxtReport;
    }
}