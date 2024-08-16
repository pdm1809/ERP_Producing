using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTrainningEmployees")]
[Microsoft.EntityFrameworkCore.Index("FkHremployeeId", "HrtrainningEmployeeType", Name = "Idx_HRTrainningEmployees")]
public partial class HrtrainningEmployee
{
    [Key]
    [Column("HRTrainningEmployeeID")]
    public int HrtrainningEmployeeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRTrainningCourseID")]
    public int FkHrtrainningCourseId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRTrainningClassID")]
    public int? FkHrtrainningClassId { get; set; }

    [Required]
    [Column("HRTrainningEmployeeType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrtrainningEmployeeType { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrtrainningEmployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrtrainningClassId")]
    [InverseProperty("HrtrainningEmployees")]
    public virtual HrtrainningClass FkHrtrainningClass { get; set; }

    [ForeignKey("FkHrtrainningCourseId")]
    [InverseProperty("HrtrainningEmployees")]
    public virtual HrtrainningCourse FkHrtrainningCourse { get; set; }
}
