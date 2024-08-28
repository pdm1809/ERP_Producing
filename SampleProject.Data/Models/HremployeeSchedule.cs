using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeSchedules")]
public partial class HremployeeSchedule
{
    [Key]
    [Column("HREmployeeScheduleID")]
    public int HremployeeScheduleId { get; set; }

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

    [Column("HREmployeeScheduleWorkDate", TypeName = "datetime")]
    public DateTime HremployeeScheduleWorkDate { get; set; }

    [Column("FK_HRScheduleID")]
    public int FkHrscheduleId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRWorkingShiftID")]
    public int FkHrworkingShiftId { get; set; }

    [Column("HREmployeeScheduleFromTime", TypeName = "datetime")]
    public DateTime? HremployeeScheduleFromTime { get; set; }

    [Column("HREmployeeScheduleToTime", TypeName = "datetime")]
    public DateTime? HremployeeScheduleToTime { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeSchedules")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrscheduleId")]
    [InverseProperty("HremployeeSchedules")]
    public virtual Hrschedule FkHrschedule { get; set; }

    [ForeignKey("FkHrworkingShiftId")]
    [InverseProperty("HremployeeSchedules")]
    public virtual HrworkingShift FkHrworkingShift { get; set; }
}
