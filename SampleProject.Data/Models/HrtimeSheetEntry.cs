using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeSheetEntrys")]
public partial class HrtimeSheetEntry
{
    [Key]
    [Column("HRTimeSheetEntryID")]
    public int HrtimeSheetEntryId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeTimeSheetID")]
    public int FkHremployeeTimeSheetId { get; set; }

    [Column("FK_HRTimeSheetID")]
    public int FkHrtimeSheetId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int FkHrtimeSheetParamId { get; set; }

    [Column("HRTimeSheetEntryDate", TypeName = "datetime")]
    public DateTime HrtimeSheetEntryDate { get; set; }

    [Column("HRTimeSheetEntryFrom", TypeName = "datetime")]
    public DateTime? HrtimeSheetEntryFrom { get; set; }

    [Column("HRTimeSheetEntryTo", TypeName = "datetime")]
    public DateTime? HrtimeSheetEntryTo { get; set; }

    [Column("HRTimeSheetEntryWorkingHours", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetEntryWorkingHours { get; set; }

    [Column("HRTimeSheetEntryWorkingQty", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetEntryWorkingQty { get; set; }

    [Column("HRTimeSheetEntryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetEntryFactor { get; set; }

    public bool? IsNightWorking { get; set; }

    [Column("HRTimeSheetEntryPermissionOTDaysOff", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetEntryPermissionOtdaysOff { get; set; }

    [Column("HRTimeSheetEntryHolidayWorkingHours", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetEntryHolidayWorkingHours { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrtimeSheetEntries")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeTimeSheetId")]
    [InverseProperty("HrtimeSheetEntries")]
    public virtual HremployeeTimeSheet FkHremployeeTimeSheet { get; set; }

    [ForeignKey("FkHrtimeSheetId")]
    [InverseProperty("HrtimeSheetEntries")]
    public virtual HrtimeSheet FkHrtimeSheet { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HrtimeSheetEntries")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
