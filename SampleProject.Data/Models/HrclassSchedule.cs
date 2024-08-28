using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRClassSchedules")]
public partial class HrclassSchedule
{
    [Key]
    [Column("HRClassScheduleID")]
    public int HrclassScheduleId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRTrainningClassID")]
    public int FkHrtrainningClassId { get; set; }

    [Required]
    [Column("HRDayOfWeek")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrdayOfWeek { get; set; }

    [Column("HRClassScheduleFromTime", TypeName = "datetime")]
    public DateTime HrclassScheduleFromTime { get; set; }

    [Column("HRClassScheduleToTime", TypeName = "datetime")]
    public DateTime HrclassScheduleToTime { get; set; }

    [ForeignKey("FkHrtrainningClassId")]
    [InverseProperty("HrclassSchedules")]
    public virtual HrtrainningClass FkHrtrainningClass { get; set; }

    [InverseProperty("FkHrclassSchedule")]
    public virtual ICollection<HremployeeAbsence> HremployeeAbsences { get; set; } = new List<HremployeeAbsence>();

    [InverseProperty("FkHrclassSchedule")]
    public virtual ICollection<HrtrainningSchedule> HrtrainningSchedules { get; set; } = new List<HrtrainningSchedule>();
}
