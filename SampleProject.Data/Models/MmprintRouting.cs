using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPrintRoutings")]
public partial class MmprintRouting
{
    [Key]
    [Column("MMPrintRoutingID")]
    public int MmprintRoutingId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMPrintRoutingProductName")]
    [StringLength(100)]
    public string MmprintRoutingProductName { get; set; }

    [Column("MMPrintRoutingProductForBatchName")]
    [StringLength(100)]
    public string MmprintRoutingProductForBatchName { get; set; }

    [Column("MMPrintRoutingProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmprintRoutingProductQty { get; set; }

    [Column("MMPrintRoutingBarcode")]
    [StringLength(50)]
    public string MmprintRoutingBarcode { get; set; }

    [Column("MMPrintRoutingProductionNormItemQuantity", TypeName = "decimal(18, 5)")]
    public decimal? MmprintRoutingProductionNormItemQuantity { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmprintRoutingFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MmprintRoutingFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmprintRoutings")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmprintRoutings")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
