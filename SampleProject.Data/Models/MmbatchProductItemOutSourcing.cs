using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductItemOutSourcings")]
public partial class MmbatchProductItemOutSourcing
{
    [Key]
    [Column("MMBatchProductItemOutSourcingID")]
    public int MmbatchProductItemOutSourcingId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMBatchProductItemOutSourcingProductNo")]
    [StringLength(50)]
    public string MmbatchProductItemOutSourcingProductNo { get; set; }

    [Column("MMBatchProductItemOutSourcingProductName")]
    [StringLength(216)]
    public string MmbatchProductItemOutSourcingProductName { get; set; }

    [Column("MMBatchProductItemOutSourcingProductDesc")]
    [StringLength(512)]
    public string MmbatchProductItemOutSourcingProductDesc { get; set; }

    [Column("MMBatchProductItemOutSourcingProductQty", TypeName = "decimal(18, 6)")]
    public decimal? MmbatchProductItemOutSourcingProductQty { get; set; }

    [Column("MMBatchProductItemOutSourcingOperation")]
    [StringLength(256)]
    public string MmbatchProductItemOutSourcingOperation { get; set; }

    [Column("MMBatchProductItemOutSourcingGroup")]
    [StringLength(50)]
    public string MmbatchProductItemOutSourcingGroup { get; set; }

    [Column("MMBatchProductItemOutSourcingNeedDate", TypeName = "datetime")]
    public DateTime? MmbatchProductItemOutSourcingNeedDate { get; set; }

    [Column("MMBatchProductItemOutSourcingStatus")]
    [StringLength(50)]
    public string MmbatchProductItemOutSourcingStatus { get; set; }

    [Column("MMBatchProductItemOutSourcingResourceType")]
    [StringLength(50)]
    public string MmbatchProductItemOutSourcingResourceType { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductItemOutSourcings")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }
}
