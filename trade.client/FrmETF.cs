using NetMQ;
using NetMQ.Sockets;
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
using trade.client.Marketdata;
using trade.client.Trade;

namespace trade.client
{
    public partial class FrmETF : Form
    {
        private Etf etf;
        private TradeClient Trader { get { return accountToolbar.Current; } }

        public FrmETF()
        {
            InitializeComponent();
            StockFaced.QuoteCache.OnCacheUpdated += OnStockUpdated;
            gridBasket.RowStateChanged += RowAdded;
        }

        private void RowAdded(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void OnStockUpdated(List<StockQuote> obj)
        {
            if (etf == null) return;
            etf.Items.ForEach((item) => {
                StockQuote stock = obj.Find((s) => { return string.Equals(s.SecurityId.Code, item.Code); });
                if (stock == null) return;
                item.Price = stock.Match;
            });
        }
        
        private void LoadEtf(string code)
        {
            etf = EtfLoader.LoadEtf(code);
            if (etf == null)
            {
                MessageBox.Show(string.Format("代码 {0} 的篮子文件不存在。", code));
                return;
            }
            SetEtfInfo(etf);
            gridBasket.DataSource = etf.Items;
            LoadHolding();
        }

        private void SetEtfInfo(Etf etf)
        {
            txtEtfLevel1Code.Text = etf.Level1Code;
            txtEtfNavPreCU.Text = etf.NAVperCU.ToString();
            txtEtfTradingDay.Text = etf.TradingDay;
            txtEtfNav.Text = etf.Nav.ToString();
            txtEtfTradeUnit.Text = etf.TradeUnit.ToString();
            txtEtfEstimateCashComponent.Text = etf.EstimateCashComponent.ToString();
            txtEtfItemsCount.Text = etf.RecordNum.ToString();
            txtEtfMaxCashRatio.Text = etf.MaxCashRatio.ToString();
        }

        private void LoadHolding()
        {
            Thread thread = new Thread(new ThreadStart(RefreshHolding));
            thread.Start();
        }
        private void RefreshHolding()
        {
            if (etf == null) return;
            Dwjk.Dtp.QueryPositionResponse holding = Trader.QueryPositions();
            etf.Items.ForEach((item) => {
                var d = holding.PositionList.FirstOrDefault((detail) => {
                    return string.Equals(detail.Code, item.Code);
                });
                if (d != null) item.Available = d.AvailableQuantity;
            });
        }

        private void TxtEtfCode_TextChanged(object sender, EventArgs e)
        {
            if (txtEtfCode.Text.Length == 6)
            {
               LoadEtf(txtEtfCode.Text);
            }
        }

        private void txtEtfCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                LoadEtf(txtEtfCode.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEtfCode.Text = ((LinkLabel)sender).Text;
        }
        
        private void btnEtfBuyBasket_Click(object sender, EventArgs e)
        {
            if (etf == null) return;
            var orders = new List<Dwjk.Dtp.PlaceBatchOrder.Types.BatchOrderItem>();
            etf.Items.ForEach((item) => {
                Stock stock = StockFaced.GetStock(item.Code);
                StockQuote quote = StockFaced.GetQuote(item.Code);
                if (stock == null|| quote == null) return;
                if (!string.Equals(item.ReplaceFlag, "1")) return;
                orders.Add(
                    Trader.NewBatchOrderItem(
                        stock.SecurityId.Exchange == Exchange.Sh ? Dwjk.Dtp.Exchange.ShA : Dwjk.Dtp.Exchange.SzA,
                        item.Code,
                        quote.HighLimited.ToString(),
                        (uint)item.Quantity,
                        Dwjk.Dtp.OrderSide.Buy
                    ));
            });
            if (FrmOrderConfirm.ShowList(orders))
            {
                Trader.BatchOrder(orders);
            }
        }

        private void btnEtfSellBasket_Click(object sender, EventArgs e)
        {
            if (etf == null) return;
            var orders = new List<Dwjk.Dtp.PlaceBatchOrder.Types.BatchOrderItem>();
            etf.Items.ForEach((item) => {
                StockQuote stock = StockFaced.GetQuote(item.Code);
                if (item.Available == 0) return;
                orders.Add(
                    Trader.NewBatchOrderItem(
                        stock.SecurityId.Exchange == Exchange.Sh ? Dwjk.Dtp.Exchange.ShA : Dwjk.Dtp.Exchange.SzA,
                        item.Code,
                        stock.LowLimited.ToString(),
                        (uint)item.Quantity,
                        Dwjk.Dtp.OrderSide.Sell
                    ));
            });
            if (FrmOrderConfirm.ShowList(orders))
            {
                Trader.BatchOrder(orders);
            }
        }

        private void BtnEtfCreate_Click(object sender, EventArgs e)
        {
            if (etf == null) return;
            var order = 
                Trader.NewOrder(
                    Dwjk.Dtp.Exchange.ShA,
                    etf.Level1Code,
                    Price.Value.ToString(),
                    (uint)etf.TradeUnit,
                    Dwjk.Dtp.OrderSide.Creation
                );
            if (FrmOrderConfirm.Show(order))
            {
                Trader.Order(order);
            }

        }

        private void btnEtfRedeem_Click(object sender, EventArgs e)
        {
            if (etf == null) return;
            var order = 
                Trader.NewOrder(
                    Dwjk.Dtp.Exchange.ShA,
                    etf.Level1Code,
                    Price.Value.ToString(),
                    (uint)etf.TradeUnit,
                    Dwjk.Dtp.OrderSide.Redempton
                );
            if (FrmOrderConfirm.Show(order))
            {
                Trader.Order(order);
            }
        }

        private void btnEtfBuy_Click(object sender, EventArgs e)
        {
            if (etf == null) return;
            var order = 
                Trader.NewOrder(
                    Dwjk.Dtp.Exchange.ShA,
                    etf.Code,
                    Price.Value.ToString(),
                    (uint)etf.TradeUnit,
                    Dwjk.Dtp.OrderSide.Buy
                );
            if (FrmOrderConfirm.Show(order))
            {
                Trader.Order(order);
            }
        }

        private void btnEtfSell_Click(object sender, EventArgs e)
        {
            if (etf == null) return;
            var order = 
                Trader.NewOrder(
                    Dwjk.Dtp.Exchange.ShA,
                    etf.Code,
                    Price.Value.ToString(),
                    (uint)etf.TradeUnit,
                    Dwjk.Dtp.OrderSide.Sell
                );
            if (FrmOrderConfirm.Show(order))
            {
                Trader.Order(order);
            }
        }
    }
}
