using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMConfigFalseConditionals")]
public partial class MmconfigFalseConditional
{
    [Key]
    [Column("MMConfigFalseConditionalID")]
    public int MmconfigFalseConditionalId { get; set; }

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

    [Column("MMConfigFalseConditionalName")]
    [StringLength(100)]
    public string MmconfigFalseConditionalName { get; set; }

    [Column("MMConfigFalseConditionalLevel")]
    [StringLength(100)]
    public string MmconfigFalseConditionalLevel { get; set; }

    [Column("MMConfigFalseConditionalLimit", TypeName = "decimal(18, 5)")]
    public decimal? MmconfigFalseConditionalLimit { get; set; }

    [Column("MMConfigFalseConditionalConsequence")]
    [StringLength(100)]
    public string MmconfigFalseConditionalConsequence { get; set; }

    [Column("MMConfigFalseConditionalConditional")]
    [StringLength(100)]
    public string MmconfigFalseConditionalConditional { get; set; }

    [InverseProperty("FkMmconfigFalseConditional")]
    public virtual ICollection<MmfalseConditionalDetail> MmfalseConditionalDetails { get; set; } = new List<MmfalseConditionalDetail>();
}
