using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseOrderItemOutSourcings")]
public partial class AppurchaseOrderItemOutSourcing
{
    [Key]
    [Column("APPurchaseOrderItemOutSourcingID")]
    public int AppurchaseOrderItemOutSourcingId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
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

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("APPurchaseOrderItemOutSourcingGroup")]
    [StringLength(50)]
    public string AppurchaseOrderItemOutSourcingGroup { get; set; }

    [Column("APPurchaseOrderItemOutSourcingProductNo")]
    [StringLength(50)]
    public string AppurchaseOrderItemOutSourcingProductNo { get; set; }

    [Column("APPurchaseOrderItemOutSourcingProductName")]
    [StringLength(255)]
    public string AppurchaseOrderItemOutSourcingProductName { get; set; }

    [Column("APPurchaseOrderItemOutSourcingProductDesc")]
    [StringLength(512)]
    public string AppurchaseOrderItemOutSourcingProductDesc { get; set; }

    [Column("APPurchaseOrderItemOutSourcingProductQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemOutSourcingProductQty { get; set; }

    [Column("APPurchaseOrderItemOutSourcingProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemOutSourcingProductUnitPrice { get; set; }

    [Column("APPurchaseOrderItemOutSourcingTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemOutSourcingTotalAmount { get; set; }

    [Column("APPurchaseOrderItemOutSourcingProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemOutSourcingProductHeight { get; set; }

    [Column("APPurchaseOrderItemOutSourcingProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemOutSourcingProductWidth { get; set; }

    [Column("APPurchaseOrderItemOutSourcingProductLength", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemOutSourcingProductLength { get; set; }

    [Column("FK_MMBPSemiProductID")]
    public int? FkMmbpsemiProductId { get; set; }

    [Column("APPurchaseOrderItemOutSourcingBPQty", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderItemOutSourcingBpqty { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppurchaseOrderItemOutSourcings")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AppurchaseOrderItemOutSourcings")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AppurchaseOrderItemOutSourcings")]
    public virtual Icproduct FkIcproduct { get; set; }
}
