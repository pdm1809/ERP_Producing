using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTaskComments")]
public partial class PmtaskComment
{
    [Key]
    [Column("PMTaskCommentID")]
    public int PmtaskCommentId { get; set; }

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

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("PMTaskCommentDate", TypeName = "datetime")]
    public DateTime? PmtaskCommentDate { get; set; }

    [Column("PMTaskCommentTitle")]
    [StringLength(256)]
    public string PmtaskCommentTitle { get; set; }

    [Column("PMTaskCommentContent")]
    [StringLength(256)]
    public string PmtaskCommentContent { get; set; }

    [Column("PMTaskCommentStatus")]
    [StringLength(50)]
    public string PmtaskCommentStatus { get; set; }

    [Column("PMTaskCommentParentID")]
    public int PmtaskCommentParentId { get; set; }
}
