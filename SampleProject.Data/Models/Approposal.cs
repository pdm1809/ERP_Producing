using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APProposals")]
[Microsoft.EntityFrameworkCore.Index("ApproposalNo", "ApproposalDate", "FkBrbranchId", Name = "Idx_APProposals")]
public partial class Approposal
{
    [Key]
    [Column("APProposalID")]
    public int ApproposalId { get; set; }

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

    [Required]
    [Column("APProposalNo")]
    [StringLength(50)]
    public string ApproposalNo { get; set; }

    [Column("APProposalName")]
    [StringLength(100)]
    public string ApproposalName { get; set; }

    [Column("APProposalDesc")]
    [StringLength(512)]
    public string ApproposalDesc { get; set; }

    [Column("APProposalComment")]
    [StringLength(512)]
    public string ApproposalComment { get; set; }

    [Column("APProposalDate", TypeName = "datetime")]
    public DateTime ApproposalDate { get; set; }

    [Column("APPurchaseProposalType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseProposalType { get; set; }

    [Column("APPurchaseProposalStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseProposalStatus { get; set; }

    [Column("APProposalTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalTaxPercent { get; set; }

    [Column("APProposalTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalTaxAmount { get; set; }

    [Column("APProposalSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalSubTotalCost { get; set; }

    [Column("APProposalTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApproposalTotalCost { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("APProposalTransferredDate", TypeName = "datetime")]
    public DateTime? ApproposalTransferredDate { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMPurchasePlanID")]
    public int? FkMmpurchasePlanId { get; set; }

    [Column("APProposalAPTypeCombo")]
    [StringLength(50)]
    public string ApproposalAptypeCombo { get; set; }

    [Column("APProposalReference")]
    [StringLength(1000)]
    public string ApproposalReference { get; set; }

    [Column("APProposalNeedTime", TypeName = "datetime")]
    public DateTime? ApproposalNeedTime { get; set; }

    [Column("APProposalProposedEmployeeID")]
    public int? ApproposalProposedEmployeeId { get; set; }

    [Column("APProposalPONo")]
    [StringLength(50)]
    public string ApproposalPono { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("APProposalNeedToTime", TypeName = "datetime")]
    public DateTime? ApproposalNeedToTime { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApobjectType { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_APPurchaseContractID")]
    public int? FkAppurchaseContractId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(156)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("APProposalApproveStatus")]
    [StringLength(50)]
    public string ApproposalApproveStatus { get; set; }

    [Column("APProposalReasonType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApproposalReasonType { get; set; }

    [Column("FK_APPurchasingStaffID")]
    public int? FkAppurchasingStaffId { get; set; }

    [InverseProperty("FkApproposal")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkApproposal")]
    public virtual ICollection<ApcancelPurchaseProposal> ApcancelPurchaseProposals { get; set; } = new List<ApcancelPurchaseProposal>();

    [InverseProperty("FkApproposal")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkApproposal")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [ForeignKey("ApproposalProposedEmployeeId")]
    [InverseProperty("ApproposalApproposalProposedEmployees")]
    public virtual Hremployee ApproposalProposedEmployee { get; set; }

    [InverseProperty("FkApproposal")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [ForeignKey("FkAppurchaseContractId")]
    [InverseProperty("Approposals")]
    public virtual AppurchaseContract FkAppurchaseContract { get; set; }

    [ForeignKey("FkAppurchasingStaffId")]
    [InverseProperty("ApproposalFkAppurchasingStaffs")]
    public virtual Hremployee FkAppurchasingStaff { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Approposals")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Approposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Approposals")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Approposals")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApproposalFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("Approposals")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("Approposals")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("Approposals")]
    public virtual Pmproject FkPmproject { get; set; }
}
