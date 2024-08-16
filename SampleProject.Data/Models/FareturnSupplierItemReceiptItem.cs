using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReturnSupplierItemReceiptItems")]
public partial class FareturnSupplierItemReceiptItem
{
    [Key]
    [Column("FAReturnSupplierItemReceiptItemID")]
    public int FareturnSupplierItemReceiptItemId { get; set; }

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

    [Column("FAReturnSupplierItemID")]
    public int? FareturnSupplierItemId { get; set; }

    [ForeignKey("FareceiptItemId")]
    [InverseProperty("FareturnSupplierItemReceiptItems")]
    public virtual IcreceiptItem FareceiptItem { get; set; }

    [ForeignKey("FareturnSupplierItemId")]
    [InverseProperty("FareturnSupplierItemReceiptItems")]
    public virtual FareturnSupplierItem FareturnSupplierItem { get; set; }
}
