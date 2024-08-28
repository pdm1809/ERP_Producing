using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductDescs")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ICProductDescs")]
public partial class IcproductDesc
{
    [Key]
    [Column("ICProductDescID")]
    public int IcproductDescId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_GELanguageID")]
    public int FkGelanguageId { get; set; }

    [Required]
    [Column("ICProductDescName")]
    [StringLength(50)]
    public string IcproductDescName { get; set; }

    [Column("ICProductDesc")]
    [StringLength(510)]
    public string IcproductDesc1 { get; set; }

    [Column("ICProductDescText", TypeName = "ntext")]
    public string IcproductDescText { get; set; }

    [Column("ICProductDescSticker")]
    [StringLength(510)]
    public string IcproductDescSticker { get; set; }

    [Column("ICProductDescSellUnit")]
    [StringLength(30)]
    public string IcproductDescSellUnit { get; set; }

    [Column("ICProductDescBasicUnit")]
    [StringLength(50)]
    public string IcproductDescBasicUnit { get; set; }

    [Column("ICProductDescPackUnit")]
    [StringLength(50)]
    public string IcproductDescPackUnit { get; set; }

    [Column("ICProductDescSize")]
    [StringLength(255)]
    public string IcproductDescSize { get; set; }

    [Column("ICProductDescColor")]
    [StringLength(255)]
    public string IcproductDescColor { get; set; }

    [Column("ICProductBasicToSell", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBasicToSell { get; set; }

    [Column("ICProductPackToBasic", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackToBasic { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("IcproductDescs")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductDescs")]
    public virtual Icproduct FkIcproduct { get; set; }
}
