using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool isManager { get; set; } = false;
        public bool isExecutive { get; set; } = false;
        public bool isTechnicial { get; set; } = false;
    }
}
