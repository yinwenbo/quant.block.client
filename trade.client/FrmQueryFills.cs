using Dwjk.Dtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using trade.client.Trade;

namespace trade.client
{
    public partial class FrmQueryFills : Form
    {
        public string ExchangeId { set; get; }
        public string OriginalId { set; get; }
        public string Code { set; get; }
        public OrderSide Side { set; get; }
        public bool IncludeCancelFill { set; get; }
        public Exchange Exchange { set; get; }

        public QueryFillsResponse Fills { set; get; }

        public FrmQueryFills()
        {
            InitializeComponent();
        }

        private void SetParams()
        {
            Exchange = TradeDict.Exchange[cboFillExchange.Text];
            Side = TradeDict.OrderSide[cboFillOrderSide.Text];
            Code = txtFillCode.Text;
            ExchangeId = txtFillExchangeId.Text;
            OriginalId = txtFillOriginalId.Text;
            IncludeCancelFill = chkFillIncludeCancel.Checked;
        }

        private void btnQueryFills_Click(object sender, EventArgs e)
        {
            DoQuery();
        }
        private void DoQuery()
        {
            SetParams();
            Thread thread = new Thread(new ThreadStart(Query));
            thread.Start();
        }
        private void ShowData()
        {
            this.grid.DataSource = Fills.FillList;
        }
        private void Query()
        {
            Fills = AccountToolbar.Current?.QueryFill(
                exchange: Exchange,
                side: Side,
                code: Code,
                exchangeId: ExchangeId,
                originalId: OriginalId,
                includeCancelFill: IncludeCancelFill
                );
            BeginInvoke(new MethodInvoker(ShowData));
        }

        private void FrmQueryFills_Shown(object sender, EventArgs e)
        {
            DoQuery();
        }
    }
}
