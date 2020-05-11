using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    class MailService
    {
        public void OnVideoEncoded(Object source, string args)
        {
            Console.WriteLine("MailService: Sending an email.. " + args);
        }
    }
}
