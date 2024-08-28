using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAInvoiceDiscounts")]
public partial class FainvoiceDiscount
{
    [Key]
    [Column("FAInvoiceDiscountID")]
    public int FainvoiceDiscountId { get; set; }

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

    [Column("FAInvoiceID")]
    public int FainvoiceId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAInvoiceDiscount")]
    public int NewfainvoiceDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FainvoiceDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FainvoiceId")]
    [InverseProperty("FainvoiceDiscounts")]
    public virtual Arinvoice Fainvoice { get; set; }
}
