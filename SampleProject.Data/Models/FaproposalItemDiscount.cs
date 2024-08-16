using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAProposalItemDiscount")]
public partial class FaproposalItemDiscount
{
    [Key]
    [Column("FAProposalItemDiscountID")]
    public int FaproposalItemDiscountId { get; set; }

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

    [Column("FAProposalItemID")]
    public int FaproposalItemId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAProposalDiscount")]
    public int? NewfaproposalDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FaproposalItemDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FaproposalItemId")]
    [InverseProperty("FaproposalItemDiscounts")]
    public virtual FaproposalItem FaproposalItem { get; set; }
}
