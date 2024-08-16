using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPurchasePlanTrackings")]
public partial class MmpurchasePlanTracking
{
    [Key]
    [Column("MMPurchasePlanTrackingID")]
    public int MmpurchasePlanTrackingId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICSemiProductID")]
    public int? FkIcsemiProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMPurchasePlanTrackingDocumentNo")]
    [StringLength(50)]
    public string MmpurchasePlanTrackingDocumentNo { get; set; }

    [Column("MMPurchasePlanTrackingPurchaseQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanTrackingPurchaseQty { get; set; }

    [Column("MMPurchasePlanTrackingReceiptQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanTrackingReceiptQty { get; set; }

    [Column("MMPurchasePlanTrackingStatus")]
    [StringLength(50)]
    public string MmpurchasePlanTrackingStatus { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmpurchasePlanTrackingFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcsemiProductId")]
    [InverseProperty("MmpurchasePlanTrackingFkIcsemiProducts")]
    public virtual Icproduct FkIcsemiProduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmpurchasePlanTrackings")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmpurchasePlanTrackings")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
