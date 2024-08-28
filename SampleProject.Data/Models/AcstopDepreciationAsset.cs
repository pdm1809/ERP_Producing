using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACStopDepreciationAssets")]
public partial class AcstopDepreciationAsset
{
    [Key]
    [Column("ACStopDepreciationAssetID")]
    public int AcstopDepreciationAssetId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("ACStopDepreciationAssetNo")]
    [StringLength(50)]
    public string AcstopDepreciationAssetNo { get; set; }

    [Column("ACStopDepreciationAssetName")]
    [StringLength(256)]
    public string AcstopDepreciationAssetName { get; set; }

    [Column("ACStopDepreciationAssetDesc")]
    [StringLength(512)]
    public string AcstopDepreciationAssetDesc { get; set; }

    [Column("ACStopDepreciationAssetReason")]
    [StringLength(512)]
    public string AcstopDepreciationAssetReason { get; set; }

    [Column("ACStopDepreciationAssetDate", TypeName = "datetime")]
    public DateTime? AcstopDepreciationAssetDate { get; set; }

    [Column("ACStopDepreciationAssetDateStop", TypeName = "datetime")]
    public DateTime AcstopDepreciationAssetDateStop { get; set; }

    [Column("FK_ACAssetID")]
    public int FkAcassetId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACStopDepreciationAssetType")]
    [StringLength(50)]
    public string AcstopDepreciationAssetType { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("AcstopDepreciationAssets")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcstopDepreciationAssets")]
    public virtual Brbranch FkBrbranch { get; set; }
}
