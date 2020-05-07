using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class CsvFileWriter : StreamWriter
    {
        public CsvFileWriter(Stream stream) : base(stream) { }

        public CsvFileWriter(string filename) : base(filename) { }

        public void WriteRow(CsvRow row)
        {
            StringBuilder builder = new StringBuilder();
            bool firstColumnFlag = true;

            foreach (string value in row)
            {
                if (!firstColumnFlag)
                {
                    builder.Append(',');
                }

                /* 
                 * implement  handling for values that contain comma or quote
                 */

                if (value.IndexOfAny(new char[] { '"', ',' }) != -1)
                {
                    builder.AppendFormat("{0}", value.Replace("\"", "\"\""));
                }

                else { builder.Append(value); }

                firstColumnFlag = false;
            }
            row.LineText = builder.ToString();
            WriteLine(row.LineText);
        }

        public class CsvRow : List<string>
        {
            public string LineText { get; set; }
        }
    }
}
