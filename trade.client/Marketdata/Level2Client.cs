using Google.Protobuf.Collections;
using NetMQ;
using NetMQ.Sockets;
using Newtonsoft.Json;
using Quotation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trade.client.Marketdata;

namespace trade.client.Marketdata
{
    public class Level2Client
    {
        private static Level2Client Instance { get; set; }

        public static Level2Client Connection(string address)
        {
            Instance = new Level2Client(address);
            return Instance;
        }

        private SubscriberSocket subscriber;
        private NetMQPoller subscriberPoller;

        public Action<List<StockQuote>> OnStockQuoteUpdated { set; get; }
        public Action<List<OrderQueue>> OnOrderQueueUpdated { set; get; }
        public Action<List<Order>> OnOrderUpdated { set; get; }
        public Action<List<Transaction>> OnTransactionUpdated { set; get; }

        public string Address { get; private set; }

        public Level2Client(string address)
        {
            Address = address;
            InitSub();
        }

        private void InitSub()
        {
            subscriber = new SubscriberSocket();
            subscriber.Connect(Address);
            subscriber.ReceiveReady += _Subscire_ReceiveReady;
            subscriber.SubscribeToAnyTopic();

            subscriberPoller = new NetMQPoller { subscriber };
            subscriberPoller.RunAsync();
        }

        private void _Subscire_ReceiveReady(object sender, NetMQSocketEventArgs e)
        {
            var msg = subscriber.ReceiveMultipartMessage();
            if (msg.FrameCount == 0) return; 
            MarketData data = MarketData.Parser.ParseFrom(msg.Pop().ToByteArray());

            var type = data.Type;
            if (type == MarketData.Types.Type.Stock)
            {
                OnStockQuoteUpdated?.Invoke(Transfer(data.StockData));        
            }
            else if (type == MarketData.Types.Type.Transaction)
            {
                OnTransactionUpdated?.Invoke(Transfer(data.TransactionData));
            }
            else if (type == MarketData.Types.Type.Order)
            {
                OnOrderUpdated?.Invoke(Transfer(data.OrderData));
            }
            else if (type == MarketData.Types.Type.Queue)
            {
                OnOrderQueueUpdated?.Invoke(Transfer(data.QueueData));
            }
        }
        private List<OrderQueue> Transfer(OrderQueueBlock block)
        {
            List<OrderQueue> results = new List<OrderQueue>();
            block.Queue.All(
                delegate (Quotation.OrderQueue t) {
                    results.Add(Transfer(t));
                    return true;
                });
            return results;
        }
        private List<Order> Transfer(OrderBlock block)
        {
            List<Order> results = new List<Order>();
            block.Order.All(
                delegate (Quotation.Order t) {
                    results.Add(Transfer(t));
                    return true;
                });
            return results;
        }
        private List<Transaction> Transfer(TransactionBlock block)
        {
            List<Transaction> results = new List<Transaction>();
            block.Transaction.All(
                delegate (Quotation.Transaction t) {
                    results.Add(Transfer(t));
                    return true;
                });
            return results;
        }
        private List<StockQuote> Transfer(StockBlock stockData)
        {
            List<StockQuote> results = new List<StockQuote>();
            foreach(Quotation.Stock s in stockData.Stock)
            {
                StockQuote stock = Transfer(s);
                results.Add(stock);
            }
            return results;
        }
        private StockQuote Transfer(Quotation.Stock s)
        {
            StockQuote result = new StockQuote()
            {
                SecurityId = ParseSecurityId(s.SzCode, s.SzWindCode),
                TradingDay = s.NTradingDay,
                Time = s.NTime,
                Status = s.NStatus,
                PreClose = PriceTransfer(s.NPreClose),
                Open = PriceTransfer(s.NOpen),
                High = PriceTransfer(s.NHigh),
                Low = PriceTransfer(s.NLow),
                Match = PriceTransfer(s.NMatch),
                AskPrice = new decimal[]
                {
                    PriceTransfer(s.NAskPrice0),
                    PriceTransfer(s.NAskPrice1),
                    PriceTransfer(s.NAskPrice2),
                    PriceTransfer(s.NAskPrice3),
                    PriceTransfer(s.NAskPrice4),
                    PriceTransfer(s.NAskPrice5),
                    PriceTransfer(s.NAskPrice6),
                    PriceTransfer(s.NAskPrice7),
                    PriceTransfer(s.NAskPrice8),
                    PriceTransfer(s.NAskPrice9),
                },
                AskVol = new decimal[]
                {
                    VolTransfer(s.NAskVol0),
                    VolTransfer(s.NAskVol1),
                    VolTransfer(s.NAskVol2),
                    VolTransfer(s.NAskVol3),
                    VolTransfer(s.NAskVol4),
                    VolTransfer(s.NAskVol5),
                    VolTransfer(s.NAskVol6),
                    VolTransfer(s.NAskVol7),
                    VolTransfer(s.NAskVol8),
                    VolTransfer(s.NAskVol9),
                },
                BidPrice = new decimal[]
                {
                    PriceTransfer(s.NBidPrice0),
                    PriceTransfer(s.NBidPrice1),
                    PriceTransfer(s.NBidPrice2),
                    PriceTransfer(s.NBidPrice3),
                    PriceTransfer(s.NBidPrice4),
                    PriceTransfer(s.NBidPrice5),
                    PriceTransfer(s.NBidPrice6),
                    PriceTransfer(s.NBidPrice7),
                    PriceTransfer(s.NBidPrice8),
                    PriceTransfer(s.NBidPrice9),
                },
                BidVol = new decimal[]
                {
                    VolTransfer(s.NBidVol0),
                    VolTransfer(s.NBidVol1),
                    VolTransfer(s.NBidVol2),
                    VolTransfer(s.NBidVol3),
                    VolTransfer(s.NBidVol4),
                    VolTransfer(s.NBidVol5),
                    VolTransfer(s.NBidVol6),
                    VolTransfer(s.NBidVol7),
                    VolTransfer(s.NBidVol8),
                    VolTransfer(s.NBidVol9),
                },
                NumTrades = s.NNumTrades,
                Volume = VolTransfer(s.IVolume),
                Turnover = VolTransfer(s.ITurnover),
                TotalBidVol = VolTransfer(s.NTotalBidVol),
                TotalAskVol = VolTransfer(s.NTotalAskVol),
                WeightedAvgBidPrice = PriceTransfer(s.NWeightedAvgBidPrice),
                WeightedAvgAskPrice = PriceTransfer(s.NWeightedAvgAskPrice),
                IOPV = PriceTransfer(s.NIOPV),
                YieldToMaturity = PriceTransfer(s.NYieldToMaturity),
                HighLimited = PriceTransfer(s.NHighLimited),
                LowLimited = PriceTransfer(s.NLowLimited),
            };
            return result;
        }

