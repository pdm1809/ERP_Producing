using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRecruitmentPlanItems")]
public partial class HrrecruitmentPlanItem
{
    [Key]
    [Column("HRRecruitmentPlanItemID")]
    public int HrrecruitmentPlanItemId { get; set; }

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

    [Column("FK_HRLevelID")]
    public int FkHrlevelId { get; set; }

    [Column("FK_HRRecruitmentPlanID")]
    public int? FkHrrecruitmentPlanId { get; set; }

    [Column("HRRecruitmentPlanItemQty", TypeName = "decimal(18, 5)")]
    public decimal? HrrecruitmentPlanItemQty { get; set; }

    [Column("HRRecruitmentPlanItemNote")]
    [StringLength(255)]
    public string HrrecruitmentPlanItemNote { get; set; }

    [Column("HRRecruitmentPlanItemDate", TypeName = "datetime")]
    public DateTime? HrrecruitmentPlanItemDate { get; set; }

    [Column("FK_HRRecruitmentNeedID")]
    public int? FkHrrecruitmentNeedId { get; set; }

    [Column("FK_HRRecruitmentNeedItemID")]
    public int? FkHrrecruitmentNeedItemId { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrrecruitmentPlanItems")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkHrrecruitmentNeedId")]
    [InverseProperty("HrrecruitmentPlanItems")]
    public virtual HrrecruitmentNeed FkHrrecruitmentNeed { get; set; }

    [ForeignKey("FkHrrecruitmentNeedItemId")]
    [InverseProperty("HrrecruitmentPlanItems")]
    public virtual HrrecruitmentNeedItem FkHrrecruitmentNeedItem { get; set; }

    [ForeignKey("FkHrrecruitmentPlanId")]
    [InverseProperty("HrrecruitmentPlanItems")]
    public virtual HrrecruitmentPlan FkHrrecruitmentPlan { get; set; }
}
