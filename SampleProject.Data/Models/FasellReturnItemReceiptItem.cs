using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellReturnItemReceiptItems")]
public partial class FasellReturnItemReceiptItem
{
    [Key]
    [Column("FASellReturnItemReceiptItemID")]
    public int FasellReturnItemReceiptItemId { get; set; }

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

    [Column("FAReceiptItemID")]
    public int? FareceiptItemId { get; set; }

    [ForeignKey("FareceiptItemId")]
    [InverseProperty("FasellReturnItemReceiptItems")]
    public virtual IcreceiptItem FareceiptItem { get; set; }

    [ForeignKey("FasellReturnItemId")]
    [InverseProperty("FasellReturnItemReceiptItems")]
    public virtual FasellReturnItem FasellReturnItem { get; set; }
}
