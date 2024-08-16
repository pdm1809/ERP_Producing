using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APAllocationCosts")]
public partial class ApallocationCost
{
    [Key]
    [Column("APAllocationCostID")]
    public int ApallocationCostId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Required]
    [Column("APAllocationCostNo")]
    [StringLength(50)]
    public string ApallocationCostNo { get; set; }

    [Column("APAllocationCostDate", TypeName = "datetime")]
    public DateTime? ApallocationCostDate { get; set; }

    [Column("APAllocationCostStatus")]
    [StringLength(50)]
    public string ApallocationCostStatus { get; set; }

    [Column("APAllocationCostDesc")]
    [StringLength(512)]
    public string ApallocationCostDesc { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("APAllocationCostCriterion")]
    [StringLength(50)]
    public string ApallocationCostCriterion { get; set; }

    [Column("APAllocationCostPostedStatus")]
    [StringLength(50)]
    public string ApallocationCostPostedStatus { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("APAllocationCostType")]
    [StringLength(50)]
    public string ApallocationCostType { get; set; }

    [InverseProperty("FkApallocationCost")]
    public virtual ICollection<ApallocationCostItemInvoiceIn> ApallocationCostItemInvoiceIns { get; set; } = new List<ApallocationCostItemInvoiceIn>();

    [InverseProperty("FkApallocationCost")]
    public virtual ICollection<ApallocationCostItemInvoice> ApallocationCostItemInvoices { get; set; } = new List<ApallocationCostItemInvoice>();

    [InverseProperty("FkApallocationCost")]
    public virtual ICollection<ApallocationCostItemShipment> ApallocationCostItemShipments { get; set; } = new List<ApallocationCostItemShipment>();

    [InverseProperty("FkApallocationCost")]
    public virtual ICollection<ApallocationCostItem> ApallocationCostItems { get; set; } = new List<ApallocationCostItem>();

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("ApallocationCosts")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApallocationCosts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApallocationCosts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ApallocationCosts")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("ApallocationCosts")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
