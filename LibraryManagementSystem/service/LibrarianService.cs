using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.services
{
    public class LibrarianService : ILibrarianService
    {
        private readonly ILibrarianRepository _librarianRepository;

        public LibrarianService(ILibrarianRepository librarianRepository)
        {
            _librarianRepository = librarianRepository;
        }

        public void AddLibrarian(Librarian librarian)
        {
            _librarianRepository.Add(librarian);
        }
    }
}
