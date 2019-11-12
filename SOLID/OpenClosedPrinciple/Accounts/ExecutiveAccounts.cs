using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName}.{person.LastName}@acmecorp.com";

            output.isExecutive = true;
            output.isManager = true;

            return output;
        }
    }
}
