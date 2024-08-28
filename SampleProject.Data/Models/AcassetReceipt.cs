using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAssetReceipts")]
[Microsoft.EntityFrameworkCore.Index("AcassetReceiptNo", "AcassetReceiptDate", "FkBrbranchId", "AcassetReceiptType", Name = "Idx_ACAssetReceipts")]
public partial class AcassetReceipt
{
    [Key]
    [Column("ACAssetReceiptID")]
    public int AcassetReceiptId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ACAssetReceiptNo")]
    [StringLength(50)]
    public string AcassetReceiptNo { get; set; }

    [Column("ACAssetReceiptDesc")]
    [StringLength(512)]
    public string AcassetReceiptDesc { get; set; }

    [Column("ACAssetReceiptDate", TypeName = "datetime")]
    public DateTime? AcassetReceiptDate { get; set; }

    [Required]
    [Column("ACAssetReceiptType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcassetReceiptType { get; set; }

    [Column("ACAssetReceiptStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcassetReceiptStatus { get; set; }

    [Column("ACAssetReceiptExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptExchangeRate { get; set; }

    [Column("ACAssetReceiptDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptDiscountPercent { get; set; }

    [Column("ACAssetReceiptDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptDiscountAmount { get; set; }

    [Column("ACAssetReceiptTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptTaxPercent { get; set; }

    [Column("ACAssetReceiptTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptTaxAmount { get; set; }

    [Column("ACAssetReceiptShippingFee", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptShippingFee { get; set; }

    [Column("ACAssetReceiptExtraFee", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptExtraFee { get; set; }

    [Column("ACAssetReceiptSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptSubTotalCost { get; set; }

    [Column("ACAssetReceiptTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptTotalCost { get; set; }

    [Column("ACAssetReceiptInvoiceNo")]
    [StringLength(50)]
    public string AcassetReceiptInvoiceNo { get; set; }

    [Column("ACAssetReceiptInvoiceDate", TypeName = "datetime")]
    public DateTime? AcassetReceiptInvoiceDate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ACAssetReceiptTransferredDate", TypeName = "datetime")]
    public DateTime? AcassetReceiptTransferredDate { get; set; }

    [Column("APInputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string ApinputVatinvoiceNoCombo { get; set; }

    [Column("APInputVATDocumentType")]
    [StringLength(512)]
    public string ApinputVatdocumentType { get; set; }

    [Column("ACAssetReceiptFormNo")]
    [StringLength(50)]
    public string AcassetReceiptFormNo { get; set; }

    [Column("ACAssetReceiptSymbol")]
    [StringLength(50)]
    public string AcassetReceiptSymbol { get; set; }

    [Column("ACAssetReceiptObjectTaxNumber")]
    [StringLength(50)]
    public string AcassetReceiptObjectTaxNumber { get; set; }

    [Column("ACAssetReceiptSupplierTaxNumber")]
    [StringLength(50)]
    public string AcassetReceiptSupplierTaxNumber { get; set; }

    [Column("ACAssetReceiptSupplierContactAddress")]
    [StringLength(200)]
    public string AcassetReceiptSupplierContactAddress { get; set; }

    [Column("ACAssetReceiptPaymentTermDate", TypeName = "datetime")]
    public DateTime? AcassetReceiptPaymentTermDate { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(50)]
    public string SttoolbarActionName { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("ACAssetReceiptPostedStatus")]
    [StringLength(50)]
    public string AcassetReceiptPostedStatus { get; set; }

    [Column("FK_APPurchaseContractID")]
    public int? FkAppurchaseContractId { get; set; }

    [Column("ACAssetReceiptVATFormNo")]
    [StringLength(50)]
    public string AcassetReceiptVatformNo { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [InverseProperty("FkAcassetReceipt")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("AcassetReceipts")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkAppurchaseContractId")]
    [InverseProperty("AcassetReceipts")]
    public virtual AppurchaseContract FkAppurchaseContract { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("AcassetReceipts")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcassetReceipts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcassetReceipts")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AcassetReceipts")]
    public virtual Hremployee FkHremployee { get; set; }
}
