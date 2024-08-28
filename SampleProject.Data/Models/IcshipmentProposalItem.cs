using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentProposalItems")]
public partial class IcshipmentProposalItem
{
    [Key]
    [Column("ICShipmentProposalItemID")]
    public int IcshipmentProposalItemId { get; set; }

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

    [Column("FK_ICShipmentProposalID")]
    public int? FkIcshipmentProposalId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("FK_ICProductAttributeColor")]
    public int? FkIcproductAttributeColor { get; set; }

    [Column("FK_ICProductAttributePaintType")]
    public int? FkIcproductAttributePaintType { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("ICShipmentProposalItemProductName")]
    [StringLength(50)]
    public string IcshipmentProposalItemProductName { get; set; }

    [Column("ICShipmentProposalItemProductDesc", TypeName = "ntext")]
    public string IcshipmentProposalItemProductDesc { get; set; }

    [Column("ICShipmentProposalItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemProductQty { get; set; }

    [Column("ICShipmentProposalItemProductShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemProductShippedQty { get; set; }

    [Column("ICShipmentProposalItemProductRemainQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemProductRemainQty { get; set; }

    [Column("ICShipmentProposalItemComment")]
    [StringLength(50)]
    public string IcshipmentProposalItemComment { get; set; }

    [Column("ICShipmentProposalItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentProposalItemStatus { get; set; }

    [Column("ICPriority")]
    [StringLength(50)]
    public string Icpriority { get; set; }

    [Column("ICShipmentProposalItemProductCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemProductCanceledQty { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ICShipmentProposalItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemWoodQty { get; set; }

    [Column("ICShipmentProposalItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemHeight { get; set; }

    [Column("ICShipmentProposalItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemWidth { get; set; }

    [Column("ICShipmentProposalItemLength", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemLength { get; set; }

    [Column("ICShipmentProposalItemPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemPerimeter { get; set; }

    [Column("ICShipmentProposalItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemHeightMin { get; set; }

    [Column("ICShipmentProposalItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemWidthMin { get; set; }

    [Column("ICShipmentProposalItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemLengthMin { get; set; }

    [Column("ICShipmentProposalItemPerimeterMin", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemPerimeterMin { get; set; }

    [Column("ICShipmentProposalItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemHeightMax { get; set; }

    [Column("ICShipmentProposalItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemWidthMax { get; set; }

    [Column("ICShipmentProposalItemLentghMax", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemLentghMax { get; set; }

    [Column("ICShipmentProposalItemPerimeterMax", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentProposalItemPerimeterMax { get; set; }

    [Column("ICShipmentProposalItemLotNo")]
    [StringLength(50)]
    public string IcshipmentProposalItemLotNo { get; set; }

    [Column("ICShipmentProposalItemProductSerialNo")]
    [StringLength(50)]
    public string IcshipmentProposalItemProductSerialNo { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("ICShipmentProposalItemPONo")]
    [StringLength(50)]
    public string IcshipmentProposalItemPono { get; set; }

    [Column("FK_ARContainerLoaderID")]
    public int? FkArcontainerLoaderId { get; set; }

    [Column("FK_ARContainerLoaderItemID")]
    public int? FkArcontainerLoaderItemId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ARProductionPlanningItemID")]
    public int? FkArproductionPlanningItemId { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkArcontainerLoaderId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual ArcontainerLoader FkArcontainerLoader { get; set; }

    [ForeignKey("FkArcontainerLoaderItemId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual ArcontainerLoaderItem FkArcontainerLoaderItem { get; set; }

    [ForeignKey("FkArproductionPlanningItemId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual ArproductionPlanningItem FkArproductionPlanningItem { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcshipmentProposalItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("IcshipmentProposalItemFkIcproductAttributes")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }

    [ForeignKey("FkIcproductAttributeColor")]
    [InverseProperty("IcshipmentProposalItemFkIcproductAttributeColorNavigations")]
    public virtual IcproductAttribute FkIcproductAttributeColorNavigation { get; set; }

    [ForeignKey("FkIcproductAttributePaintType")]
    [InverseProperty("IcshipmentProposalItemFkIcproductAttributePaintTypeNavigations")]
    public virtual IcproductAttribute FkIcproductAttributePaintTypeNavigation { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcshipmentProposalItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcshipmentProposalItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductEquipmentId")]
    [InverseProperty("IcshipmentProposalItemFkIcproductEquipments")]
    public virtual Icproduct FkIcproductEquipment { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcshipmentProposalId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual IcshipmentProposal FkIcshipmentProposal { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcshipmentProposalItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [InverseProperty("FkIcshipmentProposalItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
