using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADWorkingShifts")]
[Microsoft.EntityFrameworkCore.Index("AdworkingShiftNo", Name = "Idx_ADWorkingShifts")]
public partial class AdworkingShift
{
    [Key]
    [Column("ADWorkingShiftID")]
    public int AdworkingShiftId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Required]
    [Column("ADWorkingShiftNo")]
    [StringLength(50)]
    public string AdworkingShiftNo { get; set; }

    [Required]
    [Column("ADWorkingShiftName")]
    [StringLength(50)]
    public string AdworkingShiftName { get; set; }

    [Column("ADWorkingShiftDesc")]
    [StringLength(512)]
    public string AdworkingShiftDesc { get; set; }

    [Column("ADWorkingShiftFromTime", TypeName = "datetime")]
    public DateTime AdworkingShiftFromTime { get; set; }

    [Column("ADWorkingShiftToTime", TypeName = "datetime")]
    public DateTime AdworkingShiftToTime { get; set; }

    [Column("ADWorkingShiftTimeBreak")]
    public int? AdworkingShiftTimeBreak { get; set; }

    [Column("ADWorkingShiftNight")]
    public bool? AdworkingShiftNight { get; set; }

    [Column("ADWorkingShiftDayOffWeek")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdworkingShiftDayOffWeek { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("ADWorkingShiftWorkingTime", TypeName = "decimal(18, 5)")]
    public decimal? AdworkingShiftWorkingTime { get; set; }

    [Column("ADWorkingShiftIsDefault")]
    public bool? AdworkingShiftIsDefault { get; set; }

    [Column("ADWorkingShiftBreakTimeBetweenFrom", TypeName = "datetime")]
    public DateTime? AdworkingShiftBreakTimeBetweenFrom { get; set; }

    [Column("ADWorkingShiftBreakTimeBetweenTo", TypeName = "datetime")]
    public DateTime? AdworkingShiftBreakTimeBetweenTo { get; set; }

    [Column("ADWorkingShiftTimeKeepInFrom", TypeName = "datetime")]
    public DateTime? AdworkingShiftTimeKeepInFrom { get; set; }

    [Column("ADWorkingShiftTimeKeepInTo", TypeName = "datetime")]
    public DateTime? AdworkingShiftTimeKeepInTo { get; set; }

    [Column("ADWorkingShiftTimeKeepOutFrom", TypeName = "datetime")]
    public DateTime? AdworkingShiftTimeKeepOutFrom { get; set; }

    [Column("ADWorkingShiftTimeKeepOutTo", TypeName = "datetime")]
    public DateTime? AdworkingShiftTimeKeepOutTo { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("AdworkingShifts")]
    public virtual HremployeePayrollFormula FkHrtimeSheetParam { get; set; }
}
