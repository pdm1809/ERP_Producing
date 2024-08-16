using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductPrices")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ICProductPrices")]
public partial class IcproductPrice
{
    [Key]
    [Column("ICProductPriceID")]
    public int IcproductPriceId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ARPriceLevelID")]
    public int FkArpriceLevelId { get; set; }

    [Column("ICProductPriceMarkDown", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPriceMarkDown { get; set; }

    [ForeignKey("FkArpriceLevelId")]
    [InverseProperty("IcproductPrices")]
    public virtual ArpriceLevel FkArpriceLevel { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductPrices")]
    public virtual Icproduct FkIcproduct { get; set; }
}
