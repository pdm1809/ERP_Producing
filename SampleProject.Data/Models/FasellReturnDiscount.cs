using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellReturnDiscounts")]
public partial class FasellReturnDiscount
{
    [Key]
    [Column("FASellReturnDiscountID")]
    public int FasellReturnDiscountId { get; set; }

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

    [Column("FASellReturnID")]
    public int FasellReturnId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFASellReturnDiscount")]
    public int NewfasellReturnDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FasellReturnDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FasellReturnId")]
    [InverseProperty("FasellReturnDiscounts")]
    public virtual FasellReturn FasellReturn { get; set; }
}
