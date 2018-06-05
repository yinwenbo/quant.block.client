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
        private const int ConfigWidth = 638;
        private const int LoginWidth = 256;

        private ConfigLoader ConfigLoader = ConfigLoader.Load();
        public FrmLogin()
        {
            InitializeComponent();
            InitialView();
        }
        private void InitialView()
        {
            Bind(ConfigList, ConfigLoader.Configs);
            ConfigList.DisplayMember = "Name";
            Bind(AccountList, ConfigLoader.Accounts);

            if (ConfigLoader.Configs.Count == 0)
            {
                ConfigView();
            } else
            {
                LoginView();
            }
        }
        private void Bind(ComboBox combo, object list)
        {
            combo.DataSource = new BindingSource
            {
                DataSource = list
            };
        }
        private void RefreshData(ComboBox combo)
        {
            ((BindingSource)combo.DataSource).ResetBindings(false);
            UpdateConfigView();
        }
        private void ConfigView()
        {
            this.Width = ConfigWidth;
        }
        private void LoginView()
        {
            this.Width = LoginWidth;
        }
        
        private void ShowConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigView();
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Login.Focus();
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void ConfigList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateConfigView();
        }
        private void UpdateConfigView()
        {
            ConfigGrid.SelectedObject = CurrentConfig();
        }
        private Config CurrentConfig()
        {
            return (Config)ConfigList.SelectedItem;
        }
        private string CurrentAccount()
        {
            return AccountList.Text.Trim();
        }
        private void DoLogin()
        {
            Config config = CurrentConfig();
            string account = CurrentAccount();

            if (config == null)
            {
                MessageBox.Show("请选择服务配置");
                return;
            }
            if (String.IsNullOrEmpty(account))
            {
                MessageBox.Show("请输入账号");
                return;
            }
            try
            {
                SaveConfig();
                TradeClient adapter = TradeClient.Create(
                    account,
                    txtPassword.Text,
                    config.TradeHost,
                    config.TradeQueryPort,
                    config.TradeOrderPort,
                    config.TradeReportPort
                    );
                StockFaced.ConnectL1(config.ReferenceAddress);
                StockFaced.ConnectL2(config.Level2Address);
                StockFaced.UpdateStockAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveConfig()
        {
            string account = CurrentAccount();
            if (ConfigLoader.Accounts.Exists(account.Equals))
                ConfigLoader.Accounts.Remove(account);
            ConfigLoader.Accounts.Insert(0, account);

            Config config = CurrentConfig();
            if (ConfigLoader.Configs.Exists(config.Equals))
                ConfigLoader.Configs.Remove(config);
            ConfigLoader.Configs.Insert(0, config);

            ConfigLoader.Save();
        }

        private void ConfigAdd_Click(object sender, EventArgs e)
        {
            Config config = new Config
            {
                Name = "config"
            };
            ConfigLoader.Configs.Insert(0, config);
            RefreshData(ConfigList);
        }

        private void ConfigDel_Click(object sender, EventArgs e)
        {
            Config config = CurrentConfig();
            string msg = string.Format("删除配置 {0} ?", config.Name);
            if(MessageBox.Show(msg, "删除确认", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                ConfigLoader.Configs.Remove(config);
                ConfigLoader.Save();
                RefreshData(ConfigList);
            }
        }

        private void ConfigGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (String.Equals(e.ChangedItem.Label, "Name"))
            {
                RefreshData(ConfigList);
            }
        }
    }
}
