using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICCollectionItems")]
public partial class IccollectionItem
{
    [Key]
    [Column("ICCollectionItemID")]
    public int IccollectionItemId { get; set; }

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

    [Column("FK_ICCollectionID")]
    public int? FkIccollectionId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICCollectionItemProductNo")]
    [StringLength(50)]
    public string IccollectionItemProductNo { get; set; }

    [Column("ICCollectionItemProductName")]
    [StringLength(256)]
    public string IccollectionItemProductName { get; set; }

    [Column("ICCollectionItemProductDesc")]
    [StringLength(512)]
    public string IccollectionItemProductDesc { get; set; }

    [Column("ICCollectionItemProductType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IccollectionItemProductType { get; set; }

    [Column("ICCollectionItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IccollectionItemQty { get; set; }

    [Column("ICCollectionItemBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? IccollectionItemBasicQty { get; set; }

    [Column("ICCollectionItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IccollectionItemType { get; set; }

    [Column("ICCollectionItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IccollectionItemProductUnitPrice { get; set; }

    [InverseProperty("FkIccollectionItem")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [ForeignKey("FkIccollectionId")]
    [InverseProperty("IccollectionItems")]
    public virtual Iccollection FkIccollection { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IccollectionItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IccollectionItems")]
    public virtual Icproduct FkIcproduct { get; set; }
}
