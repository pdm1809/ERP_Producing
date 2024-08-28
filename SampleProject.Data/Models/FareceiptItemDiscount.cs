using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReceiptItemDiscount")]
public partial class FareceiptItemDiscount
{
    [Key]
    [Column("FAReceiptItemDiscountID")]
    public int FareceiptItemDiscountId { get; set; }

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

    [Column("FAReceiptItemID")]
    public int FareceiptItemId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAReceiptDiscount")]
    public int? NewfareceiptDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FareceiptItemDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FareceiptItemId")]
    [InverseProperty("FareceiptItemDiscounts")]
    public virtual IcreceiptItem FareceiptItem { get; set; }
}
