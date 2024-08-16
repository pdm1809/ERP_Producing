using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("PmtaskId", "Rev")]
[Table("PMTasks_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class PmtasksHistory
{
    [Key]
    [Column("PMTaskID")]
    public long PmtaskId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

    [StringLength(255)]
    public string ObjectType { get; set; }

    [Column("FK_ObjectID")]
    public int? FkObjectId { get; set; }

    [StringLength(255)]
    public string ObjectTypeName { get; set; }

    [Column("PMTaskStatus")]
    [StringLength(255)]
    public string PmtaskStatus { get; set; }

    [Column("PMTaskLocation")]
    [StringLength(256)]
    public string PmtaskLocation { get; set; }

    [Column("AACreatedDate")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("FK_HREmployeeCreatedID")]
    public int? FkHremployeeCreatedId { get; set; }

    [Column("PMTaskInfo")]
    [StringLength(512)]
    public string PmtaskInfo { get; set; }

    [Column("PMTaskActualEndDate")]
    public DateTime? PmtaskActualEndDate { get; set; }

    [Column("PMTaskName")]
    [StringLength(255)]
    public string PmtaskName { get; set; }

    [Column("PMTaskActualStartDate")]
    public DateTime? PmtaskActualStartDate { get; set; }

    [Column("AAStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("PMTaskType")]
    [StringLength(255)]
    public string PmtaskType { get; set; }

    [Column("AAUpdatedDate")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_HREmployeeUpdatedID")]
    public int? FkHremployeeUpdatedId { get; set; }

    public bool IsShare { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("PmtasksHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
