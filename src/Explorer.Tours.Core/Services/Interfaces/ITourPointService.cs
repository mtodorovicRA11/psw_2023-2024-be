using System.Collections.Generic;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Core.Services
{
    public interface ITourPointService
    {
        Task<IEnumerable<TourPoint>> GetAllTourPointsAsync();
        Task<TourPoint> GetTourPointByIdAsync(int id);
        Task CreateTourPointAsync(TourPoint tourPoint);
        Task UpdateTourPointAsync(TourPoint tourPoint);
        Task DeleteTourPointAsync(int id);
        Task<IEnumerable<TourPoint>> GetTourPointsByTourIdAsync(int tourId);
    }
}
