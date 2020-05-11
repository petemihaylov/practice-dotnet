using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
    }
}
