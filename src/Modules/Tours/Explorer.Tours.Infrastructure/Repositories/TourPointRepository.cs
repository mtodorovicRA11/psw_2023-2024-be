using Explorer.Tours.Core.Domain;
using Explorer.Tours.Infrastructure.Database;

namespace Explorer.Tours.Infrastructure.Repositories
{
    public class TourPointRepository : GenericRepository<TourPoint>, ITourPointRepository
    {
        public TourPointRepository(ToursContext context) : base(context)
        {
        }
    }
}
