using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Database;

namespace Explorer.Tours.Core.Repositories
{
    public class RewardRepository : GenericRepository<Reward>, IRewardRepository
    {
        public RewardRepository(ToursContext context) : base(context)
        {
        }
    }
}
