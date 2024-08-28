using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderDiscounts")]
public partial class FapurchaseOrderDiscount
{
    [Key]
    [Column("FAPurchaseOrderDiscountID")]
    public int FapurchaseOrderDiscountId { get; set; }

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
    public int FapurchaseOrderId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAPurchaseOrderDiscount")]
    public int NewfapurchaseOrderDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FapurchaseOrderDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FapurchaseOrderId")]
    [InverseProperty("FapurchaseOrderDiscounts")]
    public virtual FapurchaseOrder FapurchaseOrder { get; set; }
}
