using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Database;

namespace Explorer.Tours.Core.Repositories
{
    public class TourRepository : GenericRepository<Tour>, ITourRepository
    {
        private readonly ToursContext _context;
        public TourRepository(ToursContext context) : base(context)
        {
            _context = context;
        }
        public void Create(Tour tour)
        {
            _context.Tours.Add(tour);
            _context.SaveChanges();
        }
    }
}