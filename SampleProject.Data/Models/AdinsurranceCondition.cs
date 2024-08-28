using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADInsurranceConditions")]
public partial class AdinsurranceCondition
{
    [Key]
    [Column("ADInsurranceConditionID")]
    public int AdinsurranceConditionId { get; set; }

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

    [Column("ADInsurranceConditionNo")]
    [StringLength(50)]
    public string AdinsurranceConditionNo { get; set; }

    [Column("ADInsurranceConditionName")]
    [StringLength(512)]
    public string AdinsurranceConditionName { get; set; }

    [Column("ADInsurranceConditionSocialID")]
    [StringLength(512)]
    public string AdinsurranceConditionSocialId { get; set; }

    [InverseProperty("FkAdinsurranceCondition")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();
}
