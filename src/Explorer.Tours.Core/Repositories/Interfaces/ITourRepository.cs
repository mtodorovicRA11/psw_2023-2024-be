using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Core.Repositories
{
    public interface ITourRepository : IGenericRepository<Tour>
    {
        void Create(Tour tour);
    }
}