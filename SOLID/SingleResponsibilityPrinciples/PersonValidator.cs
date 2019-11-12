using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciples
{
    class PersonValidator
    {
        public static bool Validate(Person person)
        {

            //Checks to be sure the first and the last names are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandartMessage.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandartMessage.DisplayValidationError("last name");
                return false;
            }
            return true;
        }
    }
}
