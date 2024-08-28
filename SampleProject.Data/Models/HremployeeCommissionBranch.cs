using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeCommissionBranchs")]
public partial class HremployeeCommissionBranch
{
    [Key]
    [Column("HREmployeeCommissionBranchID")]
    public int HremployeeCommissionBranchId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int FkHremployeePayrollFormulaId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeCommissionBranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("HremployeeCommissionBranches")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }
}
