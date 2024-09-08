using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelDocSQLGenerator
{
    internal class SQLComponent
    {
        public string type { get; set; }
        public string sql { get; set; }
        public int colIndex { get; set; }
        public bool includeTicks { get; set; }
        public bool allowNull { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        public SQLComponent(string type)
        {
            this.type = type;
        }

        /// <summary>
        /// Converts an index into it's Excel Letter
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string NumberToExcelColumn(int number)
        {
            string columnName = string.Empty;

            while (number >= 0)
            {
                int remainder = number % 26;
                columnName = (char)(65 + remainder) + columnName;
                number = (number / 26) - 1;
            }

            return columnName;
        }


        /// <summary>
        /// Writes out a fancy representation of the column
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (type == "S")
            {
                return sql;
            }
            else
            {
                return "<" + (includeTicks ? "'" : "")
                    + "COL " + NumberToExcelColumn(colIndex)
                    + (includeTicks ? "'" : "") + ">";
            }
        }
    }
}
