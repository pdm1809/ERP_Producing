using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAProposalDiscounts")]
public partial class FaproposalDiscount
{
    [Key]
    [Column("FAProposalDiscountID")]
    public int FaproposalDiscountId { get; set; }

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

    [Column("FAProposalID")]
    public int FaproposalId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAProposalDiscount")]
    public int NewfaproposalDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FaproposalDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FaproposalId")]
    [InverseProperty("FaproposalDiscounts")]
    public virtual Oeproposal Faproposal { get; set; }
}
