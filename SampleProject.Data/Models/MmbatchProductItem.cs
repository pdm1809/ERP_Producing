using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductItems")]
public partial class MmbatchProductItem
{
    [Key]
    [Column("MMBatchProductItemID")]
    public int MmbatchProductItemId { get; set; }

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
    public string Aastatus { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeHTTypeID")]
    public int? FkIcproductAttributeHttypeId { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int? FkIcproductAttributeColorId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Required]
    [Column("MMBatchProductItemProductName")]
    [StringLength(512)]
    public string MmbatchProductItemProductName { get; set; }

    [Column("MMBatchProductItemProductDesc")]
    [StringLength(512)]
    public string MmbatchProductItemProductDesc { get; set; }

    [Column("MMBatchProductItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProductLength { get; set; }

    [Column("MMBatchProductItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProductWidth { get; set; }

    [Column("MMBatchProductItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProductHeight { get; set; }

    [Required]
    [Column("MMBatchProductItemProductSerial")]
    [StringLength(50)]
    public string MmbatchProductItemProductSerial { get; set; }

    [Column("MMBatchProductItemDesc")]
    [StringLength(512)]
    public string MmbatchProductItemDesc { get; set; }

    [Column("MMBatchProductItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProductQty { get; set; }

    [Column("MMBatchProductItemProductCard")]
    public bool? MmbatchProductItemProductCard { get; set; }

    [Column("MMBatchProductItemProductTTMTCard")]
    public bool? MmbatchProductItemProductTtmtcard { get; set; }

    [Column("MMBatchProductItemProductLabel")]
    public bool? MmbatchProductItemProductLabel { get; set; }

    [Column("MMBatchProductItemProductHDLR")]
    public bool? MmbatchProductItemProductHdlr { get; set; }

    [Column("MMBatchProductItemProductHDSD")]
    public bool? MmbatchProductItemProductHdsd { get; set; }

    [Column("MMBatchProductItemProductBarcode")]
    public bool? MmbatchProductItemProductBarcode { get; set; }

    [Column("MMBatchProductItemProductWarranty")]
    public bool? MmbatchProductItemProductWarranty { get; set; }

    [Column("MMBatchProductItemProductDeliveryDate", TypeName = "datetime")]
    public DateTime? MmbatchProductItemProductDeliveryDate { get; set; }

    [Column("MMBatchProductItemStatus")]
    [StringLength(50)]
    public string MmbatchProductItemStatus { get; set; }

    [Column("MMBatchProductItemProducedQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProducedQty { get; set; }

    [Column("MMBatchProductItemRemainQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemRemainQty { get; set; }

    [Column("MMBatchProductItemIsNewProduct")]
    public bool? MmbatchProductItemIsNewProduct { get; set; }

    [Column("MMBatchProductItemIsJoinComponent")]
    public bool? MmbatchProductItemIsJoinComponent { get; set; }

    [Column("MMBatchProductItemHardwareRemark")]
    [StringLength(256)]
    public string MmbatchProductItemHardwareRemark { get; set; }

    [Column("MMBatchProductItemPackagingRequimentType")]
    [StringLength(50)]
    public string MmbatchProductItemPackagingRequimentType { get; set; }

    [Column("MMBatchProductItemLabelCorlor")]
    public bool? MmbatchProductItemLabelCorlor { get; set; }

    [Column("FK_MMProposalID")]
    public int? FkMmproposalId { get; set; }

    [Column("FK_MMProposalItemID")]
    public int? FkMmproposalItemId { get; set; }

    [Column("MMBatchProductItemResourceType")]
    [StringLength(50)]
    public string MmbatchProductItemResourceType { get; set; }

    [Column("MMBatchProductItemProductMinWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProductMinWidth { get; set; }

    [Column("MMBatchProductItemProductMaxWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProductMaxWidth { get; set; }

    [Column("MMBatchProductItemProductMinLength", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProductMinLength { get; set; }

    [Column("MMBatchProductItemProductMaxLength", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemProductMaxLength { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("MMBatchProductItemDeliveryDate", TypeName = "datetime")]
    public DateTime? MmbatchProductItemDeliveryDate { get; set; }

    [Column("MMBatchProductItemWoodTypeID")]
    [StringLength(50)]
    public string MmbatchProductItemWoodTypeId { get; set; }

    [Column("MMBatchProductItemWoodTypeText")]
    [StringLength(512)]
    public string MmbatchProductItemWoodTypeText { get; set; }

    [Column("MMBatchProductItemColorID")]
    [StringLength(50)]
    public string MmbatchProductItemColorId { get; set; }

    [Column("MMBatchProductItemColorText")]
    [StringLength(512)]
    public string MmbatchProductItemColorText { get; set; }

    [Column("MMBatchProductItemHTID")]
    [StringLength(50)]
    public string MmbatchProductItemHtid { get; set; }

    [Column("MMBatchProductItemHTText")]
    [StringLength(512)]
    public string MmbatchProductItemHttext { get; set; }

    [Column("MMBatchProductitemTotalPaint", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductitemTotalPaint { get; set; }

    [Column("MMBatchProductItemPONo")]
    [StringLength(50)]
    public string MmbatchProductItemPono { get; set; }

    [Column("MMBatchProductItemIsNeedMergeWood")]
    public bool? MmbatchProductItemIsNeedMergeWood { get; set; }

    [Column("MMBatchProductItemOperationPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemOperationPlanProductQty { get; set; }

    [Column("MMBatchProductItemNeededTime", TypeName = "datetime")]
    public DateTime? MmbatchProductItemNeededTime { get; set; }

    [Column("MMBatchProductItemProductNo")]
    [StringLength(50)]
    public string MmbatchProductItemProductNo { get; set; }

    [Column("FK_ARProductionPlanningID")]
    public int? FkArproductionPlanningId { get; set; }

    [Column("FK_ARProductionPlanningItemID")]
    public int? FkArproductionPlanningItemId { get; set; }

    [Column("MMBatchProductItemPeriod")]
    public int? MmbatchProductItemPeriod { get; set; }

    [Column("MMBatchProductItemLotNo")]
    [StringLength(50)]
    public string MmbatchProductItemLotNo { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("MMBatchProductItemIsNeedMergeHW")]
    public bool? MmbatchProductItemIsNeedMergeHw { get; set; }

    [Column("MMBatchProductItemIsNeedMergePaint")]
    public bool? MmbatchProductItemIsNeedMergePaint { get; set; }

    [Column("MMBatchProductItemIsNeedMergePackaging")]
    public bool? MmbatchProductItemIsNeedMergePackaging { get; set; }

    [Column("MMBatchProductItemIsNeedMergeGeneralMaterial")]
    public bool? MmbatchProductItemIsNeedMergeGeneralMaterial { get; set; }

    [Column("MMBatchProductItemIsNeedMergeCarcassProcess")]
    public bool? MmbatchProductItemIsNeedMergeCarcassProcess { get; set; }

    [Column("MMBatchProductItemIsNeedMergeColorProcess")]
    public bool? MmbatchProductItemIsNeedMergeColorProcess { get; set; }

    [Column("FK_MMProductionNormApproveLogIDWood")]
    public int? FkMmproductionNormApproveLogIdwood { get; set; }

    [Column("FK_MMProductionNormApproveLogIDHardware")]
    public int? FkMmproductionNormApproveLogIdhardware { get; set; }

    [Column("FK_MMProductionNormApproveLogIDPaint")]
    public int? FkMmproductionNormApproveLogIdpaint { get; set; }

    [Column("FK_MMProductionNormApproveLogIDPackaging")]
    public int? FkMmproductionNormApproveLogIdpackaging { get; set; }

    [Column("FK_MMProductionNormApproveLogIDGeneralMaterial")]
    public int? FkMmproductionNormApproveLogIdgeneralMaterial { get; set; }

    [Column("FK_MMProductionNormApproveLogIDColorProcess")]
    public int? FkMmproductionNormApproveLogIdcolorProcess { get; set; }

    [Column("FK_MMProductionNormApproveLogIDCarcassProcess")]
    public int? FkMmproductionNormApproveLogIdcarcassProcess { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("MMBatchProductItemSemiProductRemark")]
    [StringLength(256)]
    public string MmbatchProductItemSemiProductRemark { get; set; }

    [Column("MMBatchProductItemProductRemark")]
    [StringLength(256)]
    public string MmbatchProductItemProductRemark { get; set; }

    [Column("MMBatchProductItemWoodRemark")]
    [StringLength(256)]
    public string MmbatchProductItemWoodRemark { get; set; }

    [Column("MMBatchProductItemPackagingRemark")]
    [StringLength(256)]
    public string MmbatchProductItemPackagingRemark { get; set; }

    [Column("MMBatchProductItemPaintRemark")]
    [StringLength(256)]
    public string MmbatchProductItemPaintRemark { get; set; }

    [Column("MMBatchProductItemGeneralMaterialRemark")]
    [StringLength(256)]
    public string MmbatchProductItemGeneralMaterialRemark { get; set; }

    [Column("MMBatchProductItemSOName")]
    [StringLength(256)]
    public string MmbatchProductItemSoname { get; set; }

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [ForeignKey("FkArproductionPlanningId")]
    [InverseProperty("MmbatchProductItems")]
    public virtual ArproductionPlanning FkArproductionPlanning { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmbatchProductItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("MmbatchProductItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmbatchProductItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbatchProductItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeColorId")]
    [InverseProperty("MmbatchProductItemFkIcproductAttributeColors")]
    public virtual IcproductAttribute FkIcproductAttributeColor { get; set; }

    [ForeignKey("FkIcproductAttributeHttypeId")]
    [InverseProperty("MmbatchProductItemFkIcproductAttributeHttypes")]
    public virtual IcproductAttribute FkIcproductAttributeHttype { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmbatchProductItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmbatchProductItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmbatchProductItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmbatchProductItems")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmbatchProductItems")]
    public virtual Mmproposal FkMmproposal { get; set; }

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmbatchProductItemOperation> MmbatchProductItemOperations { get; set; } = new List<MmbatchProductItemOperation>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmbatchProductProductionNormItemEquipment> MmbatchProductProductionNormItemEquipments { get; set; } = new List<MmbatchProductProductionNormItemEquipment>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmbatchProductProductionNormItemHardware> MmbatchProductProductionNormItemHardwares { get; set; } = new List<MmbatchProductProductionNormItemHardware>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmbatchProductProductionNormItemMeterial> MmbatchProductProductionNormItemMeterials { get; set; } = new List<MmbatchProductProductionNormItemMeterial>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmbatchProductProductionNormItemPaint> MmbatchProductProductionNormItemPaints { get; set; } = new List<MmbatchProductProductionNormItemPaint>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmbpoperationDepartment> MmbpoperationDepartments { get; set; } = new List<MmbpoperationDepartment>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmcalculatorProductionNormItem> MmcalculatorProductionNormItems { get; set; } = new List<MmcalculatorProductionNormItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmchangeDeliveryDateBatchProductItem> MmchangeDeliveryDateBatchProductItems { get; set; } = new List<MmchangeDeliveryDateBatchProductItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetails { get; set; } = new List<MmwoodPlanItemDetail>();

    [InverseProperty("FkMmbatchProductItem")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItems { get; set; } = new List<MmwoodPlanItem>();
}
