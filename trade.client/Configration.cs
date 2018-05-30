using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade.client
{
    public class Configration
    {
        private static string FileName = "config.json";

        public static Configration Load()
        {
            if (!File.Exists(FileName)) return new Configration();

            string json = File.ReadAllText("config.json");
            return JsonConvert.DeserializeObject<Configration>(json);
        }
        public static void Save(Configration configration)
        {
            string json = JsonConvert.SerializeObject(configration, Formatting.Indented);
            File.WriteAllText(FileName, json);
        }
        public Configration()
        {
            Accounts = new List<string>();
            TradeServers = new List<TradeServer>();
            Level2Servers = new List<Level2Server>();
        }
        public List<string> Accounts { set; get; }
        public List<TradeServer> TradeServers { set; get; }
        public List<Level2Server> Level2Servers { set; get; }
    }

    public class TradeServer
    {
        public string Name { set; get; }
        public string Host { set; get; }
        public int OrderPort { set; get; }
        public int ReportPort { set; get; }
        public int QueryPort { set; get; }

        public string OrderAddress()
        {
            return BuildAddress(Host, OrderPort);
        }
        public string ReportAddress()
        {
            return BuildAddress(Host, ReportPort);
        }

        public string QueryAddress()
        {
            return BuildAddress(Host, QueryPort);
        }

        private string BuildAddress(string host, int port)
        {
            return string.Format("{0}:{1}", host.TrimEnd(':'), port);
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is TradeServer)) return false;
            return string.Equals(Name, ((TradeServer)obj).Name);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

    public class Level2Server
    {
        public string Name { set; get; }
        public string Address { set; get; }
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Level2Server)) return false;
            return string.Equals(Name, ((Level2Server)obj).Name);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
