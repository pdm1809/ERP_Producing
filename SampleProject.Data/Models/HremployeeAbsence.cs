using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeAbsences")]
[Microsoft.EntityFrameworkCore.Index("HremployeeAbsenceDate", Name = "Idx_HREmployeeAbsences")]
public partial class HremployeeAbsence
{
    [Key]
    [Column("HREmployeeAbsenceID")]
    public int HremployeeAbsenceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRTrainningCourseID")]
    public int FkHrtrainningCourseId { get; set; }

    [Column("FK_HRTrainningClassID")]
    public int FkHrtrainningClassId { get; set; }

    [Column("FK_HRClassScheduleID")]
    public int FkHrclassScheduleId { get; set; }

    [Column("FK_HREmployeeTeacherID")]
    public int FkHremployeeTeacherId { get; set; }

    [Column("FK_HREmployeeStudentID")]
    public int FkHremployeeStudentId { get; set; }

    [Column("HREmployeeAbsenceDate", TypeName = "datetime")]
    public DateTime HremployeeAbsenceDate { get; set; }

    public bool IsPresent { get; set; }

    [ForeignKey("FkHrclassScheduleId")]
    [InverseProperty("HremployeeAbsences")]
    public virtual HrclassSchedule FkHrclassSchedule { get; set; }

    [ForeignKey("FkHremployeeStudentId")]
    [InverseProperty("HremployeeAbsenceFkHremployeeStudents")]
    public virtual Hremployee FkHremployeeStudent { get; set; }

    [ForeignKey("FkHremployeeTeacherId")]
    [InverseProperty("HremployeeAbsenceFkHremployeeTeachers")]
    public virtual Hremployee FkHremployeeTeacher { get; set; }

    [ForeignKey("FkHrtrainningClassId")]
    [InverseProperty("HremployeeAbsences")]
    public virtual HrtrainningClass FkHrtrainningClass { get; set; }

    [ForeignKey("FkHrtrainningCourseId")]
    [InverseProperty("HremployeeAbsences")]
    public virtual HrtrainningCourse FkHrtrainningCourse { get; set; }
}
