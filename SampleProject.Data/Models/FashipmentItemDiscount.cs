using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("FAShipmentItemDiscount")]
public partial class FashipmentItemDiscount
{
    [Column("FAShipmentItemDiscountID")]
    public int FashipmentItemDiscountId { get; set; }

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

    [Column("FAShipmentItemID")]
    public int FashipmentItemId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Column("NEWFAShipmentDiscount")]
    public int? NewfashipmentDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FashipmentItemId")]
    public virtual IcshipmentItem FashipmentItem { get; set; }
}
