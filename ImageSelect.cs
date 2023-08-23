using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aptekaAprel
{
    public partial class ImageSelect : Form
    {
        public ImageSelect()
        {
            InitializeComponent();
            this.pictureBox1.MouseWheel += PictureBox1_MouseWheel;
        }
        Point StartPoint;
        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                pictureBox1.Width += 50;
                pictureBox1.Height += 50;
            }
            else if (e.Delta < 0)
            {
                pictureBox1.Width -= 50;
                pictureBox1.Height -= 50;
            }
        }

        private void butSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Выберите изображение";
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    butLeft90.Enabled = true;
                    butRight90.Enabled = true;
                }
            }
        }

        private void butLeft90_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
            
            //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        private void butRight90_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                StartPoint = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pb = (PictureBox)sender;
                Point pt = pb.Location;
                pt.Offset(e.X - StartPoint.X, e.Y - StartPoint.Y);
                pb.Location = pt;
            }
        }
    }
}
