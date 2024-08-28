using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseOrderItemDeliverys")]
public partial class AppurchaseOrderItemDelivery
{
    [Key]
    [Column("APPurchaseOrderItemDeliveryID")]
    public int AppurchaseOrderItemDeliveryId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_APPurchaseOrderItemID")]
    public int? FkAppurchaseOrderItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("APPurchaseOrderItemDeliveryProductName")]
    [StringLength(50)]
    public string AppurchaseOrderItemDeliveryProductName { get; set; }

    [Column("APPurchaseOrderItemDeliveryProductDesc")]
    [StringLength(4000)]
    public string AppurchaseOrderItemDeliveryProductDesc { get; set; }

    [Column("APPurchaseOrderItemDeliveryProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemDeliveryProductUnitPrice { get; set; }

    [Column("APPurchaseOrderItemDeliveryProductQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemDeliveryProductQty { get; set; }

    [Column("APPurchaseOrderItemDeliveryTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemDeliveryTotalCost { get; set; }

    [Column("APPurchaseOrderItemDeliveryDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderItemDeliveryDate { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppurchaseOrderItemDeliveries")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AppurchaseOrderItemDeliveries")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AppurchaseOrderItemDeliveries")]
    public virtual Icproduct FkIcproduct { get; set; }
}
