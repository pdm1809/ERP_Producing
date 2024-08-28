using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderSellOrders")]
public partial class FapurchaseOrderSellOrder
{
    [Key]
    [Column("FAPurchaseOrderSellOrderID")]
    public int FapurchaseOrderSellOrderId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FAPurchaseOrderID")]
    public int? FapurchaseOrderId { get; set; }

    [Column("FASellOrderID")]
    public int? FasellOrderId { get; set; }

    [ForeignKey("FapurchaseOrderId")]
    [InverseProperty("FapurchaseOrderSellOrders")]
    public virtual FapurchaseOrder FapurchaseOrder { get; set; }

    [ForeignKey("FasellOrderId")]
    [InverseProperty("FapurchaseOrderSellOrders")]
    public virtual ArsaleOrder FasellOrder { get; set; }
}
