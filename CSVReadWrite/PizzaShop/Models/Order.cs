using System;
using System.Collections.Generic;

namespace PizzaShop.Models
{
    class Order
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public DateTime Timestamp { get; set; }
        public List<Item> items { get; set; }
        public double TotalPrice { get; set; }

        public Order(int iD, int customerId, DateTime timestamp, double totalPrice = 0.00)
        {
            ID = iD;
            Timestamp = timestamp;
            CustomerId = customerId;
            TotalPrice = totalPrice;
        }

        public override string ToString()
        {
            return $"{this.ID},{this.CustomerId},{this.Timestamp.ToString()},{this.TotalPrice}";
        }
    }
}
