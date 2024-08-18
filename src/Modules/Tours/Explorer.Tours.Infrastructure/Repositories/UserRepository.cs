using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Infrastructure.Repositories
{
	public interface IUserRepository : IGenericRepository<User>
	{
	}

	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		public UserRepository(ToursContext context) : base(context)
		{
		}
	}
}