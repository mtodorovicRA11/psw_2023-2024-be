using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Infrastructure.Repositories
{
    public interface IIssueRepository : IGenericRepository<Issue>
    {
    }

    public class IssueRepository : GenericRepository<Issue>, IIssueRepository
    {
        public IssueRepository(ToursContext context) : base(context)
        {
        }
    }
}
