using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDocuments")]
[Microsoft.EntityFrameworkCore.Index("AcdocumentNo", "AcdocumentDate", "FkBrbranchId", "FkAcobjectId", "AcobjectType", "AcdocumentReference", Name = "Idx_ACDocuments")]
public partial class Acdocument
{
    [Key]
    [Column("ACDocumentID")]
    public int AcdocumentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ACDocumentTypeID")]
    public int FkAcdocumentTypeId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ACDocumentNo")]
    [StringLength(50)]
    public string AcdocumentNo { get; set; }

    [Column("ACDocumentName")]
    [StringLength(100)]
    public string AcdocumentName { get; set; }

    [Column("ACDocumentDesc")]
    [StringLength(1024)]
    public string AcdocumentDesc { get; set; }

    [Column("ACDocumentDate", TypeName = "datetime")]
    public DateTime AcdocumentDate { get; set; }

    [Column("ACDocumentPostingDate", TypeName = "datetime")]
    public DateTime AcdocumentPostingDate { get; set; }

    public bool? IsPosted { get; set; }

    [Column("ACDocumentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentTotalAmount { get; set; }

    [Column("ACDocumentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentExchangeRate { get; set; }

    [Column("ACDocumentExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentExchangeAmount { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("ACAssObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcassObjectType { get; set; }

    [Column("ACDocumentReference")]
    [StringLength(50)]
    public string AcdocumentReference { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ACDocumentTransferredDate", TypeName = "datetime")]
    public DateTime? AcdocumentTransferredDate { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ACDocumentVATFormNo")]
    [StringLength(50)]
    public string AcdocumentVatformNo { get; set; }

    [Column("ACDocumentVATSymbol")]
    [StringLength(50)]
    public string AcdocumentVatsymbol { get; set; }

    [Column("ACDocumentVoucherNo")]
    [StringLength(50)]
    public string AcdocumentVoucherNo { get; set; }

    [Column("ACDocumentObjectTaxNumber")]
    [StringLength(50)]
    public string AcdocumentObjectTaxNumber { get; set; }

    [Column("ACDocumentVATType")]
    [StringLength(50)]
    public string AcdocumentVattype { get; set; }

    [Column("ACVATDocumentType")]
    [StringLength(1000)]
    public string AcvatdocumentType { get; set; }

    [Column("ACVATInvoiceNoCombo")]
    [StringLength(50)]
    public string AcvatinvoiceNoCombo { get; set; }

    [Column("ACDocumentProductDesc")]
    [StringLength(2000)]
    public string AcdocumentProductDesc { get; set; }

    [Column("ACDocumentInvoiceDate", TypeName = "datetime")]
    public DateTime? AcdocumentInvoiceDate { get; set; }

    [Column("ACInputVATDocumentType")]
    [StringLength(50)]
    public string AcinputVatdocumentType { get; set; }

    [Column("ACDocumentPaymentDueDate", TypeName = "datetime")]
    public DateTime? AcdocumentPaymentDueDate { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ACDocumentPostedStatus")]
    [StringLength(64)]
    public string AcdocumentPostedStatus { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(50)]
    public string SttoolbarActionName { get; set; }

    [Column("ACDocumentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcdocumentStatus { get; set; }

    [Column("ACDocumentAllocationCriteria")]
    [StringLength(64)]
    public string AcdocumentAllocationCriteria { get; set; }

    [Column("ACDocumentCreateFrom")]
    [StringLength(64)]
    public string AcdocumentCreateFrom { get; set; }

    [Column("ACDocumentFollowPosted")]
    public bool? AcdocumentFollowPosted { get; set; }

    [Column("ACDocumentProject")]
    [StringLength(100)]
    public string AcdocumentProject { get; set; }

    [Column("ACDocumentTaxEntryType")]
    [StringLength(100)]
    public string AcdocumentTaxEntryType { get; set; }

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcclearingDebtInvoiceInItem> AcclearingDebtInvoiceInItems { get; set; } = new List<AcclearingDebtInvoiceInItem>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcloanReceiptItem> AcloanReceiptItems { get; set; } = new List<AcloanReceiptItem>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcloanReceiptPayDoc> AcloanReceiptPayDocs { get; set; } = new List<AcloanReceiptPayDoc>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AcrelativeDocument> AcrelativeDocumentFkAcdocuments { get; set; } = new List<AcrelativeDocument>();

    [InverseProperty("FkAcrelativeDocument")]
    public virtual ICollection<AcrelativeDocument> AcrelativeDocumentFkAcrelativeDocuments { get; set; } = new List<AcrelativeDocument>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApallocationCostItemInvoice> ApallocationCostItemInvoices { get; set; } = new List<ApallocationCostItemInvoice>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; } = new List<ApfeePaymentFeeConfig>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApfeePaymentInvoiceIn> ApfeePaymentInvoiceIns { get; set; } = new List<ApfeePaymentInvoiceIn>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApfeePaymentInvoiceInternalReceipt> ApfeePaymentInvoiceInternalReceipts { get; set; } = new List<ApfeePaymentInvoiceInternalReceipt>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApfeePaymentInvoice> ApfeePaymentInvoices { get; set; } = new List<ApfeePaymentInvoice>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApfeePaymentItem> ApfeePaymentItems { get; set; } = new List<ApfeePaymentItem>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApfeePaymentPurchaseOrder> ApfeePaymentPurchaseOrders { get; set; } = new List<ApfeePaymentPurchaseOrder>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApfeePaymentReceipt> ApfeePaymentReceipts { get; set; } = new List<ApfeePaymentReceipt>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ApfeePaymentTransfer> ApfeePaymentTransfers { get; set; } = new List<ApfeePaymentTransfer>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetails { get; set; } = new List<AppopaymentTimeInvoiceInDetail>();

    [InverseProperty("FkAcdocument")]
    public virtual ICollection<ArfeePaymentCommission> ArfeePaymentCommissions { get; set; } = new List<ArfeePaymentCommission>();

    [ForeignKey("FkAcdocumentTypeId")]
    [InverseProperty("Acdocuments")]
    public virtual AcdocumentType FkAcdocumentType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("Acdocuments")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Acdocuments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("Acdocuments")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Acdocuments")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Acdocuments")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("Acdocuments")]
    public virtual Pmproject FkPmproject { get; set; }
}
