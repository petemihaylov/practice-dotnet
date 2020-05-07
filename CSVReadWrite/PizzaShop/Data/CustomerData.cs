using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PizzaShop.CsvFileWriter;

namespace PizzaShop.Data
{
    class CustomerData
    {
        private string file = "Customer.csv";

        public void Add(Customer customer)
        {
            using (FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write))
            {
                using (CsvFileWriter writer = new CsvFileWriter(fs))
                {
                    CsvRow row = new CsvRow();

                    row.Add(customer.ToString());
                    writer.WriteRow(row);
                }
            }
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (CsvFileReader reader = new CsvFileReader(file))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    try
                    {
                        Customer c = new Customer(int.Parse(row[0]), row[1].Trim(), row[2].Trim());
                        customers.Add(c);
                    }
                    catch (FormatException ex)
                    {
                        // Save the exception to a custom log file
                    }

                }
            }

            return customers;
        }
        
        public Customer GetCustomerById(int id)
        {
            using (CsvFileReader reader = new CsvFileReader(file))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    try
                    {
                        if(int.Parse(row[0]) == id)
                        {
                            return new Customer(int.Parse(row[0]), row[1], row[2]);
                        }

                    }
                    catch (FormatException ex)
                    {
                        // Save the exception to a custom log file
                    }

                }
            }
            return null;
        }
        public void UpdateById(Customer customer, List<Customer> list)
        {
            File.WriteAllText(file, String.Empty);
            foreach (var c in list)
            {
                if (c.ID == customer.ID) Add(customer);
                else Add(c);
            }

            if (list.Count == 0) Add(customer);

        }

        public void DeleteById(Customer customer, List<Customer> list)
        {
            File.WriteAllText(file, String.Empty);
            foreach (var c in list)
            {
                if (c.ID != customer.ID) Add(c);
            }
        }
        public int GetLargestId(List<Customer> list)
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
