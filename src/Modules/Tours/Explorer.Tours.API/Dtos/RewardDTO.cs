namespace Explorer.Tours.API.Dtos
{
    public class RewardDTO
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int Points { get; set; }
        public bool IsAwarded { get; set; }
    }
}