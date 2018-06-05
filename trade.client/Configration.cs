using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade.client
{

    public class ConfigLoader
    {
        private const string FileName = "config.json";

        public static ConfigLoader Load(string filename = FileName)
        {
            if (!File.Exists(filename)) return new ConfigLoader();

            string json = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<ConfigLoader>(json);
        }
        public static void Save(ConfigLoader configs, string filename = FileName)
        {
            string json = JsonConvert.SerializeObject(configs, Formatting.Indented);
            File.WriteAllText(filename, json);
        }

        public List<Config> Configs { set; get; }
        public List<string> Accounts { set; get; }

        public ConfigLoader()
        {
            Configs = new List<Config>();
            Accounts = new List<string>();
        }

        public void Save(string filename = FileName)
        {
            Save(this, filename);
        }
    }

    public class Config
    {
        public string Name { set; get; }

        public string TradeHost { set; get; }
        public int TradeOrderPort { set; get; }
        public int TradeReportPort { set; get; }
        public int TradeQueryPort { set; get; }

        public string ReferenceAddress { set; get; }
        public string Level2Address { set; get; }

        public string ComplianceHost { set; get; }
        public int ComplianceReportPort { set; get; }

    }

}
