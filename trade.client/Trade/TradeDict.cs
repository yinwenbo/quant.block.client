using Dwjk.Dtp;
using System.Collections.Generic;

namespace trade.client.Trade
{
    public static class TradeDict
    {
        public static Dictionary<string, OrderSide> OrderSide =
            new Dictionary<string, OrderSide>
            {
                { "", Dwjk.Dtp.OrderSide.Undefined },
                { "买入", Dwjk.Dtp.OrderSide.Buy },
                { "卖出", Dwjk.Dtp.OrderSide.Sell },
                { "申购", Dwjk.Dtp.OrderSide.Creation },
                { "赎回", Dwjk.Dtp.OrderSide.Redempton }
            };
        public static Dictionary<string, Exchange> Exchange =
            new Dictionary<string, Exchange>
            {
                {"", Dwjk.Dtp.Exchange.Undefined },
                {"上海", Dwjk.Dtp.Exchange.ShA },
                {"深圳", Dwjk.Dtp.Exchange.SzA }
            };

        
       
    }
}
