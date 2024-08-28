using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTasks")]
public partial class Ictask
{
    [Key]
    [Column("ICTaskID")]
    public int IctaskId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICTaskNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctaskNo { get; set; }

    [Column("ICTaskName")]
    [StringLength(256)]
    public string IctaskName { get; set; }

    [Column("ICTaskInfo")]
    [StringLength(512)]
    public string IctaskInfo { get; set; }

    [Column("ICTaskTotalEstimatedDays", TypeName = "decimal(18, 5)")]
    public decimal? IctaskTotalEstimatedDays { get; set; }

    [Column("ICTaskTotalActualDays", TypeName = "decimal(18, 5)")]
    public decimal? IctaskTotalActualDays { get; set; }

    [Column("ICTaskTotalEstimatedHours", TypeName = "decimal(18, 5)")]
    public decimal? IctaskTotalEstimatedHours { get; set; }

    [Column("ICTaskTotalActualHours", TypeName = "decimal(18, 5)")]
    public decimal? IctaskTotalActualHours { get; set; }

    [Column("ICTaskEstimatedExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? IctaskEstimatedExtendDays { get; set; }

    [Column("ICTaskActualExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? IctaskActualExtendDays { get; set; }

    [Column("ICTaskEstimatedExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? IctaskEstimatedExtendHours { get; set; }

    [Column("ICTaskActualExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? IctaskActualExtendHours { get; set; }

    [Column("ICTaskQty", TypeName = "decimal(18, 5)")]
    public decimal? IctaskQty { get; set; }

    [Column("ICTaskEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IctaskEstimatedTotalCost { get; set; }

    [Column("ICTaskActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IctaskActualTotalCost { get; set; }

    [InverseProperty("FkIctask")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkIctask")]
    public virtual ICollection<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; } = new List<ArproposalItemWorkTask>();

    [InverseProperty("FkIctask")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Ictasks")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Ictasks")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Ictasks")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("Ictasks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("Ictasks")]
    public virtual PmprojectType FkPmprojectType { get; set; }

    [InverseProperty("FkIctask")]
    public virtual ICollection<IcproductTask> IcproductTasks { get; set; } = new List<IcproductTask>();

    [InverseProperty("FkIctask")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkIctask")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();
}
