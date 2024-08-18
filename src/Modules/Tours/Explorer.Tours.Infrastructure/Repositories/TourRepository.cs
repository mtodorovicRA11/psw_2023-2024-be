using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Infrastructure.Repositories
{
    public interface ITourRepository : IGenericRepository<Tour>
    {
    }

    public class TourRepository : GenericRepository<Tour>, ITourRepository
    {
        public TourRepository(ToursContext context) : base(context)
        {
        }
    }
}