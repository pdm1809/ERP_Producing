using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSubplements")]
public partial class IcproductSubplement
{
    [Key]
    [Column("ICProductSubplementID")]
    public int IcproductSubplementId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductSubplementChildID")]
    public int FkIcproductSubplementChildId { get; set; }

    [Column("FK_ICProductSubplementParentID")]
    public int FkIcproductSubplementParentId { get; set; }

    [Column("ICProductSubplementQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSubplementQty { get; set; }

    [Column("ICProductSubplementPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSubplementPrice { get; set; }

    [Column("ICProductSubplementSortOrder")]
    public int? IcproductSubplementSortOrder { get; set; }

    [Column("ICProductSubplementDesc")]
    [StringLength(50)]
    public string IcproductSubplementDesc { get; set; }

    [ForeignKey("FkIcproductSubplementChildId")]
    [InverseProperty("IcproductSubplementFkIcproductSubplementChildren")]
    public virtual Icproduct FkIcproductSubplementChild { get; set; }

    [ForeignKey("FkIcproductSubplementParentId")]
    [InverseProperty("IcproductSubplementFkIcproductSubplementParents")]
    public virtual Icproduct FkIcproductSubplementParent { get; set; }
}
