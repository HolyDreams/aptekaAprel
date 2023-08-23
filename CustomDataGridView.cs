using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace aptekaAprel
{
    public partial class CustomDataGridView : DataGridView
    {

        Query query = new Query();
        DataTable source;
        public CustomDataGridView()
        {
            InitializeComponent();

            source = query.FillData();
            loadTable();

            var favs = Methods.ReadFavs();
            if (favs == null)
                return;


            for (int i = 0; i < Columns.Count; i++)
            {
                Columns[i].DisplayIndex = favs.FirstOrDefault(a => a.Name == Columns[i].Name).Index;
                Columns[i].Name = favs.FirstOrDefault(a => a.Name == Columns[i].Name).Name;
                Columns[i].Width = favs.FirstOrDefault(a => a.Name == Columns[i].Name).Width;
                Columns[i].Visible = favs.FirstOrDefault(a => a.Name == Columns[i].Name).Visible;
            }
        }
        private void CustomDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var cellHeaderStyle = ColumnHeadersDefaultCellStyle;
            for (int i = 0; i < ColumnCount; i++)
            {
                Columns[i].HeaderCell.Style = cellHeaderStyle;
            }
            var cellStyle = new DataGridViewCellStyle();
            cellStyle.Font = new Font(cellHeaderStyle.Font, FontStyle.Bold);
            Columns[e.ColumnIndex].HeaderCell.Style = cellStyle;
        }

        private void CustomDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < ColumnCount; i++)
            {
                if (Columns[i].HeaderCell.Style.Font.Bold)
                {
                    if (Columns[i].ValueType.Name != "String")
                        return;

                    var filterTable = new FilterTable();
                    filterTable.ShowDialog();
                    if (filterTable.search != "")
                    {
                        source = query.FillData($@"WHERE {Columns[i].Name} LIKE '%{filterTable.search}%'");

                        loadTable();
                        return;
                    }
                }
            }
        }
        private void CustomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellHeaderStyle = ColumnHeadersDefaultCellStyle;
            for (int i = 0; i < ColumnCount; i++)
            {
                Columns[i].HeaderCell.Style = cellHeaderStyle;
            }
        }

        private void CustomDataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            ColumnChange();
        }

        private void CustomDataGridView_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            ColumnChange();
        }
        private void ColumnChange()
        {
            if (Columns.Count < source.Columns.Count)
                return;

            var cols = new List<Columns>();
            for (int i = 0; i < Columns.Count; i++)
            {
                cols.Add(new Columns()
                {
                    Index = Columns[i].DisplayIndex,
                    Width = Columns[i].Width,
                    Name = Columns[i].Name,
                    Visible = Columns[i].Visible
                });
                Methods.WriteFavs(cols);
            }
        }
        public void loadTable()
        {
            DataSource = null;
            DataSource = source;

            Refresh();
        }
    }
}
