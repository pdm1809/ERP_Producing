using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICAssembleProductDetails")]
public partial class IcassembleProductDetail
{
    [Key]
    [Column("ICAssembleProductDetailID")]
    public int IcassembleProductDetailId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICAssembleProductID")]
    public int? FkIcassembleProductId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICAssembleProductDetailProductName")]
    [StringLength(256)]
    public string IcassembleProductDetailProductName { get; set; }

    [Column("ICAssembleProductDetailProductDesc")]
    [StringLength(512)]
    public string IcassembleProductDetailProductDesc { get; set; }

    [Column("ICAssembleProductDetailNormQty", TypeName = "decimal(18, 5)")]
    public decimal? IcassembleProductDetailNormQty { get; set; }

    [Column("ICAssembleProductDetailMixQty", TypeName = "decimal(18, 5)")]
    public decimal? IcassembleProductDetailMixQty { get; set; }

    [Column("ICAssembleProductDetailCanAssembleQty", TypeName = "decimal(18, 5)")]
    public decimal? IcassembleProductDetailCanAssembleQty { get; set; }

    [Column("ICAssembleProductDetailProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcassembleProductDetailProductQty { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICAssembleProductDetailIsAverageCalculation")]
    public bool? IcassembleProductDetailIsAverageCalculation { get; set; }

    [Column("ICAssembleProductDetailIsSpecificCalculation")]
    public bool? IcassembleProductDetailIsSpecificCalculation { get; set; }

    [ForeignKey("FkIcassembleProductId")]
    [InverseProperty("IcassembleProductDetails")]
    public virtual IcassembleProduct FkIcassembleProduct { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcassembleProductDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcassembleProductDetails")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcassembleProductDetails")]
    public virtual Icstock FkIcstock { get; set; }
}
