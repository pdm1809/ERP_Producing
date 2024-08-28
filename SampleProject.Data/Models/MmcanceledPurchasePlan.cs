using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMCanceledPurchasePlans")]
public partial class MmcanceledPurchasePlan
{
    [Key]
    [Column("MMCanceledPurchasePlanID")]
    public int MmcanceledPurchasePlanId { get; set; }

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

    [Column("FK_MMPurchasePlanID")]
    public int? FkMmpurchasePlanId { get; set; }

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

    [Column("MMCanceledPurchasePlanSaleOrderNo")]
    [StringLength(50)]
    public string MmcanceledPurchasePlanSaleOrderNo { get; set; }

    [Required]
    [Column("MMCanceledPurchasePlanNo")]
    [StringLength(50)]
    public string MmcanceledPurchasePlanNo { get; set; }

    [Column("MMCanceledPurchasePlanDesc")]
    [StringLength(512)]
    public string MmcanceledPurchasePlanDesc { get; set; }

    [Column("MMCanceledPurchasePlanDate", TypeName = "datetime")]
    public DateTime? MmcanceledPurchasePlanDate { get; set; }

    [Column("MMCanceledPurchasePlanStatus")]
    [StringLength(50)]
    public string MmcanceledPurchasePlanStatus { get; set; }

    [Column("MMCanceledPurchasePlanValidateDate", TypeName = "datetime")]
    public DateTime? MmcanceledPurchasePlanValidateDate { get; set; }

    [Column("MMCanceledPurchasePlanApprovedDate", TypeName = "datetime")]
    public DateTime? MmcanceledPurchasePlanApprovedDate { get; set; }

    [Column("MMCanceledPurchasePlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmcanceledPurchasePlanProductQty { get; set; }

    [Column("MMCanceledPurchasePlanType")]
    [StringLength(50)]
    public string MmcanceledPurchasePlanType { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("MMCanceledPurchasePlansNeededTime", TypeName = "datetime")]
    public DateTime? MmcanceledPurchasePlansNeededTime { get; set; }

    [Column("MMCanceledPurchasePlanPONo")]
    [StringLength(50)]
    public string MmcanceledPurchasePlanPono { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmcanceledPurchasePlans")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmcanceledPurchasePlans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmcanceledPurchasePlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmcanceledPurchasePlanFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproved")]
    [InverseProperty("MmcanceledPurchasePlanFkHremployeeApprovedNavigations")]
    public virtual Hremployee FkHremployeeApprovedNavigation { get; set; }

    [ForeignKey("FkHremployeeValidated")]
    [InverseProperty("MmcanceledPurchasePlanFkHremployeeValidatedNavigations")]
    public virtual Hremployee FkHremployeeValidatedNavigation { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmcanceledPurchasePlans")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmcanceledPurchasePlans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmpurchasePlanId")]
    [InverseProperty("MmcanceledPurchasePlans")]
    public virtual MmpurchasePlan FkMmpurchasePlan { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmcanceledPurchasePlans")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [InverseProperty("FkMmcanceledPurchasePlan")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();
}
