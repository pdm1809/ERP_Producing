using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleReturnItemComponents")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ARSaleReturnItemComponents")]
public partial class ArsaleReturnItemComponent
{
    [Key]
    [Column("ARSaleReturnItemComponentID")]
    public int ArsaleReturnItemComponentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleReturnItemID")]
    public int FkArsaleReturnItemId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("ICProductSerieNo")]
    [StringLength(50)]
    public string IcproductSerieNo { get; set; }

    [Column("ARSaleReturnItemComponentQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleReturnItemComponentQty { get; set; }

    [ForeignKey("FkArsaleReturnItemId")]
    [InverseProperty("ArsaleReturnItemComponents")]
    public virtual ArsaleReturnItem FkArsaleReturnItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleReturnItemComponents")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("ArsaleReturnItemComponents")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ArsaleReturnItemComponents")]
    public virtual Icstock FkIcstock { get; set; }
}
