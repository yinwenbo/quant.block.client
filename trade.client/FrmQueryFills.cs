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
using static Dwjk.Dtp.QueryFillsResponse.Types;

namespace trade.client
{
    public partial class FrmQueryFills : Form
    {
        private DefaultGridView<Fill> _Grid;
        private QueryPagination _NextPage;

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
            _Grid = new DefaultGridView<Fill>(grid);
            _NextPage = new QueryPagination
            {
                Size = (uint)PageSize.Value,
                Offset = 0
            };
        }

        private void InitQueryParams()
        {
            _NextPage.Size = (uint)PageSize.Value;
            _NextPage.Offset = 0;

            Exchange = TradeDict.Exchange[cboFillExchange.Text];
            Side = TradeDict.OrderSide[cboFillOrderSide.Text];
            Code = txtFillCode.Text;
            ExchangeId = txtFillExchangeId.Text;
            OriginalId = txtFillOriginalId.Text;
            IncludeCancelFill = chkFillIncludeCancel.Checked;

            _Grid.Clear();
        }

        private void BtnQueryFills_Click(object sender, EventArgs e)
        {
            RefreshQuery();
        }
        private void RefreshQuery()
        {
            InitQueryParams();
            QueryAsync();
        }
        
        private void QueryAsync()
        {
            Thread thread = new Thread(new ThreadStart(Query));
            thread.Start();
        }
        private void Query()
        {
            var fills = AccountToolbar.Current?.QueryFill(
                exchange: Exchange,
                side: Side,
                code: Code,
                exchangeId: ExchangeId,
                originalId: OriginalId,
                includeCancelFill: IncludeCancelFill,
                pagination: _NextPage
                );
            if (fills == null || fills.FillList.Count() == 0)
            {
                MessageBox.Show("没有了!");
                return;
            }
            if (fills.Pagination.Offset <= _NextPage.Offset) return;
            _NextPage.Offset = fills.Pagination.Offset;
            Invoke(
                new MethodInvoker(() =>
                {
                    _Grid.Add(fills.FillList.ToList());
                }));
        }

        private void FrmQueryFills_Shown(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            QueryAsync();
        }
    }
}
