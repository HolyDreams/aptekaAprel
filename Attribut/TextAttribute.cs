using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptekaAprel.Attribut
{
    public enum NpgsqlType : int
    {
        [Text("anyarray")]
        Array = -2147483648,
        Unknown = 0,
        [Text("int8")]
        Bigint = 1,
        [Text("bool")]
        Boolean = 2,
        [Text("box")]
        Box = 3,
        [Text("bytea")]
        Bytea = 4,
        [Text("circle")]
        Circle = 5
    }
    public static class AttributesHelper
    {
        public static string ToText(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            if (field == null)
                return default;

            var text = field.GetCustomAttributes(typeof(TextAttribute), false);

            if (text.Length == 0)
                return default;

            return ((TextAttribute)text[0]).temp;
        }
    }
    public class TextAttribute : Attribute
    {
        public string temp { get; set; }
        public TextAttribute(string a)
        {
            temp = a;
        }
        public override string ToString()
        {
            return temp;
        }
    }
}
