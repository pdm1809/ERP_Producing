using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierPaymentDocuments")]
public partial class ApsupplierPaymentDocument
{
    [Key]
    [Column("APSupplierPaymentDocumentID")]
    public int ApsupplierPaymentDocumentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APSupplierPaymentID")]
    public int FkApsupplierPaymentId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int FkAcentryTypeId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int FkAccreditAccountId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("APSupplierPaymentDocumentDesc")]
    [StringLength(512)]
    public string ApsupplierPaymentDocumentDesc { get; set; }

    [Column("APSupplierPaymentDocumentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentDocumentAmount { get; set; }

    [Column("APSupplierPaymentDocumentExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentDocumentExchangeAmount { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_HRAdvanceRefundID")]
    public int? FkHradvanceRefundId { get; set; }

    [Column("ACEntryTypeName")]
    [StringLength(256)]
    public string AcentryTypeName { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("ApsupplierPaymentDocuments")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("ApsupplierPaymentDocumentFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("ApsupplierPaymentDocumentFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("ApsupplierPaymentDocuments")]
    public virtual AcentryType FkAcentryType { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("ApsupplierPaymentDocuments")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkApsupplierPaymentId")]
    [InverseProperty("ApsupplierPaymentDocuments")]
    public virtual ApsupplierPayment FkApsupplierPayment { get; set; }

    [ForeignKey("FkHradvanceRefundId")]
    [InverseProperty("ApsupplierPaymentDocuments")]
    public virtual HradvanceRefund FkHradvanceRefund { get; set; }
}
