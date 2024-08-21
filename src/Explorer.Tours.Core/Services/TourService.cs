using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Repositories;
using Explorer.Tours.Core.Dtos;
using AutoMapper;

namespace Explorer.Tours.Core.Services
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _tourRepository;
        private readonly IMapper _mapper;

        public TourService(ITourRepository tourRepository, IMapper mapper)
        {
            _tourRepository = tourRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Tour>> GetAllToursAsync()
        {
            return await _tourRepository.GetAllAsync();
        }

        public async Task<Tour> GetTourByIdAsync(int id)
        {
            return await _tourRepository.GetByIdAsync(id);
        }

        public void CreateTour(TourCreateDTO tourCreateDTO)
        {
            var tour = _mapper.Map<Tour>(tourCreateDTO);
            tour.Status = "draft"; // Ensure the status is set to "draft"
            _tourRepository.Create(tour);
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
