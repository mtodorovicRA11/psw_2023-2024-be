using System.Collections.Generic;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Core.Services
{
    public interface IIssueService
    {
        Task<IEnumerable<Issue>> GetAllIssuesAsync();
        Task<Issue> GetIssueByIdAsync(int id);
        Task CreateIssueAsync(Issue issue);
        Task UpdateIssueAsync(Issue issue);
        Task DeleteIssueAsync(int id);
        Task<IEnumerable<Issue>> GetIssuesByTourIdAsync(int tourId);
    }
}
