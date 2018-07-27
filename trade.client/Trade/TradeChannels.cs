using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NetMQ;
using NetMQ.Sockets;

namespace trade.client.Trade
{
    public class TradeChannels
    {
        public delegate void SubscribeReceived(NetMQMessage message);

        public string RequestAddress { set; get; }
        public string SubscribeAddress { set; get; }
        public string DealerAddress { set; get; }
        public string ConfigAddress { set; get; }

        public SubscribeReceived OnSubscribeRecieved { set; get; }

        private SubscriberSocket subscriber;
        private NetMQPoller subscriberPoller;

        public void ConnectSubscribe()
        {
            subscriber = new SubscriberSocket();
            subscriber.Connect(SubscribeAddress);
            subscriber.ReceiveReady += _Subscire_ReceiveReady;
            subscriber.SubscribeToAnyTopic();

            subscriberPoller = new NetMQPoller { subscriber };
            subscriberPoller.RunAsync();
        }

        private void _Subscire_ReceiveReady(object sender, NetMQSocketEventArgs e)
        {
            
            var msg = subscriber.ReceiveMultipartMessage();
            OnSubscribeRecieved?.Invoke(msg);
        }

        public NetMQMessage SendRequest(NetMQMessage message)
        {
            RequestSocket request = new RequestSocket();
            request.Connect(RequestAddress);
            request.SendMultipartMessage(message);
            return request.ReceiveMultipartMessage();
        }

        public void SendDealre(NetMQMessage message)
        {
            DealerSocket request = new DealerSocket();
            request.Connect(DealerAddress);
            request.SendMultipartMessage(message);
        }
    }
}
