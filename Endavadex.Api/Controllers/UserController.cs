using Endavadex.Api.Controllers.Dtos;
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
        public async Task<IActionResult> PostUser([FromBody] UserDto userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
            };

            var result = await _userRepository.CreateUser(user);

            return Ok(result);
        }

        [HttpPost("{userId:Guid}/projects/{projectId}/assign")]
        public async Task<IActionResult> PostAssignUserToProject(
            [FromRoute] Guid userId,
            [FromRoute] Guid projectId,
            [FromBody] AssignmentDto assignmentDto)
        {
            var assignment = new Assignment
            {
                Role = assignmentDto.Role,
                Duties = assignmentDto.Duties,
                StartDate = assignmentDto.StartDate,
                EndDate = assignmentDto.EndDate
            };

            var result = await _userRepository.AssignUserToProject(userId, projectId, assignment);

            return Ok(result);
        }
    }
}
