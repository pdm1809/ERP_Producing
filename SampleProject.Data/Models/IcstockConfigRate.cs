using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICStockConfigRates")]
public partial class IcstockConfigRate
{
    [Key]
    [Column("ICStockConfigRateID")]
    public int IcstockConfigRateId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Required]
    [Column("ICStockConfigRateNo")]
    [StringLength(50)]
    public string IcstockConfigRateNo { get; set; }

    [Required]
    [Column("ICStockConfigRateName")]
    [StringLength(255)]
    public string IcstockConfigRateName { get; set; }

    [Column("ICStockConfigRateDesc")]
    [StringLength(512)]
    public string IcstockConfigRateDesc { get; set; }

    [Required]
    [Column("ICStockConfigRateProductType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockConfigRateProductType { get; set; }

    [Required]
    [Column("ICStockConfigRateProductDesc")]
    [StringLength(512)]
    public string IcstockConfigRateProductDesc { get; set; }

    [Column("ICStockConfigRateIsIncrease")]
    public bool? IcstockConfigRateIsIncrease { get; set; }

    [Column("ICStockConfigRatePercent", TypeName = "decimal(18, 5)")]
    public decimal? IcstockConfigRatePercent { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcstockConfigRates")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcstockConfigRates")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
