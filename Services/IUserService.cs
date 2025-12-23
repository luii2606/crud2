using Backend.DTO;
using Backend.Models;

namespace Backend.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Create(CreateUserDto dto);
        //void Update(int id, UpdateUserDto dto);
        void Delete(int id);
    }
}
