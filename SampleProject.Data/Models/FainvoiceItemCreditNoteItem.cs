using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAInvoiceItemCreditNoteItems")]
public partial class FainvoiceItemCreditNoteItem
{
    [Key]
    [Column("FAInvoiceItemCreditNoteItemID")]
    public int FainvoiceItemCreditNoteItemId { get; set; }

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

    [Column("FAInvoiceItemId")]
    public int? FainvoiceItemId { get; set; }

    [Column("FACreditNoteItemID")]
    public int? FacreditNoteItemId { get; set; }

    [ForeignKey("FacreditNoteItemId")]
    [InverseProperty("FainvoiceItemCreditNoteItems")]
    public virtual FacreditNoteItem FacreditNoteItem { get; set; }
}
