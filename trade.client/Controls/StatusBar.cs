using Dwjk.Dtp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using trade.client.Marketdata;
using trade.client.Trade;

namespace trade.client.Controls
{
    public partial class StatusBar : UserControl
    {
        public StatusBar()
        {
            InitializeComponent();
            TradeMessage.Text = "";
            QuoteMessage.Text = "";
        }

        private void StatusBar_Load(object sender, EventArgs e)
        {
            this.ParentForm.FormClosing += On_Form_Close;
            StockFacade.QuoteCache.OnCacheUpdated += On_StockUpdate;
            InitTradeClient();
        }

        private void On_Form_Close(object sender, FormClosingEventArgs e)
        {
            TradeFacade.Clients().ForEach(UnBindTradeClient);
            StockFacade.QuoteCache.OnCacheUpdated -= On_StockUpdate;
        }

        private void InitTradeClient()
        {
            TradeFacade.Clients().ForEach(BindTradeClient);
        }

        private void UnBindTradeClient(TradeClient obj)
        {
            obj.PlaceReportReceived -= On_Trade_Place;
            obj.FillReportReceived -= On_Trade_Fill;
            obj.CancelReportReceived -= On_Trade_Cancel;
        }

        private void BindTradeClient(TradeClient obj)
        {
            obj.PlaceReportReceived += On_Trade_Place;
            obj.FillReportReceived += On_Trade_Fill;
            obj.CancelReportReceived += On_Trade_Cancel;
        }

        private void On_Trade_Cancel(string accountNo, ReportHeader header, CancellationReport report)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                TradeMessage.Text =
                    string.Format("撤单 {0} {1} {2} {3}",
                        report.Code,
                        report.Quantity,
                        report.CancelledQuantity,
                        DateTime.Now.ToString("HH:mm:ss.fff"));
            }));
        }

        private void On_Trade_Fill(string accountNo, ReportHeader header, FillReport report)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                TradeMessage.Text =
                    string.Format("成交 {0} {1} {2} {3}",
                        report.Code,
                        report.Quantity,
                        report.FillQuantity,
                        DateTime.Now.ToString("HH:mm:ss.fff"));
            }));
        }

        private void On_Trade_Place(string accountNo, ReportHeader header, PlacedReport report)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                TradeMessage.Text =
                    string.Format("{0} {1} {2} {3} {4} {5}",
                        report.Status,
                        report.OrderSide,
                        report.Code,
                        report.Quantity,
                        report.Price,
                        header.Message);
            }));
        }

        private void On_StockUpdate(List<StockQuote> obj)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                QuoteMessage.Text = string.Format("行情更新 {0} 条 {1}", obj.Count, DateTime.Now.ToString("HH:mm:ss.fff"));
            }));
        }
    }
}
