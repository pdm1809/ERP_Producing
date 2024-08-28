using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APOpenDocuments")]
[Microsoft.EntityFrameworkCore.Index("ApopenDocumentNo", "ApopenDocumentDate", "ApopenDocumentType", Name = "Idx_APOpenDocuments")]
public partial class ApopenDocument
{
    [Key]
    [Column("APOpenDocumentID")]
    public int ApopenDocumentId { get; set; }

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

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int FkApinvoiceInId { get; set; }

    [Column("APOpenDocumentNo")]
    [StringLength(50)]
    public string ApopenDocumentNo { get; set; }

    [Column("APOpenDocumentName")]
    [StringLength(100)]
    public string ApopenDocumentName { get; set; }

    [Column("APOpenDocumentDesc")]
    [StringLength(512)]
    public string ApopenDocumentDesc { get; set; }

    [Column("APOpenDocumentType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApopenDocumentType { get; set; }

    [Column("APOpenDocumentDate", TypeName = "datetime")]
    public DateTime? ApopenDocumentDate { get; set; }

    [Column("APOpenDocumentValidateDate", TypeName = "datetime")]
    public DateTime? ApopenDocumentValidateDate { get; set; }

    [Column("APOpenDocumentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApopenDocumentStatus { get; set; }

    [Column("APOpenDocumentPaymentTerm")]
    [StringLength(50)]
    public string ApopenDocumentPaymentTerm { get; set; }

    [Column("APPaymentMethodCombo")]
    [StringLength(50)]
    public string AppaymentMethodCombo { get; set; }

    [Column("APOpenDocumentIsDiscountPercentCheck")]
    public bool? ApopenDocumentIsDiscountPercentCheck { get; set; }

    [Column("APOpenDocumentDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ApopenDocumentDiscountPerCent { get; set; }

    [Column("APOpenDocumentDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ApopenDocumentDiscountFix { get; set; }

    [Column("APOpenDocumentTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApopenDocumentTaxNumber { get; set; }

    [Column("APOpenDocumentTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApopenDocumentTaxAmount { get; set; }

    [Column("APOpenDocumentSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApopenDocumentSubTotalCost { get; set; }

    [Column("APOpenDocumentTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApopenDocumentTotalCost { get; set; }

    [Column("APOpenDocumentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApopenDocumentExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("APOpenDocumentTransferredDate", TypeName = "datetime")]
    public DateTime? ApopenDocumentTransferredDate { get; set; }

    [InverseProperty("FkApopenDocument")]
    public virtual ICollection<ApdocumentPayment> ApdocumentPayments { get; set; } = new List<ApdocumentPayment>();

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("ApopenDocuments")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApopenDocuments")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApopenDocuments")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("ApopenDocuments")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApopenDocuments")]
    public virtual Hremployee FkHremployee { get; set; }
}
