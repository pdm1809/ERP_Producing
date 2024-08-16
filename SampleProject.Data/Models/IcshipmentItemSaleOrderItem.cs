using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentItemSaleOrderItems")]
public partial class IcshipmentItemSaleOrderItem
{
    [Key]
    [Column("ICShipmentItemSaleOrderItemID")]
    public int IcshipmentItemSaleOrderItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ICShipmentItemID")]
    public int? FkIcshipmentItemId { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("IcshipmentItemSaleOrderItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcshipmentItemId")]
    [InverseProperty("IcshipmentItemSaleOrderItems")]
    public virtual IcshipmentItem FkIcshipmentItem { get; set; }
}
