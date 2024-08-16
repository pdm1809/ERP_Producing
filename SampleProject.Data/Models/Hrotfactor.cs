using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HROTFactors")]
public partial class Hrotfactor
{
    [Key]
    [Column("HROTFactorID")]
    public int HrotfactorId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HROTFactorType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrotfactorType { get; set; }

    [Column("HROTFactorFromTime", TypeName = "datetime")]
    public DateTime? HrotfactorFromTime { get; set; }

    [Column("HROTFactorToTime", TypeName = "datetime")]
    public DateTime? HrotfactorToTime { get; set; }

    [Column("HROTFactorValue", TypeName = "decimal(18, 5)")]
    public decimal? HrotfactorValue { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int? FkHremployeePayrollFormulaId { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("Hrotfactors")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }
}
