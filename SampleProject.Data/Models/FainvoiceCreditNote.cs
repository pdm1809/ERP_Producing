using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAInvoiceCreditNotes")]
public partial class FainvoiceCreditNote
{
    [Key]
    [Column("FAInvoiceCreditNoteID")]
    public int FainvoiceCreditNoteId { get; set; }

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

    [Column("FACreditNoteID")]
    public int? FacreditNoteId { get; set; }

    [ForeignKey("FacreditNoteId")]
    [InverseProperty("FainvoiceCreditNotes")]
    public virtual FacreditNote FacreditNote { get; set; }

    [ForeignKey("FainvoiceId")]
    [InverseProperty("FainvoiceCreditNotes")]
    public virtual Arinvoice Fainvoice { get; set; }
}
