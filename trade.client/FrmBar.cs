using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace trade.client
{
    public partial class FrmBar : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
 
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
 
        private const int VM_NCLBUTTONDOWN = 0XA1;//定义鼠标左键按下
        private const int HTCAPTION = 2;

        private List<Form> forms = new List<Form>();

        public FrmBar()
        {
            InitializeComponent();
            InitToolbar();
        }

        private void InitToolbar()
        {
            QuickBar.Items.Clear();
            foreach(var pair in FunctionList.QuickBar)
            {
                QuickBar.Items.Add(BindButton(pair.Key, pair.Value));
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            //为当前应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
        }


        private void Menus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
