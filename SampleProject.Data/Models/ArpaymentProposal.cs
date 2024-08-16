using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARPaymentProposals")]
public partial class ArpaymentProposal
{
    [Key]
    [Column("ARPaymentProposalID")]
    public int ArpaymentProposalId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Required]
    [Column("ARPaymentProposalNo")]
    [StringLength(50)]
    public string ArpaymentProposalNo { get; set; }

    [Column("ARPaymentProposalName")]
    [StringLength(100)]
    public string ArpaymentProposalName { get; set; }

    [Column("ARPaymentProposalDesc")]
    [StringLength(512)]
    public string ArpaymentProposalDesc { get; set; }

    [Column("ARPaymentProposalDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalDate { get; set; }

    [Column("ARPaymentProposalPayDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalPayDate { get; set; }

    [Column("ARPaymentProposalTypeCombo")]
    [StringLength(50)]
    public string ArpaymentProposalTypeCombo { get; set; }

    [Column("ARPaymentProposalStatusCombo")]
    [StringLength(50)]
    public string ArpaymentProposalStatusCombo { get; set; }

    [Column("ARPriority")]
    [StringLength(50)]
    public string Arpriority { get; set; }

    [Column("ARPaymentProposalPaymentMethodCombo")]
    [StringLength(50)]
    public string ArpaymentProposalPaymentMethodCombo { get; set; }

    [Column("ARPaymentProposalInvoiceNo")]
    [StringLength(50)]
    public string ArpaymentProposalInvoiceNo { get; set; }

    [Column("ARPaymentProposalReceiptNo")]
    [StringLength(50)]
    public string ArpaymentProposalReceiptNo { get; set; }

    [Column("ARPaymentProposalBookNo")]
    [StringLength(50)]
    public string ArpaymentProposalBookNo { get; set; }

    [Column("ARPaymentProposalRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalRemainAmount { get; set; }

    [Column("ARPaymentProposalPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalPaidAmount { get; set; }

    [Column("ARPaymentProposalTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpaymentProposalTotalAmount { get; set; }

    [Column("ARPaymentProposalRemark")]
    [StringLength(512)]
    public string ArpaymentProposalRemark { get; set; }

    [Column("ARPaymentProposalDocAttachCombo")]
    [StringLength(50)]
    public string ArpaymentProposalDocAttachCombo { get; set; }

    [Column("FK_HREmployeeAccountantID")]
    public int? FkHremployeeAccountantId { get; set; }

    [Column("FK_HREmployeeManagerID")]
    public int? FkHremployeeManagerId { get; set; }

    [Column("FK_HREmployeeHeadDepartmentID")]
    public int? FkHremployeeHeadDepartmentId { get; set; }

    [Column("ARPaymentProposalCheckDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalCheckDate { get; set; }

    [Column("ARPaymentProposalApproveDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalApproveDate { get; set; }

    [Column("ARPaymentProposalConfirmDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalConfirmDate { get; set; }

    [Column("ARPaymentProposalApprovePaymentDate", TypeName = "datetime")]
    public DateTime? ArpaymentProposalApprovePaymentDate { get; set; }

    [Column("FK_HREmployeeHeadAccountantID")]
    public int? FkHremployeeHeadAccountantId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ARPaymentProposalApproveStatus")]
    [StringLength(50)]
    public string ArpaymentProposalApproveStatus { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("ARAssObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArassObjectType { get; set; }

    [Column("FK_HREmployeeReceipt")]
    public int? FkHremployeeReceipt { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_AROpportunityID")]
    public int? FkAropportunityId { get; set; }

    [InverseProperty("FkArpaymentProposal")]
    public virtual ICollection<ArclearingDetail> ArclearingDetails { get; set; } = new List<ArclearingDetail>();

    [InverseProperty("FkArpaymentProposal")]
    public virtual ICollection<ArcustomerPaymentTimePayment> ArcustomerPaymentTimePayments { get; set; } = new List<ArcustomerPaymentTimePayment>();

    [InverseProperty("FkArpaymentProposal")]
    public virtual ICollection<ArpaymentProposalItem> ArpaymentProposalItems { get; set; } = new List<ArpaymentProposalItem>();

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkAropportunityId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual Aropportunity FkAropportunity { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArpaymentProposalFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeAccountantId")]
    [InverseProperty("ArpaymentProposalFkHremployeeAccountants")]
    public virtual Hremployee FkHremployeeAccountant { get; set; }

    [ForeignKey("FkHremployeeHeadAccountantId")]
    [InverseProperty("ArpaymentProposalFkHremployeeHeadAccountants")]
    public virtual Hremployee FkHremployeeHeadAccountant { get; set; }

    [ForeignKey("FkHremployeeHeadDepartmentId")]
    [InverseProperty("ArpaymentProposalFkHremployeeHeadDepartments")]
    public virtual Hremployee FkHremployeeHeadDepartment { get; set; }

    [ForeignKey("FkHremployeeManagerId")]
    [InverseProperty("ArpaymentProposalFkHremployeeManagers")]
    public virtual Hremployee FkHremployeeManager { get; set; }

    [ForeignKey("FkHremployeeReceipt")]
    [InverseProperty("ArpaymentProposalFkHremployeeReceiptNavigations")]
    public virtual Hremployee FkHremployeeReceiptNavigation { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual Icreceipt FkIcreceipt { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArpaymentProposals")]
    public virtual Pmproject FkPmproject { get; set; }
}
