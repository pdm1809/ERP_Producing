using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMAllocationProposals")]
public partial class MmallocationProposal
{
    [Key]
    [Column("MMAllocationProposalID")]
    public int MmallocationProposalId { get; set; }

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

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

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

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Required]
    [Column("MMAllocationProposalNo")]
    [StringLength(50)]
    public string MmallocationProposalNo { get; set; }

    [Column("MMAllocationProposalName")]
    [StringLength(100)]
    public string MmallocationProposalName { get; set; }

    [Column("MMAllocationProposalDesc")]
    [StringLength(512)]
    public string MmallocationProposalDesc { get; set; }

    [Column("MMAllocationProposalDate", TypeName = "datetime")]
    public DateTime MmallocationProposalDate { get; set; }

    [Column("MMAllocationProposalApprovedDate", TypeName = "datetime")]
    public DateTime? MmallocationProposalApprovedDate { get; set; }

    [Column("MMAllocationProposalDiscardDate", TypeName = "datetime")]
    public DateTime? MmallocationProposalDiscardDate { get; set; }

    [Column("MMAllocationProposalValidateDate", TypeName = "datetime")]
    public DateTime? MmallocationProposalValidateDate { get; set; }

    [Column("MMAllocationProposalType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmallocationProposalType { get; set; }

    [Column("MMAllocationProposalStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmallocationProposalStatus { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    public string Mmpriority { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("MMAllocationProposalProductType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmallocationProposalProductType { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("MMAllocationProposalProposedDate", TypeName = "datetime")]
    public DateTime? MmallocationProposalProposedDate { get; set; }

    [Column("MMAllocationProposalProposedEmployeeID")]
    public int? MmallocationProposalProposedEmployeeId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("MMAllocationProposalPONo")]
    [StringLength(50)]
    public string MmallocationProposalPono { get; set; }

    [Column("MMAllocationProposalNewFrom")]
    [StringLength(100)]
    public string MmallocationProposalNewFrom { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("MMAllocationProposalreferences")]
    [StringLength(50)]
    public string MmallocationProposalreferences { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int? FkMmoperationDetailPlanId { get; set; }

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmallocationProposals")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmallocationProposals")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmallocationProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmallocationProposals")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("MmallocationProposals")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmallocationProposalFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmallocationProposals")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("MmallocationProposals")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmallocationProposals")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmallocationProposals")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmallocationProposals")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmallocationProposals")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmallocationProposals")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [ForeignKey("MmallocationProposalProposedEmployeeId")]
    [InverseProperty("MmallocationProposalMmallocationProposalProposedEmployees")]
    public virtual Hremployee MmallocationProposalProposedEmployee { get; set; }

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();

    [InverseProperty("FkMmallocationProposal")]
    public virtual ICollection<MmcancelAllocationProposal> MmcancelAllocationProposals { get; set; } = new List<MmcancelAllocationProposal>();
}
