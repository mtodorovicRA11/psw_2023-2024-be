namespace Explorer.Tours.API.Dtos
{
    public class RewardCreateDTO
    {
        public int AuthorId { get; set; }
        public int Points { get; set; }
        public bool IsAwarded { get; set; }
    }
}