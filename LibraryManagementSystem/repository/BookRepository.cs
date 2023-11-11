using LibraryManagementSystem.data;
using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext dbContext;

        public BookRepository(LibraryContext context)
        {
            dbContext = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return dbContext.Books.ToList();
        }

        public Book GetById(int id)
        {
            return dbContext.Books.Find(id);
        }

        public void Add(Book book)
        {
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
        }

        public void Update(Book book)
        {
            var existingBook = dbContext.Books.Find(book.Id);

            if (existingBook != null)
            {
                // Update the properties of the existing book
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Category = book.Category;
                existingBook.NumberOfCopies = book.NumberOfCopies;
                existingBook.PublicationYear = book.PublicationYear;

                // Save changes to the database
                dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var bookToDelete = dbContext.Books.Find(id);

            if (bookToDelete != null)
            {
                // Delete the book from the database
                dbContext.Books.Remove(bookToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
