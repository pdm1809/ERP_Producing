using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlanCapacitys")]
public partial class MmoperationDetailPlanCapacity
{
    [Key]
    [Column("MMOperationDetailPlanCapacityID")]
    public int MmoperationDetailPlanCapacityId { get; set; }

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

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("MMOperationDetailPlanCapacityNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanCapacityNo { get; set; }

    [Column("MMOperationDetailPlanNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanNo { get; set; }

    [Column("MMOperationDetailPlanCapacityDesc")]
    [StringLength(512)]
    public string MmoperationDetailPlanCapacityDesc { get; set; }

    [Column("MMOperationDetailPlanCapacityStatus")]
    [StringLength(50)]
    public string MmoperationDetailPlanCapacityStatus { get; set; }

    [Column("MMOperationDetailPlanCapacityTotalProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityTotalProductQty { get; set; }

    [Column("MMOperationDetailPlanCapacityTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanCapacityTotalBlock { get; set; }

    [Column("MMOperationDetailPlanCapacityDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCapacityDate { get; set; }

    [Column("MMOperationDetailPlanCapacityToApprovedDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanCapacityToApprovedDate { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmoperationDetailPlanCapacities")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmoperationDetailPlanCapacityFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeIdapproved")]
    [InverseProperty("MmoperationDetailPlanCapacityFkHremployeeIdapprovedNavigations")]
    public virtual Hremployee FkHremployeeIdapprovedNavigation { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmoperationDetailPlanCapacities")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationDetailPlanCapacities")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmoperationDetailPlanCapacities")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmoperationDetailPlanCapacities")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
