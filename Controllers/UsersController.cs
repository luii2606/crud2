using Microsoft.AspNetCore.Mvc;
using Backend.Models;
namespace Backend.Controllers;

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
    public IActionResult Post(CreateUserDto dto)
    {
        _service.Create(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, UpdateUserDto dto)
    {
        _service.Update(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return Ok();
    }
}
