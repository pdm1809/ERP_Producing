using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ImportLumberProduct")]
public partial class ImportLumberProduct
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

    [Column("FK_ICProductBasicUnitID")]
    [StringLength(50)]
    public string FkIcproductBasicUnitId { get; set; }

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

    [Column("ICProductOriginOfProduct")]
    [StringLength(100)]
    public string IcproductOriginOfProduct { get; set; }

    [Column("ICProductUses")]
    [StringLength(50)]
    public string IcproductUses { get; set; }

    [Column("FK_GECountryID")]
    [StringLength(100)]
    public string FkGecountryId { get; set; }

    [Column("APSupplierNo")]
    [StringLength(50)]
    public string ApsupplierNo { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    [StringLength(50)]
    public string FkIcproductAttributeWoodTypeId { get; set; }

    [Column("ICProductType")]
    [StringLength(50)]
    public string IcproductType { get; set; }

    [Column("ICProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductHeight { get; set; }

    [Column("ICProductAttribute01")]
    [StringLength(50)]
    public string IcproductAttribute01 { get; set; }

    [Column("ICProductAttribute02")]
    [StringLength(50)]
    public string IcproductAttribute02 { get; set; }

    [Column("ICProductAttribute03")]
    [StringLength(50)]
    public string IcproductAttribute03 { get; set; }

    [Column("ICProductAttribute04")]
    [StringLength(50)]
    public string IcproductAttribute04 { get; set; }

    [Column("ICProductPurchaseType")]
    [StringLength(50)]
    public string IcproductPurchaseType { get; set; }

    [Column("ICProductPrice01")]
    [StringLength(20)]
    public string IcproductPrice01 { get; set; }

    [Column("ICProductSupplierPrice")]
    [StringLength(20)]
    public string IcproductSupplierPrice { get; set; }

    [Column("FK_GEVATID")]
    [StringLength(50)]
    public string FkGevatid { get; set; }

    [Column("FK_ICPriceCalculationMethodID")]
    [StringLength(20)]
    public string FkIcpriceCalculationMethodId { get; set; }

    [Column("ICProductIsFollowInventoryStock")]
    [StringLength(20)]
    public string IcproductIsFollowInventoryStock { get; set; }

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

    [Column("FK_ACAccountRevenueInternalID")]
    [StringLength(10)]
    public string FkAcaccountRevenueInternalId { get; set; }

    [Column("FK_ACAccountDiscountID")]
    [StringLength(10)]
    public string FkAcaccountDiscountId { get; set; }

    [Column("ICProductStockMin")]
    [StringLength(20)]
    public string IcproductStockMin { get; set; }

    [Column("ICProductStockMax")]
    [StringLength(20)]
    public string IcproductStockMax { get; set; }

    [Column("ICProductStockDay")]
    [StringLength(20)]
    public string IcproductStockDay { get; set; }

    [Column("ICProductExchangeUnit")]
    [StringLength(100)]
    public string IcproductExchangeUnit { get; set; }

    [Column("ICProductMeasureUnitFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcproductMeasureUnitFactor { get; set; }
}
