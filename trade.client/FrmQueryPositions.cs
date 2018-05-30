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
    public partial class FrmQueryPositions : Form
    {
        public string Code { set; get; }
        public Exchange Exchange { set; get; }
        public QueryPositionResponse Positions { set; get; }

        public FrmQueryPositions()
        {
            InitializeComponent();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
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
            Exchange = TradeDict.Exchange[cboExchange.Text];
            Code = txtCode.Text;
        }

        private void ShowData()
        {
            if (Positions == null) return;
            this.grid.DataSource = Positions.PositionList;
        }
        private void Query()
        {
            Positions = accountToolbar.Current?.QueryPositions(
                exchange: Exchange,
                code: Code
                );
            BeginInvoke(new MethodInvoker(ShowData));

        }

        private void FrmQueryPositions_Shown(object sender, EventArgs e)
        {
            DoQuery();
        }
    }
}
