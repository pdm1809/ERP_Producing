using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductApplyPriceItems")]
public partial class IcproductApplyPriceItem
{
    [Key]
    [Column("ICProductApplyPriceItemID")]
    public int IcproductApplyPriceItemId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductApplyPriceID")]
    public int? FkIcproductApplyPriceId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductApplyPriceItemProductNo")]
    [StringLength(50)]
    public string IcproductApplyPriceItemProductNo { get; set; }

    [Column("ICProductApplyPriceItemProductName")]
    [StringLength(50)]
    public string IcproductApplyPriceItemProductName { get; set; }

    [Column("ICProductApplyPriceItemProductDesc")]
    [StringLength(512)]
    public string IcproductApplyPriceItemProductDesc { get; set; }

    [Column("ICProductApplyPriceItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemProductLength { get; set; }

    [Column("ICProductApplyPriceItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemProductWidth { get; set; }

    [Column("ICProductApplyPriceItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemProductHeight { get; set; }

    [Column("ICProductApplyPriceItemQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemQty { get; set; }

    [Column("ICProductApplyPriceItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemPrice { get; set; }

    [Column("ICProductApplyPriceItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemTotalAmount { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("ICProductApplyPriceItemProductWoodTypeAttribute")]
    [StringLength(256)]
    public string IcproductApplyPriceItemProductWoodTypeAttribute { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductFormulaPriceConfigID")]
    public int? FkIcproductFormulaPriceConfigId { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int? FkIcproductAttributeColorId { get; set; }

    [Column("ICProductApplyPriceItemProductColorAttribute")]
    [StringLength(256)]
    public string IcproductApplyPriceItemProductColorAttribute { get; set; }

    [Column("FK_ICProductParentID")]
    public int? FkIcproductParentId { get; set; }

    [Column("ICProductApplyPriceItemCommand")]
    [StringLength(512)]
    public string IcproductApplyPriceItemCommand { get; set; }

    [Column("FK_ICCollectionID")]
    public int? FkIccollectionId { get; set; }

    [Column("FK_ICCollectionItemID")]
    public int? FkIccollectionItemId { get; set; }

    [Column("ICProductApplyPriceItemProductArea", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemProductArea { get; set; }

    [Column("ICProductApplyPriceItemDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemDiscountPercent { get; set; }

    [Column("ICProductApplyPriceItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemDiscountAmount { get; set; }

    [Column("ICProductApplyPriceItemTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemTaxPercent { get; set; }

    [Column("ICProductApplyPriceItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemTaxAmount { get; set; }

    [Column("ICProductApplyPriceItemInternalPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemInternalPrice { get; set; }

    [Column("ICProductApplyPriceItemBasicPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemBasicPrice { get; set; }

    [Column("ICProductApplyPriceItemReductionRate", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceItemReductionRate { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcproductApplyPriceItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductApplyPriceItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductApplyPriceId")]
    [InverseProperty("IcproductApplyPriceItems")]
    public virtual IcproductApplyPrice FkIcproductApplyPrice { get; set; }

    [ForeignKey("FkIcproductAttributeColorId")]
    [InverseProperty("IcproductApplyPriceItemFkIcproductAttributeColors")]
    public virtual IcproductAttribute FkIcproductAttributeColor { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcproductApplyPriceItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductFormulaPriceConfigId")]
    [InverseProperty("IcproductApplyPriceItems")]
    public virtual IcproductFormulaPriceConfig FkIcproductFormulaPriceConfig { get; set; }
}
