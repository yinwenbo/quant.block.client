using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trade.client.Marketdata;

namespace trade.client
{
    public partial class HandicapL2 : UserControl
    {

        private static string STOCK_PRICE_FORMAT = "{0:0.00}";
        private static string FUND_PRICE_FORMAT = "{0:0.000}";

        private string PriceFormat = FUND_PRICE_FORMAT;

        public HandicapL2()
        {
            InitializeComponent();
            InitText();
        }

        public void Update(Stock stock)
        {
            if (stock.Type == StockType.Stock)
                PriceFormat = STOCK_PRICE_FORMAT;
            else
                PriceFormat = FUND_PRICE_FORMAT;
            StockName.Text = string.Format("{0} {1}", stock.Name, stock.SecurityId.Code);
        }
        public void Update(StockQuote quote)
        {
            try
            {
                decimal preClose = quote.PreClose;
                decimal match = quote.Match;
                decimal priceUp = Decimal.Zero.Equals(match) ? Decimal.Zero : match - preClose;
                decimal priceUpRatio = (Decimal.Zero.Equals(match) || Decimal.Zero.Equals(preClose)) ? Decimal.Zero : priceUp / preClose;
                Match.Text = string.Format(PriceFormat, match);

                PriceUp.Text = string.Format(PriceFormat, priceUp);
                SetColor(PriceUp, 0, priceUp);

                PriceUpRatio.Text = string.Format("{0:0.00%}", priceUpRatio);
                SetColor(PriceUpRatio, 0, priceUp);
                // 委比
                decimal bidAskRatio = CalculateBidAskRatio(quote);
                // 委比
                BidAskRatio.Text = string.Format("{0:0.00%}", bidAskRatio);
                SetColor(BidAskRatio, 0, bidAskRatio);
                // 委比量
                BidAskDiff.Text = string.Format("{0:0}", CalculateBidAskDiff(quote) / 100);
                SetColor(BidAskDiff, 0, bidAskRatio);
                // 均卖价
                WeightedAvgAskPrice.Text = string.Format(PriceFormat, quote.WeightedAvgAskPrice);
                SetColor(WeightedAvgAskPrice, preClose, quote.WeightedAvgAskPrice);
                // 总卖量
                TotalAskVol.Text = string.Format("{0:0}", quote.TotalAskVol / 100);
                // 均买价
                WeightedAvgBidPrice.Text = string.Format(PriceFormat, quote.WeightedAvgBidPrice);
                SetColor(WeightedAvgBidPrice, preClose, quote.WeightedAvgBidPrice);
                // 总买量
                TotalBidVol.Text = string.Format("{0:0}", quote.TotalBidVol / 100);
                // 总笔数
                NumTrades.Text = quote.NumTrades.ToString();
                // 均笔量
                AvgTradeVol.Text = string.Format("{0:0}", CalculateAvgTradeVol(quote) / 100);

                SetHandicap(BidPrice1, BidVol1, quote.BidPrice[0], quote.BidVol[0], preClose);
                SetHandicap(BidPrice2, BidVol2, quote.BidPrice[1], quote.BidVol[1], preClose);
                SetHandicap(BidPrice3, BidVol3, quote.BidPrice[2], quote.BidVol[2], preClose);
                SetHandicap(BidPrice4, BidVol4, quote.BidPrice[3], quote.BidVol[3], preClose);
                SetHandicap(BidPrice5, BidVol5, quote.BidPrice[4], quote.BidVol[4], preClose);
                SetHandicap(BidPrice6, BidVol6, quote.BidPrice[5], quote.BidVol[5], preClose);
                SetHandicap(BidPrice7, BidVol7, quote.BidPrice[6], quote.BidVol[6], preClose);
                SetHandicap(BidPrice8, BidVol8, quote.BidPrice[7], quote.BidVol[7], preClose);
                SetHandicap(BidPrice9, BidVol9, quote.BidPrice[8], quote.BidVol[8], preClose);
                SetHandicap(BidPrice10, BidVol10, quote.BidPrice[9], quote.BidVol[9], preClose);

                SetHandicap(AskPrice1, AskVol1, quote.AskPrice[0], quote.AskVol[0], preClose);
                SetHandicap(AskPrice2, AskVol2, quote.AskPrice[1], quote.AskVol[1], preClose);
                SetHandicap(AskPrice3, AskVol3, quote.AskPrice[2], quote.AskVol[2], preClose);
                SetHandicap(AskPrice4, AskVol4, quote.AskPrice[3], quote.AskVol[3], preClose);
                SetHandicap(AskPrice5, AskVol5, quote.AskPrice[4], quote.AskVol[4], preClose);
                SetHandicap(AskPrice6, AskVol6, quote.AskPrice[5], quote.AskVol[5], preClose);
                SetHandicap(AskPrice7, AskVol7, quote.AskPrice[6], quote.AskVol[6], preClose);
                SetHandicap(AskPrice8, AskVol8, quote.AskPrice[7], quote.AskVol[7], preClose);
                SetHandicap(AskPrice9, AskVol9, quote.AskPrice[8], quote.AskVol[8], preClose);
                SetHandicap(AskPrice10, AskVol10, quote.AskPrice[9], quote.AskVol[9], preClose);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void InitText()
        {
            StockName.Text = string.Empty;
            Match.Text = string.Empty;
            PriceUp.Text = string.Empty;
            PriceUpRatio.Text = string.Empty;
            BidAskRatio.Text = string.Empty;                // 委比
            BidAskDiff.Text = string.Empty;                 // 委比量
            WeightedAvgAskPrice.Text = string.Empty;        // 均卖价
            TotalAskVol.Text = string.Empty;                // 总卖量
            WeightedAvgBidPrice.Text = string.Empty;        // 均买价
            TotalBidVol.Text = string.Empty;                // 总买量
            NumTrades.Text = string.Empty;                  // 总笔数
            AvgTradeVol.Text = string.Empty;                // 均笔量
            BidPrice1.Text = string.Empty;
            BidVol1.Text = string.Empty;
            InitHandicap(BidPrice1, BidVol1);
            InitHandicap(BidPrice2, BidVol2);
            InitHandicap(BidPrice3, BidVol3);
            InitHandicap(BidPrice4, BidVol4);
            InitHandicap(BidPrice5, BidVol5);
            InitHandicap(BidPrice6, BidVol6);
            InitHandicap(BidPrice7, BidVol7);
            InitHandicap(BidPrice8, BidVol8);
            InitHandicap(BidPrice9, BidVol9);
            InitHandicap(BidPrice10, BidVol10);

            InitHandicap(AskPrice1, AskVol1);
            InitHandicap(AskPrice2, AskVol2);
            InitHandicap(AskPrice3, AskVol3);
            InitHandicap(AskPrice4, AskVol4);
            InitHandicap(AskPrice5, AskVol5);
            InitHandicap(AskPrice6, AskVol6);
            InitHandicap(AskPrice7, AskVol7);
            InitHandicap(AskPrice8, AskVol8);
            InitHandicap(AskPrice9, AskVol9);
            InitHandicap(AskPrice10, AskVol10);
        }
        private void InitHandicap(Label lprice, Label lvol)
        {
            SetColor(lprice, 0, 0);
            lprice.Text = string.Empty;
            lvol.Text = string.Empty;
        }
        private void SetHandicap(Label lprice, Label lvol, decimal price, decimal vol, decimal precolse)
        {
            SetColor(lprice, precolse, price);
            lprice.Text = string.Format(PriceFormat, price);
            lvol.Text = string.Format("{0:0}", vol / 100);
        }

        private void SetColor(Label label, decimal baseline, decimal value)
        {
            int result = decimal.Compare(baseline, value);
            if (result < 0) //涨
                label.ForeColor = Color.OrangeRed; 
            else if (result > 0) //跌
                label.ForeColor = Color.SpringGreen; 
            else //平
                label.ForeColor = Color.White;
        }

        private decimal CalculateBidAskRatio(StockQuote stock)
        {
            decimal bidVol = stock.TotalBidVol;
            decimal askVol = stock.TotalAskVol;
            if (bidVol == 0 && askVol == 0) return Decimal.Zero;
            return (bidVol - askVol) / (bidVol + askVol);
        }
        private decimal CalculateBidAskDiff(StockQuote stock)
        {
            decimal bidVol = stock.TotalBidVol;
            decimal askVol = stock.TotalAskVol;
            return bidVol - askVol;
        }

        private decimal CalculateAvgTradeVol(StockQuote stock)
        {
            decimal vol = stock.Volume;
            int trades = stock.NumTrades;
            if (trades == 0) return Decimal.Zero;
            return vol / trades;
        }
    }
}
