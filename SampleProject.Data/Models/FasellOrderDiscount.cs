using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellOrderDiscounts")]
public partial class FasellOrderDiscount
{
    [Key]
    [Column("FASellOrderDiscountID")]
    public int FasellOrderDiscountId { get; set; }

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

    [Column("FASellOrderID")]
    public int FasellOrderId { get; set; }

    /// <summary>
    /// 0:Percent
    /// 1:Amount
    /// </summary>
    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFASellOrderDiscount")]
    public int NewfasellOrderDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FasellOrderDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FasellOrderId")]
    [InverseProperty("FasellOrderDiscounts")]
    public virtual ArsaleOrder FasellOrder { get; set; }
}
