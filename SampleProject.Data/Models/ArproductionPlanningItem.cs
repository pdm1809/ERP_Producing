using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProductionPlanningItems")]
public partial class ArproductionPlanningItem
{
    [Key]
    [Column("ARProductionPlanningItemID")]
    public int ArproductionPlanningItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ARProductionPlanningID")]
    public int? FkArproductionPlanningId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARContainerLoaderID")]
    public int? FkArcontainerLoaderId { get; set; }

    [Column("ARProductionPlanningItemProductType")]
    [StringLength(50)]
    public string ArproductionPlanningItemProductType { get; set; }

    [Column("ARProductionPlanningItemProductAttribute")]
    [StringLength(200)]
    public string ArproductionPlanningItemProductAttribute { get; set; }

    [Column("ARProductionPlanningItemSortOrder")]
    public int? ArproductionPlanningItemSortOrder { get; set; }

    [Column("ARProductionPlanningItemProductName")]
    [StringLength(50)]
    public string ArproductionPlanningItemProductName { get; set; }

    [Column("ARProductionPlanningItemProductNo")]
    [StringLength(50)]
    public string ArproductionPlanningItemProductNo { get; set; }

    [Column("ARProductionPlanningItemProductDesc", TypeName = "ntext")]
    public string ArproductionPlanningItemProductDesc { get; set; }

