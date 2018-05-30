using Dwjk.Dtp;
using Google.Protobuf;
using NetMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Dwjk.Dtp.PlaceBatchOrder.Types;

namespace trade.client.Trade
{

    public class TradeClient
    {
        #region Request Code
        //stock
        //登录
        public const int ID_S_ACCOUNT_LOGIN_REQT = 10001001;
        public const int ID_S_ACCOUNT_LOGIN_RESP = 11001001;

        //logout
        public const int ID_S_ACCOUNT_LOGOUT_REQT = 10001002;
        public const int ID_S_ACCOUNT_LOGOUT_RESP = 11001002;

        //login query
        public const int ID_S_ACCOUNT_Q_LOGIN_REQT = 11000003;
        public const int ID_S_ACCOUNT_Q_LOGIN_RESP = 11100003;

        public const int ID_S_ACCOUNT_RELOGIN_REQT = 11000004;
        public const int ID_S_ACCOUNT_RELOGIN_RESP = 11100004;

        //单笔委托
        public const int ID_S_ORDER_REQT = 10002001;
        public const int ID_S_ORDER_RESP = 11101001;
        // Report
        public const int ID_STOCK_PLACE_REPORT = 20001001;
        public const int ID_STOCK_FILL_REPORT = 20001002;


        //批量委托
        public const int ID_S_ORDERS_REQT = 11001003;
        public const int ID_S_ORDERS_RESP = 11101003;

        //申购赎回
        public const int ID_S_CREATE_REDEEM_REQT = 11001003;
        public const int ID_S_CREATE_REDEEM_RESP = 11101003;

        //单笔撤单
        public const int ID_S_DELETE_REQT = 10002002;
        public const int ID_STOCK_CANCEL_REPORT = 20001003;

        //批量撤单
        public const int ID_S_DELETES_REQT = 11001004;
        public const int ID_S_DELETES_RESP = 11101004;

        //单笔委托查询
        public const int ID_S_Q_ORDER_REQT = 10003001;
        public const int ID_S_Q_ORDER_RESP = 11003001;

        //批量委托查询
        public const int ID_S_Q_ORDERS_REQT = 10003001;
        public const int ID_S_Q_ORDERS_RESP = 11003001;

        public const int ID_S_Q_ETF_BASIC_INFO_REQT = 11002008;
        public const int ID_S_Q_ETF_BASIC_INFO_RESP = 11102008;

        public const int ID_S_Q_ETF_BASKET_LIST_REQT = 11002009;
        public const int ID_S_Q_ETF_BASKET_LIST_RESP = 11102009;

        //资金查询
        public const int ID_S_Q_CAPITAL_REQT = 10003003;
        public const int ID_S_Q_CAPITAL_RESP = 11003003;

        //持仓查询
        public const int ID_S_Q_POSITION_REQT = 10003004;
        public const int ID_S_Q_POSITION_RESP = 11003004;

        //成交明细查询
        public const int ID_S_Q_DEAL_REQT = 10003002;
        public const int ID_S_Q_DEAL_RESP = 11003002;



        //新股申购额度查询请求
        public const int ID_S_Q_IPOR_REQT = 11002005;
        public const int ID_S_Q_IPOR_RESP = 11102005;

        public const int ID_S_Q_IPOL_REQT = 11002006;
        public const int ID_S_Q_IPOL_RESP = 11102006;
        #endregion

