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
using static Dwjk.Dtp.QueryPositionResponse.Types;

namespace trade.client
{
    public partial class FrmQueryPositions : Form
    {
        private DefaultGridView<PositionDetail> _Grid;
        private QueryPagination _NextPage;

        public string Code { set; get; }
        public Exchange Exchange { set; get; }
        
        public FrmQueryPositions()
        {
            InitializeComponent();
            _Grid = new DefaultGridView<PositionDetail>(Grid);
            _NextPage = new QueryPagination
            {
                Size = (uint)PageSize.Value,
                Offset = 0,
            };
        }
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            RefreshQuery();
        }
        private void RefreshQuery()
        {
            InitQueryParams();
            QueryAsync();
        }
        private void InitQueryParams()
        {
            _NextPage.Size = (uint)PageSize.Value;
            _NextPage.Offset = 0;
            Exchange = TradeDict.Exchange[cboExchange.Text];
            Code = txtCode.Text;
            _Grid.Clear();
        }
        private void QueryAsync()
        {
            Thread thread = new Thread(new ThreadStart(Query));
            thread.Start();
        }
        private void Query()
        {
            var positions = accountToolbar.Current?.QueryPositions(
                exchange: Exchange,
                code: Code,
                pagination: _NextPage
                );
            if (positions == null || positions.PositionList.Count() == 0)
            {
                MessageBox.Show("没有了!");
                return;
            };
            if (positions.Pagination.Offset <= _NextPage.Offset) return;
            _NextPage.Offset = positions.Pagination.Offset;
            Invoke(
                new MethodInvoker(() =>
                {
                    _Grid.Add(positions.PositionList.ToList());
                }));
        }

        private void FrmQueryPositions_Shown(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            QueryAsync();
        }
    }
}
