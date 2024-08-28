using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellReturnItemDiscount")]
public partial class FasellReturnItemDiscount
{
    [Key]
    [Column("FASellReturnItemDiscountID")]
    public int FasellReturnItemDiscountId { get; set; }

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

    [Column("FASellReturnItemID")]
    public int FasellReturnItemId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFASellReturnDiscount")]
    public int? NewfasellReturnDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FasellReturnItemDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FasellReturnItemId")]
    [InverseProperty("FasellReturnItemDiscounts")]
    public virtual FasellReturnItem FasellReturnItem { get; set; }
}
