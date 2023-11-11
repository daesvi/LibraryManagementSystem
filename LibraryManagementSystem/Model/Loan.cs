using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Loan
    {
        // Configure Id as primary key and autoincremental
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Attributes
        Book book;
        User user;
        DateTime loanDate;
        DateTime dueDate;

        // Getters and Setters
        public Book Book { get => book; set => book = value; }
        public Book Book1 { get => book; set => book = value; }
        public User User { get => user; set => user = value; }
        public DateTime LoanDate { get => loanDate; set => loanDate = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }


        // Constructor
        public Loan() { }

        public Loan(int id, Book book, User user, DateTime loanDate, DateTime dueDate)
        {
            Id = id;
            this.book = book;
            this.user = user;
            this.loanDate = loanDate;
            this.dueDate = dueDate;
        }
    }
}
