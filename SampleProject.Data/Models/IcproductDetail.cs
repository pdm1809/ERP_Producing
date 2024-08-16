using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductDetails")]
public partial class IcproductDetail
{
    [Key]
    [Column("ICProductDetailID")]
    public int IcproductDetailId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ICProductDetailProductNo")]
    [StringLength(50)]
    public string IcproductDetailProductNo { get; set; }

    [Column("ICProductDetailProductName")]
    [StringLength(256)]
    public string IcproductDetailProductName { get; set; }

    [Column("ICProductDetailProductDesc")]
    [StringLength(512)]
    public string IcproductDetailProductDesc { get; set; }

    [Column("ICProductDetailProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDetailProductQty { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductParentID")]
    public int FkIcproductParentId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("ICProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductHeight { get; set; }

    [Column("ICProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductWidth { get; set; }

    [Column("ICProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductLength { get; set; }

    [Column("ICProductBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBlock { get; set; }

    [Column("ICProductQuantitative", TypeName = "decimal(18, 5)")]
    public decimal? IcproductQuantitative { get; set; }

    [Column("ICProductDepth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDepth { get; set; }

    [Column("ICProductDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDepreciationRate { get; set; }

    [Column("ICProductDepreciationQty", TypeName = "decimal(18, 6)")]
    public decimal? IcproductDepreciationQty { get; set; }

    [Column("ICProductDetailTolenrance", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDetailTolenrance { get; set; }

    [Column("ICProductDetailSerial")]
    [StringLength(100)]
    public string IcproductDetailSerial { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeSemiProductSpecialityID")]
    public int? FkIcproductAttributeSemiProductSpecialityId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_MMFormulaIDPaintA")]
    public int? FkMmformulaIdpaintA { get; set; }

    [Column("FK_MMFormulaIDPaintB")]
    public int? FkMmformulaIdpaintB { get; set; }

    [Column("FK_MMFormulaIDPaintC")]
    public int? FkMmformulaIdpaintC { get; set; }

    [Column("ICProductHavePaint")]
    public bool? IcproductHavePaint { get; set; }

    public bool? HasComponent { get; set; }

    [Column("ICProductDetailCode01Combo")]
    [StringLength(100)]
    public string IcproductDetailCode01Combo { get; set; }

    [Column("ICProductDetailCode02Combo")]
    [StringLength(100)]
    public string IcproductDetailCode02Combo { get; set; }

    [Column("ICProductDetailCode03Combo")]
    [StringLength(100)]
    public string IcproductDetailCode03Combo { get; set; }

    [Column("ICProductDetailCode04Combo")]
    [StringLength(100)]
    public string IcproductDetailCode04Combo { get; set; }

    [Column("ICProductDetailCode05Combo")]
    [StringLength(100)]
    public string IcproductDetailCode05Combo { get; set; }

    [Column("ICProductDetailCode06Combo")]
    [StringLength(100)]
    public string IcproductDetailCode06Combo { get; set; }

    [Column("ICProductDetailCode07Combo")]
    [StringLength(100)]
    public string IcproductDetailCode07Combo { get; set; }

    [Column("ICProductDetailCode08Combo")]
    [StringLength(100)]
    public string IcproductDetailCode08Combo { get; set; }

    [Column("ICProductDetailCode09Combo")]
    [StringLength(100)]
    public string IcproductDetailCode09Combo { get; set; }

    [Column("ICProductDetailCode10Combo")]
    [StringLength(100)]
    public string IcproductDetailCode10Combo { get; set; }

    [Column("FK_MMProcessID")]
    public int? FkMmprocessId { get; set; }

    [Column("ICProductSizeAndSpecifiCations")]
    [StringLength(512)]
    public string IcproductSizeAndSpecifiCations { get; set; }

    [Column("ICProductJoinery")]
    [StringLength(524)]
    public string IcproductJoinery { get; set; }

    [Column("ICProductComment")]
    [StringLength(524)]
    public string IcproductComment { get; set; }

    [Column("ICProductDiameter", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDiameter { get; set; }

    [Column("ICProductIsReUse")]
    public bool? IcproductIsReUse { get; set; }

    [Column("ICProductDetailOldID")]
    public int? IcproductDetailOldId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("ICConfigProductionComplexityType")]
    [StringLength(100)]
    public string IcconfigProductionComplexityType { get; set; }

    [Column("ICProductDetailCode11Combo")]
    [StringLength(100)]
    public string IcproductDetailCode11Combo { get; set; }

    [Column("ICProductDetailCode12Combo")]
    [StringLength(100)]
    public string IcproductDetailCode12Combo { get; set; }

    [Column("ICProductDetailCode13Combo")]
    [StringLength(100)]
    public string IcproductDetailCode13Combo { get; set; }

    [Column("ICProductDetailCode14Combo")]
    [StringLength(100)]
    public string IcproductDetailCode14Combo { get; set; }

    [Column("ICProductDetailCode15Combo")]
    [StringLength(100)]
    public string IcproductDetailCode15Combo { get; set; }

    [InverseProperty("FkIcproductDetail")]
    public virtual ICollection<ApinvoiceInPackageItemDetail> ApinvoiceInPackageItemDetails { get; set; } = new List<ApinvoiceInPackageItemDetail>();

    [InverseProperty("FkIcproductDetail")]
    public virtual ICollection<AppopackageItemDetail> AppopackageItemDetails { get; set; } = new List<AppopackageItemDetail>();

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductDetailFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductParentId")]
    [InverseProperty("IcproductDetailFkIcproductParents")]
    public virtual Icproduct FkIcproductParent { get; set; }

    [InverseProperty("FkIcproductDetail")]
    public virtual ICollection<IcproductPackageItemDetail> IcproductPackageItemDetails { get; set; } = new List<IcproductPackageItemDetail>();

    [InverseProperty("FkIcproductDetail")]
    public virtual ICollection<IcreceiptPackageItemDetail> IcreceiptPackageItemDetails { get; set; } = new List<IcreceiptPackageItemDetail>();

    [InverseProperty("FkIcproductDetail")]
    public virtual ICollection<IcshipmentPackageItemDetail> IcshipmentPackageItemDetails { get; set; } = new List<IcshipmentPackageItemDetail>();
}
