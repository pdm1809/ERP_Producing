using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCreditNoteInvoices")]
public partial class ArcreditNoteInvoice
{
    [Key]
    [Column("ARCreditNoteInvoiceID")]
    public int ArcreditNoteInvoiceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCreditNoteID")]
    public int? FkArcreditNoteId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [ForeignKey("FkArcreditNoteId")]
    [InverseProperty("ArcreditNoteInvoices")]
    public virtual ArcreditNote FkArcreditNote { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArcreditNoteInvoices")]
    public virtual Arinvoice FkArinvoice { get; set; }
}
