using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    class ExecutiveModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProccessor { get; set; } = new ExecutiveAccounts();
    } 
}
