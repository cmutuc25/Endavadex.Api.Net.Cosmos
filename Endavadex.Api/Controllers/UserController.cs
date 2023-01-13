using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExRam.Gremlinq.Core;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Endavadex.Api.Repositories;
using Endavadex.Api.Models;

namespace Endavadex.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGremlinQuerySource _source;
        private readonly UserRepository _userRepository;

        public UserController(IGremlinQuerySource source, UserRepository userRepository)
        {
            _source = source;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userRepository.GetUsers();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            var result = await _userRepository.CreateUser(user);

            return Ok(result);
        }
    }
}
