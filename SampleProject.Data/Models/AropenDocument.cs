using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AROpenDocuments")]
[Microsoft.EntityFrameworkCore.Index("AropenDocumentNo", "AropenDocumentDate", "FkBrbranchId", "FkArcustomerId", "AropenDocumentType", Name = "Idx_AROpenDocuments")]
public partial class AropenDocument
{
    [Key]
    [Column("AROpenDocumentID")]
    public int AropenDocumentId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GELanguageID")]
    public int FkGelanguageId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ARSellerID")]
    public int? FkArsellerId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_GEVATRegionID")]
    public int? FkGevatregionId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("AROpenDocumentNo")]
    [StringLength(50)]
    public string AropenDocumentNo { get; set; }

    [Column("AROpenDocumentName")]
    [StringLength(100)]
    public string AropenDocumentName { get; set; }

    [Column("AROpenDocumentDesc")]
    [StringLength(512)]
    public string AropenDocumentDesc { get; set; }

    [Column("AROpenDocumentType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AropenDocumentType { get; set; }

    [Column("AROpenDocumentCustomerName")]
    [StringLength(50)]
    public string AropenDocumentCustomerName { get; set; }

    [Column("AROpenDocumentCustomerDesc")]
    [StringLength(500)]
    public string AropenDocumentCustomerDesc { get; set; }

    [Column("AROpenDocumentInvoiceNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AropenDocumentInvoiceNo { get; set; }

    [Column("AROpenDocumentCreditNoteNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AropenDocumentCreditNoteNo { get; set; }

    [Column("AROpenDocumentDate", TypeName = "datetime")]
    public DateTime? AropenDocumentDate { get; set; }

    [Column("AROpenDocumentValidateDate", TypeName = "datetime")]
    public DateTime? AropenDocumentValidateDate { get; set; }

    [Column("AROpenDocumentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AropenDocumentStatus { get; set; }

    [Column("AROpenDocumentPaymentTerm")]
    [StringLength(50)]
    public string AropenDocumentPaymentTerm { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("AROpenDocumentIsDiscountPercentCheck")]
    public bool? AropenDocumentIsDiscountPercentCheck { get; set; }

    [Column("AROpenDocumentDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentDiscountPerCent { get; set; }

    [Column("AROpenDocumentDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentDiscountFix { get; set; }

    [Column("AROpenDocumentTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string AropenDocumentTaxNumber { get; set; }

    [Column("AROpenDocumentNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentNetAmount { get; set; }

    [Column("AROpenDocumentTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentTaxAmount { get; set; }

    [Column("AROpenDocumentSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentSubTotalAmount { get; set; }

    [Column("AROpenDocumentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentTotalAmount { get; set; }

    [Column("AROpenDocumentNetFuncAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentNetFuncAmount { get; set; }

    [Column("AROpenDocumentTaxFuncAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentTaxFuncAmount { get; set; }

    [Column("AROpenDocumentTotalFuncAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentTotalFuncAmount { get; set; }

    [Column("AROpenDocumentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentExchangeRate { get; set; }

    [Column("AROpenDocumentRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? AropenDocumentRemainAmount { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("AROpenDocumentTransferredDate", TypeName = "datetime")]
    public DateTime? AropenDocumentTransferredDate { get; set; }

    [InverseProperty("FkAropenDocument")]
    public virtual ICollection<ArdocumentPayment> ArdocumentPayments { get; set; } = new List<ArdocumentPayment>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("AropenDocuments")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("AropenDocuments")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AropenDocuments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AropenDocuments")]
    public virtual Hremployee FkHremployee { get; set; }
}
