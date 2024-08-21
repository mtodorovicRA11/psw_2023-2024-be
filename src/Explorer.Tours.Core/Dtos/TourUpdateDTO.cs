namespace Explorer.Tours.Core.Dtos
{
    public class TourUpdateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public int AuthorId { get; set; }
    }
}