using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductBranchPrices")]
[Microsoft.EntityFrameworkCore.Index("FkBrbranchId", "FkIcproductId", "IcproductBranchPriceType", Name = "Idx_ICProductBranchPrices")]
public partial class IcproductBranchPrice
{
    [Key]
    [Column("ICProductBranchPriceID")]
    public int IcproductBranchPriceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ICProductBranchPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductBranchPrice1 { get; set; }

    [Column("ICProductBranchPriceType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductBranchPriceType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcproductBranchPrices")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("IcproductBranchPrices")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductBranchPrices")]
    public virtual Icproduct FkIcproduct { get; set; }
}
