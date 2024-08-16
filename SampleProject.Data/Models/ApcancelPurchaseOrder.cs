using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APCancelPurchaseOrders")]
public partial class ApcancelPurchaseOrder
{
    [Key]
    [Column("APCancelPurchaseOrderID")]
    public int ApcancelPurchaseOrderId { get; set; }

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

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("APCancelPurchaseOrderNo")]
    [StringLength(50)]
    public string ApcancelPurchaseOrderNo { get; set; }

    [Column("APCancelPurchaseOrderName")]
    [StringLength(100)]
    public string ApcancelPurchaseOrderName { get; set; }

    [Column("APCancelPurchaseOrderDesc")]
    [StringLength(512)]
    public string ApcancelPurchaseOrderDesc { get; set; }

    [Column("APCancelPurchaseOrderComment")]
    [StringLength(512)]
    public string ApcancelPurchaseOrderComment { get; set; }

    [Column("APCancelPurchaseOrderDate", TypeName = "datetime")]
    public DateTime? ApcancelPurchaseOrderDate { get; set; }

    [Column("APCancelPurchaseOrderType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApcancelPurchaseOrderType { get; set; }

    [Column("APCancelPurchaseOrderStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApcancelPurchaseOrderStatus { get; set; }

    [Column("APCancelPurchaseOrderReference")]
    [StringLength(512)]
    [Unicode(false)]
    public string ApcancelPurchaseOrderReference { get; set; }

    [Column("APCancelPurchaseOrderApproveDate", TypeName = "datetime")]
    public DateTime? ApcancelPurchaseOrderApproveDate { get; set; }

    [Required]
    [Column("APCancelPurchaseOrderCancelFromDepartment")]
    [StringLength(50)]
    public string ApcancelPurchaseOrderCancelFromDepartment { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApobjectType { get; set; }

    [Column("FK_APPurchaseContractID")]
    public int? FkAppurchaseContractId { get; set; }

    [Column("APCancelPurchaseOrderContractNo")]
    [StringLength(50)]
    public string ApcancelPurchaseOrderContractNo { get; set; }

    [InverseProperty("FkApcancelPurchaseOrder")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [ForeignKey("FkAppurchaseContractId")]
    [InverseProperty("ApcancelPurchaseOrders")]
    public virtual AppurchaseContract FkAppurchaseContract { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApcancelPurchaseOrders")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApcancelPurchaseOrders")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApcancelPurchaseOrders")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApcancelPurchaseOrders")]
    public virtual Hremployee FkHremployee { get; set; }
}
