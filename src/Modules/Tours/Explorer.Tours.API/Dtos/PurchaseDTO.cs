namespace Explorer.Tours.API.Dtos
{
    public class PurchaseDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TourId { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}