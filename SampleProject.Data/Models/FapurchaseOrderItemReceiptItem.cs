using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderItemReceiptItems")]
public partial class FapurchaseOrderItemReceiptItem
{
    [Key]
    [Column("FAPurchaseOrderItemReceiptItemID")]
    public int FapurchaseOrderItemReceiptItemId { get; set; }

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

    [Column("FAReceiptItemID")]
    public int? FareceiptItemId { get; set; }

    [Column("FAPurchaseOrderItemID")]
    public int? FapurchaseOrderItemId { get; set; }

    [ForeignKey("FapurchaseOrderItemId")]
    [InverseProperty("FapurchaseOrderItemReceiptItems")]
    public virtual FapurchaseOrderItem FapurchaseOrderItem { get; set; }

    [ForeignKey("FareceiptItemId")]
    [InverseProperty("FapurchaseOrderItemReceiptItems")]
    public virtual IcreceiptItem FareceiptItem { get; set; }
}
