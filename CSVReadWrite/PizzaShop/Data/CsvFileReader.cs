using System;
using System.IO;
using static PizzaShop.CsvFileWriter;

namespace PizzaShop
{
    class CsvFileReader : StreamReader
    {
        public CsvFileReader(Stream stream) : base(stream) { }

        public CsvFileReader(string filename) : base(filename) { }

        public bool ReadRow(CsvRow row)
        {
            row.LineText = ReadLine();

            if (String.IsNullOrEmpty(row.LineText))
            {
                return false;
            }

            int pos = 0;
            int rows = 0;

            while (pos < row.LineText.Length)
            {
                string value;

                if (row.LineText[pos] == '"')
                {
                    // skip initial quote
                    pos++;

                    int start = pos;
                    while (pos < row.LineText.Length)
                    {
                        // test for quote character
                        if (row.LineText[pos] == '"')
                        {
                            // found one
                            pos++;

                            // If two quotes together, keep one
                            // Otherwise, indicates end of value
                            if (pos >= row.LineText.Length || row.LineText[pos] != '"')
                            {
                                pos--;
                                break;
                            }
                        }
                        pos++;
                    }
                    value = row.LineText.Substring(start, pos - start);
                    value = value.Replace("\"\"", "\"");
                }
                else
                {
                    // Parse unquoted value
                    int start = pos;
                    while (pos < row.LineText.Length && row.LineText[pos] != ',')
                        pos++;
                    value = row.LineText.Substring(start, pos - start);
                }

                // Add field to list
                if (rows < row.Count)
                    row[rows] = value;
                else
                    row.Add(value);
                rows++;

                // Eat up to and including next comma
                while (pos < row.LineText.Length && row.LineText[pos] != ',')
                    pos++;
                if (pos < row.LineText.Length)
                    pos++;
            }
            // Delete any unused items
            while (row.Count > rows)
                row.RemoveAt(rows);

            // Return true if any columns read
            return (row.Count > 0);
        }
    }
}
