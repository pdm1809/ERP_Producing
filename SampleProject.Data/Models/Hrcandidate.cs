using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRCandidates")]
public partial class Hrcandidate
{
    [Key]
    [Column("HRCandidateID")]
    public int HrcandidateId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("HRCandidateNo")]
    [StringLength(50)]
    public string HrcandidateNo { get; set; }

    [Column("HRCandidateName")]
    [StringLength(150)]
    public string HrcandidateName { get; set; }

    [Column("HRCandidateGenderCombo")]
    [StringLength(50)]
    public string HrcandidateGenderCombo { get; set; }

    [Column("HRCandidateDob", TypeName = "datetime")]
    public DateTime? HrcandidateDob { get; set; }

    [Column("HRCandidateBirthPlace")]
    [StringLength(100)]
    public string HrcandidateBirthPlace { get; set; }

    [Column("HRCandidateDesc")]
    [StringLength(200)]
    public string HrcandidateDesc { get; set; }

    [Column("HRCandidatePicture")]
    public byte[] HrcandidatePicture { get; set; }

    [Column("HRCandidateIDNumber")]
    [StringLength(50)]
    public string HrcandidateIdnumber { get; set; }

    [Column("HRCandidateIDCardPlace")]
    [StringLength(150)]
    public string HrcandidateIdcardPlace { get; set; }

    [Column("HRCandidateIDCardDate", TypeName = "datetime")]
    public DateTime? HrcandidateIdcardDate { get; set; }

    [Column("HRCandidateReligion")]
    [StringLength(50)]
    public string HrcandidateReligion { get; set; }

    [Column("HRCandidateTel1")]
    [StringLength(50)]
    public string HrcandidateTel1 { get; set; }

    [Column("HRCandidateTel2")]
    [StringLength(50)]
    public string HrcandidateTel2 { get; set; }

    [Column("HRCandidateTel3")]
    [StringLength(50)]
    public string HrcandidateTel3 { get; set; }

    [Column("HRCandidateEmail")]
    [StringLength(50)]
    public string HrcandidateEmail { get; set; }

    [Column("HRCandidateFax")]
    [StringLength(50)]
    public string HrcandidateFax { get; set; }

    [Column("HRCandidateContactAddressStreet")]
    [StringLength(200)]
    public string HrcandidateContactAddressStreet { get; set; }

    [Column("HRCandidateContactAddressLine1")]
    [StringLength(200)]
    public string HrcandidateContactAddressLine1 { get; set; }

    [Column("HRCandidateContactAddressLine2")]
    [StringLength(200)]
    public string HrcandidateContactAddressLine2 { get; set; }

    [Column("HRCandidateContactAddressLine3")]
    [StringLength(200)]
    public string HrcandidateContactAddressLine3 { get; set; }

    [Column("HRCandidateContactAddressCity")]
    [StringLength(50)]
    public string HrcandidateContactAddressCity { get; set; }

    [Column("HRCandidateContactAddressPostalCode")]
    [StringLength(50)]
    public string HrcandidateContactAddressPostalCode { get; set; }

    [Column("HRCandidateContactAddressStateProvince")]
    [StringLength(50)]
    public string HrcandidateContactAddressStateProvince { get; set; }

    [Column("HRCandidateContactAddressZipCode")]
    [StringLength(50)]
    public string HrcandidateContactAddressZipCode { get; set; }

    [Column("HRCandidateContactAddressCountry")]
    [StringLength(50)]
    public string HrcandidateContactAddressCountry { get; set; }

    [Column("HRCandidateEmployeeID")]
    [StringLength(50)]
    public string HrcandidateEmployeeId { get; set; }

    [Column("HRCandidateStatusCombo")]
    [StringLength(50)]
    public string HrcandidateStatusCombo { get; set; }

    [Column("HREmployeeMaritalStatusCombo")]
    [StringLength(512)]
    public string HremployeeMaritalStatusCombo { get; set; }

    [Column("FK_GENationalityID")]
    public int? FkGenationalityId { get; set; }

    [Column("FK_GEReligionID")]
    public int? FkGereligionId { get; set; }

    [Column("FK_GEIDCardStateProvinceID")]
    public int? FkGeidcardStateProvinceId { get; set; }

    [Column("FK_GEDistrictID")]
    public int? FkGedistrictId { get; set; }

    [Column("FK_GEStateProvinceID")]
    public int? FkGestateProvinceId { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("HRCandidateYearWorking")]
    public int? HrcandidateYearWorking { get; set; }

    [Column("HRCandidateExperience")]
    public int? HrcandidateExperience { get; set; }

    [Column("HRCandidatePositionApply")]
    [StringLength(200)]
    public string HrcandidatePositionApply { get; set; }

    [Column("HRCandidateWorkingPalce")]
    [StringLength(100)]
    public string HrcandidateWorkingPalce { get; set; }

    [Column("HRCandidateSpecialize")]
    [StringLength(100)]
    public string HrcandidateSpecialize { get; set; }

    [Column("HRCandidateSalaryExpected")]
    [StringLength(200)]
    public string HrcandidateSalaryExpected { get; set; }

    [Column("HRCandidateDateCanWork", TypeName = "datetime")]
    public DateTime? HrcandidateDateCanWork { get; set; }

    [Column("HRCandidateDateStartProbationary", TypeName = "datetime")]
    public DateTime? HrcandidateDateStartProbationary { get; set; }

    [Column("HRCandidateDateEndProbationary", TypeName = "datetime")]
    public DateTime? HrcandidateDateEndProbationary { get; set; }

    [Column("HRCandidateSalaryProbationary", TypeName = "decimal(18, 5)")]
    public decimal? HrcandidateSalaryProbationary { get; set; }

    [Column("HRCandidateOfficalSalary", TypeName = "decimal(18, 5)")]
    public decimal? HrcandidateOfficalSalary { get; set; }

    [Column("HRCandidateDepartmentTo")]
    [StringLength(100)]
    public string HrcandidateDepartmentTo { get; set; }

    [Column("HRCandidateDateChangeDepartment", TypeName = "datetime")]
    public DateTime? HrcandidateDateChangeDepartment { get; set; }

    [Column("HRCandidateDateCreatedCV", TypeName = "datetime")]
    public DateTime? HrcandidateDateCreatedCv { get; set; }

    [Column("HRCandidateSubmitType")]
    [StringLength(50)]
    public string HrcandidateSubmitType { get; set; }

    [Column("HRCandidateRate")]
    [StringLength(50)]
    public string HrcandidateRate { get; set; }

    [Column("HRCandidateAdditionalCV")]
    [StringLength(512)]
    public string HrcandidateAdditionalCv { get; set; }

    [Column("HRCandidateCompanyWorked")]
    public int? HrcandidateCompanyWorked { get; set; }

    [Column("HRCandidateCurrentWorking")]
    [StringLength(200)]
    public string HrcandidateCurrentWorking { get; set; }

    [Column("HRCandidateCurrentPosition")]
    [StringLength(200)]
    public string HrcandidateCurrentPosition { get; set; }

    [Column("HRCandidateCurrentSalary", TypeName = "decimal(18, 5)")]
    public decimal? HrcandidateCurrentSalary { get; set; }

    [Column("HRCandidateWorked")]
    [StringLength(200)]
    public string HrcandidateWorked { get; set; }

    [Column("HRCandidateExternality")]
    [StringLength(100)]
    public string HrcandidateExternality { get; set; }

    [Column("HRCandidateHeight")]
    [StringLength(50)]
    public string HrcandidateHeight { get; set; }

    [Column("HRCandidateWeight")]
    [StringLength(50)]
    public string HrcandidateWeight { get; set; }

    [Column("HRCandidateDress")]
    [StringLength(50)]
    public string HrcandidateDress { get; set; }

    [Column("HRCandidateHair")]
    [StringLength(50)]
    public string HrcandidateHair { get; set; }

    [Column("HRCandidateMakeup")]
    [StringLength(50)]
    public string HrcandidateMakeup { get; set; }

    [Column("HRCandidateTeeth")]
    [StringLength(50)]
    public string HrcandidateTeeth { get; set; }

    [Column("HRCandidateCommunication")]
    [StringLength(50)]
    public string HrcandidateCommunication { get; set; }

    [Column("HRCandidateVoice")]
    [StringLength(50)]
    public string HrcandidateVoice { get; set; }

    [Column("HRCandidateEducation")]
    [StringLength(50)]
    public string HrcandidateEducation { get; set; }

    [Column("HRCandidateIQ")]
    [StringLength(50)]
    public string HrcandidateIq { get; set; }

    [Column("HRCandidateSkill")]
    [StringLength(512)]
    public string HrcandidateSkill { get; set; }

    [Column("HRCandidateGraduateStudent")]
    public bool? HrcandidateGraduateStudent { get; set; }

    [Column("HRCandidateOriginPlace")]
    [StringLength(200)]
    public string HrcandidateOriginPlace { get; set; }

    [Column("HRCandidateHCTime")]
    public bool? HrcandidateHctime { get; set; }

    [Column("HRCandidateOTTime")]
    public bool? HrcandidateOttime { get; set; }

    [Column("HRCandidateComputerSkill")]
    [StringLength(200)]
    public string HrcandidateComputerSkill { get; set; }

    [Column("HRCandidateLanguageSkill")]
    [StringLength(200)]
    public string HrcandidateLanguageSkill { get; set; }

    [Column("HRCandidateInterviewDate", TypeName = "datetime")]
    public DateTime? HrcandidateInterviewDate { get; set; }

    [Column("HRCandidatePriority")]
    [StringLength(200)]
    public string HrcandidatePriority { get; set; }

    [Column("HRCandidateContactType")]
    [StringLength(50)]
    public string HrcandidateContactType { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("Hrcandidates")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGedistrictId")]
    [InverseProperty("Hrcandidates")]
    public virtual Gedistrict FkGedistrict { get; set; }

    [ForeignKey("FkGeidcardStateProvinceId")]
    [InverseProperty("HrcandidateFkGeidcardStateProvinces")]
    public virtual GestateProvince FkGeidcardStateProvince { get; set; }

    [ForeignKey("FkGenationalityId")]
    [InverseProperty("Hrcandidates")]
    public virtual Genationality FkGenationality { get; set; }

    [ForeignKey("FkGereligionId")]
    [InverseProperty("Hrcandidates")]
    public virtual Gereligion FkGereligion { get; set; }

    [ForeignKey("FkGestateProvinceId")]
    [InverseProperty("HrcandidateFkGestateProvinces")]
    public virtual GestateProvince FkGestateProvince { get; set; }

    [InverseProperty("FkHrcandidate")]
    public virtual ICollection<HrcandidateCertificate> HrcandidateCertificates { get; set; } = new List<HrcandidateCertificate>();

    [InverseProperty("FkHrcandidate")]
    public virtual ICollection<HrcandidateTemplate> HrcandidateTemplates { get; set; } = new List<HrcandidateTemplate>();
}
