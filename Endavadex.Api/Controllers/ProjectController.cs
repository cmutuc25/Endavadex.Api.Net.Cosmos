using Endavadex.Api.Models;
using Endavadex.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Endavadex.Api.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ProjectRepository _projectRepository;

        public ProjectController(ProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var result = await _projectRepository.ReadProjects();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostProject([FromBody] Project project)
        {
            var result = await _projectRepository.CreateProject(project);

            return Ok(result);
        }
    }
}
