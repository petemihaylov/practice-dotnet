using System;

namespace SingleResponsibilityPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            StandartMessage.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if(isUserValid == false)
            {
                StandartMessage.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandartMessage.EndApplication();
        }
    }
}
