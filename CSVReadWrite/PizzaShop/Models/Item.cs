using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Models
{
    class Item
    {

        public int ID { get; set; }
        public int OrderId { get; set; }
        public Pizza Pizza { get; set; }
        public string Drink { get; set; }

        public Item(int iD, int orderId, Pizza pizza, string drink)
        {
            ID = iD;
            OrderId = orderId;
            Pizza = pizza;
            Drink = drink;
        }

        public override string ToString()
        {
            if(this.Pizza == null)
            {
                return $"{this.ID},{this.OrderId},,,{this.Drink}";
            }
            return $"{this.ID},{this.OrderId},{this.Pizza.GetCrust()},{this.Pizza.GetTopping()},{this.Drink}";
        }
    }
}
