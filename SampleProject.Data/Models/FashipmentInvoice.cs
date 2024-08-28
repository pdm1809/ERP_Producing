using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAShipmentInvoices")]
public partial class FashipmentInvoice
{
    [Key]
    [Column("FAShipmentInvoiceID")]
    public int FashipmentInvoiceId { get; set; }

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
    public int? FainvoiceId { get; set; }

    [Column("FAShipmentID")]
    public int? FashipmentId { get; set; }

    [ForeignKey("FainvoiceId")]
    [InverseProperty("FashipmentInvoices")]
    public virtual Arinvoice Fainvoice { get; set; }

    [ForeignKey("FashipmentId")]
    [InverseProperty("FashipmentInvoices")]
    public virtual Icshipment Fashipment { get; set; }
}
