using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("FAReturnSupplierDiscount")]
public partial class FareturnSupplierDiscount
{
    [Column("FAReturnSupplierDiscountID")]
    public int FareturnSupplierDiscountId { get; set; }

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

    [Column("FAReturnSupplierID")]
    public int FareturnSupplierId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Required]
    [Column("NEWFAShipmentDiscount")]
    [StringLength(10)]
    public string NewfashipmentDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FareturnSupplierId")]
    public virtual FareturnSupplier FareturnSupplier { get; set; }
}
