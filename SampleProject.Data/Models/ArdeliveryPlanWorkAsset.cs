using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanWorkAssets")]
public partial class ArdeliveryPlanWorkAsset
{
    [Key]
    [Column("ARDeliveryPlanWorkAssetID")]
    public int ArdeliveryPlanWorkAssetId { get; set; }

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

    [Column("FK_ARDeliveryPlanItemID")]
    public int? FkArdeliveryPlanItemId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ARDeliveryPlanWorkAssetProductNo")]
    [StringLength(50)]
    public string ArdeliveryPlanWorkAssetProductNo { get; set; }

    [Column("ARDeliveryPlanWorkAssetProductName")]
    [StringLength(256)]
    public string ArdeliveryPlanWorkAssetProductName { get; set; }

    [Column("ARDeliveryPlanWorkAssetProductDesc")]
    [StringLength(512)]
    public string ArdeliveryPlanWorkAssetProductDesc { get; set; }

    [Column("ARDeliveryPlanWorkAssetProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkAssetProductQty { get; set; }

    [Column("ARDeliveryPlanWorkAssetProductType")]
    [StringLength(50)]
    public string ArdeliveryPlanWorkAssetProductType { get; set; }

    [Column("ARDeliveryPlanWorkAssetProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkAssetProductUnitPrice { get; set; }

    [Column("ARDeliveryPlanWorkAssetTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkAssetTotalAmount { get; set; }

    [Column("ARDeliveryPlanWorkAssetSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkAssetSubTotalAmount { get; set; }

    [Column("ARDeliveryPlanWorkAssetProductChargeCheck")]
    public bool? ArdeliveryPlanWorkAssetProductChargeCheck { get; set; }

    [Column("ARDeliveryPlanWorkAssetStatus")]
    [StringLength(50)]
    public string ArdeliveryPlanWorkAssetStatus { get; set; }

    [Column("ARDeliveryPlanWorkAssetIsCost")]
    public bool? ArdeliveryPlanWorkAssetIsCost { get; set; }

    [Column("ARDeliveryPlanWorkAssetAllocationQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkAssetAllocationQty { get; set; }

    [InverseProperty("FkArdeliveryPlanWorkAsset")]
    public virtual ICollection<ArallocationItem> ArallocationItems { get; set; } = new List<ArallocationItem>();

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanWorkAssets")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanItemId")]
    [InverseProperty("ArdeliveryPlanWorkAssets")]
    public virtual ArdeliveryPlanItem FkArdeliveryPlanItem { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArdeliveryPlanWorkAssets")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArdeliveryPlanWorkAssets")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArdeliveryPlanWorkAssets")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArdeliveryPlanWorkAssets")]
    public virtual Icproduct FkIcproduct { get; set; }
}
