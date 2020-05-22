using System;

namespace DRY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input FirstName: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Input LastName: ");
            var lastName = Console.ReadLine();

            string employeeId = new EmployeeProcessor().GenerateEmployeeId(firstName, lastName);
        }

    }
}