    [Column("ARProductionPlanningItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductUnitPrice { get; set; }

    [Column("ARProductionPlanningItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductUnitCost { get; set; }

    [Column("ARProductionPlanningItemProductGroupDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductGroupDiscount { get; set; }

    [Column("ARProductionPlanningItemProductDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductDiscount { get; set; }

    [Column("ARProductionPlanningItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductTaxPercent { get; set; }

    [Column("ARProductionPlanningItemProductQtyOld", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductQtyOld { get; set; }

    [Column("ARProductionPlanningItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductQty { get; set; }

    [Column("ARProductionPlanningItemProductBasicQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductBasicQty { get; set; }

    [Column("ARProductionPlanningItemProductPakagingQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductPakagingQty { get; set; }

    [Column("ARProductionPlanningItemCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemCanceledQty { get; set; }

    [Column("ARProductionPlanningItemShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemShippedQty { get; set; }

    [Column("ARProductionPlanningItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemPrice { get; set; }

    [Column("ARProductionPlanningItemComment")]
    [StringLength(50)]
    public string ArproductionPlanningItemComment { get; set; }

    [Column("ARProductionPlanningItemUnitVolumn", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemUnitVolumn { get; set; }

    [Column("ARProductionPlanningItemUnitWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemUnitWeight { get; set; }

    [Column("ARProductionPlanningItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemTaxAmount { get; set; }

    [Column("ARProductionPlanningItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemDiscountAmount { get; set; }

    [Column("ARProductionPlanningItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemNetAmount { get; set; }

    [Column("ARProductionPlanningItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemTotalAmount { get; set; }

    [Column("ARProductionPlanningItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemTotalCost { get; set; }

    [Column("ARProductionPlanningItemDeliveryDate", TypeName = "datetime")]
    public DateTime? ArproductionPlanningItemDeliveryDate { get; set; }

    [Column("ARProductionPlanningItemOSSDeliveryDate", TypeName = "datetime")]
    public DateTime? ArproductionPlanningItemOssdeliveryDate { get; set; }

    [Column("ARProductionPlanningItemDeliveryTime", TypeName = "datetime")]
    public DateTime? ArproductionPlanningItemDeliveryTime { get; set; }

    [Column("ICProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductUnitPrice { get; set; }

    [Column("ARProductionPlanningItemProductSupplierNo")]
    [StringLength(50)]
    public string ArproductionPlanningItemProductSupplierNo { get; set; }

    [Column("ARProductionPlanningItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductLength { get; set; }

    [Column("ARProductionPlanningItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductWidth { get; set; }

    [Column("ARProductionPlanningItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductHeight { get; set; }

    [Column("ARProductionPlanningItemProductCartonLength", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductCartonLength { get; set; }

    [Column("ARProductionPlanningItemProductCartonWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductCartonWidth { get; set; }

    [Column("ARProductionPlanningItemProductCartonHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductCartonHeight { get; set; }

    [Column("ARProductionPlanningItemProductContainerLoading20", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductContainerLoading20 { get; set; }

    [Column("ARProductionPlanningItemProductContainerLoading40", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductContainerLoading40 { get; set; }

    [Column("ARProductionPlanningItemProductContainerLoadingHC", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductContainerLoadingHc { get; set; }

    [Column("ARProductionPlanningItemProductFOBPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductFobprice { get; set; }

    [Column("ARProductionPlanningItemProductTargetPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductTargetPrice { get; set; }

    [Column("ARProductionPlanningItemQuantityOfBox", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemQuantityOfBox { get; set; }

    [Column("ARProductionPlanningItemProductCustomerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArproductionPlanningItemProductCustomerNumber { get; set; }

    [Column("ARProductionPlanningItemProposedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProposedQty { get; set; }

    [Column("ARProductionPlanningItemRemark")]
    [StringLength(500)]
    public string ArproductionPlanningItemRemark { get; set; }

    [Column("ARProductionPlanningItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemWoodQty { get; set; }

    [Column("ARProductionPlanningItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemHeight { get; set; }

    [Column("ARProductionPlanningItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemWidth { get; set; }

    [Column("ARProductionPlanningItemLength", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemLength { get; set; }

    [Column("ARProductionPlanningItemProductUnitPrice2", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductUnitPrice2 { get; set; }

    [Column("ARProductionPlanningItemTotalAmount2", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemTotalAmount2 { get; set; }

    [Column("ARProductionPlanningItemPONo")]
    [StringLength(50)]
    public string ArproductionPlanningItemPono { get; set; }

    [Column("ARProductionPlanningItemProductLoadContQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductLoadContQty { get; set; }

    [Column("ARProductionPlanningItemLoadContNumber")]
    public int? ArproductionPlanningItemLoadContNumber { get; set; }

    [Column("ARProductionPlanningItemProductCBM", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductCbm { get; set; }

    [Column("ARProductionPlanningItemSaleOrderNo")]
    [StringLength(50)]
    public string ArproductionPlanningItemSaleOrderNo { get; set; }

    [Column("ARProductionPlanningItemProductSerial")]
    [StringLength(50)]
    public string ArproductionPlanningItemProductSerial { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ARProductionPlanningItemSources")]
    [StringLength(50)]
    public string ArproductionPlanningItemSources { get; set; }

    [Column("ARProductionPlanningItemStatus")]
    [StringLength(50)]
    public string ArproductionPlanningItemStatus { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("ARProductionPlanningItemProductionPriority")]
    [StringLength(50)]
    public string ArproductionPlanningItemProductionPriority { get; set; }

    [Column("ARProductionPlanningItemIsNewProduct")]
    public bool? ArproductionPlanningItemIsNewProduct { get; set; }

    [Column("ARProductionPlanningItemIsJoinComponent")]
    public bool? ArproductionPlanningItemIsJoinComponent { get; set; }

    [Column("ARProductionPlanningItemIsLabelCorlor")]
    public bool? ArproductionPlanningItemIsLabelCorlor { get; set; }

    [Column("ARProductionPlanningItemIsProductCard")]
    public bool? ArproductionPlanningItemIsProductCard { get; set; }

    [Column("ARProductionPlanningItemIsProductFSCCard")]
    public bool? ArproductionPlanningItemIsProductFsccard { get; set; }

    [Column("ARProductionPlanningItemIsProductLabel")]
    public bool? ArproductionPlanningItemIsProductLabel { get; set; }

    [Column("ARProductionPlanningItemIsProductHDLR")]
    public bool? ArproductionPlanningItemIsProductHdlr { get; set; }

    [Column("ARProductionPlanningItemIsProductHDSD")]
    public bool? ArproductionPlanningItemIsProductHdsd { get; set; }

    [Column("ARProductionPlanningItemIsProductBarcode")]
    public bool? ArproductionPlanningItemIsProductBarcode { get; set; }

    [Column("ARProductionPlanningItemIsProductWarranty")]
    public bool? ArproductionPlanningItemIsProductWarranty { get; set; }

    [Column("ARProductionPlanningItemHardwareRemark")]
    [StringLength(256)]
    public string ArproductionPlanningItemHardwareRemark { get; set; }

    [Column("ARProductionPlanningItemPackagingRequimentType")]
    [StringLength(50)]
    public string ArproductionPlanningItemPackagingRequimentType { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ARProductionPlanningItemSemiProductRemark")]
    [StringLength(256)]
    public string ArproductionPlanningItemSemiProductRemark { get; set; }

    [Column("ARProductionPlanningItemProductRemark")]
    [StringLength(524)]
    public string ArproductionPlanningItemProductRemark { get; set; }

    [Column("ARProductionPlanningItemWoodRemark")]
    [StringLength(256)]
    public string ArproductionPlanningItemWoodRemark { get; set; }

    [Column("ARProductionPlanningItemPackagingRemark")]
    [StringLength(256)]
    public string ArproductionPlanningItemPackagingRemark { get; set; }

    [Column("ARProductionPlanningItemPaintRemark")]
    [StringLength(256)]
    public string ArproductionPlanningItemPaintRemark { get; set; }

    [Column("ARProductionPlanningItemGeneralMaterialRemark")]
    [StringLength(256)]
    public string ArproductionPlanningItemGeneralMaterialRemark { get; set; }

    [Column("ARProductionPlanningItemSaleOrderName")]
    [StringLength(256)]
    public string ArproductionPlanningItemSaleOrderName { get; set; }

    [Column("ARProductionPlanningItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductFactor { get; set; }

    [Column("ARProductionPlanningItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproductionPlanningItemProductExchangeQty { get; set; }

    [InverseProperty("FkArproductionPlanningItem")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [ForeignKey("FkArcontainerLoaderId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual ArcontainerLoader FkArcontainerLoader { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArproductionPlanningId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual ArproductionPlanning FkArproductionPlanning { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArproductionPlanningItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [InverseProperty("FkArproductionPlanningItem")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();
}
