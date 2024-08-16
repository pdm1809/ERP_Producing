using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMAllocationProposalItems")]
public partial class MmallocationProposalItem
{
    [Key]
    [Column("MMAllocationProposalItemID")]
    public int MmallocationProposalItemId { get; set; }

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

    [Column("FK_MMAllocationProposalID")]
    public int? FkMmallocationProposalId { get; set; }

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

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Column("FK_MMAllocationPlanItemID")]
    public int? FkMmallocationPlanItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("MMAllocationProposalItemProductName")]
    [StringLength(50)]
    public string MmallocationProposalItemProductName { get; set; }

    [Column("MMAllocationProposalItemProductDesc")]
    [StringLength(4000)]
    public string MmallocationProposalItemProductDesc { get; set; }

    [Column("MMAllocationProposalItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemHeight { get; set; }

    [Column("MMAllocationProposalItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemWidth { get; set; }

    [Column("MMAllocationProposalItemLength", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemLength { get; set; }

    [Column("MMAllocationProposalItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemHeightMin { get; set; }

    [Column("MMAllocationProposalItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemWidthMin { get; set; }

    [Column("MMAllocationProposalItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemLengthMin { get; set; }

    [Column("MMAllocationProposalItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemHeightMax { get; set; }

    [Column("MMAllocationProposalItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemWidthMax { get; set; }

    [Column("MMAllocationProposalItemLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemLengthMax { get; set; }

    [Column("MMAllocationProposalItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemQty { get; set; }

    [Column("MMAllocationProposalItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemWoodQty { get; set; }

    [Column("MMAllocationProposalItemShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemShippedQty { get; set; }

    [Column("MMAllocationProposalItemComment")]
    [StringLength(50)]
    public string MmallocationProposalItemComment { get; set; }

    [Column("MMAllocationProposalItemShippedWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemShippedWoodQty { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("MMAllocationProposalItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemProductPerimeter { get; set; }

    [Column("MMAllocationProposalItemCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemCanceledQty { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("MMAllocationProposalItemProductSerialNo")]
    [StringLength(50)]
    public string MmallocationProposalItemProductSerialNo { get; set; }

    [Column("MMAllocationProposalItemLotNo")]
    [StringLength(50)]
    public string MmallocationProposalItemLotNo { get; set; }

    [Column("MMAllocationProposalItemHWQtySource")]
    [StringLength(50)]
    public string MmallocationProposalItemHwqtySource { get; set; }

    [Column("MMAllocationProposalItemBPProductionNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemBpproductionNormItemQty { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("MMAllocationProposalItemBatchProductItemProductSerial")]
    [StringLength(50)]
    public string MmallocationProposalItemBatchProductItemProductSerial { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("MMAllocationProposalItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmallocationProposalItemProductSupplierNumber { get; set; }

    [Column("MMAllocationProposalItemStatus")]
    [StringLength(50)]
    public string MmallocationProposalItemStatus { get; set; }

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("MMAllocationProposalItemIsReuse")]
    public bool? MmallocationProposalItemIsReuse { get; set; }

    [Column("MMAllocationProposalItemWaste", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemWaste { get; set; }

    [Column("MMAllocationProposalItemCanceledWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationProposalItemCanceledWoodQty { get; set; }

    [Column("FK_ACMaintainProposalItemNeedID")]
    public int? FkAcmaintainProposalItemNeedId { get; set; }

    [Column("FK_ACDeviceItemPlanID")]
    public int? FkAcdeviceItemPlanId { get; set; }

    [InverseProperty("FkMmallocationProposalItem")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmallocationProposalItem")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkMmallocationProposalItem")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [ForeignKey("FkGecountryId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmallocationProposalItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmallocationProposalItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmallocationProposalItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmallocationProposalItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmallocationProposalItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmallocationProposalItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [InverseProperty("FkMmallocationProposalItem")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkMmallocationProposalItem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmallocationProposalItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkMmallocationProposalItem")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();
}
