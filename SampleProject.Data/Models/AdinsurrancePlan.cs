using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADInsurrancePlans")]
public partial class AdinsurrancePlan
{
    [Key]
    [Column("ADInsurrancePlanID")]
    public int AdinsurrancePlanId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("ADInsurrancePlanNo")]
    [StringLength(50)]
    public string AdinsurrancePlanNo { get; set; }

    [Column("ADInsurrancePlanName")]
    [StringLength(512)]
    public string AdinsurrancePlanName { get; set; }

    [Column("ADInsurrancePlanSocialID")]
    [StringLength(512)]
    public string AdinsurrancePlanSocialId { get; set; }

    [Column("ADInsurrancePlanIsUnCheckBHXH")]
    public bool? AdinsurrancePlanIsUnCheckBhxh { get; set; }

    [InverseProperty("FkAdinsurrancePlan")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();
}
