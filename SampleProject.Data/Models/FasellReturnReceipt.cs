using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellReturnReceipts")]
public partial class FasellReturnReceipt
{
    [Key]
    [Column("FASellReturnReceiptID")]
    public int FasellReturnReceiptId { get; set; }

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

    [Column("FASellReturnID")]
    public int? FasellReturnId { get; set; }

    [Column("FAReceiptID")]
    public int? FareceiptId { get; set; }

    [ForeignKey("FareceiptId")]
    [InverseProperty("FasellReturnReceipts")]
    public virtual Icreceipt Fareceipt { get; set; }

    [ForeignKey("FasellReturnId")]
    [InverseProperty("FasellReturnReceipts")]
    public virtual FasellReturn FasellReturn { get; set; }
}
