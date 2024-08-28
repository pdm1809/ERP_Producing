using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAInvoiceItemSellReturnItems")]
public partial class FainvoiceItemSellReturnItem
{
    [Key]
    [Column("FAInvoiceItemSellReturnItemID")]
    public int FainvoiceItemSellReturnItemId { get; set; }

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

    [Column("FASellReturnItemID")]
    public int? FasellReturnItemId { get; set; }

    [Column("FAInvoiceItemID")]
    public int? FainvoiceItemId { get; set; }

    [ForeignKey("FasellReturnItemId")]
    [InverseProperty("FainvoiceItemSellReturnItems")]
    public virtual FasellReturnItem FasellReturnItem { get; set; }
}
