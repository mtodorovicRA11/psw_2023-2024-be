using System.Collections.Generic;
using System.Threading.Tasks;
using Explorer.Tours.Core.Dtos;
using Explorer.Tours.Core.Domain;

namespace Explorer.Tours.Core.Services
{
    public interface ITourService
    {
        Task<IEnumerable<Tour>> GetAllToursAsync();
        Task<Tour> GetTourByIdAsync(int id);
        void CreateTour(TourCreateDTO tourCreateDTO);
        Task UpdateTourAsync(Tour tour);
        Task DeleteTourAsync(int id);
        Task<IEnumerable<Tour>> GetToursByCategoryAsync(string category);
        Task<IEnumerable<Tour>> GetPublishedToursAsync();
    }
}
