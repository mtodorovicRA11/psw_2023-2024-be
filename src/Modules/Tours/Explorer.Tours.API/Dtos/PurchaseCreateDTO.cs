namespace Explorer.Tours.API.Dtos
{
    public class PurchaseCreateDTO
    {
        public int UserId { get; set; }
        public int TourId { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}