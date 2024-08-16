using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevelWorkSummarys")]
public partial class HrlevelWorkSummary
{
    [Key]
    [Column("HRLevelWorkSummarysID")]
    public int HrlevelWorkSummarysId { get; set; }

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

    [Column("FK_HRLevelID")]
    public int FkHrlevelId { get; set; }

    [Column("HRLevelWorkSummaryOrder")]
    public int? HrlevelWorkSummaryOrder { get; set; }

    [Column("HRLevelWorkSummaryDesc")]
    [StringLength(512)]
    public string HrlevelWorkSummaryDesc { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrlevelWorkSummaries")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
