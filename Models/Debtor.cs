using System;
using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class Debtor
    {
        [Key]
        public long AutoKey { get; set; }

        [MaxLength(12)]
        public string? AccNo { get; set; }

        [MaxLength(100)]
        public string? CompanyName { get; set; }

        [MaxLength(100)]
        public string? Desc2 { get; set; }

        [MaxLength(30)]
        public string? RegisterNo { get; set; }

        [MaxLength(40)]
        public string? Address1 { get; set; }
        [MaxLength(40)]
        public string? Address2 { get; set; }
        [MaxLength(40)]
        public string? Address3 { get; set; }
        [MaxLength(40)]
        public string? Address4 { get; set; }

        [MaxLength(10)]
        public string? PostCode { get; set; }

        [MaxLength(40)]
        public string? DeliverAddr1 { get; set; }
        [MaxLength(40)]
        public string? DeliverAddr2 { get; set; }
        [MaxLength(40)]
        public string? DeliverAddr3 { get; set; }
        [MaxLength(40)]
        public string? DeliverAddr4 { get; set; }

        [MaxLength(10)]
        public string? DeliverPostCode { get; set; }

        [MaxLength(40)]
        public string? Attention { get; set; }

        [MaxLength(25)]
        public string? Phone1 { get; set; }
        [MaxLength(25)]
        public string? Phone2 { get; set; }

        [MaxLength(25)]
        public string? Fax1 { get; set; }
        [MaxLength(25)]
        public string? Fax2 { get; set; }

        [MaxLength(12)]
        public string? AreaCode { get; set; }

        [MaxLength(12)]
        public string? SalesAgent { get; set; }

        [MaxLength(20)]
        public string? DebtorType { get; set; }

        [MaxLength(40)]
        public string? NatureOfBusiness { get; set; }

        [MaxLength(80)]
        public string? WebURL { get; set; }

        [MaxLength(200)]
        public string? EmailAddress { get; set; }

        [MaxLength(30)]
        public string? DisplayTerm { get; set; }

        public decimal? CreditLimit { get; set; }

        public char? AgingOn { get; set; }
        public char? StatementType { get; set; }

        [MaxLength(5)]
        public string? CurrencyCode { get; set; }

        public char? AllowExceedCreditLimit { get; set; }

        public string? Note { get; set; }

        [MaxLength(60)]
        public string? ExemptNo { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [MaxLength(12)]
        public string? PriceCategory { get; set; }

        [MaxLength(14)]
        public string? TaxCode { get; set; }

        public decimal? DiscountPercent { get; set; }

        [MaxLength(20)]
        public string? DetailDiscount { get; set; }

        public DateTime? LastModified { get; set; }

        [MaxLength(10)]
        public string? LastModifiedUserID { get; set; }

        public DateTime? CreatedTimeStamp { get; set; }

        [MaxLength(10)]
        public string? CreatedUserID { get; set; }

        public decimal? OverdueLimit { get; set; }

        public char? HasBonusPoint { get; set; }

        public decimal? OpeningBonusPoint { get; set; }

        public short? QTBlockStatus { get; set; }
        public short? SOBlockStatus { get; set; }
        public short? DOBlockStatus { get; set; }
        public short? IVBlockStatus { get; set; }
        public short? CSBlockStatus { get; set; }

        [MaxLength(40)]
        public string? QTBlockMessage { get; set; }
        [MaxLength(40)]
        public string? SOBlockMessage { get; set; }
        [MaxLength(40)]
        public string? DOBlockMessage { get; set; }
        [MaxLength(40)]
        public string? IVBlockMessage { get; set; }
        [MaxLength(40)]
        public string? CSBlockMessage { get; set; }

        public string? ExternalLink { get; set; }

        public char? IsGroupCompany { get; set; }
        public char IsActive { get; set; }

        public int? LastUpdate { get; set; }

        public string? ContactInfo { get; set; }

        [MaxLength(12)]
        public string? AccountGroup { get; set; }

        public decimal? MarkupRatio { get; set; }

        public char? CalcDiscountOnUnitPrice { get; set; }

        public DateTime? GSTStatusVerifiedDate { get; set; }

        public char? InclusiveTax { get; set; }

        public int? RoundingMethod { get; set; }

        [MaxLength(30)]
        public string? SelfBilledApprovalNo { get; set; }

        public Guid? Guid { get; set; }

        public char? IsTaxRegistered { get; set; }

        [MaxLength(14)]
        public string? WithholdingTaxCode { get; set; }

        [MaxLength(8)]
        public string? MultiPrice { get; set; }

        public char? AllowChangeMultiPrice { get; set; }

        [MaxLength(25)]
        public string? Mobile { get; set; }

        public short? CGBlockStatus { get; set; }

        [MaxLength(40)]
        public string? CGBlockMessage { get; set; }

        [MaxLength(14)]
        public string? WithholdingVATCode { get; set; }

        public int? TaxEntityID { get; set; }

        public string? GenerateLinkResultJson { get; set; }

        public char? IsCashSaleDebtor { get; set; }
        public char? DoNotSubmitEInvoice { get; set; }

        [MaxLength(50)]
        public string? SGEInvoicePeppolID { get; set; }

        [MaxLength(10)]
        public string? SGEInvoiceBusinessUnit { get; set; }

        [MaxLength(10)]
        public string? SGEInvoicePeppolFormat { get; set; }
    }
}
