using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePayrollDetails")]
public partial class HremployeePayrollDetail
{
    [Key]
    [Column("HREmployeePayrollDetailID")]
    public int HremployeePayrollDetailId { get; set; }

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

    [Column("FK_HREmployeePayrollID")]
    public int? FkHremployeePayrollId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("HREmployeeTimeSheetOTDetailName")]
    [StringLength(200)]
    public string HremployeeTimeSheetOtdetailName { get; set; }

    [Column("HREmployeeTimeSheetOTDetailFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetOtdetailFactor { get; set; }

    [Column("HREmployeePayrollHours", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollHours { get; set; }

    [Column("HREmployeePayrollBasicSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollBasicSalary { get; set; }

    [Column("HREmployeePayrollSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollSalaryFactor { get; set; }

    [ForeignKey("FkHremployeePayrollId")]
    [InverseProperty("HremployeePayrollDetails")]
    public virtual HremployeePayRoll FkHremployeePayroll { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HremployeePayrollDetails")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
