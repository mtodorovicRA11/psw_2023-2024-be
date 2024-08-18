using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;
using Explorer.Tours.Infrastructure.Repositories;

namespace Explorer.Tours.Core.Services
{
    public class IssueService : IIssueService
    {
        private readonly IIssueRepository _issueRepository;

        public IssueService(IIssueRepository issueRepository)
        {
            _issueRepository = issueRepository;
        }

        public async Task<IEnumerable<Issue>> GetAllIssuesAsync()
        {
            return await _issueRepository.GetAllAsync();
        }

        public async Task<Issue> GetIssueByIdAsync(int id)
        {
            return await _issueRepository.GetByIdAsync(id);
        }

        public async Task CreateIssueAsync(Issue issue)
        {
            await _issueRepository.AddAsync(issue);
            await _issueRepository.SaveChangesAsync();
        }

        public async Task UpdateIssueAsync(Issue issue)
        {
            _issueRepository.Update(issue);
            await _issueRepository.SaveChangesAsync();
        }

        public async Task DeleteIssueAsync(int id)
        {
            var issue = await _issueRepository.GetByIdAsync(id);
            if (issue != null)
            {
                _issueRepository.Delete(issue);
                await _issueRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Issue>> GetIssuesByTourIdAsync(int tourId)
        {
            var allIssues = await _issueRepository.GetAllAsync();
            return allIssues.Where(i => i.TourId == tourId);
        }
    }
}
