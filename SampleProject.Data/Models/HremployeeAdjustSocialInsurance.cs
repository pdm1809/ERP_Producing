using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeAdjustSocialInsurances")]
public partial class HremployeeAdjustSocialInsurance
{
    [Key]
    [Column("HREmployeeAdjustSocialInsuranceID")]
    public int HremployeeAdjustSocialInsuranceId { get; set; }

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

    [Column("FK_HRAdjustSocialInsuranceID")]
    public int? FkHradjustSocialInsuranceId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeSocialInsuranceType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeSocialInsuranceType { get; set; }

    [Column("HREmployeeSocialInsuranceName")]
    [StringLength(200)]
    public string HremployeeSocialInsuranceName { get; set; }

    [Column("HREmployeeSocialInsuranceNo")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceNo { get; set; }

    [Column("HREmployeeSocialInsuranceBirthday", TypeName = "datetime")]
    public DateTime? HremployeeSocialInsuranceBirthday { get; set; }

    [Column("HREmployeeSocialInsuranceGender")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceGender { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("HREmployeeSocialInsuranceOldSalaryAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSocialInsuranceOldSalaryAmount { get; set; }

    [Column("HREmployeeSocialInsuranceOldAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSocialInsuranceOldAllowance { get; set; }

    [Column("HREmployeeSocialInsuranceOldTNVK")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceOldTnvk { get; set; }

    [Column("HREmployeeSocialInsuranceOldTNNghe")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceOldTnnghe { get; set; }

    [Column("HREmployeeSocialInsuranceOldTNKhac")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceOldTnkhac { get; set; }

    [Column("HREmployeeSocialInsuranceNewSalaryAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSocialInsuranceNewSalaryAmount { get; set; }

    [Column("FK_HRLevelIDNew")]
    public int? FkHrlevelIdnew { get; set; }

    [Column("HREmployeeSocialInsuranceNewAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSocialInsuranceNewAllowance { get; set; }

    [Column("HREmployeeSocialInsuranceNewTNVK")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceNewTnvk { get; set; }

    [Column("HREmployeeSocialInsuranceNewTNNghe")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceNewTnnghe { get; set; }

    [Column("HREmployeeSocialInsuranceNewTNKhac")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceNewTnkhac { get; set; }

    [Column("HREmployeeAdjustSocialInsuranceFromDate", TypeName = "datetime")]
    public DateTime? HremployeeAdjustSocialInsuranceFromDate { get; set; }

    [Column("HREmployeeAdjustSocialInsuranceToDate", TypeName = "datetime")]
    public DateTime? HremployeeAdjustSocialInsuranceToDate { get; set; }

    [Column("HREmployeeSocialInsurancePercent", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSocialInsurancePercent { get; set; }

    [Column("HREmployeeSocialInsuranceReturnCard")]
    public bool? HremployeeSocialInsuranceReturnCard { get; set; }

    [Column("HREmployeeSocialInsuranceRemark")]
    [StringLength(100)]
    public string HremployeeSocialInsuranceRemark { get; set; }

    [Column("HREmployeeSocialInsuranceLedger")]
    public bool? HremployeeSocialInsuranceLedger { get; set; }

    [ForeignKey("FkHradjustSocialInsuranceId")]
    [InverseProperty("HremployeeAdjustSocialInsurances")]
    public virtual HradjustSocialInsurance FkHradjustSocialInsurance { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeeAdjustSocialInsurances")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
