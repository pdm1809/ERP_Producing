using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMFalseConditionalItems")]
public partial class MmfalseConditionalItem
{
    [Key]
    [Column("MMFalseConditionalItemID")]
    public int MmfalseConditionalItemId { get; set; }

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

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("MMFalseConditionalItemHumidity")]
    [StringLength(100)]
    public string MmfalseConditionalItemHumidity { get; set; }

    [Column("MMFalseConditionalItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalItemProductLength { get; set; }

    [Column("MMFalseConditionalItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalItemProductWidth { get; set; }

    [Column("MMFalseConditionalItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalItemProductHeight { get; set; }

    [Column("MMFalseConditionalItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalItemWoodQty { get; set; }

    [Column("MMFalseConditionalItemInventoryWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalItemInventoryWoodQty { get; set; }

    [Column("MMFalseConditionalItemFaultPercent", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalItemFaultPercent { get; set; }

    [Column("MMFalseConditionalItemGoodPercent", TypeName = "decimal(18, 5)")]
    public decimal? MmfalseConditionalItemGoodPercent { get; set; }

    [Column("MMFalseConditionalItemResult")]
    [StringLength(100)]
    public string MmfalseConditionalItemResult { get; set; }

    [Column("MMFalseConditionalItemComment")]
    [StringLength(500)]
    public string MmfalseConditionalItemComment { get; set; }

    [Column("MMFalseConditionalItemProductSerialNo")]
    [StringLength(100)]
    public string MmfalseConditionalItemProductSerialNo { get; set; }

    [Column("FK_MMFalseConditionalID")]
    public int? FkMmfalseConditionalId { get; set; }

    [Column("MMFalseConditionalItemProductAttributeQuality")]
    [StringLength(200)]
    public string MmfalseConditionalItemProductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmfalseConditionalItems")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("MmfalseConditionalItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkMmfalseConditionalId")]
    [InverseProperty("MmfalseConditionalItems")]
    public virtual MmfalseConditional FkMmfalseConditional { get; set; }

    [InverseProperty("FkMmfalseConditionalItem")]
    public virtual ICollection<MmfalseConditionalDetail> MmfalseConditionalDetails { get; set; } = new List<MmfalseConditionalDetail>();
}
