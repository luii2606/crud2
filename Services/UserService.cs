using Backend.DTO;
using Backend.Models;
using Backend.Repositories;

namespace Backend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IUserRoleRepository _userRoleRepo;

        public UserService(
            IUserRepository userRepo,
            IUserRoleRepository userRoleRepo)
        {
            _userRepo = userRepo;
            _userRoleRepo = userRoleRepo;
        }

        public IEnumerable<User> GetAll()
            => _userRepo.GetAll();

        public User GetById(int id)
            => _userRepo.GetById(id);

        public void Create(CreateUserDto dto)
        {
            if (dto.RoleIds == null || dto.RoleIds.Count == 0)
                throw new Exception("El usuario debe tener al menos un rol");

            var user = new User
            {
                Username = dto.Username,
                Email = dto.Email,
                Password = dto.Password
            };

            _userRepo.Add(user);
            _userRepo.Save();

            foreach (var roleId in dto.RoleIds)
            {
                _userRoleRepo.Add(new UserRole
                {
                    UserId = user.Id,
                    RoleId = roleId
                });
            }

            _userRepo.Save();
        }

        // public void Update(int id, UpdateUserDto dto)
        // {
        //     var user = _userRepo.GetById(id);

        //     if (user == null)
        //         throw new Exception("Usuario no encontrado");

        //     user.Username = dto.Username;
        //     user.Email = dto.Email;

        //     _userRepo.Update(user);
        //     _userRepo.Save();
        // }


        public void Delete(int id)
        {
            var user = _userRepo.GetById(id);
            _userRepo.Delete(user);
            _userRepo.Save();
        }
    }
}

