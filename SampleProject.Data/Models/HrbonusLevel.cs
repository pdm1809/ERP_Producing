using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRBonusLevels")]
public partial class HrbonusLevel
{
    [Key]
    [Column("HRBonusLevelID")]
    public int HrbonusLevelId { get; set; }

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

    [Column("HRBonusLevelRewardPoint", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusLevelRewardPoint { get; set; }

    [Column("HRBonusLevelPointFrom", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusLevelPointFrom { get; set; }

    [Column("HRBonusLevelPointTo", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusLevelPointTo { get; set; }

    [Column("HRBonusLevelPointEqual", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusLevelPointEqual { get; set; }

    [Column("HRProductDepartmentGroup")]
    [StringLength(255)]
    public string HrproductDepartmentGroup { get; set; }

    [Column("HRBonusLevelCalculatedOn")]
    [StringLength(255)]
    public string HrbonusLevelCalculatedOn { get; set; }
}
