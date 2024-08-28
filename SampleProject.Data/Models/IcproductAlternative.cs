using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductAlternatives")]
public partial class IcproductAlternative
{
    [Key]
    [Column("ICProductAlternativeID")]
    public int IcproductAlternativeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductAlternativeChildID")]
    public int FkIcproductAlternativeChildId { get; set; }

    [Column("FK_ICProductAlternativeParentID")]
    public int FkIcproductAlternativeParentId { get; set; }

    [Column("ICProductAlternativeQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductAlternativeQty { get; set; }

    [Column("ICProductAlternativePrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductAlternativePrice { get; set; }

    [Column("ICProductAlternativeSortOrder")]
    public int? IcproductAlternativeSortOrder { get; set; }

    [Column("ICProductAlternativeDesc")]
    [StringLength(512)]
    public string IcproductAlternativeDesc { get; set; }

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

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("ICProductAlternativeName")]
    [StringLength(255)]
    public string IcproductAlternativeName { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [ForeignKey("FkIcproductAlternativeChildId")]
    [InverseProperty("IcproductAlternativeFkIcproductAlternativeChildren")]
    public virtual Icproduct FkIcproductAlternativeChild { get; set; }

    [ForeignKey("FkIcproductAlternativeParentId")]
    [InverseProperty("IcproductAlternativeFkIcproductAlternativeParents")]
    public virtual Icproduct FkIcproductAlternativeParent { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcproductAlternatives")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }
}
