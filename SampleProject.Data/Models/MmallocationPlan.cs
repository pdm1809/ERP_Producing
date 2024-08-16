using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMAllocationPlans")]
public partial class MmallocationPlan
{
    [Key]
    [Column("MMAllocationPlanID")]
    public int MmallocationPlanId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeIDValidate")]
    public int? FkHremployeeIdvalidate { get; set; }

    [Column("FK_HREmployeeIDApprove")]
    public int? FkHremployeeIdapprove { get; set; }

    [Column("FK_HREmployeeIDDiscard")]
    public int? FkHremployeeIddiscard { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMWoodPlanID")]
    public int? FkMmwoodPlanId { get; set; }

    [Required]
    [Column("MMAllocationPlanNo")]
    [StringLength(50)]
    public string MmallocationPlanNo { get; set; }

    [Column("MMAllocationPlanName")]
    [StringLength(100)]
    public string MmallocationPlanName { get; set; }

    [Column("MMAllocationPlanDesc")]
    [StringLength(512)]
    public string MmallocationPlanDesc { get; set; }

    [Column("MMAllocationPlanDate", TypeName = "datetime")]
    public DateTime MmallocationPlanDate { get; set; }

    [Column("MMAllocationPlanApprovedDate", TypeName = "datetime")]
    public DateTime? MmallocationPlanApprovedDate { get; set; }

    [Column("MMAllocationPlanDiscardDate", TypeName = "datetime")]
    public DateTime? MmallocationPlanDiscardDate { get; set; }

    [Column("MMAllocationPlanValidateDate", TypeName = "datetime")]
    public DateTime? MmallocationPlanValidateDate { get; set; }

    [Column("MMAllocationPlanType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmallocationPlanType { get; set; }

    [Column("MMAllocationPlanStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmallocationPlanStatus { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("MMAllocationPlanDeliveryDate", TypeName = "datetime")]
    public DateTime? MmallocationPlanDeliveryDate { get; set; }

    [Column("MMAllocationPlanTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? MmallocationPlanTotalQty { get; set; }

    [Column("MMAllocationPlanPurpose")]
    [StringLength(50)]
    public string MmallocationPlanPurpose { get; set; }

    [Column("MMAllocationPlanPONo")]
    [StringLength(50)]
    public string MmallocationPlanPono { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("MMObjectType")]
    [StringLength(50)]
    public string MmobjectType { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [Column("MMAllocationPlanWeek")]
    [StringLength(50)]
    public string MmallocationPlanWeek { get; set; }

    [Column("MMAllocationPlanBatchProductNo")]
    [StringLength(4000)]
    public string MmallocationPlanBatchProductNo { get; set; }

    [Column("MMAllocationPlanPostedStatus")]
    [StringLength(50)]
    public string MmallocationPlanPostedStatus { get; set; }

    [Column("FK_HREmployeeIDReceive")]
    public int? FkHremployeeIdreceive { get; set; }

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmallocationPlans")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmallocationPlans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmallocationPlans")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmallocationPlans")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmallocationPlans")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmallocationPlans")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmallocationPlans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmallocationPlans")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmallocationPlans")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmwoodPlanId")]
    [InverseProperty("MmallocationPlans")]
    public virtual MmwoodPlan FkMmwoodPlan { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmallocationPlans")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; } = new List<MmcancelAllocationPlanItem>();

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkMmallocationPlan")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();
}
