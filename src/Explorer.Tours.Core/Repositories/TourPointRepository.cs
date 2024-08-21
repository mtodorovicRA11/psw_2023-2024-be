using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Database;

namespace Explorer.Tours.Core.Repositories
{
    public class TourPointRepository : GenericRepository<TourPoint>, ITourPointRepository
    {
        public TourPointRepository(ToursContext context) : base(context)
        {
        }
    }
}
