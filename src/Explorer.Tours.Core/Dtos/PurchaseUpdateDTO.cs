namespace Explorer.Tours.Core.Dtos
{
    public class PurchaseUpdateDTO
    {
        public int UserId { get; set; }
        public int TourId { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}