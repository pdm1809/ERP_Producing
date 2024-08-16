using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ImportProduct")]
public partial class ImportProduct1
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

    [Column("FK_ICProductGroupChild2ID")]
    [StringLength(50)]
    public string FkIcproductGroupChild2Id { get; set; }

    [Column("FK_ICProductGroupChild3ID")]
    [StringLength(50)]
    public string FkIcproductGroupChild3Id { get; set; }

    [Column("STT")]
    [StringLength(10)]
    public string Stt { get; set; }

    [Column("ICProductCustomerNumber")]
    [StringLength(100)]
    public string IcproductCustomerNumber { get; set; }

    [Column("ICProductName")]
    [StringLength(200)]
    public string IcproductName { get; set; }

    [Column("ICProductName2")]
    [StringLength(200)]
    public string IcproductName2 { get; set; }

    [Column("ICProductImageFile")]
    [StringLength(256)]
    public string IcproductImageFile { get; set; }

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

    [Column("ARCustomerNo")]
    [StringLength(50)]
    public string ArcustomerNo { get; set; }

    [Column("ICProductWorkType")]
    [StringLength(50)]
    public string IcproductWorkType { get; set; }

    [Column("ICProductOriginOfProduct")]
    [StringLength(50)]
    public string IcproductOriginOfProduct { get; set; }

    [Column("APSupplierNo")]
    [StringLength(50)]
    public string ApsupplierNo { get; set; }

    [Column("ICProductGuaranteeMonth")]
    [StringLength(50)]
    public string IcproductGuaranteeMonth { get; set; }

    [Column("ICProductTemplateType")]
    [StringLength(50)]
    public string IcproductTemplateType { get; set; }

    [Column("ICProductOrigin")]
    [StringLength(50)]
    public string IcproductOrigin { get; set; }

    [Column("FK_ICModelID")]
    [StringLength(50)]
    public string FkIcmodelId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    [StringLength(50)]
    public string FkIcproductAttributeWoodTypeId { get; set; }

    [StringLength(256)]
    public string WoodType { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    [StringLength(50)]
    public string FkIcproductAttributeColorId { get; set; }

    [StringLength(256)]
    public string AttributeColor { get; set; }

    [Column("ICProductPaintNoOfManufacture")]
    [StringLength(50)]
    public string IcproductPaintNoOfManufacture { get; set; }

    [Column("ICProductLength")]
    [StringLength(20)]
    public string IcproductLength { get; set; }

    [Column("ICProductWidth")]
    [StringLength(20)]
    public string IcproductWidth { get; set; }

    [Column("ICProductHeight")]
    [StringLength(20)]
    public string IcproductHeight { get; set; }

    [Column("ICProductDiameter")]
    [StringLength(20)]
    public string IcproductDiameter { get; set; }

    [Column("ICProductRadius")]
    [StringLength(20)]
    public string IcproductRadius { get; set; }

    [Column("ICProductDepth")]
    [StringLength(20)]
    public string IcproductDepth { get; set; }

    [Column("ICProductNetWeight")]
    [StringLength(20)]
    public string IcproductNetWeight { get; set; }

    [Column("ICProductGrossWeight")]
    [StringLength(20)]
    public string IcproductGrossWeight { get; set; }

    [Column("ICProductQtyInBox")]
    [StringLength(20)]
    public string IcproductQtyInBox { get; set; }

    [Column("ICProductBlock")]
    [StringLength(20)]
    public string IcproductBlock { get; set; }

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
}
