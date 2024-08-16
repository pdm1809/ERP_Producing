using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProducts")]
public partial class Icproduct
{
    [Key]
    [Column("ICProductID")]
    public int IcproductId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_GEVATID")]
    public int? FkGevatid { get; set; }

    [Column("FK_ICProductBasicUnitID")]
    public int FkIcproductBasicUnitId { get; set; }

    [Column("FK_ICProductSaleUnitID")]
    public int? FkIcproductSaleUnitId { get; set; }

    [Column("FK_ICProductPurchaseUnitID")]
    public int? FkIcproductPurchaseUnitId { get; set; }

    [Column("ICProductAttributeKey")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductAttributeKey { get; set; }

    [Column("ICProductAttribute")]
    [StringLength(200)]
    public string IcproductAttribute { get; set; }

    [Column("ICProductAttributeNo")]
    [StringLength(50)]
    public string IcproductAttributeNo { get; set; }

    [Column("ICProductSupplierPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSupplierPrice { get; set; }

    [Column("ICProductSupplierNumber")]
    [StringLength(50)]
    public string IcproductSupplierNumber { get; set; }

    [Required]
    [Column("ICProductNo")]
    [StringLength(50)]
    public string IcproductNo { get; set; }

    [Required]
    [Column("ICProductName")]
    [StringLength(256)]
    public string IcproductName { get; set; }

    [Required]
    [Column("ICProductDesc")]
    [StringLength(512)]
    public string IcproductDesc { get; set; }

    [Column("ICProductActiveCheck")]
    public bool IcproductActiveCheck { get; set; }

    [Column("ICProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductLength { get; set; }

    [Column("ICProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductHeight { get; set; }

    [Column("ICProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductWidth { get; set; }

    [Column("ICProductWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductWeight { get; set; }

    [Column("ICProductBarCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductBarCode { get; set; }

    [Column("ICProductStockMin", TypeName = "decimal(18, 5)")]
    public decimal? IcproductStockMin { get; set; }

    [Column("ICProductStockMinDateFrom", TypeName = "datetime")]
    public DateTime? IcproductStockMinDateFrom { get; set; }

    [Column("ICProductStockMinDateTo", TypeName = "datetime")]
    public DateTime? IcproductStockMinDateTo { get; set; }

    [Column("ICProductStockMax", TypeName = "decimal(18, 5)")]
    public decimal? IcproductStockMax { get; set; }

    [Column("ICProductStockMaxDateFrom", TypeName = "datetime")]
    public DateTime? IcproductStockMaxDateFrom { get; set; }

    [Column("ICProductStockMaxDateTo", TypeName = "datetime")]
    public DateTime? IcproductStockMaxDateTo { get; set; }

    [Column("ICProductPicture")]
    public byte[] IcproductPicture { get; set; }

    [Column("ICProductPrice01", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPrice01 { get; set; }

    [Required]
    [Column("ICProductType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductType { get; set; }

    public bool? HasComponent { get; set; }

    [Column("ICProductModelNo")]
    [StringLength(50)]
    public string IcproductModelNo { get; set; }

    [Column("ICProductGuaranteeTerm")]
    [StringLength(512)]
    public string IcproductGuaranteeTerm { get; set; }

    [Column("ICProductGuaranteeMonths")]
    public int? IcproductGuaranteeMonths { get; set; }

    [Column("ICProductDepreciationMethod")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductDepreciationMethod { get; set; }

    [Column("ICProductDepreciationMonths")]
    public int? IcproductDepreciationMonths { get; set; }

    [Column("ICProductComment")]
    [StringLength(512)]
    public string IcproductComment { get; set; }

    [Column("FK_ACAccountID")]
    public int FkAcaccountId { get; set; }

    [Column("ICProductHavePaint")]
    public bool? IcproductHavePaint { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("ICProductCheckCarcass")]
    public bool? IcproductCheckCarcass { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int? FkIcproductAttributeColorId { get; set; }

    [Column("ICProductPaintNoOfManufacture")]
    [StringLength(100)]
    public string IcproductPaintNoOfManufacture { get; set; }

    [Column("FK_ICProductAttributeFinishingID")]
    public int? FkIcproductAttributeFinishingId { get; set; }

    [Column("ICProductJoinery")]
    [StringLength(50)]
    public string IcproductJoinery { get; set; }

    [Column("ICProductSizeAndSpecifiCations")]
    [StringLength(256)]
    public string IcproductSizeAndSpecifiCations { get; set; }

    [Column("ICProductPurchaseType")]
    [StringLength(50)]
    public string IcproductPurchaseType { get; set; }

    [Column("ICProductCode")]
    [StringLength(50)]
    public string IcproductCode { get; set; }

    [Column("ICProductNoOfOldSys")]
    [StringLength(100)]
    public string IcproductNoOfOldSys { get; set; }

    [Column("ICProductCustomerNumber")]
    [StringLength(50)]
    public string IcproductCustomerNumber { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductGroupParentID")]
    public int? FkIcproductGroupParentId { get; set; }

    [Column("ICProductName2")]
    [StringLength(256)]
    public string IcproductName2 { get; set; }

    [Column("ICProductWoodTypeAttribute")]
    [StringLength(512)]
    public string IcproductWoodTypeAttribute { get; set; }

    [Column("ICProductColorAttribute")]
    [StringLength(512)]
    public string IcproductColorAttribute { get; set; }

    [Column("FK_ICProdAttPackingMaterialSpecialityID")]
    public int? FkIcprodAttPackingMaterialSpecialityId { get; set; }

    [Column("FK_ICProdAttPackingMaterialSizeID")]
    public int? FkIcprodAttPackingMaterialSizeId { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [Column("FK_ICProductAttributeSemiProductSpecialityID")]
    public int? FkIcproductAttributeSemiProductSpecialityId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("ICProductOriginalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductOriginalAmount { get; set; }

    [Column("ICProductDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDepreciatedAmount { get; set; }

    [Column("FK_ACDepreciationAccountID")]
    public int? FkAcdepreciationAccountId { get; set; }

    [Column("ICProductAttributeFinishing")]
    [StringLength(50)]
    public string IcproductAttributeFinishing { get; set; }

    [Column("ICProductAttributeFinishingText")]
    [StringLength(512)]
    public string IcproductAttributeFinishingText { get; set; }

    [Column("ICProductWoodGroup")]
    [StringLength(50)]
    public string IcproductWoodGroup { get; set; }

    [Column("FK_ICProductWorkGroupID")]
    public int? FkIcproductWorkGroupId { get; set; }

    [Column("ICProductWorkType")]
    [StringLength(50)]
    public string IcproductWorkType { get; set; }

    [Column("ICProductWorkUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductWorkUnitPrice { get; set; }

    [Column("ICProductMaterialUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductMaterialUnitPrice { get; set; }

    [Column("ICProductEquipmentUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductEquipmentUnitPrice { get; set; }

    [Column("ICProductOriginOfProduct")]
    [StringLength(256)]
    public string IcproductOriginOfProduct { get; set; }

    [Column("ICProductChargeCheck")]
    public bool? IcproductChargeCheck { get; set; }

    [Column("ICProductLockedPurchaseOrder")]
    public bool? IcproductLockedPurchaseOrder { get; set; }

    [Column("ICProductMinLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductMinLength { get; set; }

    [Column("ICProductMaxHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductMaxHeight { get; set; }

    [Column("ICProductTargetType")]
    [StringLength(50)]
    public string IcproductTargetType { get; set; }

    [Column("ICProductOrigin")]
    [StringLength(100)]
    public string IcproductOrigin { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("ICProductOtherSize")]
    [StringLength(256)]
    public string IcproductOtherSize { get; set; }

    [Column("ICProductImageFileName")]
    [StringLength(50)]
    public string IcproductImageFileName { get; set; }

    [Column("FK_ICProductParentID")]
    public int? FkIcproductParentId { get; set; }

    [Column("ICProductFixedNorm")]
    public bool? IcproductFixedNorm { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

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

    [Column("ICProductLicensePlate")]
    [StringLength(100)]
    public string IcproductLicensePlate { get; set; }

    [Column("ICProductBulk", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBulk { get; set; }

    [Column("ICProductCapacity", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCapacity { get; set; }

    [Column("ICProductDepth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDepth { get; set; }

    [Column("ICProductRadius", TypeName = "decimal(18, 5)")]
    public decimal? IcproductRadius { get; set; }

    [Column("ICProductDiameter", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDiameter { get; set; }

    [Column("ICProductThickness", TypeName = "decimal(18, 5)")]
    public decimal? IcproductThickness { get; set; }

    [Column("FK_ICProductGroupHeightID")]
    public int? FkIcproductGroupHeightId { get; set; }

    [Column("FK_ICProductFormulaPriceConfigID")]
    public int? FkIcproductFormulaPriceConfigId { get; set; }

    [Column("ICProductGuaranteeMonth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductGuaranteeMonth { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ICProductTemplateType")]
    [StringLength(50)]
    public string IcproductTemplateType { get; set; }

    [Column("ICProductPromotionCheck")]
    public bool? IcproductPromotionCheck { get; set; }

    [Column("FK_ICProductTypeAccountConfigID")]
    public int FkIcproductTypeAccountConfigId { get; set; }

    [Column("ICProductUses")]
    [StringLength(50)]
    public string IcproductUses { get; set; }

    [Column("ICProductNonRetail")]
    public bool? IcproductNonRetail { get; set; }

    [Column("ICProductIsShowWeb")]
    public bool? IcproductIsShowWeb { get; set; }

    [Column("ICProductTrademark")]
    [StringLength(50)]
    public string IcproductTrademark { get; set; }

    [Column("ICProductDepartmentGroup")]
    [StringLength(255)]
    public string IcproductDepartmentGroup { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_ACEquipmentTypeAccountConfigID")]
    public int? FkAcequipmentTypeAccountConfigId { get; set; }

    [Column("ICProductAlternativeCheck")]
    public bool? IcproductAlternativeCheck { get; set; }

    [Column("FK_ICPriceCalculationMethodID")]
    public int? FkIcpriceCalculationMethodId { get; set; }

    [Column("ICProductImageFile")]
    [StringLength(524)]
    public string IcproductImageFile { get; set; }

    [Column("ICProductBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBlock { get; set; }

    [Column("ICProductVolume", TypeName = "decimal(18, 5)")]
    public decimal? IcproductVolume { get; set; }

    [Column("ICProductImageName")]
    [StringLength(500)]
    public string IcproductImageName { get; set; }

    [Column("FK_MMFormulaIDPaintA")]
    public int? FkMmformulaIdpaintA { get; set; }

    [Column("FK_MMFormulaIDPaintB")]
    public int? FkMmformulaIdpaintB { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ICProductDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDepreciationRate { get; set; }

    [Column("ICProductDepreciationQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductDepreciationQty { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_MMFormulaIDPaintC")]
    public int? FkMmformulaIdpaintC { get; set; }

    [Column("ICProductCartonBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCartonBlock { get; set; }

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

    [Column("ICProductQtyInBox")]
    public int? IcproductQtyInBox { get; set; }

    [Column("ICProductNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductNetWeight { get; set; }

    [Column("ICProductGrossWeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductGrossWeight { get; set; }

    [Column("ICProductLeadTime", TypeName = "decimal(18, 5)")]
    public decimal? IcproductLeadTime { get; set; }

    [Column("ICProductBoxArea", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBoxArea { get; set; }

    [Column("ICProductBoxUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBoxUnitPrice { get; set; }

    [Column("FK_ICProductCarcassID")]
    public int? FkIcproductCarcassId { get; set; }

    [Column("FK_ICProductStockSaveID")]
    public int? FkIcproductStockSaveId { get; set; }

    [Column("ICProductStockSaveDate")]
    public int? IcproductStockSaveDate { get; set; }

    [Column("FK_ICPerimeterGroupID")]
    public int? FkIcperimeterGroupId { get; set; }

    [Column("FK_ICLengthGroupID")]
    public int? FkIclengthGroupId { get; set; }

    [Column("FK_ICStockGroupID")]
    public int? FkIcstockGroupId { get; set; }

    [Column("FK_ICProductWoodIngredientID")]
    public int? FkIcproductWoodIngredientId { get; set; }

    [Column("FK_MMProcessID")]
    public int? FkMmprocessId { get; set; }

    [Column("ICProductIsFollowInventoryStock")]
    public bool? IcproductIsFollowInventoryStock { get; set; }

    [Column("ICProductConsumable", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConsumable { get; set; }

    [Column("ICProductResourceType")]
    [StringLength(50)]
    public string IcproductResourceType { get; set; }

    [Column("FK_ICProductThickGroupID")]
    public int? FkIcproductThickGroupId { get; set; }

    [Column("ICProductStorageDay")]
    public int? IcproductStorageDay { get; set; }

    [Column("ICProductUsingMethod")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductUsingMethod { get; set; }

    [Column("ICProductCreateNumber")]
    public int? IcproductCreateNumber { get; set; }

    [Column("FK_ACAccountRevenueHinterLandID")]
    public int? FkAcaccountRevenueHinterLandId { get; set; }

    [Column("ICProductContType")]
    [StringLength(50)]
    public string IcproductContType { get; set; }

    [Column("ICProductInRadius", TypeName = "decimal(18, 5)")]
    public decimal? IcproductInRadius { get; set; }

    [Column("ICProductInDiameter", TypeName = "decimal(18, 5)")]
    public decimal? IcproductInDiameter { get; set; }

    [Column("ICProductWarping", TypeName = "decimal(18, 5)")]
    public decimal? IcproductWarping { get; set; }

    [Column("ICProductNumberSign")]
    [StringLength(50)]
    public string IcproductNumberSign { get; set; }

    [Column("ICProductIsInventory")]
    public bool? IcproductIsInventory { get; set; }

    [Column("ICProductProductionComment")]
    [StringLength(512)]
    public string IcproductProductionComment { get; set; }

    [Column("ICProductPackagingDetail")]
    [StringLength(512)]
    public string IcproductPackagingDetail { get; set; }

    [Column("ICProductStorageCondition")]
    [StringLength(1000)]
    public string IcproductStorageCondition { get; set; }

    [Column("ICProductExpiryDay", TypeName = "decimal(18, 5)")]
    public decimal? IcproductExpiryDay { get; set; }

    [Column("FK_ICWidthGroupID")]
    public int? FkIcwidthGroupId { get; set; }

    [Column("ICProductCollection")]
    [StringLength(100)]
    public string IcproductCollection { get; set; }

    [Column("ICProductPackagingDetailEnglish")]
    [StringLength(256)]
    public string IcproductPackagingDetailEnglish { get; set; }

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<Acdevice> Acdevices { get; set; } = new List<Acdevice>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcretailVatitem> AcretailVatitems { get; set; } = new List<AcretailVatitem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AcstopAllocationEquipment> AcstopAllocationEquipments { get; set; } = new List<AcstopAllocationEquipment>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApallocationCostItem> ApallocationCostItems { get; set; } = new List<ApallocationCostItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApbillOfLadingItem> ApbillOfLadingItems { get; set; } = new List<ApbillOfLadingItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkIcproductEquipments { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkIcproductForBatches { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItemFkIcproducts { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApfeePaymentItem> ApfeePaymentItems { get; set; } = new List<ApfeePaymentItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApinvoiceInPackageItemDetail> ApinvoiceInPackageItemDetails { get; set; } = new List<ApinvoiceInPackageItemDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AppopackageItemDetail> AppopackageItemDetails { get; set; } = new List<AppopackageItemDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AppopackageItem> AppopackageItems { get; set; } = new List<AppopackageItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AppriceSheetItem> AppriceSheetItems { get; set; } = new List<AppriceSheetItem>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkIcproductEquipments { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkIcproductForBatches { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApproposalItem> ApproposalItemFkIcproducts { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkIcproductEquipments { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkIcproductForBatches { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotalFkIcproducts { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AppurchaseOrderItemDelivery> AppurchaseOrderItemDeliveries { get; set; } = new List<AppurchaseOrderItemDelivery>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItemFkIcproductEquipments { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItemFkIcproducts { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AppurchaseOrderItemOutSourcing> AppurchaseOrderItemOutSourcings { get; set; } = new List<AppurchaseOrderItemOutSourcing>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApsupplierProductDiscount> ApsupplierProductDiscounts { get; set; } = new List<ApsupplierProductDiscount>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ApsupplierProductNumber> ApsupplierProductNumbers { get; set; } = new List<ApsupplierProductNumber>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AracceptanceItem> AracceptanceItemFkIcproducts { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkIcsectionProduct")]
    public virtual ICollection<AracceptanceItem> AracceptanceItemFkIcsectionProducts { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AracceptanceItemWork> AracceptanceItemWorks { get; set; } = new List<AracceptanceItemWork>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<AradjustSaleOrderQuantityItem> AradjustSaleOrderQuantityItems { get; set; } = new List<AradjustSaleOrderQuantityItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArallocationItem> ArallocationItems { get; set; } = new List<ArallocationItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcancelSaleForecastItem> ArcancelSaleForecastItems { get; set; } = new List<ArcancelSaleForecastItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; } = new List<ArcancelVoucherItemCost>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcancelVoucherItem> ArcancelVoucherItems { get; set; } = new List<ArcancelVoucherItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcanceledDeliveryPlanItem> ArcanceledDeliveryPlanItems { get; set; } = new List<ArcanceledDeliveryPlanItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetailFkIcproductForBatches { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetailFkIcproducts { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcreditNoteItem> ArcreditNoteItems { get; set; } = new List<ArcreditNoteItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcustomerProductDiscount> ArcustomerProductDiscounts { get; set; } = new List<ArcustomerProductDiscount>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArcustomerProductNumber> ArcustomerProductNumbers { get; set; } = new List<ArcustomerProductNumber>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItemFkIcproducts { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIcsectionProduct")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItemFkIcsectionProducts { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; } = new List<ArdeliveryPlanMachineDevice>();

    [InverseProperty("FkIcproductTruck")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItemFkIcproductTrucks { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItemFkIcproducts { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkIcproductTruck")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTrucks { get; set; } = new List<ArdeliveryPlanTruck>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArdeliveryPlanWorkAsset> ArdeliveryPlanWorkAssets { get; set; } = new List<ArdeliveryPlanWorkAsset>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArdeliveryPlanWork> ArdeliveryPlanWorks { get; set; } = new List<ArdeliveryPlanWork>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArdiscountProgramItem> ArdiscountProgramItems { get; set; } = new List<ArdiscountProgramItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArinvoiceItemComponent> ArinvoiceItemComponents { get; set; } = new List<ArinvoiceItemComponent>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItemFkIcproductEquipments { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItemFkIcproducts { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcsectionProduct")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItemFkIcsectionProducts { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArinvoiceItemPackage> ArinvoiceItemPackages { get; set; } = new List<ArinvoiceItemPackage>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArinvoiceItemWork> ArinvoiceItemWorks { get; set; } = new List<ArinvoiceItemWork>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArpriceSheetItemWork> ArpriceSheetItemWorks { get; set; } = new List<ArpriceSheetItemWork>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArpriceSheetItem> ArpriceSheetItems { get; set; } = new List<ArpriceSheetItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArproposalAreaItem> ArproposalAreaItems { get; set; } = new List<ArproposalAreaItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArproposalArea> ArproposalAreas { get; set; } = new List<ArproposalArea>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArproposalItem> ArproposalItemFkIcproducts { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcsectionProduct")]
    public virtual ICollection<ArproposalItem> ArproposalItemFkIcsectionProducts { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArproposalItemWorkItem> ArproposalItemWorkItems { get; set; } = new List<ArproposalItemWorkItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; } = new List<ArproposalItemWorkTask>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArproposalItemWork> ArproposalItemWorks { get; set; } = new List<ArproposalItemWork>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArproposalTemplateItem> ArproposalTemplateItems { get; set; } = new List<ArproposalTemplateItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArreceptionItem> ArreceptionItems { get; set; } = new List<ArreceptionItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleForecastItem> ArsaleForecastItems { get; set; } = new List<ArsaleForecastItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleOrderItemAllocationFee> ArsaleOrderItemAllocationFees { get; set; } = new List<ArsaleOrderItemAllocationFee>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItemFkIcproductEquipments { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItemFkIcproducts { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcsectionProduct")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItemFkIcsectionProducts { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleOrderItemWorkItem> ArsaleOrderItemWorkItems { get; set; } = new List<ArsaleOrderItemWorkItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleOrderItemWork> ArsaleOrderItemWorks { get; set; } = new List<ArsaleOrderItemWork>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleReturnItemComponent> ArsaleReturnItemComponents { get; set; } = new List<ArsaleReturnItemComponent>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [InverseProperty("Icproduct")]
    public virtual ICollection<ArsellerProduct> ArsellerProducts { get; set; } = new List<ArsellerProduct>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsfitemComponent> ArsfitemComponents { get; set; } = new List<ArsfitemComponent>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<ArsoitemComponent> ArsoitemComponents { get; set; } = new List<ArsoitemComponent>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<Brpositem> Brpositems { get; set; } = new List<Brpositem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<BrposredemptionItem> BrposredemptionItems { get; set; } = new List<BrposredemptionItem>();

    [InverseProperty("FaproductIdcomboNavigation")]
    public virtual ICollection<FacreditNoteItem> FacreditNoteItems { get; set; } = new List<FacreditNoteItem>();

    [InverseProperty("FaproductIdcomboNavigation")]
    public virtual ICollection<FaproposalItem> FaproposalItems { get; set; } = new List<FaproposalItem>();

    [InverseProperty("FaproductIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrderItem> FapurchaseOrderItems { get; set; } = new List<FapurchaseOrderItem>();

    [InverseProperty("FaproductIdcomboNavigation")]
    public virtual ICollection<FareturnSupplierItem> FareturnSupplierItems { get; set; } = new List<FareturnSupplierItem>();

    [InverseProperty("FaproductIdcomboNavigation")]
    public virtual ICollection<FasellReturnItem> FasellReturnItems { get; set; } = new List<FasellReturnItem>();

    [InverseProperty("FaproductIdcomboNavigation")]
    public virtual ICollection<FatransferStockInItem> FatransferStockInItems { get; set; } = new List<FatransferStockInItem>();

    [InverseProperty("FaproductIdcomboNavigation")]
    public virtual ICollection<FatransferStockOutItem> FatransferStockOutItems { get; set; } = new List<FatransferStockOutItem>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("IcproductFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcaccountCostPriceId")]
    [InverseProperty("IcproductFkAcaccountCostPrices")]
    public virtual Acaccount FkAcaccountCostPrice { get; set; }

    [ForeignKey("FkAcaccountDiscountId")]
    [InverseProperty("IcproductFkAcaccountDiscounts")]
    public virtual Acaccount FkAcaccountDiscount { get; set; }

    [ForeignKey("FkAcaccountRevenueId")]
    [InverseProperty("IcproductFkAcaccountRevenues")]
    public virtual Acaccount FkAcaccountRevenue { get; set; }

    [ForeignKey("FkAcaccountRevenueHinterLandId")]
    [InverseProperty("IcproductFkAcaccountRevenueHinterLands")]
    public virtual Acaccount FkAcaccountRevenueHinterLand { get; set; }

    [ForeignKey("FkAcaccountRevenueInternalId")]
    [InverseProperty("IcproductFkAcaccountRevenueInternals")]
    public virtual Acaccount FkAcaccountRevenueInternal { get; set; }

    [ForeignKey("FkAcaccountSaleReturnId")]
    [InverseProperty("IcproductFkAcaccountSaleReturns")]
    public virtual Acaccount FkAcaccountSaleReturn { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("Icproducts")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdepreciationAccountId")]
    [InverseProperty("IcproductFkAcdepreciationAccounts")]
    public virtual Acaccount FkAcdepreciationAccount { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("IcproductFkAcdepreciationCostAccounts")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [ForeignKey("FkAcequipmentTypeAccountConfigId")]
    [InverseProperty("Icproducts")]
    public virtual AcequipmentTypeAccountConfig FkAcequipmentTypeAccountConfig { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("Icproducts")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("Icproducts")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Icproducts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("Icproducts")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGevatid")]
    [InverseProperty("Icproducts")]
    public virtual Gevat FkGevat { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("Icproducts")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIclengthGroupId")]
    [InverseProperty("Icproducts")]
    public virtual IclengthGroup FkIclengthGroup { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("Icproducts")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcperimeterGroupId")]
    [InverseProperty("Icproducts")]
    public virtual IcperimeterGroup FkIcperimeterGroup { get; set; }

    [ForeignKey("FkIcpriceCalculationMethodId")]
    [InverseProperty("Icproducts")]
    public virtual IcpriceCalculationMethod FkIcpriceCalculationMethod { get; set; }

    [ForeignKey("FkIcprodAttPackingMaterialSizeId")]
    [InverseProperty("IcproductFkIcprodAttPackingMaterialSizes")]
    public virtual IcproductAttribute FkIcprodAttPackingMaterialSize { get; set; }

    [ForeignKey("FkIcprodAttPackingMaterialSpecialityId")]
    [InverseProperty("IcproductFkIcprodAttPackingMaterialSpecialities")]
    public virtual IcproductAttribute FkIcprodAttPackingMaterialSpeciality { get; set; }

    [ForeignKey("FkIcprodAttPackingMaterialWeightPerVolumeId")]
    [InverseProperty("IcproductFkIcprodAttPackingMaterialWeightPerVolumes")]
    public virtual IcproductAttribute FkIcprodAttPackingMaterialWeightPerVolume { get; set; }

    [ForeignKey("FkIcproductAttributeColorId")]
    [InverseProperty("IcproductFkIcproductAttributeColors")]
    public virtual IcproductAttribute FkIcproductAttributeColor { get; set; }

    [ForeignKey("FkIcproductAttributeFinishingId")]
    [InverseProperty("IcproductFkIcproductAttributeFinishings")]
    public virtual IcproductAttribute FkIcproductAttributeFinishing { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcproductFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeSemiProductSpecialityId")]
    [InverseProperty("IcproductFkIcproductAttributeSemiProductSpecialities")]
    public virtual IcproductAttribute FkIcproductAttributeSemiProductSpeciality { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcproductFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductBasicUnitId")]
    [InverseProperty("IcproductFkIcproductBasicUnits")]
    public virtual IcmeasureUnit FkIcproductBasicUnit { get; set; }

    [ForeignKey("FkIcproductCarcassId")]
    [InverseProperty("InverseFkIcproductCarcass")]
    public virtual Icproduct FkIcproductCarcass { get; set; }

    [ForeignKey("FkIcproductFormulaPriceConfigId")]
    [InverseProperty("Icproducts")]
    public virtual IcproductFormulaPriceConfig FkIcproductFormulaPriceConfig { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("Icproducts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductGroupHeightId")]
    [InverseProperty("Icproducts")]
    public virtual IcproductGroupHeight FkIcproductGroupHeight { get; set; }

    [ForeignKey("FkIcproductParentId")]
    [InverseProperty("InverseFkIcproductParent")]
    public virtual Icproduct FkIcproductParent { get; set; }

    [ForeignKey("FkIcproductPurchaseUnitId")]
    [InverseProperty("IcproductFkIcproductPurchaseUnits")]
    public virtual IcmeasureUnit FkIcproductPurchaseUnit { get; set; }

    [ForeignKey("FkIcproductSaleUnitId")]
    [InverseProperty("IcproductFkIcproductSaleUnits")]
    public virtual IcmeasureUnit FkIcproductSaleUnit { get; set; }

    [ForeignKey("FkIcproductThickGroupId")]
    [InverseProperty("IcproductFkIcproductThickGroups")]
    public virtual IcproductAttribute FkIcproductThickGroup { get; set; }

    [ForeignKey("FkIcproductTypeAccountConfigId")]
    [InverseProperty("Icproducts")]
    public virtual IcproductTypeAccountConfig FkIcproductTypeAccountConfig { get; set; }

    [ForeignKey("FkIcwidthGroupId")]
    [InverseProperty("Icproducts")]
    public virtual IcwidthGroup FkIcwidthGroup { get; set; }

    [ForeignKey("FkMmprocessId")]
    [InverseProperty("Icproducts")]
    public virtual Mmprocesss FkMmprocess { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("Icproducts")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<HrdormitoryItem> HrdormitoryItems { get; set; } = new List<HrdormitoryItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<HremployeePieceWork> HremployeePieceWorks { get; set; } = new List<HremployeePieceWork>();

    [InverseProperty("FkIcproductIdforBatchNavigation")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItemFkIcproductIdforBatchNavigations { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItemFkIcproducts { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcadjustmentItem> IcadjustmentItems { get; set; } = new List<IcadjustmentItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcassembleProductDetail> IcassembleProductDetails { get; set; } = new List<IcassembleProductDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcassembleProduct> IcassembleProducts { get; set; } = new List<IcassembleProduct>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcaverageCost> IcaverageCosts { get; set; } = new List<IcaverageCost>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcbarcodeItem> IcbarcodeItems { get; set; } = new List<IcbarcodeItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IccollectionItem> IccollectionItems { get; set; } = new List<IccollectionItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcdisassembleProductDetail> IcdisassembleProductDetails { get; set; } = new List<IcdisassembleProductDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcdisassembleProduct> IcdisassembleProducts { get; set; } = new List<IcdisassembleProduct>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcimportStockMinMax> IcimportStockMinMaxes { get; set; } = new List<IcimportStockMinMax>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinitializedInventoryStock> IcinitializedInventoryStocks { get; set; } = new List<IcinitializedInventoryStock>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinvAdjustment> IcinvAdjustments { get; set; } = new List<IcinvAdjustment>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinventoryItemPackage> IcinventoryItemPackages { get; set; } = new List<IcinventoryItemPackage>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinventoryPackage> IcinventoryPackages { get; set; } = new List<IcinventoryPackage>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinventoryStockCountItem> IcinventoryStockCountItems { get; set; } = new List<IcinventoryStockCountItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinventoryStockSerial> IcinventoryStockSerials { get; set; } = new List<IcinventoryStockSerial>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinventoryStockSlotSeries> IcinventoryStockSlotSeries { get; set; } = new List<IcinventoryStockSlotSeries>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinventoryStockSlot> IcinventoryStockSlots { get; set; } = new List<IcinventoryStockSlot>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcinventoryStock> IcinventoryStocks { get; set; } = new List<IcinventoryStock>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcmachineGroup> IcmachineGroups { get; set; } = new List<IcmachineGroup>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcmaterialConfig> IcmaterialConfigs { get; set; } = new List<IcmaterialConfig>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcpackageProduct> IcpackageProducts { get; set; } = new List<IcpackageProduct>();

    [InverseProperty("FkIcproductParent")]
    public virtual ICollection<IcpackagingNormItem> IcpackagingNormItemFkIcproductParents { get; set; } = new List<IcpackagingNormItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcpackagingNormItem> IcpackagingNormItemFkIcproducts { get; set; } = new List<IcpackagingNormItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; } = new List<IcpriceAdjustmentItem>();

    [InverseProperty("FkIcproductAlternativeChild")]
    public virtual ICollection<IcproductAlternative> IcproductAlternativeFkIcproductAlternativeChildren { get; set; } = new List<IcproductAlternative>();

    [InverseProperty("FkIcproductAlternativeParent")]
    public virtual ICollection<IcproductAlternative> IcproductAlternativeFkIcproductAlternativeParents { get; set; } = new List<IcproductAlternative>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductApplyPriceItem> IcproductApplyPriceItems { get; set; } = new List<IcproductApplyPriceItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductBranchPrice> IcproductBranchPrices { get; set; } = new List<IcproductBranchPrice>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductBranch> IcproductBranches { get; set; } = new List<IcproductBranch>();

    [InverseProperty("FkIcproductComponentChild")]
    public virtual ICollection<IcproductComponent> IcproductComponentFkIcproductComponentChildren { get; set; } = new List<IcproductComponent>();

    [InverseProperty("FkIcproductComponentParent")]
    public virtual ICollection<IcproductComponent> IcproductComponentFkIcproductComponentParents { get; set; } = new List<IcproductComponent>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductConfigRate> IcproductConfigRates { get; set; } = new List<IcproductConfigRate>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductContainerDetail> IcproductContainerDetails { get; set; } = new List<IcproductContainerDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductConversionItem> IcproductConversionItems { get; set; } = new List<IcproductConversionItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductCriteriaItem> IcproductCriteriaItems { get; set; } = new List<IcproductCriteriaItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductCustomerPrice> IcproductCustomerPrices { get; set; } = new List<IcproductCustomerPrice>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductCustomer> IcproductCustomers { get; set; } = new List<IcproductCustomer>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductDesc> IcproductDescs { get; set; } = new List<IcproductDesc>();

    [InverseProperty("FkIcproductParent")]
    public virtual ICollection<IcproductDetail> IcproductDetailFkIcproductParents { get; set; } = new List<IcproductDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductDetail> IcproductDetailFkIcproducts { get; set; } = new List<IcproductDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductDiscount> IcproductDiscounts { get; set; } = new List<IcproductDiscount>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductFile> IcproductFiles { get; set; } = new List<IcproductFile>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkIcproductCarcass")]
    public virtual ICollection<IcproductItem> IcproductItemFkIcproductCarcasses { get; set; } = new List<IcproductItem>();

    [InverseProperty("FkIcproductItemChild")]
    public virtual ICollection<IcproductItem> IcproductItemFkIcproductItemChildren { get; set; } = new List<IcproductItem>();

    [InverseProperty("FkIcproductItemParent")]
    public virtual ICollection<IcproductItem> IcproductItemFkIcproductItemParents { get; set; } = new List<IcproductItem>();

    [InverseProperty("FkIcproductCarcass")]
    public virtual ICollection<IcproductItemMaterial> IcproductItemMaterialFkIcproductCarcasses { get; set; } = new List<IcproductItemMaterial>();

    [InverseProperty("FkIcproductMaterial")]
    public virtual ICollection<IcproductItemMaterial> IcproductItemMaterialFkIcproductMaterials { get; set; } = new List<IcproductItemMaterial>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductItemMaterial> IcproductItemMaterialFkIcproducts { get; set; } = new List<IcproductItemMaterial>();

    [InverseProperty("FkIcproductCarcass")]
    public virtual ICollection<IcproductItemProcesss> IcproductItemProcesssFkIcproductCarcasses { get; set; } = new List<IcproductItemProcesss>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductItemProcesss> IcproductItemProcesssFkIcproducts { get; set; } = new List<IcproductItemProcesss>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductMeasureUnit> IcproductMeasureUnits { get; set; } = new List<IcproductMeasureUnit>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductOperation> IcproductOperations { get; set; } = new List<IcproductOperation>();

    [InverseProperty("FkIcproductOutsourcingChild")]
    public virtual ICollection<IcproductOutsourcing> IcproductOutsourcingFkIcproductOutsourcingChildren { get; set; } = new List<IcproductOutsourcing>();

    [InverseProperty("FkIcproductOutsourcingParent")]
    public virtual ICollection<IcproductOutsourcing> IcproductOutsourcingFkIcproductOutsourcingParents { get; set; } = new List<IcproductOutsourcing>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductPackageItemDetail> IcproductPackageItemDetails { get; set; } = new List<IcproductPackageItemDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductPackage> IcproductPackages { get; set; } = new List<IcproductPackage>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductPackingDetail> IcproductPackingDetails { get; set; } = new List<IcproductPackingDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductPrice> IcproductPrices { get; set; } = new List<IcproductPrice>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductProductAttribute> IcproductProductAttributes { get; set; } = new List<IcproductProductAttribute>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductProfile> IcproductProfiles { get; set; } = new List<IcproductProfile>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductSerialNumber> IcproductSerialNumbers { get; set; } = new List<IcproductSerialNumber>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<IcproductSeries> IcproductSeriesFkIcproductForBatches { get; set; } = new List<IcproductSeries>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductSeries> IcproductSeriesFkIcproducts { get; set; } = new List<IcproductSeries>();

    [InverseProperty("FkIcproductSubChild")]
    public virtual ICollection<IcproductSub> IcproductSubFkIcproductSubChildren { get; set; } = new List<IcproductSub>();

    [InverseProperty("FkIcproductSubParent")]
    public virtual ICollection<IcproductSub> IcproductSubFkIcproductSubParents { get; set; } = new List<IcproductSub>();

    [InverseProperty("FkIcproductSubplementChild")]
    public virtual ICollection<IcproductSubplement> IcproductSubplementFkIcproductSubplementChildren { get; set; } = new List<IcproductSubplement>();

    [InverseProperty("FkIcproductSubplementParent")]
    public virtual ICollection<IcproductSubplement> IcproductSubplementFkIcproductSubplementParents { get; set; } = new List<IcproductSubplement>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductSupplier> IcproductSuppliers { get; set; } = new List<IcproductSupplier>();

    [InverseProperty("FkIcproductParent")]
    public virtual ICollection<IcproductTask> IcproductTaskFkIcproductParents { get; set; } = new List<IcproductTask>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductTask> IcproductTaskFkIcproducts { get; set; } = new List<IcproductTask>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductTemplateItem> IcproductTemplateItems { get; set; } = new List<IcproductTemplateItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductTemplate> IcproductTemplates { get; set; } = new List<IcproductTemplate>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductTolenrance> IcproductTolenrances { get; set; } = new List<IcproductTolenrance>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductUnit> IcproductUnits { get; set; } = new List<IcproductUnit>();

    [InverseProperty("FkIcproductWorkItemChild")]
    public virtual ICollection<IcproductWorkItem> IcproductWorkItemFkIcproductWorkItemChildren { get; set; } = new List<IcproductWorkItem>();

    [InverseProperty("FkIcproductWorkItemParent")]
    public virtual ICollection<IcproductWorkItem> IcproductWorkItemFkIcproductWorkItemParents { get; set; } = new List<IcproductWorkItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcproductWorkItem> IcproductWorkItemFkIcproducts { get; set; } = new List<IcproductWorkItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcpromotionItemDetail> IcpromotionItemDetails { get; set; } = new List<IcpromotionItemDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcpromotionItem> IcpromotionItems { get; set; } = new List<IcpromotionItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditemFkIcproductForBatches { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditemFkIcproducts { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcreceiptComponentItem> IcreceiptComponentItems { get; set; } = new List<IcreceiptComponentItem>();

    [InverseProperty("FkIcproductTransfer")]
    public virtual ICollection<Icreceipt> IcreceiptFkIcproductTransfers { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<Icreceipt> IcreceiptFkIcproducts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkIcproductEquipments { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkIcproductForBatches { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkIcproducts { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcreplaceProduct")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkIcreplaceProducts { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcsectionProduct")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkIcsectionProducts { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcreceiptPackageItemDetail> IcreceiptPackageItemDetails { get; set; } = new List<IcreceiptPackageItemDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcreceiptPackageItem> IcreceiptPackageItems { get; set; } = new List<IcreceiptPackageItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();

    [InverseProperty("FkIcproductTransfer")]
    public virtual ICollection<Icshipment> IcshipmentFkIcproductTransfers { get; set; } = new List<Icshipment>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<Icshipment> IcshipmentFkIcproducts { get; set; } = new List<Icshipment>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcshipmentItemComponent> IcshipmentItemComponents { get; set; } = new List<IcshipmentItemComponent>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkIcproductEquipments { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkIcproductForBatches { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkIcproducts { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcsectionProduct")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkIcsectionProducts { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcshipmentPackageItemDetail> IcshipmentPackageItemDetails { get; set; } = new List<IcshipmentPackageItemDetail>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItemFkIcproductEquipments { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItemFkIcproducts { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IcstockConfigRate> IcstockConfigRates { get; set; } = new List<IcstockConfigRate>();

    [InverseProperty("FkIcproductEquipment")]
    public virtual ICollection<IctransferItem> IctransferItemFkIcproductEquipments { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IctransferItem> IctransferItemFkIcproducts { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IctransferItemPackage> IctransferItemPackages { get; set; } = new List<IctransferItemPackage>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IctransferLogItem> IctransferLogItems { get; set; } = new List<IctransferLogItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItems { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIcproductCarcass")]
    public virtual ICollection<Icproduct> InverseFkIcproductCarcass { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductParent")]
    public virtual ICollection<Icproduct> InverseFkIcproductParent { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItemFkIcproductForBatches { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcproductWoodIngredient")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItemFkIcproductWoodIngredients { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItemFkIcproducts { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItemFkIcproductForBatches { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItemFkIcproducts { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchItemWood> MmbatchItemWoods { get; set; } = new List<MmbatchItemWood>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchProductInputItem> MmbatchProductInputItems { get; set; } = new List<MmbatchProductInputItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchProductItemOperationInfo> MmbatchProductItemOperationInfos { get; set; } = new List<MmbatchProductItemOperationInfo>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchProductItemOperation> MmbatchProductItemOperations { get; set; } = new List<MmbatchProductItemOperation>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItems { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkIcproductAlternative")]
    public virtual ICollection<MmbatchProductProductionNormItemEquipment> MmbatchProductProductionNormItemEquipmentFkIcproductAlternatives { get; set; } = new List<MmbatchProductProductionNormItemEquipment>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchProductProductionNormItemEquipment> MmbatchProductProductionNormItemEquipmentFkIcproducts { get; set; } = new List<MmbatchProductProductionNormItemEquipment>();

    [InverseProperty("FkIcproductAlternative")]
    public virtual ICollection<MmbatchProductProductionNormItemHardware> MmbatchProductProductionNormItemHardwareFkIcproductAlternatives { get; set; } = new List<MmbatchProductProductionNormItemHardware>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchProductProductionNormItemHardware> MmbatchProductProductionNormItemHardwareFkIcproducts { get; set; } = new List<MmbatchProductProductionNormItemHardware>();

    [InverseProperty("FkIcproductAlternative")]
    public virtual ICollection<MmbatchProductProductionNormItemMeterial> MmbatchProductProductionNormItemMeterialFkIcproductAlternatives { get; set; } = new List<MmbatchProductProductionNormItemMeterial>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchProductProductionNormItemMeterial> MmbatchProductProductionNormItemMeterialFkIcproducts { get; set; } = new List<MmbatchProductProductionNormItemMeterial>();

    [InverseProperty("FkIcproductCarcass")]
    public virtual ICollection<MmbatchProductProductionNormItemProcesss> MmbatchProductProductionNormItemProcesssFkIcproductCarcasses { get; set; } = new List<MmbatchProductProductionNormItemProcesss>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbatchProductProductionNormItemProcesss> MmbatchProductProductionNormItemProcesssFkIcproducts { get; set; } = new List<MmbatchProductProductionNormItemProcesss>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmbpoperationDepartment> MmbpoperationDepartments { get; set; } = new List<MmbpoperationDepartment>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmcalculatorProductionNormCost> MmcalculatorProductionNormCosts { get; set; } = new List<MmcalculatorProductionNormCost>();

    [InverseProperty("FkIcproductMaterial")]
    public virtual ICollection<MmcalculatorProductionNormItemMaterial> MmcalculatorProductionNormItemMaterials { get; set; } = new List<MmcalculatorProductionNormItemMaterial>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItemFkIcproductForBatches { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItemFkIcproducts { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkIcproductForBatches { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItemFkIcproducts { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmchangeBominformationItem> MmchangeBominformationItems { get; set; } = new List<MmchangeBominformationItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmchangeBominformation> MmchangeBominformations { get; set; } = new List<MmchangeBominformation>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmchangeDeliveryDateBatchProductItem> MmchangeDeliveryDateBatchProductItems { get; set; } = new List<MmchangeDeliveryDateBatchProductItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmconsumableConfig> MmconsumableConfigs { get; set; } = new List<MmconsumableConfig>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmexchangeMeasureUnitConfig> MmexchangeMeasureUnitConfigs { get; set; } = new List<MmexchangeMeasureUnitConfig>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmexecuteTimeConfig> MmexecuteTimeConfigs { get; set; } = new List<MmexecuteTimeConfig>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetailFkIcproductForBatches { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetailFkIcproducts { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmmergeBomchangeItemMaterialBomlog> MmmergeBomchangeItemMaterialBomlogs { get; set; } = new List<MmmergeBomchangeItemMaterialBomlog>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmmergeBomchangeItemMaterialBplog> MmmergeBomchangeItemMaterialBplogs { get; set; } = new List<MmmergeBomchangeItemMaterialBplog>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmmergeBomchangeItemProcessBomlog> MmmergeBomchangeItemProcessBomlogs { get; set; } = new List<MmmergeBomchangeItemProcessBomlog>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmmergeBomchangeItemProcessBplog> MmmergeBomchangeItemProcessBplogs { get; set; } = new List<MmmergeBomchangeItemProcessBplog>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItemFkIcproductForBatches { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItemFkIcproducts { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItemFkIcproductForBatches { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItemFkIcproducts { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmoperationDetailPlanItemChild> MmoperationDetailPlanItemChildFkIcproductForBatches { get; set; } = new List<MmoperationDetailPlanItemChild>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmoperationDetailPlanItemChild> MmoperationDetailPlanItemChildFkIcproducts { get; set; } = new List<MmoperationDetailPlanItemChild>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmoperationProduct> MmoperationProducts { get; set; } = new List<MmoperationProduct>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmpaintProcessesItem> MmpaintProcessesItems { get; set; } = new List<MmpaintProcessesItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmprintRouting> MmprintRoutingFkIcproductForBatches { get; set; } = new List<MmprintRouting>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmprintRouting> MmprintRoutingFkIcproducts { get; set; } = new List<MmprintRouting>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmprocessInfo> MmprocessInfos { get; set; } = new List<MmprocessInfo>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmprocessProduct> MmprocessProducts { get; set; } = new List<MmprocessProduct>();

    [InverseProperty("FkIcproductIdforBatchNavigation")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkIcproductIdforBatchNavigation")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; } = new List<MmproductionCostCalculationDetailCost>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();

    [InverseProperty("FkIcproductIdforBatchNavigation")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCostFkIcproductIdforBatchNavigations { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCostFkIcproducts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionCostFormulaProduct> MmproductionCostFormulaProducts { get; set; } = new List<MmproductionCostFormulaProduct>();

    [InverseProperty("FkIcproductIdforBatchNavigation")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionCostOverall> MmproductionCostOveralls { get; set; } = new List<MmproductionCostOverall>();

    [InverseProperty("FkIcproductAlternative")]
    public virtual ICollection<MmproductionNormItemEquipment> MmproductionNormItemEquipmentFkIcproductAlternatives { get; set; } = new List<MmproductionNormItemEquipment>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionNormItemEquipment> MmproductionNormItemEquipmentFkIcproducts { get; set; } = new List<MmproductionNormItemEquipment>();

    [InverseProperty("FkIcproductAlternative")]
    public virtual ICollection<MmproductionNormItemHardware> MmproductionNormItemHardwareFkIcproductAlternatives { get; set; } = new List<MmproductionNormItemHardware>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionNormItemHardware> MmproductionNormItemHardwareFkIcproducts { get; set; } = new List<MmproductionNormItemHardware>();

    [InverseProperty("FkIcproductAlternative")]
    public virtual ICollection<MmproductionNormItemMeterial> MmproductionNormItemMeterialFkIcproductAlternatives { get; set; } = new List<MmproductionNormItemMeterial>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionNormItemMeterial> MmproductionNormItemMeterialFkIcproducts { get; set; } = new List<MmproductionNormItemMeterial>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionNormItemOperation> MmproductionNormItemOperations { get; set; } = new List<MmproductionNormItemOperation>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproductionNorm> MmproductionNorms { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmproposalItem> MmproposalItems { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItemFkIcproductForBatches { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItemFkIcproducts { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkIcproductForBatches { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItemFkIcproducts { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkIcproductForBatches { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotalFkIcproducts { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmpurchasePlanTracking> MmpurchasePlanTrackingFkIcproducts { get; set; } = new List<MmpurchasePlanTracking>();

    [InverseProperty("FkIcsemiProduct")]
    public virtual ICollection<MmpurchasePlanTracking> MmpurchasePlanTrackingFkIcsemiProducts { get; set; } = new List<MmpurchasePlanTracking>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmsemiProductIngredientItem> MmsemiProductIngredientItems { get; set; } = new List<MmsemiProductIngredientItem>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetailFkIcproductForBatches { get; set; } = new List<MmwoodPlanItemDetail>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetailFkIcproducts { get; set; } = new List<MmwoodPlanItemDetail>();

    [InverseProperty("FkIcsemiProduct")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetailFkIcsemiProducts { get; set; } = new List<MmwoodPlanItemDetail>();

    [InverseProperty("FkIcproductForBatch")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItemFkIcproductForBatches { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkIcproductWoodIngredient")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItemFkIcproductWoodIngredients { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItemFkIcproducts { get; set; } = new List<MmwoodPlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmbuidingCommandItem> PmbuidingCommandItems { get; set; } = new List<PmbuidingCommandItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmbuidingProposalItem> PmbuidingProposalItems { get; set; } = new List<PmbuidingProposalItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmbuildingAllocationItem> PmbuildingAllocationItems { get; set; } = new List<PmbuildingAllocationItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmbuildingPlanItem> PmbuildingPlanItems { get; set; } = new List<PmbuildingPlanItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmprojectMaterialItem> PmprojectMaterialItems { get; set; } = new List<PmprojectMaterialItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmprojectNormItem> PmprojectNormItems { get; set; } = new List<PmprojectNormItem>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmprojectPhaseResource> PmprojectPhaseResources { get; set; } = new List<PmprojectPhaseResource>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmsaleWorkItem> PmsaleWorkItems { get; set; } = new List<PmsaleWorkItem>();

    [InverseProperty("FkIcproductWork")]
    public virtual ICollection<PmtemplateItemComponent> PmtemplateItemComponentFkIcproductWorks { get; set; } = new List<PmtemplateItemComponent>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmtemplateItemComponent> PmtemplateItemComponentFkIcproducts { get; set; } = new List<PmtemplateItemComponent>();

    [InverseProperty("FkIcproduct")]
    public virtual ICollection<PmtemplateItem> PmtemplateItems { get; set; } = new List<PmtemplateItem>();
}
