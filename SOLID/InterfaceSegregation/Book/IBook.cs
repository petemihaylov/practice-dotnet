using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Library
{
    interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages{ get; set;}

    }
}
