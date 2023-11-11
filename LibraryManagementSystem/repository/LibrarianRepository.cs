using LibraryManagementSystem.data;
using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.repository
{
    public class LibrarianRepository : ILibrarianRepository
    {
        private readonly LibraryContext dbContext;

        public LibrarianRepository(LibraryContext context)
        {
            dbContext = context;
        }

        public IEnumerable<Librarian> GetAll()
        {
            return dbContext.Librarians.ToList();
        }

        public Librarian GetById(int id)
        {
            return dbContext.Librarians.Find(id);
        }

        public void Add(Librarian librarian)
        {
            dbContext.Librarians.Add(librarian);
            dbContext.SaveChanges();
        }

        public void Update(Librarian librarian)
        {
            var existingLibrarian = dbContext.Librarians.Find(librarian.Id);

            if (existingLibrarian != null)
            {
                // Update the properties of the existing librarian
                existingLibrarian.Name = librarian.Name;
                existingLibrarian.Age = librarian.Age;
                existingLibrarian.Gender = librarian.Gender;
                existingLibrarian.Address = librarian.Address;
                existingLibrarian.PhoneNumber = librarian.PhoneNumber;
                existingLibrarian.Email = librarian.Email;

                // Save changes to the database
                dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var librarianToDelete = dbContext.Librarians.Find(id);

            if (librarianToDelete != null)
            {
                // Delete the librarian from the database
                dbContext.Librarians.Remove(librarianToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
