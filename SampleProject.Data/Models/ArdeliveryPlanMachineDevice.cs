using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanMachineDevices")]
public partial class ArdeliveryPlanMachineDevice
{
    [Key]
    [Column("ARDeliveryPlanMachineDeviceID")]
    public int ArdeliveryPlanMachineDeviceId { get; set; }

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

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ARDeliveryPlanMachineDeviceSaleOrderNo")]
    [StringLength(50)]
    public string ArdeliveryPlanMachineDeviceSaleOrderNo { get; set; }

    [Column("ARDeliveryPlanMachineDeviceSaleOrderDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanMachineDeviceSaleOrderDate { get; set; }

    [Column("ARDeliveryPlanMachineDeviceDeliveryDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanMachineDeviceDeliveryDate { get; set; }

    [Column("ARDeliveryPlanMachineDeviceProductNo")]
    [StringLength(50)]
    public string ArdeliveryPlanMachineDeviceProductNo { get; set; }

    [Column("ARDeliveryPlanMachineDeviceProductName")]
    [StringLength(256)]
    public string ArdeliveryPlanMachineDeviceProductName { get; set; }

    [Column("ARDeliveryPlanMachineDeviceProductDesc")]
    [StringLength(512)]
    public string ArdeliveryPlanMachineDeviceProductDesc { get; set; }

    [Column("ARDeliveryPlanMachineDeviceProductType")]
    [StringLength(256)]
    public string ArdeliveryPlanMachineDeviceProductType { get; set; }

    [Column("ARDeliveryPlanMachineDeviceProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanMachineDeviceProductQty { get; set; }

    [Column("ARDeliveryPlanMachineDeviceAddress")]
    [StringLength(512)]
    public string ArdeliveryPlanMachineDeviceAddress { get; set; }

    [Column("ARDeliveryPlanMachineDeviceCommand")]
    [StringLength(512)]
    public string ArdeliveryPlanMachineDeviceCommand { get; set; }

    [Column("ARDeliveryPlanMachineDeviceSource")]
    [StringLength(50)]
    public string ArdeliveryPlanMachineDeviceSource { get; set; }

    [Column("ARDeliveryPlanMachineDeviceStatus")]
    [StringLength(50)]
    public string ArdeliveryPlanMachineDeviceStatus { get; set; }

    [Column("ARDeliveryPlanMachineDeviceDeliveryActualDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanMachineDeviceDeliveryActualDate { get; set; }

    [Column("ARDeliveryPlanMachineDeviceCancelReason")]
    [StringLength(256)]
    public string ArdeliveryPlanMachineDeviceCancelReason { get; set; }

    [Column("ARDeliveryPlanMachineDeviceCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanMachineDeviceCancelQty { get; set; }

    [Column("ARDeliveryPlanMachineDevicePlanQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanMachineDevicePlanQty { get; set; }

    [Column("ARDeliveryPlanMachineDeviceShipmentQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanMachineDeviceShipmentQty { get; set; }

    [Column("ARDeliveryPlanMachineDeviceDeliveryQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanMachineDeviceDeliveryQty { get; set; }

    [Column("ARDeliveryPlanMachineDeviceDeliveryAddressStreet")]
    [StringLength(256)]
    public string ArdeliveryPlanMachineDeviceDeliveryAddressStreet { get; set; }

    [Column("ARDeliveryPlanMachineDeviceDeliveryAddressWard")]
    [StringLength(256)]
    public string ArdeliveryPlanMachineDeviceDeliveryAddressWard { get; set; }

    [Column("FK_GEDeliveryDistrictID")]
    public int? FkGedeliveryDistrictId { get; set; }

    [Column("FK_GEDeliveryStateProvinceID")]
    public int? FkGedeliveryStateProvinceId { get; set; }

    [Column("ARDeliveryPlanMachineDeviceProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanMachineDeviceProductHeight { get; set; }

    [Column("ARDeliveryPlanMachineDeviceProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanMachineDeviceProductWidth { get; set; }

    [Column("ARDeliveryPlanMachineDeviceProductLength", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanMachineDeviceProductLength { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArdeliveryPlanMachineDevices")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanMachineDevices")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArdeliveryPlanMachineDevices")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArdeliveryPlanMachineDevices")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkGedeliveryDistrictId")]
    [InverseProperty("ArdeliveryPlanMachineDevices")]
    public virtual Gedistrict FkGedeliveryDistrict { get; set; }

    [ForeignKey("FkGedeliveryStateProvinceId")]
    [InverseProperty("ArdeliveryPlanMachineDevices")]
    public virtual GestateProvince FkGedeliveryStateProvince { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArdeliveryPlanMachineDevices")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArdeliveryPlanMachineDevices")]
    public virtual Icproduct FkIcproduct { get; set; }
}
