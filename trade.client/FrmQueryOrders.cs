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
    public partial class FrmQueryOrders : Form
    {

        public QueryOrderCriteria Criteria { set; get; }
        public Exchange Exchange { set; get; }
        public OrderSide Side { set; get; }
        public string Code { set; get; }
        public string ExchangeId { set; get; }
        public string OriginalId { set; get; }
        public QueryOrdersResponse Orders { set; get; }
        public TradeClient Trader { get { return accountToolbar.Current; } }

        public FrmQueryOrders()
        {
            InitializeComponent();
        }
        private QueryOrderCriteria GetPlacementsQueryCriteria()
        {
            if (rdPlacementsCanCancel.Checked)
                return QueryOrderCriteria.QueryOrderCanBeCancelled;
            if (rdPlacementsCancel.Checked)
                return QueryOrderCriteria.QueryOnlyCancelOrder;
            if (rdPlacementsNormal.Checked)
                return QueryOrderCriteria.QueryOnlyOrder;
            return QueryOrderCriteria.QueryOrderAll;
        }
        private void BtnQueryPlacements_Click(object sender, EventArgs e)
        {
            DoQuery();
        }
        private void DoQuery()
        {
            SetParams();
            Thread thread = new Thread(new ThreadStart(Query));
            thread.Start();
        }
        private void SetParams()
        {
            Criteria = GetPlacementsQueryCriteria();
            Exchange = TradeDict.Exchange[cboPlacementsExchange.Text];
            Side = TradeDict.OrderSide[cboPlacementsOrderSide.Text];
            Code = txtPlacementsCode.Text;
            ExchangeId = txtPlacementsExchangeId.Text;
            OriginalId = txtPlacementsOriginalId.Text;
        }
        private void ShowData()
        {
            this.Grid.DataSource = Orders.OrderList;
        }
        private void Query()
        {
            Orders = Trader?.QueryOrder(
                criteria: Criteria,
                exchange: Exchange,
                side: Side,
                code: Code,
                exchangeId: ExchangeId,
                originalId: OriginalId
                );
            BeginInvoke(new MethodInvoker(ShowData));
        }

        private void FrmQueryOrders_Shown(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = Orders.OrderList[e.RowIndex];
            if (MessageBox.Show(
                string.Format("撤销委托 {0} ?", order.OrderExchangeId), 
                "撤单确认", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Trader.Cancel(order.OrderExchangeId);
            }
            
        }
    }


}
