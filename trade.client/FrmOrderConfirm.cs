using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trade.client
{
    public partial class FrmOrderConfirm : Form
    {

        private static FrmOrderConfirm instance = new FrmOrderConfirm();
        private static List<object> emptyList = new List<object>();

        public static bool Show(object data)
        {
            return ShowList(new List<object> { data });
        }
        public static bool ShowList(object list)
        {
            instance.Data = list;
            instance.IsConfirm = false;
            instance.ShowDialog();
            instance.Grid.DataSource = emptyList;
            return instance.IsConfirm;
        }

        public bool IsConfirm { get; private set; }
        public object Data { set; get; }

        public FrmOrderConfirm()
        {
            InitializeComponent();
            IsConfirm = false;
            Grid.RowStateChanged += RowAdded;
            Message.Text = "";
        }

        private void FrmOrderConfirm_Shown(object sender, EventArgs e)
        {
            Grid.DataSource = Data;
            Message.Text = string.Format("共 {0} 条", Grid.RowCount);

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            IsConfirm = true;
            this.Close();
        }

        private void Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsConfirm = false;
            this.Close();
        }
        private void RowAdded(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
