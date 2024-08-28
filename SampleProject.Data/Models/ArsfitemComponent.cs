using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSFItemComponents")]
public partial class ArsfitemComponent
{
    [Key]
    [Column("ARSFItemComponentID")]
    public int ArsfitemComponentId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleForecastItemID")]
    public int FkArsaleForecastItemId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("ARSFItemComponentQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsfitemComponentQty { get; set; }

    [Column("ARSFItemComponentShippedQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsfitemComponentShippedQty { get; set; }

    [Column("ARSFItemComponentProductSOQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsfitemComponentProductSoqty { get; set; }

    [ForeignKey("FkArsaleForecastItemId")]
    [InverseProperty("ArsfitemComponents")]
    public virtual ArsaleForecastItem FkArsaleForecastItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsfitemComponents")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArsfitemComponents")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArsfitemComponents")]
    public virtual Icstock FkIcstock { get; set; }
}
