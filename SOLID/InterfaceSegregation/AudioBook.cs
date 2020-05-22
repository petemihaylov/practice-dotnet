using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Library
{
    class AudioBook : IBorrowableAudioBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; } = "";
        public int Pages { get; set; } = -1;
        public int RuntimeInMinutes { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;


        public void CheckIn() { this.Borrower = ""; }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }
        
        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}
