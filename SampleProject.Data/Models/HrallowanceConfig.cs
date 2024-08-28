using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAllowanceConfigs")]
public partial class HrallowanceConfig
{
    [Key]
    [Column("HRAllowanceConfigID")]
    public int HrallowanceConfigId { get; set; }

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

    [Column("HRAllowanceConfigNo")]
    [StringLength(50)]
    public string HrallowanceConfigNo { get; set; }

    [Required]
    [Column("HRAllowanceConfigName")]
    [StringLength(100)]
    public string HrallowanceConfigName { get; set; }

    [Column("HRAllowanceConfigFromDate")]
    public int? HrallowanceConfigFromDate { get; set; }

    [Column("HRAllowanceConfigToDate")]
    public int? HrallowanceConfigToDate { get; set; }

    [Column("HRAllowanceConfigPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceConfigPercent { get; set; }

    [Column("HRAllowanceConfigAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceConfigAmount { get; set; }

    [Column("HRAllowanceConfigIsTimeKeeping")]
    public bool? HrallowanceConfigIsTimeKeeping { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int? FkHremployeePayrollFormulaId { get; set; }

    [Column("HRAllowanceConfigGroup")]
    [StringLength(50)]
    public string HrallowanceConfigGroup { get; set; }

    [Column("HRAllowanceConfigFromTime", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceConfigFromTime { get; set; }

    [Column("HRAllowanceConfigToTime", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceConfigToTime { get; set; }

    [Column("HRAllowanceConfigDeductionAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceConfigDeductionAmount { get; set; }

    [Column("HRAllowanceConfigPermiYearAndHoliday")]
    public bool? HrallowanceConfigPermiYearAndHoliday { get; set; }

    [Column("HRAllowanceConfigContdifferenceWithReality", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceConfigContdifferenceWithReality { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("HrallowanceConfigs")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }
}
