using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Data
{
    static class TxtFileWriter
    {
        public static bool PrintReceiptFor(List<string> lines)
        {
            const string path = "Receipt.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        lines.ForEach(l => sw.WriteLine(l));
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
