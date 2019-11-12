using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    class StandartMessage
    {
        public static void ShowEmployee(EmployeeModel emp)
        {
            Console.WriteLine($"{emp.FirstName, -6} {emp.LastName, -10}: {emp.EmailAddress, -35}" +
                $" isManager: {emp.isManager, -5}" +
                $" isExecutive: {emp.isExecutive, -5}" +
                $" isTechnicial: {emp.isTechnicial}");
        }
    }
}
