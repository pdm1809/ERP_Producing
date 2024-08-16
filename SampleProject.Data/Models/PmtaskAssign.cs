using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTaskAssigns")]
public partial class PmtaskAssign
{
    [Key]
    [Column("PMTaskAssignID")]
    public int PmtaskAssignId { get; set; }

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

    [Column("FK_PMTaskID")]
    public int? FkPmtaskId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("PMTaskAssignEmployeeName")]
    [StringLength(256)]
    public string PmtaskAssignEmployeeName { get; set; }

    [Column("PMTaskAssignStatus")]
    [StringLength(50)]
    public string PmtaskAssignStatus { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("REV")]
    public long? Rev { get; set; }

    [Column("REVTYPE")]
    public long? Revtype { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("PmtaskAssigns")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("PmtaskAssigns")]
    public virtual Hrgroup FkHrgroup { get; set; }

    [ForeignKey("FkPmtaskId")]
    [InverseProperty("PmtaskAssigns")]
    public virtual Pmtask FkPmtask { get; set; }
}
