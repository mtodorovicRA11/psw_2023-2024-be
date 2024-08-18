namespace Explorer.Tours.Core.Domain
{
    public class Reward
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public int Points { get; set; }
        public bool IsAwarded { get; set; }
    }
}