using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEHistoryDetailOfProductBranchPrices")]
[Microsoft.EntityFrameworkCore.Index("FkBrbranchId", Name = "Idx_GEHistoryDetailOfProductBranchPrices")]
public partial class GehistoryDetailOfProductBranchPrice
{
    [Key]
    [Column("GEHistoryDetailOfProductBranchPriceID")]
    public int GehistoryDetailOfProductBranchPriceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GEObjectHistoryID")]
    public int FkGeobjectHistoryId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("GEHistoryDetailOfProductBranchPriceOldValue", TypeName = "decimal(18, 5)")]
    public decimal? GehistoryDetailOfProductBranchPriceOldValue { get; set; }

    [Column("GEHistoryDetailOfProductBranchPriceNewValue", TypeName = "decimal(18, 5)")]
    public decimal? GehistoryDetailOfProductBranchPriceNewValue { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("GehistoryDetailOfProductBranchPrices")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("GehistoryDetailOfProductBranchPrices")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGeobjectHistoryId")]
    [InverseProperty("GehistoryDetailOfProductBranchPrices")]
    public virtual GeobjectHistory FkGeobjectHistory { get; set; }
}
