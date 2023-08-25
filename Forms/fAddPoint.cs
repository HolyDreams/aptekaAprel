using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aptekaAprel
{
    public partial class fAddPoint : Form
    {
        public fAddPoint()
        {
            InitializeComponent();
        }

        public MapPoint newPoint;
        private void butAccept_Click(object sender, EventArgs e)
        {
            newPoint = new MapPoint()
            {
                CoordinateX = double.Parse(textX.Text),
                CoordinateY = double.Parse(textY.Text),
                Name = textName.Text,
                Description = textDesc.Text
            };
            this.Close();
        }

        private void textX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
