using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Pizza
    {

        private Crust crust;
        private Topping topping;

        // Pizza base price
        private const double price = 5.99;

        public Pizza(Crust crust, Topping topping)
        {
            this.crust = crust;
            this.topping = topping;
        }


        private double getCrustPrice(Crust type)
        {
            switch (type)
            {
                case Crust.thick: return 0.51;
                case Crust.filled: return 1.96;
                case Crust.thin: return 0;
                default: return 0;
            }
        }
        private double getToppingPrice(Topping type)
        {
            switch (type)
            {
                case Topping.formaggi: return 2;
                case Topping.stagioni: return 1.5;
                case Topping.pepperoni: return 1;
                case Topping.chicken: return 1;
                case Topping.margherita: return 0;
                default: return 0;
            }
        }

        public Topping GetTopping()
        {
            return this.topping;
        }
        public Crust GetCrust()
        {
            return this.crust;
        }


        public string GetCrustName() { return this.crust.ToString(); }
        public string GetToppingName()
        {
            switch (this.topping)
            {
                case Topping.margherita:
                    return "margherita";
                case Topping.formaggi:
                    return "quattro formaggi";
                case Topping.stagioni:
                    return "quattro stagioni";
                case Topping.chicken:
                    return "BBQ chicken";
                case Topping.pepperoni:
                    return "pepperoni";
                default:
                    return "";
            }
        }

        public double GetPizzaPrice() { return price + getCrustPrice(this.crust) + getToppingPrice(this.topping); }

        public string GetPizzaName() { return $"Pizza {this.GetToppingName()} - {this.GetCrustName()}"; }

    }
    enum Crust
    {
        thin,
        thick,
        filled
    }

    enum Topping
    {
        margherita,
        formaggi,
        stagioni,
        chicken,
        pepperoni
    }
}
