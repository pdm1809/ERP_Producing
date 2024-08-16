using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAssetTypeDepreciationConfigs")]
public partial class AcassetTypeDepreciationConfig
{
    [Key]
    [Column("ACAssetTypeDepreciationConfigID")]
    public int AcassetTypeDepreciationConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("ACAssetType")]
    [StringLength(50)]
    public string AcassetType { get; set; }

    [Column("ACAssetTypeDepreciationConfigDesc")]
    [StringLength(512)]
    public string AcassetTypeDepreciationConfigDesc { get; set; }

    [Column("ACAssetTypeDepreciationConfigMin")]
    public int? AcassetTypeDepreciationConfigMin { get; set; }

    [Column("ACAssetTypeDepreciationConfigMax")]
    public int? AcassetTypeDepreciationConfigMax { get; set; }
}
