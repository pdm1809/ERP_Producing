using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMFalseConditionalDetails")]
public partial class MmfalseConditionalDetail
{
    [Key]
    [Column("MMFalseConditionalDetailID")]
    public int MmfalseConditionalDetailId { get; set; }

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

    [Column("FK_MMConfigFalseConditionalID")]
    public int? FkMmconfigFalseConditionalId { get; set; }

    [Column("MMFalseConditionalDetailName")]
    [StringLength(100)]
    public string MmfalseConditionalDetailName { get; set; }

    [Column("MMFalseConditionalDetailLimit", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalDetailLimit { get; set; }

    [Column("MMFalseConditionalDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalDetailQty { get; set; }

    [Column("MMFalseConditionalDetailPercent", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalDetailPercent { get; set; }

    [Column("MMFalseConditionalDetailComment")]
    [StringLength(500)]
    public string MmfalseConditionalDetailComment { get; set; }

    [Column("FK_MMFalseConditionalID")]
    public int? FkMmfalseConditionalId { get; set; }

    [Column("FK_MMFalseConditionalItemID")]
    public int? FkMmfalseConditionalItemId { get; set; }

    [ForeignKey("FkMmconfigFalseConditionalId")]
    [InverseProperty("MmfalseConditionalDetails")]
    public virtual MmconfigFalseConditional FkMmconfigFalseConditional { get; set; }

    [ForeignKey("FkMmfalseConditionalId")]
    [InverseProperty("MmfalseConditionalDetails")]
    public virtual MmfalseConditional FkMmfalseConditional { get; set; }

    [ForeignKey("FkMmfalseConditionalItemId")]
    [InverseProperty("MmfalseConditionalDetails")]
    public virtual MmfalseConditionalItem FkMmfalseConditionalItem { get; set; }
}
