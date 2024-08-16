using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAccounts")]
[Microsoft.EntityFrameworkCore.Index("AcaccountNo", "AcaccountType", Name = "Idx_ACAccounts")]
public partial class Acaccount
{
    [Key]
    [Column("ACAccountID")]
    public int AcaccountId { get; set; }

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
    [Column("ACAccountNo")]
    [StringLength(50)]
    public string AcaccountNo { get; set; }

    [Required]
    [Column("ACAccountName")]
    [StringLength(100)]
    public string AcaccountName { get; set; }

    [Column("ACAccountDesc")]
    [StringLength(512)]
    public string AcaccountDesc { get; set; }

    [Column("ACAccountParentID")]
    public int? AcaccountParentId { get; set; }

    [Column("ACAccountType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcaccountType { get; set; }

    [Column("ACAccountPostingRule")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcaccountPostingRule { get; set; }

    [Column("ACAccountInitialBalance", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountInitialBalance { get; set; }

    public bool? IsActive { get; set; }

    [Column("ACAccountItemExpense")]
    public bool? AcaccountItemExpense { get; set; }

    [Column("ACAccountCenterExpense")]
    public bool? AcaccountCenterExpense { get; set; }

    [Column("ACAccountProject")]
    public bool? AcaccountProject { get; set; }

    [Column("ACAccountControlAccountItemExpense")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcaccountControlAccountItemExpense { get; set; }

    [Column("ACAccountControlAccountCenterExpense")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcaccountControlAccountCenterExpense { get; set; }

    [Column("ACAccountControlAccountProject")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcaccountControlAccountProject { get; set; }

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcaccountDetail> AcaccountDetails { get; set; } = new List<AcaccountDetail>();

    [InverseProperty("FkAcfromAccount")]
    public virtual ICollection<AcaccountTranferCost> AcaccountTranferCostFkAcfromAccounts { get; set; } = new List<AcaccountTranferCost>();

    [InverseProperty("FkActoAccount")]
    public virtual ICollection<AcaccountTranferCost> AcaccountTranferCostFkActoAccounts { get; set; } = new List<AcaccountTranferCost>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AcaccountingBill> AcaccountingBillFkAccreditAccounts { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AcaccountingBill> AcaccountingBillFkAcdebitAccounts { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcaccountingSheetDetail> AcaccountingSheetDetails { get; set; } = new List<AcaccountingSheetDetail>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetailFkAccreditAccounts { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetailFkAcdebitAccounts { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkAccostAccount")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTranFkAccostAccounts { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkAcdepreciationWaitAccount")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTranFkAcdepreciationWaitAccounts { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkAcallocationAccount")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTranFkAcallocationAccounts { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkAcallocationCostAccount")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTranFkAcallocationCostAccounts { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<Acasset> AcassetFkAcaccounts { get; set; } = new List<Acasset>();

    [InverseProperty("FkAcdepreciationAccount")]
    public virtual ICollection<Acasset> AcassetFkAcdepreciationAccounts { get; set; } = new List<Acasset>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<Acasset> AcassetFkAcdepreciationCostAccounts { get; set; } = new List<Acasset>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcassetTypeAccountConfig> AcassetTypeAccountConfigFkAcaccounts { get; set; } = new List<AcassetTypeAccountConfig>();

    [InverseProperty("FkAcdepreciationAccount")]
    public virtual ICollection<AcassetTypeAccountConfig> AcassetTypeAccountConfigFkAcdepreciationAccounts { get; set; } = new List<AcassetTypeAccountConfig>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<AcassetTypeAccountConfig> AcassetTypeAccountConfigFkAcdepreciationCostAccounts { get; set; } = new List<AcassetTypeAccountConfig>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcbalanceAmountArisingDetail> AcbalanceAmountArisingDetails { get; set; } = new List<AcbalanceAmountArisingDetail>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcbalanceAmountArisingObjectDetail> AcbalanceAmountArisingObjectDetails { get; set; } = new List<AcbalanceAmountArisingObjectDetail>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItemFkAccreditAccounts { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItemFkAcdebitAccounts { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcbusinessResultDetail> AcbusinessResultDetails { get; set; } = new List<AcbusinessResultDetail>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcclearingDebtInvoiceInItem> AcclearingDebtInvoiceInItems { get; set; } = new List<AcclearingDebtInvoiceInItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcclearingDebtInvoiceItem> AcclearingDebtInvoiceItems { get; set; } = new List<AcclearingDebtInvoiceItem>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AccostBudgetDetail> AccostBudgetDetailFkAccreditAccounts { get; set; } = new List<AccostBudgetDetail>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AccostBudgetDetail> AccostBudgetDetailFkAcdebitAccounts { get; set; } = new List<AccostBudgetDetail>();

    [InverseProperty("FkAccostAccount")]
    public virtual ICollection<AccostObject> AccostObjectFkAccostAccounts { get; set; } = new List<AccostObject>();

    [InverseProperty("FkAcdepreciationWaitAccount")]
    public virtual ICollection<AccostObject> AccostObjectFkAcdepreciationWaitAccounts { get; set; } = new List<AccostObject>();

    [InverseProperty("FkAcallocationAccount")]
    public virtual ICollection<AccostObjectItem> AccostObjectItemFkAcallocationAccounts { get; set; } = new List<AccostObjectItem>();

    [InverseProperty("FkAccostAllocationWaitAccount")]
    public virtual ICollection<AccostObjectItem> AccostObjectItemFkAccostAllocationWaitAccounts { get; set; } = new List<AccostObjectItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTranFkAcaccounts { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkAcdepreciationAccount")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTranFkAcdepreciationAccounts { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTranFkAcdepreciationCostAccounts { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcdocTypeEntryAccount> AcdocTypeEntryAccounts { get; set; } = new List<AcdocTypeEntryAccount>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntryFkAccreditAccounts { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntryFkAcdebitAccounts { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcdocumentTran> AcdocumentTranFkAcaccounts { get; set; } = new List<AcdocumentTran>();

    [InverseProperty("FkAcoffsetAccount")]
    public virtual ICollection<AcdocumentTran> AcdocumentTranFkAcoffsetAccounts { get; set; } = new List<AcdocumentTran>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceifeFkAcaccounts { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkAcbyCreditAccount")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceifeFkAcbyCreditAccounts { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkAcbyDebitAccount")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceifeFkAcbyDebitAccounts { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItemFkAcaccounts { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkAcbyCreditAccount")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItemFkAcbyCreditAccounts { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkAcbyDebitAccount")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItemFkAcbyDebitAccounts { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcequipmentTypeAccountConfig> AcequipmentTypeAccountConfigFkAcaccounts { get; set; } = new List<AcequipmentTypeAccountConfig>();

    [InverseProperty("FkAcdepreciationAccount")]
    public virtual ICollection<AcequipmentTypeAccountConfig> AcequipmentTypeAccountConfigFkAcdepreciationAccounts { get; set; } = new List<AcequipmentTypeAccountConfig>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<AcequipmentTypeAccountConfig> AcequipmentTypeAccountConfigFkAcdepreciationCostAccounts { get; set; } = new List<AcequipmentTypeAccountConfig>();

    [InverseProperty("FkAcaccountCostExpired")]
    public virtual ICollection<AcloanReceiptType> AcloanReceiptTypeFkAcaccountCostExpireds { get; set; } = new List<AcloanReceiptType>();

    [InverseProperty("FkAcaccountCost")]
    public virtual ICollection<AcloanReceiptType> AcloanReceiptTypeFkAcaccountCosts { get; set; } = new List<AcloanReceiptType>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcloanReceiptType> AcloanReceiptTypeFkAcaccounts { get; set; } = new List<AcloanReceiptType>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcmoneyChangeItem> AcmoneyChangeItems { get; set; } = new List<AcmoneyChangeItem>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetailFkAccreditAccounts { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetailFkAcdebitAccounts { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetailFkAccreditAccounts { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetailFkAcdebitAccounts { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AcsalaryEntryTypeDetail> AcsalaryEntryTypeDetailFkAccreditAccounts { get; set; } = new List<AcsalaryEntryTypeDetail>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AcsalaryEntryTypeDetail> AcsalaryEntryTypeDetailFkAcdebitAccounts { get; set; } = new List<AcsalaryEntryTypeDetail>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<Acsegment> Acsegments { get; set; } = new List<Acsegment>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<Actransaction> ActransactionFkAcaccounts { get; set; } = new List<Actransaction>();

    [InverseProperty("FkAcoffsetAccount")]
    public virtual ICollection<Actransaction> ActransactionFkAcoffsetAccounts { get; set; } = new List<Actransaction>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<AcunfinishedConstructionCost> AcunfinishedConstructionCosts { get; set; } = new List<AcunfinishedConstructionCost>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AdtargetReportBudget> AdtargetReportBudgetFkAccreditAccounts { get; set; } = new List<AdtargetReportBudget>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AdtargetReportBudget> AdtargetReportBudgetFkAcdebitAccounts { get; set; } = new List<AdtargetReportBudget>();

    [InverseProperty("FkAcaccountPurchase")]
    public virtual ICollection<ApclearInvoiceIn> ApclearInvoiceIns { get; set; } = new List<ApclearInvoiceIn>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<ApfeePaymentItem> ApfeePaymentItems { get; set; } = new List<ApfeePaymentItem>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AppaymentProposalPayment> AppaymentProposalPaymentFkAccreditAccounts { get; set; } = new List<AppaymentProposalPayment>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AppaymentProposalPayment> AppaymentProposalPaymentFkAcdebitAccounts { get; set; } = new List<AppaymentProposalPayment>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItemFkAccreditAccounts { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItemFkAcdebitAccounts { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetailFkAccreditAccounts { get; set; } = new List<AppopaymentTimeInvoiceInDetail>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetailFkAcdebitAccounts { get; set; } = new List<AppopaymentTimeInvoiceInDetail>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkAcaccountPurchase")]
    public virtual ICollection<Apsupplier> ApsupplierFkAcaccountPurchases { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkAcaccountSale")]
    public virtual ICollection<Apsupplier> ApsupplierFkAcaccountSales { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<Apsupplier> ApsupplierFkAcaccounts { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<ApsupplierPaymentDocument> ApsupplierPaymentDocumentFkAccreditAccounts { get; set; } = new List<ApsupplierPaymentDocument>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<ApsupplierPaymentDocument> ApsupplierPaymentDocumentFkAcdebitAccounts { get; set; } = new List<ApsupplierPaymentDocument>();

    [InverseProperty("FkAcaccountDeposit")]
    public virtual ICollection<ApsupplierTypeAccountConfig> ApsupplierTypeAccountConfigFkAcaccountDeposits { get; set; } = new List<ApsupplierTypeAccountConfig>();

    [InverseProperty("FkAcaccountPurchase")]
    public virtual ICollection<ApsupplierTypeAccountConfig> ApsupplierTypeAccountConfigFkAcaccountPurchases { get; set; } = new List<ApsupplierTypeAccountConfig>();

    [InverseProperty("FkAcaccountSale")]
    public virtual ICollection<ApsupplierTypeAccountConfig> ApsupplierTypeAccountConfigFkAcaccountSales { get; set; } = new List<ApsupplierTypeAccountConfig>();

    [InverseProperty("FkAcaccountSale")]
    public virtual ICollection<ArclearInvoice> ArclearInvoices { get; set; } = new List<ArclearInvoice>();

    [InverseProperty("FkAcaccountDeposit")]
    public virtual ICollection<Arcustomer> ArcustomerFkAcaccountDeposits { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkAcaccountPurchase")]
    public virtual ICollection<Arcustomer> ArcustomerFkAcaccountPurchases { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkAcaccountSale")]
    public virtual ICollection<Arcustomer> ArcustomerFkAcaccountSales { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<Arcustomer> ArcustomerFkAcaccounts { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<ArcustomerPaymentDocument> ArcustomerPaymentDocumentFkAccreditAccounts { get; set; } = new List<ArcustomerPaymentDocument>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<ArcustomerPaymentDocument> ArcustomerPaymentDocumentFkAcdebitAccounts { get; set; } = new List<ArcustomerPaymentDocument>();

    [InverseProperty("FkAcaccountDeposit")]
    public virtual ICollection<ArcustomerTypeAccountConfig> ArcustomerTypeAccountConfigFkAcaccountDeposits { get; set; } = new List<ArcustomerTypeAccountConfig>();

    [InverseProperty("FkAcaccountPurchase")]
    public virtual ICollection<ArcustomerTypeAccountConfig> ArcustomerTypeAccountConfigFkAcaccountPurchases { get; set; } = new List<ArcustomerTypeAccountConfig>();

    [InverseProperty("FkAcaccountSale")]
    public virtual ICollection<ArcustomerTypeAccountConfig> ArcustomerTypeAccountConfigFkAcaccountSales { get; set; } = new List<ArcustomerTypeAccountConfig>();

    [InverseProperty("FkAcaccountRevenue")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItemFkAcaccountRevenues { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItemFkAcaccounts { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<ArpospaymentDetail> ArpospaymentDetails { get; set; } = new List<ArpospaymentDetail>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<ArreceiptVoucherItem> ArreceiptVoucherItemFkAccreditAccounts { get; set; } = new List<ArreceiptVoucherItem>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<ArreceiptVoucherItem> ArreceiptVoucherItemFkAcdebitAccounts { get; set; } = new List<ArreceiptVoucherItem>();

    [InverseProperty("FkAcoffsetAccount")]
    public virtual ICollection<ArsaleReturnItem> ArsaleReturnItems { get; set; } = new List<ArsaleReturnItem>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<ArsopaymentTimeInvoiceDetail> ArsopaymentTimeInvoiceDetailFkAccreditAccounts { get; set; } = new List<ArsopaymentTimeInvoiceDetail>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<ArsopaymentTimeInvoiceDetail> ArsopaymentTimeInvoiceDetailFkAcdebitAccounts { get; set; } = new List<ArsopaymentTimeInvoiceDetail>();

    [InverseProperty("FkAcacount")]
    public virtual ICollection<CscashFund> CscashFunds { get; set; } = new List<CscashFund>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoiceFkAccreditAccounts { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoiceFkAcdebitAccounts { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkAcaccountDeposit")]
    public virtual ICollection<Hremployee> HremployeeFkAcaccountDeposits { get; set; } = new List<Hremployee>();

    [InverseProperty("FkAcaccountPurchase")]
    public virtual ICollection<Hremployee> HremployeeFkAcaccountPurchases { get; set; } = new List<Hremployee>();

    [InverseProperty("FkAcaccountSale")]
    public virtual ICollection<Hremployee> HremployeeFkAcaccountSales { get; set; } = new List<Hremployee>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<IcfeeConfig> IcfeeConfigs { get; set; } = new List<IcfeeConfig>();

    [InverseProperty("FkAcacount")]
    public virtual ICollection<IcimportAndExportReason> IcimportAndExportReasons { get; set; } = new List<IcimportAndExportReason>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<IcproductConversionItem> IcproductConversionItems { get; set; } = new List<IcproductConversionItem>();

    [InverseProperty("FkAcaccountCostPrice")]
    public virtual ICollection<Icproduct> IcproductFkAcaccountCostPrices { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcaccountDiscount")]
    public virtual ICollection<Icproduct> IcproductFkAcaccountDiscounts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcaccountRevenueHinterLand")]
    public virtual ICollection<Icproduct> IcproductFkAcaccountRevenueHinterLands { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcaccountRevenueInternal")]
    public virtual ICollection<Icproduct> IcproductFkAcaccountRevenueInternals { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcaccountRevenue")]
    public virtual ICollection<Icproduct> IcproductFkAcaccountRevenues { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcaccountSaleReturn")]
    public virtual ICollection<Icproduct> IcproductFkAcaccountSaleReturns { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<Icproduct> IcproductFkAcaccounts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcdepreciationAccount")]
    public virtual ICollection<Icproduct> IcproductFkAcdepreciationAccounts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<Icproduct> IcproductFkAcdepreciationCostAccounts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkAcaccountCostPrice")]
    public virtual ICollection<IcproductTypeAccountConfig> IcproductTypeAccountConfigFkAcaccountCostPrices { get; set; } = new List<IcproductTypeAccountConfig>();

    [InverseProperty("FkAcaccountDiscount")]
    public virtual ICollection<IcproductTypeAccountConfig> IcproductTypeAccountConfigFkAcaccountDiscounts { get; set; } = new List<IcproductTypeAccountConfig>();

    [InverseProperty("FkAcaccountRevenueHinterLand")]
    public virtual ICollection<IcproductTypeAccountConfig> IcproductTypeAccountConfigFkAcaccountRevenueHinterLands { get; set; } = new List<IcproductTypeAccountConfig>();

    [InverseProperty("FkAcaccountRevenueInternal")]
    public virtual ICollection<IcproductTypeAccountConfig> IcproductTypeAccountConfigFkAcaccountRevenueInternals { get; set; } = new List<IcproductTypeAccountConfig>();

    [InverseProperty("FkAcaccountRevenue")]
    public virtual ICollection<IcproductTypeAccountConfig> IcproductTypeAccountConfigFkAcaccountRevenues { get; set; } = new List<IcproductTypeAccountConfig>();

    [InverseProperty("FkAcaccountSaleReturn")]
    public virtual ICollection<IcproductTypeAccountConfig> IcproductTypeAccountConfigFkAcaccountSaleReturns { get; set; } = new List<IcproductTypeAccountConfig>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<IcproductTypeAccountConfig> IcproductTypeAccountConfigFkAcaccounts { get; set; } = new List<IcproductTypeAccountConfig>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkAcaccounts { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkAcoffsetAccount")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkAcoffsetAccounts { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkActransitInAccount")]
    public virtual ICollection<IcreceiptItem> IcreceiptItemFkActransitInAccounts { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkAcaccounts { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkAcdepreciationCostAccount")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkAcdepreciationCostAccounts { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkAcoffsetAccount")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkAcoffsetAccounts { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkActransitInAccount")]
    public virtual ICollection<IcshipmentItem> IcshipmentItemFkActransitInAccounts { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<Icstock> Icstocks { get; set; } = new List<Icstock>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<IctransferItem> IctransferItemFkAcaccounts { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkAcoffsetAccount")]
    public virtual ICollection<IctransferItem> IctransferItemFkAcoffsetAccounts { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkActransitInAccount")]
    public virtual ICollection<IctransferItem> IctransferItemFkActransitInAccounts { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<MmconfigAccountOperation> MmconfigAccountOperationFkAcaccounts { get; set; } = new List<MmconfigAccountOperation>();

    [InverseProperty("FkAccostAccount")]
    public virtual ICollection<MmconfigAccountOperation> MmconfigAccountOperationFkAccostAccounts { get; set; } = new List<MmconfigAccountOperation>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<MmconfigAccountOperation> MmconfigAccountOperationFkAcdebitAccounts { get; set; } = new List<MmconfigAccountOperation>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetailFkAcaccounts { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkAcoffsetAccount")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetailFkAcoffsetAccounts { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkAcaccount")]
    public virtual ICollection<Mmoperation> MmoperationFkAcaccounts { get; set; } = new List<Mmoperation>();

    [InverseProperty("FkAccostAccount")]
    public virtual ICollection<Mmoperation> MmoperationFkAccostAccounts { get; set; } = new List<Mmoperation>();

    [InverseProperty("FkAcingrogressAccount")]
    public virtual ICollection<Mmoperation> MmoperationFkAcingrogressAccounts { get; set; } = new List<Mmoperation>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<MmproductionCostFactor> MmproductionCostFactorFkAccreditAccounts { get; set; } = new List<MmproductionCostFactor>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<MmproductionCostFactor> MmproductionCostFactorFkAcdebitAccounts { get; set; } = new List<MmproductionCostFactor>();

    [InverseProperty("FkAcinProgressAccount")]
    public virtual ICollection<MmproductionCostFactor> MmproductionCostFactorFkAcinProgressAccounts { get; set; } = new List<MmproductionCostFactor>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetailFkAccreditAccounts { get; set; } = new List<MmproductionCostFormulaDetail>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetailFkAcdebitAccounts { get; set; } = new List<MmproductionCostFormulaDetail>();

    [InverseProperty("FkAcinProgressAccount")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetailFkAcinProgressAccounts { get; set; } = new List<MmproductionCostFormulaDetail>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<MmproductionCostGeneralCostAllocation> MmproductionCostGeneralCostAllocationFkAccreditAccounts { get; set; } = new List<MmproductionCostGeneralCostAllocation>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<MmproductionCostGeneralCostAllocation> MmproductionCostGeneralCostAllocationFkAcdebitAccounts { get; set; } = new List<MmproductionCostGeneralCostAllocation>();

    [InverseProperty("FkAccreditAccount")]
    public virtual ICollection<MmproductionNormCostFactor> MmproductionNormCostFactorFkAccreditAccounts { get; set; } = new List<MmproductionNormCostFactor>();

    [InverseProperty("FkAcdebitAccount")]
    public virtual ICollection<MmproductionNormCostFactor> MmproductionNormCostFactorFkAcdebitAccounts { get; set; } = new List<MmproductionNormCostFactor>();
}
