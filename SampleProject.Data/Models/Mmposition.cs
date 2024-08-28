using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPositions")]
public partial class Mmposition
{
    [Key]
    [Column("MMPositionID")]
    public int MmpositionId { get; set; }

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

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Required]
    [Column("MMPositionType")]
    [StringLength(50)]
    public string MmpositionType { get; set; }

    [Required]
    [Column("MMPositionNo")]
    [StringLength(50)]
    public string MmpositionNo { get; set; }

    [Required]
    [Column("MMPositionSymbol")]
    [StringLength(50)]
    public string MmpositionSymbol { get; set; }

    [Column("MMPositionLevel")]
    public int MmpositionLevel { get; set; }

    [Required]
    [Column("MMPositionName")]
    [StringLength(256)]
    public string MmpositionName { get; set; }

    [Column("MMPositionDesc")]
    [StringLength(512)]
    public string MmpositionDesc { get; set; }

    [Column("MMPositionLength", TypeName = "decimal(18, 5)")]
    public decimal? MmpositionLength { get; set; }

    [Column("MMPositionWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmpositionWidth { get; set; }

    [Column("MMPositionHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmpositionHeight { get; set; }

    [Column("MMPositionActiveCheck")]
    public bool MmpositionActiveCheck { get; set; }

    [Column("MMPositionGELocationName")]
    [StringLength(512)]
    public string MmpositionGelocationName { get; set; }
}
