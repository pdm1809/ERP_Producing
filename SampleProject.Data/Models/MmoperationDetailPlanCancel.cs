using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlanCancels")]
public partial class MmoperationDetailPlanCancel
{
    [Key]
    [Column("MMOperationDetailPlanCancelID")]
    public int MmoperationDetailPlanCancelId { get; set; }

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

    [Column("MMOperationDetailPlanCancelNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelNo { get; set; }

    [Column("MMOperationDetailPlanCancelDesc")]
    [StringLength(512)]
    public string MmoperationDetailPlanCancelDesc { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("MMOperationDetailPlanCancelWeek")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelWeek { get; set; }

    [Column("MMOperationDetailPlanCancelDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCancelDate { get; set; }

    [Column("MMOperationDetailPlanCancelApprovedDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCancelApprovedDate { get; set; }

    [Column("MMOperationDetailPlanCancelStatus")]
    [StringLength(50)]
    public string MmoperationDetailPlanCancelStatus { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmoperationDetailPlanCancels")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmoperationDetailPlanCancelFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeIdapproved")]
    [InverseProperty("MmoperationDetailPlanCancelFkHremployeeIdapprovedNavigations")]
    public virtual Hremployee FkHremployeeIdapprovedNavigation { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmoperationDetailPlanCancels")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationDetailPlanCancels")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmoperationDetailPlanCancels")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmoperationDetailPlanCancels")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmoperationDetailPlanCancel")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();
}
