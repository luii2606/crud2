using Backend.Models;
using Backend.Repositories;

namespace Backend.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repo;

        public RoleService(IRoleRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Role> GetAll() => _repo.GetAll();

        public void Create(string name)
        {
            _repo.Add(new Role { Name = name });
            _repo.Save();
        }

        public void Delete(int id)
        {
            var role = _repo.GetById(id);
            _repo.Delete(role);
            _repo.Save();
        }
    }
}
