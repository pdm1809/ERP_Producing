using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePayrollFormulas")]
public partial class HremployeePayrollFormula
{
    [Key]
    [Column("HREmployeePayrollFormulaID")]
    public int HremployeePayrollFormulaId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRTimesheetGroupID")]
    public int? FkHrtimesheetGroupId { get; set; }

    [Column("HREmployeePayrollFormulaNo")]
    [StringLength(50)]
    public string HremployeePayrollFormulaNo { get; set; }

    [Column("HREmployeePayrollFormulaStatus")]
    [StringLength(100)]
    public string HremployeePayrollFormulaStatus { get; set; }

    [Column("HREmployeePayrollFormulaName")]
    [StringLength(512)]
    public string HremployeePayrollFormulaName { get; set; }

    [Column("HREmployeePayrollFormulaDesc")]
    [StringLength(512)]
    public string HremployeePayrollFormulaDesc { get; set; }

    [Column("HREmployeePayrollFormulaFromDate", TypeName = "datetime")]
    public DateTime? HremployeePayrollFormulaFromDate { get; set; }

    [Column("HREmployeePayrollFormulaToDate", TypeName = "datetime")]
    public DateTime? HremployeePayrollFormulaToDate { get; set; }

    [Column("HREmployeePayrollFormulaSalaryType")]
    [StringLength(512)]
    public string HremployeePayrollFormulaSalaryType { get; set; }

    [Required]
    [Column("HREmployeePayrollFormulaSalaryTypeOption")]
    [StringLength(512)]
    public string HremployeePayrollFormulaSalaryTypeOption { get; set; }

    [Column("HREmployeePayrollFormulaIsOTCheck")]
    public bool? HremployeePayrollFormulaIsOtcheck { get; set; }

    [Column("HREmployeePayrollFormulaMaxPercentDeposit", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaMaxPercentDeposit { get; set; }

    [Column("HREmployeePayrollFormulaDepositFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaDepositFactor { get; set; }

    [Column("HREmployeePayrollFormulaDepositPercentValue", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaDepositPercentValue { get; set; }

    [Column("HREmployeePayrollFormulaBalanceDayNumber", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaBalanceDayNumber { get; set; }

    [Column("HREmployeePayrollFormulaBalanceDayNumberLevel2", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaBalanceDayNumberLevel2 { get; set; }

    [Column("HREmployeePayrollFormulaBalancePercentValueLevel2", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaBalancePercentValueLevel2 { get; set; }

    [Column("HREmployeePayrollFormulaBalanceFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaBalanceFactor { get; set; }

    [Column("HREmployeePayrollFormulaBalancePercentValue", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaBalancePercentValue { get; set; }

    [Column("HREmployeePayrollFormulaTotalAmountEmployeePercentValue", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaTotalAmountEmployeePercentValue { get; set; }

    [Column("HREmployeePayrollFormulaTotalAmountBranchPercentValue", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaTotalAmountBranchPercentValue { get; set; }

    [Column("HREmployeePayrollFormulaTotalAmountCompanyPercentValue", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaTotalAmountCompanyPercentValue { get; set; }

    [Column("HREmployeePayrollFormulaBanVai", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaBanVai { get; set; }

    [Column("HREmployeePayrollFormulaBanMan", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaBanMan { get; set; }

    [Column("HREmployeePayrollFormulaCatMan", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaCatMan { get; set; }

    [Column("HREmployeePayrollFormulaXNK", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaXnk { get; set; }

    [Column("HREmployeePayrollFormulaWorkingDiff", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollFormulaWorkingDiff { get; set; }

    [Column("HREmployeePayrollFormulaCalculation")]
    [StringLength(100)]
    public string HremployeePayrollFormulaCalculation { get; set; }

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<AdgroupTimeSheetPermission> AdgroupTimeSheetPermissions { get; set; } = new List<AdgroupTimeSheetPermission>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<AdworkingShift> AdworkingShifts { get; set; } = new List<AdworkingShift>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<HrallowanceConfig> HrallowanceConfigs { get; set; } = new List<HrallowanceConfig>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<HrbreakTime> HrbreakTimes { get; set; } = new List<HrbreakTime>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<HremployeeComission> HremployeeComissions { get; set; } = new List<HremployeeComission>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<HremployeeCommissionBranch> HremployeeCommissionBranches { get; set; } = new List<HremployeeCommissionBranch>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<HremployeePayrollFormulaItem> HremployeePayrollFormulaItems { get; set; } = new List<HremployeePayrollFormulaItem>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<Hrotfactor> Hrotfactors { get; set; } = new List<Hrotfactor>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<HrtimesheetConfig> HrtimesheetConfigs { get; set; } = new List<HrtimesheetConfig>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<HrtimesheetEmployeeLate> HrtimesheetEmployeeLates { get; set; } = new List<HrtimesheetEmployeeLate>();

    [InverseProperty("FkHremployeePayrollFormula")]
    public virtual ICollection<HrworkingShift> HrworkingShiftFkHremployeePayrollFormulas { get; set; } = new List<HrworkingShift>();

    [InverseProperty("FkHrtimeSheetParam")]
    public virtual ICollection<HrworkingShift> HrworkingShiftFkHrtimeSheetParams { get; set; } = new List<HrworkingShift>();
}
