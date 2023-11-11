using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
    }
}
