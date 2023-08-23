using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptekaAprel
{
    internal class Favorites
    {
        public Guid ID { get; set; }
        public List<Columns> Col  { get; set; }
    }
    internal class Columns
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public int Width { get; set; }
        public bool Visible { get; set; }
    }
    public class MapPoint
    {
        public string Coordinates { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
