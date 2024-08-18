using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Infrastructure.Repositories
{
    public interface ITourPointRepository : IGenericRepository<TourPoint>
    {
    }

    public class TourPointRepository : GenericRepository<TourPoint>, ITourPointRepository
    {
        public TourPointRepository(ToursContext context) : base(context)
        {
        }
    }
}
