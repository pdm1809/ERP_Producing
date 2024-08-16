using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlans")]
public partial class MmoperationDetailPlan
{
    [Key]
    [Column("MMOperationDetailPlanID")]
    public int MmoperationDetailPlanId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeIDApproved")]
    public int? FkHremployeeIdapproved { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("MMOperationDetailPlanName")]
    [StringLength(50)]
    public string MmoperationDetailPlanName { get; set; }

    [Column("MMOperationDetailPlanNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanNo { get; set; }

    [Column("MMOperationDetailPlanDesc")]
    [StringLength(512)]
    public string MmoperationDetailPlanDesc { get; set; }

    [Column("MMOperationDetailPlanStatus")]
    [StringLength(50)]
    public string MmoperationDetailPlanStatus { get; set; }

    [Column("MMOperationDetailPlanTotalProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanTotalProductQty { get; set; }

    [Column("MMOperationDetailPlanTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanTotalBlock { get; set; }

    [Column("MMOperationDetailPlanDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanDate { get; set; }

    [Column("MMOperationDetailPlanFromDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanFromDate { get; set; }

    [Column("MMOperationDetailPlanToDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanToDate { get; set; }

    [Column("MMOperationDetailPlanToApprovedDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanToApprovedDate { get; set; }

    [Column("MMOperationDetailPlanType")]
    [StringLength(50)]
    public string MmoperationDetailPlanType { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("MMOperationDetailPlanWeek")]
    [StringLength(50)]
    public string MmoperationDetailPlanWeek { get; set; }

    [Column("MMOperationDetailPlanOutSourcingValue")]
    [StringLength(50)]
    public string MmoperationDetailPlanOutSourcingValue { get; set; }

    [Column("MMOperationDetailPlanOutSourcingText")]
    [StringLength(512)]
    public string MmoperationDetailPlanOutSourcingText { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmoperationDetailPlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("MmoperationDetailPlans")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmoperationDetailPlanFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeIdapproved")]
    [InverseProperty("MmoperationDetailPlanFkHremployeeIdapprovedNavigations")]
    public virtual Hremployee FkHremployeeIdapprovedNavigation { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmoperationDetailPlans")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationDetailPlans")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("InverseFkMmoperationDetailPlan")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmoperationDetailPlans")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmoperationDetailPlan> InverseFkMmoperationDetailPlan { get; set; } = new List<MmoperationDetailPlan>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmoperationDetailPlanCancel> MmoperationDetailPlanCancels { get; set; } = new List<MmoperationDetailPlanCancel>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmoperationDetailPlanCapacity> MmoperationDetailPlanCapacities { get; set; } = new List<MmoperationDetailPlanCapacity>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmoperationDetailPlanItemChild> MmoperationDetailPlanItemChildren { get; set; } = new List<MmoperationDetailPlanItemChild>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkMmoperationDetailPlan")]
    public virtual ICollection<MmwoodPlan> MmwoodPlans { get; set; } = new List<MmwoodPlan>();
}
