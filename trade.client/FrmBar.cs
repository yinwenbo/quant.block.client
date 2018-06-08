using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace trade.client
{
    public partial class FrmBar : Form
    {
        private List<Form> forms = new List<Form>();
        private bool FormMoveFlag = false;
        private Point FormMoveOffset;

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
            int x = MousePosition.X - Left;
            int y = MousePosition.Y - Top;
            FormMoveOffset = new Point(-x, -y);
            Console.WriteLine(string.Format("Offset {0}", FormMoveOffset));
            FormMoveFlag = true;
        }

        private void MoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!FormMoveFlag) return;
            Point location = MousePosition;
            Console.WriteLine(string.Format("Move Location {0}", location));
            location.Offset(FormMoveOffset.X, FormMoveOffset.Y);
            Console.WriteLine(string.Format("Move Offset Location {0}", location));
            Location = location;
        }

        private void MoveForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (FormMoveFlag) FormMoveFlag = false;
        }

        private void Menus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (FormMoveFlag) FormMoveFlag = false;
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
