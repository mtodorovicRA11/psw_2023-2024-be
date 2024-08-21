using System.Collections.Generic;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Core.Services
{
    public interface IRewardService
    {
        Task<IEnumerable<Reward>> GetAllRewardsAsync();
        Task<Reward> GetRewardByIdAsync(int id);
        Task CreateRewardAsync(Reward reward);
        Task UpdateRewardAsync(Reward reward);
        Task DeleteRewardAsync(int id);
        Task<IEnumerable<Reward>> GetRewardsByUserIdAsync(int userId);
    }
}
