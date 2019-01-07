using Quizes.DataBase;
using System.Collections.Generic;

namespace Quizes
{
    public static class DataTypes
    {
        public static List<string> Types => new List<string>
        {
            DataTypesR.String,
            DataTypesR.Char,
            DataTypesR.Int,
            DataTypesR.Long,
            DataTypesR.Float,
            DataTypesR.Decimal
        };
    }
}
