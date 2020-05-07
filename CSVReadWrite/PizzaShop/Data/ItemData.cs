using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PizzaShop.Models;
using static PizzaShop.CsvFileWriter;

namespace PizzaShop.Data
{
    class ItemData
    {
        private string file = "Item.csv";

        public void Add(Item item)
        {
            using (FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write))
            {
                using (CsvFileWriter writer = new CsvFileWriter(fs))
                {
                    CsvRow row = new CsvRow();

                    row.Add(item.ToString());
                    writer.WriteRow(row);
                }
            }
        }

        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();

            using (CsvFileReader reader = new CsvFileReader(file))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    try {

                        Item item;
                        if (row.Count > 4)
                        {
                            // Only a drink
                            item = new Item(int.Parse(row[0]), int.Parse(row[1]), null, row[4]);
                        }
                        else
                        {
                            // Only Pizza
                            Enum.TryParse(row[2], out Crust crust);
                            Enum.TryParse(row[3], out Topping topping);

                            Pizza p = new Pizza(crust, topping);
                            item = new Item(int.Parse(row[0]), int.Parse(row[1]), p, null);

                        }

                        items.Add(item);

                    }
                    catch (FormatException ex)
                    {
                        // Save the exception to a custom log file
                    }

                }
            }

            return items;
        }

        public List<Item> GetItemsByOrderId(int orderId)
        {
            List<Item> items = new List<Item>();

            using (CsvFileReader reader = new CsvFileReader(file))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    try
                    {
                        if (int.Parse(row[1]) == orderId)
                        {
                            Item item;

                            
                            if (row.Count > 4)
                            {
                                // Only a drink
                                item = new Item(int.Parse(row[0]), int.Parse(row[1]), null, row[4]);
                            }
                            else
                            {
                                // Only Pizza
                                Enum.TryParse(row[2], out Crust crust);
                                Enum.TryParse(row[3], out Topping topping);

                                Pizza p = new Pizza(crust, topping);
                                item = new Item(int.Parse(row[0]), int.Parse(row[1]), p, null);

                            }

                            items.Add(item);

                        }

                    }
                    catch (FormatException ex)
                    {
                        // Save the exception to a custom log file
                    }
                }
            }

            return items;
        }

        public int GetLargestId(List<Item> list)
        {
            int max = 0;
            foreach (var item in list)
            {
                if (item.ID > max) max = item.ID;
            }
            return max;
        }

        public void DeleteByOrderId(int id)
        {
            List<Item> list = GetItems();

            File.WriteAllText(file, String.Empty);
            foreach (var i in list)
            {
                if (i.OrderId != id) Add(i);
            }

        }

    }
}
