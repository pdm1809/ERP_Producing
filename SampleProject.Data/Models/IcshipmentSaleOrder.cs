using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentSaleOrders")]
public partial class IcshipmentSaleOrder
{
    [Key]
    [Column("ICShipmentSaleOrderID")]
    public int IcshipmentSaleOrderId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("IcshipmentSaleOrders")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("IcshipmentSaleOrders")]
    public virtual Icshipment FkIcshipment { get; set; }
}
