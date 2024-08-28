using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPaymentMethods")]
public partial class AdpaymentMethod
{
    [Key]
    [Column("ADPaymentMethodID")]
    public int AdpaymentMethodId { get; set; }

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

    [Required]
    [Column("ADPaymentMethodName")]
    [StringLength(50)]
    public string AdpaymentMethodName { get; set; }

    [Column("ADPaymentMethodDesc")]
    [StringLength(255)]
    public string AdpaymentMethodDesc { get; set; }
}
