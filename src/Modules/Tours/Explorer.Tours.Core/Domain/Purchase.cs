namespace Explorer.Tours.Core.Domain
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}