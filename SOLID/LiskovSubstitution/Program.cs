using LiskovSubstitution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {

            IManager manager = new CEO();
            manager.FirstName = "Emma";
            manager.LastName = "Stone";
            manager.CalculatePerHourRate(4);

            IManaged emp= new Employee();

            emp.FirstName = "Petar";
            emp.LastName = "Mihaylov";
            emp.AssignManager(manager);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            Console.ReadLine();

          
        }
    }
}
