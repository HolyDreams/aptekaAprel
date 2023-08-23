using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            endJS = $@";
}};
</script>
</head>
	<style>
        html, body, #map {{
            width: 100%; height: 100%; padding: 0; margin: 0;
        }}
    </style>
</head>
<body>
    <div id=""map""></div>
</body>
</html>
";
            createHTML("");
            chromiumWebBrowser1.LoadUrl("file:///" + path);
        }

        private void butAddPoint_Click(object sender, EventArgs e)
        {
            var addPoint = new fAddPoint();
            addPoint.ShowDialog();
            if (addPoint.newPoint == null)
                return;

            createJS.loadJS(addPoint.newPoint);
            createHTML(createJS.jsScript);
            chromiumWebBrowser1.LoadUrl("file:///" + path);

        }

        private void butAddCircle_Click(object sender, EventArgs e)
        {
            string js = File.ReadAllText("index.html");
            js = js.Substring(0, js.Length - endJS.Length);
            js += ";" + Environment.NewLine + $@"var myCircle = new ymaps.Circle([
            [45.035470, 38.975313],
            10000
        ], {{}}, {{
            fillColor: ""#DB709377"",
            strokeColor: ""#990066"",
            strokeOpacity: 0.8,
            strokeWidth: 5
        }});

    myMap.geoObjects.add(myCircle);

    myCircle.editor.startEditing();" + endJS;
            File.WriteAllText("index.html", js);

            chromiumWebBrowser1.LoadUrl("file:///" + path);
        }
        private void createHTML(string text)
        {
            string index = $@"<!DOCTYPE html>
<html>
<head>
    <title>Добавление метки на карту</title>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <!--
        Укажите свой API-ключ. Тестовый ключ НЕ БУДЕТ работать на других сайтах.
        Получить ключ можно в Кабинете разработчика: https://developer.tech.yandex.ru/keys/
    -->
    <script src=""https://api-maps.yandex.ru/2.1/?lang=ru_RU&amp;apikey=18713f91-5e4a-4311-bbe5-2cf766abebcb"" type=""text/javascript""></script>
    <script type=""text/javascript"">
        // Как только будет загружен API и готов DOM, выполняем инициализацию
        ymaps.ready(init);
        var myMap;
        function init() {{
            // Создание экземпляра карты и его привязка к контейнеру с
            // заданным id (""map"")
            myMap = new ymaps.Map('map', {{
                // При инициализации карты, обязательно нужно указать
                // ее центр и коэффициент масштабирования
                center: [45.035470, 38.975313], // Краснодар
                zoom: 12,
                controls: []
            }})" + text + endJS;
            File.WriteAllText(path, index);
        }
    }
}
