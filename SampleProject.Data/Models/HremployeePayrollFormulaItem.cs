using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePayrollFormulaItems")]
public partial class HremployeePayrollFormulaItem
{
    [Key]
    [Column("HREmployeePayrollFormulaItemID")]
    public int HremployeePayrollFormulaItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int FkHremployeePayrollFormulaId { get; set; }

    [Column("FK_HRTimesheetGroupID")]
    public int FkHrtimesheetGroupId { get; set; }

    [Column("HREmployeePayrollFormulaSalaryType")]
    [StringLength(512)]
    public string HremployeePayrollFormulaSalaryType { get; set; }

    [Column("HREmployeePayrollFormulaSalaryTypeOption")]
    [StringLength(20)]
    public string HremployeePayrollFormulaSalaryTypeOption { get; set; }

    [Column("HREmployeePayrollFormulaSalaryRemark")]
    [StringLength(512)]
    public string HremployeePayrollFormulaSalaryRemark { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("HremployeePayrollFormulaItems")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }
}
