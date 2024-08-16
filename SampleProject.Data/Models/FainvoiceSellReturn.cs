using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAInvoiceSellReturns")]
public partial class FainvoiceSellReturn
{
    [Key]
    [Column("FAInvoiceSellReturnID")]
    public int FainvoiceSellReturnId { get; set; }

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
    public int? FasellReturnId { get; set; }

    [Column("FAInvoiceID")]
    public int? FainvoiceId { get; set; }

    [ForeignKey("FainvoiceId")]
    [InverseProperty("FainvoiceSellReturns")]
    public virtual Arinvoice Fainvoice { get; set; }

    [ForeignKey("FasellReturnId")]
    [InverseProperty("FainvoiceSellReturns")]
    public virtual FasellReturn FasellReturn { get; set; }
}
