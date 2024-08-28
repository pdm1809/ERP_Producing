using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTaskReportIssues")]
public partial class PmtaskReportIssue
{
    [Key]
    [Column("PMTaskReportIssueID")]
    public int PmtaskReportIssueId { get; set; }

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

    [Column("FK_PMTaskID")]
    public int? FkPmtaskId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("PMTaskReportIssueDate", TypeName = "datetime")]
    public DateTime? PmtaskReportIssueDate { get; set; }

    [Column("PMTaskReportIssueName")]
    [StringLength(256)]
    public string PmtaskReportIssueName { get; set; }

    [Column("PMTaskReportIssueDesc")]
    [StringLength(512)]
    public string PmtaskReportIssueDesc { get; set; }

    [Column("PMTaskReportIssueType")]
    [StringLength(50)]
    public string PmtaskReportIssueType { get; set; }

    [Column("PMTaskReportIssueStatus")]
    [StringLength(50)]
    public string PmtaskReportIssueStatus { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("PmtaskReportIssues")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmtaskReportIssues")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmtaskId")]
    [InverseProperty("PmtaskReportIssues")]
    public virtual Pmtask FkPmtask { get; set; }

    [InverseProperty("FkPmtaskReportIssue")]
    public virtual ICollection<PmtaskFile> PmtaskFiles { get; set; } = new List<PmtaskFile>();
}
