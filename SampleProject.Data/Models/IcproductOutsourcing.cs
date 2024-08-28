using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductOutsourcings")]
public partial class IcproductOutsourcing
{
    [Key]
    [Column("ICProductOutsourcingID")]
    public int IcproductOutsourcingId { get; set; }

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

    [Column("FK_ICProductOutsourcingChildID")]
    public int FkIcproductOutsourcingChildId { get; set; }

    [Column("FK_ICProductOutsourcingParentID")]
    public int FkIcproductOutsourcingParentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICProductOutsourcingProductNo")]
    [StringLength(50)]
    public string IcproductOutsourcingProductNo { get; set; }

    [Column("ICProductOutsourcingProductName")]
    [StringLength(256)]
    public string IcproductOutsourcingProductName { get; set; }

    [Column("ICProductOutsourcingProductDesc")]
    [StringLength(512)]
    public string IcproductOutsourcingProductDesc { get; set; }

    [Column("ICProductOutsourcingRemark")]
    [StringLength(512)]
    public string IcproductOutsourcingRemark { get; set; }

    [Column("ICProductOutsourcingProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductOutsourcingProductQty { get; set; }

    [Column("ICProductOutsourcingSortOrder")]
    public int? IcproductOutsourcingSortOrder { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcproductOutsourcings")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductOutsourcingChildId")]
    [InverseProperty("IcproductOutsourcingFkIcproductOutsourcingChildren")]
    public virtual Icproduct FkIcproductOutsourcingChild { get; set; }

    [ForeignKey("FkIcproductOutsourcingParentId")]
    [InverseProperty("IcproductOutsourcingFkIcproductOutsourcingParents")]
    public virtual Icproduct FkIcproductOutsourcingParent { get; set; }
}
