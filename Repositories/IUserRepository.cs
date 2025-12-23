using Backend.Models;

namespace Backend.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        void Save();
    }
}
