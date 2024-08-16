using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICAverageCosts")]
public partial class IcaverageCost
{
    [Key]
    [Column("ICAverageCostID")]
    public int IcaverageCostId { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ICAverageCostMonth")]
    public int? IcaverageCostMonth { get; set; }

    [Column("ICAverageCostYear")]
    public int? IcaverageCostYear { get; set; }

    [Column("ICAverageCostProductName")]
    [StringLength(256)]
    public string IcaverageCostProductName { get; set; }

    [Column("ICAverageCostProductDesc")]
    [StringLength(512)]
    public string IcaverageCostProductDesc { get; set; }

    [Column("ICAverageCostProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcaverageCostProductUnitCost { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcaverageCosts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcaverageCosts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcaverageCosts")]
    public virtual Icstock FkIcstock { get; set; }
}
