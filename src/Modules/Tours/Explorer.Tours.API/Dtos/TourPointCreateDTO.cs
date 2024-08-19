namespace Explorer.Tours.API.Dtos
{
    public class TourPointCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ImageUrl { get; set; }
        public int TourId { get; set; }
    }
}
