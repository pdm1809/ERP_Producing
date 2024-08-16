using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FACreditNoteDiscounts")]
public partial class FacreditNoteDiscount
{
    [Key]
    [Column("FACreditNoteDiscountID")]
    public int FacreditNoteDiscountId { get; set; }

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

    [Column("FACreditNoteID")]
    public int FacreditNoteId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFACreditNoteDiscount")]
    public int NewfacreditNoteDiscount { get; set; }

    [ForeignKey("FacreditNoteId")]
    [InverseProperty("FacreditNoteDiscounts")]
    public virtual FacreditNote FacreditNote { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FacreditNoteDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }
}
