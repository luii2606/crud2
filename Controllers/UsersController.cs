using Backend.DTO;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_service.GetById(id));

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserDto dto)
        {
            _service.Create(dto);
            return Ok(new { message = "Usuario creado con roles" });
        }

        // [HttpPut("{id}")]
        // public IActionResult Put(int id, UpdateUserDto dto)
        // {
        //     _service.Update(id, dto);
        //     return Ok();
        // }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
