using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public required string userName { get; set; }
        public required string userEmail { get; set; }
        public required string AssignedBranch { get; set; }
        public int status { get; set; }  // 1 = active, 0 = inactive
        public DateTime JoinedDate { get; set; }
    }
}
