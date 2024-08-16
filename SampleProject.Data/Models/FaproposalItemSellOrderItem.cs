using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAProposalItemSellOrderItems")]
public partial class FaproposalItemSellOrderItem
{
    [Key]
    [Column("FAProposalItemSellOrderItemID")]
    public int FaproposalItemSellOrderItemId { get; set; }

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
    public int? FaproposalItemId { get; set; }

    [Column("FASellOrderItemID")]
    public int? FasellOrderItemId { get; set; }

    [ForeignKey("FaproposalItemId")]
    [InverseProperty("FaproposalItemSellOrderItems")]
    public virtual FaproposalItem FaproposalItem { get; set; }

    [ForeignKey("FasellOrderItemId")]
    [InverseProperty("FaproposalItemSellOrderItems")]
    public virtual ArsaleOrderItem FasellOrderItem { get; set; }
}
