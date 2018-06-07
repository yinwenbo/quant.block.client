using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trade.client.UIUtils
{
    public class DefaultGridView<T>
    {
        private DataGridView _Grid;
        private BindingSource _BindingSource = new BindingSource();
        private List<T> _List = new List<T>();

        public DefaultGridView(DataGridView view)
        {
            _Grid = view;
            InitialGrid(view);
            _BindingSource.DataSource = _List;
            _Grid.DataSource = _BindingSource;
        }

        public void InitialGrid(DataGridView view)
        {
            view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            view.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            view.RowHeadersWidth = 60;

            view.ReadOnly = true;
            view.AllowUserToAddRows = false;
            view.AllowUserToDeleteRows = false;
            view.AllowUserToOrderColumns = true;
            view.MultiSelect = true;
            view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            view.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;

            view.ShowCellErrors = false;
            view.ShowCellToolTips = false;
            view.ShowEditingIcon = false;
            view.ShowRowErrors = false;

            view.RowStateChanged += Grid_RowAdded;
        }

        public void Grid_RowAdded(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        public void Clear()
        {
            _BindingSource.Clear();
        }

        public void Add(T item)
        {
            _BindingSource.Add(item);
        }
        public void Add(List<T> items)
        {
            items.ForEach((item) => { _BindingSource.Add(item); });
        }

        public T Get(int index)
        {
            return _List[index];
        }
    }
}
