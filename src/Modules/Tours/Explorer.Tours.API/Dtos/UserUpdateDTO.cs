using System.Collections.Generic;

namespace Explorer.Tours.API.Dtos
{
    public class UserUpdateDTO
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> Interests { get; set; }
        public bool IsBlocked { get; set; }
    }
}
