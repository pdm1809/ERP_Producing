using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICDisassembleProductDetails")]
public partial class IcdisassembleProductDetail
{
    [Key]
    [Column("ICDisassembleProductDetailID")]
    public int IcdisassembleProductDetailId { get; set; }

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

    [Column("FK_ICDisassembleProductID")]
    public int? FkIcdisassembleProductId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICDisassembleProductDetailProductName")]
    [StringLength(256)]
    public string IcdisassembleProductDetailProductName { get; set; }

    [Column("ICDisassembleProductDetailProductDesc")]
    [StringLength(512)]
    public string IcdisassembleProductDetailProductDesc { get; set; }

    [Column("ICDisassembleProductDetailNormQty", TypeName = "decimal(18, 5)")]
    public decimal? IcdisassembleProductDetailNormQty { get; set; }

    [Column("ICDisassembleProductDetailMixQty", TypeName = "decimal(18, 5)")]
    public decimal? IcdisassembleProductDetailMixQty { get; set; }

    [Column("ICDisassembleProductDetailProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcdisassembleProductDetailProductQty { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICDisassembleProductDetailIsAverageCalculation")]
    public bool? IcdisassembleProductDetailIsAverageCalculation { get; set; }

    [Column("ICDisassembleProductDetailIsSpecificCalculation")]
    public bool? IcdisassembleProductDetailIsSpecificCalculation { get; set; }

    [ForeignKey("FkIcdisassembleProductId")]
    [InverseProperty("IcdisassembleProductDetails")]
    public virtual IcdisassembleProduct FkIcdisassembleProduct { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcdisassembleProductDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcdisassembleProductDetails")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcdisassembleProductDetails")]
    public virtual Icstock FkIcstock { get; set; }
}
