
namespace Explorer.Tours.Core.Dtos
{
	public class IssueDTO
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }
		public int TourId { get; set; }
		public int UserId { get; set; }
		public DateTime ReportedDate { get; set; }
	}
}