using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Explorer.Tours.Core.Domain
{
    public class Tour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; } = "draft";
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public List<TourPoint> TourPoints { get; set; }
    }
}