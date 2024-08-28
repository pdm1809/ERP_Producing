using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductComponents")]
public partial class IcproductComponent
{
    [Key]
    [Column("ICProductComponentID")]
    public int IcproductComponentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductComponentParentID")]
    public int FkIcproductComponentParentId { get; set; }

    [Column("FK_ICProductComponentChildID")]
    public int FkIcproductComponentChildId { get; set; }

    [Column("ICProductComponentQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductComponentQty { get; set; }

    [Column("ICProductComponentSortOrder")]
    public int? IcproductComponentSortOrder { get; set; }

    [Column("ICProductComponentDesc")]
    [StringLength(512)]
    public string IcproductComponentDesc { get; set; }

    [ForeignKey("FkIcproductComponentChildId")]
    [InverseProperty("IcproductComponentFkIcproductComponentChildren")]
    public virtual Icproduct FkIcproductComponentChild { get; set; }

    [ForeignKey("FkIcproductComponentParentId")]
    [InverseProperty("IcproductComponentFkIcproductComponentParents")]
    public virtual Icproduct FkIcproductComponentParent { get; set; }
}
