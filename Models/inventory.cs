using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class Inventory
    {
        [Key]
        public int ItemID { get; set; }

        [MaxLength(50)]
        public string? ItemCode { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        public int? TotalQty { get; set; }

        [MaxLength(50)]
        public string? LeadTime { get; set; }

        [MaxLength(50)]
        public string? DutyRate { get; set; }

        [MaxLength(20)]
        public string? SupplyTaxCode { get; set; }

        [MaxLength(20)]
        public string? PurchaseTaxCode { get; set; }

        [MaxLength(50)]
        public string? TariffCode { get; set; }

        [MaxLength(50)]
        public string? ItemGroup { get; set; }

        [MaxLength(50)]
        public string? ItemType { get; set; }

        public bool Active { get; set; }
        public bool HasPromoter { get; set; }
        public bool Discontinued { get; set; }

        [MaxLength(50)]
        public string? CostingMethod { get; set; }

        [MaxLength(50)]
        public string? MainSupplier { get; set; }

        [MaxLength(20)]
        public string? UOM { get; set; }

        public decimal? StandardCost { get; set; }
        public decimal? MinPurchasePrice { get; set; }
        public decimal? MaxPurchasePrice { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal? Price4 { get; set; }
        public decimal? Price5 { get; set; }
        public decimal? Price6 { get; set; }
        public decimal? MinSellingPrice { get; set; }
        public decimal? MaxSellingPrice { get; set; }

        [MaxLength(50)]
        public string? Margin { get; set; }
    }
}