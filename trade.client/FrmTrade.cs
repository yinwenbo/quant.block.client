using Dwjk.Dtp;
using NetMQ;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using trade.client.Marketdata;
using trade.client.Trade;

namespace trade.client
{
    public partial class FrmTrade : Form
    {
        public TradeClient Trader { get { return accountToolbar.Current; } }

        public FrmTrade()
        {
            InitializeComponent();
            StockFacade.QuoteCache.OnCacheUpdated += OnQuoteUpdated;
        }

        private void QueryCapital()
        {
            var result = accountToolbar.Current?.QueryCapital();
            txtCapitalAccountNo.Text = result.AccountNo;
            txtCapitalBalance.Text = result.Balance;
            txtCapitalAvailable.Text = result.Available;
            txtCapitalFreeze.Text = result.Freeze;
            txtCapitalMarketValue.Text = result.Securities;
            txtCapitalTotal.Text = result.Total;
        }
        
        private void Place()
        {
            var order =
                Trader.NewOrder(
                   TradeDict.Exchange[Exchange.Text],
                   Code.Text,
                   Price.Value.ToString(),
                   (uint)Quantity.Value,
                   TradeDict.OrderSide[OrderSide.Text]
                   );
            if (FrmOrderConfirm.Show(order))
            {
                Trader.Order(order);
            }
        }

        
        private void btnCapitialRefresh_Click(object sender, EventArgs e)
        {
            QueryCapital();
        }

        private void DoPlace_Click(object sender, EventArgs e)
        {
            Place();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            QueryCapital();
        }

        private void ShowFPAmount(object sender, EventArgs e)
        {
            Amount.Text = string.Format("{0}", Price.Value * Quantity.Value);
        }

        private void FrmTrade_FormClosing(object sender, FormClosingEventArgs e)
        {
            StockFacade.QuoteCache.OnCacheUpdated -= OnQuoteUpdated;
        }

        private void Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                Price.Focus();
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                Quantity.Focus();
            }
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                DoPlace.Focus();
            }
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {
            var stock = StockFacade.GetStock(Code.Text);
            if (stock != null) HandicapL2.Update(stock);
            StockQuote quote = StockFacade.GetQuote(Code.Text);
            if (quote != null) HandicapL2.Update(quote);
        }

        private void OnQuoteUpdated(List<StockQuote> obj)
        {
            string code = Code.Text;
            if (code.Length != 6) return;
            var quote = obj.Find((q) => { return String.Equals(q.SecurityId.Code, code); });
            if (quote != null) BeginInvoke(new MethodInvoker(() => { HandicapL2.Update(quote); }));
        }

    }
}
