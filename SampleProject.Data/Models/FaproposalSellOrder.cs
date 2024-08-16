using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAProposalSellOrders")]
public partial class FaproposalSellOrder
{
    [Key]
    [Column("FAProposalSellOrderID")]
    public int FaproposalSellOrderId { get; set; }

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
    public int? FaproposalId { get; set; }

    [Column("FASellOrderID")]
    public int? FasellOrderId { get; set; }

    [ForeignKey("FaproposalId")]
    [InverseProperty("FaproposalSellOrders")]
    public virtual Oeproposal Faproposal { get; set; }

    [ForeignKey("FasellOrderId")]
    [InverseProperty("FaproposalSellOrders")]
    public virtual ArsaleOrder FasellOrder { get; set; }
}
