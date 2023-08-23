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
    public partial class FilterTable : Form
    {
        public FilterTable()
        {
            InitializeComponent();
        }
        public string search;
        private void butAccept_Click(object sender, EventArgs e)
        {
            search = textSearch.Text;
            this.Close();
        }
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
