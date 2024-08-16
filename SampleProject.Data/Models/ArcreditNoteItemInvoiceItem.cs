using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCreditNoteItemInvoiceItems")]
public partial class ArcreditNoteItemInvoiceItem
{
    [Key]
    [Column("ARCreditNoteItemInvoiceItemID")]
    public int ArcreditNoteItemInvoiceItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCreditNoteItemID")]
    public int? FkArcreditNoteItemId { get; set; }

    [Column("FK_ARInvoiceItemID")]
    public int? FkArinvoiceItemId { get; set; }

    [ForeignKey("FkArcreditNoteItemId")]
    [InverseProperty("ArcreditNoteItemInvoiceItems")]
    public virtual ArcreditNoteItem FkArcreditNoteItem { get; set; }

    [ForeignKey("FkArinvoiceItemId")]
    [InverseProperty("ArcreditNoteItemInvoiceItems")]
    public virtual ArinvoiceItem FkArinvoiceItem { get; set; }
}
