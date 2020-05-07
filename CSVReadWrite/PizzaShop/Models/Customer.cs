using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(int id, string name, string email)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"{this.ID},{this.Name},{this.Email}";
        }
    }
}
