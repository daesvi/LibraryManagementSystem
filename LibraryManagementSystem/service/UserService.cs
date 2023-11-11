using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
        }
    }
}
