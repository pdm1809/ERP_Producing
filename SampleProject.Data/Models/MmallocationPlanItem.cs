using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMAllocationPlanItems")]
public partial class MmallocationPlanItem
{
    [Key]
    [Column("MMAllocationPlanItemID")]
    public int MmallocationPlanItemId { get; set; }

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

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Column("FK_MMWoodPlanItemDetailID")]
    public int? FkMmwoodPlanItemDetailId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("MMAllocationPlanItemProductName")]
    [StringLength(256)]
    public string MmallocationPlanItemProductName { get; set; }

    [Column("MMAllocationPlanItemProductDesc")]
    [StringLength(4000)]
    public string MmallocationPlanItemProductDesc { get; set; }

    [Column("MMAllocationPlanItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemHeight { get; set; }

    [Column("MMAllocationPlanItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemWidth { get; set; }

    [Column("MMAllocationPlanItemLength", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemLength { get; set; }

    [Column("MMAllocationPlanItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemHeightMin { get; set; }

    [Column("MMAllocationPlanItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemWidthMin { get; set; }

    [Column("MMAllocationPlanItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemLengthMin { get; set; }

    [Column("MMAllocationPlanItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemHeightMax { get; set; }

    [Column("MMAllocationPlanItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemWidthMax { get; set; }

    [Column("MMAllocationPlanItemLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemLengthMax { get; set; }

    [Column("MMAllocationPlanItemQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemQty { get; set; }

    [Column("MMAllocationPlanItemWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemWoodQty { get; set; }

    [Column("MMAllocationPlanItemProposedQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemProposedQty { get; set; }

    [Column("MMAllocationPlanItemCanceledQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemCanceledQty { get; set; }

    [Column("MMAllocationPlanItemComment")]
    [StringLength(524)]
    public string MmallocationPlanItemComment { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    public string Mmpriority { get; set; }

    [Column("MMAllocationPlanItemDeliveryDate", TypeName = "datetime")]
    public DateTime? MmallocationPlanItemDeliveryDate { get; set; }

    [Column("MMAllocationPlanItemHWQtySource")]
    [StringLength(50)]
    public string MmallocationPlanItemHwqtySource { get; set; }

    [Column("MMAllocationPlanItemProposedWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemProposedWoodQty { get; set; }

    [Column("MMAllocationPlanItemCanceledWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemCanceledWoodQty { get; set; }

    [Column("MMAllocationPlanItemBPProductionNormItemQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemBpproductionNormItemQty { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("MMAllocationPlanItemBatchProductItemProductSerial")]
    [StringLength(50)]
    public string MmallocationPlanItemBatchProductItemProductSerial { get; set; }

    [Column("MMAllocationPlanItemBPQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemBpqty { get; set; }

    [Column("FK_ICBPMeasureUnitID")]
    public int? FkIcbpmeasureUnitId { get; set; }

    [Column("MMAllocationPlanItemSaleOrderQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemSaleOrderQty { get; set; }

    [Column("MMAllocationPlanItemSaleOrderWoodQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemSaleOrderWoodQty { get; set; }

    [Column("MMAllocationPlanItemProductionNormItemBlocks", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemProductionNormItemBlocks { get; set; }

    [Column("MMAllocationPlanItemProductionNormItemPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemProductionNormItemPaint { get; set; }

    [Column("MMAllocationPlanItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmallocationPlanItemProductSupplierNumber { get; set; }

    [Column("MMAllocationPlanItemProductForBatchName")]
    [StringLength(50)]
    public string MmallocationPlanItemProductForBatchName { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMProductType")]
    [StringLength(50)]
    public string MmproductType { get; set; }

    [Column("FK_ICProductWoodIngredientID")]
    public int? FkIcproductWoodIngredientId { get; set; }

    [Column("MMAllocationPlanItemReference")]
    [StringLength(500)]
    public string MmallocationPlanItemReference { get; set; }

    [Column("MMAllocationPlanItemBPProductionNormItemIsReuse")]
    public bool? MmallocationPlanItemBpproductionNormItemIsReuse { get; set; }

    [Column("MMAllocationPlanItemWoodGroup")]
    [StringLength(200)]
    public string MmallocationPlanItemWoodGroup { get; set; }

    [Column("MMAllocationPlanItemWaste", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemWaste { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("MMAllocatedQty", TypeName = "decimal(18, 6)")]
    public decimal? MmallocatedQty { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("MMAllocationPlanItemGroup")]
    [StringLength(50)]
    public string MmallocationPlanItemGroup { get; set; }

    [Column("MMAllocationPlanItemStatus")]
    [StringLength(50)]
    public string MmallocationPlanItemStatus { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_ICProductAlternativeID")]
    public int? FkIcproductAlternativeId { get; set; }

    [Column("MMAllocationPlanItemAltFactor", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanItemAltFactor { get; set; }

    [Column("FK_MMBatchProductItemOutSourcingID")]
    public int? FkMmbatchProductItemOutSourcingId { get; set; }

    [Column("FK_HREmployeeIDReceive")]
    public int? FkHremployeeIdreceive { get; set; }

    [Column("MMAllocationPlanItemPostedStatus")]
    [StringLength(50)]
    public string MmallocationPlanItemPostedStatus { get; set; }

    [Column("MMAllocationPlanItemPostedAction")]
    [StringLength(50)]
    public string MmallocationPlanItemPostedAction { get; set; }

    [Column("FK_MMBatchProductProductionNormItemMeterialID")]
    public int? FkMmbatchProductProductionNormItemMeterialId { get; set; }

    [Column("MMAllocationPlanItemDepreciationRate", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemDepreciationRate { get; set; }

    [Column("MMAllocationPlanItemRate", TypeName = "decimal(18, 6)")]
    public decimal? MmallocationPlanItemRate { get; set; }

    [InverseProperty("FkMmallocationPlanItem")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcbpmeasureUnitId")]
    [InverseProperty("MmallocationPlanItemFkIcbpmeasureUnits")]
    public virtual IcmeasureUnit FkIcbpmeasureUnit { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmallocationPlanItemFkIcmeasureUnits")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmallocationPlanItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmallocationPlanItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmallocationPlanItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmallocationPlanItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmallocationPlanItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductWoodIngredientId")]
    [InverseProperty("MmallocationPlanItemFkIcproductWoodIngredients")]
    public virtual Icproduct FkIcproductWoodIngredient { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmallocationPlanItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmallocationPlanItem")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkMmallocationPlanItem")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();

    [InverseProperty("FkMmallocationPlanItem")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();
}
