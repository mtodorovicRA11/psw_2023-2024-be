﻿using Explorer.Tours.Core.Domain;
using Explorer.Tours.Infrastructure.Database;

namespace Explorer.Tours.Infrastructure.Repositories
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		public UserRepository(ToursContext context) : base(context)
		{
		}
	}
}