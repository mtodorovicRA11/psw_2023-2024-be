using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Repositories;

namespace Explorer.Tours.Core.Services
{
    public class RewardService : IRewardService
    {
        private readonly IRewardRepository _rewardRepository;

        public RewardService(IRewardRepository rewardRepository)
        {
            _rewardRepository = rewardRepository;
        }

        public async Task<IEnumerable<Reward>> GetAllRewardsAsync()
        {
            return await _rewardRepository.GetAllAsync();
        }

        public async Task<Reward> GetRewardByIdAsync(int id)
        {
            return await _rewardRepository.GetByIdAsync(id);
        }

        public async Task CreateRewardAsync(Reward reward)
        {
            await _rewardRepository.AddAsync(reward);
            await _rewardRepository.SaveChangesAsync();
        }

        public async Task UpdateRewardAsync(Reward reward)
        {
            _rewardRepository.Update(reward);
            await _rewardRepository.SaveChangesAsync();
        }

        public async Task DeleteRewardAsync(int id)
        {
            var reward = await _rewardRepository.GetByIdAsync(id);
            if (reward != null)
            {
                _rewardRepository.Delete(reward);
                await _rewardRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Reward>> GetRewardsByUserIdAsync(int userId)
        {
            var allRewards = await _rewardRepository.GetAllAsync();
            return allRewards.Where(r => r.AuthorId == userId);
        }
    }
}
