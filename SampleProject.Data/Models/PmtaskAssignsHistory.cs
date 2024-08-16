using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("PmtaskAssignId", "Rev")]
[Table("PMTaskAssigns_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class PmtaskAssignsHistory
{
    [Key]
    [Column("PMTaskAssignID")]
    public int PmtaskAssignId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

    [Column("AACreatedDate")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AAUpdatedDate")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_PMTaskID")]
    public long? FkPmtaskId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("PmtaskAssignsHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
