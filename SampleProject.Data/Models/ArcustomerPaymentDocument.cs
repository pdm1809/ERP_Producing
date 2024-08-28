using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerPaymentDocuments")]
public partial class ArcustomerPaymentDocument
{
    [Key]
    [Column("ARCustomerPaymentDocumentID")]
    public int ArcustomerPaymentDocumentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerPaymentID")]
    public int FkArcustomerPaymentId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int FkAcentryTypeId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int FkAccreditAccountId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("ARCustomerPaymentDocumentDesc")]
    [StringLength(512)]
    public string ArcustomerPaymentDocumentDesc { get; set; }

    [Column("ARCustomerPaymentDocumentAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDocumentAmount { get; set; }

    [Column("ARCustomerPaymentDocumentExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerPaymentDocumentExchangeAmount { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_HRAdvanceRefundID")]
    public int? FkHradvanceRefundId { get; set; }

    [Column("ACEntryTypeName")]
    [StringLength(256)]
    public string AcentryTypeName { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("ArcustomerPaymentDocuments")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("ArcustomerPaymentDocumentFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("ArcustomerPaymentDocumentFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("ArcustomerPaymentDocuments")]
    public virtual AcentryType FkAcentryType { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("ArcustomerPaymentDocuments")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkArcustomerPaymentId")]
    [InverseProperty("ArcustomerPaymentDocuments")]
    public virtual ArcustomerPayment FkArcustomerPayment { get; set; }

    [ForeignKey("FkHradvanceRefundId")]
    [InverseProperty("ArcustomerPaymentDocuments")]
    public virtual HradvanceRefund FkHradvanceRefund { get; set; }
}
