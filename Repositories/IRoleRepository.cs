using Backend.Models;

namespace Backend.Repositories
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);
        void Add(Role role);
        void Delete(Role role);
        void Save();
    }
}
