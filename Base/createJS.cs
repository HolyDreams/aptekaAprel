using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptekaAprel
{
    internal class createJS
    {
        public static string jsScript;
        static List<MapPoint> points = new List<MapPoint>();
        public static void loadJS(MapPoint newPoint)
        {
            points.Add(newPoint);
            jsScript = "," + CreateJSPoint(points).TrimEnd(',') + $@";
myMap.geoObjects
" + CreatePointObjects(points.Count);
        }

        private static string CreateJSPoint(List<MapPoint> allPoints)
        {
            string result = "";
            string script = Environment.NewLine + @"myGeoObject{0} = new ymaps.GeoObject({{
            geometry: {{
                type: ""Point"",
                coordinates: {1}
            }},
            properties: {{
                iconContent: '{2}',
                hintContent: '{3}'
            }}
        }}, {{
            preset: 'islands#blackStretchyIcon',
            draggable: 'trueion'
        }}),";
            for (int i = 0; i < allPoints.Count; i++)
            {
                result += string.Format(script, i, allPoints[i].Coordinates, allPoints[i].Name, allPoints[i].Description);
            }

            return result;
        }
        private static string CreatePointObjects(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += ".add(myGeoObject" + i + ")" + Environment.NewLine;
            }
            return result;
        }
    }
}
