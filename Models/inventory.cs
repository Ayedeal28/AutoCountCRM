using System;
using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class Inventory
    {
        [Key]
        public long AutoKey { get; set; }

        [MaxLength(30)]
        public string ItemCode { get; set; } = null!;

        public long DocKey { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

        [MaxLength(100)]
        public string? Desc2 { get; set; }

        public string? FurtherDescription { get; set; }

        [MaxLength(8)]
        public string? ItemGroup { get; set; }

        [MaxLength(12)]
        public string? ItemType { get; set; }

        public decimal? AssemblyCost { get; set; }

        [MaxLength(40)]
        public string? LeadTime { get; set; }

        public char StockControl { get; set; }
        public char HasSerialNo { get; set; }
        public char HasBatchNo { get; set; }

        public decimal DutyRate { get; set; }

        [MaxLength(14)]
        public string? TaxCode { get; set; }

        public string? Note { get; set; }
        public byte[]? Image { get; set; }

        public byte CostingMethod { get; set; }

        [MaxLength(8)]
        public string SalesUOM { get; set; } = null!;
        [MaxLength(8)]
        public string PurchaseUOM { get; set; } = null!;
        [MaxLength(8)]
        public string ReportUOM { get; set; } = null!;

        public DateTime LastModified { get; set; }

        [MaxLength(10)]
        public string LastModifiedUserID { get; set; } = null!;

        public DateTime CreatedTimeStamp { get; set; }

        [MaxLength(10)]
        public string CreatedUserID { get; set; } = null!;

        public char IsActive { get; set; }

        public int LastUpdate { get; set; }

        [MaxLength(20)]
        public string? SNFormatName { get; set; }

        public char? IsCalcBonusPoint { get; set; }
        public decimal? MarkupRatio { get; set; }
        public char HasPromoter { get; set; }

        [MaxLength(30)]
        public string? GlobalCode { get; set; }

        [MaxLength(20)]
        public string? ItemBrand { get; set; }

        [MaxLength(20)]
        public string? ItemClass { get; set; }

        [MaxLength(20)]
        public string? ItemCategory { get; set; }

        public int? LeadTimeDay { get; set; }
        public string? ExternalLink { get; set; }
        public char Discontinued { get; set; }

        public char? AutoUOMConversion { get; set; }

        [MaxLength(8)]
        public string BaseUOM { get; set; } = null!;

        public char BackOrderControl { get; set; }

        [MaxLength(14)]
        public string? PurchaseTaxCode { get; set; }

        [MaxLength(12)]
        public string? TariffCode { get; set; }

        public Guid Guid { get; set; }

        public char? IsSalesItem { get; set; }
        public char? IsPurchaseItem { get; set; }
        public char? IsPOSItem { get; set; }
        public char? IsRawMaterialItem { get; set; }
        public char? IsFinishGoodsItem { get; set; }

        [MaxLength(12)]
        public string? MainSupplier { get; set; }

        [MaxLength(3)]
        public string? Classification { get; set; }

        public bool MustGenerateEInvoice { get; set; }

        [MaxLength(120)]
        public string? ImageFileName { get; set; }
    }
}
