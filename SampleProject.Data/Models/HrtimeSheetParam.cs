using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeSheetParams")]
public partial class HrtimeSheetParam
{
    [Key]
    [Column("HRTimeSheetParamID")]
    public int HrtimeSheetParamId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HRTimeSheetParamNo")]
    [StringLength(50)]
    public string HrtimeSheetParamNo { get; set; }

    [Required]
    [Column("HRTimeSheetParamName")]
    [StringLength(50)]
    public string HrtimeSheetParamName { get; set; }

    [Column("HRTimeSheetParamDesc")]
    [StringLength(512)]
    public string HrtimeSheetParamDesc { get; set; }

    [Required]
    [Column("HRTimeSheetParamType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtimeSheetParamType { get; set; }

    [Column("HRTimeSheetParamValue1", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetParamValue1 { get; set; }

    [Column("HRTimeSheetParamValue2", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetParamValue2 { get; set; }

    public bool? IsDefault { get; set; }

    [Column("IsOTCalculated")]
    public bool? IsOtcalculated { get; set; }

    [Column("HRTimeSheetParamNight")]
    public bool? HrtimeSheetParamNight { get; set; }

    public bool IsAllowedLeave { get; set; }

    public bool? IsPause { get; set; }

    [Column("HRTimeSheetParamBonusTimeConfig", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetParamBonusTimeConfig { get; set; }

    [Column("FK_HRWorkingShiftID")]
    [StringLength(50)]
    [Unicode(false)]
    public string FkHrworkingShiftId { get; set; }

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HrapproveLeaveDay> HrapproveLeaveDays { get; set; } = new List<HrapproveLeaveDay>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HremployeePause> HremployeePauses { get; set; } = new List<HremployeePause>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HremployeePayRollAuditDetail> HremployeePayRollAuditDetails { get; set; } = new List<HremployeePayRollAuditDetail>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HremployeePayrollDetail> HremployeePayrollDetails { get; set; } = new List<HremployeePayrollDetail>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HremployeeTimeSheetAuditOtdetail> HremployeeTimeSheetAuditOtdetails { get; set; } = new List<HremployeeTimeSheetAuditOtdetail>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HremployeeTimeSheetOtdetail> HremployeeTimeSheetOtdetails { get; set; } = new List<HremployeeTimeSheetOtdetail>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HrleaveApplication> HrleaveApplications { get; set; } = new List<HrleaveApplication>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HrleaveDay> HrleaveDays { get; set; } = new List<HrleaveDay>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HrrequestLeaveDay> HrrequestLeaveDays { get; set; } = new List<HrrequestLeaveDay>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HrtimeSheetAuditEntry> HrtimeSheetAuditEntries { get; set; } = new List<HrtimeSheetAuditEntry>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HrtimeSheetEntry> HrtimeSheetEntries { get; set; } = new List<HrtimeSheetEntry>();
}
