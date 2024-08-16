using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectNormHistorys")]
public partial class PmprojectNormHistory
{
    [Key]
    [Column("PMProjectNormHistoryID")]
    public int PmprojectNormHistoryId { get; set; }

    [Column("AAStatus")]
    [StringLength(32)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADUserID")]
    public int AduserId { get; set; }

    [Column("ADUserName")]
    [StringLength(64)]
    public string AduserName { get; set; }

    [Required]
    [Column("PMProjectNormHistoryAction")]
    [StringLength(64)]
    [Unicode(false)]
    public string PmprojectNormHistoryAction { get; set; }

    [Column("PMProjectNormHistoryDate", TypeName = "datetime")]
    public DateTime? PmprojectNormHistoryDate { get; set; }

    [Required]
    [Column("PMProjectNormHistoryTableName")]
    [StringLength(64)]
    [Unicode(false)]
    public string PmprojectNormHistoryTableName { get; set; }

    [Required]
    [Column("PMProjectNormHistoryDetailColumnName")]
    [StringLength(128)]
    [Unicode(false)]
    public string PmprojectNormHistoryDetailColumnName { get; set; }

    [Required]
    [Column("PMProjectNormHistoryDetailOldValue")]
    [StringLength(512)]
    public string PmprojectNormHistoryDetailOldValue { get; set; }

    [Required]
    [Column("PMProjectNormHistoryDetailNewValue")]
    [StringLength(512)]
    public string PmprojectNormHistoryDetailNewValue { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_PMProjectNormID")]
    public int? FkPmprojectNormId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmprojectNormHistories")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectNormHistories")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmprojectNormId")]
    [InverseProperty("PmprojectNormHistories")]
    public virtual PmprojectNorm FkPmprojectNorm { get; set; }
}
