using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace trade.client.Marketdata
{
    public class StockFaced
    {
        private static Level2Client Level2;
        private static Level1Client Level1;

        public static JsonCache<Stock> StockCache { get; private set; }
            
        public static JsonCache<StockQuote> QuoteCache { get; private set; }

        static StockFaced()
        {
            StockCache = new JsonCache<Stock>("stock.json", CacheKeyMaker);
            QuoteCache = new JsonCache<StockQuote>("quote.json", CacheKeyMaker);
        }

        public static void ConnectL1(string host)
        {
            Level1 = new Level1Client(host);
        }

        public static void ConnectL2(string host)
        {
            Level2 = new Level2Client(host);
            Level2.OnStockQuoteUpdated += OnLevel2QuoteUpdated;
        }

        public static void UpdateStock()
        {
            if (Level1 == null) return;
            var stocks = Level1.GetStocks();
            StockCache.Update(stocks);
        }

        public static void UpdateStockAsync()
        {
            Thread thread = new Thread(new ThreadStart(UpdateStock));
            thread.Start();
        }

        public static Stock GetStock(string code)
        {
            return StockCache.Get(code);
        }

        public static StockQuote GetQuote(string code)
        {
            return QuoteCache.Get(code);
        }

        private static void OnLevel2QuoteUpdated(List<StockQuote> list)
        {
            QuoteCache.Update(list);
        }

        private static string CacheKeyMaker(Security security)
        {
            return security.SecurityId.Code;
        }
    }
}
