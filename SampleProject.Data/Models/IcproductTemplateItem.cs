using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductTemplateItems")]
public partial class IcproductTemplateItem
{
    [Key]
    [Column("ICProductTemplateItemID")]
    public int IcproductTemplateItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ICProductTemplateItemProductName")]
    [StringLength(512)]
    public string IcproductTemplateItemProductName { get; set; }

    [Column("FK_ICProductTemplateID")]
    public int? FkIcproductTemplateId { get; set; }

    [Column("FK_ICProductFormulaPriceConfigID")]
    public int? FkIcproductFormulaPriceConfigId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductTemplateItemSortOrder")]
    public int? IcproductTemplateItemSortOrder { get; set; }

    [Column("ICProductTemplateItemType")]
    [StringLength(50)]
    public string IcproductTemplateItemType { get; set; }

    [Column("ICProductTemplateItemProductNo")]
    [StringLength(128)]
    public string IcproductTemplateItemProductNo { get; set; }

    [Column("ICProductTemplateItemProductDesc")]
    [StringLength(1024)]
    public string IcproductTemplateItemProductDesc { get; set; }

    [Column("ICProductTemplateItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTemplateItemProductQty { get; set; }

    [Column("ICProductTemplateItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTemplateItemProductUnitPrice { get; set; }

    [Column("ICProductTemplateItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTemplateItemTotalAmount { get; set; }

    [Column("ICProductTemplateItemLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTemplateItemLength { get; set; }

    [Column("ICProductTemplateItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTemplateItemWidth { get; set; }

    [Column("ICProductTemplateItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTemplateItemHeight { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICProductTemplateItemFormulaPriceConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTemplateItemFormulaPriceConfigQty { get; set; }

    [InverseProperty("FkIcproductTemplateItem")]
    public virtual ICollection<ArproposalAreaItem> ArproposalAreaItems { get; set; } = new List<ArproposalAreaItem>();

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcproductTemplateItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductTemplateItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductFormulaPriceConfigId")]
    [InverseProperty("IcproductTemplateItems")]
    public virtual IcproductFormulaPriceConfig FkIcproductFormulaPriceConfig { get; set; }

    [ForeignKey("FkIcproductTemplateId")]
    [InverseProperty("IcproductTemplateItems")]
    public virtual IcproductTemplate FkIcproductTemplate { get; set; }
}
