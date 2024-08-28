using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCalculatorProductionNormCosts")]
public partial class MmcalculatorProductionNormCost
{
    [Key]
    [Column("MMCalculatorProductionNormCostID")]
    public int MmcalculatorProductionNormCostId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_MMProcessID")]
    public int? FkMmprocessId { get; set; }

    [Required]
    [Column("MMCalculatorProductionNormCostNo")]
    [StringLength(50)]
    public string MmcalculatorProductionNormCostNo { get; set; }

    [Column("MMCalculatorProductionNormCostDate", TypeName = "datetime")]
    public DateTime? MmcalculatorProductionNormCostDate { get; set; }

    [Column("MMCalculatorProductionNormCostType")]
    [StringLength(200)]
    public string MmcalculatorProductionNormCostType { get; set; }

    [Column("MMCalculatorProductionNormCostStatus")]
    [StringLength(50)]
    public string MmcalculatorProductionNormCostStatus { get; set; }

    [Column("MMCalculatorProductionNormCostEffectiveDate", TypeName = "datetime")]
    public DateTime? MmcalculatorProductionNormCostEffectiveDate { get; set; }

    [Column("MMCalculatorProductionNormCostCostPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostCostPrice { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("MMCalculatorProductionNormCostExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostExchangeRate { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("MMPriceType")]
    [StringLength(50)]
    public string MmpriceType { get; set; }

    [Column("ARCustomerType")]
    [StringLength(50)]
    public string ArcustomerType { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("MMCalculatorProductionNormCostBasicPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostBasicPrice { get; set; }

    [Column("MMCalculatorProductionNormCostNetPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostNetPrice { get; set; }

    [Column("MMCalculatorProductionNormCostGrossPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostGrossPrice { get; set; }

    [Column("MMCalculatorProductionNormCostSOQPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmcalculatorProductionNormCostSoqprice { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmcalculatorProductionNormCosts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("MmcalculatorProductionNormCosts")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmcalculatorProductionNormCosts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmcalculatorProductionNormCosts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmcalculatorProductionNormCosts")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmprocessId")]
    [InverseProperty("MmcalculatorProductionNormCosts")]
    public virtual Mmprocesss FkMmprocess { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmcalculatorProductionNormCosts")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [InverseProperty("FkMmcalculatorProductionNormCost")]
    public virtual ICollection<MmcalculatorProductionNormCostItem> MmcalculatorProductionNormCostItems { get; set; } = new List<MmcalculatorProductionNormCostItem>();

    [InverseProperty("FkMmcalculatorProductionNormCost")]
    public virtual ICollection<MmcalculatorProductionNormItemMaterial> MmcalculatorProductionNormItemMaterials { get; set; } = new List<MmcalculatorProductionNormItemMaterial>();
}
