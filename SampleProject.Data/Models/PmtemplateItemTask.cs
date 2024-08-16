using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTemplateItemTasks")]
public partial class PmtemplateItemTask
{
    [Key]
    [Column("PMTemplateItemTaskID")]
    public int PmtemplateItemTaskId { get; set; }

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

    [Column("FK_ICProductTaskID")]
    public int? FkIcproductTaskId { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("PMTemplateItemTaskNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtemplateItemTaskNo { get; set; }

    [Column("PMTemplateItemTaskName")]
    [StringLength(256)]
    public string PmtemplateItemTaskName { get; set; }

    [Column("PMTemplateItemTaskInfo")]
    [StringLength(512)]
    public string PmtemplateItemTaskInfo { get; set; }

    [Column("PMTemplateItemTaskTotalEstimatedDays", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskTotalEstimatedDays { get; set; }

    [Column("PMTemplateItemTaskTotalActualDays", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskTotalActualDays { get; set; }

    [Column("PMTemplateItemTaskTotalEstimatedHours", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskTotalEstimatedHours { get; set; }

    [Column("PMTemplateItemTaskTotalActualHours", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskTotalActualHours { get; set; }

    [Column("PMTemplateItemTaskEstimatedExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskEstimatedExtendDays { get; set; }

    [Column("PMTemplateItemTaskActualExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskActualExtendDays { get; set; }

    [Column("PMTemplateItemTaskEstimatedExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskEstimatedExtendHours { get; set; }

    [Column("PMTemplateItemTaskActualExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskActualExtendHours { get; set; }

    [Column("PMTemplateItemTaskQty", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskQty { get; set; }

    [Column("PMTemplateItemTaskEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskEstimatedTotalCost { get; set; }

    [Column("PMTemplateItemTaskTaskActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmtemplateItemTaskTaskActualTotalCost { get; set; }

    [Column("PMTemplateItemTaskEstimatedStartDate", TypeName = "datetime")]
    public DateTime? PmtemplateItemTaskEstimatedStartDate { get; set; }

    [Column("PMTemplateItemTaskActualStartDate", TypeName = "datetime")]
    public DateTime? PmtemplateItemTaskActualStartDate { get; set; }

    [Column("PMTemplateItemTaskEstimatedEndDate", TypeName = "datetime")]
    public DateTime? PmtemplateItemTaskEstimatedEndDate { get; set; }

    [Column("PMTemplateItemTaskActualEndDate", TypeName = "datetime")]
    public DateTime? PmtemplateItemTaskActualEndDate { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductTaskId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual IcproductTask FkIcproductTask { get; set; }

    [ForeignKey("FkIctaskId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual Ictask FkIctask { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual PmprojectType FkPmprojectType { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("PmtemplateItemTasks")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }
}
