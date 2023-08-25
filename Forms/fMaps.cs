using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aptekaAprel
{
    public partial class fMaps : Form
    {
        string endJS = "";
        string path = Path.Combine(Directory.GetCurrentDirectory()) + "/index.html";
        public fMaps()
        {
            InitializeComponent();
        }

        private void fMaps_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("file:///" + path);
        }

        private void butAddPoint_Click(object sender, EventArgs e)
        {
            var addPoint = new fAddPoint();
            addPoint.ShowDialog();
            if (addPoint.newPoint == null)
                return;

            chromiumWebBrowser1.ExecuteScriptAsync(CreateJSPoint(addPoint.newPoint));
            chromiumWebBrowser1.ExecuteScriptAsync("document.getElementById('ButtonAddObject').click()");

        }

        private void butAddCircle_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.ExecuteScriptAsync(CreateJSCircle());
            chromiumWebBrowser1.ExecuteScriptAsync("document.getElementById('ButtonAddCircle').click()");

        }

        private string CreateJSPoint(MapPoint point)
        {
            return $"addGeoObject(\"Point\", {point.CoordinateX}, {point.CoordinateY}, \"{point.Name}\", \"{point.Description}\", 'blackStretchyIcon', true)";
        }
        private string CreateJSCircle()
        {
            return $"addCircleObject(55, 37, 100000, \"Тестовый круг\", \"Описание\", true, \"#DB709377\", \"#990066\")";
        }
    }
}
