namespace Explorer.Tours.Core.Dtos
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> Interests { get; set; }
        public bool IsBlocked { get; set; }
    }
}
