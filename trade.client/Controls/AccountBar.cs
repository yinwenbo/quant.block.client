using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using trade.client.Trade;
using trade.client.Marketdata;
using Dwjk.Dtp;
using System.Threading;

namespace trade.client
{
    public partial class AccountBar : UserControl
    {
        public delegate void TradeClientChange(TradeClient client);


        public ToolStrip ToolStrip { get { return toolStrip1; } }
        public TradeClient Current { get; private set; }
        public TradeClientChange ClientChanged { set; get; }
        
        public AccountBar()
        {
            InitializeComponent();
        }

        private void OnParentFormShown(object sender, EventArgs e)
        {
            InitAccounts();
        }

        private void InitAccounts()
        {
            string selectedItem = comboAccountNo.Text;
            comboAccountNo.Items.Clear();
            TradeFacade.Accounts().ForEach((item) => { comboAccountNo.Items.Add(item); });
            if (comboAccountNo.Items.Count > 0 && string.IsNullOrEmpty(selectedItem))
            {
                comboAccountNo.SelectedIndex = 0;
            }
            else
            {
                comboAccountNo.SelectedItem = selectedItem;
            }
        }

        private void comboAccountNo_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrent(TradeFacade.GetClient(comboAccountNo.Text));
        }

        private void ChangeCurrent(TradeClient client)
        {
            if (Current != null)
            {
                Current.CapitalReceived -= Show;
            }
            client.CapitalReceived += Show;
            
            Thread thread = new Thread(new ThreadStart(() => { client.QueryCapital(); }));
            thread.Start();

            Current = client;
            ClientChanged?.Invoke(client);
        }
        
        private void Show(QueryCapitalResponse capital)
        {
            if (this.IsHandleCreated)
            {
                Invoke(new MethodInvoker(() =>
                {
                    ShowCapital(capital);
                }));
            }
        }

        private void ShowCapital(QueryCapitalResponse capital)
        {
            AvailableCash.Text = capital.Available;
            AvailableCash.ToolTipText = string.Format("可用资金: {0}", capital.Available);
            FrozenCash.Text = capital.Freeze;
            FrozenCash.ToolTipText = string.Format("冻结资金: {0}", capital.Freeze);
            MarketValue.Text = capital.Securities;
            MarketValue.ToolTipText = string.Format("总市值: {0}", capital.Securities);
            TotalAsset.Text = capital.Total;
            TotalAsset.ToolTipText = string.Format("总资产: {0}", capital.Total);
        }

        private void AccountToolbar_Load(object sender, EventArgs e)
        {
            InitAccounts();
        }
    }
}
