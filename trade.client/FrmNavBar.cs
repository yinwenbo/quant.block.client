using System;
using System.Collections.Generic;
using System.Windows.Forms;
using trade.client.Trade;

namespace trade.client
{
    public partial class FrmNavBar : Form
    {
        FrmLogin frmLogin;
        TradeClient tradeAdapter;
        List<Form> forms = new List<Form>();

        public FrmNavBar()
        {
            InitializeComponent();
            frmLogin = new FrmLogin();
            frmLogin.OnLoginSuccess += On_LoginSuccess;
            InitPreLoginToolbar();
        }

        private void On_LoginSuccess(TradeClient adapter)
        {
            tradeAdapter = adapter;
            frmLogin.Hide();
            InitToolbar();
        }

        private void InitPreLoginToolbar()
        {
            toolStrip.Items.Clear();
            toolStrip.Items.Add("登录").Click += ShowLogin;
        }

        private void InitToolbar()
        {
            toolStrip.Items.Clear();
            foreach(var pair in FunctionList.QuickBar)
            {
                toolStrip.Items.Add(BindButton(pair.Key, pair.Value));
            }
        }

        private ToolStripButton BindButton(string text, Type formType)
        {
            ToolStripButton button = new ToolStripButton(text);
            button.Click += Button_Click;
            button.Tag = formType;
            return button;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripButton)) return;
            
            Type type = (Type)((ToolStripButton)sender).Tag;
            Form form = (Form)type.GetConstructor(new Type[0]).Invoke(new object[0]);
            form.FormClosed += On_Form_Closed;
            forms.Add(form);
            form.Show();
        }

        private void On_Form_Closed(object sender, FormClosedEventArgs e)
        {
            forms.Remove((Form)sender);
        }

        private void ShowLogin(object sender, EventArgs e)
        {
            frmLogin.ShowDialog();

        }

        private void FrmNavBar_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                for(int i = forms.Count; i > 0; i--)
                {
                    forms[i - 1].Close();
                }
                Environment.Exit(0);
            }
            catch (Exception)
            {

            }
            
        }
    }
}
