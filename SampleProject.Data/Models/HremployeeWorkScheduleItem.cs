using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeWorkScheduleItems")]
public partial class HremployeeWorkScheduleItem
{
    [Key]
    [Column("HREmployeeWorkScheduleItemID")]
    public int HremployeeWorkScheduleItemId { get; set; }

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

    [Column("FK_HREmployeeWorkScheduleID")]
    public int? FkHremployeeWorkScheduleId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeWorkScheduleItemDesc")]
    [StringLength(512)]
    public string HremployeeWorkScheduleItemDesc { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeWorkScheduleItemFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeWorkScheduleId")]
    [InverseProperty("HremployeeWorkScheduleItemFkHremployeeWorkSchedules")]
    public virtual Hremployee FkHremployeeWorkSchedule { get; set; }
}
