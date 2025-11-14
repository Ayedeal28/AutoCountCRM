using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class quotation_items
    {
        [Key]
        public int ItemID { get; set; }

        [MaxLength(20)]
        public string QuotationNo { get; set; } = null!;

        [MaxLength(50)]
        public string ItemCode { get; set; } = null!;

        [MaxLength(200)]
        public string Description { get; set; } = null!;

        [MaxLength(50)]
        public string UOM { get; set; } = null!;

        public int Qty { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }
    }
}
