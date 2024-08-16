using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPaintProcessesItems")]
public partial class MmpaintProcessesItem
{
    [Key]
    [Column("MMPaintProcessesItemID")]
    public int MmpaintProcessesItemId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_MMPaintProcessesID")]
    public int? FkMmpaintProcessesId { get; set; }

    [Required]
    [Column("MMPaintProcessesItemNo")]
    [StringLength(50)]
    public string MmpaintProcessesItemNo { get; set; }

    [Column("MMPaintProcessesItemName")]
    [StringLength(256)]
    public string MmpaintProcessesItemName { get; set; }

    [Column("MMPaintProcessesItemDesc")]
    [StringLength(512)]
    public string MmpaintProcessesItemDesc { get; set; }

    [Column("MMPaintProcessesItemParentID")]
    public int? MmpaintProcessesItemParentId { get; set; }

    [Column("MMPaintProcessesItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpaintProcessesItemProductQty { get; set; }

    [Column("MMPaintProcessesItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmpaintProcessesItemProductUnitCost { get; set; }

    [Column("MMPaintProcessesItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmpaintProcessesItemTotalCost { get; set; }

    [Column("MMPaintProcessesItemGroupName")]
    [StringLength(256)]
    public string MmpaintProcessesItemGroupName { get; set; }

    [Column("MMPaintProcessesItemMixRatio")]
    [StringLength(512)]
    public string MmpaintProcessesItemMixRatio { get; set; }

    [Column("MMPaintProcessesItemWaitingTime")]
    public int? MmpaintProcessesItemWaitingTime { get; set; }

    [Column("MMPaintProcessesItemPasNumber")]
    public int? MmpaintProcessesItemPasNumber { get; set; }

    [Column("MMPaintProcessesItemViscosity")]
    public int? MmpaintProcessesItemViscosity { get; set; }

    [Column("FK_PackagingProductID")]
    public int? FkPackagingProductId { get; set; }

    [Column("MMPaintProcessesItemExecuteMethod")]
    [StringLength(512)]
    public string MmpaintProcessesItemExecuteMethod { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmpaintProcessesItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmpaintProcessesItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmpaintProcessesId")]
    [InverseProperty("MmpaintProcessesItems")]
    public virtual MmpaintProcessess FkMmpaintProcesses { get; set; }
}
