using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTrainningSchedules")]
[Microsoft.EntityFrameworkCore.Index("FkHremployeeId", Name = "Idx_HRTrainningSchedules")]
public partial class HrtrainningSchedule
{
    [Key]
    [Column("HRTrainningScheduleID")]
    public int HrtrainningScheduleId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRTrainningClassID")]
    public int FkHrtrainningClassId { get; set; }

    [Column("FK_HRClassScheduleID")]
    public int FkHrclassScheduleId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [ForeignKey("FkHrclassScheduleId")]
    [InverseProperty("HrtrainningSchedules")]
    public virtual HrclassSchedule FkHrclassSchedule { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrtrainningSchedules")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrtrainningClassId")]
    [InverseProperty("HrtrainningSchedules")]
    public virtual HrtrainningClass FkHrtrainningClass { get; set; }
}