        #region static functions
        private static Dictionary<string, TradeClient> clients = new Dictionary<string, TradeClient>();
        public static TradeClient GetClient(string accountNo)
        {
            TradeClient result = null;
            if (clients.TryGetValue(accountNo, out result))
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
        public static TradeClient Create(string accountNo, string password, string requestAddress, string dealreAddress, string subscribeAddress)
        {
            TradeClient client = new TradeClient(requestAddress, dealreAddress, subscribeAddress);
            client.Login(accountNo, password);
            clients[accountNo] = client;
            return client;
        }
        #endregion

        #region events
        public delegate void Logger(String text);

        public delegate void PlaceAck(string accountNo, ReportHeader header, PlacedReport report);
        public delegate void FillAck(string accountNo, ReportHeader header, FillReport report);
        public delegate void CancelAck(string accountNo, ReportHeader header, CancellationReport report);

        public delegate void CapitalUpdate(QueryCapitalResponse response);
        public delegate void PositionsUpdate(QueryPositionResponse response);
        public delegate void OrdersUpdate(QueryOrdersResponse response);
        public delegate void FillsUpdate(QueryFillsResponse response);

        public PlaceAck PlaceReportReceived { set; get; }
        public FillAck FillReportReceived { set; get; }
        public CancelAck CancelReportReceived { set; get; }
        public CapitalUpdate CapitalReceived { set; get; }
        public PositionsUpdate PositionsReceived { set; get; }
        public OrdersUpdate OrdersReceived { set; get; }
        public FillsUpdate FillsReceived { set; get; }

        public Logger LoggerReceived { set; get; }
        #endregion

        public TradeChannels Channels { get; private set; }

        public string AccountNo { get; private set; }
        public string Token { get; private set; }

        public TradeClient(string requestAddress, string dealreAddress, string subscribeAddress)
        {
            Channels = new TradeChannels
            {
                RequestAddress = requestAddress,
                DealerAddress = dealreAddress,
                SubscribeAddress = subscribeAddress
            };
        }

        #region Subscribe
        private void On_SubscribeReceived(NetMQMessage message)
        {
            int count = message.FrameCount;
            if (count < 3) return;

            string accountNo = message.Pop().ConvertToString();
            ReportHeader header = ReportHeader.Parser.ParseFrom(message.Pop().ToByteArray());
            var payload = message.Pop();
            if (header.ApiId == ID_STOCK_PLACE_REPORT)
            {
                PlacedReport report = PlacedReport.Parser.ParseFrom(payload.ToByteArray());
                PlaceReportReceived?.Invoke(accountNo, header, report);
            }
            else if (header.ApiId == ID_STOCK_FILL_REPORT)
            {
                FillReport report = FillReport.Parser.ParseFrom(payload.ToByteArray());
                FillReportReceived?.Invoke(accountNo, header, report);
            }
            else if (header.ApiId == ID_STOCK_CANCEL_REPORT)
            {
                CancellationReport report = CancellationReport.Parser.ParseFrom(payload.ToByteArray());
                CancelReportReceived?.Invoke(accountNo, header, report);
            }
        }
        #endregion

        #region Login

        public void Login(string accountNo, string password)
        {
            NetMQMessage msg = 
                Channels.SendRequest(
                    BuildMessage(
                        Header(ID_S_ACCOUNT_LOGIN_REQT),
                        new LoginAccountRequest()
                        {
                            AccountNo = accountNo,
                            Password = password
                        }));

            ResponseHeader header = ResponseHeader.Parser.ParseFrom(msg.Pop().ToByteArray());
            WriteLog(header.ToString());

            LoginAccountResponse response = LoginAccountResponse.Parser.ParseFrom(msg.Pop().ToByteArray());
            WriteLog(response.ToString());
            if (header.Code != ResponseStatusCode.ResponseCodeOk)
            {
                throw new Exception(header.Message);
            }
            Channels.OnSubscribeRecieved += On_SubscribeReceived;
            Channels.ConnectSubscribe();
            Token = response.Token;
            AccountNo = accountNo;
        }

        #endregion

        #region BatchOrder
        public BatchOrderItem NewBatchOrderItem(
           Exchange exchange,
           string code,
           string price,
           uint quantity,
           OrderSide side,
           OrderType type = OrderType.Limit,
           string origianId = ""
           )
        {
            return
                new BatchOrderItem()
                {
                    OrderOriginalId = string.IsNullOrEmpty(origianId) ? DateTime.Now.ToString("HHmmssfff") : origianId,
                    Exchange = exchange,
                    Code = code,
                    Price = price,
                    Quantity = quantity,
                    OrderSide = side,
                    OrderType = type
                };
        }
        public void BatchOrder(List<BatchOrderItem> items)
        {
            var order = new PlaceBatchOrder()
            {
                AccountNo = AccountNo,
                OrderCounte = (uint)items.Count
            };
            items.ForEach(order.OrderList.Add);
            BatchOrder(order);
        }
        public void BatchOrder(PlaceBatchOrder order)
        {
            BatchOrder(Header(ID_S_ORDERS_REQT), order);
        }

        public void BatchOrder(RequestHeader header, PlaceBatchOrder order)
        {
            Channels.SendDealre(BuildMessage(header, order));
        }
        #endregion

        #region Order

        public PlaceOrder NewOrder(
            Exchange exchange,
            string code,
            string price,
            uint quantity,
            OrderSide side,
            OrderType type = OrderType.Limit,
            string origianId = ""
            )
        {
            return
                new PlaceOrder()
                {
                    AccountNo = AccountNo,
                    OrderOriginalId = string.IsNullOrEmpty(origianId) ? DateTime.Now.ToString("HHmmssfff") : origianId,
                    Exchange = exchange,
                    Code = code,
                    Price = price,
                    Quantity = quantity,
                    OrderSide = side,
                    OrderType = type
                };
        }

        public void Order(
            Exchange exchange, 
            string code, 
            string price, 
            uint quantity, 
            OrderSide side, 
            OrderType type = OrderType.Limit, 
            string origianId = ""
            )
        {
            var order = NewOrder(exchange, code, price, quantity, side, type, origianId);
            Order(order);
        }

        public void Order(PlaceOrder order)
        {
            Order(Header(ID_S_ORDER_REQT), order);
        }

        public void Order(RequestHeader header, PlaceOrder order)
        {
            Channels.SendDealre(BuildMessage(header, order));
        }

        #endregion

        #region Cancel
        public void Cancel(string exchangeId)
        {
            Cancel(
                new CancelOrder()
                {
                    AccountNo = AccountNo,
                    OrderExchangeId = exchangeId
                });
        }
        public void Cancel(CancelOrder cancel)
        {
            Cancel(Header(ID_S_DELETE_REQT), cancel);
        }
        public void Cancel(RequestHeader header, CancelOrder cancel)
        {
            Channels.SendDealre(BuildMessage(header, cancel));
        }
        #endregion

        #region QueryCapital

        public QueryCapitalResponse QueryCapital()
        {
            return
                QueryCapital(
                    new QueryCapitalRequest()
                    {
                        AccountNo = AccountNo,
                    });
        }
        public QueryCapitalResponse QueryCapital(QueryCapitalRequest payload)
        {
            return QueryCapital(Header(ID_S_Q_CAPITAL_REQT), payload);
        }
        public QueryCapitalResponse QueryCapital(RequestHeader header, QueryCapitalRequest payload)
        {
            NetMQMessage response = Channels.SendRequest(BuildMessage(header, payload));

            ResponseHeader responseHeader = ResponseHeader.Parser.ParseFrom(response.Pop().ToByteArray());
            WriteLog(responseHeader.ToString());

            QueryCapitalResponse responsePayload = QueryCapitalResponse.Parser.ParseFrom(response.Pop().ToByteArray());
            WriteLog(responsePayload.ToString());
            CapitalReceived?.Invoke(responsePayload);
            return responsePayload;
        }

        #endregion

        #region QueryPositions

        public QueryPositionResponse QueryPositions(
            Exchange exchange = Exchange.Undefined,
            string code = ""
            )
        {
            return
                QueryPositions(
                    new QueryPositionRequest()
                    {
                        AccountNo = AccountNo,
                        Code = code,
                        Exchange = exchange
                    });
        }
        public QueryPositionResponse QueryPositions(QueryPositionRequest payload)
        {
            return QueryPositions(Header(ID_S_Q_POSITION_REQT), payload);
        }
        public QueryPositionResponse QueryPositions(RequestHeader header, QueryPositionRequest payload)
        {
            NetMQMessage response = Channels.SendRequest(BuildMessage(header, payload));

            ResponseHeader responseHeader = ResponseHeader.Parser.ParseFrom(response.Pop().ToByteArray());
            WriteLog(responseHeader.ToString());

            QueryPositionResponse responsePayload = QueryPositionResponse.Parser.ParseFrom(response.Pop().ToByteArray());
            WriteLog(responsePayload.ToString());
            PositionsReceived?.Invoke(responsePayload);
            return responsePayload;
        }

        #endregion

        #region QueryOrder

        public QueryOrdersResponse QueryOrder(
            QueryOrderCriteria criteria = QueryOrderCriteria.QueryOrderAll,
            Exchange exchange = Exchange.Undefined,
            OrderSide side = OrderSide.Undefined,
            string code = "",
            string exchangeId = "",
            string originalId = ""
            )
        {
            return
                QueryOrder(
                    new QueryOrdersRequest()
                    {
                        AccountNo = AccountNo,
                        OrderExchangeId = exchangeId,
                        Code = code,
                        OrderOriginalId = originalId,
                        OrderSide = side,
                        QueryCriteria = criteria,
                        Exchange = exchange
                    });
        }
        public QueryOrdersResponse QueryOrder(QueryOrdersRequest payload)
        {
            return QueryOrder(Header(ID_S_Q_ORDERS_REQT), payload);
        }
        public QueryOrdersResponse QueryOrder(RequestHeader header, QueryOrdersRequest payload)
        {
            NetMQMessage response = Channels.SendRequest(BuildMessage(header, payload));

            ResponseHeader responseHeader = ResponseHeader.Parser.ParseFrom(response.Pop().ToByteArray());
            WriteLog(responseHeader.ToString());

            QueryOrdersResponse responsePayload = QueryOrdersResponse.Parser.ParseFrom(response.Pop().ToByteArray());
            WriteLog(responsePayload.ToString());
            OrdersReceived?.Invoke(responsePayload);
            return responsePayload;
        }

        #endregion

        #region QueryFill

        public QueryFillsResponse QueryFill(
            Exchange exchange = Exchange.Undefined,
            OrderSide side = OrderSide.Undefined,
            string code = "", 
            string exchangeId = "", 
            string originalId = "",
            bool includeCancelFill = true
            )
        {
            return
                QueryFill(
                    new QueryFillsRequest()
                    {
                        AccountNo = AccountNo,
                        OrderExchangeId = exchangeId,
                        Code = code,
                        OrderOriginalId = originalId,
                        OrderSide = side,
                        IncludeCancelFill = includeCancelFill,
                        Exchange = exchange
                    });
        }
        public QueryFillsResponse QueryFill(QueryFillsRequest payload)
        {
            return QueryFill(Header(ID_S_Q_DEAL_REQT), payload);
        }
        public QueryFillsResponse QueryFill(RequestHeader header, QueryFillsRequest payload)
        {
            NetMQMessage response = Channels.SendRequest(BuildMessage(header, payload));

            ResponseHeader responseHeader = ResponseHeader.Parser.ParseFrom(response.Pop().ToByteArray());
            WriteLog(responseHeader.ToString());

            QueryFillsResponse responsePayload = QueryFillsResponse.Parser.ParseFrom(response.Pop().ToByteArray());
            WriteLog(responsePayload.ToString());
            FillsReceived?.Invoke(responsePayload);
            return responsePayload;
        }
        
        #endregion

        private void WriteLog(string v)
        {
            LoggerReceived?.Invoke(v);
        }

        private RequestHeader Header(uint apiId)
        {
            return
                new RequestHeader()
                {
                    ApiId = apiId,
                    Token = Token == null?"":Token,
                    RequestId = Guid.NewGuid().ToString()
                };
        }

        private NetMQMessage BuildMessage(IMessage header, IMessage payload)
        {
            NetMQMessage result = new NetMQMessage();
            result.Push(payload.ToByteArray());
            result.Push(header.ToByteArray());
            return result;
        }
    }
}
