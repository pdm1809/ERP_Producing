using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRecruitmentNeedItems")]
public partial class HrrecruitmentNeedItem
{
    [Key]
    [Column("HRRecruitmentNeedItemID")]
    public int HrrecruitmentNeedItemId { get; set; }

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

    [Column("FK_HRRecruitmentNeedID")]
    public int? FkHrrecruitmentNeedId { get; set; }

    [Column("HRRecruitmentNeedItemQty", TypeName = "decimal(18, 5)")]
    public decimal? HrrecruitmentNeedItemQty { get; set; }

    [Column("HRRecruitmentNeedItemNote")]
    [StringLength(255)]
    public string HrrecruitmentNeedItemNote { get; set; }

    [Column("HRRecruitmentNeedItemDate", TypeName = "datetime")]
    public DateTime? HrrecruitmentNeedItemDate { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrrecruitmentNeedItems")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkHrrecruitmentNeedId")]
    [InverseProperty("HrrecruitmentNeedItems")]
    public virtual HrrecruitmentNeed FkHrrecruitmentNeed { get; set; }

    [InverseProperty("FkHrrecruitmentNeedItem")]
    public virtual ICollection<HrrecruitmentPlanItem> HrrecruitmentPlanItems { get; set; } = new List<HrrecruitmentPlanItem>();
}
