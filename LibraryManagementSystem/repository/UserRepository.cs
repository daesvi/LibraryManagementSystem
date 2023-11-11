using LibraryManagementSystem.data;
using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.repository
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryContext dbContext;

        public UserRepository(LibraryContext context)
        {
            dbContext = context;
        }

        public IEnumerable<User> GetAll()
        {
            return dbContext.Users.ToList();
        }

        public User GetById(int id)
        {
            return dbContext.Users.Find(id);
        }

        public void Add(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public void Update(User user)
        {
            var existingUser = dbContext.Users.Find(user.Id);

            if (existingUser != null)
            {
                // Update the properties of the existing user
                existingUser.Name = user.Name;
                existingUser.Age = user.Age;
                existingUser.Gender = user.Gender;
                existingUser.Address = user.Address;
                existingUser.PhoneNumber = user.PhoneNumber;
                existingUser.Email = user.Email;

                // Save changes to the database
                dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var userToDelete = dbContext.Users.Find(id);

            if (userToDelete != null)
            {
                // Delete the user from the database
                dbContext.Users.Remove(userToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
