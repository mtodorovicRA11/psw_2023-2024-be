using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Infrastructure.Repositories
{
    public interface IRewardRepository : IGenericRepository<Reward>
    {
    }

    public class RewardRepository : GenericRepository<Reward>, IRewardRepository
    {
        public RewardRepository(ToursContext context) : base(context)
        {
        }
    }
}
