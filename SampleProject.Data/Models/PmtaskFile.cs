using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMTaskFiles")]
public partial class PmtaskFile
{
    [Key]
    [Column("PMTaskFileID")]
    public int PmtaskFileId { get; set; }

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

    [Column("PMTaskFileType")]
    [StringLength(50)]
    public string PmtaskFileType { get; set; }

    [Column("PMTaskFileName")]
    public Guid? PmtaskFileName { get; set; }

    [Column("PMTaskFileDesc")]
    [StringLength(256)]
    public string PmtaskFileDesc { get; set; }

    [Column("PMTaskFileLinkRoot")]
    [StringLength(256)]
    public string PmtaskFileLinkRoot { get; set; }

    [Column("PMTaskFileLink")]
    [StringLength(256)]
    public string PmtaskFileLink { get; set; }

    [Column("PMTaskFileExtention")]
    [StringLength(10)]
    public string PmtaskFileExtention { get; set; }

    [Column("FK_PMTaskReportIssueID")]
    public int? FkPmtaskReportIssueId { get; set; }

    [ForeignKey("FkPmtaskId")]
    [InverseProperty("PmtaskFiles")]
    public virtual Pmtask FkPmtask { get; set; }

    [ForeignKey("FkPmtaskReportIssueId")]
    [InverseProperty("PmtaskFiles")]
    public virtual PmtaskReportIssue FkPmtaskReportIssue { get; set; }
}
