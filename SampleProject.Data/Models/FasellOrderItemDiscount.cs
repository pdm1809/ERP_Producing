using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("FASellOrderItemDiscount")]
public partial class FasellOrderItemDiscount
{
    [Column("FASellOrderItemDiscountID")]
    public int FasellOrderItemDiscountId { get; set; }

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

    [Column("FASellOrderItemID")]
    public int FasellOrderItemId { get; set; }

    /// <summary>
    /// 0:Percent
    /// 1:Amount
    /// </summary>
    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFASellOrderDiscount")]
    public int? NewfasellOrderDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FasellOrderItemId")]
    public virtual Getext FasellOrderItem { get; set; }
}
