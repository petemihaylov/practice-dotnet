using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciples
{
    class AccountGenerator
    {
        public static void CreateAccount (Person user)
        {
            //Create username for the person 
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)} {user.LastName}");
        }
    }
}
