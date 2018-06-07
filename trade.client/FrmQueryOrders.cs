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
using trade.client.UIUtils;
using static Dwjk.Dtp.QueryOrdersResponse.Types;

namespace trade.client
{
    public partial class FrmQueryOrders : Form
    {
        private DefaultGridView<Order> _Grid;
        private QueryPagination _NextPage;

        public QueryOrderCriteria Criteria { set; get; }
        public Exchange Exchange { set; get; }
        public OrderSide Side { set; get; }
        public string Code { set; get; }
        public string ExchangeId { set; get; }
        public string OriginalId { set; get; }

        public TradeClient Trader { get { return accountToolbar.Current; } }

        public FrmQueryOrders()
        {
            InitializeComponent();
            _Grid = new DefaultGridView<Order>(Grid);
            _NextPage = new QueryPagination
            {
                Size = (uint)PageSize.Value,
                Offset = 0
            };
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
            DoRefresh();
        }
        private void DoRefresh()
        {
            InitQueryParams();
            QueryAsync();
        }
        private void InitQueryParams()
        {
            Criteria = GetPlacementsQueryCriteria();
            Exchange = TradeDict.Exchange[cboPlacementsExchange.Text];
            Side = TradeDict.OrderSide[cboPlacementsOrderSide.Text];
            Code = txtPlacementsCode.Text;
            ExchangeId = txtPlacementsExchangeId.Text;
            OriginalId = txtPlacementsOriginalId.Text;
            _NextPage.Size = (uint)PageSize.Value;
            _NextPage.Offset = 0;
            _Grid.Clear();
        }

        private void QueryAsync()
        {
            Thread thread = new Thread(new ThreadStart(Query));
            thread.Start();
        }
        private void Query()
        {
            var orders = Trader?.QueryOrder(
                criteria: Criteria,
                exchange: Exchange,
                side: Side,
                code: Code,
                exchangeId: ExchangeId,
                originalId: OriginalId,
                pagination: _NextPage
                );
            if (orders == null || orders.OrderList.Count() == 0)
            {
                MessageBox.Show("没有了!");
                return;
            }
            if (orders.Pagination.Offset <= _NextPage.Offset) return;
            _NextPage.Offset = orders.Pagination.Offset;
            Invoke(
                new MethodInvoker(() =>
                {
                    _Grid.Add(orders.OrderList.ToList());
                }));
        }

        private void FrmQueryOrders_Shown(object sender, EventArgs e)
        {
            DoRefresh();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = _Grid.Get(e.RowIndex);
            if (MessageBox.Show(
                string.Format("撤销委托 {0} ?", order.OrderExchangeId), 
                "撤单确认", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Trader.Cancel(order.OrderExchangeId);
            }
            
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            QueryAsync();
        }
    }


}
