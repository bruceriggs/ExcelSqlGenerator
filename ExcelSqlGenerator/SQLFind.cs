using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelDocSQLGenerator
{
    internal class SQLFind
    {
        public int colIndex { get; set; }
        public string find { get; set; }
        public string replace { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public SQLFind()
        {
            colIndex = 0;
            find = "";
            replace = "";
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
        /// Displays Find/Replace Data for a Column
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return NumberToExcelColumn(colIndex) + ": " + find + " -> " + replace;
        }
    }
}
