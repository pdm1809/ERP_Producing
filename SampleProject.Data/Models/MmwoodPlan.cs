using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMWoodPlans")]
public partial class MmwoodPlan
{
    [Key]
    [Column("MMWoodPlanID")]
    public int MmwoodPlanId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeValidated")]
    public int? FkHremployeeValidated { get; set; }

    [Column("FK_HREmployeeApproved")]
    public int? FkHremployeeApproved { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Required]
    [Column("MMWoodPlanNo")]
    [StringLength(50)]
    public string MmwoodPlanNo { get; set; }

    [Column("MMWoodPlanDesc")]
    [StringLength(512)]
    public string MmwoodPlanDesc { get; set; }

    [Column("MMWoodPlanDate", TypeName = "datetime")]
    public DateTime? MmwoodPlanDate { get; set; }

    [Column("MMWoodPlanStatus")]
    [StringLength(50)]
    public string MmwoodPlanStatus { get; set; }

    [Column("MMWoodPlanValidateDate", TypeName = "datetime")]
    public DateTime? MmwoodPlanValidateDate { get; set; }

    [Column("MMWoodPlanApprovedDate", TypeName = "datetime")]
    public DateTime? MmwoodPlanApprovedDate { get; set; }

    [Column("MMWoodPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmwoodPlanProductQty { get; set; }

    [Column("MMWoodPlanBatchSaleOrderNo")]
    [StringLength(50)]
    public string MmwoodPlanBatchSaleOrderNo { get; set; }

    [Column("MMWoodPlanPONo")]
    [StringLength(50)]
    public string MmwoodPlanPono { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("MMWoodPlanBatchProductNo")]
    [StringLength(100)]
    public string MmwoodPlanBatchProductNo { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmwoodPlans")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmwoodPlans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmwoodPlanFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproved")]
    [InverseProperty("MmwoodPlanFkHremployeeApprovedNavigations")]
    public virtual Hremployee FkHremployeeApprovedNavigation { get; set; }

    [ForeignKey("FkHremployeeValidated")]
    [InverseProperty("MmwoodPlanFkHremployeeValidatedNavigations")]
    public virtual Hremployee FkHremployeeValidatedNavigation { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmwoodPlans")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmwoodPlans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmwoodPlans")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmwoodPlans")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmwoodPlans")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlans { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlans { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmwoodPlanItemDetail> MmwoodPlanItemDetails { get; set; } = new List<MmwoodPlanItemDetail>();

    [InverseProperty("FkMmwoodPlan")]
    public virtual ICollection<MmwoodPlanItem> MmwoodPlanItems { get; set; } = new List<MmwoodPlanItem>();
}
