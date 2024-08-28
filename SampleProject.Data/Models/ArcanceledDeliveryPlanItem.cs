using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCanceledDeliveryPlanItems")]
public partial class ArcanceledDeliveryPlanItem
{
    [Key]
    [Column("ARCanceledDeliveryPlanItemID")]
    public int ArcanceledDeliveryPlanItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCanceledDeliveryPlanID")]
    public int FkArcanceledDeliveryPlanId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARDeliveryPlanItemID")]
    public int? FkArdeliveryPlanItemId { get; set; }

    [Column("ARCanceledDeliveryPlanItemProductNo")]
    [StringLength(50)]
    public string ArcanceledDeliveryPlanItemProductNo { get; set; }

    [Column("ARCanceledDeliveryPlanItemProductName")]
    [StringLength(50)]
    public string ArcanceledDeliveryPlanItemProductName { get; set; }

    [Column("ARCanceledDeliveryPlanItemProductDesc")]
    [StringLength(512)]
    public string ArcanceledDeliveryPlanItemProductDesc { get; set; }

    [Column("ARCanceledDeliveryPlanItemSaleOrderNo")]
    [StringLength(50)]
    public string ArcanceledDeliveryPlanItemSaleOrderNo { get; set; }

    [Column("ARCanceledDeliveryPlanItemQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcanceledDeliveryPlanItemQty { get; set; }

    [Column("ARCanceledDeliveryPlanItemTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcanceledDeliveryPlanItemTotalQty { get; set; }

    [Column("ARCanceledDeliveryPlanItemComment")]
    [StringLength(512)]
    public string ArcanceledDeliveryPlanItemComment { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("ARCanceledDeliveryPlanItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcanceledDeliveryPlanItemWoodQty { get; set; }

    [Column("ARCanceledDeliveryPlanItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArcanceledDeliveryPlanItemProductNoOfOldSys { get; set; }

    [Column("ARCanceledDeliveryPlanItemProductCustomerNumber")]
    [StringLength(50)]
    public string ArcanceledDeliveryPlanItemProductCustomerNumber { get; set; }

    [ForeignKey("FkArcanceledDeliveryPlanId")]
    [InverseProperty("ArcanceledDeliveryPlanItems")]
    public virtual ArcanceledDeliveryPlan FkArcanceledDeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanItemId")]
    [InverseProperty("ArcanceledDeliveryPlanItems")]
    public virtual ArdeliveryPlanItem FkArdeliveryPlanItem { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArcanceledDeliveryPlanItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArcanceledDeliveryPlanItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArcanceledDeliveryPlanItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcanceledDeliveryPlanItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArcanceledDeliveryPlanItems")]
    public virtual Icstock FkIcstock { get; set; }
}
