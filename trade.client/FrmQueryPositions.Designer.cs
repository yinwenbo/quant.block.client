namespace trade.client
{
    partial class FrmQueryPositions
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
            this.accountToolbar = new trade.client.AccountBar();
            this.groupHolding = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cboExchange = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.StatusBar = new trade.client.Controls.StatusBar();
            this.groupHolding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountToolbar
            // 
            this.accountToolbar.ClientChanged = null;
            this.accountToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountToolbar.Location = new System.Drawing.Point(0, 0);
            this.accountToolbar.Name = "accountToolbar";
            this.accountToolbar.Size = new System.Drawing.Size(800, 32);
            this.accountToolbar.TabIndex = 0;
            // 
            // groupHolding
            // 
            this.groupHolding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupHolding.Controls.Add(this.grid);
            this.groupHolding.Location = new System.Drawing.Point(0, 88);
            this.groupHolding.Name = "groupHolding";
            this.groupHolding.Size = new System.Drawing.Size(800, 336);
            this.groupHolding.TabIndex = 1;
            this.groupHolding.TabStop = false;
            this.groupHolding.Text = "持仓";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(3, 17);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid.RowTemplate.Height = 23;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(794, 316);
            this.grid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.cboExchange);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Location = new System.Drawing.Point(3, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(84, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 6;
            this.label27.Text = "股票代码:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(149, 16);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(71, 21);
            this.txtCode.TabIndex = 5;
            // 
            // cboExchange
            // 
            this.cboExchange.FormattingEnabled = true;
            this.cboExchange.Items.AddRange(new object[] {
            "",
            "上海",
            "深圳"});
            this.cboExchange.Location = new System.Drawing.Point(22, 17);
            this.cboExchange.Name = "cboExchange";
            this.cboExchange.Size = new System.Drawing.Size(56, 20);
            this.cboExchange.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(250, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "刷新";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = true;
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.Location = new System.Drawing.Point(0, 428);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(800, 22);
            this.StatusBar.TabIndex = 3;
            // 
            // FrmQueryPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupHolding);
            this.Controls.Add(this.accountToolbar);
            this.Name = "FrmQueryPositions";
            this.Text = "头寸查询";
            this.Shown += new System.EventHandler(this.FrmQueryPositions_Shown);
            this.groupHolding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountBar accountToolbar;
        private System.Windows.Forms.GroupBox groupHolding;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cboExchange;
        private Controls.StatusBar StatusBar;
    }
}