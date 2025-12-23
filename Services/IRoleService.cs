using Backend.Models;

namespace Backend.Services
{
    public interface IRoleService
    {
        IEnumerable<Role> GetAll();
        void Create(string name);
        void Delete(int id);
    }
}
