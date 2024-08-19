using Explorer.API.Controllers;
using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [Route("api/administration/tour")]
    [ApiController]
    public class TourController : BaseApiController
    {
        private readonly ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        // GET: api/Tour
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tour>>> GetAllTours()
        {
            var tours = await _tourService.GetAllToursAsync();
            return Ok(tours);
        }

        // GET: api/Tour/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Tour>> GetTourById(int id)
        {
            var tour = await _tourService.GetTourByIdAsync(id);
            if (tour == null)
            {
                return NotFound();
            }
            return Ok(tour);
        }

        // POST: api/Tour
        [HttpPost]
        public async Task<ActionResult> CreateTour([FromBody] Tour tour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _tourService.CreateTourAsync(tour);
            return CreatedAtAction(nameof(GetTourById), new { id = tour.Id }, tour);
        }

        // PUT: api/Tour/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTour(int id, [FromBody] Tour tour)
        {
            if (id != tour.Id)
            {
                return BadRequest("Tour ID mismatch.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _tourService.UpdateTourAsync(tour);
            return NoContent();
        }

        // DELETE: api/Tour/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTour(int id)
        {
            var tour = await _tourService.GetTourByIdAsync(id);
            if (tour == null)
            {
                return NotFound();
            }

            await _tourService.DeleteTourAsync(id);
            return NoContent();
        }

        // GET: api/Tour/category/{category}
        [HttpGet("category/{category}")]
        public async Task<ActionResult<IEnumerable<Tour>>> GetToursByCategory(string category)
        {
            var tours = await _tourService.GetToursByCategoryAsync(category);
            return Ok(tours);
        }

        // GET: api/Tour/published
        [HttpGet("published")]
        public async Task<ActionResult<IEnumerable<Tour>>> GetPublishedTours()
        {
            var tours = await _tourService.GetPublishedToursAsync();
            return Ok(tours);
        }
    }
}