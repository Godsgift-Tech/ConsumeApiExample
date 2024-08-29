using ConsumeApiExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        private readonly IReqresService _reqresService;

        public UserController(IReqresService reqresService)
        {
            _reqresService = reqresService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _reqresService.GetUserByIdAysnc(id);
            if (user == null)
            {
                return NoContent();
            }
            return Ok(user);
        }
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var users = await _reqresService.GetUsers();
            return Ok(users);
        }
    }
}
