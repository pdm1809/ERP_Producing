using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTrainningCourses")]
[Microsoft.EntityFrameworkCore.Index("HrtrainningCourseNo", "HrtrainningCourseType", Name = "Idx_HRTrainningCourses")]
public partial class HrtrainningCourse
{
    [Key]
    [Column("HRTrainningCourseID")]
    public int HrtrainningCourseId { get; set; }

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

    [Required]
    [Column("HRTrainningCourseNo")]
    [StringLength(50)]
    public string HrtrainningCourseNo { get; set; }

    [Required]
    [Column("HRTrainningCourseName")]
    [StringLength(100)]
    public string HrtrainningCourseName { get; set; }

    [Column("HRTrainningCourseDesc")]
    [StringLength(512)]
    public string HrtrainningCourseDesc { get; set; }

    [Column("HRTrainningCourseType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtrainningCourseType { get; set; }

    [Required]
    [Column("HRTrainningCourseStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtrainningCourseStatus { get; set; }

    [Column("HRTranningCourseStartDate", TypeName = "datetime")]
    public DateTime? HrtranningCourseStartDate { get; set; }

    [Column("HRTrainningCourseEndDate", TypeName = "datetime")]
    public DateTime? HrtrainningCourseEndDate { get; set; }

    [InverseProperty("FkHrtrainningCourse")]
    public virtual ICollection<HremployeeAbsence> HremployeeAbsences { get; set; } = new List<HremployeeAbsence>();

    [InverseProperty("FkHrtrainningCourse")]
    public virtual ICollection<HrtrainningClass> HrtrainningClasses { get; set; } = new List<HrtrainningClass>();

    [InverseProperty("FkHrtrainningCourse")]
    public virtual ICollection<HrtrainningEmployee> HrtrainningEmployees { get; set; } = new List<HrtrainningEmployee>();
}
