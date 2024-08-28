using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTrainningClass")]
public partial class HrtrainningClass
{
    [Key]
    [Column("HRTrainningClassID")]
    public int HrtrainningClassId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRTrainningCourseID")]
    public int FkHrtrainningCourseId { get; set; }

    [Required]
    [Column("HRTrainningClassNo")]
    [StringLength(50)]
    public string HrtrainningClassNo { get; set; }

    [Required]
    [Column("HRTrainningClassName")]
    [StringLength(100)]
    public string HrtrainningClassName { get; set; }

    [Column("HRTrainningClassDesc")]
    [StringLength(512)]
    public string HrtrainningClassDesc { get; set; }

    [Column("HRTrainningClassMaxQty")]
    public int? HrtrainningClassMaxQty { get; set; }

    [Column("HRTrainningClassRegisteredQty")]
    public int? HrtrainningClassRegisteredQty { get; set; }

    [ForeignKey("FkHrtrainningCourseId")]
    [InverseProperty("HrtrainningClasses")]
    public virtual HrtrainningCourse FkHrtrainningCourse { get; set; }

    [InverseProperty("FkHrtrainningClass")]
    public virtual ICollection<HrclassSchedule> HrclassSchedules { get; set; } = new List<HrclassSchedule>();

    [InverseProperty("FkHrtrainningClass")]
    public virtual ICollection<HremployeeAbsence> HremployeeAbsences { get; set; } = new List<HremployeeAbsence>();

    [InverseProperty("FkHrtrainningClass")]
    public virtual ICollection<HrtrainningEmployee> HrtrainningEmployees { get; set; } = new List<HrtrainningEmployee>();

    [InverseProperty("FkHrtrainningClass")]
    public virtual ICollection<HrtrainningSchedule> HrtrainningSchedules { get; set; } = new List<HrtrainningSchedule>();
}
