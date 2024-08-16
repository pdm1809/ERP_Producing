using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductItems")]
public partial class IcproductItem
{
    [Key]
    [Column("ICProductItemID")]
    public int IcproductItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductItemParentID")]
    public int FkIcproductItemParentId { get; set; }

    [Column("FK_ICProductItemChildID")]
    public int FkIcproductItemChildId { get; set; }

    [Column("ICProductItemQty", TypeName = "decimal(18, 6)")]
    public decimal? IcproductItemQty { get; set; }

    [Column("ICProductItemSortOrder")]
    public int? IcproductItemSortOrder { get; set; }

    [Column("ICProductItemDesc")]
    [StringLength(512)]
    public string IcproductItemDesc { get; set; }

    [Column("ICProductItemType")]
    [StringLength(50)]
    public string IcproductItemType { get; set; }

    [Column("FK_ICProductCarcassID")]
    public int? FkIcproductCarcassId { get; set; }

    [Column("ICProductItemParentID")]
    public int? IcproductItemParentId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_ICProductDetailID")]
    public int? FkIcproductDetailId { get; set; }

    [Column("ICProductItemCode")]
    [StringLength(50)]
    public string IcproductItemCode { get; set; }

    [Column("ICProductionItemParentCode")]
    [StringLength(50)]
    public string IcproductionItemParentCode { get; set; }

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

    [ForeignKey("FkIcproductCarcassId")]
    [InverseProperty("IcproductItemFkIcproductCarcasses")]
    public virtual Icproduct FkIcproductCarcass { get; set; }

    [ForeignKey("FkIcproductItemChildId")]
    [InverseProperty("IcproductItemFkIcproductItemChildren")]
    public virtual Icproduct FkIcproductItemChild { get; set; }

    [ForeignKey("FkIcproductItemParentId")]
    [InverseProperty("IcproductItemFkIcproductItemParents")]
    public virtual Icproduct FkIcproductItemParent { get; set; }
}
