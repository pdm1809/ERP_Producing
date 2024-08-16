using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectNormTasks")]
public partial class PmprojectNormTask
{
    [Key]
    [Column("PMProjectNormTaskID")]
    public int PmprojectNormTaskId { get; set; }

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

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICTaskID")]
    public int? FkIctaskId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_PMProjectNormID")]
    public int? FkPmprojectNormId { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("PMProjectNormTaskNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectNormTaskNo { get; set; }

    [Column("PMProjectNormTaskName")]
    [StringLength(256)]
    public string PmprojectNormTaskName { get; set; }

    [Column("PMProjectNormTaskInfo")]
    [StringLength(512)]
    public string PmprojectNormTaskInfo { get; set; }

    [Column("PMProjectNormTaskTotalEstimatedDays", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskTotalEstimatedDays { get; set; }

    [Column("PMProjectNormTaskTotalActualDays", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskTotalActualDays { get; set; }

    [Column("PMProjectNormTaskTotalEstimatedHours", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskTotalEstimatedHours { get; set; }

    [Column("PMProjectNormTaskTotalActualHours", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskTotalActualHours { get; set; }

    [Column("PMProjectNormTaskEstimatedExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskEstimatedExtendDays { get; set; }

    [Column("PMProjectNormTaskActualExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskActualExtendDays { get; set; }

    [Column("PMProjectNormTaskEstimatedExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskEstimatedExtendHours { get; set; }

    [Column("PMProjectNormTaskActualExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskActualExtendHours { get; set; }

    [Column("PMProjectNormTaskQty", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskQty { get; set; }

    [Column("PMProjectNormTaskEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskEstimatedTotalCost { get; set; }

    [Column("PMProjectNormTaskActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectNormTaskActualTotalCost { get; set; }

    [Column("PMProjectNormTaskEstimatedStartDate", TypeName = "datetime")]
    public DateTime? PmprojectNormTaskEstimatedStartDate { get; set; }

    [Column("PMProjectNormTaskActualStartDate", TypeName = "datetime")]
    public DateTime? PmprojectNormTaskActualStartDate { get; set; }

    [Column("PMProjectNormTaskEstimatedEndDate", TypeName = "datetime")]
    public DateTime? PmprojectNormTaskEstimatedEndDate { get; set; }

    [Column("PMProjectNormTaskActualEndDate", TypeName = "datetime")]
    public DateTime? PmprojectNormTaskActualEndDate { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIctaskId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual Ictask FkIctask { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmprojectNormId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual PmprojectNorm FkPmprojectNorm { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual PmprojectType FkPmprojectType { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("PmprojectNormTasks")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }
}
