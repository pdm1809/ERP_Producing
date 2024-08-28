using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACCostObjects")]
[Microsoft.EntityFrameworkCore.Index("AccostObjectNo", "FkBrbranchId", Name = "Idx_ACCostObjects")]
public partial class AccostObject
{
    [Key]
    [Column("ACCostObjectID")]
    public int AccostObjectId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_BRCostedBranchID")]
    public int? FkBrcostedBranchId { get; set; }

    [Column("FK_ACCostAccountID")]
    public int? FkAccostAccountId { get; set; }

    [Required]
    [Column("ACCostObjectNo")]
    [StringLength(50)]
    public string AccostObjectNo { get; set; }

    [Required]
    [Column("ACCostObjectName")]
    [StringLength(100)]
    public string AccostObjectName { get; set; }

    [Column("ACCostObjectDesc")]
    [StringLength(512)]
    public string AccostObjectDesc { get; set; }

    [Column("ACCostObjectStartDate", TypeName = "datetime")]
    public DateTime? AccostObjectStartDate { get; set; }

    [Column("ACCostObjectEndDate", TypeName = "datetime")]
    public DateTime? AccostObjectEndDate { get; set; }

    [Column("ACCostObjectAllocationMonths")]
    public int? AccostObjectAllocationMonths { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ACCostObjectTransferredDate", TypeName = "datetime")]
    public DateTime? AccostObjectTransferredDate { get; set; }

    [Column("FK_ACDepreciationWaitAccountID")]
    public int? FkAcdepreciationWaitAccountId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AccostObjectItem> AccostObjectItems { get; set; } = new List<AccostObjectItem>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AppaymentProposalPayment> AppaymentProposalPayments { get; set; } = new List<AppaymentProposalPayment>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; } = new List<AppaymentVoucherInvoice>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<ApsupplierPaymentDocument> ApsupplierPaymentDocuments { get; set; } = new List<ApsupplierPaymentDocument>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<ArcustomerPaymentDocument> ArcustomerPaymentDocuments { get; set; } = new List<ArcustomerPaymentDocument>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [ForeignKey("FkAccostAccountId")]
    [InverseProperty("AccostObjectFkAccostAccounts")]
    public virtual Acaccount FkAccostAccount { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AccostObjects")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdepreciationWaitAccountId")]
    [InverseProperty("AccostObjectFkAcdepreciationWaitAccounts")]
    public virtual Acaccount FkAcdepreciationWaitAccount { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AccostObjects")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AccostObjectFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrcostedBranchId")]
    [InverseProperty("AccostObjectFkBrcostedBranches")]
    public virtual Brbranch FkBrcostedBranch { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AccostObjects")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkAccostObject")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();
}
