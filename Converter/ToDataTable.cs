using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptekaAprel.Converter
{
    internal class ToDataTable
    {
        internal static DataTable Convert(string json)
        {
            return (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
        }
    }
}
