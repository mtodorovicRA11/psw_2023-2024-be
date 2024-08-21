namespace Explorer.Tours.Core.Dtos
{
    public class RewardCreateDTO
    {
        public int AuthorId { get; set; }
        public int Points { get; set; }
        public bool IsAwarded { get; set; }
    }
}