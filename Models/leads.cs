using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class leads_list
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Product { get; set; }
        public string? ProductId { get; set; }
        public string? Website { get; set; }
        public string? SubscriberEmail { get; set; }
        public string? LeadStatus { get; set; }
        public string? LeadSource { get; set; }
        public string? AssignedTo { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Comments { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
