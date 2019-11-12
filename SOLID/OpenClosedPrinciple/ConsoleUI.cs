using System;
using System.Collections.Generic;

namespace OCPLibrary
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel {FirstName = "Jerey", LastName = "Corey"},
                new ManagerModel {FirstName = "Tim", LastName = "Key"},
                new ExecutiveModel {FirstName = "Brand", LastName = "Woelfell"},
                new PersonModel {FirstName = "Nancy", LastName = "Roman"},
                new TechicialModel {FirstName = "Jhon", LastName = "Snow"} 

            };

            List<EmployeeModel> employees = new List<EmployeeModel>();


            foreach (var person in applicants)
            {
                employees.Add(person.AccountProccessor.Create(person));
            }

            employees.Sort(delegate (EmployeeModel e1, EmployeeModel e2)
            {
                int result = e1.isManager.CompareTo(e2.isManager);
                if (result == 0)
                {
                    return e1.isManager.CompareTo(e2.isManager);
                }
                return result;
            });

            foreach (var emp in employees)
            {
                StandartMessage.ShowEmployee(emp);
            }
                
            Console.ReadLine();
        }
    }
}
