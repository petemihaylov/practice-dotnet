using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    interface ILibraryItem
    {
        string Author { get; set; }
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
        string LibraryId { get; set; }
        int Pages{ get; set;}

        string Title { get; set; }
        void CheckIn();

        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
