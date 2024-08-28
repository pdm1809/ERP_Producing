using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeSocialInsuranceChanges")]
public partial class HremployeeSocialInsuranceChange
{
    [Key]
    [Column("HREmployeeSocialInsuranceChangeID")]
    public int HremployeeSocialInsuranceChangeId { get; set; }

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

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRAdjustSocialInsuranceID")]
    public int? FkHradjustSocialInsuranceId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeSocialInsuranceChangeNo")]
    [StringLength(50)]
    public string HremployeeSocialInsuranceChangeNo { get; set; }

    [Column("HREmployeeSocialInsuranceChangeContent")]
    [StringLength(500)]
    public string HremployeeSocialInsuranceChangeContent { get; set; }

    [Column("HREmployeeSocialInsuranceChangeOld")]
    [StringLength(500)]
    public string HremployeeSocialInsuranceChangeOld { get; set; }

    [Column("HREmployeeSocialInsuranceChangeNew")]
    [StringLength(500)]
    public string HremployeeSocialInsuranceChangeNew { get; set; }

    [Column("HREmployeeSocialInsuranceChangeFromDate", TypeName = "datetime")]
    public DateTime? HremployeeSocialInsuranceChangeFromDate { get; set; }

    [Column("HREmployeeSocialInsuranceChangeToDate", TypeName = "datetime")]
    public DateTime? HremployeeSocialInsuranceChangeToDate { get; set; }

    [Column("HREmployeeSocialInsuranceChangeCanCu")]
    [StringLength(500)]
    public string HremployeeSocialInsuranceChangeCanCu { get; set; }

    [ForeignKey("FkHradjustSocialInsuranceId")]
    [InverseProperty("HremployeeSocialInsuranceChangeFkHradjustSocialInsurances")]
    public virtual Hremployee FkHradjustSocialInsurance { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeSocialInsuranceChangeFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }
}
