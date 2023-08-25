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


        private void FMain_Load(object sender, System.EventArgs e)
        {
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