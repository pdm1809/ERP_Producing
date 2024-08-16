using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("FAReturnSupplierItemDiscount")]
public partial class FareturnSupplierItemDiscount
{
    [Column("FAReturnSupplierItemDiscountID")]
    public int FareturnSupplierItemDiscountId { get; set; }

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

    [Column("FAReturnSupplierItemID")]
    public int FareturnSupplierItemId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAReturnSupplierDiscount")]
    public int? NewfareturnSupplierDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FareturnSupplierItemId")]
    public virtual FareturnSupplierItem FareturnSupplierItem { get; set; }
}
