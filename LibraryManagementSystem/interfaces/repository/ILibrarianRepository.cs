using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.interfaces
{
    public interface ILibrarianRepository
    {
        IEnumerable<Librarian> GetAll();
        Librarian GetById(int id);
        void Add(Librarian librarian);
        void Update(Librarian librarian);
        void Delete(int id);
    }
}
