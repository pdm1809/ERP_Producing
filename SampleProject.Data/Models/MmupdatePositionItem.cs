using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMUpdatePositionItems")]
public partial class MmupdatePositionItem
{
    [Key]
    [Column("MMUpdatePositionItemID")]
    public int MmupdatePositionItemId { get; set; }

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

    [Column("FK_MMUpdatePositionID")]
    public int FkMmupdatePositionId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_MMDiagramPositionOldID")]
    public int? FkMmdiagramPositionOldId { get; set; }

    [Column("FK_MMWSPositionID")]
    public int FkMmwspositionId { get; set; }

    [Column("FK_MMRangePositionID")]
    public int FkMmrangePositionId { get; set; }

    [Column("FK_MMRowPositionID")]
    public int FkMmrowPositionId { get; set; }

    [Column("MMUpdatePositionItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? MmupdatePositionItemProductQty { get; set; }

    [Column("MMUpdatePositionItemProductWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? MmupdatePositionItemProductWoodQty { get; set; }

    [Column("MMUpdatePositionItemLength", TypeName = "decimal(18, 5)")]
    public decimal? MmupdatePositionItemLength { get; set; }

    [Column("MMUpdatePositionItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmupdatePositionItemWidth { get; set; }

    [Column("MMUpdatePositionItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmupdatePositionItemHeight { get; set; }

    [Column("MMUpdatePositionItemPositionName")]
    [StringLength(100)]
    public string MmupdatePositionItemPositionName { get; set; }

    [Column("MMUpdatePositionItemDesc")]
    [StringLength(512)]
    public string MmupdatePositionItemDesc { get; set; }

    [ForeignKey("FkMmupdatePositionId")]
    [InverseProperty("MmupdatePositionItems")]
    public virtual MmupdatePosition FkMmupdatePosition { get; set; }

    [InverseProperty("FkMmupdatePositionItem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmupdatePositionItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
