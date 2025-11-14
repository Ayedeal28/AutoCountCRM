using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class UsersLogin
    {
        public int Id { get; set; }
        public required string Email { get; set; }      // <-- must exist
        public required string Password { get; set; }   // <-- must exist
        public required string Name { get; set; }
        public required string Role { get; set; }
    }
}