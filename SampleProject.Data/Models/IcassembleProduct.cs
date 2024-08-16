using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICAssembleProducts")]
public partial class IcassembleProduct
{
    [Key]
    [Column("ICAssembleProductID")]
    public int IcassembleProductId { get; set; }

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

    [Column("ICAssembleProductNo")]
    [StringLength(50)]
    public string IcassembleProductNo { get; set; }

    [Column("ICAssembleProductDate", TypeName = "datetime")]
    public DateTime? IcassembleProductDate { get; set; }

    [Column("ICAssembleProductLotNo")]
    [StringLength(50)]
    public string IcassembleProductLotNo { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICAssembleProductName")]
    [StringLength(256)]
    public string IcassembleProductName { get; set; }

    [Column("ICAssembleProductDesc")]
    [StringLength(512)]
    public string IcassembleProductDesc { get; set; }

    [Column("ICAssembleProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcassembleProductQty { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICAssembleProductStatus")]
    [StringLength(50)]
    public string IcassembleProductStatus { get; set; }

    [Column("ICAssembleProductPostedStatus")]
    [StringLength(50)]
    public string IcassembleProductPostedStatus { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("ICAssembleProductIsAverageCalculation")]
    public bool? IcassembleProductIsAverageCalculation { get; set; }

    [Column("ICAssembleProductIsSpecificCalculation")]
    public bool? IcassembleProductIsSpecificCalculation { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcassembleProducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcassembleProducts")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcassembleProducts")]
    public virtual Icstock FkIcstock { get; set; }

    [InverseProperty("FkIcassembleProduct")]
    public virtual ICollection<IcassembleProductDetail> IcassembleProductDetails { get; set; } = new List<IcassembleProductDetail>();
}
