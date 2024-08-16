using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryMethods")]
public partial class ArdeliveryMethod
{
    [Key]
    [Column("ARDeliveryMethodID")]
    public int ArdeliveryMethodId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARDeliveryMethodNo")]
    [StringLength(50)]
    public string ArdeliveryMethodNo { get; set; }

    [Column("ARDeliveryMethodName")]
    [StringLength(256)]
    public string ArdeliveryMethodName { get; set; }

    [Column("ARDeliveryMethodIsDeliveryPlan")]
    public bool? ArdeliveryMethodIsDeliveryPlan { get; set; }

    [Column("ARDeliveryMethodIsSaleOrderShipment")]
    public bool? ArdeliveryMethodIsSaleOrderShipment { get; set; }

    [Column("ARDeliveryMethodIsAcceptance")]
    public bool? ArdeliveryMethodIsAcceptance { get; set; }

    [Column("ARDeliveryMethodIsInvoiceAndShipment")]
    public bool? ArdeliveryMethodIsInvoiceAndShipment { get; set; }

    [Column("ARDeliveryMethodIsVehicleAllocation")]
    public bool? ArdeliveryMethodIsVehicleAllocation { get; set; }

    [Column("ARDeliveryMethodSOCreateFromType")]
    [StringLength(100)]
    public string ArdeliveryMethodSocreateFromType { get; set; }

    [Column("ARDeliveryMethodIsContainerLoader")]
    public bool? ArdeliveryMethodIsContainerLoader { get; set; }

    [InverseProperty("FkArdeliveryMethod")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();
}
