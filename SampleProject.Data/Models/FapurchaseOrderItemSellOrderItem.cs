using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderItemSellOrderItems")]
public partial class FapurchaseOrderItemSellOrderItem
{
    [Key]
    [Column("FAPurchaseOrderItemSellOrderItemID")]
    public int FapurchaseOrderItemSellOrderItemId { get; set; }

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

    [Column("FAPurchaseOrderItemID")]
    public int? FapurchaseOrderItemId { get; set; }

    [Column("FASellOrderItemID")]
    public int? FasellOrderItemId { get; set; }

    [ForeignKey("FapurchaseOrderItemId")]
    [InverseProperty("FapurchaseOrderItemSellOrderItems")]
    public virtual FapurchaseOrderItem FapurchaseOrderItem { get; set; }

    [ForeignKey("FasellOrderItemId")]
    [InverseProperty("FapurchaseOrderItemSellOrderItems")]
    public virtual ArsaleOrderItem FasellOrderItem { get; set; }
}
