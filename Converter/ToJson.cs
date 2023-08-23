using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace aptekaAprel.Converter
{
    internal class ToJson
    {
        internal static string Convert(DataTable dt)
        {
            return JsonConvert.SerializeObject(dt);
        }
    }
}
