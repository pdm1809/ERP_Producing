using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBankTransactionItems")]
[Microsoft.EntityFrameworkCore.Index("FkAcbankTransactionId", Name = "Idx_ACBankTransactionItems")]
public partial class AcbankTransactionItem
{
    [Key]
    [Column("ACBankTransactionItemID")]
    public int AcbankTransactionItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACBankTransactionID")]
    public int FkAcbankTransactionId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int FkAcentryTypeId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int FkAccreditAccountId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("ACBankTransactionItemDesc")]
    [StringLength(512)]
    public string AcbankTransactionItemDesc { get; set; }

    [Column("ACBankTransactionItemAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionItemAmount { get; set; }

    [Column("ACBankTransactionItemExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionItemExchangeAmount { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_HRAdvanceRefundID")]
    public int? FkHradvanceRefundId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_HRAdvanceRequestItemID")]
    public int? FkHradvanceRequestItemId { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("ACBankTransactionItemReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcbankTransactionItemReference { get; set; }

    [Column("ACBankTransactionItemVATDocumentType")]
    [StringLength(128)]
    public string AcbankTransactionItemVatdocumentType { get; set; }

    [Column("ACBankTransactionItemVATFormNo")]
    [StringLength(128)]
    public string AcbankTransactionItemVatformNo { get; set; }

    [Column("ACBankTransactionItemVoucherNo")]
    [StringLength(128)]
    public string AcbankTransactionItemVoucherNo { get; set; }

    [Column("ACBankTransactionItemInvoiceDate", TypeName = "datetime")]
    public DateTime? AcbankTransactionItemInvoiceDate { get; set; }

    [Column("ACBankTransactionItemVATInvoiceNo")]
    [StringLength(128)]
    public string AcbankTransactionItemVatinvoiceNo { get; set; }

    [Column("ACBankTransactionItemVATSymbol")]
    [StringLength(128)]
    public string AcbankTransactionItemVatsymbol { get; set; }

    [Column("ACBankTransactionItemTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcbankTransactionItemTaxNumber { get; set; }

    [Column("ACBankTransactionItemTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionItemTaxPercent { get; set; }

    [Column("ACBankTransactionItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionItemTaxAmount { get; set; }

    [Column("ACBankTransactionItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionItemTotalAmount { get; set; }

    [Column("ACBankTransactionItemTotalExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionItemTotalExchangeAmount { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("ACObjectName")]
    [StringLength(100)]
    public string AcobjectName { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("FK_HRAdvanceRefundItemInvoiceID")]
    public int? FkHradvanceRefundItemInvoiceId { get; set; }

    [Column("ACBankTransactionItemFeeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbankTransactionItemFeeAmount { get; set; }

    [ForeignKey("FkAcbankTransactionId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual AcbankTransaction FkAcbankTransaction { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AcbankTransactionItemFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AcbankTransactionItemFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual AcentryType FkAcentryType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkHradvanceRefundId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual HradvanceRefund FkHradvanceRefund { get; set; }

    [ForeignKey("FkHradvanceRefundItemInvoiceId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual HradvanceRefundItemInvoice FkHradvanceRefundItemInvoice { get; set; }

    [ForeignKey("FkHradvanceRequestItemId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual HradvanceRequestItem FkHradvanceRequestItem { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("AcbankTransactionItems")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
