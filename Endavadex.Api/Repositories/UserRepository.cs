using Endavadex.Api.Models;
using ExRam.Gremlinq.Core;

namespace Endavadex.Api.Repositories
{
    public class UserRepository
    {
        private readonly IGremlinQuerySource _gremlinQuerySource;

        public UserRepository(IGremlinQuerySource gremlinQuerySource)
        {
            _gremlinQuerySource = gremlinQuerySource;
        }

        public async Task<User[]> ReadUsers()
        {
            return await _gremlinQuerySource.V<User>();
        }

        public async Task<User> CreateUser(User user)
        {
            return await _gremlinQuerySource.AddV(user).FirstAsync();
        }

        public async Task<Assignment> AssignUserToProject(Guid userId, Guid projectId, Assignment assigned)
        {
            return await _gremlinQuerySource
                .V(userId)
                .AddE(assigned)
                .To(_ => _.V(projectId))
                .FirstAsync();
        }
    }
}
