using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderReceipts")]
public partial class FapurchaseOrderReceipt
{
    [Key]
    [Column("FAPurchaseOrderReceiptID")]
    public int FapurchaseOrderReceiptId { get; set; }

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

    [Column("FAReceiptID")]
    public int? FareceiptId { get; set; }

    [Column("FAPurchaseOrderID")]
    public int? FapurchaseOrderId { get; set; }

    [ForeignKey("FapurchaseOrderId")]
    [InverseProperty("FapurchaseOrderReceipts")]
    public virtual FapurchaseOrder FapurchaseOrder { get; set; }

    [ForeignKey("FareceiptId")]
    [InverseProperty("FapurchaseOrderReceipts")]
    public virtual Icreceipt Fareceipt { get; set; }
}
