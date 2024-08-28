using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARConfigOriginalUnitPrices")]
public partial class ArconfigOriginalUnitPrice
{
    [Key]
    [Column("ARConfigOriginalUnitPriceID")]
    public int ArconfigOriginalUnitPriceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("ACBalanceDate", TypeName = "datetime")]
    public DateTime? AcbalanceDate { get; set; }

    [Column("ARConfigOriginalUnitPriceHachCode")]
    public bool? ArconfigOriginalUnitPriceHachCode { get; set; }

    [Column("ARConfigOriginalUnitPriceVoucher")]
    public bool? ArconfigOriginalUnitPriceVoucher { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArconfigOriginalUnitPrices")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
