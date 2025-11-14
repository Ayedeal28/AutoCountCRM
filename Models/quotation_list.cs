using System;
using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class quotation_list
    {
        [Key]
        public int QuotationID { get; set; }

        [MaxLength(20)]
        public string QuotationNo { get; set; } = null!;

        public DateTime QuotationDate { get; set; }

        [MaxLength(100)]
        public string ClientName { get; set; } = null!;

        [MaxLength(200)]
        public string Address { get; set; } = null!;

        [MaxLength(50)]
        public string CreditTerm { get; set; } = null!;

        [MaxLength(100)]
        public string SalesAgent { get; set; } = null!;

        [MaxLength(100)]
        public string SalesLocation { get; set; } = null!;

        public decimal Subtotal { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } = null!;
    }
}
