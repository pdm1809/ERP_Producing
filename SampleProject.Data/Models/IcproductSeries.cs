using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSeries")]
[Microsoft.EntityFrameworkCore.Index("IcproductSerieNo", "FkIcproductId", Name = "Idx_ICProductSeries")]
public partial class IcproductSeries
{
    [Key]
    [Column("ICProductSerieID")]
    public int IcproductSerieId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Required]
    [Column("ICProductSerieNo")]
    [StringLength(50)]
    public string IcproductSerieNo { get; set; }

    [Column("ICProductSerieReceiptDate", TypeName = "datetime")]
    public DateTime? IcproductSerieReceiptDate { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ICProductSerieLotNo")]
    [StringLength(50)]
    public string IcproductSerieLotNo { get; set; }

    [Column("ICProductSerieWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieWoodQty { get; set; }

    [Column("ICProductSerieLogListNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductSerieLogListNo { get; set; }

    [Column("ICProductSerieContainerNo")]
    [StringLength(50)]
    public string IcproductSerieContainerNo { get; set; }

    [Column("ICProductSerieProductDesc")]
    [StringLength(512)]
    public string IcproductSerieProductDesc { get; set; }

    [Column("ICProductSerieProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductHeight { get; set; }

    [Column("ICProductSerieProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductWidth { get; set; }

    [Column("ICProductSerieProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductLength { get; set; }

    [Column("ICProductSerieProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductPerimeter { get; set; }

    [Column("ICProductSerieProductWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductWidthMax { get; set; }

    [Column("ICProductSerieProductLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductLengthMax { get; set; }

    [Column("ICProductSerieProductPerimeterMax", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductPerimeterMax { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("ICProductSerieBlockPerOne", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieBlockPerOne { get; set; }

    [Column("ICProductSeriePackageBarcode")]
    [StringLength(255)]
    public string IcproductSeriePackageBarcode { get; set; }

    [Column("ICProductSerieProductWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductWidthMin { get; set; }

    [Column("ICProductSerieProductLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSerieProductLengthMin { get; set; }

    [Column("ICProductSerieExpireDate", TypeName = "datetime")]
    public DateTime? IcproductSerieExpireDate { get; set; }

    [Column("FK_MMDiagramPositionID")]
    public int? FkMmdiagramPositionId { get; set; }

    [Column("ICProductSerieNumbering")]
    public int? IcproductSerieNumbering { get; set; }

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ApallocationCostItem> ApallocationCostItems { get; set; } = new List<ApallocationCostItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArinvoiceItemComponent> ArinvoiceItemComponents { get; set; } = new List<ArinvoiceItemComponent>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArsaleForecastItem> ArsaleForecastItems { get; set; } = new List<ArsaleForecastItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArsaleReturnItemComponent> ArsaleReturnItemComponents { get; set; } = new List<ArsaleReturnItemComponent>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArsfitemComponent> ArsfitemComponents { get; set; } = new List<ArsfitemComponent>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<ArsoitemComponent> ArsoitemComponents { get; set; } = new List<ArsoitemComponent>();

    [ForeignKey("FkGecountryId")]
    [InverseProperty("IcproductSeries")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("IcproductSeries")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("IcproductSeries")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductSeriesFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcproductSeriesFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcproductSeriesFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcproductSeriesFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("IcproductSeriesFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcproductSeries")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("IcproductSeries")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcassembleProductDetail> IcassembleProductDetails { get; set; } = new List<IcassembleProductDetail>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcassembleProduct> IcassembleProducts { get; set; } = new List<IcassembleProduct>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcdisassembleProductDetail> IcdisassembleProductDetails { get; set; } = new List<IcdisassembleProductDetail>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcdisassembleProduct> IcdisassembleProducts { get; set; } = new List<IcdisassembleProduct>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcinitializedInventoryStock> IcinitializedInventoryStocks { get; set; } = new List<IcinitializedInventoryStock>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcinvAdjustment> IcinvAdjustments { get; set; } = new List<IcinvAdjustment>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcinventoryItemPackage> IcinventoryItemPackages { get; set; } = new List<IcinventoryItemPackage>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcinventoryStockCountItem> IcinventoryStockCountItems { get; set; } = new List<IcinventoryStockCountItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcinventoryStockSlotSeries> IcinventoryStockSlotSeries { get; set; } = new List<IcinventoryStockSlotSeries>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcinventoryStock> IcinventoryStocks { get; set; } = new List<IcinventoryStock>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; } = new List<IcpriceAdjustmentItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcproductConversionItem> IcproductConversionItems { get; set; } = new List<IcproductConversionItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcproductSerialNumber> IcproductSerialNumbers { get; set; } = new List<IcproductSerialNumber>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcreceiptPackageItemDetail> IcreceiptPackageItemDetails { get; set; } = new List<IcreceiptPackageItemDetail>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcshipmentItemComponent> IcshipmentItemComponents { get; set; } = new List<IcshipmentItemComponent>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<IctransferProposalItem> IctransferProposalItems { get; set; } = new List<IctransferProposalItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<MmbatchProductInputItem> MmbatchProductInputItems { get; set; } = new List<MmbatchProductInputItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<MmfalseConditionalItem> MmfalseConditionalItems { get; set; } = new List<MmfalseConditionalItem>();

    [InverseProperty("FkIcproductSerie")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();
}
