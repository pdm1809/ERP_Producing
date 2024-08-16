using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePayRollAuditDetails")]
public partial class HremployeePayRollAuditDetail
{
    [Key]
    [Column("HREmployeePayRollAuditDetailID")]
    public int HremployeePayRollAuditDetailId { get; set; }

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

    [Column("FK_HREmployeePayRollAuditID")]
    public int? FkHremployeePayRollAuditId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("HREmployeeTimeSheetAuditOTDetailName")]
    [StringLength(200)]
    public string HremployeeTimeSheetAuditOtdetailName { get; set; }

    [Column("HREmployeeTimeSheetAuditOTDetailFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTimeSheetAuditOtdetailFactor { get; set; }

    [Column("HREmployeePayRollAuditHours", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditHours { get; set; }

    [Column("HREmployeePayRollAuditBasicSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditBasicSalary { get; set; }

    [Column("HREmployeePayRollAuditSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditSalaryFactor { get; set; }

    [ForeignKey("FkHremployeePayRollAuditId")]
    [InverseProperty("HremployeePayRollAuditDetails")]
    public virtual HremployeePayRollAudit FkHremployeePayRollAudit { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("HremployeePayRollAuditDetails")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }
}
