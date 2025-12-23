using Backend.Data;
using Backend.Models;

namespace Backend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
            => _context.Users.ToList();

        public User GetById(int id)
            => _context.Users.Find(id);

        public void Add(User user)
            => _context.Users.Add(user);

        public void Update(User user)
            => _context.Users.Update(user);

        public void Delete(User user)
            => _context.Users.Remove(user);

        public void Save()
            => _context.SaveChanges();
    }
}
