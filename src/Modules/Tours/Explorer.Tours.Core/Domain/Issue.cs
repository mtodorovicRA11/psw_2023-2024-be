namespace Explorer.Tours.Core.Domain
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime ReportedDate { get; set; }
    }
}