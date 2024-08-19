using Explorer.Tours.Core.Domain;
using Explorer.Tours.Infrastructure.Database;

namespace Explorer.Tours.Infrastructure.Repositories
{
    public class RewardRepository : GenericRepository<Reward>, IRewardRepository
    {
        public RewardRepository(ToursContext context) : base(context)
        {
        }
    }
}
