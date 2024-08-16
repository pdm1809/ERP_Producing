using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAShipmentDiscounts")]
public partial class FashipmentDiscount
{
    [Key]
    [Column("FAShipmentDiscountID")]
    public int FashipmentDiscountId { get; set; }

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

    [Column("FAShipmentID")]
    public int FashipmentId { get; set; }

    [Column("FADiscountID")]
    public int FadiscountId { get; set; }

    [Required]
    [Column("NEWFAShipmentDiscount")]
    [StringLength(10)]
    public string NewfashipmentDiscount { get; set; }

    [ForeignKey("FadiscountId")]
    [InverseProperty("FashipmentDiscounts")]
    public virtual Addiscount Fadiscount { get; set; }

    [ForeignKey("FashipmentId")]
    [InverseProperty("FashipmentDiscounts")]
    public virtual Icshipment Fashipment { get; set; }
}
