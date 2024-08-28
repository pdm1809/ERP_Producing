using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRSplitRatios")]
public partial class HrsplitRatio
{
    [Key]
    [Column("HRSplitRatioID")]
    public int HrsplitRatioId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_CSCompanyID")]
    public int? FkCscompanyId { get; set; }

    [Column("HRSplitRatioGroup")]
    [StringLength(255)]
    public string HrsplitRatioGroup { get; set; }

    [Column("HRSplitRatioRatio", TypeName = "decimal(18, 5)")]
    public decimal? HrsplitRatioRatio { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrsplitRatios")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyId")]
    [InverseProperty("HrsplitRatios")]
    public virtual Cscompany FkCscompany { get; set; }
}
