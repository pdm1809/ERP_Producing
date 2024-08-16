using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSegments")]
[Microsoft.EntityFrameworkCore.Index("AcsegmentNo", Name = "Idx_ACSegments")]
public partial class Acsegment
{
    [Key]
    [Column("ACSegmentID")]
    public int AcsegmentId { get; set; }

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

    [Required]
    [Column("ACSegmentNo")]
    [StringLength(50)]
    public string AcsegmentNo { get; set; }

    [Required]
    [Column("ACSegmentName")]
    [StringLength(100)]
    public string AcsegmentName { get; set; }

    [Column("ACSegmentDesc")]
    [StringLength(512)]
    public string AcsegmentDesc { get; set; }

    [Column("ACCostType")]
    [StringLength(50)]
    public string AccostType { get; set; }

    [Column("ACSegmentBudgetControl")]
    [StringLength(50)]
    public string AcsegmentBudgetControl { get; set; }

    [Column("ACSegmentBudgetControlPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcsegmentBudgetControlPercent { get; set; }

    [Column("ACSegmentType")]
    [StringLength(50)]
    public string AcsegmentType { get; set; }

    [Column("FK_ADTargetReportBudgetID")]
    public int? FkAdtargetReportBudgetId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ACSegmentDebitAccountNo")]
    [StringLength(100)]
    public string AcsegmentDebitAccountNo { get; set; }

    [Column("ACSegmentCreditAccountNo")]
    [StringLength(100)]
    public string AcsegmentCreditAccountNo { get; set; }

    [Column("ACSegmentExcludeDebitAccountNo")]
    [StringLength(100)]
    public string AcsegmentExcludeDebitAccountNo { get; set; }

    [Column("ACSegmentExcludeCreditAccountNo")]
    [StringLength(100)]
    public string AcsegmentExcludeCreditAccountNo { get; set; }

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcbankTransaction> AcbankTransactions { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AccostBudgetDetail> AccostBudgetDetails { get; set; } = new List<AccostBudgetDetail>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AccostObjectItem> AccostObjectItems { get; set; } = new List<AccostObjectItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AccostObject> AccostObjects { get; set; } = new List<AccostObject>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<Acdocument> Acdocuments { get; set; } = new List<Acdocument>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcsalaryEntryTypeDetail> AcsalaryEntryTypeDetails { get; set; } = new List<AcsalaryEntryTypeDetail>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcsegmentDocumentControl> AcsegmentDocumentControls { get; set; } = new List<AcsegmentDocumentControl>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AcsegmentObjectControl> AcsegmentObjectControls { get; set; } = new List<AcsegmentObjectControl>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; } = new List<ApfeePaymentFeeConfig>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<AppaymentVoucher> AppaymentVouchers { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPayments { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVouchers { get; set; } = new List<ArreceiptVoucher>();

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("Acsegments")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [ForeignKey("FkAdtargetReportBudgetId")]
    [InverseProperty("Acsegments")]
    public virtual AdtargetReportBudget FkAdtargetReportBudget { get; set; }

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<HradvanceRequest> HradvanceRequests { get; set; } = new List<HradvanceRequest>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkAcsegment")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();
}
