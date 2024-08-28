using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductWorkItems")]
public partial class IcproductWorkItem
{
    [Key]
    [Column("ICProductWorkItemID")]
    public int IcproductWorkItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductWorkItemParentID")]
    public int FkIcproductWorkItemParentId { get; set; }

    [Column("FK_ICProductWorkItemChildID")]
    public int FkIcproductWorkItemChildId { get; set; }

    [Column("ICProductWorkItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductWorkItemQty { get; set; }

    [Column("ICProductWorkItemSortOrder")]
    public int? IcproductWorkItemSortOrder { get; set; }

    [Column("ICProductWorkItemDesc")]
    [StringLength(512)]
    public string IcproductWorkItemDesc { get; set; }

    [Column("ICProductWorkItemType")]
    [StringLength(50)]
    public string IcproductWorkItemType { get; set; }

    [Column("ICProductWorkItemProductChargeCheck")]
    public bool? IcproductWorkItemProductChargeCheck { get; set; }

    [Column("ICProductWorkItemParentType")]
    [StringLength(50)]
    public string IcproductWorkItemParentType { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductWorkItemFixedNorm")]
    public bool? IcproductWorkItemFixedNorm { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductWorkItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductWorkItemChildId")]
    [InverseProperty("IcproductWorkItemFkIcproductWorkItemChildren")]
    public virtual Icproduct FkIcproductWorkItemChild { get; set; }

    [ForeignKey("FkIcproductWorkItemParentId")]
    [InverseProperty("IcproductWorkItemFkIcproductWorkItemParents")]
    public virtual Icproduct FkIcproductWorkItemParent { get; set; }

    [InverseProperty("FkIcproductWorkItem")]
    public virtual ICollection<PmtemplateItemComponent> PmtemplateItemComponents { get; set; } = new List<PmtemplateItemComponent>();
}
