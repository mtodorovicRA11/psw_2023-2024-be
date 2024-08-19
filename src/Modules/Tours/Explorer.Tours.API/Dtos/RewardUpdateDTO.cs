namespace Explorer.Tours.API.Dtos
{
    public class RewardUpdateDTO
    {
        public int AuthorId { get; set; }
        public int Points { get; set; }
        public bool IsAwarded { get; set; }
    }
}