using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReceiptDiscounts")]
public partial class FareceiptDiscount
{
    [Key]
    [Column("FAReceiptDiscountID")]
    public int FareceiptDiscountId { get; set; }

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

    [Column("FAReceiptID")]
    public int FareceiptId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAReceiptDiscount")]
    public int NewfareceiptDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FareceiptDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FareceiptId")]
    [InverseProperty("FareceiptDiscounts")]
    public virtual Icreceipt Fareceipt { get; set; }
}
