using System;
using System.Collections.Generic;

namespace PizzaShop
{
    static class Drink
    {
         private static Dictionary<string, double> drinks = new Dictionary<string, double>()
            {
                {"Flat water", 2.50},
                { "Sparkling water", 2.50},
                { "Cola", 2.75},
                { "Ice tea", 2.75},
                { "Energy drink", 3.75}
            };


        public static double GetPriceByName(string name)
        {
            if (drinks.ContainsKey(name.Trim()))
                return drinks[name];

            return 0;
        }

    }
}
