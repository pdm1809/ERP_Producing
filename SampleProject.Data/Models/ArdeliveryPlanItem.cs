using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanItems")]
public partial class ArdeliveryPlanItem
{
    [Key]
    [Column("ARDeliveryPlanItemID")]
    public int ArdeliveryPlanItemId { get; set; }

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

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ARDeliveryPlanItemSaleOrderNo")]
    [StringLength(50)]
    public string ArdeliveryPlanItemSaleOrderNo { get; set; }

    [Column("ARDeliveryPlanItemSaleOrderDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanItemSaleOrderDate { get; set; }

    [Column("ARDeliveryPlanItemDeliveryDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanItemDeliveryDate { get; set; }

    [Column("ARDeliveryPlanItemProductNo")]
    [StringLength(50)]
    public string ArdeliveryPlanItemProductNo { get; set; }

    [Column("ARDeliveryPlanItemProductName")]
    [StringLength(256)]
    public string ArdeliveryPlanItemProductName { get; set; }

    [Column("ARDeliveryPlanItemProductDesc")]
    [StringLength(512)]
    public string ArdeliveryPlanItemProductDesc { get; set; }

    [Column("ARDeliveryPlanItemProductType")]
    [StringLength(256)]
    public string ArdeliveryPlanItemProductType { get; set; }

    [Column("ARDeliveryPlanItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemProductQty { get; set; }

    [Column("ARDeliveryPlanItemNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemNetWeight { get; set; }

    [Column("ARDeliveryPlanItemAddress")]
    [StringLength(512)]
    public string ArdeliveryPlanItemAddress { get; set; }

    [Column("ARDeliveryPlanItemCommand")]
    [StringLength(512)]
    public string ArdeliveryPlanItemCommand { get; set; }

    [Column("ARDeliveryPlanItemSource")]
    [StringLength(50)]
    public string ArdeliveryPlanItemSource { get; set; }

    [Column("ARDeliveryPlanItemStatus")]
    [StringLength(50)]
    public string ArdeliveryPlanItemStatus { get; set; }

    [Column("ARDeliveryPlanItemDeliveryActualDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanItemDeliveryActualDate { get; set; }

    [Column("ARDeliveryPlanItemCancelReason")]
    [StringLength(256)]
    public string ArdeliveryPlanItemCancelReason { get; set; }

    [Column("ARDeliveryPlanItemCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemCancelQty { get; set; }

    [Column("ARDeliveryPlanItemPlanQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemPlanQty { get; set; }

    [Column("ARDeliveryPlanItemShipmentQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemShipmentQty { get; set; }

    [Column("ARDeliveryPlanItemDeliveryQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemDeliveryQty { get; set; }

    [Column("ARDeliveryPlanItemDeliveryAddressStreet")]
    [StringLength(256)]
    public string ArdeliveryPlanItemDeliveryAddressStreet { get; set; }

    [Column("ARDeliveryPlanItemDeliveryAddressWard")]
    [StringLength(256)]
    public string ArdeliveryPlanItemDeliveryAddressWard { get; set; }

    [Column("FK_GEDeliveryDistrictID")]
    public int? FkGedeliveryDistrictId { get; set; }

    [Column("FK_GEDeliveryStateProvinceID")]
    public int? FkGedeliveryStateProvinceId { get; set; }

    [Column("ARDeliveryPlanItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemProductHeight { get; set; }

    [Column("ARDeliveryPlanItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemProductWidth { get; set; }

    [Column("ARDeliveryPlanItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemProductLength { get; set; }

    [Column("ARDeliveryPlanItemReferenceID")]
    public int? ArdeliveryPlanItemReferenceId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ARDeliveryPlanItemProductTemplateType")]
    [StringLength(256)]
    public string ArdeliveryPlanItemProductTemplateType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("FK_ICTransferItemID")]
    public int? FkIctransferItemId { get; set; }

    [Column("FK_ARSaleReturnItemID")]
    public int? FkArsaleReturnItemId { get; set; }

    [Column("FK_ARSaleReturnID")]
    public int? FkArsaleReturnId { get; set; }

    [Column("FK_ICTransferID")]
    public int? FkIctransferId { get; set; }

    [Column("FK_ICSectionProductID")]
    public int? FkIcsectionProductId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_PMTemplateItemID")]
    public int? FkPmtemplateItemId { get; set; }

    [Column("FK_ARProposalTemplateItemID")]
    public int? FkArproposalTemplateItemId { get; set; }

    [Column("FK_ICMeasureUnitBeforeChangeID")]
    public int? FkIcmeasureUnitBeforeChangeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ARDeliveryPlanItemProductSerialNo")]
    [StringLength(50)]
    public string ArdeliveryPlanItemProductSerialNo { get; set; }

    [Column("FK_ARContainerLoaderItemID")]
    public int? FkArcontainerLoaderItemId { get; set; }

    [Column("FK_ARContainerLoaderID")]
    public int? FkArcontainerLoaderId { get; set; }

    [Column("ARDeliveryPlanItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemProductFactor { get; set; }

    [Column("ARDeliveryPlanItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemProductExchangeQty { get; set; }

    [Column("ARDeliveryPlanItemExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemExchangeUnitCost { get; set; }

    [Column("ARDeliveryPlanItemExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemExchangeTotalCost { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ARDeliveryPlanItemLotNo")]
    [StringLength(100)]
    public string ArdeliveryPlanItemLotNo { get; set; }

    [Column("ARDeliveryPlanItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemWoodQty { get; set; }

    [Column("ARDeliveryPlanItemPONo")]
    [StringLength(50)]
    public string ArdeliveryPlanItemPono { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("ARDeliveryPlanItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArdeliveryPlanItemProductNoOfOldSys { get; set; }

    [Column("ARDeliveryPlanItemProductCustomerNumber")]
    [StringLength(50)]
    public string ArdeliveryPlanItemProductCustomerNumber { get; set; }

    [Column("ARDeliveryPlanItemQuantityOfBox", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanItemQuantityOfBox { get; set; }

    [InverseProperty("FkArdeliveryPlanItem")]
    public virtual ICollection<ArcanceledDeliveryPlanItem> ArcanceledDeliveryPlanItems { get; set; } = new List<ArcanceledDeliveryPlanItem>();

    [InverseProperty("FkArdeliveryPlanItem")]
    public virtual ICollection<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; } = new List<ArdeliveryPlanFile>();

    [InverseProperty("FkArdeliveryPlanItem")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkArdeliveryPlanItem")]
    public virtual ICollection<ArdeliveryPlanWorkAsset> ArdeliveryPlanWorkAssets { get; set; } = new List<ArdeliveryPlanWorkAsset>();

    [InverseProperty("FkArdeliveryPlanItem")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkArdeliveryPlanItem")]
    public virtual ICollection<ArdeliveryPlanWork> ArdeliveryPlanWorks { get; set; } = new List<ArdeliveryPlanWork>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkArsaleReturnId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual ArsaleReturn FkArsaleReturn { get; set; }

    [ForeignKey("FkArsaleReturnItemId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual ArsaleReturnItem FkArsaleReturnItem { get; set; }

    [ForeignKey("FkGedeliveryDistrictId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual Gedistrict FkGedeliveryDistrict { get; set; }

    [ForeignKey("FkGedeliveryStateProvinceId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual GestateProvince FkGedeliveryStateProvince { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArdeliveryPlanItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("ArdeliveryPlanItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ArdeliveryPlanItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcsectionProductId")]
    [InverseProperty("ArdeliveryPlanItemFkIcsectionProducts")]
    public virtual Icproduct FkIcsectionProduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIctransferId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual Ictransfer FkIctransfer { get; set; }

    [ForeignKey("FkIctransferItemId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual IctransferItem FkIctransferItem { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkPmtemplateItemId")]
    [InverseProperty("ArdeliveryPlanItems")]
    public virtual PmtemplateItem FkPmtemplateItem { get; set; }

    [InverseProperty("FkArdeliveryPlanItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
