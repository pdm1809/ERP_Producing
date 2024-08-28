using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderItemDiscount")]
public partial class FapurchaseOrderItemDiscount
{
    [Key]
    [Column("FAPurchaseOrderItemDiscountID")]
    public int FapurchaseOrderItemDiscountId { get; set; }

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
    public int FapurchaseOrderItemId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAPurchaseOrderDiscount")]
    public int? NewfapurchaseOrderDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FapurchaseOrderItemDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FapurchaseOrderItemId")]
    [InverseProperty("FapurchaseOrderItemDiscounts")]
    public virtual FapurchaseOrderItem FapurchaseOrderItem { get; set; }
}
