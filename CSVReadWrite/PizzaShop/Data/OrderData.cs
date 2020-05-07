using System;
using System.IO;
using System.Collections.Generic;
using static PizzaShop.CsvFileWriter;
using PizzaShop.Models;

namespace PizzaShop.Data
{
    class OrderData
    {
        private string file = "Order.csv";

        public void Add(Order order)
        {
            using (FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write))
            {
                using (CsvFileWriter writer = new CsvFileWriter(fs))
                {
                    CsvRow row = new CsvRow();

                    row.Add(order.ToString());
                    writer.WriteRow(row);
                }
            }
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            using (CsvFileReader reader = new CsvFileReader(file))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    try
                    {
                        
                        Order order = new Order(int.Parse(row[0]), int.Parse(row[1]), DateTime.Parse(row[2]), double.Parse(row[3])); 
                        orders.Add(order);
                    }
                    catch (FormatException ex)
                    {
                        // Save the exception to a custom log file
                    }

                }
            }

            return orders;
        }
        public List<Order> GetOrdersByClient(int customerId)
        {
            List<Order> orders = new List<Order>();

            using (CsvFileReader reader = new CsvFileReader(file))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    try
                    {
                        if (customerId == int.Parse(row[1]))
                        {

                            Order order = new Order(int.Parse(row[0]), int.Parse(row[1]), DateTime.Parse(row[2]), double.Parse(row[3]));
                            orders.Add(order);

                        }
                    }
                    catch (FormatException ex)
                    {
                        // Save the exception to a custom log file
                    }

                }
            }

            return orders;
        }
        public Order GetOrderById(int id)
        {
            foreach (var o in GetOrders())
            {
                if (o.ID == id) return o;
            }

            return null;
        }
        public void Update(Order order)
        {
            List<Order> list = GetOrders();
            File.WriteAllText(file, String.Empty);
            foreach (var o in list)
            {
                if (o.ID == order.ID) Add(order);
                else Add(o);
            }

            if (GetOrders().Count == 0) Add(order);

        }
        public void DeleteById(int id)
        {
            List<Order> list = GetOrders();

            File.WriteAllText(file, String.Empty);

            foreach (var o in list)
            {
                if (o.ID != id) Add(o);
            }

        }
        public int GetLargestId(List<Order> list)
        {
            int max = 0;
            foreach (var item in list)
            {
                if (item.ID > max) max = item.ID;
            }
            return max;
        }

    }
}
