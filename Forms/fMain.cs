using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aptekaAprel
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        Query query = new Query();
        DataTable source;
        private void Form1_Load(object sender, EventArgs e)
        {
            source = query.FillData();
            loadTable();

            var favs = Methods.ReadFavs();
            if (favs == null)
                return;


            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].DisplayIndex = favs.FirstOrDefault(a => a.Name == gridView.Columns[i].Name).Index;
                gridView.Columns[i].Name = favs.FirstOrDefault(a => a.Name == gridView.Columns[i].Name).Name;
                gridView.Columns[i].Width = favs.FirstOrDefault(a => a.Name == gridView.Columns[i].Name).Width;
                gridView.Columns[i].Visible = favs.FirstOrDefault(a => a.Name == gridView.Columns[i].Name).Visible;
            }
        }
        private void CustomDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var cellHeaderStyle = gridView.ColumnHeadersDefaultCellStyle;
            for (int i = 0; i < gridView.ColumnCount; i++)
            {
                gridView.Columns[i].HeaderCell.Style = cellHeaderStyle;
            }
            var cellStyle = new DataGridViewCellStyle();
            cellStyle.Font = new Font(cellHeaderStyle.Font, FontStyle.Bold);
            gridView.Columns[e.ColumnIndex].HeaderCell.Style = cellStyle;
        }

        private void CustomDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < gridView.ColumnCount; i++)
            {
                if (gridView.Columns[i].HeaderCell.Style.Font.Bold)
                {
                    if (gridView.Columns[i].ValueType.Name != "String")
                        return;

                    var filterTable = new FilterTable();
                    filterTable.ShowDialog();

                    if (filterTable.search != "")
                    {
                        source = query.FillData($@"WHERE {gridView.Columns[i].Name} LIKE '%{filterTable.search}%'");

                        loadTable();
                        return;
                    }
                }
            }
        }
        private void CustomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellHeaderStyle = gridView.ColumnHeadersDefaultCellStyle;
            for (int i = 0; i < gridView.ColumnCount; i++)
            {
                gridView.Columns[i].HeaderCell.Style = cellHeaderStyle;
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
            if (gridView.Columns.Count < source.Columns.Count)
                return;

            var cols = new List<Columns>();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                cols.Add(new Columns()
                {
                    Index = gridView.Columns[i].DisplayIndex,
                    Width = gridView.Columns[i].Width,
                    Name = gridView.Columns[i].Name,
                    Visible = gridView.Columns[i].Visible
                });
                Methods.WriteFavs(cols);
            }
        }
        public void loadTable()
        {
            gridView.DataSource = null;
            gridView.DataSource = source;

            gridView.Refresh();
        }

        private void butImage_Click(object sender, EventArgs e)
        {
            var picture = new fImageSelect();
            picture.Show();
        }

        private void butDiscord_Click(object sender, EventArgs e)
        {
            var discord = new DiscordWebHook();
            discord.SendMessage("Test Message");
            MessageBox.Show("Сообщение успешно отправлено. Можно посмотреть: https://discord.gg/36RBbVuC . Действует до 30.08");
        }

        private void butMap_Click(object sender, EventArgs e)
        {
            var maps = new fMaps();
            maps.ShowDialog();
        }
    }
}