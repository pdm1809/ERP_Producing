using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReceiptCreditNotes")]
public partial class FareceiptCreditNote
{
    [Key]
    [Column("FAReceiptCreditNoteID")]
    public int FareceiptCreditNoteId { get; set; }

    [Required]
    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int AanumberInt { get; set; }

    [Required]
    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FAReceiptID")]
    public int FareceiptId { get; set; }

    [Column("FACreditNoteID")]
    public int FacreditNoteId { get; set; }

    [ForeignKey("FacreditNoteId")]
    [InverseProperty("FareceiptCreditNotes")]
    public virtual FacreditNote FacreditNote { get; set; }

    [ForeignKey("FareceiptId")]
    [InverseProperty("FareceiptCreditNotes")]
    public virtual Icreceipt Fareceipt { get; set; }
}
