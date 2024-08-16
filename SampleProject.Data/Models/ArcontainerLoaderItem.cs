using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARContainerLoaderItems")]
public partial class ArcontainerLoaderItem
{
    [Key]
    [Column("ARContainerLoaderItemID")]
    public int ArcontainerLoaderItemId { get; set; }

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

    [Column("FK_ARContainerLoaderID")]
    public int? FkArcontainerLoaderId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ARContainerLoaderItemProductType")]
    [StringLength(50)]
    public string ArcontainerLoaderItemProductType { get; set; }

    [Column("ARContainerLoaderItemProductName")]
    [StringLength(50)]
    public string ArcontainerLoaderItemProductName { get; set; }

    [Column("ARContainerLoaderItemProductDesc", TypeName = "ntext")]
    public string ArcontainerLoaderItemProductDesc { get; set; }

    [Column("ARContainerLoaderItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemProductQty { get; set; }

    [Column("ARContainerLoaderItemCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemCanceledQty { get; set; }

    [Column("ARContainerLoaderItemComment")]
    [StringLength(50)]
    public string ArcontainerLoaderItemComment { get; set; }

    [Column("FK_ARSaleForecastID")]
    public int? FkArsaleForecastId { get; set; }

    [Column("FK_ARSaleForecastItemID")]
    public int? FkArsaleForecastItemId { get; set; }

    [Column("ARContainerLoaderItemProposedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemProposedQty { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("ARContainerLoaderItemUnitVolume", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemUnitVolume { get; set; }

    [Column("ARContainerLoaderItemLength", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemLength { get; set; }

    [Column("ARContainerLoaderItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemWidth { get; set; }

    [Column("ARContainerLoaderItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemHeight { get; set; }

    [Column("ARContainerLoaderItemNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemNetWeight { get; set; }

    [Column("ARContainerLoaderItemGrossWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemGrossWeight { get; set; }

    [Column("ARContainerLoaderItemTotalGrossWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemTotalGrossWeight { get; set; }

    [Column("ARContainerLoaderItemTotalCMB", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemTotalCmb { get; set; }

    [Column("ARContainerLoaderItemTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemTotalBlock { get; set; }

    [Column("FK_ARProductionPlanningItemID")]
    public int? FkArproductionPlanningItemId { get; set; }

    [Column("ARContainerLoaderItemProductQtyReal", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemProductQtyReal { get; set; }

    [Column("FK_MMChangeDeliveryDateBatchProductItemID")]
    public int? FkMmchangeDeliveryDateBatchProductItemId { get; set; }

    [Column("ARContainerLoaderItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemProductFactor { get; set; }

    [Column("ARContainerLoaderItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemProductExchangeQty { get; set; }

    [Column("ARContainerLoaderItemExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemExchangeTotalCost { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ARContainerLoaderItemPONo")]
    [StringLength(50)]
    public string ArcontainerLoaderItemPono { get; set; }

    [InverseProperty("FkArcontainerLoaderItem")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [ForeignKey("FkArcontainerLoaderId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual ArcontainerLoader FkArcontainerLoader { get; set; }

    [ForeignKey("FkArproductionPlanningItemId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual ArproductionPlanningItem FkArproductionPlanningItem { get; set; }

    [ForeignKey("FkArsaleForecastId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual ArsaleForecast FkArsaleForecast { get; set; }

    [ForeignKey("FkArsaleForecastItemId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual ArsaleForecastItem FkArsaleForecastItem { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("ArcontainerLoaderItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ArcontainerLoaderItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ArcontainerLoaderItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [InverseProperty("FkArcontainerLoaderItem")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();
}
