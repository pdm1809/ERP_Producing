using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ImportIngredientPackaging")]
public partial class ImportIngredientPackaging
{
    [Column("ICProductNo")]
    [StringLength(50)]
    public string IcproductNo { get; set; }

    [Column("FK_ICDepartmentID")]
    [StringLength(50)]
    public string FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    [StringLength(50)]
    public string FkIcproductGroupId { get; set; }

    [Column("FK_ICProductGroupChild1ID")]
    [StringLength(50)]
    public string FkIcproductGroupChild1Id { get; set; }

    [Column("STT")]
    [StringLength(10)]
    public string Stt { get; set; }

    [Column("ICProductName")]
    [StringLength(200)]
    public string IcproductName { get; set; }

    [Column("ICProductDesc")]
    [StringLength(200)]
    public string IcproductDesc { get; set; }

    [Column("ICProductBarCode")]
    [StringLength(50)]
    public string IcproductBarCode { get; set; }

    [Column("ICProductAttributeNo")]
    [StringLength(50)]
    public string IcproductAttributeNo { get; set; }

    [Column("ICProductNoOfOldSys")]
    [StringLength(50)]
    public string IcproductNoOfOldSys { get; set; }

    [Column("ICProductSupplierNumber")]
    [StringLength(50)]
    public string IcproductSupplierNumber { get; set; }

    [Column("ICProductUses")]
    [StringLength(50)]
    public string IcproductUses { get; set; }

    [Column("APSupplierNo")]
    [StringLength(50)]
    public string ApsupplierNo { get; set; }

    [Column("FK_ICProdAttPackingMaterialSpecialityID")]
    [StringLength(50)]
    public string FkIcprodAttPackingMaterialSpecialityId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSizeID")]
    [StringLength(50)]
    public string FkIcprodAttPackingMaterialSizeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    [StringLength(50)]
    public string FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("ICProductInsideDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductInsideDimensionLength { get; set; }

    [Column("ICProductInsideDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductInsideDimensionWidth { get; set; }

    [Column("ICProductInsideDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductInsideDimensionHeight { get; set; }

    [Column("ICProductOverallDimensionLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductOverallDimensionLength { get; set; }

    [Column("ICProductOverallDimensionWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductOverallDimensionWidth { get; set; }

    [Column("ICProductOverallDimensionHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductOverallDimensionHeight { get; set; }

    [Column("ICProductSizeAndSpecifiCations")]
    [StringLength(50)]
    public string IcproductSizeAndSpecifiCations { get; set; }

    [Column("ICProductCapacity", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCapacity { get; set; }

    [Column("ICProductNetWeight")]
    [StringLength(50)]
    public string IcproductNetWeight { get; set; }

    [Column("ICProductGrossWeight")]
    [StringLength(50)]
    public string IcproductGrossWeight { get; set; }

    [Column("ICProductBoxArea", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBoxArea { get; set; }

    [Column("ICProductBoxUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBoxUnitPrice { get; set; }

    [Column("ICProductLeadTime")]
    public int? IcproductLeadTime { get; set; }

    [Column("ICProductPurchaseType")]
    [StringLength(50)]
    public string IcproductPurchaseType { get; set; }

    [Column("ICProductAttribute01")]
    [StringLength(50)]
    public string IcproductAttribute01 { get; set; }

    [Column("ICProductPrice01")]
    [StringLength(20)]
    public string IcproductPrice01 { get; set; }

    [Column("ICProductSupplierPrice")]
    [StringLength(20)]
    public string IcproductSupplierPrice { get; set; }

    [Column("FK_GEVATID")]
    [StringLength(50)]
    public string FkGevatid { get; set; }

    [Column("FK_ICProductBasicUnitID")]
    [StringLength(50)]
    public string FkIcproductBasicUnitId { get; set; }

    [Column("FK_ICPriceCalculationMethodID")]
    [StringLength(20)]
    public string FkIcpriceCalculationMethodId { get; set; }

    [Column("ICProductIsFollowInventoryStock")]
    [StringLength(20)]
    public string IcproductIsFollowInventoryStock { get; set; }

    [Column("FK_ICProductTypeAccountConfigID")]
    [StringLength(100)]
    public string FkIcproductTypeAccountConfigId { get; set; }

    [Column("FK_ACAccountID")]
    [StringLength(10)]
    public string FkAcaccountId { get; set; }

    [Column("FK_ACAccountRevenueID")]
    [StringLength(10)]
    public string FkAcaccountRevenueId { get; set; }

    [Column("FK_ACAccountSaleReturnID")]
    [StringLength(10)]
    public string FkAcaccountSaleReturnId { get; set; }

    [Column("FK_ACAccountCostPriceID")]
    [StringLength(10)]
    public string FkAcaccountCostPriceId { get; set; }

    [Column("FK_ACAccountDiscountID")]
    [StringLength(10)]
    public string FkAcaccountDiscountId { get; set; }

    [Column("ICProductOriginOfProduct")]
    [StringLength(100)]
    public string IcproductOriginOfProduct { get; set; }

    [Column("FK_GECountryID")]
    [StringLength(100)]
    public string FkGecountryId { get; set; }

    [Column("ICProductAttribute02")]
    [StringLength(100)]
    public string IcproductAttribute02 { get; set; }

    [Column("ICProductAttribute03")]
    [StringLength(100)]
    public string IcproductAttribute03 { get; set; }
}
