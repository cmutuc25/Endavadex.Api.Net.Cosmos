using Endavadex.Api.Models;
using ExRam.Gremlinq.Core;
using System.Linq;

namespace Endavadex.Api.Repositories
{
    public class UserRepository
    {
        private readonly TextWriter _writer;
        private readonly IGremlinQuerySource _g;

        public UserRepository(TextWriter writer, IGremlinQuerySource g)
        {
            _writer = writer;
            _g = g;
        }

        public async Task<User[]?> GetUsers()
        {
            return await _g.V<User>();
        }

        public async Task<User?> CreateUser(User user)
        {
            return await _g.AddV(user).FirstAsync();
        }
    }
}
