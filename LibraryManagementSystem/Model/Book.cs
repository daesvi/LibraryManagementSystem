using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Book
    {
        // Attributes
        string title;
        string author;
        string category;
        int numberOfCopies;
        int publicationYear;

        // Getters and Setters
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Category { get => category; set => category = value; }
        public int NumberOfCopies { get => numberOfCopies; set => numberOfCopies = value; }
        public int PublicationYear { get => publicationYear; set => publicationYear = value; }

        // Constructor
        public Book(string title, string author, string category, int numberOfCopies, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.category = category;
            this.numberOfCopies = numberOfCopies;
            this.publicationYear = publicationYear;
        }
    }
}
