using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceRequests")]
public partial class ArinvoiceRequest
{
    [Key]
    [Column("ARInvoiceRequestID")]
    public int ArinvoiceRequestId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ARInvoiceRequestKey")]
    [StringLength(100)]
    public string ArinvoiceRequestKey { get; set; }

    [Required]
    [Column("ARInvoiceRequestKeyValue")]
    [StringLength(100)]
    public string ArinvoiceRequestKeyValue { get; set; }

    [Column("ARInvoiceRequestText")]
    [StringLength(1000)]
    public string ArinvoiceRequestText { get; set; }

    [Column("ARInvoiceRequestKeyDesc")]
    [StringLength(500)]
    public string ArinvoiceRequestKeyDesc { get; set; }

    [InverseProperty("FkArinvoiceRequest")]
    public virtual ICollection<Aracceptance> Aracceptances { get; set; } = new List<Aracceptance>();

    [InverseProperty("FkArinvoiceRequest")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkArinvoiceRequest")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArinvoiceRequest")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();
}
