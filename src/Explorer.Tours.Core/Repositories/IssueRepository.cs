using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Database;

namespace Explorer.Tours.Core.Repositories
{
    public class IssueRepository : GenericRepository<Issue>, IIssueRepository
    {
        public IssueRepository(ToursContext context) : base(context)
        {
        }
    }
}
