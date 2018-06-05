using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace trade.client
{
    public partial class FrmBar : Form
    {
        List<Form> forms = new List<Form>();

        public FrmBar()
        {
            InitializeComponent();
            InitToolbar();
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
