using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Loan
    {
        // Attributes
        Book book;

        // Getters and Setters
        public Book Book { get => book; set => book = value; }

        // Constructor
        public Loan(Book book)
        {
            this.book = book;
        }
    }
}
