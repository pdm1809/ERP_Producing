using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("FAInvoiceItemDiscount")]
public partial class FainvoiceItemDiscount
{
    [Column("FAInvoiceItemDiscountID")]
    public int FainvoiceItemDiscountId { get; set; }

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

    [Column("FAInvoiceItemID")]
    public int FainvoiceItemId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAInvoiceDiscount")]
    public int? NewfainvoiceDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    public virtual Addiscount Fadiscount { get; set; }
}
