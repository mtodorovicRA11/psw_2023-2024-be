using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Explorer.Tours.Core.Domain
{
    public class Reward
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public int Points { get; set; }
        public bool IsAwarded { get; set; }
    }
}