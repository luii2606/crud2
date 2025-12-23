using Backend.Data;
using Backend.Models;

namespace Backend.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly AppDbContext _context;

        public UserRoleRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(UserRole userRole)
        {
            _context.UserRoles.Add(userRole);
        }
    }
}