        private Transaction Transfer(Quotation.Transaction t)
        {
            Transaction result = new Transaction()
            {
                SecurityId = ParseSecurityId(t.SzCode, t.SzWindCode),
                ActionDay = t.NActionDay,
                Time = t.NTime,
                Index = t.NIndex,
                Price = PriceTransfer(t.NPrice),
                Volume = VolTransfer(t.NVolume),
                Turnover = VolTransfer(t.NTurnover),
                OrderSide = ParseBSFlag(t.NBSFlag),
                AskOrderId = t.NAskOrder,
                BidOrderId = t.NBidOrder
            };
            return result;
        }

        private Order Transfer(Quotation.Order o)
        {
            Order result = new Order()
            {
                SecurityId = ParseSecurityId(o.SzCode, o.SzWindCode),
                ActionDay = o.NActionDay,
                Time = o.NTime,
                OrderId = o.NOrder,
                Price = PriceTransfer(o.NPrice),
                Volume = VolTransfer(o.NVolume),
                OrderSide = ParseBSFlag(o.ChFunctionCode)
            };
            return result;
        }

        private OrderQueue Transfer(Quotation.OrderQueue o)
        {
            OrderQueue result = new OrderQueue()
            {
                SecurityId = ParseSecurityId(o.SzCode, o.SzWindCode),
                ActionDay = o.NActionDay,
                Time = o.NTime,
                OrderSide = ParseQueueSide(o.NSide),
                Price = PriceTransfer(o.NPrice),
                ABItems = o.NABItems,
                ABVolume = o.NABVolume.ToArray(),
            };
            return result;
        }

        private SecurityId ParseSecurityId(string SzCode, string SzWindCode)
        {
            if (SzWindCode.EndsWith(".SZ"))
                return new SecurityId(SzCode, Exchange.Sz);
            else if (SzWindCode.EndsWith(".SH"))
                return new SecurityId(SzCode, Exchange.Sh);
            else
                return new SecurityId(SzWindCode, Exchange.Undefined);
        }

        private OrderSide ParseQueueSide(int side)
        {
            if ((int)'B' == side)
                return OrderSide.Buy;
            if ((int)'A' == side)
                return OrderSide.Sell;
            return OrderSide.Undefined;
        }
        private OrderSide ParseBSFlag(string flag)
        {
            char[] chars = flag.ToCharArray();
            if (chars.Count() == 0) return OrderSide.Undefined;
            return ParseBSFlag((int)chars[0]);
        }

        private OrderSide ParseBSFlag(int flag)
        {
            if ((int)'B' == flag)
                return OrderSide.Buy;
            if ((int)'S' == flag)
                return OrderSide.Sell;
            if ((int)'C' == flag)
                return OrderSide.Cancel;
            return OrderSide.Undefined;
        }
        private decimal VolTransfer(long vol)
        {
            return new decimal(vol);
        }
        private decimal PriceTransfer(long price)
        {
            return new decimal((double)price / 10000d);
        }

    }
}
