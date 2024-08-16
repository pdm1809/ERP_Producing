using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReceiptItemCreditNoteItems")]
public partial class FareceiptItemCreditNoteItem
{
    [Key]
    [Column("FAReceiptItemCreditNoteItemID")]
    public int FareceiptItemCreditNoteItemId { get; set; }

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

    [Column("FAReceiptItemID")]
    public int? FareceiptItemId { get; set; }

    [Column("FACreditNoteItemID")]
    public int? FacreditNoteItemId { get; set; }

    [ForeignKey("FacreditNoteItemId")]
    [InverseProperty("FareceiptItemCreditNoteItems")]
    public virtual FacreditNoteItem FacreditNoteItem { get; set; }

    [ForeignKey("FareceiptItemId")]
    [InverseProperty("FareceiptItemCreditNoteItems")]
    public virtual IcreceiptItem FareceiptItem { get; set; }
}
