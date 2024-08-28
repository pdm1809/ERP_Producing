using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAdjustSocialInsurances")]
public partial class HradjustSocialInsurance
{
    [Key]
    [Column("HRAdjustSocialInsuranceID")]
    public int HradjustSocialInsuranceId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("HRAdjustSocialInsuranceNo")]
    [StringLength(50)]
    public string HradjustSocialInsuranceNo { get; set; }

    [Column("HRAdjustSocialInsuranceStatus")]
    [StringLength(100)]
    public string HradjustSocialInsuranceStatus { get; set; }

    [Column("HRAdjustSocialInsuranceDesc")]
    [StringLength(512)]
    public string HradjustSocialInsuranceDesc { get; set; }

    [Column("HRAdjustSocialInsuranceDate", TypeName = "datetime")]
    public DateTime? HradjustSocialInsuranceDate { get; set; }

    [Column("HRAdjustSocialInsurancePhase")]
    public int? HradjustSocialInsurancePhase { get; set; }

    [Column("HRAdjustSocialInsuranceBHXHRate", TypeName = "decimal(18, 5)")]
    public decimal? HradjustSocialInsuranceBhxhrate { get; set; }

    [Column("HRAdjustSocialInsuranceBHYTRate", TypeName = "decimal(18, 5)")]
    public decimal? HradjustSocialInsuranceBhytrate { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HradjustSocialInsurances")]
    public virtual Brbranch FkBrbranch { get; set; }

    [InverseProperty("FkHradjustSocialInsurance")]
    public virtual ICollection<HremployeeAdjustSocialInsurance> HremployeeAdjustSocialInsurances { get; set; } = new List<HremployeeAdjustSocialInsurance>();

    [InverseProperty("FkHradjustSocialInsurance")]
    public virtual ICollection<HremployeeArrearSocialInsurance> HremployeeArrearSocialInsurances { get; set; } = new List<HremployeeArrearSocialInsurance>();
}
