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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPlacementsSize = new System.Windows.Forms.TextBox();
            this.txtPlacementsOffset = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPlacementsOriginalId = new System.Windows.Forms.TextBox();
            this.txtPlacementsExchangeId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlacementsCode = new System.Windows.Forms.TextBox();
            this.cboPlacementsOrderSide = new System.Windows.Forms.ComboBox();
            this.cboPlacementsExchange = new System.Windows.Forms.ComboBox();
            this.groupOrderQueryCriteria = new System.Windows.Forms.GroupBox();
            this.rdPlacementsNormal = new System.Windows.Forms.RadioButton();
            this.rdPlacementsCancel = new System.Windows.Forms.RadioButton();
            this.rdPlacementsCanCancel = new System.Windows.Forms.RadioButton();
            this.rdPlacementsAll = new System.Windows.Forms.RadioButton();
            this.btnQueryPlacements = new System.Windows.Forms.Button();
            this.groupPlacements = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.StatusBar = new trade.client.Controls.StatusBar();
            this.accountToolbar = new trade.client.AccountBar();
            this.groupPlacmentQuery.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupOrderQueryCriteria.SuspendLayout();
            this.groupPlacements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPlacmentQuery
            // 
            this.groupPlacmentQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPlacmentQuery.Controls.Add(this.groupBox3);
            this.groupPlacmentQuery.Controls.Add(this.groupBox2);
            this.groupPlacmentQuery.Controls.Add(this.groupBox1);
            this.groupPlacmentQuery.Controls.Add(this.groupOrderQueryCriteria);
            this.groupPlacmentQuery.Controls.Add(this.btnQueryPlacements);
            this.groupPlacmentQuery.Location = new System.Drawing.Point(0, 38);
            this.groupPlacmentQuery.Name = "groupPlacmentQuery";
            this.groupPlacmentQuery.Size = new System.Drawing.Size(759, 94);
            this.groupPlacmentQuery.TabIndex = 13;
            this.groupPlacmentQuery.TabStop = false;
            this.groupPlacmentQuery.Text = "条件";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtPlacementsSize);
            this.groupBox3.Controls.Add(this.txtPlacementsOffset);
            this.groupBox3.Location = new System.Drawing.Point(389, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 74);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "分页";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 3;
            this.label20.Text = "行数:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "位置:";
            // 
            // txtPlacementsSize
            // 
            this.txtPlacementsSize.Location = new System.Drawing.Point(50, 46);
            this.txtPlacementsSize.Name = "txtPlacementsSize";
            this.txtPlacementsSize.Size = new System.Drawing.Size(40, 21);
            this.txtPlacementsSize.TabIndex = 1;
            // 
            // txtPlacementsOffset
            // 
            this.txtPlacementsOffset.Location = new System.Drawing.Point(50, 20);
            this.txtPlacementsOffset.Name = "txtPlacementsOffset";
            this.txtPlacementsOffset.Size = new System.Drawing.Size(40, 21);
            this.txtPlacementsOffset.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtPlacementsOriginalId);
            this.groupBox2.Controls.Add(this.txtPlacementsExchangeId);
            this.groupBox2.Location = new System.Drawing.Point(255, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 12);
            this.label22.TabIndex = 3;
            this.label22.Text = "原始号:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "单号:";
            // 
            // txtPlacementsOriginalId
            // 
            this.txtPlacementsOriginalId.Location = new System.Drawing.Point(59, 46);
            this.txtPlacementsOriginalId.Name = "txtPlacementsOriginalId";
            this.txtPlacementsOriginalId.Size = new System.Drawing.Size(63, 21);
            this.txtPlacementsOriginalId.TabIndex = 1;
            // 
            // txtPlacementsExchangeId
            // 
            this.txtPlacementsExchangeId.Location = new System.Drawing.Point(59, 19);
            this.txtPlacementsExchangeId.Name = "txtPlacementsExchangeId";
            this.txtPlacementsExchangeId.Size = new System.Drawing.Size(63, 21);
            this.txtPlacementsExchangeId.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtPlacementsCode);
            this.groupBox1.Controls.Add(this.cboPlacementsOrderSide);
            this.groupBox1.Controls.Add(this.cboPlacementsExchange);
            this.groupBox1.Location = new System.Drawing.Point(120, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "股票代码:";
            // 
            // txtPlacementsCode
            // 
            this.txtPlacementsCode.Location = new System.Drawing.Point(70, 46);
            this.txtPlacementsCode.Name = "txtPlacementsCode";
            this.txtPlacementsCode.Size = new System.Drawing.Size(52, 21);
            this.txtPlacementsCode.TabIndex = 2;
            // 
            // cboPlacementsOrderSide
            // 
            this.cboPlacementsOrderSide.FormattingEnabled = true;
            this.cboPlacementsOrderSide.Items.AddRange(new object[] {
            "",
            "买入",
            "卖出"});
            this.cboPlacementsOrderSide.Location = new System.Drawing.Point(70, 22);
            this.cboPlacementsOrderSide.Name = "cboPlacementsOrderSide";
            this.cboPlacementsOrderSide.Size = new System.Drawing.Size(52, 20);
            this.cboPlacementsOrderSide.TabIndex = 1;
            // 
            // cboPlacementsExchange
            // 
            this.cboPlacementsExchange.FormattingEnabled = true;
            this.cboPlacementsExchange.Items.AddRange(new object[] {
            "",
            "上海",
            "深圳"});
            this.cboPlacementsExchange.Location = new System.Drawing.Point(8, 22);
            this.cboPlacementsExchange.Name = "cboPlacementsExchange";
            this.cboPlacementsExchange.Size = new System.Drawing.Size(56, 20);
            this.cboPlacementsExchange.TabIndex = 0;
            // 
            // groupOrderQueryCriteria
            // 
            this.groupOrderQueryCriteria.Controls.Add(this.rdPlacementsNormal);
            this.groupOrderQueryCriteria.Controls.Add(this.rdPlacementsCancel);
            this.groupOrderQueryCriteria.Controls.Add(this.rdPlacementsCanCancel);
            this.groupOrderQueryCriteria.Controls.Add(this.rdPlacementsAll);
            this.groupOrderQueryCriteria.Location = new System.Drawing.Point(6, 13);
            this.groupOrderQueryCriteria.Name = "groupOrderQueryCriteria";
            this.groupOrderQueryCriteria.Size = new System.Drawing.Size(108, 74);
            this.groupOrderQueryCriteria.TabIndex = 1;
            this.groupOrderQueryCriteria.TabStop = false;
            // 
            // rdPlacementsNormal
            // 
            this.rdPlacementsNormal.AutoSize = true;
            this.rdPlacementsNormal.Location = new System.Drawing.Point(59, 48);
            this.rdPlacementsNormal.Name = "rdPlacementsNormal";
            this.rdPlacementsNormal.Size = new System.Drawing.Size(47, 16);
            this.rdPlacementsNormal.TabIndex = 3;
            this.rdPlacementsNormal.Text = "委托";
            this.rdPlacementsNormal.UseVisualStyleBackColor = true;
            // 
            // rdPlacementsCancel
            // 
            this.rdPlacementsCancel.AutoSize = true;
            this.rdPlacementsCancel.Location = new System.Drawing.Point(6, 48);
            this.rdPlacementsCancel.Name = "rdPlacementsCancel";
            this.rdPlacementsCancel.Size = new System.Drawing.Size(47, 16);
            this.rdPlacementsCancel.TabIndex = 2;
            this.rdPlacementsCancel.Text = "撤单";
            this.rdPlacementsCancel.UseVisualStyleBackColor = true;
            // 
            // rdPlacementsCanCancel
            // 
            this.rdPlacementsCanCancel.AutoSize = true;
            this.rdPlacementsCanCancel.Location = new System.Drawing.Point(59, 26);
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
            this.rdPlacementsAll.Location = new System.Drawing.Point(6, 26);
            this.rdPlacementsAll.Name = "rdPlacementsAll";
            this.rdPlacementsAll.Size = new System.Drawing.Size(47, 16);
            this.rdPlacementsAll.TabIndex = 0;
            this.rdPlacementsAll.TabStop = true;
            this.rdPlacementsAll.Text = "全部";
            this.rdPlacementsAll.UseVisualStyleBackColor = true;
            // 
            // btnQueryPlacements
            // 
            this.btnQueryPlacements.Location = new System.Drawing.Point(492, 64);
            this.btnQueryPlacements.Name = "btnQueryPlacements";
            this.btnQueryPlacements.Size = new System.Drawing.Size(75, 23);
            this.btnQueryPlacements.TabIndex = 0;
            this.btnQueryPlacements.Text = "刷新";
            this.btnQueryPlacements.UseVisualStyleBackColor = true;
            this.btnQueryPlacements.Click += new System.EventHandler(this.BtnQueryPlacements_Click);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupOrderQueryCriteria.ResumeLayout(false);
            this.groupOrderQueryCriteria.PerformLayout();
            this.groupPlacements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPlacmentQuery;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPlacementsSize;
        private System.Windows.Forms.TextBox txtPlacementsOffset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtPlacementsOriginalId;
        private System.Windows.Forms.TextBox txtPlacementsExchangeId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlacementsCode;
        private System.Windows.Forms.ComboBox cboPlacementsOrderSide;
        private System.Windows.Forms.ComboBox cboPlacementsExchange;
        private System.Windows.Forms.GroupBox groupOrderQueryCriteria;
        private System.Windows.Forms.RadioButton rdPlacementsNormal;
        private System.Windows.Forms.RadioButton rdPlacementsCancel;
        private System.Windows.Forms.RadioButton rdPlacementsCanCancel;
        private System.Windows.Forms.RadioButton rdPlacementsAll;
        private System.Windows.Forms.Button btnQueryPlacements;
        private System.Windows.Forms.GroupBox groupPlacements;
        private System.Windows.Forms.DataGridView Grid;
        private AccountBar accountToolbar;
        private Controls.StatusBar StatusBar;
    }
}