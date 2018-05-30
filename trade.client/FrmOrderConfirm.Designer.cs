namespace trade.client
{
    partial class FrmOrderConfirm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Message = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 17);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 60;
            this.Grid.RowTemplate.Height = 23;
            this.Grid.Size = new System.Drawing.Size(732, 273);
            this.Grid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Message);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 56);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Message
            // 
            this.Message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(436, 25);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(47, 12);
            this.Message.TabIndex = 3;
            this.Message.Text = "Message";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Location = new System.Drawing.Point(308, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 34);
            this.panel1.TabIndex = 2;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(3, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(72, 29);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "确定";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.Location = new System.Drawing.Point(87, 10);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(29, 12);
            this.Cancel.TabIndex = 1;
            this.Cancel.TabStop = true;
            this.Cancel.Text = "取消";
            this.Cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cancel_LinkClicked);
            // 
            // FrmOrderConfirm
            // 
            this.AcceptButton = this.Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(738, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrderConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "委托确认";
            this.Shown += new System.EventHandler(this.FrmOrderConfirm_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.LinkLabel Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Message;
    }
}