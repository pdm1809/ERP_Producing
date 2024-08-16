using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanTruckItems")]
public partial class ArdeliveryPlanTruckItem
{
    [Key]
    [Column("ARDeliveryPlanTruckItemID")]
    public int ArdeliveryPlanTruckItemId { get; set; }

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

    [Column("FK_ARDeliveryPlanTruckID")]
    public int? FkArdeliveryPlanTruckId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Column("FK_ARDeliveryPlanItemID")]
    public int? FkArdeliveryPlanItemId { get; set; }

    [Column("ARDeliveryPlanTruckItemDeliveryQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckItemDeliveryQty { get; set; }

    [Column("FK_ARDeliveryPlanTruckPointID")]
    public int? FkArdeliveryPlanTruckPointId { get; set; }

    [Column("ARDeliveryPlanTruckItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckItemProductHeight { get; set; }

    [Column("ARDeliveryPlanTruckItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckItemProductWidth { get; set; }

    [Column("ARDeliveryPlanTruckItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckItemProductLength { get; set; }

    [Column("FK_ICProductTruckID")]
    public int? FkIcproductTruckId { get; set; }

    [Column("FK_ARSaleReturnID")]
    public int? FkArsaleReturnId { get; set; }

    [Column("FK_ARSaleReturnItemID")]
    public int? FkArsaleReturnItemId { get; set; }

    [Column("FK_ICTransferID")]
    public int? FkIctransferId { get; set; }

    [Column("FK_ICTransferItemID")]
    public int? FkIctransferItemId { get; set; }

    [InverseProperty("FkArdeliveryPlanTruckItem")]
    public virtual ICollection<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; } = new List<ArdeliveryPlanFile>();

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanItemId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual ArdeliveryPlanItem FkArdeliveryPlanItem { get; set; }

    [ForeignKey("FkArdeliveryPlanTruckId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual ArdeliveryPlanTruck FkArdeliveryPlanTruck { get; set; }

    [ForeignKey("FkArdeliveryPlanTruckPointId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual ArdeliveryPlanTruckPoint FkArdeliveryPlanTruckPoint { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkArsaleReturnId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual ArsaleReturn FkArsaleReturn { get; set; }

    [ForeignKey("FkArsaleReturnItemId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual ArsaleReturnItem FkArsaleReturnItem { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArdeliveryPlanTruckItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductTruckId")]
    [InverseProperty("ArdeliveryPlanTruckItemFkIcproductTrucks")]
    public virtual Icproduct FkIcproductTruck { get; set; }

    [ForeignKey("FkIctransferId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual Ictransfer FkIctransfer { get; set; }

    [ForeignKey("FkIctransferItemId")]
    [InverseProperty("ArdeliveryPlanTruckItems")]
    public virtual IctransferItem FkIctransferItem { get; set; }
}
