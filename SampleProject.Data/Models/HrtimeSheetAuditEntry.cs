using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeSheetAuditEntrys")]
public partial class HrtimeSheetAuditEntry
{
    [Key]
    [Column("HRTimeSheetAuditEntryID")]
    public int HrtimeSheetAuditEntryId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeTimeSheetAuditID")]
    public int FkHremployeeTimeSheetAuditId { get; set; }

    [Column("FK_HRTimeSheetAuditID")]
    public int FkHrtimeSheetAuditId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int FkHrtimeSheetParamId { get; set; }

    [Column("HRTimeSheetAuditEntryDate", TypeName = "datetime")]
    public DateTime HrtimeSheetAuditEntryDate { get; set; }

    [Column("HRTimeSheetAuditEntryFrom", TypeName = "datetime")]
    public DateTime? HrtimeSheetAuditEntryFrom { get; set; }

    [Column("HRTimeSheetAuditEntryTo", TypeName = "datetime")]
    public DateTime? HrtimeSheetAuditEntryTo { get; set; }

    [Column("HRTimeSheetAuditEntryWorkingHours", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetAuditEntryWorkingHours { get; set; }

    [Column("HRTimeSheetAuditEntryWorkingQty", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetAuditEntryWorkingQty { get; set; }

    [Column("HRTimeSheetAuditEntryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetAuditEntryFactor { get; set; }

    public bool? IsNightWorking { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrtimeSheetAuditEntries")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeTimeSheetAuditId")]
    [InverseProperty("HrtimeSheetAuditEntries")]
    public virtual HremployeeTimeSheetAudit FkHremployeeTimeSheetAudit { get; set; }

    [ForeignKey("FkHrtimeSheetAuditId")]
    [InverseProperty("HrtimeSheetAuditEntries")]
    public virtual HrtimeSheetAudit FkHrtimeSheetAudit { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HrtimeSheetAuditEntries")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
