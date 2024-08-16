using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRConfigureRewardLevels")]
public partial class HrconfigureRewardLevel
{
    [Key]
    [Column("HRConfigureRewardLevelID")]
    public int HrconfigureRewardLevelId { get; set; }

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

    [Column("HRConfigureRewardLevelReceiptTime")]
    [StringLength(255)]
    public string HrconfigureRewardLevelReceiptTime { get; set; }

    [Column("HRConfigureRewardLevelBonus", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigureRewardLevelBonus { get; set; }

    [Column("HRConfigureRewardLevelDependent")]
    [StringLength(255)]
    public string HrconfigureRewardLevelDependent { get; set; }
}
