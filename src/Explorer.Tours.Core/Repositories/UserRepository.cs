using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Database;

namespace Explorer.Tours.Core.Repositories
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		public UserRepository(ToursContext context) : base(context)
		{
		}
	}
}