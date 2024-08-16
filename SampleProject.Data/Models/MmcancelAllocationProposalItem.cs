using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCancelAllocationProposalItems")]
public partial class MmcancelAllocationProposalItem
{
    [Key]
    [Column("MMCancelAllocationProposalItemID")]
    public int MmcancelAllocationProposalItemId { get; set; }

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

    [Column("FK_MMAllocationProposalItemID")]
    public int? FkMmallocationProposalItemId { get; set; }

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

    [Column("MMCancelAllocationProposalItemProductName")]
    [StringLength(50)]
    public string MmcancelAllocationProposalItemProductName { get; set; }

    [Column("MMCancelAllocationProposalItemProductDesc", TypeName = "ntext")]
    public string MmcancelAllocationProposalItemProductDesc { get; set; }

    [Column("MMCancelAllocationProposalItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemHeight { get; set; }

    [Column("MMCancelAllocationProposalItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemWidth { get; set; }

    [Column("MMCancelAllocationProposalItemLength", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemLength { get; set; }

    [Column("MMCancelAllocationProposalItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemHeightMin { get; set; }

    [Column("MMCancelAllocationProposalItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemWidthMin { get; set; }

    [Column("MMCancelAllocationProposalItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemLengthMin { get; set; }

    [Column("MMCancelAllocationProposalItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemHeightMax { get; set; }

    [Column("MMCancelAllocationProposalItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemWidthMax { get; set; }

    [Column("MMCancelAllocationProposalItemLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemLengthMax { get; set; }

    [Column("MMCancelAllocationProposalItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemQty { get; set; }

    [Column("MMCancelAllocationProposalItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemWoodQty { get; set; }

    [Column("MMCancelAllocationProposalItemShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemShippedQty { get; set; }

    [Column("MMCancelAllocationProposalItemComment")]
    [StringLength(50)]
    public string MmcancelAllocationProposalItemComment { get; set; }

    [Column("MMCancelAllocationProposalItemShippedWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemShippedWoodQty { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("MMCancelAllocationProposalItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemProductPerimeter { get; set; }

    [Column("MMCancelAllocationProposalItemCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemCancelQty { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("MMCancelAllocationProposalItemProductSerialNo")]
    [StringLength(50)]
    public string MmcancelAllocationProposalItemProductSerialNo { get; set; }

    [Column("MMCancelAllocationProposalItemLotNo")]
    [StringLength(50)]
    public string MmcancelAllocationProposalItemLotNo { get; set; }

    [Column("MMCancelAllocationProposalItemHWQtySource")]
    [StringLength(50)]
    public string MmcancelAllocationProposalItemHwqtySource { get; set; }

    [Column("MMCancelAllocationProposalItemBPProductionNormItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcancelAllocationProposalItemBpproductionNormItemQty { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("MMCancelAllocationProposalItemBatchProductItemProductSerial")]
    [StringLength(50)]
    public string MmcancelAllocationProposalItemBatchProductItemProductSerial { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("MMCancelAllocationProposalItemProductSupplierNumber")]
    [StringLength(50)]
    public string MmcancelAllocationProposalItemProductSupplierNumber { get; set; }

    [Column("FK_MMCancelAllocationProposalID")]
    public int? FkMmcancelAllocationProposalId { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmcancelAllocationProposalItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmcancelAllocationProposalItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmcancelAllocationProposalItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmcancelAllocationProposalItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmcancelAllocationProposalItemFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmallocationPlanItemId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual MmallocationPlanItem FkMmallocationPlanItem { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmallocationProposalItemId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual MmallocationProposalItem FkMmallocationProposalItem { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmcancelAllocationProposalId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual MmcancelAllocationProposal FkMmcancelAllocationProposal { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmcancelAllocationProposalItems")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
