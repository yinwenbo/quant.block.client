namespace trade.client
{
    partial class FrmTrade
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupFreePlacement = new System.Windows.Forms.GroupBox();
            this.tableFreePlacement = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Exchange = new System.Windows.Forms.ComboBox();
            this.OrderSide = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFPName = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.Amount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoPlace = new System.Windows.Forms.Button();
            this.groupCapital = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCapitialRefresh = new System.Windows.Forms.Button();
            this.txtCapitalAccountNo = new System.Windows.Forms.TextBox();
            this.txtCapitalBalance = new System.Windows.Forms.TextBox();
            this.txtCapitalAvailable = new System.Windows.Forms.TextBox();
            this.txtCapitalFreeze = new System.Windows.Forms.TextBox();
            this.txtCapitalMarketValue = new System.Windows.Forms.TextBox();
            this.txtCapitalTotal = new System.Windows.Forms.TextBox();
            this.HandicapL2 = new trade.client.HandicapL2();
            this.statusBar1 = new trade.client.Controls.StatusBar();
            this.accountToolbar = new trade.client.AccountBar();
            this.groupFreePlacement.SuspendLayout();
            this.tableFreePlacement.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupCapital.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFreePlacement
            // 
            this.groupFreePlacement.Controls.Add(this.tableFreePlacement);
            this.groupFreePlacement.Location = new System.Drawing.Point(7, 38);
            this.groupFreePlacement.Name = "groupFreePlacement";
            this.groupFreePlacement.Size = new System.Drawing.Size(233, 203);
            this.groupFreePlacement.TabIndex = 0;
            this.groupFreePlacement.TabStop = false;
            this.groupFreePlacement.Text = "自由委托";
            // 
            // tableFreePlacement
            // 
            this.tableFreePlacement.ColumnCount = 2;
            this.tableFreePlacement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableFreePlacement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFreePlacement.Controls.Add(this.label6, 0, 0);
            this.tableFreePlacement.Controls.Add(this.label7, 0, 1);
            this.tableFreePlacement.Controls.Add(this.label8, 0, 2);
            this.tableFreePlacement.Controls.Add(this.label9, 0, 3);
            this.tableFreePlacement.Controls.Add(this.Exchange, 1, 0);
            this.tableFreePlacement.Controls.Add(this.OrderSide, 1, 1);
            this.tableFreePlacement.Controls.Add(this.label10, 0, 4);
            this.tableFreePlacement.Controls.Add(this.panel1, 1, 2);
            this.tableFreePlacement.Controls.Add(this.Price, 1, 3);
            this.tableFreePlacement.Controls.Add(this.Quantity, 1, 4);
            this.tableFreePlacement.Controls.Add(this.Amount, 1, 5);
            this.tableFreePlacement.Controls.Add(this.label12, 0, 5);
            this.tableFreePlacement.Controls.Add(this.panel2, 1, 6);
            this.tableFreePlacement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFreePlacement.Location = new System.Drawing.Point(3, 17);
            this.tableFreePlacement.Name = "tableFreePlacement";
            this.tableFreePlacement.RowCount = 8;
            this.tableFreePlacement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableFreePlacement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableFreePlacement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableFreePlacement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableFreePlacement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableFreePlacement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableFreePlacement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableFreePlacement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableFreePlacement.Size = new System.Drawing.Size(227, 183);
            this.tableFreePlacement.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "市场:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "委托类型:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "代码:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(3, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "价格:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Exchange
            // 
            this.Exchange.FormattingEnabled = true;
            this.Exchange.Items.AddRange(new object[] {
            "上海",
            "深圳"});
            this.Exchange.Location = new System.Drawing.Point(83, 3);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(137, 20);
            this.Exchange.TabIndex = 1;
            this.Exchange.Text = "上海";
            // 
            // OrderSide
            // 
            this.OrderSide.FormattingEnabled = true;
            this.OrderSide.Items.AddRange(new object[] {
            "买入",
            "卖出",
            "申购",
            "赎回"});
            this.OrderSide.Location = new System.Drawing.Point(83, 28);
            this.OrderSide.Name = "OrderSide";
            this.OrderSide.Size = new System.Drawing.Size(137, 20);
            this.OrderSide.TabIndex = 2;
            this.OrderSide.Text = "买入";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(3, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "数量:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFPName);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Location = new System.Drawing.Point(83, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 22);
            this.panel1.TabIndex = 14;
            // 
            // txtFPName
            // 
            this.txtFPName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFPName.Location = new System.Drawing.Point(61, 0);
            this.txtFPName.Name = "txtFPName";
            this.txtFPName.Size = new System.Drawing.Size(78, 21);
            this.txtFPName.TabIndex = 1;
            this.txtFPName.TabStop = false;
            // 
            // Code
            // 
            this.Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code.Location = new System.Drawing.Point(0, 0);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(58, 21);
            this.Code.TabIndex = 3;
            this.Code.TextChanged += new System.EventHandler(this.Code_TextChanged);
            this.Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Code_KeyPress);
            // 
            // Price
            // 
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price.DecimalPlaces = 3;
            this.Price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Price.Location = new System.Drawing.Point(83, 81);
            this.Price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(86, 21);
            this.Price.TabIndex = 4;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price.ValueChanged += new System.EventHandler(this.ShowFPAmount);
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // Quantity
            // 
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Quantity.Location = new System.Drawing.Point(83, 106);
            this.Quantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(86, 21);
            this.Quantity.TabIndex = 5;
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.ThousandsSeparator = true;
            this.Quantity.ValueChanged += new System.EventHandler(this.ShowFPAmount);
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amount.Location = new System.Drawing.Point(83, 128);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(141, 22);
            this.Amount.TabIndex = 15;
            this.Amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "金额:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DoPlace);
            this.panel2.Location = new System.Drawing.Point(83, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 24);
            this.panel2.TabIndex = 17;
            // 
            // DoPlace
            // 
            this.DoPlace.Location = new System.Drawing.Point(0, 0);
            this.DoPlace.Name = "DoPlace";
            this.DoPlace.Size = new System.Drawing.Size(75, 23);
            this.DoPlace.TabIndex = 6;
            this.DoPlace.Text = "下单";
            this.DoPlace.UseVisualStyleBackColor = true;
            this.DoPlace.Click += new System.EventHandler(this.DoPlace_Click);
            // 
            // groupCapital
            // 
            this.groupCapital.Controls.Add(this.tableLayoutPanel1);
            this.groupCapital.Location = new System.Drawing.Point(246, 38);
            this.groupCapital.Name = "groupCapital";
            this.groupCapital.Size = new System.Drawing.Size(209, 203);
            this.groupCapital.TabIndex = 2;
            this.groupCapital.TabStop = false;
            this.groupCapital.Text = "资金";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCapitialRefresh, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCapitalAccountNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCapitalBalance, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCapitalAvailable, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCapitalFreeze, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCapitalMarketValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCapitalTotal, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(203, 183);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "账号:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "余额:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "可用:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "冻结:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "市值:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 25);
            this.label17.TabIndex = 5;
            this.label17.Text = "总资产:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCapitialRefresh
            // 
            this.btnCapitialRefresh.Location = new System.Drawing.Point(83, 153);
            this.btnCapitialRefresh.Name = "btnCapitialRefresh";
            this.btnCapitialRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnCapitialRefresh.TabIndex = 6;
            this.btnCapitialRefresh.Text = "刷新";
            this.btnCapitialRefresh.UseVisualStyleBackColor = true;
            this.btnCapitialRefresh.Click += new System.EventHandler(this.btnCapitialRefresh_Click);
            // 
            // txtCapitalAccountNo
            // 
            this.txtCapitalAccountNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapitalAccountNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapitalAccountNo.Location = new System.Drawing.Point(83, 3);
            this.txtCapitalAccountNo.Name = "txtCapitalAccountNo";
            this.txtCapitalAccountNo.Size = new System.Drawing.Size(117, 21);
            this.txtCapitalAccountNo.TabIndex = 7;
            this.txtCapitalAccountNo.TabStop = false;
            // 
            // txtCapitalBalance
            // 
            this.txtCapitalBalance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapitalBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapitalBalance.Location = new System.Drawing.Point(83, 28);
            this.txtCapitalBalance.Name = "txtCapitalBalance";
            this.txtCapitalBalance.Size = new System.Drawing.Size(117, 21);
            this.txtCapitalBalance.TabIndex = 8;
            this.txtCapitalBalance.TabStop = false;
            this.txtCapitalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCapitalAvailable
            // 
            this.txtCapitalAvailable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapitalAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapitalAvailable.Location = new System.Drawing.Point(83, 53);
            this.txtCapitalAvailable.Name = "txtCapitalAvailable";
            this.txtCapitalAvailable.Size = new System.Drawing.Size(117, 21);
            this.txtCapitalAvailable.TabIndex = 9;
            this.txtCapitalAvailable.TabStop = false;
            this.txtCapitalAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCapitalFreeze
            // 
            this.txtCapitalFreeze.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapitalFreeze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapitalFreeze.Location = new System.Drawing.Point(83, 78);
            this.txtCapitalFreeze.Name = "txtCapitalFreeze";
            this.txtCapitalFreeze.Size = new System.Drawing.Size(117, 21);
            this.txtCapitalFreeze.TabIndex = 10;
            this.txtCapitalFreeze.TabStop = false;
            this.txtCapitalFreeze.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCapitalMarketValue
            // 
            this.txtCapitalMarketValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapitalMarketValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapitalMarketValue.Location = new System.Drawing.Point(83, 103);
            this.txtCapitalMarketValue.Name = "txtCapitalMarketValue";
            this.txtCapitalMarketValue.Size = new System.Drawing.Size(117, 21);
            this.txtCapitalMarketValue.TabIndex = 11;
            this.txtCapitalMarketValue.TabStop = false;
            this.txtCapitalMarketValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCapitalTotal
            // 
            this.txtCapitalTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapitalTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapitalTotal.Location = new System.Drawing.Point(83, 128);
            this.txtCapitalTotal.Name = "txtCapitalTotal";
            this.txtCapitalTotal.Size = new System.Drawing.Size(117, 21);
            this.txtCapitalTotal.TabIndex = 12;
            this.txtCapitalTotal.TabStop = false;
            this.txtCapitalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HandicapL2
            // 
            this.HandicapL2.BackColor = System.Drawing.Color.Transparent;
            this.HandicapL2.Location = new System.Drawing.Point(458, 38);
            this.HandicapL2.Name = "HandicapL2";
            this.HandicapL2.Padding = new System.Windows.Forms.Padding(2);
            this.HandicapL2.Size = new System.Drawing.Size(238, 461);
            this.HandicapL2.TabIndex = 7;
            // 
            // statusBar1
            // 
            this.statusBar1.AutoSize = true;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 505);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(817, 22);
            this.statusBar1.TabIndex = 6;
            // 
            // accountToolbar
            // 
            this.accountToolbar.ClientChanged = null;
            this.accountToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountToolbar.Location = new System.Drawing.Point(0, 0);
            this.accountToolbar.Name = "accountToolbar";
            this.accountToolbar.Size = new System.Drawing.Size(817, 32);
            this.accountToolbar.TabIndex = 5;
            // 
            // FrmTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 527);
            this.Controls.Add(this.HandicapL2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.accountToolbar);
            this.Controls.Add(this.groupCapital);
            this.Controls.Add(this.groupFreePlacement);
            this.Name = "FrmTrade";
            this.Text = "交易";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTrade_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.groupFreePlacement.ResumeLayout(false);
            this.tableFreePlacement.ResumeLayout(false);
            this.tableFreePlacement.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupCapital.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupCapital;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCapitialRefresh;
        private System.Windows.Forms.TextBox txtCapitalAccountNo;
        private System.Windows.Forms.TextBox txtCapitalBalance;
        private System.Windows.Forms.TextBox txtCapitalAvailable;
        private System.Windows.Forms.TextBox txtCapitalFreeze;
        private System.Windows.Forms.TextBox txtCapitalMarketValue;
        private System.Windows.Forms.TextBox txtCapitalTotal;
        private System.Windows.Forms.GroupBox groupFreePlacement;
        private System.Windows.Forms.TableLayoutPanel tableFreePlacement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Exchange;
        private System.Windows.Forms.ComboBox OrderSide;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFPName;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DoPlace;
        private AccountBar accountToolbar;
        private Controls.StatusBar statusBar1;
        private HandicapL2 HandicapL2;
    }
}

