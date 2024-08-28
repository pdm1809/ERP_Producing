using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class VIcproduct
{
    [Column("ICProductID")]
    public int IcproductId { get; set; }

    [Column("ICProductPrice01", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPrice01 { get; set; }

    [Column("ICProductBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductBarCode { get; set; }

    [Required]
    [Column("ICProductNo")]
    [StringLength(50)]
    public string IcproductNo { get; set; }

    [Column("ICProductCode")]
    [StringLength(50)]
    public string IcproductCode { get; set; }

    [Required]
    [Column("ICProductName")]
    [StringLength(256)]
    public string IcproductName { get; set; }

    [Column("ICProductName2")]
    [StringLength(256)]
    public string IcproductName2 { get; set; }

    [Required]
    [Column("ICProductDesc")]
    [StringLength(512)]
    public string IcproductDesc { get; set; }

    [Column("ICProductSupplierNumber")]
    [StringLength(50)]
    public string IcproductSupplierNumber { get; set; }

    [Required]
    [Column("ICProductType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductType { get; set; }

    [Column("ICProductJoinery")]
    [StringLength(50)]
    public string IcproductJoinery { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSizeID")]
    public int? FkIcprodAttPackingMaterialSizeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSpecialityID")]
    public int? FkIcprodAttPackingMaterialSpecialityId { get; set; }

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

    [Column("FK_ICProductBasicUnitID")]
    public int FkIcproductBasicUnitId { get; set; }

    [Column("FK_ICProductSaleUnitID")]
    public int? FkIcproductSaleUnitId { get; set; }

    [Column("FK_ICProductPurchaseUnitID")]
    public int? FkIcproductPurchaseUnitId { get; set; }

    [StringLength(665)]
    public string LookupInfo { get; set; }

    [Column("ICMeasureUnitName")]
    [StringLength(50)]
    public string IcmeasureUnitName { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("ICProductNoOfOldSys")]
    [StringLength(100)]
    public string IcproductNoOfOldSys { get; set; }

    public bool? HasComponent { get; set; }

    [Column("FK_ICProductCarcassID")]
    public int? FkIcproductCarcassId { get; set; }

    [Column("FK_ACAccountID")]
    public int FkAcaccountId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("FK_ACDepreciationAccountID")]
    public int? FkAcdepreciationAccountId { get; set; }

    [Column("FK_ACAccountRevenueInternalID")]
    public int? FkAcaccountRevenueInternalId { get; set; }

    [Column("FK_ACAccountCostPriceID")]
    public int? FkAcaccountCostPriceId { get; set; }

    [Column("FK_ACAccountRevenueID")]
    public int? FkAcaccountRevenueId { get; set; }

    [Column("FK_ACAccountSaleReturnID")]
    public int? FkAcaccountSaleReturnId { get; set; }

    [Column("FK_ACAccountDiscountID")]
    public int? FkAcaccountDiscountId { get; set; }

    [Column("ICProductStockMaxDateFrom", TypeName = "datetime")]
    public DateTime? IcproductStockMaxDateFrom { get; set; }

    [Column("ICProductStockMaxDateTo", TypeName = "datetime")]
    public DateTime? IcproductStockMaxDateTo { get; set; }

    [Column("ICProductStockMax", TypeName = "decimal(18, 5)")]
    public decimal? IcproductStockMax { get; set; }

    [Column("ICProductVolume", TypeName = "decimal(18, 5)")]
    public decimal? IcproductVolume { get; set; }

    [Column("ICProductActiveCheck")]
    public bool IcproductActiveCheck { get; set; }

    [Column("ICProductDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDepreciationRate { get; set; }

    [Column("ICProductDepreciationQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDepreciationQty { get; set; }

    [Column("ICProductCheckCarcass")]
    public bool? IcproductCheckCarcass { get; set; }

    [Column("ICProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductLength { get; set; }

    [Column("ICProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductWidth { get; set; }

    [Column("ICProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductHeight { get; set; }

    [Column("ICProductBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBlock { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("ICProductIsFollowInventoryStock")]
    public bool? IcproductIsFollowInventoryStock { get; set; }

    [Column("ICPriceCalculationMethodMethod")]
    [StringLength(64)]
    public string IcpriceCalculationMethodMethod { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int? FkIcproductAttributeColorId { get; set; }

    [Column("ICProductParentNo")]
    [StringLength(50)]
    public string IcproductParentNo { get; set; }

    [Column("ICProductParentName")]
    [StringLength(256)]
    public string IcproductParentName { get; set; }

    [Column("ICProductConsumable", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConsumable { get; set; }

    [Column("ICProductCustomerNumber")]
    public string IcproductCustomerNumber { get; set; }

    [Column("FK_ICPerimeterGroupID")]
    public int? FkIcperimeterGroupId { get; set; }

    [Column("FK_ICLengthGroupID")]
    public int? FkIclengthGroupId { get; set; }

    [Column("FK_ICWidthGroupID")]
    public int? FkIcwidthGroupId { get; set; }

    [Column("ICProductUsingMethod")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductUsingMethod { get; set; }

    [Column("ICProductNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductNetWeight { get; set; }

    [Column("ICProductGrossWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductGrossWeight { get; set; }

    [Column("ICProductSizeAndSpecifiCations")]
    [StringLength(256)]
    public string IcproductSizeAndSpecifiCations { get; set; }

    [Column("ICProductOriginOfProduct")]
    [StringLength(256)]
    public string IcproductOriginOfProduct { get; set; }

    [Column("ICProductImageFile")]
    [StringLength(524)]
    public string IcproductImageFile { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ICProductProductionComment")]
    [StringLength(512)]
    public string IcproductProductionComment { get; set; }

    [Column("ARCustomerName")]
    public string ArcustomerName { get; set; }

    [Column("ARCustomerNo")]
    public string ArcustomerNo { get; set; }
}
