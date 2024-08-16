using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeArrearSocialInsurances")]
public partial class HremployeeArrearSocialInsurance
{
    [Key]
    [Column("HREmployeeArrearSocialInsuranceID")]
    public int HremployeeArrearSocialInsuranceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_HRAdjustSocialInsuranceID")]
    public int? FkHradjustSocialInsuranceId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeArrearSocialInsuranceNo")]
    [StringLength(50)]
    public string HremployeeArrearSocialInsuranceNo { get; set; }

    [Column("HREmployeeArrearSocialInsuranceSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceSalary { get; set; }

    [Column("HREmployeeArrearSocialInsuranceFromDate", TypeName = "datetime")]
    public DateTime? HremployeeArrearSocialInsuranceFromDate { get; set; }

    [Column("HREmployeeArrearSocialInsuranceToDate", TypeName = "datetime")]
    public DateTime? HremployeeArrearSocialInsuranceToDate { get; set; }

    [Column("HREmployeeArrearSocialInsuranceTotalMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceTotalMonth { get; set; }

    [Column("HREmployeeArrearSocialInsuranceBHXHRate", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceBhxhrate { get; set; }

    [Column("HREmployeeArrearSocialInsuranceBHTNRate", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceBhtnrate { get; set; }

    [Column("HREmployeeArrearSocialInsuranceBHYTRate", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceBhytrate { get; set; }

    [Column("HREmployeeArrearSocialInsuranceNi", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceNi { get; set; }

    [Column("HREmployeeArrearSocialInsuranceBHXHInterest", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceBhxhinterest { get; set; }

    [Column("HREmployeeArrearSocialInsuranceBHTNInterest", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceBhtninterest { get; set; }

    [Column("HREmployeeArrearSocialInsuranceBHYTInterest", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceBhytinterest { get; set; }

    [Column("HREmployeeArrearSocialInsuranceInterestTotal", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeArrearSocialInsuranceInterestTotal { get; set; }

    [Column("HREmployeeArrearSocialInsuranceDesc")]
    [StringLength(1000)]
    public string HremployeeArrearSocialInsuranceDesc { get; set; }

    [ForeignKey("FkHradjustSocialInsuranceId")]
    [InverseProperty("HremployeeArrearSocialInsurances")]
    public virtual HradjustSocialInsurance FkHradjustSocialInsurance { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeArrearSocialInsurances")]
    public virtual Hremployee FkHremployee { get; set; }
}
