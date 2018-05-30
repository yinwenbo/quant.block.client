using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade.client
{
    public class EtfLoader
    {
        public static Etf LoadEtf(string code)
        {
            string fileName = string.Format("{0}.json", code);
            if (!File.Exists(fileName))
            {
                return null;
            }
            string text = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<Etf>(text);
        }
    }

    public class Etf
    {
        public string Code { set; get; }
        /** 一级市场基金代码 **/
        public string Level1Code { set; get; }
        public string Level2Code { set; get; }
        public string Name { set; get; }
        public string TradingDay { set; get; }
        public string PreTradingDay { set; get; }
        public string Market { set; get; }
        public string PublishFlag { set; get; }
        /** 现金替代比例上限 **/
        public decimal MaxCashRatio { set; get; }
        /** 基金份额净值(单位:元) **/
        public decimal Nav { set; get; }
        /** 最小申购、赎回单位净值(单位：元) **/
        public decimal NAVperCU { set; get; }
        /** 最小申购、赎回单位的预估现金部分(单位:元) **/
        public decimal EstimateCashComponent { set; get; }
        /** 现金差额(单位:元) **/
        public decimal CashComponent { set; get; }
        /** 最小申购、赎回单位(单位:份) **/
        public int TradeUnit { set; get; }
        public int RecordNum { set; get; }

        public List<BasketItem> Items { set; get; }
    }

    public class BasketItem
    {
        public string Market { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string ReplaceFlag { set; get; }
        public decimal OverPriceRate { set; get; }
        public decimal ReplaceAmount { set; get; }
        public long Quantity { set; get; }
        public long Available { set; get; }
        public decimal Price { set; get; }
    }
}
