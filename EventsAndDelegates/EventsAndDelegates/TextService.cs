using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    class TextService
    {
        public void OnVideoEncoded(Object source, string args)
        {
            Console.WriteLine("Sending a text message ..." + args);
        }
    }
}
