using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade.client.Trade
{
    public class TradeFacade
    {
        private static Dictionary<string, TradeClient> clients = new Dictionary<string, TradeClient>();
        public static TradeClient GetClient(string accountNo)
        {
            if (clients.TryGetValue(accountNo, out TradeClient result))
            {
                return result;
            }
            return null;
        }
        public static List<string> Accounts()
        {
            return clients.Keys.ToList();
        }
        public static List<TradeClient> Clients()
        {
            return clients.Values.ToList();
        }
        public static TradeClient Create(string accountNo, string password, string host, int requestPort, int dealerPort, int subscribePort)
        {
            const string template = "{0}:{1}";
            string request = string.Format(template, host, requestPort);
            string dealer = string.Format(template, host, dealerPort);
            string subscribe = string.Format(template, host, subscribePort);
            return Create(accountNo, password, request, dealer, subscribe);
        }
        public static TradeClient Create(string accountNo, string password, string requestAddress, string dealerAddress, string subscribeAddress)
        {
            TradeClient client = new TradeClient(requestAddress, dealerAddress, subscribeAddress);
            client.Login(accountNo, password);
            clients[accountNo] = client;
            return client;
        }
    }
}
