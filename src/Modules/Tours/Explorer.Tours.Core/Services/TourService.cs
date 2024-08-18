using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;
using Explorer.Tours.Infrastructure.Repositories;

namespace Explorer.Tours.Core.Services
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _tourRepository;

        public TourService(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        public async Task<IEnumerable<Tour>> GetAllToursAsync()
        {
            return await _tourRepository.GetAllAsync();
        }

        public async Task<Tour> GetTourByIdAsync(int id)
        {
            return await _tourRepository.GetByIdAsync(id);
        }

        public async Task CreateTourAsync(Tour tour)
        {
            await _tourRepository.AddAsync(tour);
            await _tourRepository.SaveChangesAsync();
        }

        public async Task UpdateTourAsync(Tour tour)
        {
            _tourRepository.Update(tour);
            await _tourRepository.SaveChangesAsync();
        }

        public async Task DeleteTourAsync(int id)
        {
            var tour = await _tourRepository.GetByIdAsync(id);
            if (tour != null)
            {
                _tourRepository.Delete(tour);
                await _tourRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Tour>> GetToursByCategoryAsync(string category)
        {
            var allTours = await _tourRepository.GetAllAsync();
            return allTours.Where(t => t.Category == category);
        }

        public async Task<IEnumerable<Tour>> GetPublishedToursAsync()
        {
            var allTours = await _tourRepository.GetAllAsync();
            return allTours.Where(t => t.Status == "published");
        }
    }
}
