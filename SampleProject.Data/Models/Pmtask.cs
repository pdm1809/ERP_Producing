using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTasks")]
public partial class Pmtask
{
    [Key]
    [Column("PMTaskID")]
    public int PmtaskId { get; set; }

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
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeOwnerID")]
    public int? FkHremployeeOwnerId { get; set; }

    [Column("FK_ICTaskID")]
    public int? FkIctaskId { get; set; }

    [Column("PMTaskNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtaskNo { get; set; }

    [Column("PMTaskName")]
    [StringLength(256)]
    public string PmtaskName { get; set; }

    [Column("PMTaskInfo")]
    [StringLength(512)]
    public string PmtaskInfo { get; set; }

    [Column("PMTaskTotalEstimatedDays", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskTotalEstimatedDays { get; set; }

    [Column("PMTaskTotalActualDays", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskTotalActualDays { get; set; }

    [Column("PMTaskTotalEstimatedHours", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskTotalEstimatedHours { get; set; }

    [Column("PMTaskTotalActualHours", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskTotalActualHours { get; set; }

    [Column("PMTaskEstimatedExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskEstimatedExtendDays { get; set; }

    [Column("PMTaskActualExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskActualExtendDays { get; set; }

    [Column("PMTaskEstimatedExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskEstimatedExtendHours { get; set; }

    [Column("PMTaskActualExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskActualExtendHours { get; set; }

    [Column("PMTaskQty", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskQty { get; set; }

    [Column("PMTaskEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskEstimatedTotalCost { get; set; }

    [Column("PMTaskActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskActualTotalCost { get; set; }

    [Column("PMTaskExtendTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmtaskExtendTotalCost { get; set; }

    [Column("PMTaskEstimatedStartDate", TypeName = "datetime")]
    public DateTime? PmtaskEstimatedStartDate { get; set; }

    [Column("PMTaskEstimatedEndDate", TypeName = "datetime")]
    public DateTime? PmtaskEstimatedEndDate { get; set; }

    [Column("PMTaskActualStartDate", TypeName = "datetime")]
    public DateTime? PmtaskActualStartDate { get; set; }

    [Column("PMTaskActualEndDate", TypeName = "datetime")]
    public DateTime? PmtaskActualEndDate { get; set; }

    [Column("PMTaskExtendStartDate", TypeName = "datetime")]
    public DateTime? PmtaskExtendStartDate { get; set; }

    [Column("PMTaskExtendEndDate", TypeName = "datetime")]
    public DateTime? PmtaskExtendEndDate { get; set; }

    [Column("PMTaskType")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtaskType { get; set; }

    [Column("PMTaskStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmtaskStatus { get; set; }

    [Column("PMTaskIssueType")]
    [StringLength(50)]
    public string PmtaskIssueType { get; set; }

    [Column("PMTaskIssueReason")]
    [StringLength(256)]
    public string PmtaskIssueReason { get; set; }

    [Column("FK_ObjectID")]
    public int? FkObjectId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ObjectType { get; set; }

    [Column("FK_Object01ID")]
    public int? FkObject01Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ObjectType01 { get; set; }

    [Column("FK_Object02ID")]
    public int? FkObject02Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ObjectType02 { get; set; }

    [Column("PMTaskLocation")]
    [StringLength(512)]
    public string PmtaskLocation { get; set; }

    [Column("FK_HREmployeeCreatedID")]
    public int? FkHremployeeCreatedId { get; set; }

    [Column("FK_HREmployeeUpdatedID")]
    public int? FkHremployeeUpdatedId { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [StringLength(2000)]
    public string ObjectTypeName { get; set; }

    [Column("REV")]
    public long? Rev { get; set; }

    [Column("REVTYPE")]
    public long? Revtype { get; set; }

    public bool IsShare { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("Pmtasks")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkHremployeeCreatedId")]
    [InverseProperty("PmtaskFkHremployeeCreateds")]
    public virtual Hremployee FkHremployeeCreated { get; set; }

    [ForeignKey("FkHremployeeUpdatedId")]
    [InverseProperty("PmtaskFkHremployeeUpdateds")]
    public virtual Hremployee FkHremployeeUpdated { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("Pmtasks")]
    public virtual Hrgroup FkHrgroup { get; set; }

    [InverseProperty("FkPmtask")]
    public virtual ICollection<PmtaskAssign> PmtaskAssigns { get; set; } = new List<PmtaskAssign>();

    [InverseProperty("FkPmtask")]
    public virtual ICollection<PmtaskFile> PmtaskFiles { get; set; } = new List<PmtaskFile>();

    [InverseProperty("FkPmtask")]
    public virtual ICollection<PmtaskReportIssue> PmtaskReportIssues { get; set; } = new List<PmtaskReportIssue>();
}
