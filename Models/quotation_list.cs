using System;
using System.ComponentModel.DataAnnotations;

namespace AutocountCRM_ProjectOne.Models
{
    public class quotation_list
    {
        [Key]
        public long DocKey { get; set; }

        [MaxLength(30)]
        public string DocNo { get; set; } = null!;

        public DateTime DocDate { get; set; }

        [MaxLength(12)]
        public string? DebtorCode { get; set; }

        [MaxLength(100)]
        public string? DebtorName { get; set; }

        [MaxLength(40)]
        public string? Ref { get; set; }

        [MaxLength(80)]
        public string? Description { get; set; }

        [MaxLength(30)]
        public string DisplayTerm { get; set; } = null!;

        [MaxLength(12)]
        public string? SalesAgent { get; set; }

        [MaxLength(40)]
        public string? InvAddr1 { get; set; }

        [MaxLength(40)]
        public string? InvAddr2 { get; set; }

        [MaxLength(40)]
        public string? InvAddr3 { get; set; }

        [MaxLength(40)]
        public string? InvAddr4 { get; set; }

        [MaxLength(25)]
        public string? Phone1 { get; set; }

        [MaxLength(25)]
        public string? Fax1 { get; set; }

        [MaxLength(40)]
        public string? Attention { get; set; }

        [MaxLength(20)]
        public string? BranchCode { get; set; }

        [MaxLength(40)]
        public string? DeliverAddr1 { get; set; }

        [MaxLength(40)]
        public string? DeliverAddr2 { get; set; }

        [MaxLength(40)]
        public string? DeliverAddr3 { get; set; }

        [MaxLength(40)]
        public string? DeliverAddr4 { get; set; }

        [MaxLength(25)]
        public string? DeliverPhone1 { get; set; }

        [MaxLength(25)]
        public string? DeliverFax1 { get; set; }

        [MaxLength(40)]
        public string? DeliverContact { get; set; }

        [MaxLength(60)]
        public string? SalesExemptionNo { get; set; }

        public DateTime? SalesExemptionExpiryDate { get; set; }

        [MaxLength(40)]
        public string? Validity { get; set; }

        [MaxLength(40)]
        public string? DeliveryTerm { get; set; }

        [MaxLength(40)]
        public string? PaymentTerm { get; set; }

        [MaxLength(30)]
        public string? YourRef { get; set; }

        [MaxLength(20)]
        public string? CC { get; set; }

        public decimal? Total { get; set; }
        public decimal? Footer1Param { get; set; }
        public decimal? Footer1Amt { get; set; }
        public decimal? Footer1LocalAmt { get; set; }

        [MaxLength(14)]
        public string? Footer1TaxCode { get; set; }

        public decimal? Footer2Param { get; set; }
        public decimal? Footer2Amt { get; set; }
        public decimal? Footer2LocalAmt { get; set; }

        [MaxLength(14)]
        public string? Footer2TaxCode { get; set; }

        public decimal? Footer3Param { get; set; }
        public decimal? Footer3Amt { get; set; }
        public decimal? Footer3LocalAmt { get; set; }

        [MaxLength(14)]
        public string? Footer3TaxCode { get; set; }

        [MaxLength(5)]
        public string CurrencyCode { get; set; } = null!;
        public decimal CurrencyRate { get; set; }
        public decimal? NetTotal { get; set; }
        public decimal? LocalNetTotal { get; set; }
        public decimal? AnalysisNetTotal { get; set; }
        public decimal? LocalAnalysisNetTotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? LocalTax { get; set; }

        public char Transferable { get; set; }

        [MaxLength(2)]
        public string? ToDocType { get; set; }

        public long? ToDocKey { get; set; }
        public string? Note { get; set; }
        [MaxLength(40)]
        public string? Remark1 { get; set; }
        [MaxLength(40)]
        public string? Remark2 { get; set; }
        [MaxLength(40)]
        public string? Remark3 { get; set; }
        [MaxLength(40)]
        public string? Remark4 { get; set; }

        public short PrintCount { get; set; }
        public char Cancelled { get; set; }
        public DateTime LastModified { get; set; }

        [MaxLength(10)]
        public string LastModifiedUserID { get; set; } = null!;

        public DateTime CreatedTimeStamp { get; set; }

        [MaxLength(10)]
        public string CreatedUserID { get; set; } = null!;

        [MaxLength(10)]
        public string? ApprovalUserID { get; set; }

        public string? ExternalLink { get; set; }
        [MaxLength(30)]
        public string? RefDocNo { get; set; }

        public char CanSync { get; set; }
        public int LastUpdate { get; set; }
        public long? ToDtlKey { get; set; }
        public char? FullTransferOption { get; set; }

        [MaxLength(20)]
        public string? ShipVia { get; set; }

        [MaxLength(40)]
        public string? ShipInfo { get; set; }

        [MaxLength(8)]
        public string? SalesLocation { get; set; }

        public decimal? Footer1Tax { get; set; }
        public decimal? Footer1LocalTax { get; set; }
        public decimal? Footer2Tax { get; set; }
        public decimal? Footer2LocalTax { get; set; }
        public decimal? Footer3Tax { get; set; }
        public decimal? Footer3LocalTax { get; set; }
        public decimal? ExTax { get; set; }
        public decimal? LocalExTax { get; set; }

        public Guid Guid { get; set; }
        public decimal ToTaxCurrencyRate { get; set; }
        public char? CalcDiscountOnUnitPrice { get; set; }
        public decimal? TotalExTax { get; set; }
        public decimal? TaxableAmt { get; set; }
        public char InclusiveTax { get; set; }
        public decimal? Footer1TaxRate { get; set; }
        public decimal? Footer2TaxRate { get; set; }
        public decimal? Footer3TaxRate { get; set; }
        public int RoundingMethod { get; set; }
        public decimal? LocalTaxableAmt { get; set; }
        public decimal? TaxCurrencyTax { get; set; }
        public decimal? TaxCurrencyTaxableAmt { get; set; }
        public char IsRoundAdj { get; set; }
        public decimal? RoundAdj { get; set; }
        public decimal? FinalTotal { get; set; }

        [MaxLength(8)]
        public string? MultiPrice { get; set; }

        public int? TaxEntityID { get; set; }
        public char DocStatus { get; set; }
        public DateTime? ExpiryTimeStamp { get; set; }
    }
}
