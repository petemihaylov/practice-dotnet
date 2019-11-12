﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    class TechicialAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmetech.com";

            output.isTechnicial = true;

            return output;

        }
    }
}
