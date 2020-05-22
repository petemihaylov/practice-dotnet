using System;
using System.Collections.Generic;
using System.Text;

namespace DRY
{
    public class EmployeeProcessor
    {
        public string GenerateEmployeeId(string firstName, string lastName)
        {
            return $@"{firstName.Substring(0, 4)}{lastName.Substring(0, 4)}{DateTime.Now.Millisecond}";
        }
    }
}
