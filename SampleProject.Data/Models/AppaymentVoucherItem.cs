using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPaymentVoucherItems")]
[Microsoft.EntityFrameworkCore.Index("FkAppaymentVoucherId", Name = "Idx_APPaymentVoucherItems")]
public partial class AppaymentVoucherItem
{
    [Key]
    [Column("APPaymentVoucherItemID")]
    public int AppaymentVoucherItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APPaymentVoucherID")]
    public int FkAppaymentVoucherId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int FkAcentryTypeId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Required]
    [Column("APPaymentVoucherItemDesc")]
    [StringLength(512)]
    public string AppaymentVoucherItemDesc { get; set; }

    [Column("APPaymentVoucherItemAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherItemAmount { get; set; }

    [Column("APPaymentVoucherItemExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherItemExchangeAmount { get; set; }

    [Column("FK_HRAdvanceRequestItemID")]
    public int? FkHradvanceRequestItemId { get; set; }

    public bool? IsCreateFromAdvanceRequest { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_HRAdvanceRefundID")]
    public int? FkHradvanceRefundId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("APPaymentVoucherItemReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentVoucherItemReference { get; set; }

    [Column("APPaymentVoucherItemVATDocumentType")]
    [StringLength(128)]
    public string AppaymentVoucherItemVatdocumentType { get; set; }

    [Column("APPaymentVoucherItemVATFormNo")]
    [StringLength(128)]
    public string AppaymentVoucherItemVatformNo { get; set; }

    [Column("APPaymentVoucherItemVoucherNo")]
    [StringLength(128)]
    public string AppaymentVoucherItemVoucherNo { get; set; }

    [Column("APPaymentVoucherItemInvoiceDate", TypeName = "datetime")]
    public DateTime? AppaymentVoucherItemInvoiceDate { get; set; }

    [Column("APPaymentVoucherItemVATInvoiceNo")]
    [StringLength(128)]
    public string AppaymentVoucherItemVatinvoiceNo { get; set; }

    [Column("APPaymentVoucherItemVATSymbol")]
    [StringLength(128)]
    public string AppaymentVoucherItemVatsymbol { get; set; }

    [Column("APPaymentVoucherItemTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentVoucherItemTaxNumber { get; set; }

    [Column("APPaymentVoucherItemTaxPercent")]
    public int? AppaymentVoucherItemTaxPercent { get; set; }

    [Column("APPaymentVoucherItemTaxAmount", TypeName = "decimal(18, 0)")]
    public decimal? AppaymentVoucherItemTaxAmount { get; set; }

    [Column("APPaymentVoucherItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherItemTotalAmount { get; set; }

    [Column("APPaymentVoucherItemTotalExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppaymentVoucherItemTotalExchangeAmount { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApobjectType { get; set; }

    [Column("APObjectName")]
    [StringLength(100)]
    public string ApobjectName { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("FK_HRAdvanceRefundItemInvoiceID")]
    public int? FkHradvanceRefundItemInvoiceId { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AppaymentVoucherItemFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AppaymentVoucherItemFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual AcentryType FkAcentryType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkAppaymentVoucherId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual AppaymentVoucher FkAppaymentVoucher { get; set; }

    [ForeignKey("FkHradvanceRefundId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual HradvanceRefund FkHradvanceRefund { get; set; }

    [ForeignKey("FkHradvanceRefundItemInvoiceId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual HradvanceRefundItemInvoice FkHradvanceRefundItemInvoice { get; set; }

    [ForeignKey("FkHradvanceRequestItemId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual HradvanceRequestItem FkHradvanceRequestItem { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("AppaymentVoucherItems")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
