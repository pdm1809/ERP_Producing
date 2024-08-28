using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProposalPaymentTimes")]
public partial class ArproposalPaymentTime
{
    [Key]
    [Column("ARProposalPaymentTimeID")]
    public int ArproposalPaymentTimeId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [Required]
    [Column("ARProposalPaymentTimeName")]
    [StringLength(100)]
    public string ArproposalPaymentTimeName { get; set; }

    [Column("ARProposalPaymentTimeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalPaymentTimeAmount { get; set; }

    [Column("ARProposalPaymentTimeDate", TypeName = "datetime")]
    public DateTime? ArproposalPaymentTimeDate { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARProposalPaymentTimeRemark")]
    [StringLength(512)]
    public string ArproposalPaymentTimeRemark { get; set; }

    [Column("ARProposalPaymentTimeStatus")]
    [StringLength(50)]
    public string ArproposalPaymentTimeStatus { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int? FkGepaymentTermId { get; set; }

    [Column("ARProposalPaymentTimeDueDate", TypeName = "datetime")]
    public DateTime? ArproposalPaymentTimeDueDate { get; set; }

    [Column("ARProposalPaymentTimeDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalPaymentTimeDepositBalance { get; set; }

    [Column("ARProposalPaymentTimeBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalPaymentTimeBalanceDue { get; set; }

    [Column("ARProposalPaymentTimePaymentType")]
    [StringLength(50)]
    public string ArproposalPaymentTimePaymentType { get; set; }

    [Column("ARProposalPaymentTimePaymentTimepoint")]
    [StringLength(100)]
    public string ArproposalPaymentTimePaymentTimepoint { get; set; }

    [Column("ARProposalPaymentTimePaymentTermItemDay")]
    public int? ArproposalPaymentTimePaymentTermItemDay { get; set; }

    [Column("ARProposalPaymentTimePaymentTermItemPercentPayment", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalPaymentTimePaymentTermItemPercentPayment { get; set; }

    [Column("ARProposalPaymentTimePaymentTermItemPaymentType")]
    [StringLength(50)]
    public string ArproposalPaymentTimePaymentTermItemPaymentType { get; set; }

    [Column("ARProposalPaymentTimePaymentTermItemType")]
    [StringLength(50)]
    public string ArproposalPaymentTimePaymentTermItemType { get; set; }

    [Column("FK_ARCustomerPaymentID")]
    public int? FkArcustomerPaymentId { get; set; }

    [Column("ARProposalPaymentTimeDepositBalanceFromCustomerPayment", TypeName = "decimal(18, 0)")]
    public decimal? ArproposalPaymentTimeDepositBalanceFromCustomerPayment { get; set; }

    [Column("ARProposalPaymentTimeDepositBalanceFromExtraCustomerPayment", TypeName = "decimal(18, 0)")]
    public decimal? ArproposalPaymentTimeDepositBalanceFromExtraCustomerPayment { get; set; }

    [Column("FK_ARExtraCustomerPaymentID")]
    public int? FkArextraCustomerPaymentId { get; set; }

    [Column("FK_GEPaymentTermItemID")]
    public int? FkGepaymentTermItemId { get; set; }

    [ForeignKey("FkArcustomerPaymentId")]
    [InverseProperty("ArproposalPaymentTimes")]
    public virtual ArcustomerPayment FkArcustomerPayment { get; set; }

    [ForeignKey("FkArproposalId")]
    [InverseProperty("ArproposalPaymentTimes")]
    public virtual Arproposal FkArproposal { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("ArproposalPaymentTimes")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [ForeignKey("FkGepaymentTermItemId")]
    [InverseProperty("ArproposalPaymentTimes")]
    public virtual GepaymentTermItem FkGepaymentTermItem { get; set; }
}
