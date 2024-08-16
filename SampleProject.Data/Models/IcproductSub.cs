using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSubs")]
public partial class IcproductSub
{
    [Key]
    [Column("ICProductSubID")]
    public int IcproductSubId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductSubParentID")]
    public int FkIcproductSubParentId { get; set; }

    [Column("FK_ICProductSubChildID")]
    public int FkIcproductSubChildId { get; set; }

    [Column("ICProductSubQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSubQty { get; set; }

    [Column("ICProductSubPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSubPrice { get; set; }

    [Column("ICProductSubOrder")]
    public int? IcproductSubOrder { get; set; }

    [Column("ICProductSubDesc")]
    [StringLength(50)]
    public string IcproductSubDesc { get; set; }

    [ForeignKey("FkIcproductSubChildId")]
    [InverseProperty("IcproductSubFkIcproductSubChildren")]
    public virtual Icproduct FkIcproductSubChild { get; set; }

    [ForeignKey("FkIcproductSubParentId")]
    [InverseProperty("IcproductSubFkIcproductSubParents")]
    public virtual Icproduct FkIcproductSubParent { get; set; }
}
