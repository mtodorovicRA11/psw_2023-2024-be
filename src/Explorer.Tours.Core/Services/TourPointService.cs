using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Repositories;

namespace Explorer.Tours.Core.Services
{
    public class TourPointService : ITourPointService
    {
        private readonly ITourPointRepository _tourPointRepository;

        public TourPointService(ITourPointRepository tourPointRepository)
        {
            _tourPointRepository = tourPointRepository;
        }

        public async Task<IEnumerable<TourPoint>> GetAllTourPointsAsync()
        {
            return await _tourPointRepository.GetAllAsync();
        }

        public async Task<TourPoint> GetTourPointByIdAsync(int id)
        {
            return await _tourPointRepository.GetByIdAsync(id);
        }

        public async Task CreateTourPointAsync(TourPoint tourPoint)
        {
            await _tourPointRepository.AddAsync(tourPoint);
            await _tourPointRepository.SaveChangesAsync();
        }

        public async Task UpdateTourPointAsync(TourPoint tourPoint)
        {
            _tourPointRepository.Update(tourPoint);
            await _tourPointRepository.SaveChangesAsync();
        }

        public async Task DeleteTourPointAsync(int id)
        {
            var tourPoint = await _tourPointRepository.GetByIdAsync(id);
            if (tourPoint != null)
            {
                _tourPointRepository.Delete(tourPoint);
                await _tourPointRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TourPoint>> GetTourPointsByTourIdAsync(int tourId)
        {
            var allTourPoints = await _tourPointRepository.GetAllAsync();
            return allTourPoints.Where(tp => tp.TourId == tourId);
        }
    }
}
