using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Library
{
     interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
