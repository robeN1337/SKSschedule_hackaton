using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Extension;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/Users")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        // GET: api/Users/
        [HttpGet]
        public async Task<ActionResult<List<User>>> getAllUsers()
        {
            if (await _service.getCountUsers() == 0)
            {
                return NotFound();
            }
            return await _service.getAllUsers();
        }

        // GET: api/Users/{login}
        [HttpGet("{login}")]
        public async Task<ActionResult<User>> getUserByLogin(string login)
        {
            return await _service.getUserByLogin(login);
        }

        // GET: api/Users/auth?login=a&password=b
        [HttpGet("auth")]
        public async Task<ActionResult<User>> GetByEmailAndPassword(string login, string password)
        {
            var user = await _service.GetByEmailAndPassword(login, password);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return Problem("Не удается найти пользователя!");
            }
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            return Ok(_service.createUser(user));
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> updateUser(User user, Guid id)
        {
            return Ok(_service.updateUser(user));
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{login}")]
        public async Task<ActionResult> deleteUser(string login)
        {
            return Ok(_service.deleteUser(login));
        }
    }
}
