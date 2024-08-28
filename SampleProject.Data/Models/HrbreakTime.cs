using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRBreakTimes")]
public partial class HrbreakTime
{
    [Key]
    [Column("HRBreakTimeID")]
    public int HrbreakTimeId { get; set; }

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
    [Column("HRBreakTimeName")]
    [StringLength(50)]
    public string HrbreakTimeName { get; set; }

    [Column("HRBreakTimeFromTime", TypeName = "datetime")]
    public DateTime HrbreakTimeFromTime { get; set; }

    [Column("HRBreakTimeToTime", TypeName = "datetime")]
    public DateTime HrbreakTimeToTime { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int FkHremployeePayrollFormulaId { get; set; }

    [Column("HRBreakTimeMaxOutTime")]
    public int? HrbreakTimeMaxOutTime { get; set; }

    [Column("HRBreakTimeMinRegisterOverTime")]
    public int? HrbreakTimeMinRegisterOverTime { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("HrbreakTimes")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }
}
