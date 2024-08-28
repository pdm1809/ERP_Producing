using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPurchasePlans")]
public partial class MmpurchasePlan
{
    [Key]
    [Column("MMPurchasePlanID")]
    public int MmpurchasePlanId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeValidated")]
    public int? FkHremployeeValidated { get; set; }

    [Column("FK_HREmployeeApproved")]
    public int? FkHremployeeApproved { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("MMPurchasePlanSaleOrderNo")]
    [StringLength(50)]
    public string MmpurchasePlanSaleOrderNo { get; set; }

    [Required]
    [Column("MMPurchasePlanNo")]
    [StringLength(50)]
    public string MmpurchasePlanNo { get; set; }

    [Column("MMPurchasePlanDesc")]
    [StringLength(512)]
    public string MmpurchasePlanDesc { get; set; }

    [Column("MMPurchasePlanDate", TypeName = "datetime")]
    public DateTime? MmpurchasePlanDate { get; set; }

    [Column("MMPurchasePlanStatus")]
    [StringLength(50)]
    public string MmpurchasePlanStatus { get; set; }

    [Column("MMPurchasePlanValidateDate", TypeName = "datetime")]
    public DateTime? MmpurchasePlanValidateDate { get; set; }

    [Column("MMPurchasePlanApprovedDate", TypeName = "datetime")]
    public DateTime? MmpurchasePlanApprovedDate { get; set; }

    [Column("MMPurchasePlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanProductQty { get; set; }

    [Column("MMPurchasePlanType")]
    [StringLength(50)]
    public string MmpurchasePlanType { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("MMPurchasePlansNeededTime", TypeName = "datetime")]
    public DateTime? MmpurchasePlansNeededTime { get; set; }

    [Column("MMPurchasePlanPONo")]
    [StringLength(50)]
    public string MmpurchasePlanPono { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("MMObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmobjectType { get; set; }

    [Column("MMPurchasePlanRealDeliveryTime", TypeName = "datetime")]
    public DateTime? MmpurchasePlanRealDeliveryTime { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("MMPurchaseBatchProductNo")]
    [StringLength(4000)]
    public string MmpurchaseBatchProductNo { get; set; }

    [Column("MMPurchasePlanPurchaseOutsidePercent", TypeName = "decimal(18, 5)")]
    public decimal? MmpurchasePlanPurchaseOutsidePercent { get; set; }

    [Column("MMPurchasePlanPostedStatus")]
    [StringLength(50)]
    public string MmpurchasePlanPostedStatus { get; set; }

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<ApcancelPurchaseProposal> ApcancelPurchaseProposals { get; set; } = new List<ApcancelPurchaseProposal>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<Approposal> Approposals { get; set; } = new List<Approposal>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmpurchasePlans")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmpurchasePlans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmpurchasePlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmpurchasePlanFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproved")]
    [InverseProperty("MmpurchasePlanFkHremployeeApprovedNavigations")]
    public virtual Hremployee FkHremployeeApprovedNavigation { get; set; }

    [ForeignKey("FkHremployeeValidated")]
    [InverseProperty("MmpurchasePlanFkHremployeeValidatedNavigations")]
    public virtual Hremployee FkHremployeeValidatedNavigation { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmpurchasePlans")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmpurchasePlans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmpurchasePlans")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmpurchasePlans")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlans { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<MmpurchasePlanInPutItem> MmpurchasePlanInPutItems { get; set; } = new List<MmpurchasePlanInPutItem>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmpurchasePlan")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();
}
