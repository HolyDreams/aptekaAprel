using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptekaAprel.Attribut
{
    public enum NpgsqlType : int
    {
        Array = -2147483648,
        Unknown = 0,
        Bigint = 1,
        Boolean = 2,
        Box = 3,
        Bytea = 4,
        Circle = 5
    }

    internal static class TextAttribute
    {
        public static string ToText(this NpgsqlType npgsqlType)
        {
            switch (npgsqlType)
            {
                case NpgsqlType.Array:
                    return "anyarray";
                case NpgsqlType.Unknown:
                    return "anyarray";
                case NpgsqlType.Bigint:
                    return "int8";
                case NpgsqlType.Boolean:
                    return "bool";
                case NpgsqlType.Box:
                    return "box";
                case NpgsqlType.Bytea:
                    return "bytea";
                case NpgsqlType.Circle:
                    return "circle";
                default:
                    return "error";
            }
        }
    }
}
