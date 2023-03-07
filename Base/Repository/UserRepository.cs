using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly DbContext _context;
        public UserRepository(DbContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }
        public bool Delete(User user)
        {
            int result = 0;
            var entity = GetById(user.Id);

            if (entity != null)
            {
                _context.Set<User>().Remove(entity);
                result = _context.SaveChanges();
            }
            return result > 0;
        }
        public IEnumerable<User> GetAll()
        {
            return _context.Set<User>().ToList();
        }
        public User? GetById(int id)
        {
            return _context.Set<User>().FirstOrDefault(u => u.Id == id);
        }
        public void Update(User user)
        {
            _context.Set<User>().Update(user);
            _context.SaveChanges();
        }
    }
}