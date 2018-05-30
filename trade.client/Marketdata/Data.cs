using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade.client.Marketdata
{
    public enum OrderSide
    {
        Undefined,
        Buy,
        Sell,
        Cancel
    }

    public enum OrderType
    {
        Undefined,
        ETF_CREATE_OR_REDEEM,               /* ETF 申赎*/
        LIMIT_PRICE,                        /* 限价 */
        MARKET_IMMEDIATE_OTHER_CANCEL,      /* 深圳 即成剩撤 */
        MARKET_FIVE_LEVEL_CANCEL,           /* 深圳 五档即成剩撤 */
        MARKET_ALL_OR_CANCEL,               /* 深圳 全成全撤 */
        MARKET_OUR_BEST,                    /* 深圳 本方最优价格 */
        MARKET_COUNTERPARTY_BEST,           /* 深圳 对方最有价格 */
    }
    public enum Exchange
    {
        Undefined,
        Sh,
        Sz,
    }

    public enum StockType
    {
        Stock,
        ETF,
        LOF,
        Repo,
    }

    public class SecurityId
    {
        private Dictionary<Exchange, string> exchanges =
            new Dictionary<Exchange, string>()
            {
                {Exchange.Sh, "SH"}, {Exchange.Sz, "SZ"}
            };

        public SecurityId(string code, Exchange exchange)
        {
            Value = string.Format("{0}.{1}", code, exchanges[exchange]);
            Code = code;
            Exchange = exchange;
        }

        public string Value { get; private set; }
        public string Code { get; private set; }
        public Exchange Exchange { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is SecurityId)) return false;
            return Value.Equals(((SecurityId)obj).Value);
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        public override string ToString()
        {
            return Value;
        }
    }

    public abstract class Security
    {
        public SecurityId SecurityId { set; get; }
    }

    public class Stock : Security
    {
        public string Name { set; get; }
        public string PinYin { set; get; }
        public StockType Type { set; get; }
    }

    public class StockQuote : Security
    {
        public int TradingDay { set; get; }
        public int Time { set; get; }
        public int Status { set; get; }
        /** 前收 **/
        public decimal PreClose { set; get; }
        /** 开盘价 **/
        public decimal Open { set; get; }
        /** 最高价 **/
        public decimal High { set; get; }
        /** 最低价 **/
        public decimal Low { set; get; }
        /** 最新价 **/
        public decimal Match { set; get; }
        public decimal[] AskPrice { set; get; }
        public decimal[] AskVol { set; get; }
        public decimal[] BidPrice { set; get; }
        public decimal[] BidVol { set; get; }
        /** 成交笔数 **/
        public int NumTrades { set; get; }
        /** 成交总量 **/
        public decimal Volume { set; get; }
        /** 成交总金额 **/
        public decimal Turnover { set; get; }
        /** 委托买入总量 **/
        public decimal TotalBidVol { set; get; }
        /** 委托卖出总量 **/
        public decimal TotalAskVol { set; get; }
        /** 加权平均委买价格 **/
        public decimal WeightedAvgBidPrice { set; get; }
        /** 加权平均委卖价格 **/
        public decimal WeightedAvgAskPrice { set; get; }
        /** 净值 **/
        public decimal IOPV { set; get; }
        /** 到期收益率 **/
        public decimal YieldToMaturity { set; get; }
        /** 涨停价 **/
        public decimal HighLimited { set; get; }
        /** 跌停价 **/
        public decimal LowLimited { set; get; }

    }

    public class Transaction : Security
    {
        /** 发生日期 **/
        public int ActionDay { set; get; }
        public int Time { set; get; }
        /** 成交编号 **/
        public int Index { set; get; }
        /** 成交价格 **/
        public decimal Price { set; get; }
        /** 成交数量 **/
        public decimal Volume { set; get; }
        /** 成交金额 **/
        public decimal Turnover { set; get; }
        /** 买卖方向 **/
        public OrderSide OrderSide { set; get; }
        /** 卖方委托号 **/
        public int AskOrderId { set; get; }
        /** 买方委托号 **/
        public int BidOrderId { set; get; }
    }

    public class Order : Security
    {
        /** 发生日期 **/
        public int ActionDay { set; get; }
        /** 发生时间 **/
        public int Time { set; get; }
        /** 委托号 **/
        public int OrderId { set; get; }
        /** 委托价格 **/
        public decimal Price { set; get; }
        /** 委托数量 **/
        public decimal Volume { set; get; }
        /** 委托方向 **/
        public OrderSide OrderSide { set; get; }
        /** 订单类别 **/
        public OrderType OrderType { set; get; }
    }

    public class OrderQueue : Security
    {
        /** 发生日期 **/
        public int ActionDay { set; get; }
        /** 发生时间 **/
        public int Time { set; get; }
        /** 委托类别 **/
        public OrderSide OrderSide { set; get; }
        /** 委托价格 **/
        public decimal Price { set; get; }
        /** 订单数量 **/
        public int Orders { set; get; }
        /** 明细个数 **/
        public int ABItems { set; get; }
        /** 订单明细 **/
        public int[] ABVolume { set; get; }
    }
}
