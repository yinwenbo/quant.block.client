using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace trade.client.Marketdata
{
    public class Level1Client
    {
        private static Dictionary<string, Exchange> Exchanges =
            new Dictionary<string, Exchange>()
            {
                {"sh", Exchange.Sh}, {"sz", Exchange.Sz}
            };
        private static Dictionary<string, StockType> Types =
            new Dictionary<string, StockType>()
            {
                {"STOCK", StockType.Stock }, {"LOF", StockType.LOF },
                { "ETF", StockType.ETF }, {"REPO", StockType.Repo }
            };
        

        private RestClient Client;

        public Level1Client(string host)
        {
            Client = new RestClient(host);
        }

        public List<Stock> GetStocks()
        {
            string json = GetSecurities();
            List<SecurityDto> list = JsonConvert.DeserializeObject<List<SecurityDto>>(json);
            List<Stock> result = new List<Stock>();
            list.ForEach((stock) =>
            {
                if (Types.ContainsKey(stock.Type))
                    result.Add(Transfer(stock));
            });
            return result;
        }

        private Stock Transfer(SecurityDto s)
        {
            Stock result = new Stock()
            {
                SecurityId = new SecurityId(s.Symbol, Exchanges[s.Exchange]),
                Name = s.Name,
                PinYin = s.Pinyin,
                Type = Types[s.Type]
            };
            return result;
        }

        private string GetSecurities()
        {
            var request = new RestRequest("/securities", Method.GET);
            var response = Client.Execute(request);
            return response.Content;
        }

    }


    class SecurityDto
    {
        public string Symbol { set; get; }
        public string Exchange { set; get; }
        public string Type { set; get; }
        public string Name { set; get; }
        public string Pinyin { set; get; }
        public string Category { set; get; }
    }
}
