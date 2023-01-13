using Endavadex.Api.Models;
using ExRam.Gremlinq.Core;
using System.Linq;

namespace Endavadex.Api.Repositories
{
    public class ProjectRepository
    {
        private readonly IGremlinQuerySource _gremlinQuerySource;

        public ProjectRepository(IGremlinQuerySource gremlinQuerySource)
        {
            _gremlinQuerySource = gremlinQuerySource;
        }


        public async Task<Project[]?> ReadProjects()
        {
            return await _gremlinQuerySource.V<Project>();
        }

        public async Task<Project?> CreateProject(Project project)
        {
            return await _gremlinQuerySource.AddV(project).FirstAsync();
        }
    }
}
