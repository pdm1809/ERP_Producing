using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRSchedules")]
public partial class Hrschedule
{
    [Key]
    [Column("HRScheduleID")]
    public int HrscheduleId { get; set; }

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
    [Column("HRScheduleNo")]
    [StringLength(50)]
    public string HrscheduleNo { get; set; }

    [Required]
    [Column("HRScheduleName")]
    [StringLength(50)]
    public string HrscheduleName { get; set; }

    [Column("HRScheduleDesc")]
    [StringLength(512)]
    public string HrscheduleDesc { get; set; }

    [Column("HRScheduleDate", TypeName = "datetime")]
    public DateTime HrscheduleDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HRScheduleFromDate", TypeName = "datetime")]
    public DateTime? HrscheduleFromDate { get; set; }

    [Column("HRScheduleToDate", TypeName = "datetime")]
    public DateTime? HrscheduleToDate { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Hrschedules")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Hrschedules")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrschedule")]
    public virtual ICollection<HremployeeSchedule> HremployeeSchedules { get; set; } = new List<HremployeeSchedule>();
}
