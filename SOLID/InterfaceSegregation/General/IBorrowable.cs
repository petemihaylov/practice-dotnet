using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Library
{
    interface IBorrowable 
    {

        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
     
        DateTime GetDueDate();
        void CheckIn();
        void CheckOut(string borrower);
    }
}
