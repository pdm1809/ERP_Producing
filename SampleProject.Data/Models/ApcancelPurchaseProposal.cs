using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APCancelPurchaseProposals")]
public partial class ApcancelPurchaseProposal
{
    [Key]
    [Column("APCancelPurchaseProposalID")]
    public int ApcancelPurchaseProposalId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMPurchasePlanID")]
    public int? FkMmpurchasePlanId { get; set; }

    [Column("FK_APProposalID")]
    public int? FkApproposalId { get; set; }

    [Required]
    [Column("APCancelPurchaseProposalNo")]
    [StringLength(50)]
    public string ApcancelPurchaseProposalNo { get; set; }

    [Column("APCancelPurchaseProposalName")]
    [StringLength(100)]
    public string ApcancelPurchaseProposalName { get; set; }

    [Column("APCancelPurchaseProposalDesc")]
    [StringLength(512)]
    public string ApcancelPurchaseProposalDesc { get; set; }

    [Column("APCancelPurchaseProposalComment")]
    [StringLength(512)]
    public string ApcancelPurchaseProposalComment { get; set; }

    [Column("APCancelPurchaseProposalDate", TypeName = "datetime")]
    public DateTime ApcancelPurchaseProposalDate { get; set; }

    [Column("APCancelPurchaseProposalType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApcancelPurchaseProposalType { get; set; }

    [Column("APCancelPurchaseProposalStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApcancelPurchaseProposalStatus { get; set; }

    [Column("APCancelPurchaseProposalTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalTaxPercent { get; set; }

    [Column("APCancelPurchaseProposalTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalTaxAmount { get; set; }

    [Column("APCancelPurchaseProposalSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalSubTotalCost { get; set; }

    [Column("APCancelPurchaseProposalTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApcancelPurchaseProposalTotalCost { get; set; }

    [Column("APCancelPurchaseProposalAPTypeCombo")]
    [StringLength(50)]
    public string ApcancelPurchaseProposalAptypeCombo { get; set; }

    [Column("APCancelPurchaseProposalReference")]
    [StringLength(1000)]
    public string ApcancelPurchaseProposalReference { get; set; }

    [Column("APCancelPurchaseProposalPONo")]
    [StringLength(50)]
    public string ApcancelPurchaseProposalPono { get; set; }

    [Column("APCancelPurchaseProposalPurchasePlanType")]
    [StringLength(50)]
    public string ApcancelPurchaseProposalPurchasePlanType { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("APCancelPurchaseProposalTransferredDate", TypeName = "datetime")]
    public DateTime? ApcancelPurchaseProposalTransferredDate { get; set; }

    [Column("APCancelPurchaseProposalReasonType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApcancelPurchaseProposalReasonType { get; set; }

    [InverseProperty("FkApcancelPurchaseProposal")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [ForeignKey("FkApproposalId")]
    [InverseProperty("ApcancelPurchaseProposals")]
    public virtual Approposal FkApproposal { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApcancelPurchaseProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("ApcancelPurchaseProposals")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("ApcancelPurchaseProposals")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApcancelPurchaseProposals")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ApcancelPurchaseProposals")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("ApcancelPurchaseProposals")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }
}
