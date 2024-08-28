using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeAllowances")]
public partial class HremployeeAllowance
{
    [Key]
    [Column("HREmployeeAllowanceID")]
    public int HremployeeAllowanceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRAllowanceID")]
    public int FkHrallowanceId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("HREmployeeAllowanceValue")]
    [StringLength(512)]
    public string HremployeeAllowanceValue { get; set; }

    [Column("HREmployeeAllowanceValueAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceValueAmount { get; set; }

    [Column("HREmployeeAllowanceAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceAmount { get; set; }

    [Column("HREmployeeAllowanceQualityCriteria", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceQualityCriteria { get; set; }

    [Column("HREmployeeAllowanceProductivityCriteria", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceProductivityCriteria { get; set; }

    [Column("HREmployeeAllowanceManageCriteria", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceManageCriteria { get; set; }

    [Column("HREmployeeAllowanceConfiguredQualityAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceConfiguredQualityAmount { get; set; }

    [Column("HREmployeeAllowanceConfiguredProductivityAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceConfiguredProductivityAmount { get; set; }

    [Column("HREmployeeAllowanceConfiguredManageAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceConfiguredManageAmount { get; set; }

    [Column("HREmployeeAllowanceExactlyAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceExactlyAmount { get; set; }

    [Column("HREmployeeAllowanceExactlyCriteria", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceExactlyCriteria { get; set; }

    [ForeignKey("FkHrallowanceId")]
    [InverseProperty("HremployeeAllowances")]
    public virtual Hrallowance FkHrallowance { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeAllowances")]
    public virtual Hremployee FkHremployee { get; set; }
}
