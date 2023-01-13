using Endavadex.Api.Models;
using Endavadex.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Endavadex.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userRepository.ReadUsers();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            var result = await _userRepository.CreateUser(user);

            return Ok(result);
        }

        [HttpPost("{userId:Guid}/projects/{projectId}/assign")]
        public async Task<IActionResult> PostAssignUserToProject([FromRoute] Guid userId, [FromRoute] Guid projectId, [FromBody] Assignment assigned)
        {
            var result = await _userRepository.AssignUserToProject(userId, projectId, assigned);

            return Ok(result);
        }
    }
}
