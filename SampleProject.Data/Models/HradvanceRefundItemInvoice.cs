using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdvanceRefundItemInvoices")]
public partial class HradvanceRefundItemInvoice
{
    [Key]
    [Column("HRAdvanceRefundItemInvoiceID")]
    public int HradvanceRefundItemInvoiceId { get; set; }

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

    [Column("FK_HRAdvanceRefundID")]
    public int FkHradvanceRefundId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("HRInputVATDocumentType")]
    [StringLength(50)]
    public string HrinputVatdocumentType { get; set; }

    [Column("HRAdvanceRefundItemInvoiceSupplierNo")]
    [StringLength(50)]
    public string HradvanceRefundItemInvoiceSupplierNo { get; set; }

    [Column("HRAdvanceRefundItemInvoiceVATSymbol")]
    [StringLength(50)]
    public string HradvanceRefundItemInvoiceVatsymbol { get; set; }

    [Column("HRAdvanceRefundItemInvoiceVATDate", TypeName = "datetime")]
    public DateTime? HradvanceRefundItemInvoiceVatdate { get; set; }

    [Column("FK_HRObjectID")]
    public int? FkHrobjectId { get; set; }

    [Column("HRObjectType")]
    [StringLength(50)]
    public string HrobjectType { get; set; }

    [Column("HRAdvanceRefundItemInvoiceObjectName")]
    [StringLength(50)]
    public string HradvanceRefundItemInvoiceObjectName { get; set; }

    [Column("HRAdvanceRefundItemInvoiceObjectAddress")]
    [StringLength(500)]
    public string HradvanceRefundItemInvoiceObjectAddress { get; set; }

    [Column("HRAdvanceRefundItemInvoiceObjectTaxNumber")]
    [StringLength(50)]
    public string HradvanceRefundItemInvoiceObjectTaxNumber { get; set; }

    [Column("HRAdvanceRefundItemInvoiceObjectDesc")]
    [StringLength(500)]
    public string HradvanceRefundItemInvoiceObjectDesc { get; set; }

    [Column("HRAdvanceRefundItemInvoiceSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRefundItemInvoiceSubTotalAmount { get; set; }

    [Column("HRAdvanceRefundItemInvoiceTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRefundItemInvoiceTaxPercent { get; set; }

    [Column("HRAdvanceRefundItemInvoiceTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRefundItemInvoiceTaxAmount { get; set; }

    [Column("HRAdvanceRefundItemInvoiceTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HradvanceRefundItemInvoiceTotalAmount { get; set; }

    [Column("FK_ACBankTransactionID")]
    public int? FkAcbankTransactionId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("HRAdvanceRefundItemInvoiceDocumentNo")]
    [StringLength(50)]
    public string HradvanceRefundItemInvoiceDocumentNo { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("HRAdvanceRefundItemInvoiceStatus")]
    [StringLength(128)]
    public string HradvanceRefundItemInvoiceStatus { get; set; }

    [Column("HRAdvanceRefundItemInvoiceType")]
    [StringLength(50)]
    public string HradvanceRefundItemInvoiceType { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("HRAdvanceRefundItemInvoiceVATFormNo")]
    [StringLength(50)]
    public string HradvanceRefundItemInvoiceVatformNo { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [InverseProperty("FkHradvanceRefundItemInvoice")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkHradvanceRefundItemInvoice")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [ForeignKey("FkAcbankTransactionId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual AcbankTransaction FkAcbankTransaction { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("HradvanceRefundItemInvoiceFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("HradvanceRefundItemInvoiceFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkHradvanceRefundId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual HradvanceRefund FkHradvanceRefund { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("HradvanceRefundItemInvoices")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
