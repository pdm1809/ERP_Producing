using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevels")]
public partial class Hrlevel
{
    [Key]
    [Column("HRLevelID")]
    public int HrlevelId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HRLevelNo")]
    [StringLength(50)]
    public string HrlevelNo { get; set; }

    [Required]
    [Column("HRLevelName")]
    [StringLength(100)]
    public string HrlevelName { get; set; }

    [Column("HRLevelDesc")]
    [StringLength(512)]
    public string HrlevelDesc { get; set; }

    [Column("HRLevelQualification")]
    [StringLength(512)]
    public string HrlevelQualification { get; set; }

    [Column("HRLevelSkill")]
    [StringLength(512)]
    public string HrlevelSkill { get; set; }

    [Column("HRLevelWorkExp")]
    [StringLength(512)]
    public string HrlevelWorkExp { get; set; }

    [Column("HRLevelTraining")]
    [StringLength(512)]
    public string HrlevelTraining { get; set; }

    [Column("HRLevelContractSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelContractSlrAmt { get; set; }

    [Column("HRLevelSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelSalaryFactor { get; set; }

    [Column("HRLevelWorkingSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelWorkingSlrAmt { get; set; }

    [Column("HRLevelExtraSalary1", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelExtraSalary1 { get; set; }

    [Column("HRLevelExtraSalary2", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelExtraSalary2 { get; set; }

    [Column("HRLevelExtraSalary3", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelExtraSalary3 { get; set; }

    [Column("HRLevelExtraSalary4", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelExtraSalary4 { get; set; }

    [Column("HRLevelSocialInsPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelSocialInsPaymentPercent { get; set; }

    [Column("HRLevelHealthInsPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelHealthInsPaymentPercent { get; set; }

    [Column("HRLevelOutOfWorkInsPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelOutOfWorkInsPaymentPercent { get; set; }

    [Column("HRLevelTaxPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HrlevelTaxPaymentPercent { get; set; }

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<AcsalaryEntryTypeDetailPart> AcsalaryEntryTypeDetailParts { get; set; } = new List<AcsalaryEntryTypeDetailPart>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<Hrauthorization> Hrauthorizations { get; set; } = new List<Hrauthorization>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeeAdjustSocialInsurance> HremployeeAdjustSocialInsurances { get; set; } = new List<HremployeeAdjustSocialInsurance>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeeComission> HremployeeComissions { get; set; } = new List<HremployeeComission>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeeContract> HremployeeContracts { get; set; } = new List<HremployeeContract>();

    [InverseProperty("FkHrlevelId2Navigation")]
    public virtual ICollection<HremployeeDiscipline> HremployeeDisciplineFkHrlevelId2Navigations { get; set; } = new List<HremployeeDiscipline>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeeDiscipline> HremployeeDisciplineFkHrlevels { get; set; } = new List<HremployeeDiscipline>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeePayRollAudit> HremployeePayRollAudits { get; set; } = new List<HremployeePayRollAudit>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeePayRoll> HremployeePayRolls { get; set; } = new List<HremployeePayRoll>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeeSalaryConfig> HremployeeSalaryConfigs { get; set; } = new List<HremployeeSalaryConfig>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranfers { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeeTransmitItem> HremployeeTransmitItems { get; set; } = new List<HremployeeTransmitItem>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HremployeeTransmit> HremployeeTransmits { get; set; } = new List<HremployeeTransmit>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrlevelDetail> HrlevelDetails { get; set; } = new List<HrlevelDetail>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrlevelDutiesResponsibilitiesOther> HrlevelDutiesResponsibilitiesOthers { get; set; } = new List<HrlevelDutiesResponsibilitiesOther>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrlevelDutiesResponsibilitiess> HrlevelDutiesResponsibilitiesses { get; set; } = new List<HrlevelDutiesResponsibilitiess>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrlevelExternalCompanyRelationship> HrlevelExternalCompanyRelationships { get; set; } = new List<HrlevelExternalCompanyRelationship>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrlevelExternalDepartmentRelationship> HrlevelExternalDepartmentRelationships { get; set; } = new List<HrlevelExternalDepartmentRelationship>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrlevelInternalRelationship> HrlevelInternalRelationships { get; set; } = new List<HrlevelInternalRelationship>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrlevelJurisdiction> HrlevelJurisdictions { get; set; } = new List<HrlevelJurisdiction>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrlevelWorkSummary> HrlevelWorkSummaries { get; set; } = new List<HrlevelWorkSummary>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrotherLeaveDayConfig> HrotherLeaveDayConfigs { get; set; } = new List<HrotherLeaveDayConfig>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrrecruitmentNeedItem> HrrecruitmentNeedItems { get; set; } = new List<HrrecruitmentNeedItem>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrrecruitmentPlanItem> HrrecruitmentPlanItems { get; set; } = new List<HrrecruitmentPlanItem>();

    [InverseProperty("HrrequestEditEmployeeLevel")]
    public virtual ICollection<HrrequestEditEmployee> HrrequestEditEmployees { get; set; } = new List<HrrequestEditEmployee>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkHrlevel")]
    public virtual ICollection<HrtimeKeeperComplete> HrtimeKeeperCompletes { get; set; } = new List<HrtimeKeeperComplete>();
}
