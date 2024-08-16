using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICDisassembleProducts")]
public partial class IcdisassembleProduct
{
    [Key]
    [Column("ICDisassembleProductID")]
    public int IcdisassembleProductId { get; set; }

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

    [Column("ICDisassembleProductNo")]
    [StringLength(50)]
    public string IcdisassembleProductNo { get; set; }

    [Column("ICDisassembleProductDate", TypeName = "datetime")]
    public DateTime? IcdisassembleProductDate { get; set; }

    [Required]
    [Column("ICDisassembleProductLotNo")]
    [StringLength(50)]
    public string IcdisassembleProductLotNo { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICDisassembleProductName")]
    [StringLength(256)]
    public string IcdisassembleProductName { get; set; }

    [Column("ICDisassembleProductDesc")]
    [StringLength(512)]
    public string IcdisassembleProductDesc { get; set; }

    [Column("ICDisassembleProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcdisassembleProductQty { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICDisassembleProductStatus")]
    [StringLength(50)]
    public string IcdisassembleProductStatus { get; set; }

    [Column("ICDisassembleProductPostedStatus")]
    [StringLength(50)]
    public string IcdisassembleProductPostedStatus { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("ICDisassembleProductIsAverageCalculation")]
    public bool? IcdisassembleProductIsAverageCalculation { get; set; }

    [Column("ICDisassembleProductIsSpecificCalculation")]
    public bool? IcdisassembleProductIsSpecificCalculation { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcdisassembleProducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcdisassembleProducts")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcdisassembleProducts")]
    public virtual Icstock FkIcstock { get; set; }

    [InverseProperty("FkIcdisassembleProduct")]
    public virtual ICollection<IcdisassembleProductDetail> IcdisassembleProductDetails { get; set; } = new List<IcdisassembleProductDetail>();
}
