using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade.client
{
    class FunctionList
    {

        public static Dictionary<string, Type> QuickBar = new Dictionary<string, Type>()
        {
            {"持仓查询", typeof(FrmQueryPositions) },
            {"委托查询", typeof(FrmQueryOrders) },
            {"成交查询", typeof(FrmQueryFills) },
            {"交易", typeof(FrmTrade) },
            {"ETF交易", typeof(FrmETF) },
            {"交易回报", typeof(FrmReportSubscribe) },
        };
    }
}
