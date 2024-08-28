using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FACreditNoteItemDiscount")]
public partial class FacreditNoteItemDiscount
{
    [Key]
    [Column("FACreditNoteItemDiscountID")]
    public int FacreditNoteItemDiscountId { get; set; }

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

    [Column("FACreditNoteItemID")]
    public int FacreditNoteItemId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFACreditNoteDiscount")]
    public int? NewfacreditNoteDiscount { get; set; }

    [ForeignKey("FacreditNoteItemId")]
    [InverseProperty("FacreditNoteItemDiscounts")]
    public virtual FacreditNoteItem FacreditNoteItem { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FacreditNoteItemDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }
}
