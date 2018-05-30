using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using trade.client.Marketdata;
using trade.client.Trade;

namespace trade.client
{
    public partial class FrmLogin : Form
    {
        public delegate void LoginSuccess(TradeClient adapter);

        public LoginSuccess OnLoginSuccess { set; get; }
        private Configration configration;

        public FrmLogin()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            configration = Configration.Load();

            TradeServerList.DataSource = configration.TradeServers;
            Level2ServerList.DataSource = configration.Level2Servers;
            TradeConfigList.DataSource = configration.TradeServers;
            Level2ConfigList.DataSource = configration.Level2Servers;
            AccountList.DataSource = configration.Accounts;

            if (configration.Level2Servers.Count == 0
                || configration.TradeServers.Count == 0)
            {
                ConfigView();
            } else
            {
                LoginView();
            }
        }
        private void ConfigView()
        {
            this.Width = 538;
        }
        private void LoginView()
        {
            this.Width = 256;
        }
        
        private void ShowConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigView();
        }

        private void Upsert(Level2Server server)
        {
            var existsed = configration.Level2Servers.Find((item) => { return item.Equals(server); });
            if (existsed != null)
            {
                configration.Level2Servers.Remove(existsed);
            }
            configration.Level2Servers.Insert(0, server);
            Configration.Save(configration);
            TradeServerList.DataSource = configration.TradeServers;
            TradeConfigList.DataSource = configration.TradeServers;
        }
        private void Upsert(TradeServer server)
        {
            var existsed = configration.TradeServers.Find((item) => { return item.Equals(server); });
            if (existsed != null)
            {
                configration.TradeServers.Remove(existsed);
            }
            configration.TradeServers.Insert(0, server);
            Configration.Save(configration);
            Level2ServerList.DataSource = configration.Level2Servers;
            Level2ConfigList.DataSource = configration.Level2Servers;

        }
        private void TradeItemSave_Click(object sender, EventArgs e)
        {
            TradeServer tradeServer =
                new TradeServer()
                {
                    Name = TradeConfigList.Text,
                    Host = TradeHost.Text,
                    OrderPort = int.Parse(TradeOrderPort.Text),
                    ReportPort = int.Parse(TradeReportPort.Text),
                    QueryPort = int.Parse(TradeQueryPort.Text)
                };
            Upsert(tradeServer);
        }

        private void Level2ItemSave_Click(object sender, EventArgs e)
        {
            Level2Server server =
                new Level2Server()
                {
                    Name = Level2ConfigList.Text,
                    Address = Level2Address.Text
                };
            Upsert(server);
        }

        private void TradeConfigList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TradeServer server = configration.TradeServers[TradeConfigList.SelectedIndex];
            TradeHost.Text = server.Host;
            TradeOrderPort.Text = server.OrderPort.ToString();
            TradeReportPort.Text = server.ReportPort.ToString();
            TradeQueryPort.Text = server.QueryPort.ToString();
        }

        private void TradeItemDelete_Click(object sender, EventArgs e)
        {
            var existsed = configration.TradeServers.Find((item) => { return string.Equals(item.Name, TradeConfigList.Text); });
            if (existsed != null)
            {
                configration.TradeServers.Remove(existsed);
            }
            TradeServerList.DataSource = configration.TradeServers;
            TradeConfigList.DataSource = configration.TradeServers;
        }

        private void Level2ItemDelete_Click(object sender, EventArgs e)
        {
            var existsed = configration.Level2Servers.Find((item) => { return string.Equals(item.Name, Level2ConfigList.Text); });
            if (existsed != null)
            {
                configration.Level2Servers.Remove(existsed);
            }
            Level2ServerList.DataSource = configration.Level2Servers;
            Level2ConfigList.DataSource = configration.Level2Servers;
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Login.Focus();
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (TradeServerList.SelectedIndex <0)  MessageBox.Show("请选择交易服务器");
            if (Level2ServerList.SelectedIndex < 0) MessageBox.Show("请选择行情服务器");

            try
            {
                TradeServer tradeServer = configration.TradeServers[TradeServerList.SelectedIndex];
                string account = AccountList.Text;
                TradeClient adapter = TradeClient.Create(
                    account,
                    txtPassword.Text,
                    tradeServer.QueryAddress(),
                    tradeServer.OrderAddress(),
                    tradeServer.ReportAddress()
                    );
                Level2Server level2Server = configration.Level2Servers[Level2ServerList.SelectedIndex];
                StockFaced.ConnectL1("http://192.168.211.251:8600");
                StockFaced.ConnectL2(level2Server.Address);
                Thread thread = new Thread(new ThreadStart(StockFaced.UpdateStock));
                thread.Start();
                OnLoginSuccess?.Invoke(adapter);
                if (!configration.Accounts.Exists((a) => { return string.Equals(a, account); }))
                {
                    configration.Accounts.Insert(0, account);
                    Configration.Save(configration);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
