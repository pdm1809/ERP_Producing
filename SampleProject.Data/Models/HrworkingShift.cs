using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRWorkingShifts")]
public partial class HrworkingShift
{
    [Key]
    [Column("HRWorkingShiftID")]
    public int HrworkingShiftId { get; set; }

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
    [Column("HRWorkingShiftNo")]
    [StringLength(50)]
    public string HrworkingShiftNo { get; set; }

    [Required]
    [Column("HRWorkingShiftName")]
    [StringLength(50)]
    public string HrworkingShiftName { get; set; }

    [Column("HRWorkingShiftDesc")]
    [StringLength(512)]
    public string HrworkingShiftDesc { get; set; }

    [Column("HRWorkingShiftFromTime", TypeName = "datetime")]
    public DateTime HrworkingShiftFromTime { get; set; }

    [Column("HRWorkingShiftToTime", TypeName = "datetime")]
    public DateTime HrworkingShiftToTime { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int? FkHremployeePayrollFormulaId { get; set; }

    [Column("HRWorkingShiftTimeBreak")]
    public int? HrworkingShiftTimeBreak { get; set; }

    [Column("HRWorkingShiftNight")]
    public bool? HrworkingShiftNight { get; set; }

    [Column("HRWorkingShiftDayOffWeek")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrworkingShiftDayOffWeek { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("HRWorkingShiftWorkingTime", TypeName = "decimal(18, 5)")]
    public decimal? HrworkingShiftWorkingTime { get; set; }

    [Column("HRWorkingShiftIsDefault")]
    public bool? HrworkingShiftIsDefault { get; set; }

    [Column("FK_HRWorkingShiftID")]
    public int? FkHrworkingShiftId { get; set; }

    [Column("HRWorkingShiftBreakTimeBetweenShiftTo", TypeName = "datetime")]
    public DateTime? HrworkingShiftBreakTimeBetweenShiftTo { get; set; }

    [Column("HRWorkingShiftBreakTimeBetweenShiftFrom", TypeName = "datetime")]
    public DateTime? HrworkingShiftBreakTimeBetweenShiftFrom { get; set; }

    [Column("HRWorkingShiftFrameTimeFrom", TypeName = "datetime")]
    public DateTime? HrworkingShiftFrameTimeFrom { get; set; }

    [Column("HRWorkingShiftFrameTimeTo", TypeName = "datetime")]
    public DateTime? HrworkingShiftFrameTimeTo { get; set; }

    [Column("HRWorkingShiftTimeSession1")]
    public int? HrworkingShiftTimeSession1 { get; set; }

    [Column("HRWorkingShiftTimeSession2")]
    public int? HrworkingShiftTimeSession2 { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("HrworkingShiftFkHremployeePayrollFormulas")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HrworkingShiftFkHrtimeSheetParams")]
    public virtual HremployeePayrollFormula FkHrtimeSheetParam { get; set; }

    [ForeignKey("FkHrworkingShiftId")]
    [InverseProperty("InverseFkHrworkingShift")]
    public virtual HrworkingShift FkHrworkingShift { get; set; }

    [InverseProperty("FkHrworkingShift")]
    public virtual ICollection<HrarrangementShiftEntry> HrarrangementShiftEntries { get; set; } = new List<HrarrangementShiftEntry>();

    [InverseProperty("FkHrworkingShift")]
    public virtual ICollection<HremployeeSchedule> HremployeeSchedules { get; set; } = new List<HremployeeSchedule>();

    [InverseProperty("FkHrworkingShift")]
    public virtual ICollection<HremployeeWorkingShift> HremployeeWorkingShifts { get; set; } = new List<HremployeeWorkingShift>();

    [InverseProperty("FkHrworkingShift")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkHrworkingShift")]
    public virtual ICollection<HrworkingShift> InverseFkHrworkingShift { get; set; } = new List<HrworkingShift>();
}
