using Microsoft.Extensions.DependencyInjection;
using Models;
using Repository;

namespace Service
{
    public class UserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        


        public void AddUser(User user)
        {
            _userRepository.Add(user);
        }
        public bool RemoveUser(User user)
        {
            return _userRepository.Delete(user);
        }
        public User? GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }
    }
}