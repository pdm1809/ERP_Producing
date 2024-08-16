using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReturnSupplierInvoices")]
public partial class FareturnSupplierInvoice
{
    [Key]
    [Column("FAReturnSupplierInvoiceID")]
    public int FareturnSupplierInvoiceId { get; set; }

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

    [Column("FAReturnSupplierID")]
    public int? FareturnSupplierId { get; set; }

    [ForeignKey("FainvoiceId")]
    [InverseProperty("FareturnSupplierInvoices")]
    public virtual Arinvoice Fainvoice { get; set; }

    [ForeignKey("FareturnSupplierId")]
    [InverseProperty("FareturnSupplierInvoices")]
    public virtual FareturnSupplier FareturnSupplier { get; set; }
}
