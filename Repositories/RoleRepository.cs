using Backend.Data;
using Backend.Models;

namespace Backend.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContext _context;

        public RoleRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Role> GetAll() => _context.Roles.ToList();

        public Role GetById(int id) => _context.Roles.Find(id);

        public void Add(Role role) => _context.Roles.Add(role);

        public void Delete(Role role) => _context.Roles.Remove(role);

        public void Save() => _context.SaveChanges();
    }
}
