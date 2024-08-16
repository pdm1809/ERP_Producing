using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMWoodPlanItemDetails")]
public partial class MmwoodPlanItemDetail
{
    [Key]
    [Column("MMWoodPlanItemDetailID")]
    public int MmwoodPlanItemDetailId { get; set; }

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

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Column("FK_MMWoodPlanItemID")]
    public int? FkMmwoodPlanItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICSemiProductID")]
    public int? FkIcsemiProductId { get; set; }

    [Column("MMWoodPlanItemDetailProductNo")]
    [StringLength(50)]
    public string MmwoodPlanItemDetailProductNo { get; set; }

    [Column("MMWoodPlanItemDetailProductName")]
    [StringLength(512)]
    public string MmwoodPlanItemDetailProductName { get; set; }

    [Column("MMWoodPlanItemDetailProductDesc")]
    [StringLength(512)]
    public string MmwoodPlanItemDetailProductDesc { get; set; }

    [Column("MMWoodPlanItemDetailHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailHeight { get; set; }

    [Column("MMWoodPlanItemDetailWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailWidth { get; set; }

    [Column("MMWoodPlanItemDetailLength", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailLength { get; set; }

    [Column("MMWoodPlanItemDetailQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailQuantity { get; set; }

    [Column("MMWoodPlanItemDetailBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailBlocks { get; set; }

    [Column("MMWoodPlanItemDetailProductDryHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailProductDryHeight { get; set; }

    [Column("MMWoodPlanItemDetailProductFreshHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailProductFreshHeight { get; set; }

    [Column("MMWoodPlanItemDetailProductDryBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailProductDryBlocks { get; set; }

    [Column("MMWoodPlanItemDetailProductFreshBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailProductFreshBlocks { get; set; }

    [Column("MMWoodPlanItemDetailAllocationQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailAllocationQuantity { get; set; }

    [Column("MMWoodPlanItemDetailPurchaseQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailPurchaseQuantity { get; set; }

    [Column("MMWoodPlanItemDetailRoundWoodBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailRoundWoodBlocks { get; set; }

    [Column("MMWoodPlanItemDetailAllocationType")]
    [StringLength(50)]
    public string MmwoodPlanItemDetailAllocationType { get; set; }

    [Column("MMWoodPlanItemDetailDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailDepreciationRate { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("MMWoodPlanItemDetailProductDryWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailProductDryWidth { get; set; }

    [Column("MMWoodPlanItemDetailProductDryLength", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailProductDryLength { get; set; }

    [Column("MMWoodPlanItemDetailMaterialQty", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanItemDetailMaterialQty { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmwoodPlanItemDetailFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmwoodPlanItemDetailFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmwoodPlanItemDetailFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmwoodPlanItemDetailFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcsemiProductId")]
    [InverseProperty("MmwoodPlanItemDetailFkIcsemiProducts")]
    public virtual Icproduct FkIcsemiProduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmwoodPlanItemDetails")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmwoodPlanItemDetails")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmwoodPlanItemDetails")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [ForeignKey("FkMmwoodPlanItemId")]
    [InverseProperty("MmwoodPlanItemDetails")]
    public virtual MmwoodPlanItem FkMmwoodPlanItem { get; set; }

    [InverseProperty("FkMmwoodPlanItemDetail")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkMmwoodPlanItemDetail")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmwoodPlanItemDetail")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();
}
