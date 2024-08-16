using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("FAShipmentItemReceiptItems")]
public partial class FashipmentItemReceiptItem
{
    [Column("FAShipmentItemReceiptItemID")]
    public int FashipmentItemReceiptItemId { get; set; }

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

    [Column("FAShipmentItemID")]
    public int? FashipmentItemId { get; set; }
}
