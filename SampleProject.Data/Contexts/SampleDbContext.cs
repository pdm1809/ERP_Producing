using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SampleProject.Data.Models;

namespace SampleProject.Data.Contexts;

public partial class SampleDbContext : DbContext
{
    public SampleDbContext(DbContextOptions<SampleDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AacolumnAlias> AacolumnAliases { get; set; }

    public virtual DbSet<AacolumnAliasLanguage> AacolumnAliasLanguages { get; set; }

    public virtual DbSet<AapayRollColumnAlias> AapayRollColumnAliases { get; set; }

    public virtual DbSet<AcacceptanceItem> AcacceptanceItems { get; set; }

    public virtual DbSet<Acaccount> Acaccounts { get; set; }

    public virtual DbSet<AcaccountDetail> AcaccountDetails { get; set; }

    public virtual DbSet<AcaccountTranferCost> AcaccountTranferCosts { get; set; }

    public virtual DbSet<AcaccountingBill> AcaccountingBills { get; set; }

    public virtual DbSet<AcaccountingSheet> AcaccountingSheets { get; set; }

    public virtual DbSet<AcaccountingSheetDetail> AcaccountingSheetDetails { get; set; }

    public virtual DbSet<AcactualCostBudget> AcactualCostBudgets { get; set; }

    public virtual DbSet<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; }

    public virtual DbSet<AcadjustIncreaseOrDecreaseAsset> AcadjustIncreaseOrDecreaseAssets { get; set; }

    public virtual DbSet<AcadjustIncreaseOrDecreaseAssetItem> AcadjustIncreaseOrDecreaseAssetItems { get; set; }

    public virtual DbSet<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; }

    public virtual DbSet<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; }

    public virtual DbSet<Acasset> Acassets { get; set; }

    public virtual DbSet<AcassetReceipt> AcassetReceipts { get; set; }

    public virtual DbSet<AcassetReceiptItem> AcassetReceiptItems { get; set; }

    public virtual DbSet<AcassetShipmentItem> AcassetShipmentItems { get; set; }

    public virtual DbSet<AcassetTransferItem> AcassetTransferItems { get; set; }

    public virtual DbSet<AcassetTypeAccountConfig> AcassetTypeAccountConfigs { get; set; }

    public virtual DbSet<AcassetTypeDepreciationConfig> AcassetTypeDepreciationConfigs { get; set; }

    public virtual DbSet<Acbalance> Acbalances { get; set; }

    public virtual DbSet<AcbalanceAmountArising> AcbalanceAmountArisings { get; set; }

    public virtual DbSet<AcbalanceAmountArisingDetail> AcbalanceAmountArisingDetails { get; set; }

    public virtual DbSet<AcbalanceAmountArisingObjectDetail> AcbalanceAmountArisingObjectDetails { get; set; }

    public virtual DbSet<AcbankTransaction> AcbankTransactions { get; set; }

    public virtual DbSet<AcbankTransactionItem> AcbankTransactionItems { get; set; }

    public virtual DbSet<AcbudgetTracking> AcbudgetTrackings { get; set; }

    public virtual DbSet<AcbudgetTrackingItem> AcbudgetTrackingItems { get; set; }

    public virtual DbSet<AcbusinessResult> AcbusinessResults { get; set; }

    public virtual DbSet<AcbusinessResultDetail> AcbusinessResultDetails { get; set; }

    public virtual DbSet<AcclearingDebt> AcclearingDebts { get; set; }

    public virtual DbSet<AcclearingDebtInvoiceInItem> AcclearingDebtInvoiceInItems { get; set; }

    public virtual DbSet<AcclearingDebtInvoiceItem> AcclearingDebtInvoiceItems { get; set; }

    public virtual DbSet<AccostBudget> AccostBudgets { get; set; }

    public virtual DbSet<AccostBudgetDetail> AccostBudgetDetails { get; set; }

    public virtual DbSet<AccostCenter> AccostCenters { get; set; }

    public virtual DbSet<AccostObject> AccostObjects { get; set; }

    public virtual DbSet<AccostObjectItem> AccostObjectItems { get; set; }

    public virtual DbSet<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; }

    public virtual DbSet<Acdevice> Acdevices { get; set; }

    public virtual DbSet<AcdocTypeEntry> AcdocTypeEntrys { get; set; }

    public virtual DbSet<AcdocTypeEntryAccount> AcdocTypeEntryAccounts { get; set; }

    public virtual DbSet<AcdocTypeEntryFunctionMapping> AcdocTypeEntryFunctionMappings { get; set; }

    public virtual DbSet<Acdocument> Acdocuments { get; set; }

    public virtual DbSet<AcdocumentEntry> AcdocumentEntrys { get; set; }

    public virtual DbSet<AcdocumentTran> AcdocumentTrans { get; set; }

    public virtual DbSet<AcdocumentType> AcdocumentTypes { get; set; }

    public virtual DbSet<AceinvoiceConfig> AceinvoiceConfigs { get; set; }

    public virtual DbSet<AceinvoiceDetail> AceinvoiceDetails { get; set; }

    public virtual DbSet<AceinvoiceGeneral> AceinvoiceGenerals { get; set; }

    public virtual DbSet<AceinvoicePayment> AceinvoicePayments { get; set; }

    public virtual DbSet<AceinvoicePaymentMethod> AceinvoicePaymentMethods { get; set; }

    public virtual DbSet<AceinvoiceTaxLevelAndAmount> AceinvoiceTaxLevelAndAmounts { get; set; }

    public virtual DbSet<AceinvoiceType> AceinvoiceTypes { get; set; }

    public virtual DbSet<AcendingAllocation> AcendingAllocations { get; set; }

    public virtual DbSet<AcendingAllocationDeclaration> AcendingAllocationDeclarations { get; set; }

    public virtual DbSet<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; }

    public virtual DbSet<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; }

    public virtual DbSet<AcendingAllocationItem> AcendingAllocationItems { get; set; }

    public virtual DbSet<AcentryType> AcentryTypes { get; set; }

    public virtual DbSet<AcequipmentState> AcequipmentStates { get; set; }

    public virtual DbSet<AcequipmentTransferItem> AcequipmentTransferItems { get; set; }

    public virtual DbSet<AcequipmentTypeAccountConfig> AcequipmentTypeAccountConfigs { get; set; }

    public virtual DbSet<AcfileAttachment> AcfileAttachments { get; set; }

    public virtual DbSet<Achistory> Achistorys { get; set; }

    public virtual DbSet<AchistoryDetail> AchistoryDetails { get; set; }

    public virtual DbSet<AclistAccountBank> AclistAccountBanks { get; set; }

    public virtual DbSet<AcloanAgreement> AcloanAgreements { get; set; }

    public virtual DbSet<AcloanReceipt> AcloanReceipts { get; set; }

    public virtual DbSet<AcloanReceiptInterestRateChange> AcloanReceiptInterestRateChanges { get; set; }

    public virtual DbSet<AcloanReceiptItem> AcloanReceiptItems { get; set; }

    public virtual DbSet<AcloanReceiptPayDoc> AcloanReceiptPayDocs { get; set; }

    public virtual DbSet<AcloanReceiptPaymentPlan> AcloanReceiptPaymentPlans { get; set; }

    public virtual DbSet<AcloanReceiptType> AcloanReceiptTypes { get; set; }

    public virtual DbSet<AcmoneyChange> AcmoneyChanges { get; set; }

    public virtual DbSet<AcmoneyChangeItem> AcmoneyChangeItems { get; set; }

    public virtual DbSet<AcrelativeDocument> AcrelativeDocuments { get; set; }

    public virtual DbSet<AcretailVat> AcretailVats { get; set; }

    public virtual DbSet<AcretailVatitem> AcretailVatitems { get; set; }

    public virtual DbSet<AcrevenueBudget> AcrevenueBudgets { get; set; }

    public virtual DbSet<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; }

    public virtual DbSet<AcsalaryCalculation> AcsalaryCalculations { get; set; }

    public virtual DbSet<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; }

    public virtual DbSet<AcsalaryDocumentType> AcsalaryDocumentTypes { get; set; }

    public virtual DbSet<AcsalaryDocumentTypePayRollDetail> AcsalaryDocumentTypePayRollDetails { get; set; }

    public virtual DbSet<AcsalaryEntryType> AcsalaryEntryTypes { get; set; }

    public virtual DbSet<AcsalaryEntryTypeDetail> AcsalaryEntryTypeDetails { get; set; }

    public virtual DbSet<AcsalaryEntryTypeDetailPart> AcsalaryEntryTypeDetailParts { get; set; }

    public virtual DbSet<Acsegment> Acsegments { get; set; }

    public virtual DbSet<AcsegmentDocumentControl> AcsegmentDocumentControls { get; set; }

    public virtual DbSet<AcsegmentObjectControl> AcsegmentObjectControls { get; set; }

    public virtual DbSet<AcstopAllocationEquipment> AcstopAllocationEquipments { get; set; }

    public virtual DbSet<AcstopDepreciationAsset> AcstopDepreciationAssets { get; set; }

    public virtual DbSet<ActaxUnit> ActaxUnits { get; set; }

    public virtual DbSet<Actransaction> Actransactions { get; set; }

    public virtual DbSet<AcunfinishedConstructionCost> AcunfinishedConstructionCosts { get; set; }

    public virtual DbSet<Acvat> Acvats { get; set; }

    public virtual DbSet<AdappUserPermission> AdappUserPermissions { get; set; }

    public virtual DbSet<AdauditLog> AdauditLogs { get; set; }

    public virtual DbSet<AdcompletePermissionConfig> AdcompletePermissionConfigs { get; set; }

    public virtual DbSet<AdconfigValue> AdconfigValues { get; set; }

    public virtual DbSet<AdconfigValuesTemp> AdconfigValuesTemps { get; set; }

    public virtual DbSet<Adcriteria> Adcriterias { get; set; }

    public virtual DbSet<AddataViewPermission> AddataViewPermissions { get; set; }

    public virtual DbSet<AddataViewPermissionAppStaff> AddataViewPermissionAppStaffs { get; set; }

    public virtual DbSet<AddefaultDescConfig> AddefaultDescConfigs { get; set; }

    public virtual DbSet<AddirectoryPathConfig> AddirectoryPathConfigs { get; set; }

    public virtual DbSet<Addiscount> Addiscounts { get; set; }

    public virtual DbSet<AdfengShuisColor> AdfengShuisColors { get; set; }

    public virtual DbSet<AdfengShuisDirection> AdfengShuisDirections { get; set; }

    public virtual DbSet<AdfengShuisGenaral> AdfengShuisGenarals { get; set; }

    public virtual DbSet<AdfileReference> AdfileReferences { get; set; }

    public virtual DbSet<Adfunction> Adfunctions { get; set; }

    public virtual DbSet<AdfunctionWeb> AdfunctionWebs { get; set; }

    public virtual DbSet<AdgenerateProductNoConfig> AdgenerateProductNoConfigs { get; set; }

    public virtual DbSet<AdgroupAppStaff> AdgroupAppStaffs { get; set; }

    public virtual DbSet<AdgroupOrderWeb> AdgroupOrderWebs { get; set; }

    public virtual DbSet<AdgroupTimeSheetPermission> AdgroupTimeSheetPermissions { get; set; }

    public virtual DbSet<Adhistory> Adhistorys { get; set; }

    public virtual DbSet<AdhistoryDetail> AdhistoryDetails { get; set; }

    public virtual DbSet<Adinsurrance> Adinsurrances { get; set; }

    public virtual DbSet<AdinsurranceCondition> AdinsurranceConditions { get; set; }

    public virtual DbSet<AdinsurrancePaper> AdinsurrancePapers { get; set; }

    public virtual DbSet<AdinsurrancePlan> AdinsurrancePlans { get; set; }

    public virtual DbSet<Adlock> Adlocks { get; set; }

    public virtual DbSet<AdmatchCode> AdmatchCodes { get; set; }

    public virtual DbSet<AdmigrationScript> AdmigrationScripts { get; set; }

    public virtual DbSet<AdmoduleFieldsToUser> AdmoduleFieldsToUsers { get; set; }

    public virtual DbSet<AdobjectModulePermission> AdobjectModulePermissions { get; set; }

    public virtual DbSet<AdobjectViewPermission> AdobjectViewPermissions { get; set; }

    public virtual DbSet<AdoperationProductTypeConfig> AdoperationProductTypeConfigs { get; set; }

    public virtual DbSet<Adotfactor> Adotfactors { get; set; }

    public virtual DbSet<AdpaymentMethod> AdpaymentMethods { get; set; }

    public virtual DbSet<Adpermission> Adpermissions { get; set; }

    public virtual DbSet<AdpriceGroup> AdpriceGroups { get; set; }

    public virtual DbSet<Adprivilege> Adprivileges { get; set; }

    public virtual DbSet<AdprivilegeAppSatff> AdprivilegeAppSatffs { get; set; }

    public virtual DbSet<AdprivilegeDetail> AdprivilegeDetails { get; set; }

    public virtual DbSet<AdprivilegeGroup> AdprivilegeGroups { get; set; }

    public virtual DbSet<AdprivilegeUserGroup> AdprivilegeUserGroups { get; set; }

    public virtual DbSet<AdpushNotification> AdpushNotifications { get; set; }

    public virtual DbSet<AdremindWorking> AdremindWorkings { get; set; }

    public virtual DbSet<Adreport> Adreports { get; set; }

    public virtual DbSet<AdreportLanguage> AdreportLanguages { get; set; }

    public virtual DbSet<AdreportPermission> AdreportPermissions { get; set; }

    public virtual DbSet<AdreportTemplate> AdreportTemplates { get; set; }

    public virtual DbSet<AdreportView> AdreportViews { get; set; }

    public virtual DbSet<AdreportViewRef> AdreportViewRefs { get; set; }

    public virtual DbSet<AdreportViewRefParam> AdreportViewRefParams { get; set; }

    public virtual DbSet<AdtargetReportBudget> AdtargetReportBudgets { get; set; }

    public virtual DbSet<Adtemplate> Adtemplates { get; set; }

    public virtual DbSet<AdtemplateParam> AdtemplateParams { get; set; }

    public virtual DbSet<AdtemplateToolbar> AdtemplateToolbars { get; set; }

    public virtual DbSet<AdtimesheetConfig> AdtimesheetConfigs { get; set; }

    public virtual DbSet<Aduser> Adusers { get; set; }

    public virtual DbSet<AduserDevice> AduserDevices { get; set; }

    public virtual DbSet<AduserGroup> AduserGroups { get; set; }

    public virtual DbSet<AduserGroupFunction> AduserGroupFunctions { get; set; }

    public virtual DbSet<AduserGroupMember> AduserGroupMembers { get; set; }

    public virtual DbSet<AduserGroupSection> AduserGroupSections { get; set; }

    public virtual DbSet<AduserGroupSectionLanguage> AduserGroupSectionLanguages { get; set; }

    public virtual DbSet<AduserLocation> AduserLocations { get; set; }

    public virtual DbSet<AdworkingShift> AdworkingShifts { get; set; }

    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }

    public virtual DbSet<ApallocationCost> ApallocationCosts { get; set; }

    public virtual DbSet<ApallocationCostItem> ApallocationCostItems { get; set; }

    public virtual DbSet<ApallocationCostItemInvoice> ApallocationCostItemInvoices { get; set; }

    public virtual DbSet<ApallocationCostItemInvoiceIn> ApallocationCostItemInvoiceIns { get; set; }

    public virtual DbSet<ApallocationCostItemShipment> ApallocationCostItemShipments { get; set; }

    public virtual DbSet<ApbillOfLading> ApbillOfLadings { get; set; }

    public virtual DbSet<ApbillOfLadingItem> ApbillOfLadingItems { get; set; }

    public virtual DbSet<ApcancelPurchaseOrder> ApcancelPurchaseOrders { get; set; }

    public virtual DbSet<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; }

    public virtual DbSet<ApcancelPurchaseProposal> ApcancelPurchaseProposals { get; set; }

    public virtual DbSet<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; }

    public virtual DbSet<ApclearInvoiceIn> ApclearInvoiceIns { get; set; }

    public virtual DbSet<ApclearInvoiceInDocument> ApclearInvoiceInDocuments { get; set; }

    public virtual DbSet<ApclearInvoiceInInvoiceIn> ApclearInvoiceInInvoiceIns { get; set; }

    public virtual DbSet<ApclearingDetail> ApclearingDetails { get; set; }

    public virtual DbSet<ApdocumentPayment> ApdocumentPayments { get; set; }

    public virtual DbSet<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; }

    public virtual DbSet<ApfeePaymentInvoice> ApfeePaymentInvoices { get; set; }

    public virtual DbSet<ApfeePaymentInvoiceIn> ApfeePaymentInvoiceIns { get; set; }

    public virtual DbSet<ApfeePaymentInvoiceInternalReceipt> ApfeePaymentInvoiceInternalReceipts { get; set; }

    public virtual DbSet<ApfeePaymentItem> ApfeePaymentItems { get; set; }

    public virtual DbSet<ApfeePaymentPurchaseOrder> ApfeePaymentPurchaseOrders { get; set; }

    public virtual DbSet<ApfeePaymentReceipt> ApfeePaymentReceipts { get; set; }

    public virtual DbSet<ApfeePaymentTransfer> ApfeePaymentTransfers { get; set; }

    public virtual DbSet<ApfileAttachment> ApfileAttachments { get; set; }

    public virtual DbSet<Aphistory> Aphistorys { get; set; }

    public virtual DbSet<AphistoryDetail> AphistoryDetails { get; set; }

    public virtual DbSet<ApinvoiceIn> ApinvoiceIns { get; set; }

    public virtual DbSet<ApinvoiceInItem> ApinvoiceInItems { get; set; }

    public virtual DbSet<ApinvoiceInPackageItem> ApinvoiceInPackageItems { get; set; }

    public virtual DbSet<ApinvoiceInPackageItemDetail> ApinvoiceInPackageItemDetails { get; set; }

    public virtual DbSet<ApinvoiceInTransaction> ApinvoiceInTransactions { get; set; }

    public virtual DbSet<ApopenDocument> ApopenDocuments { get; set; }

    public virtual DbSet<AppaymentProposal> AppaymentProposals { get; set; }

    public virtual DbSet<AppaymentProposalApproval> AppaymentProposalApprovals { get; set; }

    public virtual DbSet<AppaymentProposalItem> AppaymentProposalItems { get; set; }

    public virtual DbSet<AppaymentProposalPayment> AppaymentProposalPayments { get; set; }

    public virtual DbSet<AppaymentVoucher> AppaymentVouchers { get; set; }

    public virtual DbSet<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; }

    public virtual DbSet<AppaymentVoucherItem> AppaymentVoucherItems { get; set; }

    public virtual DbSet<AppaymentVoucherItemDetail> AppaymentVoucherItemDetails { get; set; }

    public virtual DbSet<AppopackageItem> AppopackageItems { get; set; }

    public virtual DbSet<AppopackageItemDetail> AppopackageItemDetails { get; set; }

    public virtual DbSet<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetails { get; set; }

    public virtual DbSet<AppriceSheet> AppriceSheets { get; set; }

    public virtual DbSet<AppriceSheetItem> AppriceSheetItems { get; set; }

    public virtual DbSet<Approposal> Approposals { get; set; }

    public virtual DbSet<ApproposalApproval> ApproposalApprovals { get; set; }

    public virtual DbSet<ApproposalItem> ApproposalItems { get; set; }

    public virtual DbSet<ApproposalItemTotal> ApproposalItemTotals { get; set; }

    public virtual DbSet<AppurchaseContract> AppurchaseContracts { get; set; }

    public virtual DbSet<AppurchaseContractGroup> AppurchaseContractGroups { get; set; }

    public virtual DbSet<AppurchaseOrder> AppurchaseOrders { get; set; }

    public virtual DbSet<AppurchaseOrderApproval> AppurchaseOrderApprovals { get; set; }

    public virtual DbSet<AppurchaseOrderHistory> AppurchaseOrderHistorys { get; set; }

    public virtual DbSet<AppurchaseOrderItem> AppurchaseOrderItems { get; set; }

    public virtual DbSet<AppurchaseOrderItemDelivery> AppurchaseOrderItemDeliverys { get; set; }

    public virtual DbSet<AppurchaseOrderItemOutSourcing> AppurchaseOrderItemOutSourcings { get; set; }

    public virtual DbSet<AppurchaseOrderPaymentTime> AppurchaseOrderPaymentTimes { get; set; }

    public virtual DbSet<ApreturnSupplier> ApreturnSuppliers { get; set; }

    public virtual DbSet<ApreturnSupplierItem> ApreturnSupplierItems { get; set; }

    public virtual DbSet<Apsupplier> Apsuppliers { get; set; }

    public virtual DbSet<ApsupplierComment> ApsupplierComments { get; set; }

    public virtual DbSet<ApsupplierContact> ApsupplierContacts { get; set; }

    public virtual DbSet<ApsupplierDepartment> ApsupplierDepartments { get; set; }

    public virtual DbSet<ApsupplierDiscount> ApsupplierDiscounts { get; set; }

    public virtual DbSet<ApsupplierPayment> ApsupplierPayments { get; set; }

    public virtual DbSet<ApsupplierPaymentDetail> ApsupplierPaymentDetails { get; set; }

    public virtual DbSet<ApsupplierPaymentDocument> ApsupplierPaymentDocuments { get; set; }

    public virtual DbSet<ApsupplierProductDiscount> ApsupplierProductDiscounts { get; set; }

    public virtual DbSet<ApsupplierProductGroupDiscount> ApsupplierProductGroupDiscounts { get; set; }

    public virtual DbSet<ApsupplierProductNumber> ApsupplierProductNumbers { get; set; }

    public virtual DbSet<ApsupplierTypeAccountConfig> ApsupplierTypeAccountConfigs { get; set; }

    public virtual DbSet<Aracceptance> Aracceptances { get; set; }

    public virtual DbSet<AracceptanceItem> AracceptanceItems { get; set; }

    public virtual DbSet<AracceptanceItemWork> AracceptanceItemWorks { get; set; }

    public virtual DbSet<Aractivity> Aractivitys { get; set; }

    public virtual DbSet<AractivitysHistory> AractivitysHistorys { get; set; }

    public virtual DbSet<AradjustSaleOrderQuantity> AradjustSaleOrderQuantitys { get; set; }

    public virtual DbSet<AradjustSaleOrderQuantityItem> AradjustSaleOrderQuantityItems { get; set; }

    public virtual DbSet<Arallocation> Arallocations { get; set; }

    public virtual DbSet<ArallocationItem> ArallocationItems { get; set; }

    public virtual DbSet<ArcalculateDiscount> ArcalculateDiscounts { get; set; }

    public virtual DbSet<ArcalculateDiscountItem> ArcalculateDiscountItems { get; set; }

    public virtual DbSet<Arcampaign> Arcampaigns { get; set; }

    public virtual DbSet<ArcampaignsHistory> ArcampaignsHistorys { get; set; }

    public virtual DbSet<ArcancelSaleForecast> ArcancelSaleForecasts { get; set; }

    public virtual DbSet<ArcancelSaleForecastItem> ArcancelSaleForecastItems { get; set; }

    public virtual DbSet<ArcancelVoucher> ArcancelVouchers { get; set; }

    public virtual DbSet<ArcancelVoucherItem> ArcancelVoucherItems { get; set; }

    public virtual DbSet<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; }

    public virtual DbSet<ArcanceledDeliveryPlan> ArcanceledDeliveryPlans { get; set; }

    public virtual DbSet<ArcanceledDeliveryPlanItem> ArcanceledDeliveryPlanItems { get; set; }

    public virtual DbSet<ArclearInvoice> ArclearInvoices { get; set; }

    public virtual DbSet<ArclearInvoiceDocument> ArclearInvoiceDocuments { get; set; }

    public virtual DbSet<ArclearInvoiceInvoice> ArclearInvoiceInvoices { get; set; }

    public virtual DbSet<ArclearingDetail> ArclearingDetails { get; set; }

    public virtual DbSet<Arcomment> Arcomments { get; set; }

    public virtual DbSet<Arcommission> Arcommissions { get; set; }

    public virtual DbSet<ArconfigOriginalUnitPrice> ArconfigOriginalUnitPrices { get; set; }

    public virtual DbSet<ArcontainerLoader> ArcontainerLoaders { get; set; }

    public virtual DbSet<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; }

    public virtual DbSet<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; }

    public virtual DbSet<Arcoordinator> Arcoordinators { get; set; }

    public virtual DbSet<ArcreditNote> ArcreditNotes { get; set; }

    public virtual DbSet<ArcreditNoteInvoice> ArcreditNoteInvoices { get; set; }

    public virtual DbSet<ArcreditNoteItem> ArcreditNoteItems { get; set; }

    public virtual DbSet<ArcreditNoteItemInvoiceItem> ArcreditNoteItemInvoiceItems { get; set; }

    public virtual DbSet<Arcustomer> Arcustomers { get; set; }

    public virtual DbSet<ArcustomerBusinessType> ArcustomerBusinessTypes { get; set; }

    public virtual DbSet<ArcustomerComment> ArcustomerComments { get; set; }

    public virtual DbSet<ArcustomerContact> ArcustomerContacts { get; set; }

    public virtual DbSet<ArcustomerContactGroup> ArcustomerContactGroups { get; set; }

    public virtual DbSet<ArcustomerContactGroupsHistory> ArcustomerContactGroupsHistorys { get; set; }

    public virtual DbSet<ArcustomerContactsHistory> ArcustomerContactsHistorys { get; set; }

    public virtual DbSet<ArcustomerDiscount> ArcustomerDiscounts { get; set; }

    public virtual DbSet<ArcustomerDistributionChannel> ArcustomerDistributionChannels { get; set; }

    public virtual DbSet<ArcustomerInfoContact> ArcustomerInfoContacts { get; set; }

    public virtual DbSet<ArcustomerPayment> ArcustomerPayments { get; set; }

    public virtual DbSet<ArcustomerPaymentCurrency> ArcustomerPaymentCurrencys { get; set; }

    public virtual DbSet<ArcustomerPaymentDetail> ArcustomerPaymentDetails { get; set; }

    public virtual DbSet<ArcustomerPaymentDocument> ArcustomerPaymentDocuments { get; set; }

    public virtual DbSet<ArcustomerPaymentTimePayment> ArcustomerPaymentTimePayments { get; set; }

    public virtual DbSet<ArcustomerProductDiscount> ArcustomerProductDiscounts { get; set; }

    public virtual DbSet<ArcustomerProductGroupDiscount> ArcustomerProductGroupDiscounts { get; set; }

    public virtual DbSet<ArcustomerProductNumber> ArcustomerProductNumbers { get; set; }

    public virtual DbSet<ArcustomerResource> ArcustomerResources { get; set; }

    public virtual DbSet<ArcustomerSaleOrderTypeConfig> ArcustomerSaleOrderTypeConfigs { get; set; }

    public virtual DbSet<ArcustomerTypeAccountConfig> ArcustomerTypeAccountConfigs { get; set; }

    public virtual DbSet<ArcustomersHistory> ArcustomersHistorys { get; set; }

    public virtual DbSet<Ardelivery> Ardeliverys { get; set; }

    public virtual DbSet<ArdeliveryMethod> ArdeliveryMethods { get; set; }

    public virtual DbSet<ArdeliveryPlan> ArdeliveryPlans { get; set; }

    public virtual DbSet<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; }

    public virtual DbSet<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; }

    public virtual DbSet<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; }

    public virtual DbSet<ArdeliveryPlanReportIssue> ArdeliveryPlanReportIssues { get; set; }

    public virtual DbSet<ArdeliveryPlanTruck> ArdeliveryPlanTrucks { get; set; }

    public virtual DbSet<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; }

    public virtual DbSet<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; }

    public virtual DbSet<ArdeliveryPlanWork> ArdeliveryPlanWorks { get; set; }

    public virtual DbSet<ArdeliveryPlanWorkAsset> ArdeliveryPlanWorkAssets { get; set; }

    public virtual DbSet<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; }

    public virtual DbSet<ArdiscountProgram> ArdiscountPrograms { get; set; }

    public virtual DbSet<ArdiscountProgramItem> ArdiscountProgramItems { get; set; }

    public virtual DbSet<ArdiscountProgramItemTarget> ArdiscountProgramItemTargets { get; set; }

    public virtual DbSet<ArdocumentPayment> ArdocumentPayments { get; set; }

    public virtual DbSet<AremailTracking> AremailTrackings { get; set; }

    public virtual DbSet<Arestimate> Arestimates { get; set; }

    public virtual DbSet<ArestimateItem> ArestimateItems { get; set; }

    public virtual DbSet<ArfeePaymentCommission> ArfeePaymentCommissions { get; set; }

    public virtual DbSet<Arhistory> Arhistorys { get; set; }

    public virtual DbSet<ArhistoryDetail> ArhistoryDetails { get; set; }

    public virtual DbSet<Arinvoice> Arinvoices { get; set; }

    public virtual DbSet<ArinvoiceCommission> ArinvoiceCommissions { get; set; }

    public virtual DbSet<ArinvoiceItem> ArinvoiceItems { get; set; }

    public virtual DbSet<ArinvoiceItemComponent> ArinvoiceItemComponents { get; set; }

    public virtual DbSet<ArinvoiceItemPackage> ArinvoiceItemPackages { get; set; }

    public virtual DbSet<ArinvoiceItemShipmentItem> ArinvoiceItemShipmentItems { get; set; }

    public virtual DbSet<ArinvoiceItemWork> ArinvoiceItemWorks { get; set; }

    public virtual DbSet<ArinvoiceRequest> ArinvoiceRequests { get; set; }

    public virtual DbSet<ArinvoiceShipment> ArinvoiceShipments { get; set; }

    public virtual DbSet<ArinvoiceTemplate> ArinvoiceTemplates { get; set; }

    public virtual DbSet<ArinvoiceTransaction> ArinvoiceTransactions { get; set; }

    public virtual DbSet<Arnotification> Arnotifications { get; set; }

    public virtual DbSet<AropenDocument> AropenDocuments { get; set; }

    public virtual DbSet<Aropportunity> Aropportunitys { get; set; }

    public virtual DbSet<AropportunityContact> AropportunityContacts { get; set; }

    public virtual DbSet<AropportunityContactGroup> AropportunityContactGroups { get; set; }

    public virtual DbSet<AropportunityContactGroupsHistory> AropportunityContactGroupsHistorys { get; set; }

    public virtual DbSet<AropportunitysHistory> AropportunitysHistorys { get; set; }

    public virtual DbSet<ArpaymentProposal> ArpaymentProposals { get; set; }

    public virtual DbSet<ArpaymentProposalItem> ArpaymentProposalItems { get; set; }

    public virtual DbSet<ArpospaymentDetail> ArpospaymentDetails { get; set; }

    public virtual DbSet<ArpriceLevel> ArpriceLevels { get; set; }

    public virtual DbSet<ArpriceSheet> ArpriceSheets { get; set; }

    public virtual DbSet<ArpriceSheetComment> ArpriceSheetComments { get; set; }

    public virtual DbSet<ArpriceSheetItem> ArpriceSheetItems { get; set; }

    public virtual DbSet<ArpriceSheetItemWork> ArpriceSheetItemWorks { get; set; }

    public virtual DbSet<ArproductionPlanning> ArproductionPlannings { get; set; }

    public virtual DbSet<ArproductionPlanningItem> ArproductionPlanningItems { get; set; }

    public virtual DbSet<Arproposal> Arproposals { get; set; }

    public virtual DbSet<ArproposalArea> ArproposalAreas { get; set; }

    public virtual DbSet<ArproposalAreaItem> ArproposalAreaItems { get; set; }

    public virtual DbSet<ArproposalItem> ArproposalItems { get; set; }

    public virtual DbSet<ArproposalItemWork> ArproposalItemWorks { get; set; }

    public virtual DbSet<ArproposalItemWorkItem> ArproposalItemWorkItems { get; set; }

    public virtual DbSet<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; }

    public virtual DbSet<ArproposalPaymentTime> ArproposalPaymentTimes { get; set; }

    public virtual DbSet<ArproposalTemplateItem> ArproposalTemplateItems { get; set; }

    public virtual DbSet<ArprospectCustomer> ArprospectCustomers { get; set; }

    public virtual DbSet<ArprospectCustomersHistory> ArprospectCustomersHistorys { get; set; }

    public virtual DbSet<ArreceiptVoucher> ArreceiptVouchers { get; set; }

    public virtual DbSet<ArreceiptVoucherItem> ArreceiptVoucherItems { get; set; }

    public virtual DbSet<Arreception> Arreceptions { get; set; }

    public virtual DbSet<ArreceptionItem> ArreceptionItems { get; set; }

    public virtual DbSet<Arremind> Arreminds { get; set; }

    public virtual DbSet<ArrevenueForecast> ArrevenueForecasts { get; set; }

    public virtual DbSet<ArrevenueForecastItem> ArrevenueForecastItems { get; set; }

    public virtual DbSet<ArsaleContract> ArsaleContracts { get; set; }

    public virtual DbSet<ArsaleContractGroup> ArsaleContractGroups { get; set; }

    public virtual DbSet<ArsaleContractTemplate> ArsaleContractTemplates { get; set; }

    public virtual DbSet<ArsaleForecast> ArsaleForecasts { get; set; }

    public virtual DbSet<ArsaleForecastItem> ArsaleForecastItems { get; set; }

    public virtual DbSet<ArsaleForecastTemplate> ArsaleForecastTemplates { get; set; }

    public virtual DbSet<ArsaleOrder> ArsaleOrders { get; set; }

    public virtual DbSet<ArsaleOrderHistory> ArsaleOrderHistorys { get; set; }

    public virtual DbSet<ArsaleOrderHistoryDetail> ArsaleOrderHistoryDetails { get; set; }

    public virtual DbSet<ArsaleOrderItem> ArsaleOrderItems { get; set; }

    public virtual DbSet<ArsaleOrderItemAllocationFee> ArsaleOrderItemAllocationFees { get; set; }

    public virtual DbSet<ArsaleOrderItemContainer> ArsaleOrderItemContainers { get; set; }

    public virtual DbSet<ArsaleOrderItemOtherFee> ArsaleOrderItemOtherFees { get; set; }

    public virtual DbSet<ArsaleOrderItemWork> ArsaleOrderItemWorks { get; set; }

    public virtual DbSet<ArsaleOrderItemWorkItem> ArsaleOrderItemWorkItems { get; set; }

    public virtual DbSet<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; }

    public virtual DbSet<ArsaleOrderPaymentTime> ArsaleOrderPaymentTimes { get; set; }

    public virtual DbSet<ArsaleOrderPaymentTimeTemplate> ArsaleOrderPaymentTimeTemplates { get; set; }

    public virtual DbSet<ArsaleOrderSaleTypeConfig> ArsaleOrderSaleTypeConfigs { get; set; }

    public virtual DbSet<ArsaleOrderTemplate> ArsaleOrderTemplates { get; set; }

    public virtual DbSet<ArsaleReturn> ArsaleReturns { get; set; }

    public virtual DbSet<ArsaleReturnItem> ArsaleReturnItems { get; set; }

    public virtual DbSet<ArsaleReturnItemComponent> ArsaleReturnItemComponents { get; set; }

    public virtual DbSet<Arsalesman> Arsalesmans { get; set; }

    public virtual DbSet<Arseller> Arsellers { get; set; }

    public virtual DbSet<ArsellerContact> ArsellerContacts { get; set; }

    public virtual DbSet<ArsellerProduct> ArsellerProducts { get; set; }

    public virtual DbSet<ArsellerProductGroup> ArsellerProductGroups { get; set; }

    public virtual DbSet<ArsfitemComponent> ArsfitemComponents { get; set; }

    public virtual DbSet<ArsoitemComponent> ArsoitemComponents { get; set; }

    public virtual DbSet<ArsopaymentTimeInvoiceDetail> ArsopaymentTimeInvoiceDetails { get; set; }

    public virtual DbSet<AuditDataChange> AuditDataChanges { get; set; }

    public virtual DbSet<Brbranch> Brbranchs { get; set; }

    public virtual DbSet<Brhistory> Brhistorys { get; set; }

    public virtual DbSet<BrhistoryDetail> BrhistoryDetails { get; set; }

    public virtual DbSet<Brpositem> Brpositems { get; set; }

    public virtual DbSet<BrposredemptionItem> BrposredemptionItems { get; set; }

    public virtual DbSet<Brposs> Brposses { get; set; }

    public virtual DbSet<BrpostingHistory> BrpostingHistorys { get; set; }

    public virtual DbSet<BrtransferLog> BrtransferLogs { get; set; }

    public virtual DbSet<BysTable> BysTables { get; set; }

    public virtual DbSet<CheckPhuLieu> CheckPhuLieus { get; set; }

    public virtual DbSet<CheckTaiSan> CheckTaiSans { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<CrmcallCenterManager> CrmcallCenterManagers { get; set; }

    public virtual DbSet<CrmcallCenterManagerCdr> CrmcallCenterManagerCdrs { get; set; }

    public virtual DbSet<CscashFund> CscashFunds { get; set; }

    public virtual DbSet<Cscompany> Cscompanys { get; set; }

    public virtual DbSet<CscompanyBank> CscompanyBanks { get; set; }

    public virtual DbSet<CscompanyConfig> CscompanyConfigs { get; set; }

    public virtual DbSet<Faaddress> Faaddresses { get; set; }

    public virtual DbSet<Facontact> Facontacts { get; set; }

    public virtual DbSet<FacreditNote> FacreditNotes { get; set; }

    public virtual DbSet<FacreditNoteContact> FacreditNoteContacts { get; set; }

    public virtual DbSet<FacreditNoteDiscount> FacreditNoteDiscounts { get; set; }

    public virtual DbSet<FacreditNoteHistory> FacreditNoteHistorys { get; set; }

    public virtual DbSet<FacreditNoteItem> FacreditNoteItems { get; set; }

    public virtual DbSet<FacreditNoteItemDiscount> FacreditNoteItemDiscounts { get; set; }

    public virtual DbSet<FainvoiceContact> FainvoiceContacts { get; set; }

    public virtual DbSet<FainvoiceCreditNote> FainvoiceCreditNotes { get; set; }

    public virtual DbSet<FainvoiceDiscount> FainvoiceDiscounts { get; set; }

    public virtual DbSet<FainvoiceHistory> FainvoiceHistorys { get; set; }

    public virtual DbSet<FainvoiceItemCreditNoteItem> FainvoiceItemCreditNoteItems { get; set; }

    public virtual DbSet<FainvoiceItemDiscount> FainvoiceItemDiscounts { get; set; }

    public virtual DbSet<FainvoiceItemDiscount1> FainvoiceItemDiscounts1 { get; set; }

    public virtual DbSet<FainvoiceItemSellReturnItem> FainvoiceItemSellReturnItems { get; set; }

    public virtual DbSet<FainvoiceSellReturn> FainvoiceSellReturns { get; set; }

    public virtual DbSet<FaproposalContact> FaproposalContacts { get; set; }

    public virtual DbSet<FaproposalDiscount> FaproposalDiscounts { get; set; }

    public virtual DbSet<FaproposalHistory> FaproposalHistorys { get; set; }

    public virtual DbSet<FaproposalItem> FaproposalItems { get; set; }

    public virtual DbSet<FaproposalItemDiscount> FaproposalItemDiscounts { get; set; }

    public virtual DbSet<FaproposalItemSellOrderItem> FaproposalItemSellOrderItems { get; set; }

    public virtual DbSet<FaproposalSellOrder> FaproposalSellOrders { get; set; }

    public virtual DbSet<FapurchaseOrder> FapurchaseOrders { get; set; }

    public virtual DbSet<FapurchaseOrderContact> FapurchaseOrderContacts { get; set; }

    public virtual DbSet<FapurchaseOrderDiscount> FapurchaseOrderDiscounts { get; set; }

    public virtual DbSet<FapurchaseOrderHistory> FapurchaseOrderHistorys { get; set; }

    public virtual DbSet<FapurchaseOrderItem> FapurchaseOrderItems { get; set; }

    public virtual DbSet<FapurchaseOrderItemDiscount> FapurchaseOrderItemDiscounts { get; set; }

    public virtual DbSet<FapurchaseOrderItemReceiptItem> FapurchaseOrderItemReceiptItems { get; set; }

    public virtual DbSet<FapurchaseOrderItemSellOrderItem> FapurchaseOrderItemSellOrderItems { get; set; }

    public virtual DbSet<FapurchaseOrderReceipt> FapurchaseOrderReceipts { get; set; }

    public virtual DbSet<FapurchaseOrderSellOrder> FapurchaseOrderSellOrders { get; set; }

    public virtual DbSet<FareceiptContact> FareceiptContacts { get; set; }

    public virtual DbSet<FareceiptCreditNote> FareceiptCreditNotes { get; set; }

    public virtual DbSet<FareceiptDiscount> FareceiptDiscounts { get; set; }

    public virtual DbSet<FareceiptHistory> FareceiptHistorys { get; set; }

    public virtual DbSet<FareceiptItemCreditNoteItem> FareceiptItemCreditNoteItems { get; set; }

    public virtual DbSet<FareceiptItemDiscount> FareceiptItemDiscounts { get; set; }

    public virtual DbSet<FareturnSupplier> FareturnSuppliers { get; set; }

    public virtual DbSet<FareturnSupplierContact> FareturnSupplierContacts { get; set; }

    public virtual DbSet<FareturnSupplierDiscount> FareturnSupplierDiscounts { get; set; }

    public virtual DbSet<FareturnSupplierHistory> FareturnSupplierHistorys { get; set; }

    public virtual DbSet<FareturnSupplierInvoice> FareturnSupplierInvoices { get; set; }

    public virtual DbSet<FareturnSupplierItem> FareturnSupplierItems { get; set; }

    public virtual DbSet<FareturnSupplierItemDiscount> FareturnSupplierItemDiscounts { get; set; }

    public virtual DbSet<FareturnSupplierItemReceiptItem> FareturnSupplierItemReceiptItems { get; set; }

    public virtual DbSet<FareturnSupplierReceiptItem> FareturnSupplierReceiptItems { get; set; }

    public virtual DbSet<FasellOrderContact> FasellOrderContacts { get; set; }

    public virtual DbSet<FasellOrderDiscount> FasellOrderDiscounts { get; set; }

    public virtual DbSet<FasellOrderItemDiscount> FasellOrderItemDiscounts { get; set; }

    public virtual DbSet<FasellReturn> FasellReturns { get; set; }

    public virtual DbSet<FasellReturnContact> FasellReturnContacts { get; set; }

    public virtual DbSet<FasellReturnDiscount> FasellReturnDiscounts { get; set; }

    public virtual DbSet<FasellReturnHistory> FasellReturnHistorys { get; set; }

    public virtual DbSet<FasellReturnItem> FasellReturnItems { get; set; }

    public virtual DbSet<FasellReturnItemDiscount> FasellReturnItemDiscounts { get; set; }

    public virtual DbSet<FasellReturnItemReceiptItem> FasellReturnItemReceiptItems { get; set; }

    public virtual DbSet<FasellReturnReceipt> FasellReturnReceipts { get; set; }

    public virtual DbSet<FashipmentContact> FashipmentContacts { get; set; }

    public virtual DbSet<FashipmentDiscount> FashipmentDiscounts { get; set; }

    public virtual DbSet<FashipmentHistory> FashipmentHistorys { get; set; }

    public virtual DbSet<FashipmentInvoice> FashipmentInvoices { get; set; }

    public virtual DbSet<FashipmentItemDiscount> FashipmentItemDiscounts { get; set; }

    public virtual DbSet<FashipmentItemInvoiceItem> FashipmentItemInvoiceItems { get; set; }

    public virtual DbSet<FashipmentItemReceiptItem> FashipmentItemReceiptItems { get; set; }

    public virtual DbSet<Fatransfer> Fatransfers { get; set; }

    public virtual DbSet<FatransferHistory> FatransferHistorys { get; set; }

    public virtual DbSet<FatransferStockInItem> FatransferStockInItems { get; set; }

    public virtual DbSet<FatransferStockOutItem> FatransferStockOutItems { get; set; }

    public virtual DbSet<FatransferStockOutItemTransferStockInItem> FatransferStockOutItemTransferStockInItems { get; set; }

    public virtual DbSet<GeaccountingFormula> GeaccountingFormulas { get; set; }

    public virtual DbSet<GeaccountingFormulaItem> GeaccountingFormulaItems { get; set; }

    public virtual DbSet<Gebank> Gebanks { get; set; }

    public virtual DbSet<Gecontainer> Gecontainers { get; set; }

    public virtual DbSet<Gecorrespondence> Gecorrespondences { get; set; }

    public virtual DbSet<Gecountry> Gecountrys { get; set; }

    public virtual DbSet<Gecurrency> Gecurrencies { get; set; }

    public virtual DbSet<GecurrencyExchangeRate> GecurrencyExchangeRates { get; set; }

    public virtual DbSet<GecurrencyHistory> GecurrencyHistories { get; set; }

    public virtual DbSet<Gedistrict> Gedistricts { get; set; }

    public virtual DbSet<GefiscalPeriod> GefiscalPeriods { get; set; }

    public virtual DbSet<GefiscalYear> GefiscalYears { get; set; }

    public virtual DbSet<GegenerateProductNoConfig> GegenerateProductNoConfigs { get; set; }

    public virtual DbSet<GehistoryDetail> GehistoryDetails { get; set; }

    public virtual DbSet<GehistoryDetailOfProductBranchPrice> GehistoryDetailOfProductBranchPrices { get; set; }

    public virtual DbSet<Gelanguage> Gelanguages { get; set; }

    public virtual DbSet<GelanguageText> GelanguageTexts { get; set; }

    public virtual DbSet<Gelocation> Gelocations { get; set; }

    public virtual DbSet<GelookupTable> GelookupTables { get; set; }

    public virtual DbSet<Gemessage> Gemessages { get; set; }

    public virtual DbSet<Genationality> Genationalitys { get; set; }

    public virtual DbSet<Genumbering> Genumberings { get; set; }

    public virtual DbSet<Geobject> Geobjects { get; set; }

    public virtual DbSet<GeobjectHistory> GeobjectHistories { get; set; }

    public virtual DbSet<GepackageNumeringConfig> GepackageNumeringConfigs { get; set; }

    public virtual DbSet<GepaymentTerm> GepaymentTerms { get; set; }

    public virtual DbSet<GepaymentTermItem> GepaymentTermItems { get; set; }

    public virtual DbSet<Geregion> Geregions { get; set; }

    public virtual DbSet<Gereligion> Gereligions { get; set; }

    public virtual DbSet<GeshippingMethod> GeshippingMethods { get; set; }

    public virtual DbSet<GestateProvince> GestateProvinces { get; set; }

    public virtual DbSet<GestockNumbering> GestockNumberings { get; set; }

    public virtual DbSet<Gestreet> Gestreets { get; set; }

    public virtual DbSet<GetableHistory> GetableHistorys { get; set; }

    public virtual DbSet<Getemp> Getemps { get; set; }

    public virtual DbSet<Getemplate> Getemplates { get; set; }

    public virtual DbSet<Geterminal> Geterminals { get; set; }

    public virtual DbSet<Getext> Getexts { get; set; }

    public virtual DbSet<GeunitCost> GeunitCosts { get; set; }

    public virtual DbSet<GeunitCostContainer> GeunitCostContainers { get; set; }

    public virtual DbSet<GeuserAudit> GeuserAudits { get; set; }

    public virtual DbSet<GeuserMessagesHidden> GeuserMessagesHiddens { get; set; }

    public virtual DbSet<Gevat> Gevats { get; set; }

    public virtual DbSet<Gevatregion> Gevatregions { get; set; }

    public virtual DbSet<Geversion> Geversions { get; set; }

    public virtual DbSet<Geward> Gewards { get; set; }

    public virtual DbSet<Glaccount> Glaccounts { get; set; }

    public virtual DbSet<Hash> Hashes { get; set; }

    public virtual DbSet<HraccountingStore> HraccountingStores { get; set; }

    public virtual DbSet<HradjustSocialInsurance> HradjustSocialInsurances { get; set; }

    public virtual DbSet<HradvanceRefund> HradvanceRefunds { get; set; }

    public virtual DbSet<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; }

    public virtual DbSet<HradvanceRefundItemRequest> HradvanceRefundItemRequests { get; set; }

    public virtual DbSet<HradvanceRefundTemplate> HradvanceRefundTemplates { get; set; }

    public virtual DbSet<HradvanceRequest> HradvanceRequests { get; set; }

    public virtual DbSet<HradvanceRequestItem> HradvanceRequestItems { get; set; }

    public virtual DbSet<HradvanceRequestItemLoanDetail> HradvanceRequestItemLoanDetails { get; set; }

    public virtual DbSet<HradvanceRequestPaymentTime> HradvanceRequestPaymentTimes { get; set; }

    public virtual DbSet<Hrallowance> Hrallowances { get; set; }

    public virtual DbSet<HrallowanceConfig> HrallowanceConfigs { get; set; }

    public virtual DbSet<HrallowanceItem> HrallowanceItems { get; set; }

    public virtual DbSet<HrallowanceManageConfig> HrallowanceManageConfigs { get; set; }

    public virtual DbSet<HrallowanceManageConfigHistory> HrallowanceManageConfigHistorys { get; set; }

    public virtual DbSet<HrannualLeaveDayConfig> HrannualLeaveDayConfigs { get; set; }

    public virtual DbSet<HrapproveEditEmployee> HrapproveEditEmployees { get; set; }

    public virtual DbSet<HrapproveLeaveDay> HrapproveLeaveDays { get; set; }

    public virtual DbSet<HrarrangementShift> HrarrangementShifts { get; set; }

    public virtual DbSet<HrarrangementShiftEntry> HrarrangementShiftEntrys { get; set; }

    public virtual DbSet<HratmcardManage> HratmcardManages { get; set; }

    public virtual DbSet<HratmcardManageConfig> HratmcardManageConfigs { get; set; }

    public virtual DbSet<HratmcardPayroll> HratmcardPayrolls { get; set; }

    public virtual DbSet<Hrauthorization> Hrauthorizations { get; set; }

    public virtual DbSet<HrbillingIntimate> HrbillingIntimates { get; set; }

    public virtual DbSet<HrbonusCheck> HrbonusChecks { get; set; }

    public virtual DbSet<HrbonusLevel> HrbonusLevels { get; set; }

    public virtual DbSet<HrbonusSale> HrbonusSales { get; set; }

    public virtual DbSet<HrbonusSaleItem> HrbonusSaleItems { get; set; }

    public virtual DbSet<HrbreakTime> HrbreakTimes { get; set; }

    public virtual DbSet<HrbugManagement> HrbugManagements { get; set; }

    public virtual DbSet<HrbugManagementTemplate> HrbugManagementTemplates { get; set; }

    public virtual DbSet<Hrcalendar> Hrcalendars { get; set; }

    public virtual DbSet<HrcalendarEntry> HrcalendarEntrys { get; set; }

    public virtual DbSet<Hrcandidate> Hrcandidates { get; set; }

    public virtual DbSet<HrcandidateCertificate> HrcandidateCertificates { get; set; }

    public virtual DbSet<HrcandidateTemplate> HrcandidateTemplates { get; set; }

    public virtual DbSet<HrclassSchedule> HrclassSchedules { get; set; }

    public virtual DbSet<HrconfigRank> HrconfigRanks { get; set; }

    public virtual DbSet<HrconfigRewardBestSeller> HrconfigRewardBestSellers { get; set; }

    public virtual DbSet<HrconfigSalesFormulaPayroll> HrconfigSalesFormulaPayrolls { get; set; }

    public virtual DbSet<HrconfigSalesFormulaPayrollItem> HrconfigSalesFormulaPayrollItems { get; set; }

    public virtual DbSet<HrconfigSalesTarget> HrconfigSalesTargets { get; set; }

    public virtual DbSet<HrconfigSalesTargetItem> HrconfigSalesTargetItems { get; set; }

    public virtual DbSet<HrconfigScale> HrconfigScales { get; set; }

    public virtual DbSet<HrconfigureBonusLevel> HrconfigureBonusLevels { get; set; }

    public virtual DbSet<HrconfigureRewardLevel> HrconfigureRewardLevels { get; set; }

    public virtual DbSet<HrconfigureRewardTime> HrconfigureRewardTimes { get; set; }

    public virtual DbSet<HrcostTypeConfig> HrcostTypeConfigs { get; set; }

    public virtual DbSet<Hrdepartment> Hrdepartments { get; set; }

    public virtual DbSet<HrdepartmentGroupCapacity> HrdepartmentGroupCapacitys { get; set; }

    public virtual DbSet<HrdepartmentGroupOperation> HrdepartmentGroupOperations { get; set; }

    public virtual DbSet<HrdepartmentRoom> HrdepartmentRooms { get; set; }

    public virtual DbSet<HrdepartmentRoomGroup> HrdepartmentRoomGroups { get; set; }

    public virtual DbSet<HrdepartmentRoomGroupItem> HrdepartmentRoomGroupItems { get; set; }

    public virtual DbSet<HrdepartmentRoomGroupTeam> HrdepartmentRoomGroupTeams { get; set; }

    public virtual DbSet<HrdepartmentRoomGroupTeamItem> HrdepartmentRoomGroupTeamItems { get; set; }

    public virtual DbSet<HrdepartmentRoomLeaveDayConfig> HrdepartmentRoomLeaveDayConfigs { get; set; }

    public virtual DbSet<HrdesignBonuss> HrdesignBonusses { get; set; }

    public virtual DbSet<Hrdiscipline> Hrdisciplines { get; set; }

    public virtual DbSet<Hrdormitory> Hrdormitorys { get; set; }

    public virtual DbSet<HrdormitoryCost> HrdormitoryCosts { get; set; }

    public virtual DbSet<HrdormitoryCostItem> HrdormitoryCostItems { get; set; }

    public virtual DbSet<HrdormitoryItem> HrdormitoryItems { get; set; }

    public virtual DbSet<Hremployee> Hremployees { get; set; }

    public virtual DbSet<HremployeeAbsence> HremployeeAbsences { get; set; }

    public virtual DbSet<HremployeeAdjustSocialInsurance> HremployeeAdjustSocialInsurances { get; set; }

    public virtual DbSet<HremployeeAllowance> HremployeeAllowances { get; set; }

    public virtual DbSet<HremployeeArrangementShift> HremployeeArrangementShifts { get; set; }

    public virtual DbSet<HremployeeArrearSocialInsurance> HremployeeArrearSocialInsurances { get; set; }

    public virtual DbSet<HremployeeAtmcardManage> HremployeeAtmcardManages { get; set; }

    public virtual DbSet<HremployeeAtmcardPayroll> HremployeeAtmcardPayrolls { get; set; }

    public virtual DbSet<HremployeeCertificate> HremployeeCertificates { get; set; }

    public virtual DbSet<HremployeeComission> HremployeeComissions { get; set; }

    public virtual DbSet<HremployeeComissionItem> HremployeeComissionItems { get; set; }

    public virtual DbSet<HremployeeCommissionBranch> HremployeeCommissionBranchs { get; set; }

    public virtual DbSet<HremployeeContact> HremployeeContacts { get; set; }

    public virtual DbSet<HremployeeContactPerson> HremployeeContactPersons { get; set; }

    public virtual DbSet<HremployeeContract> HremployeeContracts { get; set; }

    public virtual DbSet<HremployeeDiscipline> HremployeeDisciplines { get; set; }

    public virtual DbSet<HremployeeEvaluation> HremployeeEvaluations { get; set; }

    public virtual DbSet<HremployeeGroup> HremployeeGroups { get; set; }

    public virtual DbSet<HremployeeGroupAppStaff> HremployeeGroupAppStaffs { get; set; }

    public virtual DbSet<HremployeeGroupOrderWeb> HremployeeGroupOrderWebs { get; set; }

    public virtual DbSet<HremployeeIdentityCardTemplate> HremployeeIdentityCardTemplates { get; set; }

    public virtual DbSet<HremployeeKpievaluationItem> HremployeeKpievaluationItems { get; set; }

    public virtual DbSet<HremployeeKpiregistrationItem> HremployeeKpiregistrationItems { get; set; }

    public virtual DbSet<HremployeeLreg> HremployeeLregs { get; set; }

    public virtual DbSet<HremployeeOt> HremployeeOts { get; set; }

    public virtual DbSet<HremployeeOtfactor> HremployeeOtfactors { get; set; }

    public virtual DbSet<HremployeePause> HremployeePauses { get; set; }

    public virtual DbSet<HremployeePayRoll> HremployeePayRolls { get; set; }

    public virtual DbSet<HremployeePayRollAudit> HremployeePayRollAudits { get; set; }

    public virtual DbSet<HremployeePayRollAuditDetail> HremployeePayRollAuditDetails { get; set; }

    public virtual DbSet<HremployeePayRollConfig> HremployeePayRollConfigs { get; set; }

    public virtual DbSet<HremployeePayrollDetail> HremployeePayrollDetails { get; set; }

    public virtual DbSet<HremployeePayrollFormula> HremployeePayrollFormulas { get; set; }

    public virtual DbSet<HremployeePayrollFormulaItem> HremployeePayrollFormulaItems { get; set; }

    public virtual DbSet<HremployeePieceWage> HremployeePieceWages { get; set; }

    public virtual DbSet<HremployeePieceWageItem> HremployeePieceWageItems { get; set; }

    public virtual DbSet<HremployeePieceWork> HremployeePieceWorks { get; set; }

    public virtual DbSet<HremployeeReward> HremployeeRewards { get; set; }

    public virtual DbSet<HremployeeSalaryConfig> HremployeeSalaryConfigs { get; set; }

    public virtual DbSet<HremployeeSchedule> HremployeeSchedules { get; set; }

    public virtual DbSet<HremployeeSocialInsuranceChange> HremployeeSocialInsuranceChanges { get; set; }

    public virtual DbSet<HremployeeTimeSheet> HremployeeTimeSheets { get; set; }

    public virtual DbSet<HremployeeTimeSheetAudit> HremployeeTimeSheetAudits { get; set; }

    public virtual DbSet<HremployeeTimeSheetAuditOtdetail> HremployeeTimeSheetAuditOtdetails { get; set; }

    public virtual DbSet<HremployeeTimeSheetOtdetail> HremployeeTimeSheetOtdetails { get; set; }

    public virtual DbSet<HremployeeTranfer> HremployeeTranfers { get; set; }

    public virtual DbSet<HremployeeTransmit> HremployeeTransmits { get; set; }

    public virtual DbSet<HremployeeTransmitItem> HremployeeTransmitItems { get; set; }

    public virtual DbSet<HremployeeWorkSchedule> HremployeeWorkSchedules { get; set; }

    public virtual DbSet<HremployeeWorkScheduleItem> HremployeeWorkScheduleItems { get; set; }

    public virtual DbSet<HremployeeWorkingShift> HremployeeWorkingShifts { get; set; }

    public virtual DbSet<HremployeesBackup20190731> HremployeesBackup20190731s { get; set; }

    public virtual DbSet<HrerrorType> HrerrorTypes { get; set; }

    public virtual DbSet<Hrevaluation> Hrevaluations { get; set; }

    public virtual DbSet<HrevaluationDetail> HrevaluationDetails { get; set; }

    public virtual DbSet<HrevaluationQuestion> HrevaluationQuestions { get; set; }

    public virtual DbSet<HrevaluationRank> HrevaluationRanks { get; set; }

    public virtual DbSet<HrevaluationStandard> HrevaluationStandards { get; set; }

    public virtual DbSet<HrevaluationTemplate> HrevaluationTemplates { get; set; }

    public virtual DbSet<HrformAllowance> HrformAllowances { get; set; }

    public virtual DbSet<Hrgroup> Hrgroups { get; set; }

    public virtual DbSet<Hrkpi> Hrkpis { get; set; }

    public virtual DbSet<Hrkpievaluation> Hrkpievaluations { get; set; }

    public virtual DbSet<HrkpievaluationItem> HrkpievaluationItems { get; set; }

    public virtual DbSet<HrkpievaluationItemTarget> HrkpievaluationItemTargets { get; set; }

    public virtual DbSet<Hrkpiform> Hrkpiforms { get; set; }

    public virtual DbSet<HrkpiformItem> HrkpiformItems { get; set; }

    public virtual DbSet<Hrkpiregistration> Hrkpiregistrations { get; set; }

    public virtual DbSet<HrkpiregistrationItem> HrkpiregistrationItems { get; set; }

    public virtual DbSet<HrkpiregistrationItemTarget> HrkpiregistrationItemTargets { get; set; }

    public virtual DbSet<HrlabouringConfig> HrlabouringConfigs { get; set; }

    public virtual DbSet<HrlabouringConfigItem> HrlabouringConfigItems { get; set; }

    public virtual DbSet<HrleaveApplication> HrleaveApplications { get; set; }

    public virtual DbSet<HrleaveDay> HrleaveDays { get; set; }

    public virtual DbSet<Hrlevel> Hrlevels { get; set; }

    public virtual DbSet<HrlevelDetail> HrlevelDetails { get; set; }

    public virtual DbSet<HrlevelDutiesResponsibilitiesOther> HrlevelDutiesResponsibilitiesOthers { get; set; }

    public virtual DbSet<HrlevelDutiesResponsibilitiess> HrlevelDutiesResponsibilitiesses { get; set; }

    public virtual DbSet<HrlevelExternalCompanyRelationship> HrlevelExternalCompanyRelationships { get; set; }

    public virtual DbSet<HrlevelExternalDepartmentRelationship> HrlevelExternalDepartmentRelationships { get; set; }

    public virtual DbSet<HrlevelInternalRelationship> HrlevelInternalRelationships { get; set; }

    public virtual DbSet<HrlevelJurisdiction> HrlevelJurisdictions { get; set; }

    public virtual DbSet<HrlevelWorkSummary> HrlevelWorkSummarys { get; set; }

    public virtual DbSet<HrmachineTimeKeeper> HrmachineTimeKeepers { get; set; }

    public virtual DbSet<Hrmail> Hrmails { get; set; }

    public virtual DbSet<HrmailAttachment> HrmailAttachments { get; set; }

    public virtual DbSet<HrmanufactureTimeSheet> HrmanufactureTimeSheets { get; set; }

    public virtual DbSet<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; }

    public virtual DbSet<Hrotfactor> Hrotfactors { get; set; }

    public virtual DbSet<HrotherLeaveDayConfig> HrotherLeaveDayConfigs { get; set; }

    public virtual DbSet<HroverTime> HroverTimes { get; set; }

    public virtual DbSet<HrpayRoll> HrpayRolls { get; set; }

    public virtual DbSet<HrpayRollAudit> HrpayRollAudits { get; set; }

    public virtual DbSet<HrpayRollConfig> HrpayRollConfigs { get; set; }

    public virtual DbSet<HrpercentageRetained> HrpercentageRetaineds { get; set; }

    public virtual DbSet<HrproductPieceWage> HrproductPieceWages { get; set; }

    public virtual DbSet<HrquarterReward> HrquarterRewards { get; set; }

    public virtual DbSet<HrrecruitmentNeed> HrrecruitmentNeeds { get; set; }

    public virtual DbSet<HrrecruitmentNeedItem> HrrecruitmentNeedItems { get; set; }

    public virtual DbSet<HrrecruitmentPlan> HrrecruitmentPlans { get; set; }

    public virtual DbSet<HrrecruitmentPlanItem> HrrecruitmentPlanItems { get; set; }

    public virtual DbSet<HrregisterDormitory> HrregisterDormitorys { get; set; }

    public virtual DbSet<HrregisterDormitoryItem> HrregisterDormitoryItems { get; set; }

    public virtual DbSet<Hrrelationship> Hrrelationships { get; set; }

    public virtual DbSet<HrrequestEditEmployee> HrrequestEditEmployees { get; set; }

    public virtual DbSet<HrrequestLeaveDay> HrrequestLeaveDays { get; set; }

    public virtual DbSet<Hrreward> Hrrewards { get; set; }

    public virtual DbSet<HrsalaryEvaluation> HrsalaryEvaluations { get; set; }

    public virtual DbSet<Hrschedule> Hrschedules { get; set; }

    public virtual DbSet<HrseniorityLeaveDayConfig> HrseniorityLeaveDayConfigs { get; set; }

    public virtual DbSet<HrsocialInsuranceDeclaration> HrsocialInsuranceDeclarations { get; set; }

    public virtual DbSet<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; }

    public virtual DbSet<HrsplitRatio> HrsplitRatios { get; set; }

    public virtual DbSet<HrstandardQuestion> HrstandardQuestions { get; set; }

    public virtual DbSet<HrtemplateRank> HrtemplateRanks { get; set; }

    public virtual DbSet<HrtemplateStandard> HrtemplateStandards { get; set; }

    public virtual DbSet<HrtimeKeeper> HrtimeKeepers { get; set; }

    public virtual DbSet<HrtimeKeeperComplete> HrtimeKeeperCompletes { get; set; }

    public virtual DbSet<HrtimeKeeperHistory> HrtimeKeeperHistorys { get; set; }

    public virtual DbSet<HrtimeKeeperHistoryDetail> HrtimeKeeperHistoryDetails { get; set; }

    public virtual DbSet<HrtimeReward> HrtimeRewards { get; set; }

    public virtual DbSet<HrtimeSheet> HrtimeSheets { get; set; }

    public virtual DbSet<HrtimeSheetAudit> HrtimeSheetAudits { get; set; }

    public virtual DbSet<HrtimeSheetAuditEntry> HrtimeSheetAuditEntrys { get; set; }

    public virtual DbSet<HrtimeSheetEntry> HrtimeSheetEntrys { get; set; }

    public virtual DbSet<HrtimeSheetLevel> HrtimeSheetLevels { get; set; }

    public virtual DbSet<HrtimeSheetParam> HrtimeSheetParams { get; set; }

    public virtual DbSet<HrtimeSheetScale> HrtimeSheetScales { get; set; }

    public virtual DbSet<HrtimesheetConfig> HrtimesheetConfigs { get; set; }

    public virtual DbSet<HrtimesheetEmployeeLate> HrtimesheetEmployeeLates { get; set; }

    public virtual DbSet<HrtimesheetEmployeeLateConfig> HrtimesheetEmployeeLateConfigs { get; set; }

    public virtual DbSet<HrtimesheetGroup> HrtimesheetGroups { get; set; }

    public virtual DbSet<HrtrainningClass> HrtrainningClasses { get; set; }

    public virtual DbSet<HrtrainningCourse> HrtrainningCourses { get; set; }

    public virtual DbSet<HrtrainningEmployee> HrtrainningEmployees { get; set; }

    public virtual DbSet<HrtrainningSchedule> HrtrainningSchedules { get; set; }

    public virtual DbSet<HrworkingFeeConfig> HrworkingFeeConfigs { get; set; }

    public virtual DbSet<HrworkingShift> HrworkingShifts { get; set; }

    public virtual DbSet<Icadjustment> Icadjustments { get; set; }

    public virtual DbSet<IcadjustmentItem> IcadjustmentItems { get; set; }

    public virtual DbSet<IcassembleProduct> IcassembleProducts { get; set; }

    public virtual DbSet<IcassembleProductDetail> IcassembleProductDetails { get; set; }

    public virtual DbSet<IcaverageCost> IcaverageCosts { get; set; }

    public virtual DbSet<Icbarcode> Icbarcodes { get; set; }

    public virtual DbSet<IcbarcodeItem> IcbarcodeItems { get; set; }

    public virtual DbSet<IcbravoProduct> IcbravoProducts { get; set; }

    public virtual DbSet<IccalculatedPackageVolumnConfig> IccalculatedPackageVolumnConfigs { get; set; }

    public virtual DbSet<Iccollection> Iccollections { get; set; }

    public virtual DbSet<IccollectionItem> IccollectionItems { get; set; }

    public virtual DbSet<IccommodityGridControlTypeMapping> IccommodityGridControlTypeMappings { get; set; }

    public virtual DbSet<IccommodityProductTypeMapping> IccommodityProductTypeMappings { get; set; }

    public virtual DbSet<IcconfigAccordWoodType> IcconfigAccordWoodTypes { get; set; }

    public virtual DbSet<IcconversionProposal> IcconversionProposals { get; set; }

    public virtual DbSet<IcconversionProposalItem> IcconversionProposalItems { get; set; }

    public virtual DbSet<Icdepartment> Icdepartments { get; set; }

    public virtual DbSet<IcdepartmentAttribute> IcdepartmentAttributes { get; set; }

    public virtual DbSet<IcdepartmentAttributeValue> IcdepartmentAttributeValues { get; set; }

    public virtual DbSet<IcdepartmentFormat> IcdepartmentFormats { get; set; }

    public virtual DbSet<IcdisassembleProduct> IcdisassembleProducts { get; set; }

    public virtual DbSet<IcdisassembleProductDetail> IcdisassembleProductDetails { get; set; }

    public virtual DbSet<IcfeeConfig> IcfeeConfigs { get; set; }

    public virtual DbSet<Ichistory> Ichistorys { get; set; }

    public virtual DbSet<IchistoryDetail> IchistoryDetails { get; set; }

    public virtual DbSet<IcimportAndExportReason> IcimportAndExportReasons { get; set; }

    public virtual DbSet<IcimportEquipment> IcimportEquipments { get; set; }

    public virtual DbSet<IcimportReceiptShipment> IcimportReceiptShipments { get; set; }

    public virtual DbSet<IcimportStockMinMax> IcimportStockMinMaxs { get; set; }

    public virtual DbSet<IcinitializedInventoryStock> IcinitializedInventoryStocks { get; set; }

    public virtual DbSet<IcinvAdjustment> IcinvAdjustments { get; set; }

    public virtual DbSet<IcinvBalance> IcinvBalances { get; set; }

    public virtual DbSet<IcinventoryItemPackage> IcinventoryItemPackages { get; set; }

    public virtual DbSet<IcinventoryPackage> IcinventoryPackages { get; set; }

    public virtual DbSet<IcinventoryPermission> IcinventoryPermissions { get; set; }

    public virtual DbSet<IcinventoryStock> IcinventoryStocks { get; set; }

    public virtual DbSet<IcinventoryStockCount> IcinventoryStockCounts { get; set; }

    public virtual DbSet<IcinventoryStockCountItem> IcinventoryStockCountItems { get; set; }

    public virtual DbSet<IcinventoryStockSerial> IcinventoryStockSerials { get; set; }

    public virtual DbSet<IcinventoryStockSlot> IcinventoryStockSlots { get; set; }

    public virtual DbSet<IcinventoryStockSlotSeries> IcinventoryStockSlotSeries { get; set; }

    public virtual DbSet<IclengthGroup> IclengthGroups { get; set; }

    public virtual DbSet<Icmachine> Icmachines { get; set; }

    public virtual DbSet<IcmachineGroup> IcmachineGroups { get; set; }

    public virtual DbSet<IcmaterialConfig> IcmaterialConfigs { get; set; }

    public virtual DbSet<IcmeasureUnit> IcmeasureUnits { get; set; }

    public virtual DbSet<Icmodel> Icmodels { get; set; }

    public virtual DbSet<IcmodelDetail> IcmodelDetails { get; set; }

    public virtual DbSet<Icpackage> Icpackages { get; set; }

    public virtual DbSet<IcpackageNumber> IcpackageNumbers { get; set; }

    public virtual DbSet<IcpackageProduct> IcpackageProducts { get; set; }

    public virtual DbSet<IcpackagingNormItem> IcpackagingNormItems { get; set; }

    public virtual DbSet<IcperimeterGroup> IcperimeterGroups { get; set; }

    public virtual DbSet<IcpriceAdjustment> IcpriceAdjustments { get; set; }

    public virtual DbSet<IcpriceAdjustmentItem> IcpriceAdjustmentItems { get; set; }

    public virtual DbSet<IcpriceCalculationMethod> IcpriceCalculationMethods { get; set; }

    public virtual DbSet<Icproduct> Icproducts { get; set; }

    public virtual DbSet<IcproductAlternative> IcproductAlternatives { get; set; }

    public virtual DbSet<IcproductApplyPrice> IcproductApplyPrices { get; set; }

    public virtual DbSet<IcproductApplyPriceItem> IcproductApplyPriceItems { get; set; }

    public virtual DbSet<IcproductAttribute> IcproductAttributes { get; set; }

    public virtual DbSet<IcproductAttributeItem> IcproductAttributeItems { get; set; }

    public virtual DbSet<IcproductAttributeWood> IcproductAttributeWoods { get; set; }

    public virtual DbSet<IcproductBranch> IcproductBranchs { get; set; }

    public virtual DbSet<IcproductBranchPrice> IcproductBranchPrices { get; set; }

    public virtual DbSet<IcproductColorSchema> IcproductColorSchemas { get; set; }

    public virtual DbSet<IcproductColorSchemaItem> IcproductColorSchemaItems { get; set; }

    public virtual DbSet<IcproductColorSchemaItemName> IcproductColorSchemaItemNames { get; set; }

    public virtual DbSet<IcproductComponent> IcproductComponents { get; set; }

    public virtual DbSet<IcproductConfigRate> IcproductConfigRates { get; set; }

    public virtual DbSet<IcproductContainerDetail> IcproductContainerDetails { get; set; }

    public virtual DbSet<IcproductConversion> IcproductConversions { get; set; }

    public virtual DbSet<IcproductConversionItem> IcproductConversionItems { get; set; }

    public virtual DbSet<IcproductCriteria> IcproductCriterias { get; set; }

    public virtual DbSet<IcproductCriteriaItem> IcproductCriteriaItems { get; set; }

    public virtual DbSet<IcproductCustomer> IcproductCustomers { get; set; }

    public virtual DbSet<IcproductCustomerPrice> IcproductCustomerPrices { get; set; }

    public virtual DbSet<IcproductDesc> IcproductDescs { get; set; }

    public virtual DbSet<IcproductDetail> IcproductDetails { get; set; }

    public virtual DbSet<IcproductDiscount> IcproductDiscounts { get; set; }

    public virtual DbSet<IcproductFile> IcproductFiles { get; set; }

    public virtual DbSet<IcproductFormulaPriceConfig> IcproductFormulaPriceConfigs { get; set; }

    public virtual DbSet<IcproductGroup> IcproductGroups { get; set; }

    public virtual DbSet<IcproductGroupHeight> IcproductGroupHeights { get; set; }

    public virtual DbSet<IcproductGroupMeasureUnit> IcproductGroupMeasureUnits { get; set; }

    public virtual DbSet<IcproductGroupRelation> IcproductGroupRelations { get; set; }

    public virtual DbSet<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; }

    public virtual DbSet<IcproductItem> IcproductItems { get; set; }

    public virtual DbSet<IcproductItemDetail> IcproductItemDetails { get; set; }

    public virtual DbSet<IcproductItemMaterial> IcproductItemMaterials { get; set; }

    public virtual DbSet<IcproductItemMaterialLog> IcproductItemMaterialLogs { get; set; }

    public virtual DbSet<IcproductItemProcessLog> IcproductItemProcessLogs { get; set; }

    public virtual DbSet<IcproductItemProcesss> IcproductItemProcessses { get; set; }

    public virtual DbSet<IcproductMachine> IcproductMachines { get; set; }

    public virtual DbSet<IcproductMeasureUnit> IcproductMeasureUnits { get; set; }

    public virtual DbSet<IcproductOperation> IcproductOperations { get; set; }

    public virtual DbSet<IcproductOutsourcing> IcproductOutsourcings { get; set; }

    public virtual DbSet<IcproductPackage> IcproductPackages { get; set; }

    public virtual DbSet<IcproductPackageBackup> IcproductPackageBackups { get; set; }

    public virtual DbSet<IcproductPackageItem> IcproductPackageItems { get; set; }

    public virtual DbSet<IcproductPackageItemBackup> IcproductPackageItemBackups { get; set; }

    public virtual DbSet<IcproductPackageItemDetail> IcproductPackageItemDetails { get; set; }

    public virtual DbSet<IcproductPackingDetail> IcproductPackingDetails { get; set; }

    public virtual DbSet<IcproductPrice> IcproductPrices { get; set; }

    public virtual DbSet<IcproductProductAttribute> IcproductProductAttributes { get; set; }

    public virtual DbSet<IcproductProfile> IcproductProfiles { get; set; }

    public virtual DbSet<IcproductSemi> IcproductSemis { get; set; }

    public virtual DbSet<IcproductSerialNumber> IcproductSerialNumbers { get; set; }

    public virtual DbSet<IcproductSeries> IcproductSeries { get; set; }

    public virtual DbSet<IcproductSizeSchema> IcproductSizeSchemas { get; set; }

    public virtual DbSet<IcproductSizeSchemaItem> IcproductSizeSchemaItems { get; set; }

    public virtual DbSet<IcproductSizeSchemaItemName> IcproductSizeSchemaItemNames { get; set; }

    public virtual DbSet<IcproductSub> IcproductSubs { get; set; }

    public virtual DbSet<IcproductSubplement> IcproductSubplements { get; set; }

    public virtual DbSet<IcproductSupplier> IcproductSuppliers { get; set; }

    public virtual DbSet<IcproductTask> IcproductTasks { get; set; }

    public virtual DbSet<IcproductTemplate> IcproductTemplates { get; set; }

    public virtual DbSet<IcproductTemplateConfig> IcproductTemplateConfigs { get; set; }

    public virtual DbSet<IcproductTemplateItem> IcproductTemplateItems { get; set; }

    public virtual DbSet<IcproductTolenrance> IcproductTolenrances { get; set; }

    public virtual DbSet<IcproductTypeAccountConfig> IcproductTypeAccountConfigs { get; set; }

    public virtual DbSet<IcproductTypeMapping> IcproductTypeMappings { get; set; }

    public virtual DbSet<IcproductUnit> IcproductUnits { get; set; }

    public virtual DbSet<IcproductWorkGroup> IcproductWorkGroups { get; set; }

    public virtual DbSet<IcproductWorkItem> IcproductWorkItems { get; set; }

    public virtual DbSet<Icpromotion> Icpromotions { get; set; }

    public virtual DbSet<IcpromotionItem> IcpromotionItems { get; set; }

    public virtual DbSet<IcpromotionItemDetail> IcpromotionItemDetails { get; set; }

    public virtual DbSet<Icreceipt> Icreceipts { get; set; }

    public virtual DbSet<IcreceiptCd> IcreceiptCds { get; set; }

    public virtual DbSet<IcreceiptCditem> IcreceiptCditems { get; set; }

    public virtual DbSet<IcreceiptComponentItem> IcreceiptComponentItems { get; set; }

    public virtual DbSet<IcreceiptItem> IcreceiptItems { get; set; }

    public virtual DbSet<IcreceiptItemCont> IcreceiptItemConts { get; set; }

    public virtual DbSet<IcreceiptItemContFee> IcreceiptItemContFees { get; set; }

    public virtual DbSet<IcreceiptItemError> IcreceiptItemErrors { get; set; }

    public virtual DbSet<IcreceiptItemLog> IcreceiptItemLogs { get; set; }

    public virtual DbSet<IcreceiptItemPackage> IcreceiptItemPackages { get; set; }

    public virtual DbSet<IcreceiptPackageItem> IcreceiptPackageItems { get; set; }

    public virtual DbSet<IcreceiptPackageItemDetail> IcreceiptPackageItemDetails { get; set; }

    public virtual DbSet<IcreturnShipping> IcreturnShippings { get; set; }

    public virtual DbSet<IcreturnShippingItem> IcreturnShippingItems { get; set; }

    public virtual DbSet<Icshipment> Icshipments { get; set; }

    public virtual DbSet<IcshipmentItem> IcshipmentItems { get; set; }

    public virtual DbSet<IcshipmentItemComponent> IcshipmentItemComponents { get; set; }

    public virtual DbSet<IcshipmentItemSaleOrderItem> IcshipmentItemSaleOrderItems { get; set; }

    public virtual DbSet<IcshipmentPackage> IcshipmentPackages { get; set; }

    public virtual DbSet<IcshipmentPackageItem> IcshipmentPackageItems { get; set; }

    public virtual DbSet<IcshipmentPackageItemDetail> IcshipmentPackageItemDetails { get; set; }

    public virtual DbSet<IcshipmentPlan> IcshipmentPlans { get; set; }

    public virtual DbSet<IcshipmentProposal> IcshipmentProposals { get; set; }

    public virtual DbSet<IcshipmentProposalItem> IcshipmentProposalItems { get; set; }

    public virtual DbSet<IcshipmentSaleOrder> IcshipmentSaleOrders { get; set; }

    public virtual DbSet<Icstock> Icstocks { get; set; }

    public virtual DbSet<IcstockConfigRate> IcstockConfigRates { get; set; }

    public virtual DbSet<IcstockSlot> IcstockSlots { get; set; }

    public virtual DbSet<Ictask> Ictasks { get; set; }

    public virtual DbSet<Ictransaction> Ictransactions { get; set; }

    public virtual DbSet<Ictransfer> Ictransfers { get; set; }

    public virtual DbSet<IctransferItem> IctransferItems { get; set; }

    public virtual DbSet<IctransferItemPackage> IctransferItemPackages { get; set; }

    public virtual DbSet<IctransferLog> IctransferLogs { get; set; }

    public virtual DbSet<IctransferLogItem> IctransferLogItems { get; set; }

    public virtual DbSet<IctransferProposal> IctransferProposals { get; set; }

    public virtual DbSet<IctransferProposalItem> IctransferProposalItems { get; set; }

    public virtual DbSet<IcvitualTransaction> IcvitualTransactions { get; set; }

    public virtual DbSet<IcwidthGroup> IcwidthGroups { get; set; }

    public virtual DbSet<ImpCcdc2> ImpCcdc2s { get; set; }

    public virtual DbSet<ImpCongDoan> ImpCongDoans { get; set; }

    public virtual DbSet<ImpDanhMucTaiKhoan> ImpDanhMucTaiKhoans { get; set; }

    public virtual DbSet<ImpDichVu> ImpDichVus { get; set; }

    public virtual DbSet<ImpHardware> ImpHardwares { get; set; }

    public virtual DbSet<ImpHardware2> ImpHardware2s { get; set; }

    public virtual DbSet<ImpKhachHang> ImpKhachHangs { get; set; }

    public virtual DbSet<ImpNguyenLieu> ImpNguyenLieus { get; set; }

    public virtual DbSet<ImpNguyenLieu3> ImpNguyenLieu3s { get; set; }

    public virtual DbSet<ImpNguyenLieu4> ImpNguyenLieu4s { get; set; }

    public virtual DbSet<ImpNhomHang> ImpNhomHangs { get; set; }

    public virtual DbSet<ImpPhuLieuDongGoi> ImpPhuLieuDongGois { get; set; }

    public virtual DbSet<ImpPtvc> ImpPtvcs { get; set; }

    public virtual DbSet<ImpSptaiSan> ImpSptaiSans { get; set; }

    public virtual DbSet<ImpTaiSan> ImpTaiSans { get; set; }

    public virtual DbSet<ImpTaiSan1> ImpTaiSans1 { get; set; }

    public virtual DbSet<ImpTaiSan2> ImpTaiSan2s { get; set; }

    public virtual DbSet<ImpThuocTinhKhac> ImpThuocTinhKhacs { get; set; }

    public virtual DbSet<ImpVpp> ImpVpps { get; set; }

    public virtual DbSet<ImpVtsxc> ImpVtsxcs { get; set; }

    public virtual DbSet<ImportAttribute> ImportAttributes { get; set; }

    public virtual DbSet<ImportIngrediantPaint> ImportIngrediantPaints { get; set; }

    public virtual DbSet<ImportIngredientPackaging> ImportIngredientPackagings { get; set; }

    public virtual DbSet<ImportLumberProduct> ImportLumberProducts { get; set; }

    public virtual DbSet<ImportNcc> ImportNccs { get; set; }

    public virtual DbSet<ImportProduct> ImportProducts { get; set; }

    public virtual DbSet<ImportProduct1> ImportProducts1 { get; set; }

    public virtual DbSet<ImportReceiptItem> ImportReceiptItems { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobParameter> JobParameters { get; set; }

    public virtual DbSet<JobQueue> JobQueues { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<LvIdentity> LvIdentities { get; set; }

    public virtual DbSet<MWord> MWords { get; set; }

    public virtual DbSet<MmallocationOperationConfig> MmallocationOperationConfigs { get; set; }

    public virtual DbSet<MmallocationPlan> MmallocationPlans { get; set; }

    public virtual DbSet<MmallocationPlanItem> MmallocationPlanItems { get; set; }

    public virtual DbSet<MmallocationProposal> MmallocationProposals { get; set; }

    public virtual DbSet<MmallocationProposalItem> MmallocationProposalItems { get; set; }

    public virtual DbSet<MmbatchItemPlan> MmbatchItemPlans { get; set; }

    public virtual DbSet<MmbatchItemWood> MmbatchItemWoods { get; set; }

    public virtual DbSet<MmbatchProduct> MmbatchProducts { get; set; }

    public virtual DbSet<MmbatchProductAdjustLog> MmbatchProductAdjustLogs { get; set; }

    public virtual DbSet<MmbatchProductCompletionPercentage> MmbatchProductCompletionPercentages { get; set; }

    public virtual DbSet<MmbatchProductInputItem> MmbatchProductInputItems { get; set; }

    public virtual DbSet<MmbatchProductItem> MmbatchProductItems { get; set; }

    public virtual DbSet<MmbatchProductItemGeneralPlan> MmbatchProductItemGeneralPlans { get; set; }

    public virtual DbSet<MmbatchProductItemOperation> MmbatchProductItemOperations { get; set; }

    public virtual DbSet<MmbatchProductItemOperationInfo> MmbatchProductItemOperationInfos { get; set; }

    public virtual DbSet<MmbatchProductItemOutSourcing> MmbatchProductItemOutSourcings { get; set; }

    public virtual DbSet<MmbatchProductProductionNormItem> MmbatchProductProductionNormItems { get; set; }

    public virtual DbSet<MmbatchProductProductionNormItemEquipment> MmbatchProductProductionNormItemEquipments { get; set; }

    public virtual DbSet<MmbatchProductProductionNormItemHardware> MmbatchProductProductionNormItemHardwares { get; set; }

    public virtual DbSet<MmbatchProductProductionNormItemMeterial> MmbatchProductProductionNormItemMeterials { get; set; }

    public virtual DbSet<MmbatchProductProductionNormItemPaint> MmbatchProductProductionNormItemPaints { get; set; }

    public virtual DbSet<MmbatchProductProductionNormItemProcesss> MmbatchProductProductionNormItemProcessses { get; set; }

    public virtual DbSet<MmbpoperationDepartment> MmbpoperationDepartments { get; set; }

    public virtual DbSet<MmcalMaterialConfig> MmcalMaterialConfigs { get; set; }

    public virtual DbSet<MmcalculatorProductionNormCost> MmcalculatorProductionNormCosts { get; set; }

    public virtual DbSet<MmcalculatorProductionNormCostItem> MmcalculatorProductionNormCostItems { get; set; }

    public virtual DbSet<MmcalculatorProductionNormItem> MmcalculatorProductionNormItems { get; set; }

    public virtual DbSet<MmcalculatorProductionNormItemMaterial> MmcalculatorProductionNormItemMaterials { get; set; }

    public virtual DbSet<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; }

    public virtual DbSet<MmcancelAllocationPlanItem> MmcancelAllocationPlanItems { get; set; }

    public virtual DbSet<MmcancelAllocationProposal> MmcancelAllocationProposals { get; set; }

    public virtual DbSet<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; }

    public virtual DbSet<MmcanceledPurchasePlan> MmcanceledPurchasePlans { get; set; }

    public virtual DbSet<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; }

    public virtual DbSet<MmcapacityHumanUnit> MmcapacityHumanUnits { get; set; }

    public virtual DbSet<MmchangeBominformation> MmchangeBominformations { get; set; }

    public virtual DbSet<MmchangeBominformationItem> MmchangeBominformationItems { get; set; }

    public virtual DbSet<MmchangeDeliveryDateBatchProduct> MmchangeDeliveryDateBatchProducts { get; set; }

    public virtual DbSet<MmchangeDeliveryDateBatchProductItem> MmchangeDeliveryDateBatchProductItems { get; set; }

    public virtual DbSet<MmconfigAccountOperation> MmconfigAccountOperations { get; set; }

    public virtual DbSet<MmconfigFalseConditional> MmconfigFalseConditionals { get; set; }

    public virtual DbSet<MmconfigMaterialShipmentUtility> MmconfigMaterialShipmentUtilitys { get; set; }

    public virtual DbSet<MmconsumableConfig> MmconsumableConfigs { get; set; }

    public virtual DbSet<MmcostUpdatePrice> MmcostUpdatePrices { get; set; }

    public virtual DbSet<MmdefaultAllocationOperationConfig> MmdefaultAllocationOperationConfigs { get; set; }

    public virtual DbSet<MmdepartmentAndOperation> MmdepartmentAndOperations { get; set; }

    public virtual DbSet<MmdepartmentCapacityConfig> MmdepartmentCapacityConfigs { get; set; }

    public virtual DbSet<MmdepartmentCapacityDetail> MmdepartmentCapacityDetails { get; set; }

    public virtual DbSet<MmdetailPlanEquipment> MmdetailPlanEquipments { get; set; }

    public virtual DbSet<MmdetailPlanHumanUnit> MmdetailPlanHumanUnits { get; set; }

    public virtual DbSet<MmdetailPlanMachineUnit> MmdetailPlanMachineUnits { get; set; }

    public virtual DbSet<MmdiagramPosition> MmdiagramPositions { get; set; }

    public virtual DbSet<MmexchangeMeasureUnitConfig> MmexchangeMeasureUnitConfigs { get; set; }

    public virtual DbSet<MmexchangeRateConfig> MmexchangeRateConfigs { get; set; }

    public virtual DbSet<MmexecuteTimeConfig> MmexecuteTimeConfigs { get; set; }

    public virtual DbSet<MmfalseConditional> MmfalseConditionals { get; set; }

    public virtual DbSet<MmfalseConditionalDetail> MmfalseConditionalDetails { get; set; }

    public virtual DbSet<MmfalseConditionalItem> MmfalseConditionalItems { get; set; }

    public virtual DbSet<Mmformula> Mmformulas { get; set; }

    public virtual DbSet<MmformulaConfiguration> MmformulaConfigurations { get; set; }

    public virtual DbSet<Mmhistory> Mmhistorys { get; set; }

    public virtual DbSet<MmhistoryDetail> MmhistoryDetails { get; set; }

    public virtual DbSet<MminProgressStatistic> MminProgressStatistics { get; set; }

    public virtual DbSet<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; }

    public virtual DbSet<MmjobTicket> MmjobTickets { get; set; }

    public virtual DbSet<MmjobTicketItem> MmjobTicketItems { get; set; }

    public virtual DbSet<MmjobTicketItemEmployee> MmjobTicketItemEmployees { get; set; }

    public virtual DbSet<MmlabourProductivityTargetConfig> MmlabourProductivityTargetConfigs { get; set; }

    public virtual DbSet<Mmline> Mmlines { get; set; }

    public virtual DbSet<MmlineOperation> MmlineOperations { get; set; }

    public virtual DbSet<MmmachineUnit> MmmachineUnits { get; set; }

    public virtual DbSet<MmmachineUnitCapacity> MmmachineUnitCapacitys { get; set; }

    public virtual DbSet<MmmachineUnitItem> MmmachineUnitItems { get; set; }

    public virtual DbSet<MmmachineUnitOperation> MmmachineUnitOperations { get; set; }

    public virtual DbSet<MmmaterialDepartment> MmmaterialDepartments { get; set; }

    public virtual DbSet<MmmergeBomchange> MmmergeBomchanges { get; set; }

    public virtual DbSet<MmmergeBomchangeBatchProduct> MmmergeBomchangeBatchProducts { get; set; }

    public virtual DbSet<MmmergeBomchangeColumn> MmmergeBomchangeColumns { get; set; }

    public virtual DbSet<MmmergeBomchangeItemBomlog> MmmergeBomchangeItemBomlogs { get; set; }

    public virtual DbSet<MmmergeBomchangeItemBplog> MmmergeBomchangeItemBplogs { get; set; }

    public virtual DbSet<MmmergeBomchangeItemMaterialBomlog> MmmergeBomchangeItemMaterialBomlogs { get; set; }

    public virtual DbSet<MmmergeBomchangeItemMaterialBplog> MmmergeBomchangeItemMaterialBplogs { get; set; }

    public virtual DbSet<MmmergeBomchangeItemProcessBomlog> MmmergeBomchangeItemProcessBomlogs { get; set; }

    public virtual DbSet<MmmergeBomchangeItemProcessBplog> MmmergeBomchangeItemProcessBplogs { get; set; }

    public virtual DbSet<MmnormTemplate> MmnormTemplates { get; set; }

    public virtual DbSet<MmnormTemplateItem> MmnormTemplateItems { get; set; }

    public virtual DbSet<MmnormTemplateProduct> MmnormTemplateProducts { get; set; }

    public virtual DbSet<Mmoperation> Mmoperations { get; set; }

    public virtual DbSet<MmoperationAndHardwareOperationType> MmoperationAndHardwareOperationTypes { get; set; }

    public virtual DbSet<MmoperationDetailPlan> MmoperationDetailPlans { get; set; }

    public virtual DbSet<MmoperationDetailPlanCancel> MmoperationDetailPlanCancels { get; set; }

    public virtual DbSet<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; }

    public virtual DbSet<MmoperationDetailPlanCapacity> MmoperationDetailPlanCapacitys { get; set; }

    public virtual DbSet<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItems { get; set; }

    public virtual DbSet<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; }

    public virtual DbSet<MmoperationDetailPlanItemChild> MmoperationDetailPlanItemChilds { get; set; }

    public virtual DbSet<MmoperationDetailPlanItemChildDateDetail> MmoperationDetailPlanItemChildDateDetails { get; set; }

    public virtual DbSet<MmoperationDetailPlanItemDateDetail> MmoperationDetailPlanItemDateDetails { get; set; }

    public virtual DbSet<MmoperationMachineGroup> MmoperationMachineGroups { get; set; }

    public virtual DbSet<MmoperationProduct> MmoperationProducts { get; set; }

    public virtual DbSet<MmoverallInsideDimensionConfig> MmoverallInsideDimensionConfigs { get; set; }

    public virtual DbSet<MmpackingMaterialMarketDimension> MmpackingMaterialMarketDimensions { get; set; }

    public virtual DbSet<MmpaintProcessConfig> MmpaintProcessConfigs { get; set; }

    public virtual DbSet<MmpaintProcessConfigItem> MmpaintProcessConfigItems { get; set; }

    public virtual DbSet<MmpaintProcessesItem> MmpaintProcessesItems { get; set; }

    public virtual DbSet<MmpaintProcessess> MmpaintProcessesses { get; set; }

    public virtual DbSet<Mmposition> Mmpositions { get; set; }

    public virtual DbSet<MmprintRouting> MmprintRoutings { get; set; }

    public virtual DbSet<MmprocessChange> MmprocessChanges { get; set; }

    public virtual DbSet<MmprocessChangeDetail> MmprocessChangeDetails { get; set; }

    public virtual DbSet<MmprocessChangeItem> MmprocessChangeItems { get; set; }

    public virtual DbSet<MmprocessInfo> MmprocessInfos { get; set; }

    public virtual DbSet<MmprocessProduct> MmprocessProducts { get; set; }

    public virtual DbSet<Mmprocesss> Mmprocessses { get; set; }

    public virtual DbSet<MmproductGroupTypeSwitchingConfig> MmproductGroupTypeSwitchingConfigs { get; set; }

    public virtual DbSet<MmproductPrice> MmproductPrices { get; set; }

    public virtual DbSet<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; }

    public virtual DbSet<MmproductionCompletionTimeConfig> MmproductionCompletionTimeConfigs { get; set; }

    public virtual DbSet<MmproductionComplexityByOperation> MmproductionComplexityByOperations { get; set; }

    public virtual DbSet<MmproductionCost> MmproductionCosts { get; set; }

    public virtual DbSet<MmproductionCostCalculation> MmproductionCostCalculations { get; set; }

    public virtual DbSet<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; }

    public virtual DbSet<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; }

    public virtual DbSet<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; }

    public virtual DbSet<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; }

    public virtual DbSet<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; }

    public virtual DbSet<MmproductionCostFactor> MmproductionCostFactors { get; set; }

    public virtual DbSet<MmproductionCostFactorAllocationRate> MmproductionCostFactorAllocationRates { get; set; }

    public virtual DbSet<MmproductionCostFactorGroup> MmproductionCostFactorGroups { get; set; }

    public virtual DbSet<MmproductionCostFormula> MmproductionCostFormulas { get; set; }

    public virtual DbSet<MmproductionCostFormulaDetail> MmproductionCostFormulaDetails { get; set; }

    public virtual DbSet<MmproductionCostFormulaOperation> MmproductionCostFormulaOperations { get; set; }

    public virtual DbSet<MmproductionCostFormulaOperationItem> MmproductionCostFormulaOperationItems { get; set; }

    public virtual DbSet<MmproductionCostFormulaProduct> MmproductionCostFormulaProducts { get; set; }

    public virtual DbSet<MmproductionCostGeneralCostAllocation> MmproductionCostGeneralCostAllocations { get; set; }

    public virtual DbSet<MmproductionCostGeneralCostAllocationCollectDocument> MmproductionCostGeneralCostAllocationCollectDocuments { get; set; }

    public virtual DbSet<MmproductionCostGeneralCostAllocationDetail> MmproductionCostGeneralCostAllocationDetails { get; set; }

    public virtual DbSet<MmproductionCostIngredientCost> MmproductionCostIngredientCosts { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostDd> MmproductionCostIngredientCostDds { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostDddg> MmproductionCostIngredientCostDddgs { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostDdlr> MmproductionCostIngredientCostDdlrs { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostDdsc> MmproductionCostIngredientCostDdscs { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostDdson> MmproductionCostIngredientCostDdsons { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostDdtc> MmproductionCostIngredientCostDdtcs { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostDg> MmproductionCostIngredientCostDgs { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostLr> MmproductionCostIngredientCostLrs { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostSc> MmproductionCostIngredientCostScs { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostSon> MmproductionCostIngredientCostSons { get; set; }

    public virtual DbSet<MmproductionCostIngredientCostTc> MmproductionCostIngredientCostTcs { get; set; }

    public virtual DbSet<MmproductionCostItem> MmproductionCostItems { get; set; }

    public virtual DbSet<MmproductionCostLinkConfig> MmproductionCostLinkConfigs { get; set; }

    public virtual DbSet<MmproductionCostOtherFee> MmproductionCostOtherFees { get; set; }

    public virtual DbSet<MmproductionCostOverall> MmproductionCostOveralls { get; set; }

    public virtual DbSet<MmproductionNorm> MmproductionNorms { get; set; }

    public virtual DbSet<MmproductionNormApproveLog> MmproductionNormApproveLogs { get; set; }

    public virtual DbSet<MmproductionNormCostFactor> MmproductionNormCostFactors { get; set; }

    public virtual DbSet<MmproductionNormFactor> MmproductionNormFactors { get; set; }

    public virtual DbSet<MmproductionNormItem> MmproductionNormItems { get; set; }

    public virtual DbSet<MmproductionNormItemConfig> MmproductionNormItemConfigs { get; set; }

    public virtual DbSet<MmproductionNormItemEquipment> MmproductionNormItemEquipments { get; set; }

    public virtual DbSet<MmproductionNormItemHardware> MmproductionNormItemHardwares { get; set; }

    public virtual DbSet<MmproductionNormItemLog> MmproductionNormItemLogs { get; set; }

    public virtual DbSet<MmproductionNormItemMeterial> MmproductionNormItemMeterials { get; set; }

    public virtual DbSet<MmproductionNormItemOperation> MmproductionNormItemOperations { get; set; }

    public virtual DbSet<MmproductionNormItemPacking> MmproductionNormItemPackings { get; set; }

    public virtual DbSet<MmproductionNormItemPaint> MmproductionNormItemPaints { get; set; }

    public virtual DbSet<MmprofileManagementItem> MmprofileManagementItems { get; set; }

    public virtual DbSet<Mmproposal> Mmproposals { get; set; }

    public virtual DbSet<MmproposalItem> MmproposalItems { get; set; }

    public virtual DbSet<MmproposalTemplate> MmproposalTemplates { get; set; }

    public virtual DbSet<MmpurchasePlan> MmpurchasePlans { get; set; }

    public virtual DbSet<MmpurchasePlanInPutItem> MmpurchasePlanInPutItems { get; set; }

    public virtual DbSet<MmpurchasePlanItem> MmpurchasePlanItems { get; set; }

    public virtual DbSet<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; }

    public virtual DbSet<MmpurchasePlanTracking> MmpurchasePlanTrackings { get; set; }

    public virtual DbSet<MmquantityAllocationPercentConfig> MmquantityAllocationPercentConfigs { get; set; }

    public virtual DbSet<MmreuseSpecificateConfig> MmreuseSpecificateConfigs { get; set; }

    public virtual DbSet<MmsemiProductIngredient> MmsemiProductIngredients { get; set; }

    public virtual DbSet<MmsemiProductIngredientItem> MmsemiProductIngredientItems { get; set; }

    public virtual DbSet<MmupdatePosition> MmupdatePositions { get; set; }

    public virtual DbSet<MmupdatePositionItem> MmupdatePositionItems { get; set; }

    public virtual DbSet<MmwoodPlan> MmwoodPlans { get; set; }

    public virtual DbSet<MmwoodPlanItem> MmwoodPlanItems { get; set; }

    public virtual DbSet<MmwoodPlanItemDetail> MmwoodPlanItemDetails { get; set; }

    public virtual DbSet<MmworkShop> MmworkShops { get; set; }

    public virtual DbSet<NganhHangOld> NganhHangOlds { get; set; }

    public virtual DbSet<NumberRoman> NumberRomen { get; set; }

    public virtual DbSet<Oeproposal> Oeproposals { get; set; }

    public virtual DbSet<PackageDetailImport> PackageDetailImports { get; set; }

    public virtual DbSet<PmbuidingCommand> PmbuidingCommands { get; set; }

    public virtual DbSet<PmbuidingCommandItem> PmbuidingCommandItems { get; set; }

    public virtual DbSet<PmbuidingProposal> PmbuidingProposals { get; set; }

    public virtual DbSet<PmbuidingProposalItem> PmbuidingProposalItems { get; set; }

    public virtual DbSet<PmbuildingAllocation> PmbuildingAllocations { get; set; }

    public virtual DbSet<PmbuildingAllocationItem> PmbuildingAllocationItems { get; set; }

    public virtual DbSet<PmbuildingPlan> PmbuildingPlans { get; set; }

    public virtual DbSet<PmbuildingPlanItem> PmbuildingPlanItems { get; set; }

    public virtual DbSet<Pmhistory> Pmhistorys { get; set; }

    public virtual DbSet<PmhistoryDetail> PmhistoryDetails { get; set; }

    public virtual DbSet<PmphaseType> PmphaseTypes { get; set; }

    public virtual DbSet<Pmproject> Pmprojects { get; set; }

    public virtual DbSet<PmprojectBidsProfile> PmprojectBidsProfiles { get; set; }

    public virtual DbSet<PmprojectContact> PmprojectContacts { get; set; }

    public virtual DbSet<PmprojectEquipment> PmprojectEquipments { get; set; }

    public virtual DbSet<PmprojectEquipmentItem> PmprojectEquipmentItems { get; set; }

    public virtual DbSet<PmprojectLocation> PmprojectLocations { get; set; }

    public virtual DbSet<PmprojectMaterial> PmprojectMaterials { get; set; }

    public virtual DbSet<PmprojectMaterialItem> PmprojectMaterialItems { get; set; }

    public virtual DbSet<PmprojectMaterialReturn> PmprojectMaterialReturns { get; set; }

    public virtual DbSet<PmprojectMaterialReturnItem> PmprojectMaterialReturnItems { get; set; }

    public virtual DbSet<PmprojectNorm> PmprojectNorms { get; set; }

    public virtual DbSet<PmprojectNormHistory> PmprojectNormHistorys { get; set; }

    public virtual DbSet<PmprojectNormItem> PmprojectNormItems { get; set; }

    public virtual DbSet<PmprojectNormTask> PmprojectNormTasks { get; set; }

    public virtual DbSet<PmprojectPhase> PmprojectPhases { get; set; }

    public virtual DbSet<PmprojectPhaseResource> PmprojectPhaseResources { get; set; }

    public virtual DbSet<PmprojectProfile> PmprojectProfiles { get; set; }

    public virtual DbSet<PmprojectProfilePhase> PmprojectProfilePhases { get; set; }

    public virtual DbSet<PmprojectProfilePhaseResource> PmprojectProfilePhaseResources { get; set; }

    public virtual DbSet<PmprojectTemplateRelationship> PmprojectTemplateRelationships { get; set; }

    public virtual DbSet<PmprojectTimeCard> PmprojectTimeCards { get; set; }

    public virtual DbSet<PmprojectTimeCardItem> PmprojectTimeCardItems { get; set; }

    public virtual DbSet<PmprojectType> PmprojectTypes { get; set; }

    public virtual DbSet<PmsaleWork> PmsaleWorks { get; set; }

    public virtual DbSet<PmsaleWorkItem> PmsaleWorkItems { get; set; }

    public virtual DbSet<Pmtask> Pmtasks { get; set; }

    public virtual DbSet<PmtaskAssign> PmtaskAssigns { get; set; }

    public virtual DbSet<PmtaskAssignsHistory> PmtaskAssignsHistorys { get; set; }

    public virtual DbSet<PmtaskComment> PmtaskComments { get; set; }

    public virtual DbSet<PmtaskFile> PmtaskFiles { get; set; }

    public virtual DbSet<PmtaskReportIssue> PmtaskReportIssues { get; set; }

    public virtual DbSet<PmtasksHistory> PmtasksHistorys { get; set; }

    public virtual DbSet<Pmtemplate> Pmtemplates { get; set; }

    public virtual DbSet<PmtemplateItem> PmtemplateItems { get; set; }

    public virtual DbSet<PmtemplateItemComponent> PmtemplateItemComponents { get; set; }

    public virtual DbSet<PmtemplateItemTask> PmtemplateItemTasks { get; set; }

    public virtual DbSet<Query> Queries { get; set; }

    public virtual DbSet<Revinfo> Revinfos { get; set; }

    public virtual DbSet<Schema> Schemas { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<Set> Sets { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Stfield> Stfields { get; set; }

    public virtual DbSet<StfieldColumn> StfieldColumns { get; set; }

    public virtual DbSet<StfieldColumnPermission> StfieldColumnPermissions { get; set; }

    public virtual DbSet<StfieldEvent> StfieldEvents { get; set; }

    public virtual DbSet<StfieldEventFunction> StfieldEventFunctions { get; set; }

    public virtual DbSet<StfieldEventFunctionParameter> StfieldEventFunctionParameters { get; set; }

    public virtual DbSet<StfieldEventParameter> StfieldEventParameters { get; set; }

    public virtual DbSet<StfieldFormat> StfieldFormats { get; set; }

    public virtual DbSet<StfieldFormatGroup> StfieldFormatGroups { get; set; }

    public virtual DbSet<StfieldLanguage> StfieldLanguages { get; set; }

    public virtual DbSet<StfieldPermission> StfieldPermissions { get; set; }

    public virtual DbSet<StfieldTabStop> StfieldTabStops { get; set; }

    public virtual DbSet<StgridResultColumnDisplay> StgridResultColumnDisplays { get; set; }

    public virtual DbSet<Stmodule> Stmodules { get; set; }

    public virtual DbSet<StmoduleClearData> StmoduleClearDatas { get; set; }

    public virtual DbSet<StmoduleColumn> StmoduleColumns { get; set; }

    public virtual DbSet<StmoduleCompletePermission> StmoduleCompletePermissions { get; set; }

    public virtual DbSet<StmoduleDescription> StmoduleDescriptions { get; set; }

    public virtual DbSet<StmoduleDescriptionsLanguage> StmoduleDescriptionsLanguages { get; set; }

    public virtual DbSet<StmoduleDocumentType> StmoduleDocumentTypes { get; set; }

    public virtual DbSet<StmoduleFunction> StmoduleFunctions { get; set; }

    public virtual DbSet<StmoduleFunctionParameter> StmoduleFunctionParameters { get; set; }

    public virtual DbSet<StmoduleFunctionParameterValue> StmoduleFunctionParameterValues { get; set; }

    public virtual DbSet<StmodulePosting> StmodulePostings { get; set; }

    public virtual DbSet<StmoduleSearchField> StmoduleSearchFields { get; set; }

    public virtual DbSet<StmoduleStatus> StmoduleStatuses { get; set; }

    public virtual DbSet<StmoduleTable> StmoduleTables { get; set; }

    public virtual DbSet<StmoduleToUserGroupSection> StmoduleToUserGroupSections { get; set; }

    public virtual DbSet<StobjectStatus> StobjectStatuses { get; set; }

    public virtual DbSet<Stscreen> Stscreens { get; set; }

    public virtual DbSet<StscreenLanguage> StscreenLanguages { get; set; }

    public virtual DbSet<StscreenPermission> StscreenPermissions { get; set; }

    public virtual DbSet<Sttoolbar> Sttoolbars { get; set; }

    public virtual DbSet<SttoolbarFunction> SttoolbarFunctions { get; set; }

    public virtual DbSet<SttoolbarFunctionParameter> SttoolbarFunctionParameters { get; set; }

    public virtual DbSet<SttoolbarLanguage> SttoolbarLanguages { get; set; }

    public virtual DbSet<SttransactionLogger> SttransactionLoggers { get; set; }

    public virtual DbSet<StuserFieldColumn> StuserFieldColumns { get; set; }

    public virtual DbSet<T1> T1s { get; set; }

    public virtual DbSet<Trungma> Trungmas { get; set; }

    public virtual DbSet<UpConstrain> UpConstrains { get; set; }

    public virtual DbSet<UpdateCcdc> UpdateCcdcs { get; set; }

    public virtual DbSet<UpdateHopdongvay> UpdateHopdongvays { get; set; }

    public virtual DbSet<UpdateMaPhuLieu> UpdateMaPhuLieus { get; set; }

    public virtual DbSet<UpdateNguyenLieu> UpdateNguyenLieus { get; set; }

    public virtual DbSet<UpdateSo> UpdateSos { get; set; }

    public virtual DbSet<UpdateSupplierNo> UpdateSupplierNos { get; set; }

    public virtual DbSet<UpdateTp> UpdateTps { get; set; }

    public virtual DbSet<VAcaccountingLedger> VAcaccountingLedgers { get; set; }

    public virtual DbSet<VAcobject> VAcobjects { get; set; }

    public virtual DbSet<VIcproduct> VIcproducts { get; set; }

    public virtual DbSet<VMmproductionCostCalculationAllocation> VMmproductionCostCalculationAllocations { get; set; }

    public virtual DbSet<VProductionCostInvoice> VProductionCostInvoices { get; set; }

    public virtual DbSet<Vacbalance> Vacbalances { get; set; }

    public virtual DbSet<Vactransaction> Vactransactions { get; set; }

    public virtual DbSet<VapinvoiceInVatIn> VapinvoiceInVatIns { get; set; }

    public virtual DbSet<VapinvoiceInVatInsForReport> VapinvoiceInVatInsForReports { get; set; }

    public virtual DbSet<VapinvoiceInVatInsForReportsTt06> VapinvoiceInVatInsForReportsTt06s { get; set; }

    public virtual DbSet<VarinvoiceVatOut> VarinvoiceVatOuts { get; set; }

    public virtual DbSet<VarinvoiceVatOutsForReport> VarinvoiceVatOutsForReports { get; set; }

    public virtual DbSet<Vcdtk> Vcdtks { get; set; }

    public virtual DbSet<Vmhistory> Vmhistorys { get; set; }

    public virtual DbSet<VmhistoryDetail> VmhistoryDetails { get; set; }

    public virtual DbSet<VmoduleName> VmoduleNames { get; set; }

    public virtual DbSet<Vmvehicle> Vmvehicles { get; set; }

    public virtual DbSet<VmvehicleEmployee> VmvehicleEmployees { get; set; }

    public virtual DbSet<VmvehicleFuelLog> VmvehicleFuelLogs { get; set; }

    public virtual DbSet<VmvehicleGroup> VmvehicleGroups { get; set; }

    public virtual DbSet<Vsocai> Vsocais { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcaccountDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcaccountDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAccountBalances_ACAccounts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcaccountDetails).HasConstraintName("FK_ACAccountDetails_BRBranchs");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.AcaccountDetails).HasConstraintName("FK_ACAccountBalances_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcaccountDetails).HasConstraintName("FK_ACAccountBalances_GECurrencies");
        });

        modelBuilder.Entity<AcaccountTranferCost>(entity =>
        {
            entity.HasOne(d => d.FkAcdocumentType).WithMany(p => p.AcaccountTranferCosts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAccountTranferCosts_ACDocumentTypes");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.AcaccountTranferCosts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAccountTranferCosts_ACEntryTypes");

            entity.HasOne(d => d.FkAcfromAccount).WithMany(p => p.AcaccountTranferCostFkAcfromAccounts).HasConstraintName("FK_ACAccountTranferCosts_ACAccountFroms");

            entity.HasOne(d => d.FkActoAccount).WithMany(p => p.AcaccountTranferCostFkActoAccounts).HasConstraintName("FK_ACAccountTranferCosts_ACAccountTos");
        });

        modelBuilder.Entity<AcaccountingBill>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AcaccountingBillFkAccreditAccounts).HasConstraintName("FK_ACAccountingBills_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AcaccountingBillFkAcdebitAccounts).HasConstraintName("FK_ACAccountingBills_ACAccounts");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ACDocuments");

            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ACEInvoiceTypes");

            entity.HasOne(d => d.FkAcloanReceipt).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ACLoanReceipts");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ACSegments");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ARSaleOrders");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_HRDepartmentRooms");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_MMBatchProducts");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingBills_PMProjects");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.AcaccountingBills).HasConstraintName("FK_ACAccountingbills_VMVehicles");
        });

        modelBuilder.Entity<AcaccountingSheet>(entity =>
        {
            entity.HasOne(d => d.FkBrbranchCentral).WithMany(p => p.AcaccountingSheetFkBrbranchCentrals).HasConstraintName("FK_ACAccountingSheets_BRBranchCentrals");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcaccountingSheetFkBrbranches).HasConstraintName("FK_ACAccountingSheets_BRBranchs");
        });

        modelBuilder.Entity<AcaccountingSheetDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcaccountingSheetDetails).HasConstraintName("FK_ACAccountingSheetDetails_ACAccounts");

            entity.HasOne(d => d.FkAcaccountingSheet).WithMany(p => p.AcaccountingSheetDetails).HasConstraintName("FK_ACAccountingSheetDetails_ACAccountingSheets");
        });

        modelBuilder.Entity<AcactualCostBudget>(entity =>
        {
            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcactualCostBudgets).HasConstraintName("FK_ACActualCostBudgets_GECurrency");
        });

        modelBuilder.Entity<AcactualCostBudgetDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcactualCostBudget).WithMany(p => p.AcactualCostBudgetDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACActualCostBudgetDetails_ACActualCostBudget");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_ACCostCenter");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AcactualCostBudgetDetailFkAccreditAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACActualCostBudgetDetails_ACCreditAccount");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AcactualCostBudgetDetailFkAcdebitAccounts).HasConstraintName("FK_ACActualCostBudgetDetails_ACDebitAccount");

            entity.HasOne(d => d.FkAcdocumentType).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_ACDocumentTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_ACSegment");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_APInvoiceIns");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_ARSaleOrders");

            entity.HasOne(d => d.FkArseller).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_ARSellers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_BRBranch");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_GECurrency");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_HRDepartment");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_BRBranchs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_MMWorkShops");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_PMProjects");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.AcactualCostBudgetDetails).HasConstraintName("FK_ACActualCostBudgetDetails_VMVehicles");
        });

        modelBuilder.Entity<AcadjustIncreaseOrDecreaseAsset>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcadjustIncreaseOrDecreaseAssetFkBrbranches).HasConstraintName("FK_ACAdjustIncreaseOrDecreaseAssets_BRBranchs");

            entity.HasOne(d => d.FkBrinvoiceBranch).WithMany(p => p.AcadjustIncreaseOrDecreaseAssetFkBrinvoiceBranches).HasConstraintName("FK_ACAdjustIncreaseOrDecreaseAssets_BRInvoiceBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcadjustIncreaseOrDecreaseAssets).HasConstraintName("FK_ACAdjustIncreaseOrDecreaseAssets_GECurrencies");
        });

        modelBuilder.Entity<AcadjustIncreaseOrDecreaseAssetItem>(entity =>
        {
            entity.HasOne(d => d.FkAcadjustIncreaseOrDecreaseAsset).WithMany(p => p.AcadjustIncreaseOrDecreaseAssetItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAdjustIncreaseOrDecreaseAssetItems_ACAdjustIncreaseOrDecreaseAssets");

            entity.HasOne(d => d.FkAcasset).WithMany(p => p.AcadjustIncreaseOrDecreaseAssetItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAdjustIncreaseOrDecreaseAssetItems_ACAssets");
        });

        modelBuilder.Entity<AcallocationCostObjectTran>(entity =>
        {
            entity.HasOne(d => d.FkAccostAccount).WithMany(p => p.AcallocationCostObjectTranFkAccostAccounts).HasConstraintName("FK_ACAllocationCostObjectTrans_ACCostAccounts");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_ACCostObjects");

            entity.HasOne(d => d.FkAccostObjectItem).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_ACCostObjectItems");

            entity.HasOne(d => d.FkAcdepreciationWaitAccount).WithMany(p => p.AcallocationCostObjectTranFkAcdepreciationWaitAccounts).HasConstraintName("FK_ACAllocationCostObjectTrans_ACAccountWaits");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_ACDocuments");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_ACSegments");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_APPurchaseOrders");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_HRDepartmentRooms");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_ICProductForBatchs");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_MMWorkShops");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcallocationCostObjectTrans).HasConstraintName("FK_ACAllocationCostObjectTrans_PMProjects");
        });

        modelBuilder.Entity<AcallocationEquipmentTran>(entity =>
        {
            entity.HasOne(d => d.FkAcallocationAccount).WithMany(p => p.AcallocationEquipmentTranFkAcallocationAccounts).HasConstraintName("FK_ACAllocationEquipmentTrans_ACAllocationAccounts");

            entity.HasOne(d => d.FkAcallocationCostAccount).WithMany(p => p.AcallocationEquipmentTranFkAcallocationCostAccounts).HasConstraintName("FK_ACAllocationEquipmentTrans_ACAllocationCostAccounts");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_ACCostCenters");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_ACDocuments");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_ACSegments");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_APPurchaseOrders");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_HRDepartmentRooms");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_ICProductForBatchs");

            entity.HasOne(d => d.FkIcproductIdentifiedEquipment).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_ICProductIdentifiedEquipments");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_MMWorkShops");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcallocationEquipmentTrans).HasConstraintName("FK_ACAllocationEquipmentTrans_PMProjects");
        });

        modelBuilder.Entity<Acasset>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcassetFkAcaccounts).HasConstraintName("FK_ACAssets_ACAccount");

            entity.HasOne(d => d.FkAcassetTypeAccountConfig).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ACAssetTypeAccountConfigs");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ACCostCenters");

            entity.HasOne(d => d.FkAcdepreciationAccount).WithMany(p => p.AcassetFkAcdepreciationAccounts).HasConstraintName("FK_ACAssets_ACAccounts1");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.AcassetFkAcdepreciationCostAccounts).HasConstraintName("FK_ACAssets_ACAccounts");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ACSegments");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_HRDepartmentRoomGroupID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcassetFkHrdepartmentRooms).HasConstraintName("FK_ACAssets_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_HREmployeeUserID");

            entity.HasOne(d => d.FkHrinitRoom).WithMany(p => p.AcassetFkHrinitRooms).HasConstraintName("FK_ACAssets_HRDepartmentRooms1");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_ICProductSeries");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_MMLineID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.Acassets).HasConstraintName("FK_ACAssets_MMWorkShopID");
        });

        modelBuilder.Entity<AcassetReceipt>(entity =>
        {
            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.AcassetReceipts).HasConstraintName("FK__ACAssetRe__FK_AC__142C597D");

            entity.HasOne(d => d.FkAppurchaseContract).WithMany(p => p.AcassetReceipts).HasConstraintName("FK__ACAssetRe__FK_AP__01198509");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.AcassetReceipts).HasConstraintName("FK_ACAssetReceipts_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcassetReceipts).HasConstraintName("FK_ACAssetReceipts_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcassetReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetReceipts_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AcassetReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetReceipts_HREmployees");
        });

        modelBuilder.Entity<AcassetReceiptItem>(entity =>
        {
            entity.HasOne(d => d.FkAcasset).WithMany(p => p.AcassetReceiptItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetReceiptItems_ACAssets");

            entity.HasOne(d => d.FkAcassetReceipt).WithMany(p => p.AcassetReceiptItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetReceiptItems_ACAssetReceipts");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_HRDepartmentRoomGroupID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcassetReceiptItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetReceiptItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_HREmployeeUserID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_ICStocks");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_MMLineID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcassetReceiptItems).HasConstraintName("FK_ACAssetReceiptItems_MMWorkShopID");
        });

        modelBuilder.Entity<AcassetShipmentItem>(entity =>
        {
            entity.HasOne(d => d.FkAcasset).WithMany(p => p.AcassetShipmentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetShipmentItems_ACAssets");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcassetShipmentItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ACAssetShipmentItems_ACCostCenters");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcassetShipmentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetShipmentItems_ACDocuments");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcassetShipmentItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ACAssetShipmentItems_ACSegments");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcassetShipmentItems).HasConstraintName("FK_ACAssetShipmentItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.AcassetShipmentItems).HasConstraintName("FK_ACAssetShipmentItems_HRDepartmentRoomGroupID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcassetShipmentItems).HasConstraintName("FK_ACAssetShipmentItems_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcassetShipmentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetShipmentItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.AcassetShipmentItems).HasConstraintName("FK_ACAssetShipmentItems_HREmployeeUserID");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcassetShipmentItems).HasConstraintName("FK_ACAssetShipmentItems_MMLineID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcassetShipmentItems).HasConstraintName("FK_ACAssetShipmentItems_MMWorkShopID");
        });

        modelBuilder.Entity<AcassetTransferItem>(entity =>
        {
            entity.HasOne(d => d.FkAcasset).WithMany(p => p.AcassetTransferItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetTransferItems_ACAssets");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcassetTransferItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ACAssetTransferItems_ACCostCenters");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.AcassetTransferItems).HasConstraintName("FK_ACAssetTransferItems_ACAccounts");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcassetTransferItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetTransferItems_ACDocuments");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcassetTransferItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ACAssetTransferItems_ACSegments");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcassetTransferItemFkHrdepartments).HasConstraintName("FK_ACAssetTransferItems_HRDepartments1");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.AcassetTransferItems).HasConstraintName("FK_ACAssetTransferItems_HRDepartmentRoomGroupID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcassetTransferItems).HasConstraintName("FK_ACAssetTransferItems_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcassetTransferItemFkHrdepartmentRooms).HasConstraintName("FK_ACAssetTransferItems_HRDepartmentRooms2");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.AcassetTransferItems).HasConstraintName("FK_ACAssetTransferItems_HREmployeeUserID");

            entity.HasOne(d => d.FkHrfromRoom).WithMany(p => p.AcassetTransferItemFkHrfromRooms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetTransferItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHrtoDepartment).WithMany(p => p.AcassetTransferItemFkHrtoDepartments).HasConstraintName("FK_ACAssetTransferItems_HRDepartments2");

            entity.HasOne(d => d.FkHrtoRoom).WithMany(p => p.AcassetTransferItemFkHrtoRooms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAssetTransferItems_HRDepartmentRooms1");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcassetTransferItems).HasConstraintName("FK_ACAssetTransferItems_MMLineID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcassetTransferItems).HasConstraintName("FK_ACAssetTransferItems_MMWorkShopID");
        });

        modelBuilder.Entity<AcassetTypeAccountConfig>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcassetTypeAccountConfigFkAcaccounts).HasConstraintName("FK_ACAssetTypeAccountConfigs_FK_ACAccountID");

            entity.HasOne(d => d.FkAcdepreciationAccount).WithMany(p => p.AcassetTypeAccountConfigFkAcdepreciationAccounts).HasConstraintName("FK_ACAssetTypeAccountConfigs_FK_ACDepreciationAccountID");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.AcassetTypeAccountConfigFkAcdepreciationCostAccounts).HasConstraintName("FK_ACAssetTypeAccountConfigs_FK_ACDepreciationCostAccountID");
        });

        modelBuilder.Entity<AcbalanceAmountArising>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcbalanceAmountArisings).HasConstraintName("FK_ACBalanceAmountArisings_BRBranchs");
        });

        modelBuilder.Entity<AcbalanceAmountArisingDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcbalanceAmountArisingDetails).HasConstraintName("FK_ACBalanceAmountArisingDetails_ACAccounts");

            entity.HasOne(d => d.FkAcbalanceAmountArising).WithMany(p => p.AcbalanceAmountArisingDetails).HasConstraintName("FK_ACBalanceAmountArisingDetails_ACBalanceAmountArisings");
        });

        modelBuilder.Entity<AcbalanceAmountArisingObjectDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcbalanceAmountArisingObjectDetails).HasConstraintName("FK_ACBalanceAmountArisingObjectDetails_ACAccounts");

            entity.HasOne(d => d.FkAcbalanceAmountArisingDetail).WithMany(p => p.AcbalanceAmountArisingObjectDetails).HasConstraintName("FK_ACBalanceAmountArisingObjectDetails_ACBalanceAmountArisingDetails");

            entity.HasOne(d => d.FkAcbalanceAmountArising).WithMany(p => p.AcbalanceAmountArisingObjectDetails).HasConstraintName("FK_ACBalanceAmountArisingObjectDetails_ACBalanceAmountArisings");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcbalanceAmountArisingObjectDetails).HasConstraintName("FK_ACBalanceAmountArisingObjectDetails_BRBranchs");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.AcbalanceAmountArisingObjectDetails).HasConstraintName("ACBalanceAmountArisingObjectDetail_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcbalanceAmountArisingObjectDetails).HasConstraintName("ACBalanceAmountArisingObjectDetail_GECurrencies");
        });

        modelBuilder.Entity<AcbankTransaction>(entity =>
        {
            entity.HasOne(d => d.FkAclistAccountBank).WithMany(p => p.AcbankTransactions).HasConstraintName("FK_ACBankTransactions_ACListAccountBanks");

            entity.HasOne(d => d.FkAcloanReceipt).WithMany(p => p.AcbankTransactions).HasConstraintName("FK_ACBankTransactions_ACLoanReceipts");

            entity.HasOne(d => d.FkAcloanReceiptPaymentPlan).WithMany(p => p.AcbankTransactions).HasConstraintName("FK_ACBankTransactions_ACLoanReceiptPaymentPlans");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcbankTransactions).HasConstraintName("FK_ACBankTransactions_ACSegments");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.AcbankTransactions).HasConstraintName("FK__ACBankTra__FK_AR__30DDA6C4");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcbankTransactions).HasConstraintName("FK_ACBankTransactions_BRBranchs");

            entity.HasOne(d => d.FkCscashFund).WithMany(p => p.AcbankTransactionFkCscashFunds).HasConstraintName("FK_ACBankTransactions_CSCashFunds");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.AcbankTransactionFkCscompanyBanks).HasConstraintName("FK_ACBankTransactions_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcbankTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACBankTransactions_GECurrencies");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.AcbankTransactionFkHremployeeApproveds).HasConstraintName("FK_ACBankTransactions_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployeeCompleted).WithMany(p => p.AcbankTransactionFkHremployeeCompleteds).HasConstraintName("FK_ACBankTransactions_HREmployeeCompleteds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AcbankTransactionFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACBankTransactions_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcbankTransactions).HasConstraintName("FK_ACBankTransactions_PMProjects");

            entity.HasOne(d => d.FkToCscashFund).WithMany(p => p.AcbankTransactionFkToCscashFunds).HasConstraintName("FK_ACBankTransactions_FK_ToCSCashFundID");

            entity.HasOne(d => d.FkToCscompanyBank).WithMany(p => p.AcbankTransactionFkToCscompanyBanks).HasConstraintName("FK_ACBankTransactions_FK_ToCSCompanyBankID");
        });

        modelBuilder.Entity<AcbankTransactionItem>(entity =>
        {
            entity.HasOne(d => d.FkAcbankTransaction).WithMany(p => p.AcbankTransactionItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACBankTransactionItems_ACBankTransactions");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AcbankTransactionItemFkAccreditAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACBankTransactionItems_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AcbankTransactionItemFkAcdebitAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACBankTransactionItems_ACAccounts");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.AcbankTransactionItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACBankTransactionItems_ACEntryTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_ACSegments");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkHradvanceRefund).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_HRAdvanceRefunds");

            entity.HasOne(d => d.FkHradvanceRefundItemInvoice).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_HRAdvanceRefundItemInvoices");

            entity.HasOne(d => d.FkHradvanceRequestItem).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_HRAdvanceRequestItems");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_PMProjects");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.AcbankTransactionItems).HasConstraintName("FK_ACBankTransactionItems_VMVehicles");
        });

        modelBuilder.Entity<AcbudgetTracking>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcbudgetTrackings).HasConstraintName("FK_ACBudgetTrackings_BRBranchs");
        });

        modelBuilder.Entity<AcbudgetTrackingItem>(entity =>
        {
            entity.HasOne(d => d.FkAcbudgetTracking).WithMany(p => p.AcbudgetTrackingItems).HasConstraintName("FK_ACBudgetTrackingItems_ACBudgetTrackings");
        });

        modelBuilder.Entity<AcbusinessResult>(entity =>
        {
            entity.HasOne(d => d.FkBrbranchCentral).WithMany(p => p.AcbusinessResultFkBrbranchCentrals).HasConstraintName("FK_ACBusinessResults_BRBranchCentrals");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcbusinessResultFkBrbranches).HasConstraintName("FK_ACBusinessResults_BRBranchs");
        });

        modelBuilder.Entity<AcbusinessResultDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcbusinessResultDetails).HasConstraintName("FK_ACBusinessResultDetails_ACAccounts");

            entity.HasOne(d => d.FkAcbusinessResult).WithMany(p => p.AcbusinessResultDetails).HasConstraintName("FK_ACBusinessResultDetails_ACBusinessResults");
        });

        modelBuilder.Entity<AcclearingDebt>(entity =>
        {
            entity.HasKey(e => e.AcclearingDebtId).HasName("PK_FAClearingDebts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcclearingDebts).HasConstraintName("FK_ACClearingDebts_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcclearingDebts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACClearingDebts_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AcclearingDebts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACClearingDebts_HREmployees");
        });

        modelBuilder.Entity<AcclearingDebtInvoiceInItem>(entity =>
        {
            entity.HasKey(e => e.AcclearingDebtInvoiceInItemId).HasName("PK_FAClearingDebtInvoiceInItems");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcclearingDebtInvoiceInItems).HasConstraintName("FK_ACClearingDebtInvoiceInItems_ACAccounts");

            entity.HasOne(d => d.FkAcclearingDebt).WithMany(p => p.AcclearingDebtInvoiceInItems).HasConstraintName("FK_ACClearingDebtInvoiceInItems_ACClearingDebts");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcclearingDebtInvoiceInItems).HasConstraintName("FK_ACClearingDebtInvoiceInItems_ACDocuments");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.AcclearingDebtInvoiceInItems).HasConstraintName("FK_ACClearingDebtInvoiceItems_APInvoiceIns");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AcclearingDebtInvoiceInItems).HasConstraintName("FK_ACClearingDebtInvoiceInItems_APPurchaseOrders");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcclearingDebtInvoiceInItems).HasConstraintName("FK_ACClearingDebtInvoiceInItems_GECurrencies");
        });

        modelBuilder.Entity<AcclearingDebtInvoiceItem>(entity =>
        {
            entity.HasKey(e => e.AcclearingDebtInvoiceItemId).HasName("PK_FAClearingDebtInvoiceItems");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcclearingDebtInvoiceItems).HasConstraintName("FK_ACClearingDebtInvoiceItems_ACAccounts");

            entity.HasOne(d => d.FkAcclearingDebt).WithMany(p => p.AcclearingDebtInvoiceItems).HasConstraintName("FK_ACClearingDebtInvoiceItems_ACClearingDebts");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.AcclearingDebtInvoiceItems).HasConstraintName("FK_ACClearingDebtInvoiceItems_ARInvoices");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.AcclearingDebtInvoiceItems).HasConstraintName("FK_ACClearingDebtInvoiceItems_ARSaleOrders");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcclearingDebtInvoiceItems).HasConstraintName("FK_ACClearingDebtInvoiceItems_GECurrencies");
        });

        modelBuilder.Entity<AccostBudget>(entity =>
        {
            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AccostBudgets).HasConstraintName("FK_ACCostBudgets_GECurrency");
        });

        modelBuilder.Entity<AccostBudgetDetail>(entity =>
        {
            entity.HasOne(d => d.FkAccostBudget).WithMany(p => p.AccostBudgetDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCostBudgetDetails_ACCostBudget");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AccostBudgetDetails).HasConstraintName("FK_ACCostBudgetDetails_ACCostCenter");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AccostBudgetDetailFkAccreditAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCostBudgetDetails_ACCreditAccount");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AccostBudgetDetailFkAcdebitAccounts).HasConstraintName("FK_ACCostBudgetDetails_ACDebitAccount");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AccostBudgetDetails).HasConstraintName("FK_ACCostBudgetDetails_ACSegment");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AccostBudgetDetails).HasConstraintName("FK_ACCostBudgetDetails_BRBranch");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AccostBudgetDetails).HasConstraintName("FK_ACCostBudgetDetails_GECurrency");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AccostBudgetDetails).HasConstraintName("FK_ACCostBudgetDetails_HRDepartment");
        });

        modelBuilder.Entity<AccostObject>(entity =>
        {
            entity.HasOne(d => d.FkAccostAccount).WithMany(p => p.AccostObjectFkAccostAccounts).HasConstraintName("FK_ACCostObjects_ACAccounts");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AccostObjects).HasConstraintName("FK_ACCostObjects_ACCostCenters");

            entity.HasOne(d => d.FkAcdepreciationWaitAccount).WithMany(p => p.AccostObjectFkAcdepreciationWaitAccounts).HasConstraintName("FK_ACCostObjects_ACAccounts1");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AccostObjects).HasConstraintName("FK_ACCostObjects_ACSegments");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AccostObjectFkBrbranches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCostObjects_BRBranchs");

            entity.HasOne(d => d.FkBrcostedBranch).WithMany(p => p.AccostObjectFkBrcostedBranches).HasConstraintName("FK_ACCostObjects_BRBranchs1");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AccostObjects).HasConstraintName("FK_ACCostObjects_PMProjects");
        });

        modelBuilder.Entity<AccostObjectItem>(entity =>
        {
            entity.HasOne(d => d.FkAcallocationAccount).WithMany(p => p.AccostObjectItemFkAcallocationAccounts).HasConstraintName("FK_ACCostObjects_ACAllocationAccounts");

            entity.HasOne(d => d.FkAccostAllocationWaitAccount).WithMany(p => p.AccostObjectItemFkAccostAllocationWaitAccounts).HasConstraintName("FK_ACCostObjects_ACCostAllocationWaitAccounts");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AccostObjectItems).HasConstraintName("FK_ACCostObjectItems_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AccostObjectItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCostObjectItems_ACCostObjects");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AccostObjectItems).HasConstraintName("FK_ACCostObjectItems_ACSegments");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AccostObjectItems).HasConstraintName("FK_ACCostObjectItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AccostObjectItems).HasConstraintName("FK_ACCostObjectItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AccostObjectItems).HasConstraintName("FK_ACCostObjectItems_PMProjects");
        });

        modelBuilder.Entity<AcdepreciationAssetTran>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcdepreciationAssetTranFkAcaccounts).HasConstraintName("FK_ACDepreciationAssetTrans_ACAccounts");

            entity.HasOne(d => d.FkAcadjustIncreaseOrDecreaseAsset).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_ACAdjustIncreaseOrDecreaseAssets");

            entity.HasOne(d => d.FkAcasset).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_ACAssets");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_ACCostCenters");

            entity.HasOne(d => d.FkAcdepreciationAccount).WithMany(p => p.AcdepreciationAssetTranFkAcdepreciationAccounts).HasConstraintName("FK_ACDepreciationAssetTrans_ACDepreciationAccounts");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.AcdepreciationAssetTranFkAcdepreciationCostAccounts).HasConstraintName("FK_ACDepreciationAssetTrans_ACDepreciationCostAccounts");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_ACDocuments");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_ACSegments");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_APPurchaseOrders");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_HRDepartmentRooms");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_MMWorkShops");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcdepreciationAssetTrans).HasConstraintName("FK_ACDepreciationAssetTrans_PMProjects");
        });

        modelBuilder.Entity<Acdevice>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Acdevices).HasConstraintName("ACDeviceItems_FK_BRBranchID");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Acdevices).HasConstraintName("ACDeviceItems_FK_HREmployeeID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.Acdevices).HasConstraintName("ACDeviceItems_FK_ICProductID");
        });

        modelBuilder.Entity<AcdocTypeEntry>(entity =>
        {
            entity.HasOne(d => d.FkAcdocumentType).WithMany(p => p.AcdocTypeEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACDocTypeEntrys_ACDocumentTypes");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.AcdocTypeEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACDocTypeEntrys_ACEntryTypes");
        });

        modelBuilder.Entity<AcdocTypeEntryAccount>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcdocTypeEntryAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACDocTypeEntryAccounts_ACAccounts");

            entity.HasOne(d => d.FkAcdocTypeEntry).WithMany(p => p.AcdocTypeEntryAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACDocTypeEntryAccounts_ACDocTypeEntrys");
        });

        modelBuilder.Entity<AcdocTypeEntryFunctionMapping>(entity =>
        {
            entity.HasKey(e => e.AcdocTypeEntryFunctionMappingId).HasName("PK__ACDocTyp__2006DA52ECED6DDC");

            entity.HasOne(d => d.FkAcdocumentType).WithMany(p => p.AcdocTypeEntryFunctionMappings).HasConstraintName("FK_ACDocTypeEntryFunctionMappings_ACDocumentTypes");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.AcdocTypeEntryFunctionMappings).HasConstraintName("FK_ACDocTypeEntryFunctionMappings_ACEntryTypes");

            entity.HasOne(d => d.FkStmodule).WithMany(p => p.AcdocTypeEntryFunctionMappings)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ACDocTypeEntryFunctionMappings_STModules");
        });

        modelBuilder.Entity<Acdocument>(entity =>
        {
            entity.ToTable("ACDocuments", tb => tb.HasTrigger("trg_Survey_Identify_Updated_Columns"));

            entity.HasOne(d => d.FkAcdocumentType).WithMany(p => p.Acdocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACDocuments_ACDocumentTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.Acdocuments).HasConstraintName("FK_ACDocuments_ACSegments");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Acdocuments).HasConstraintName("FK_ACDocuments_BRBranchs");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.Acdocuments).HasConstraintName("FK_ACDocuments_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Acdocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACDocuments_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Acdocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACDocuments_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Acdocuments).HasConstraintName("FK_ACDocuments_PMProjects");
        });

        modelBuilder.Entity<AcdocumentEntry>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AcdocumentEntryFkAccreditAccounts).HasConstraintName("FK_ACDocumentEntrys_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AcdocumentEntryFkAcdebitAccounts).HasConstraintName("FK_ACDocumentEntrys_ACAccounts");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcdocumentEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACDocumentEntrys_ACDocuments");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_ACEntryTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_ACSegments");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkBrcostedBranch).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_HRDepartments");

            entity.HasOne(d => d.FkIcproductIdentifiedEquipment).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_ICProductIdentifiedEquipments");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_PMProjects");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.AcdocumentEntries).HasConstraintName("FK_ACDocumentEntrys_VMVehicles");
        });

        modelBuilder.Entity<AcdocumentTran>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcdocumentTranFkAcaccounts).HasConstraintName("FK_ACDocumentTrans_ACAccounts1");

            entity.HasOne(d => d.FkAcoffsetAccount).WithMany(p => p.AcdocumentTranFkAcoffsetAccounts).HasConstraintName("FK_ACDocumentTrans_ACAccounts2");
        });

        modelBuilder.Entity<AceinvoiceConfig>(entity =>
        {
            entity.HasOne(d => d.FkActaxUnit).WithMany(p => p.AceinvoiceConfigs).HasConstraintName("FK_ACEInvoiceConfigs_ACTaxUnits");
        });

        modelBuilder.Entity<AceinvoiceDetail>(entity =>
        {
            entity.HasOne(d => d.FkAceinvoiceGeneral).WithMany(p => p.AceinvoiceDetails).HasConstraintName("FK_ACEInvoiceDetails_ACEInvoiceGenerals");
        });

        modelBuilder.Entity<AceinvoiceGeneral>(entity =>
        {
            entity.Property(e => e.BuyerAddressLine).HasDefaultValueSql("('')");
            entity.Property(e => e.BuyerCode).HasDefaultValueSql("('')");
            entity.Property(e => e.BuyerDisplayName).HasDefaultValueSql("('')");
            entity.Property(e => e.BuyerEmail).HasDefaultValueSql("('')");
            entity.Property(e => e.FkGecurrencyId).HasDefaultValueSql("((10000))");

            entity.HasOne(d => d.FkAceinvoicePaymentMethod).WithMany(p => p.AceinvoiceGenerals).HasConstraintName("FK_ACEInvoiceGenerals_ACEInvoicePaymentMethods");

            entity.HasOne(d => d.FkActaxUnit).WithMany(p => p.AceinvoiceGenerals).HasConstraintName("FK_ACEInvoiceGenerals_ACTaxUnits");
        });

        modelBuilder.Entity<AceinvoicePayment>(entity =>
        {
            entity.HasOne(d => d.FkAceinvoiceGeneral).WithMany(p => p.AceinvoicePayments).HasConstraintName("FK_ACEInvoicePayments_ACEInvoiceGenerals");
        });

        modelBuilder.Entity<AceinvoiceTaxLevelAndAmount>(entity =>
        {
            entity.HasOne(d => d.FkAceinvoiceGeneral).WithMany(p => p.AceinvoiceTaxLevelAndAmounts).HasConstraintName("FK_ACEInvoiceTaxLevelAndAmounts_ACEInvoiceGenerals");
        });

        modelBuilder.Entity<AcendingAllocation>(entity =>
        {
            entity.HasOne(d => d.FkAcendingAllocationDeclaration).WithMany(p => p.AcendingAllocations).HasConstraintName("FK_ACEndingAllocations_ACEndingAllocationDeclaration");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcendingAllocations).HasConstraintName("FK_ACEndingAllocations_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcendingAllocations).HasConstraintName("FK_ACEndingAllocations_GECurrency");
        });

        modelBuilder.Entity<AcendingAllocationDeclarationItem>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_ACAccount");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_ACCostCenter");

            entity.HasOne(d => d.FkAcendingAllocationDeclaration).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_ACEndingAllocationDeclaration");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_ACSegment");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_HRDepartment");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_HRDepartmentRoomGroupItem");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_HRDepartmentRoom");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_ICProduct");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_MMBatchProduct");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_MMLine");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_MMOperation");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_MMWorkShop");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcendingAllocationDeclarationItems).HasConstraintName("FK_ACEndingAllocationDeclarationItems_PMProjects");
        });

        modelBuilder.Entity<AcendingAllocationDeclarationItemReceife>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcendingAllocationDeclarationItemReceifeFkAcaccounts).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_ACAccount");

            entity.HasOne(d => d.FkAcbyCreditAccount).WithMany(p => p.AcendingAllocationDeclarationItemReceifeFkAcbyCreditAccounts).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_ACByCreditAccount");

            entity.HasOne(d => d.FkAcbyDebitAccount).WithMany(p => p.AcendingAllocationDeclarationItemReceifeFkAcbyDebitAccounts).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_ACByDebitAccount");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_ACCostCenter");

            entity.HasOne(d => d.FkAcendingAllocationDeclaration).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_ACEndingAllocationDeclaration");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_ACSegment");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_HRDepartment");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_HRDepartmentRoomGroupItem");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_HRDepartmentRoom");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_ICProduct");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_MMBatchProduct");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_MMLine");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_MMOperation");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_MMWorkShop");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcendingAllocationDeclarationItemReceives).HasConstraintName("FK_ACEndingAllocationDeclarationItemReceives_PMProjects");
        });

        modelBuilder.Entity<AcendingAllocationItem>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcendingAllocationItemFkAcaccounts).HasConstraintName("FK_ACEndingAllocationItems_ACAccount");

            entity.HasOne(d => d.FkAcbyCreditAccount).WithMany(p => p.AcendingAllocationItemFkAcbyCreditAccounts).HasConstraintName("FK_ACEndingAllocationItems_ACByCreditAccount");

            entity.HasOne(d => d.FkAcbyDebitAccount).WithMany(p => p.AcendingAllocationItemFkAcbyDebitAccounts).HasConstraintName("FK_ACEndingAllocationItems_ACByDebitAccount");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_ACCostCenter");

            entity.HasOne(d => d.FkAcendingAllocation).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_ACEndingAllocation");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_ACSegment");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_HRDepartment");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_HRDepartmentRoomGroupItem");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_HRDepartmentRoom");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_ICProduct");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_MMBatchProduct");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_MMLine");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_MMOperation");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcendingAllocationItems).HasConstraintName("FK_ACEndingAllocationItems_MMWorkShop");
        });

        modelBuilder.Entity<AcequipmentTransferItem>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcequipmentTransferItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ACEquipmentTransferItems_ACCostCenters");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_ACAccounts");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcequipmentTransferItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACEquipmentTransferItems_ACDocuments");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcequipmentTransferItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ACEquipmentTransferItems_ACSegments");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcequipmentTransferItemFkHrdepartments).HasConstraintName("FK_ACEquipmentTransferItems_HRDepartments2");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_HRDepartmentRoomGroupID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcequipmentTransferItemFkHrdepartmentRooms).HasConstraintName("FK_ACEquipmentTransferItems_HRDepartmentRooms2");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_HREmployeeUserID");

            entity.HasOne(d => d.FkHrfromDepartment).WithMany(p => p.AcequipmentTransferItemFkHrfromDepartments).HasConstraintName("FK_ACEquipmentTransferItems_HRFromDepartmentID");

            entity.HasOne(d => d.FkHrfromRoom).WithMany(p => p.AcequipmentTransferItemFkHrfromRooms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACEquipmentTransferItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHrtoRoom).WithMany(p => p.AcequipmentTransferItemFkHrtoRooms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACEquipmentTransferItems_HRDepartmentRooms1");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_ACEquipmentTransferItems");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_ICModels");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcequipmentTransferItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACEquipmentTransferItems_ICProducts");

            entity.HasOne(d => d.FkIcproductIdentifiedEquipment).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_ICProductIdentifiedEquipments");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("ACEquipmentTransferItems_ICStocks");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_MMLineID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.AcequipmentTransferItems).HasConstraintName("FK_ACEquipmentTransferItems_MMWorkShopID");
        });

        modelBuilder.Entity<AcequipmentTypeAccountConfig>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcequipmentTypeAccountConfigFkAcaccounts).HasConstraintName("FK_ACEquipmentTypeAccountConfigs_FK_ACAccountID");

            entity.HasOne(d => d.FkAcdepreciationAccount).WithMany(p => p.AcequipmentTypeAccountConfigFkAcdepreciationAccounts).HasConstraintName("FK_ACEquipmentTypeAccountConfigs_FK_ACDepreciationAccountID");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.AcequipmentTypeAccountConfigFkAcdepreciationCostAccounts).HasConstraintName("FK_ACEquipmentTypeAccountConfigs_FK_ACDepreciationCostAccountID");
        });

        modelBuilder.Entity<Achistory>(entity =>
        {
            entity.HasKey(e => e.AchistoryId).HasName("PK_ACHistory");

            entity.Property(e => e.AchistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.AchistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.AchistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<AchistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkAchistory).WithMany(p => p.AchistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACHistoryDetails_ACHistory");
        });

        modelBuilder.Entity<AclistAccountBank>(entity =>
        {
            entity.HasOne(d => d.FkAclistAccountBankBranchCity).WithMany(p => p.AclistAccountBanks).HasConstraintName("FK_ACListAccountBanks_GEStateProvinces2");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AclistAccountBanks).HasConstraintName("FK_ACListAccountBanks_BRBranchs");

            entity.HasOne(d => d.FkGebank).WithMany(p => p.AclistAccountBanks).HasConstraintName("FK_ACListAccountBanks_GEBanks");
        });

        modelBuilder.Entity<AcloanAgreement>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcloanAgreements).HasConstraintName("FK_ACLoanAgreements_BRBranchs");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.AcloanAgreements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACLoanAgreements_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcloanAgreements).HasConstraintName("FK_ACLoanAgreements_GECurrencies");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcloanAgreements).HasConstraintName("FK_ACLoanAgreements_PMProjects");
        });

        modelBuilder.Entity<AcloanReceipt>(entity =>
        {
            entity.HasOne(d => d.FkAcloanAgreement).WithMany(p => p.AcloanReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACLoanReceipts_ACLoanAgreements");

            entity.HasOne(d => d.FkAcloanReceiptType).WithMany(p => p.AcloanReceipts).HasConstraintName("FK_ACLoanReceipts_ACLoanReceiptTypes");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcloanReceipts).HasConstraintName("FK_ACLoanReceipts_BRBranchs");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.AcloanReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACLoanReceipts_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcloanReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACLoanReceipts_GECurrencies");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcloanReceipts).HasConstraintName("FK_ACLoanReceipts_PMProjects");
        });

        modelBuilder.Entity<AcloanReceiptInterestRateChange>(entity =>
        {
            entity.HasOne(d => d.FkAcloanReceipt).WithMany(p => p.AcloanReceiptInterestRateChanges).HasConstraintName("FK_ACLoanReceiptInterestRateChanges_ACLoanReceipts");
        });

        modelBuilder.Entity<AcloanReceiptItem>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcloanReceiptItems).HasConstraintName("FK_ACLoanReceiptItems_ACDocuments");

            entity.HasOne(d => d.FkAcloanReceipt).WithMany(p => p.AcloanReceiptItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACLoanReceiptItems_ACLoanReceipts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcloanReceiptItems).HasConstraintName("FK_ACLoanReceiptItems_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcloanReceiptItems).HasConstraintName("FK_ACLoanReceiptItems_GECurrencies");
        });

        modelBuilder.Entity<AcloanReceiptPayDoc>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcloanReceiptPayDocs).HasConstraintName("FK_ACLoanReceiptPayDocs_ACDocuments");

            entity.HasOne(d => d.FkAcloanReceipt).WithMany(p => p.AcloanReceiptPayDocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACLoanReceiptPayDocs_ACLoanReceipts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcloanReceiptPayDocs).HasConstraintName("FK_ACLoanReceiptPayDocs_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcloanReceiptPayDocs).HasConstraintName("FK_ACLoanReceiptPayDocs_GECurrencies");
        });

        modelBuilder.Entity<AcloanReceiptPaymentPlan>(entity =>
        {
            entity.HasOne(d => d.FkAcloanReceipt).WithMany(p => p.AcloanReceiptPaymentPlans).HasConstraintName("FK_ACLoanReceiptPaymentPlans_ACLoanReceipts");
        });

        modelBuilder.Entity<AcloanReceiptType>(entity =>
        {
            entity.HasOne(d => d.FkAcaccountCostExpired).WithMany(p => p.AcloanReceiptTypeFkAcaccountCostExpireds).HasConstraintName("FK_ACLoanReceiptTypes_ACAccountCostExpireds");

            entity.HasOne(d => d.FkAcaccountCost).WithMany(p => p.AcloanReceiptTypeFkAcaccountCosts).HasConstraintName("FK_ACLoanReceiptTypes_ACAccountCosts");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcloanReceiptTypeFkAcaccounts).HasConstraintName("FK_ACLoanReceiptTypes_ACAccounts");
        });

        modelBuilder.Entity<AcmoneyChange>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcmoneyChanges).HasConstraintName("FK_ACMoneyChanges_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.AcmoneyChangeFkHremployeeApproveds).HasConstraintName("FK_ACMoneyChanges_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployeeCompleted).WithMany(p => p.AcmoneyChangeFkHremployeeCompleteds).HasConstraintName("FK_ACMoneyChanges_HREmployeeCompleteds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AcmoneyChangeFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACMoneyChanges_HREmployees");
        });

        modelBuilder.Entity<AcmoneyChangeItem>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcmoneyChangeItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACMoneyChangeItems_ACAccounts");

            entity.HasOne(d => d.FkAcmoneyChange).WithMany(p => p.AcmoneyChangeItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACMoneyChangeItems_ACMoneyChanges");

            entity.HasOne(d => d.FkCscashFund).WithMany(p => p.AcmoneyChangeItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACMoneyChangeItems_CSCashFunds");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.AcmoneyChangeItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACMoneyChangeItems_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcmoneyChangeItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACMoneyChangeItems_GECurrencies");
        });

        modelBuilder.Entity<AcrelativeDocument>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AcrelativeDocumentFkAcdocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRelativeDocuments_ACDocuments");

            entity.HasOne(d => d.FkAcrelativeDocument).WithMany(p => p.AcrelativeDocumentFkAcrelativeDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRelativeDocuments_ACDocuments1");
        });

        modelBuilder.Entity<AcretailVat>(entity =>
        {
            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.AcretailVats).HasConstraintName("FK_ACRetailVATs_ACEInvoiceTypes");

            entity.HasOne(d => d.FkActaxUnit).WithMany(p => p.AcretailVats).HasConstraintName("FK_ACRetailVATs_ACTaxUnits");

            entity.HasOne(d => d.FkArseller).WithMany(p => p.AcretailVatFkArsellers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRetailVATs_HREmployees1");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcretailVats).HasConstraintName("FK_ACRetailVATs_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcretailVats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRetailVATs_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AcretailVatFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRetailVATs_HREmployees");
        });

        modelBuilder.Entity<AcretailVatitem>(entity =>
        {
            entity.HasOne(d => d.FkAcretailVat).WithMany(p => p.AcretailVatitems).HasConstraintName("FK_ACRetailVATItems_ACRetailVATs");

            entity.HasOne(d => d.FkArinvoiceItem).WithMany(p => p.AcretailVatitems).HasConstraintName("FK_ACRetailVATItems_ARInvoiceItems");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AcretailVatitems).HasConstraintName("FK_ACRetailVATItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcretailVatitems).HasConstraintName("FK_ACRetailVATItems_ICProducts");
        });

        modelBuilder.Entity<AcrevenueBudget>(entity =>
        {
            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcrevenueBudgets).HasConstraintName("FK_ACRevenueBudgets_GECurrency");
        });

        modelBuilder.Entity<AcrevenueBudgetDetail>(entity =>
        {
            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AcrevenueBudgetDetailFkAccreditAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRevenueBudgetDetails_ACCreditAccount");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AcrevenueBudgetDetailFkAcdebitAccounts).HasConstraintName("FK_ACRevenueBudgetDetails_ACDebitAccount");

            entity.HasOne(d => d.FkAcrevenueBudget).WithMany(p => p.AcrevenueBudgetDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRevenueBudgetDetails_ACRevenueBudget");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.AcrevenueBudgetDetails).HasConstraintName("FK_ACRevenueBudgetDetails_ARCustomer");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcrevenueBudgetDetails).HasConstraintName("FK_ACRevenueBudgetDetails_BRBranch");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcrevenueBudgetDetails).HasConstraintName("FK_ACRevenueBudgetDetails_GECurrency");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.AcrevenueBudgetDetails).HasConstraintName("FK_ACRevenueBudgetDetails_GELocation");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcrevenueBudgetDetails).HasConstraintName("FK_ACRevenueBudgetDetails_HRDepartment");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.AcrevenueBudgetDetails).HasConstraintName("FK_ACRevenueBudgetDetails_ICDepartment");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.AcrevenueBudgetDetails).HasConstraintName("FK_ACRevenueBudgetDetails_ICProductGroup");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcrevenueBudgetDetails).HasConstraintName("FK_ACRevenueBudgetDetails_ICProduct");
        });

        modelBuilder.Entity<AcsalaryCalculation>(entity =>
        {
            entity.HasOne(d => d.FkAcsalaryDocumentType).WithMany(p => p.AcsalaryCalculations).HasConstraintName("FK_ACSalaryCalculations_ACSalaryDocumentTypes");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcsalaryCalculations).HasConstraintName("FK_ACSalaryCalculations_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcsalaryCalculations).HasConstraintName("FK_ACSalaryCalculations_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AcsalaryCalculations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSalaryCalculations_HREmployees");
        });

        modelBuilder.Entity<AcsalaryCalculationDetail>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AcsalaryCalculationDetailFkAccreditAccounts).HasConstraintName("FK_ACSalaryCalculationDetails_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AcsalaryCalculationDetailFkAcdebitAccounts).HasConstraintName("FK_ACSalaryCalculationDetails_ACAccounts");

            entity.HasOne(d => d.FkAcsalaryCalculation).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_ACSalaryCalculations");

            entity.HasOne(d => d.FkAcsalaryEntryType).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_ACSalaryEntryTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_ACSegments");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_GECurrencies");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_HRDepartmentRooms");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AcsalaryCalculationDetails).HasConstraintName("FK_ACSalaryCalculationDetails_PMProjects");
        });

        modelBuilder.Entity<AcsalaryDocumentTypePayRollDetail>(entity =>
        {
            entity.HasKey(e => e.AcsalaryDocumentTypePayRollDetailId).HasName("PK_ACSalaryDocumentTypePayRollDetail");

            entity.HasOne(d => d.FkAcsalaryDocumentType).WithMany(p => p.AcsalaryDocumentTypePayRollDetails).HasConstraintName("FK_ACSalaryDocumentTypePayRollDetails_ACSalaryDocumentTypes");
        });

        modelBuilder.Entity<AcsalaryEntryTypeDetail>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AcsalaryEntryTypeDetails).HasConstraintName("FK_ACSalaryEntryTypeDetails_ACCostCenters");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AcsalaryEntryTypeDetailFkAccreditAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSalaryEntryTypeDetails_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AcsalaryEntryTypeDetailFkAcdebitAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSalaryEntryTypeDetails_ACAccounts");

            entity.HasOne(d => d.FkAcsalaryDocumentType).WithMany(p => p.AcsalaryEntryTypeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSalaryEntryTypeDetails_ACSalaryDocumentTypes");

            entity.HasOne(d => d.FkAcsalaryEntryType).WithMany(p => p.AcsalaryEntryTypeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSalaryEntryTypeDetails_ACSalaryEntryTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcsalaryEntryTypeDetails).HasConstraintName("FK_ACSalaryEntryTypeDetails_ACSegments");
        });

        modelBuilder.Entity<AcsalaryEntryTypeDetailPart>(entity =>
        {
            entity.HasOne(d => d.FkAcsalaryEntryType).WithMany(p => p.AcsalaryEntryTypeDetailParts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSalaryEntryTypeDetailParts_ACSalaryEntryTypes");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AcsalaryEntryTypeDetailParts).HasConstraintName("FK_ACSalaryEntryTypeDetailParts_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AcsalaryEntryTypeDetailParts).HasConstraintName("FK_ACSalaryEntryTypeDetailParts_HRDepartmentRooms");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.AcsalaryEntryTypeDetailParts).HasConstraintName("FK_ACSalaryEntryTypeDetailParts_HRLevels");
        });

        modelBuilder.Entity<Acsegment>(entity =>
        {
            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.Acsegments).HasConstraintName("FK_ACSegments_ACAccounts");

            entity.HasOne(d => d.FkAdtargetReportBudget).WithMany(p => p.Acsegments).HasConstraintName("FK_ACSegments_ADTargetReportBudgets");
        });

        modelBuilder.Entity<AcsegmentDocumentControl>(entity =>
        {
            entity.HasOne(d => d.FkAcdocumentType).WithMany(p => p.AcsegmentDocumentControls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSegmentDocumentControls_ACDocumentType");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcsegmentDocumentControls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSegmentDocumentControls_ACSegment");
        });

        modelBuilder.Entity<AcsegmentObjectControl>(entity =>
        {
            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AcsegmentObjectControls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACSegmentObjectControls_ACSegment");
        });

        modelBuilder.Entity<AcstopAllocationEquipment>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcstopAllocationEquipments).HasConstraintName("FK_ACStopAllocationEquipments_BRBranchID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AcstopAllocationEquipments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACStopAllocationEquipments_ICProductID");

            entity.HasOne(d => d.FkIcproductIdentifiedEquipment).WithMany(p => p.AcstopAllocationEquipments).HasConstraintName("FK_ACStopAllocationEquipments_ICProductIdentifiedEquipmentID");
        });

        modelBuilder.Entity<AcstopDepreciationAsset>(entity =>
        {
            entity.HasOne(d => d.FkAcasset).WithMany(p => p.AcstopDepreciationAssets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACStopDepreciationAssets_ACAssets");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AcstopDepreciationAssets).HasConstraintName("FK_ACStopDepreciationAssets_BRBranchID");
        });

        modelBuilder.Entity<ActaxUnit>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ActaxUnits).HasConstraintName("FK_ACTaxUnits_BRBranchs");
        });

        modelBuilder.Entity<Actransaction>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.ActransactionFkAcaccounts).HasConstraintName("FK_ACTransactions_ACAccounts1");

            entity.HasOne(d => d.FkAcoffsetAccount).WithMany(p => p.ActransactionFkAcoffsetAccounts).HasConstraintName("FK_ACTransactions_ACAccounts2");
        });

        modelBuilder.Entity<AcunfinishedConstructionCost>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.AcunfinishedConstructionCosts).HasConstraintName("FK_ACUnfinishedConstructionCosts_ACAccount");
        });

        modelBuilder.Entity<Acvat>(entity =>
        {
            entity.HasKey(e => e.Acvatid).HasName("PK_ACVATID");
        });

        modelBuilder.Entity<AdappUserPermission>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.AdappUserPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADAppUserPermissions_ADUserGroups");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AdappUserPermissions).HasConstraintName("FK_ADAppUserPermissions_BRBranchs");
        });

        modelBuilder.Entity<AdcompletePermissionConfig>(entity =>
        {
            entity.HasKey(e => e.AdcompletePermissionConfigId).HasName("PK_FAADCompletePermissionConfigs");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.AdcompletePermissionConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADCompletePermissionConfigs_ADUserGroups");
        });

        modelBuilder.Entity<AdconfigValue>(entity =>
        {
            entity.HasKey(e => e.AdconfigValueId).HasName("PK_ADNewConfigValue");
        });

        modelBuilder.Entity<Adcriteria>(entity =>
        {
            entity.HasOne(d => d.FkAduser).WithMany(p => p.Adcriteria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADCriterias_ADUsers");

            entity.HasOne(d => d.FkStmodule).WithMany(p => p.Adcriteria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADCriterias_STModules");
        });

        modelBuilder.Entity<AddataViewPermission>(entity =>
        {
            entity.HasOne(d => d.FkAduser).WithMany(p => p.AddataViewPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADDataViewPermissions_ADUsers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AddataViewPermissions).HasConstraintName("FK_ADDataViewPermissions_BRBranchs");
        });

        modelBuilder.Entity<AddataViewPermissionAppStaff>(entity =>
        {
            entity.HasOne(d => d.FkAdgroupAppStaff).WithMany(p => p.AddataViewPermissionAppStaffs).HasConstraintName("FK_ADDataViewPermissionAppStaffs_ADGroupAppStaffs");

            entity.HasOne(d => d.FkAdprivilegeAppSatff).WithMany(p => p.AddataViewPermissionAppStaffs).HasConstraintName("FK_ADDataViewPermissionAppStaffs_ADPrivilegeAppSatffs");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AddataViewPermissionAppStaffs).HasConstraintName("FK_ADDataViewPermissionAppStaffs_BRBranchs");

            entity.HasOne(d => d.FkHremployeeGroupAppStaff).WithMany(p => p.AddataViewPermissionAppStaffs).HasConstraintName("FK_ADDataViewPermissionAppStaffs_HREmployeeGroupAppStaffs");
        });

        modelBuilder.Entity<Adfunction>(entity =>
        {
            entity.HasKey(e => e.AdfunctionId).HasName("PK_ADFonction");
        });

        modelBuilder.Entity<AdgroupAppStaff>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AdgroupAppStaffs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADGroupAppStaffs_BRBranchs");
        });

        modelBuilder.Entity<AdgroupTimeSheetPermission>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.AdgroupTimeSheetPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADGroupTimeSheetPermissions_ADUserGroups");

            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.AdgroupTimeSheetPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADGroupTimeSheetPermissions_HREmployeePayrollFormulas");
        });

        modelBuilder.Entity<Adhistory>(entity =>
        {
            entity.HasKey(e => e.AdhistoryId).HasName("PK_ADHistory");

            entity.Property(e => e.AdhistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.AdhistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.AdhistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<AdhistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkAdhistory).WithMany(p => p.AdhistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADHistoryDetails_ADHistory");
        });

        modelBuilder.Entity<Adinsurrance>(entity =>
        {
            entity.Property(e => e.AdinsurranceSyndicatePaymentPercent).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<AdmigrationScript>(entity =>
        {
            entity.Property(e => e.AdmigrationScriptId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdmoduleFieldsToUser>(entity =>
        {
            entity.HasKey(e => e.AdmoduleFieldsToUserId).HasName("PK_ADFieldModuleToUsers");

            entity.Property(e => e.Aastat).IsFixedLength();

            entity.HasOne(d => d.Aduser).WithMany(p => p.AdmoduleFieldsToUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUsers_ADModuleFieldsToUsers");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.AdmoduleFieldsToUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STModules_ADModuleFieldsToUsers");
        });

        modelBuilder.Entity<AdobjectViewPermission>(entity =>
        {
            entity.HasOne(d => d.FkStmodule).WithMany(p => p.AdobjectViewPermissions).HasConstraintName("FK_ADObjectViewPermissions_STModules");
        });

        modelBuilder.Entity<Adprivilege>(entity =>
        {
            entity.HasOne(d => d.AdprivilegeGroup).WithMany(p => p.Adprivileges).HasConstraintName("FK8q87jdgbavyk6x4s9dtwwfoyt");

            entity.HasOne(d => d.FkStmodule).WithMany(p => p.Adprivileges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADPrivileges_STModules");
        });

        modelBuilder.Entity<AdprivilegeDetail>(entity =>
        {
            entity.HasKey(e => e.ArprivilegeDetailId).HasName("PK__ADPrivil__F4576F3435F7090A");

            entity.HasOne(d => d.FkAdprivilege).WithMany(p => p.AdprivilegeDetails).HasConstraintName("FKn9620eqpou5v7d2a18owqx9vv");
        });

        modelBuilder.Entity<AdprivilegeGroup>(entity =>
        {
            entity.HasKey(e => e.AdprivilegeGroupId).HasName("PK__ADPrivil__C5A8B51587AE31E7");
        });

        modelBuilder.Entity<AdprivilegeUserGroup>(entity =>
        {
            entity.HasOne(d => d.FkAdprivilege).WithMany(p => p.AdprivilegeUserGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADPrivilegeUserGroups_ADPrivileges");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.AdprivilegeUserGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADPrivilegeUserGroups_ADUserGroups");
        });

        modelBuilder.Entity<AdpushNotification>(entity =>
        {
            entity.HasOne(d => d.FkAduser).WithMany(p => p.AdpushNotifications).HasConstraintName("FK_ADPushNotifications_ADUsers");
        });

        modelBuilder.Entity<AdremindWorking>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AdremindWorkings).HasConstraintName("PK_ADRemindWorkings_Departments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AdremindWorkings).HasConstraintName("PK_ADRemindWorkings_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AdremindWorkings).HasConstraintName("PK_ADRemindWorkings_Employees");
        });

        modelBuilder.Entity<Adreport>(entity =>
        {
            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.Adreports)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADReports_GELanguages");
        });

        modelBuilder.Entity<AdreportPermission>(entity =>
        {
            entity.HasOne(d => d.FkAdreport).WithMany(p => p.AdreportPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADReportPermissions_ADReports");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.AdreportPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADReportPermissions_ADUserGroups");
        });

        modelBuilder.Entity<AdreportViewRefParam>(entity =>
        {
            entity.HasOne(d => d.FkAdreportViewRef).WithMany(p => p.AdreportViewRefParams).HasConstraintName("FK_ADReportViewRefParams_ADReportViewRefs");
        });

        modelBuilder.Entity<AdtargetReportBudget>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AdtargetReportBudgets).HasConstraintName("FK_ADTargetReportBudgets_ACCostCenters");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AdtargetReportBudgetFkAccreditAccounts).HasConstraintName("FK_ADTargetReportBudgets_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AdtargetReportBudgetFkAcdebitAccounts).HasConstraintName("FK_ADTargetReportBudgets_ACAccounts");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AdtargetReportBudgets).HasConstraintName("FK_ADTargetReportBudgets_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AdtargetReportBudgets).HasConstraintName("FK_ADTargetReportBudgets_HRDepartmentRooms");
        });

        modelBuilder.Entity<Aduser>(entity =>
        {
            entity.HasKey(e => e.AduserId).HasName("PK_User");

            entity.HasOne(d => d.AduserGroup).WithMany(p => p.Adusers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUsers_ADUserGroups");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Adusers).HasConstraintName("FK_ADUsers_HREmployees");
        });

        modelBuilder.Entity<AduserDevice>(entity =>
        {
            entity.HasKey(e => e.AduserDeviceId).HasName("PK__ADUserDe__CC45570AA2C240A0");

            entity.HasOne(d => d.FkAduser).WithMany(p => p.AduserDevices).HasConstraintName("FKpbv5soxk9lr0t4ema27f1v63v");
        });

        modelBuilder.Entity<AduserGroup>(entity =>
        {
            entity.HasKey(e => e.AduserGroupId).HasName("PK_UserGroup");

            entity.HasOne(d => d.AdlanguageIdcomboNavigation).WithMany(p => p.AduserGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUserGroups_GELanguages");
        });

        modelBuilder.Entity<AduserGroupFunction>(entity =>
        {
            entity.HasOne(d => d.FkAdfunctionWeb).WithMany(p => p.AduserGroupFunctions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUserGroupFunctions_ADFunctionWebs");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.AduserGroupFunctions).HasConstraintName("FK_ADUserGroupFunctions_ADUserGroups");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.AduserGroupFunctions).HasConstraintName("FK_ADUserGroupFunctions_HRGroups");
        });

        modelBuilder.Entity<AduserGroupMember>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.AduserGroupMembers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUserGroupMembers_ADUserGroups");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AduserGroupMembers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUserGroupMembers_HREmployees");
        });

        modelBuilder.Entity<AduserGroupSection>(entity =>
        {
            entity.HasKey(e => e.AduserGroupSectionId).HasName("PK_UserGroupApplication");

            entity.HasOne(d => d.AduserGroup).WithMany(p => p.AduserGroupSections).HasConstraintName("FK_ADUserGroupSection_ADUserGroup");
        });

        modelBuilder.Entity<AduserGroupSectionLanguage>(entity =>
        {
            entity.HasKey(e => e.AduserGroupSectionLanguageId).HasName("PK_UserGroupSectionLanguage");
        });

        modelBuilder.Entity<AduserLocation>(entity =>
        {
            entity.HasOne(d => d.FkAduser).WithMany(p => p.AduserLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUserLocations_ADUsers");
        });

        modelBuilder.Entity<AdworkingShift>(entity =>
        {
            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.AdworkingShifts).HasConstraintName("FK_ADWorkingShifts_HRTimeSheetParams");
        });

        modelBuilder.Entity<AggregatedCounter>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<ApallocationCost>(entity =>
        {
            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.ApallocationCosts).HasConstraintName("APAllocationCosts_APPurchaseOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApallocationCosts).HasConstraintName("FK_APAllocationCosts_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApallocationCosts).HasConstraintName("FK_APAllocationCosts_HREmployees");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ApallocationCosts).HasConstraintName("APAllocationCosts_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.ApallocationCosts).HasConstraintName("APAllocationCosts_MMOperations");
        });

        modelBuilder.Entity<ApallocationCostItem>(entity =>
        {
            entity.HasOne(d => d.FkApallocationCost).WithMany(p => p.ApallocationCostItems).HasConstraintName("FK_APAllocationCostItems_APAllocationCosts");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApallocationCostItems).HasConstraintName("FK_APAllocationCostItems_APInvoiceIns");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.ApallocationCostItems).HasConstraintName("APAllocationCostItems_APPurchaseOrders");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApallocationCostItems).HasConstraintName("FK_APAllocationCostItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ApallocationCostItems).HasConstraintName("FK_APAllocationCostItems_ICProductSeries");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.ApallocationCostItems).HasConstraintName("FK_APAllocationCostItems_ICReceipts");

            entity.HasOne(d => d.FkIcreceiptItem).WithMany(p => p.ApallocationCostItems).HasConstraintName("FK_APAllocationCostItems_ICReceiptItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ApallocationCostItems).HasConstraintName("FK_APAllocationCostItems_ICStocks");
        });

        modelBuilder.Entity<ApallocationCostItemInvoice>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApallocationCostItemInvoices).HasConstraintName("FK_APAllocationCostItemInvoices_ACDocuments");

            entity.HasOne(d => d.FkApallocationCost).WithMany(p => p.ApallocationCostItemInvoices).HasConstraintName("FK_APAllocationCostItemInvoices_APAllocationCosts");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApallocationCostItemInvoices).HasConstraintName("FK_APAllocationCostItemInvoices_APInvoiceIns");
        });

        modelBuilder.Entity<ApallocationCostItemInvoiceIn>(entity =>
        {
            entity.HasOne(d => d.FkApallocationCost).WithMany(p => p.ApallocationCostItemInvoiceIns).HasConstraintName("FK_APAllocationCostItemInvoiceIns_APAllocationCosts");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApallocationCostItemInvoiceIns).HasConstraintName("FK_APAllocationCostItemInvoiceIns_APInvoiceIns");
        });

        modelBuilder.Entity<ApallocationCostItemShipment>(entity =>
        {
            entity.HasOne(d => d.FkApallocationCost).WithMany(p => p.ApallocationCostItemShipments).HasConstraintName("FK_APAllocationCostItemShipments_APAllocationCosts");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.ApallocationCostItemShipments).HasConstraintName("FK_APAllocationCostItemShipments_ICShipments");
        });

        modelBuilder.Entity<ApbillOfLading>(entity =>
        {
            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApbillOfLadings).HasConstraintName("FK_APBillOfLadings_APInvoiceIns");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ApbillOfLadings).HasConstraintName("FK_APBillOfLadings_ARInvoices");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApbillOfLadings).HasConstraintName("FK_APBillOfLadings_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApbillOfLadings).HasConstraintName("FK_APBillOfLadings_GECurrencys");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.ApbillOfLadings).HasConstraintName("FK_APBillOfLadings_GEPaymentTerms");
        });

        modelBuilder.Entity<ApbillOfLadingItem>(entity =>
        {
            entity.HasOne(d => d.FkApbillOfLading).WithMany(p => p.ApbillOfLadingItems).HasConstraintName("FK_APBillOfLadingItems_APBillOfLadings");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ApbillOfLadingItems).HasConstraintName("FK_APBillOfLadingItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApbillOfLadingItems).HasConstraintName("FK_APBillOfLadingItems_ICProducts");
        });

        modelBuilder.Entity<ApcancelPurchaseOrder>(entity =>
        {
            entity.HasOne(d => d.FkAppurchaseContract).WithMany(p => p.ApcancelPurchaseOrders).HasConstraintName("FK_APCancelPurchaseOrders_APPurchaseContracts");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApcancelPurchaseOrders).HasConstraintName("FK_APCancelPurchaseOrders_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApcancelPurchaseOrders).HasConstraintName("FK_APCancelPurchaseOrders_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApcancelPurchaseOrders).HasConstraintName("FK_APCancelPurchaseOrders_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApcancelPurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseOrders_HREmployees");
        });

        modelBuilder.Entity<ApcancelPurchaseOrderItem>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ApcancelPurchaseOrderItems).HasConstraintName("FK_APCancelPurchaseOrderItems_ACCostCenters");

            entity.HasOne(d => d.FkApcancelPurchaseOrder).WithMany(p => p.ApcancelPurchaseOrderItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseOrderItems_APCancelPurchaseOrders");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ApcancelPurchaseOrderItems).HasConstraintName("FK_APCancelPurchaseOrderItems_ARSaleOrders");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ApcancelPurchaseOrderItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseOrderItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ApcancelPurchaseOrderItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseOrderItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ApcancelPurchaseOrderItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseOrderItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApcancelPurchaseOrderItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseOrderItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ApcancelPurchaseOrderItems).HasConstraintName("FK_APCancelPurchaseOrderItems_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ApcancelPurchaseOrderItems).HasConstraintName("FK_APCancelPurchaseOrderItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.ApcancelPurchaseOrderItemFkMmfromOperations).HasConstraintName("FK_APCancelPurchaseOrderItems_MMOperations1");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.ApcancelPurchaseOrderItemFkMmtoOperations).HasConstraintName("FK_APCancelPurchaseOrderItems_MMOperations2");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ApcancelPurchaseOrderItems).HasConstraintName("FK_APCancelPurchaseOrderItems_PMProjects");
        });

        modelBuilder.Entity<ApcancelPurchaseProposal>(entity =>
        {
            entity.HasOne(d => d.FkApproposal).WithMany(p => p.ApcancelPurchaseProposals).HasConstraintName("FK_APCancelPurchaseProposals_APProposals");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApcancelPurchaseProposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseProposals_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.ApcancelPurchaseProposals).HasConstraintName("FK_APCancelPurchaseProposals_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.ApcancelPurchaseProposals).HasConstraintName("FK_APCancelPurchaseProposals_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApcancelPurchaseProposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseProposals_HREmployees");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ApcancelPurchaseProposals).HasConstraintName("FK_APCancelPurchaseProposals_MMBatchProducts");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.ApcancelPurchaseProposals).HasConstraintName("FK_APCancelPurchaseProposals_MMPurchasePlans");
        });

        modelBuilder.Entity<ApcancelPurchaseProposalItem>(entity =>
        {
            entity.HasOne(d => d.FkApcancelPurchaseProposal).WithMany(p => p.ApcancelPurchaseProposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseProposalItems_APCancelPurchaseProposals");

            entity.HasOne(d => d.FkApproposal).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_APProposals");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_BRBranchs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ApcancelPurchaseProposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ApcancelPurchaseProposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcprodAttPackingMaterialWeightPerVolume).WithMany(p => p.ApcancelPurchaseProposalItemFkIcprodAttPackingMaterialWeightPerVolumes).HasConstraintName("FK_APCancelPurchaseProposalItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.ApcancelPurchaseProposalItemFkIcproductAttributeQualities).HasConstraintName("FK_APCancelPurchaseProposalItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ApcancelPurchaseProposalItemFkIcproductAttributeTtmts).HasConstraintName("FK_APCancelPurchaseProposalItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.ApcancelPurchaseProposalItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_APCancelPurchaseProposalItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.ApcancelPurchaseProposalItemFkIcproductForBatches).HasConstraintName("FK_APCancelPurchaseProposalItems_ICProducts_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ApcancelPurchaseProposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApcancelPurchaseProposalItemFkIcproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APCancelPurchaseProposalItems_ICProducts");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_MMAllocationProposals");

            entity.HasOne(d => d.FkMmallocationProposalItem).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_MMAllocationProposalItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.ApcancelPurchaseProposalItemFkMmfromOperations).HasConstraintName("FK_APCancelPurchaseProposalItems_MMOperations1");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_MMPurchasePlans");

            entity.HasOne(d => d.FkMmpurchasePlanItem).WithMany(p => p.ApcancelPurchaseProposalItems).HasConstraintName("FK_APCancelPurchaseProposalItems_MMPurchasePlanItems");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.ApcancelPurchaseProposalItemFkMmtoOperations).HasConstraintName("FK_APCancelPurchaseProposalItems_MMOperations2");
        });

        modelBuilder.Entity<ApclearInvoiceIn>(entity =>
        {
            entity.HasOne(d => d.FkAcaccountPurchase).WithMany(p => p.ApclearInvoiceIns).HasConstraintName("FK_APClearInvoiceIns_ACAccounts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApclearInvoiceIns).HasConstraintName("FK_APClearInvoiceIns_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApclearInvoiceIns).HasConstraintName("FK_APClearInvoiceIns_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApclearInvoiceIns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APClearInvoiceIns_HREmployees");
        });

        modelBuilder.Entity<ApclearInvoiceInDocument>(entity =>
        {
            entity.HasOne(d => d.FkApclearInvoiceIn).WithMany(p => p.ApclearInvoiceInDocuments).HasConstraintName("FK_APClearInvoiceInDocuments_APClearInvoiceIns");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApclearInvoiceInDocuments).HasConstraintName("FK_APClearInvoiceInDocuments_GECurrencies");
        });

        modelBuilder.Entity<ApclearInvoiceInInvoiceIn>(entity =>
        {
            entity.HasOne(d => d.FkApclearInvoiceIn).WithMany(p => p.ApclearInvoiceInInvoiceIns).HasConstraintName("FK_APClearInvoiceInInvoiceIns_APClearInvoiceIns");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApclearInvoiceInInvoiceIns).HasConstraintName("FK_APClearInvoiceInInvoiceIns_APInvoiceIns");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApclearInvoiceInInvoiceIns).HasConstraintName("FK_APClearInvoiceInInvoiceIns_GECurrencies");
        });

        modelBuilder.Entity<ApclearingDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcbankTransaction).WithMany(p => p.ApclearingDetails).HasConstraintName("FK_APClearingDetails_ACBankTransactions");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApclearingDetails).HasConstraintName("FK_APClearingDetails_APInvoiceIns");

            entity.HasOne(d => d.FkAppaymentProposal).WithMany(p => p.ApclearingDetails).HasConstraintName("FK_APClearingDetails_APPaymentProposals");

            entity.HasOne(d => d.FkAppaymentVoucher).WithMany(p => p.ApclearingDetails).HasConstraintName("FK_APClearingDetails_APPaymentVouchers");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.ApclearingDetails).HasConstraintName("FK_APClearingDetails_APPurchaseOrders");

            entity.HasOne(d => d.FkAppurchaseOrderPaymentTime).WithMany(p => p.ApclearingDetails).HasConstraintName("FK_APClearingDetails_APPurchaseOrderPaymentTimes");

            entity.HasOne(d => d.FkApsupplierPayment).WithMany(p => p.ApclearingDetails).HasConstraintName("FK_APClearingDetails_APSupplierPayments");
        });

        modelBuilder.Entity<ApdocumentPayment>(entity =>
        {
            entity.HasOne(d => d.FkApopenDocument).WithMany(p => p.ApdocumentPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APDocumentPayments_APOpenDocuments");

            entity.HasOne(d => d.FkApsupplierPayment).WithMany(p => p.ApdocumentPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APDocumentPayments_APSupplierPaymentID");
        });

        modelBuilder.Entity<ApfeePaymentFeeConfig>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ApfeePaymentFeeConfigs).HasConstraintName("FK_APFeePaymentFeeConfigs_ACCostCenters");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApfeePaymentFeeConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentFeeConfigs_ACDocuments");

            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.ApfeePaymentFeeConfigs).HasConstraintName("FK_APFeePaymentFeeConfigs_ACEInvoiceTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.ApfeePaymentFeeConfigs).HasConstraintName("FK_APFeePaymentFeeConfigs_ACSegments");

            entity.HasOne(d => d.FkGecontainer).WithMany(p => p.ApfeePaymentFeeConfigs).HasConstraintName("FK_APFeePaymentFeeConfigs_GEContainers");

            entity.HasOne(d => d.FkGeterminal).WithMany(p => p.ApfeePaymentFeeConfigs).HasConstraintName("FK_APFeePaymentFeeConfigs_GETerminals");

            entity.HasOne(d => d.FkGeunitCost).WithMany(p => p.ApfeePaymentFeeConfigs).HasConstraintName("FK_APFeePaymentFeeConfigs_GEUnitCosts");

            entity.HasOne(d => d.FkIcfeeConfig).WithMany(p => p.ApfeePaymentFeeConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentFeeConfigs_ICFeeConfigs");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.ApfeePaymentFeeConfigs).HasConstraintName("FK_APFeePaymentFeeConfigs_VMVehicles");
        });

        modelBuilder.Entity<ApfeePaymentInvoice>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApfeePaymentInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentInvoices_ACDocuments");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ApfeePaymentInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentInvoices_ARInvoices");
        });

        modelBuilder.Entity<ApfeePaymentInvoiceIn>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApfeePaymentInvoiceIns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentInvoiceIns_ACDocuments");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApfeePaymentInvoiceIns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentInvoiceIns_APInvoiceIns");
        });

        modelBuilder.Entity<ApfeePaymentInvoiceInternalReceipt>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApfeePaymentInvoiceInternalReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentInvoiceInternalReceipts_ACDocuments");

            entity.HasOne(d => d.FkIcinvoiceInternalReceipt).WithMany(p => p.ApfeePaymentInvoiceInternalReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentInvoiceInternalReceipts_ICInvoiceInternalReceipts");
        });

        modelBuilder.Entity<ApfeePaymentItem>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.ApfeePaymentItems).HasConstraintName("FK_APFeePaymentItems_ACAccounts");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApfeePaymentItems).HasConstraintName("FK_APFeePaymentItems_ACDocuments");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApfeePaymentItems).HasConstraintName("FK_APFeePaymentItems_ICProducts");
        });

        modelBuilder.Entity<ApfeePaymentPurchaseOrder>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApfeePaymentPurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentPurchaseOrders_ACDocuments");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.ApfeePaymentPurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentPurchaseOrders_APPurchaseOrders");
        });

        modelBuilder.Entity<ApfeePaymentReceipt>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApfeePaymentReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentReceipts_ACDocuments");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.ApfeePaymentReceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentReceipts_ICReceipts");
        });

        modelBuilder.Entity<ApfeePaymentTransfer>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ApfeePaymentTransfers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentTransfers_ACDocuments");

            entity.HasOne(d => d.FkIctransfer).WithMany(p => p.ApfeePaymentTransfers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APFeePaymentTransfers_ICTransfers");
        });

        modelBuilder.Entity<Aphistory>(entity =>
        {
            entity.HasKey(e => e.AphistoryId).HasName("PK_APHistory");

            entity.Property(e => e.AphistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.AphistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.AphistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<AphistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkAphistory).WithMany(p => p.AphistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APHistoryDetails_APHistory");
        });

        modelBuilder.Entity<ApinvoiceIn>(entity =>
        {
            entity.Property(e => e.ApinvoiceInActiveCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.ApinvoiceIns).HasConstraintName("FK__APInvoice__FK_AC__40FEFFF4");

            entity.HasOne(d => d.FkAppurchaseContract).WithMany(p => p.ApinvoiceIns).HasConstraintName("FK_APInvoiceIns_APPurchaseContracts");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApinvoiceIns).HasConstraintName("FK_APInvoiceIns_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApinvoiceInFkBrbranches).HasConstraintName("FK_APInvoiceIns_BRBranchs");

            entity.HasOne(d => d.FkBrcreatedBranch).WithMany(p => p.ApinvoiceInFkBrcreatedBranches).HasConstraintName("FK_APInvoiceIns_BRBranchs1");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.ApinvoiceIns).HasConstraintName("FK_APInvoiceIns_GECountrys");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApinvoiceIns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APInvoiceIns_GECurrencies");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.ApinvoiceIns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APInvoiceIns_GELanguages");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.ApinvoiceIns).HasConstraintName("FK_APInvoiceIns_GEShippingMethods");

            entity.HasOne(d => d.FkGeterminal).WithMany(p => p.ApinvoiceIns).HasConstraintName("FK_APInvoiceIns_GETerminals");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApinvoiceIns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APInvoiceIns_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ApinvoiceInFkIcproductAttributeTtmts).HasConstraintName("FK_APInvoiceIns_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.ApinvoiceInFkIcproductAttributeWoodTypes).HasConstraintName("FK_APInvoiceIns_ICProductAttributes1");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ApinvoiceIns).HasConstraintName("FK_APInvoiceIns_ICStocks");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ApinvoiceIns).HasConstraintName("FK_APInvoiceIns_PMProjects");
        });

        modelBuilder.Entity<ApinvoiceInItem>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ACCostCenters");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ACSegments");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_APInvoiceIns");

            entity.HasOne(d => d.FkAppurchaseOrderPaymentTime).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_APPurchaseOrderPaymentTimes");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ARSaleOrders");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_GECountrys");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICModels");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.ApinvoiceInItemFkIcproductAttributeQualities).HasConstraintName("FK_APInvoiceInItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ApinvoiceInItemFkIcproductAttributeTtmts).HasConstraintName("FK_APInvoiceInItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.ApinvoiceInItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_APInvoiceInItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICProducts");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICReceipts");

            entity.HasOne(d => d.FkIcreceiptItem).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICReceiptItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_MMBatchProducts");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.ApinvoiceInItems).HasConstraintName("FK_APInvoiceInItems_VMVehicles");
        });

        modelBuilder.Entity<ApinvoiceInPackageItem>(entity =>
        {
            entity.HasKey(e => e.ApinvoiceInPackageItemId).HasName("PK_MAInvoiceInPackageItem");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApinvoiceInPackageItems).HasConstraintName("FK_APInvoiceInPackageItems_APInvoiceIns");

            entity.HasOne(d => d.FkAppopackageItem).WithMany(p => p.ApinvoiceInPackageItems).HasConstraintName("FK_APInvoiceInPackageItems_APPOPackageItems");
        });

        modelBuilder.Entity<ApinvoiceInPackageItemDetail>(entity =>
        {
            entity.HasKey(e => e.ApinvoiceInPackageItemDetailId).HasName("PK_MAInvoiceInPackageItemDetail");

            entity.HasOne(d => d.FkApinvoiceInPackageItem).WithMany(p => p.ApinvoiceInPackageItemDetails).HasConstraintName("FK_APInvoiceInPackageItemDetails_APInvoiceInPackageItems");

            entity.HasOne(d => d.FkAppopackageItem).WithMany(p => p.ApinvoiceInPackageItemDetails).HasConstraintName("FK_APInvoiceInPackageItemDetails_APPOPackageItems");

            entity.HasOne(d => d.FkIcproductDetail).WithMany(p => p.ApinvoiceInPackageItemDetails).HasConstraintName("FK_APInvoiceInPackageItemDetails_ICProductDetails");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApinvoiceInPackageItemDetails).HasConstraintName("FK_APInvoiceInPackageItemDetails_ICProducts");
        });

        modelBuilder.Entity<ApinvoiceInTransaction>(entity =>
        {
            entity.HasOne(d => d.FkAppurchaseContract).WithMany(p => p.ApinvoiceInTransactions).HasConstraintName("FK_APInvoiceInTransactions_APPurchaseContracts");
        });

        modelBuilder.Entity<ApopenDocument>(entity =>
        {
            entity.Property(e => e.ApopenDocumentIsDiscountPercentCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApopenDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APOpenDocuments_APInvoiceIns");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApopenDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APOpenDocuments_APSuppliers");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApopenDocuments).HasConstraintName("FK_APOpenDocuments_GECurrencies");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.ApopenDocuments).HasConstraintName("FK_APOpenDocuments_GEShippingMethods");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApopenDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APOpenDocuments_HREmployees");
        });

        modelBuilder.Entity<AppaymentProposal>(entity =>
        {
            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_ACSegments");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_APInvoiceIns");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_APPurchaseOrders");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_GECurrencies");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeAccountant).WithMany(p => p.AppaymentProposalFkHremployeeAccountants).HasConstraintName("FK_APPaymentProposals_HREmployeeAccountants");

            entity.HasOne(d => d.FkHremployeeHeadAccountant).WithMany(p => p.AppaymentProposalFkHremployeeHeadAccountants).HasConstraintName("FK_APPaymentProposals_HREmployeeHeadAccountants");

            entity.HasOne(d => d.FkHremployeeHeadDepartment).WithMany(p => p.AppaymentProposalFkHremployeeHeadDepartments).HasConstraintName("FK_APPaymentProposals_HREmployeeHeadDepartments");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AppaymentProposalFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentProposals_HREmployees");

            entity.HasOne(d => d.FkHremployeeManager).WithMany(p => p.AppaymentProposalFkHremployeeManagers).HasConstraintName("FK_APPaymentProposals_HREmployeeManagers");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_ICReceipts");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AppaymentProposals).HasConstraintName("FK_APPaymentProposals_PMProjects");
        });

        modelBuilder.Entity<AppaymentProposalItem>(entity =>
        {
            entity.HasOne(d => d.FkAppaymentProposal).WithMany(p => p.AppaymentProposalItems).HasConstraintName("FK_APPaymentProposalItems_APPaymentProposals");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppaymentProposalItems).HasConstraintName("FK_APPaymentProposalItems_APPurchaseOrders");

            entity.HasOne(d => d.FkAppurchaseOrderPaymentTime).WithMany(p => p.AppaymentProposalItems).HasConstraintName("FK_APPaymentProposalItems_APPurchaseOrderPaymentTimes");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AppaymentProposalItems).HasConstraintName("FK_APPaymentProposalItems_GECurrencies");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.AppaymentProposalItems).HasConstraintName("FK_APPaymentProposalItems_ICReceipts");
        });

        modelBuilder.Entity<AppaymentProposalPayment>(entity =>
        {
            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AppaymentProposalPayments).HasConstraintName("FK_APPaymentProposalPayments_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AppaymentProposalPaymentFkAccreditAccounts).HasConstraintName("FK__APPayment__FK_AC__2C8305FB");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AppaymentProposalPaymentFkAcdebitAccounts).HasConstraintName("FK__APPayment__FK_AC__2B8EE1C2");

            entity.HasOne(d => d.FkAppaymentProposal).WithMany(p => p.AppaymentProposalPayments).HasConstraintName("FK_APPaymentProposalPayments_APPaymentProposal1s");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppaymentProposalPayments).HasConstraintName("FK_APPaymentProposalPayments_APPurchaseOrders");

            entity.HasOne(d => d.FkAppurchaseOrderPaymentTime).WithMany(p => p.AppaymentProposalPayments).HasConstraintName("FK_APPaymentProposalPayments_APPurchaseOrderPaymentTimes");

            entity.HasOne(d => d.FkApsupplierPayment).WithMany(p => p.AppaymentProposalPayments).HasConstraintName("FK_APPaymentProposalPayments_APSupplierPayments");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.AppaymentProposalPayments).HasConstraintName("FK_APPaymentProposalPayments_ICReceipts");
        });

        modelBuilder.Entity<AppaymentVoucher>(entity =>
        {
            entity.HasOne(d => d.FkAcloanReceipt).WithMany(p => p.AppaymentVouchers).HasConstraintName("FK_APPaymentVouchers_ACLoanReceipts");

            entity.HasOne(d => d.FkAcloanReceiptPaymentPlan).WithMany(p => p.AppaymentVouchers).HasConstraintName("FK_APPaymentVouchers_ACLoanReceiptPaymentPlans");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AppaymentVouchers).HasConstraintName("FK_APPaymentVouchers_ACSegments");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AppaymentVouchers).HasConstraintName("FK_APPaymentVouchers_BRBranchs");

            entity.HasOne(d => d.FkCscashFund).WithMany(p => p.AppaymentVouchers).HasConstraintName("FK_APPaymentVouchers_CSCashFunds");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.AppaymentVouchers).HasConstraintName("FK_APPaymentVouchers_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AppaymentVouchers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentVouchers_GECurrencies");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.AppaymentVoucherFkHremployeeApproveds).HasConstraintName("FK_APPaymentVouchers_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployeeCompleted).WithMany(p => p.AppaymentVoucherFkHremployeeCompleteds).HasConstraintName("FK_APPaymentVouchers_HREmployeeCompleted_HREmployees");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AppaymentVoucherFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentVouchers_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AppaymentVouchers).HasConstraintName("FK_APPaymentVouchers_PMProjects");
        });

        modelBuilder.Entity<AppaymentVoucherInvoice>(entity =>
        {
            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AppaymentVoucherInvoices).HasConstraintName("FK_APPaymentVoucherInvoices_ACCostObjects");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.AppaymentVoucherInvoices).HasConstraintName("FK_APPaymentVoucherInvoices_APInvoiceIns");

            entity.HasOne(d => d.FkAppaymentProposal).WithMany(p => p.AppaymentVoucherInvoices).HasConstraintName("FK_APPaymentVoucherInvoices_APPaymentProposal1s");

            entity.HasOne(d => d.FkAppaymentVoucher).WithMany(p => p.AppaymentVoucherInvoices).HasConstraintName("FK_APPaymentVoucherInvoices_APPaymentVouchers");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppaymentVoucherInvoices).HasConstraintName("FK_APPaymentVoucherInvoices_APPurchaseOrders");

            entity.HasOne(d => d.FkAppurchaseOrderPaymentTime).WithMany(p => p.AppaymentVoucherInvoices).HasConstraintName("FK_APPaymentVoucherInvoices_APPurchaseOrderPaymentTimes");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.AppaymentVoucherInvoices).HasConstraintName("FK_APPaymentVoucherInvoices_ARInvoices");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.AppaymentVoucherInvoices).HasConstraintName("FK_APPaymentVoucherInvoices_ICReceipts");
        });

        modelBuilder.Entity<AppaymentVoucherItem>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AppaymentVoucherItemFkAccreditAccounts).HasConstraintName("FK_APPaymentVoucherItems_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AppaymentVoucherItemFkAcdebitAccounts).HasConstraintName("FK_APPaymentVoucherItems_ACAccounts");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.AppaymentVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentVoucherItems_ACEntryTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_ACSegments");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkAppaymentVoucher).WithMany(p => p.AppaymentVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentVoucherItems_APPaymentVouchers");

            entity.HasOne(d => d.FkHradvanceRefund).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_HRAdvanceRefunds");

            entity.HasOne(d => d.FkHradvanceRefundItemInvoice).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_HRAdvanceRefundItemInvoices");

            entity.HasOne(d => d.FkHradvanceRequestItem).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_HRAdvanceRequestItems");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_PMProjects");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.AppaymentVoucherItems).HasConstraintName("FK_APPaymentVoucherItems_VMVehicles");
        });

        modelBuilder.Entity<AppaymentVoucherItemDetail>(entity =>
        {
            entity.HasOne(d => d.FkApbillOfLading).WithMany(p => p.AppaymentVoucherItemDetails).HasConstraintName("FK_APPaymentVoucherItemDetails_APBillOfLadings");

            entity.HasOne(d => d.FkAppaymentVoucher).WithMany(p => p.AppaymentVoucherItemDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentVoucherItemDetails_APPaymentVouchers");
        });

        modelBuilder.Entity<AppopackageItem>(entity =>
        {
            entity.HasKey(e => e.AppopackageItemId).HasName("PK_MAPOPackageItem");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppopackageItems).HasConstraintName("FK_APPOPackageItems_APPurchaseOrders");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AppopackageItems).HasConstraintName("FK_APPOPackageItems_ICProducts");
        });

        modelBuilder.Entity<AppopackageItemDetail>(entity =>
        {
            entity.HasKey(e => e.AppopackageItemDetailId).HasName("PK_MAPOPackageItemDetail");

            entity.HasOne(d => d.FkAppopackageItem).WithMany(p => p.AppopackageItemDetails).HasConstraintName("FK_APPOPackageItemDetails_APPOPackageItems");

            entity.HasOne(d => d.FkIcproductDetail).WithMany(p => p.AppopackageItemDetails).HasConstraintName("FK_APPOPackageItemDetails_ICProductDetails");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AppopackageItemDetails).HasConstraintName("FK_APPOPackageItemDetails_ICProducts");
        });

        modelBuilder.Entity<AppopaymentTimeInvoiceInDetail>(entity =>
        {
            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.AppopaymentTimeInvoiceInDetailFkAccreditAccounts).HasConstraintName("FK_APPOPaymentTimeInvoiceInDetails_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.AppopaymentTimeInvoiceInDetailFkAcdebitAccounts).HasConstraintName("FK_APPOPaymentTimeInvoiceInDetails_ACAccounts");

            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.AppopaymentTimeInvoiceInDetails).HasConstraintName("FK_APPOPaymentTimeInvoiceInDetails_ACDocuments");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.AppopaymentTimeInvoiceInDetails).HasConstraintName("FK_APPOPaymentTimeInvoiceInDetails_APInvoiceIns");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppopaymentTimeInvoiceInDetails).HasConstraintName("FK_APPOPaymentTimeInvoiceInDetails_APPurchaseOrders");

            entity.HasOne(d => d.FkAppurchaseOrderPaymentTime).WithMany(p => p.AppopaymentTimeInvoiceInDetails).HasConstraintName("FK_APPOPaymentTimeInvoiceInDetails_APPurchaseOrderPaymentTimes");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AppopaymentTimeInvoiceInDetails).HasConstraintName("FK_APPOPaymentTimeInvoiceInDetails_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AppopaymentTimeInvoiceInDetails).HasConstraintName("FK_APPOPaymentTimeInvoiceInDetails_GECurrencies");
        });

        modelBuilder.Entity<AppriceSheet>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AppriceSheets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPriceSheets_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AppriceSheets).HasConstraintName("FK_APPriceSheets_GECurrencies");

            entity.HasOne(d => d.FkHrapprovedEmployee).WithMany(p => p.AppriceSheetFkHrapprovedEmployees).HasConstraintName("FK_APPriceSheets_HREmployees_1");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AppriceSheetFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPriceSheets_HREmployees");
        });

        modelBuilder.Entity<AppriceSheetItem>(entity =>
        {
            entity.HasOne(d => d.FkAppriceSheet).WithMany(p => p.AppriceSheetItems).HasConstraintName("FK_APPriceSheetItems_APPriceSheets");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AppriceSheetItems).HasConstraintName("FK_APPriceSheetItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AppriceSheetItems).HasConstraintName("FK_APPriceSheetItems_ICProducts");
        });

        modelBuilder.Entity<Approposal>(entity =>
        {
            entity.HasOne(d => d.ApproposalProposedEmployee).WithMany(p => p.ApproposalApproposalProposedEmployees).HasConstraintName("FK_APProposals_APProposalProposedEmployeeID");

            entity.HasOne(d => d.FkAppurchaseContract).WithMany(p => p.Approposals).HasConstraintName("FK_APProposals_APPurchaseContracts");

            entity.HasOne(d => d.FkAppurchasingStaff).WithMany(p => p.ApproposalFkAppurchasingStaffs).HasConstraintName("FK_APProposals_HREmployees1");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Approposals).HasConstraintName("FK_APProposals_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Approposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposals_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Approposals).HasConstraintName("FK_APProposals_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Approposals).HasConstraintName("FK_APProposals_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApproposalFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposals_HREmployees");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.Approposals).HasConstraintName("FK_APProposals_MMBatchProducts");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.Approposals).HasConstraintName("FK_APProposals_MMPurchasePlans");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Approposals).HasConstraintName("FK_APProposals_PMProjects");
        });

        modelBuilder.Entity<ApproposalItem>(entity =>
        {
            entity.HasOne(d => d.FkApproposal).WithMany(p => p.ApproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposalItems_APProposals");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_APSuppliers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_BRBranchs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ApproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ApproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("APProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcprodAttPackingMaterialWeightPerVolume).WithMany(p => p.ApproposalItemFkIcprodAttPackingMaterialWeightPerVolumes).HasConstraintName("FK_APProposalItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.ApproposalItemFkIcproductAttributeQualities).HasConstraintName("FK_APProposalItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ApproposalItemFkIcproductAttributeTtmts).HasConstraintName("FK_APProposalItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.ApproposalItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_APProposalItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.ApproposalItemFkIcproductForBatches).HasConstraintName("FK_APProposalItems_ICProducts_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ApproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApproposalItemFkIcproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("APProposalItems_ICProducts");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_MMAllocationProposals");

            entity.HasOne(d => d.FkMmallocationProposalItem).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_MMAllocationProposalItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ApproposalItems).HasConstraintName("APProposalItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductInputItem).WithMany(p => p.ApproposalItems).HasConstraintName("APProposalItems_MMBatchProductInputItems");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.ApproposalItemFkMmfromOperations).HasConstraintName("FK_APProposalItems_MMOperations1");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_MMPurchasePlans");

            entity.HasOne(d => d.FkMmpurchasePlanItem).WithMany(p => p.ApproposalItems).HasConstraintName("FK_APProposalItems_MMPurchasePlanItems");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.ApproposalItemFkMmtoOperations).HasConstraintName("FK_APProposalItems_MMOperations2");
        });

        modelBuilder.Entity<ApproposalItemTotal>(entity =>
        {
            entity.HasOne(d => d.FkAcasset).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_ACAssets");

            entity.HasOne(d => d.FkApproposal).WithMany(p => p.ApproposalItemTotals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposalItemTotals_APProposals");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_BRBranchs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ApproposalItemTotals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposalItemTotals_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ApproposalItemTotals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposalItemTotals_ICMeasureUnits");

            entity.HasOne(d => d.FkIcprodAttPackingMaterialWeightPerVolume).WithMany(p => p.ApproposalItemTotalFkIcprodAttPackingMaterialWeightPerVolumes).HasConstraintName("FK_APProposalItemTotals_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.ApproposalItemTotalFkIcproductAttributeQualities).HasConstraintName("FK_APProposalItemTotals_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ApproposalItemTotalFkIcproductAttributeTtmts).HasConstraintName("FK_APProposalItemTotals_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.ApproposalItemTotalFkIcproductAttributeWoodTypes).HasConstraintName("FK_APProposalItemTotals_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.ApproposalItemTotalFkIcproductForBatches).HasConstraintName("FK_APProposalItemTotals_ICProducts_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ApproposalItemTotals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposalItemTotals_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApproposalItemTotalFkIcproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APProposalItemTotals_ICProducts");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_MMAllocationProposals");

            entity.HasOne(d => d.FkMmallocationProposalItem).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_MMAllocationProposalItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.ApproposalItemTotalFkMmfromOperations).HasConstraintName("FK_APProposalItemTotals_MMOperations1");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_MMPurchasePlans");

            entity.HasOne(d => d.FkMmpurchasePlanItemTotal).WithMany(p => p.ApproposalItemTotals).HasConstraintName("FK_APProposalItemTotals_MMPurchasePlanItemTotals");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.ApproposalItemTotalFkMmtoOperations).HasConstraintName("FK_APProposalItemTotals_MMOperations2");
        });

        modelBuilder.Entity<AppurchaseContract>(entity =>
        {
            entity.HasKey(e => e.AppurchaseContractId).HasName("PK_PAAPPurchaseContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AppurchaseContracts).HasConstraintName("FK_APPurchaseContracts_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AppurchaseContracts).HasConstraintName("FK_APPurchaseContracts_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AppurchaseContracts).HasConstraintName("FK_APPurchaseContracts_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AppurchaseContracts).HasConstraintName("FK_APPurchaseContracts_PMProjects");
        });

        modelBuilder.Entity<AppurchaseContractGroup>(entity =>
        {
            entity.HasKey(e => e.AppurchaseContractGroupId).HasName("PK_PurchaseContractGroup");
        });

        modelBuilder.Entity<AppurchaseOrder>(entity =>
        {
            entity.Property(e => e.AppurchaseOrderActiveCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AppurchaseOrderProposedEmployee).WithMany(p => p.AppurchaseOrderAppurchaseOrderProposedEmployees).HasConstraintName("FK_APPurchaseOrders_APPurchaseOrderProposedEmployeeID");

            entity.HasOne(d => d.FkAppurchaseContract).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_APPurchaseContracts");

            entity.HasOne(d => d.FkAppurchasingStaff).WithMany(p => p.AppurchaseOrderFkAppurchasingStaffs).HasConstraintName("FK_APPurchaseOrders_HREmployees1");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_APSuppliers");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_ARCustomers");

            entity.HasOne(d => d.FkArseller).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_ARSellers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_BRBranchs");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_GECountrys");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AppurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPurchaseOrders_GECurrencies");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.AppurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPurchaseOrders_GELanguages");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.AppurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPurchaseOrders_GEPaymentTerms");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_GEShippingMethods");

            entity.HasOne(d => d.FkGeterminal).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_GETerminals");

            entity.HasOne(d => d.FkGevatregion).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_GEVATRegions");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AppurchaseOrderFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPurchaseOrders_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_ICProductAttributes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_MMBatchProducts");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_MMProductionNorms");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.AppurchaseOrders).HasConstraintName("FK_APPurchaseOrders_PMProjects");
        });

        modelBuilder.Entity<AppurchaseOrderHistory>(entity =>
        {
            entity.HasOne(d => d.FkAduser).WithMany(p => p.AppurchaseOrderHistories).HasConstraintName("FK_APPurchaseOrderHistorys_ADUsers");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppurchaseOrderHistories).HasConstraintName("FK_APPurchaseOrderHistorys_APPurchaseOrders");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.AppurchaseOrderHistories).HasConstraintName("FK_APPurchaseOrderHistorys_APSuppliers");
        });

        modelBuilder.Entity<AppurchaseOrderItem>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ACCostCenters");

            entity.HasOne(d => d.FkApproposal).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_APProposals");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_APPurchaseOrders");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_GECountrys");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICDepartments");

            entity.HasOne(d => d.FkIclengthGroup).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICLengthGroups");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICModels");

            entity.HasOne(d => d.FkIcperimeterGroup).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICPerimeterGroups");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.AppurchaseOrderItemFkIcproductAttributeQualities).HasConstraintName("FK_APPurchaseOrderItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.AppurchaseOrderItemFkIcproductAttributeTtmts).HasConstraintName("FK_APPurchaseOrderItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.AppurchaseOrderItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_APPurchaseOrderItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AppurchaseOrderItemFkIcproducts).HasConstraintName("FK_APPurchaseOrderItems_ICProducts");

            entity.HasOne(d => d.FkIcproductThickGroup).WithMany(p => p.AppurchaseOrderItemFkIcproductThickGroups).HasConstraintName("FK_APPurchaseOrderItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_ICStockSlots");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("FK_APPurchaseOrderItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.AppurchaseOrderItemFkMmfromOperations).HasConstraintName("FK_APPurchaseOrderItems_MMOperations1");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.AppurchaseOrderItems).HasConstraintName("APPurchaseOrderItems_MMPurchasePlans");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.AppurchaseOrderItemFkMmtoOperations).HasConstraintName("FK_APPurchaseOrderItems_MMOperations2");
        });

        modelBuilder.Entity<AppurchaseOrderItemDelivery>(entity =>
        {
            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppurchaseOrderItemDeliveries).HasConstraintName("APPurchaseOrderItemDeliverys_FK_APPurchaseOrderID");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AppurchaseOrderItemDeliveries).HasConstraintName("APPurchaseOrderItemDeliverys_FK_ICMeasureUnitID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AppurchaseOrderItemDeliveries).HasConstraintName("APPurchaseOrderItemDeliverys_FK_ICProductID");
        });

        modelBuilder.Entity<AppurchaseOrderItemOutSourcing>(entity =>
        {
            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppurchaseOrderItemOutSourcings).HasConstraintName("APPurchaseOrderItemOutSourcings_APPurchaseOrders");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AppurchaseOrderItemOutSourcings).HasConstraintName("FK_APPurchaseOrderItemOutSourcings_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AppurchaseOrderItemOutSourcings).HasConstraintName("FK_APPurchaseOrderItemOutSourcings_ICProducts");
        });

        modelBuilder.Entity<AppurchaseOrderPaymentTime>(entity =>
        {
            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.AppurchaseOrderPaymentTimes).HasConstraintName("FK_APPurchaseOrderPaymentTimes_APPurchaseOrders");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.AppurchaseOrderPaymentTimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPurchaseOrderPaymentTimes_GEPaymentTerms");

            entity.HasOne(d => d.FkGepaymentTermItem).WithMany(p => p.AppurchaseOrderPaymentTimes).HasConstraintName("FK_APPurchaseOrderPaymentTimes_GEPaymentTermItems");
        });

        modelBuilder.Entity<ApreturnSupplier>(entity =>
        {
            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.ApreturnSuppliers).HasConstraintName("FK_APReturnSuppliers_ACEInvoiceTypes");

            entity.HasOne(d => d.FkAppurchaseContract).WithMany(p => p.ApreturnSuppliers).HasConstraintName("FK_APReturnSuppliers_APPurchaseContracts");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApreturnSuppliers).HasConstraintName("FK_APReturnSuppliers_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApreturnSuppliers).HasConstraintName("FK_APReturnSuppliers_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApreturnSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APReturnSuppliers_GECurrencies");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.ApreturnSuppliers).HasConstraintName("FK_APReturnSuppliers_GEShippingMethods");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApreturnSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APReturnSuppliers_HREmployees");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ApreturnSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APReturnSuppliers_ICStocks");
        });

        modelBuilder.Entity<ApreturnSupplierItem>(entity =>
        {
            entity.HasKey(e => e.ApreturnSupplierItemId).HasName("PK_ReturnSupplierItems");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSuppliers_ACAccounts");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_ACCostCenters");

            entity.HasOne(d => d.FkApinvoiceIn).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_APInvoiceIns");

            entity.HasOne(d => d.FkApinvoiceInItem).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_APInvoiceInItems");

            entity.HasOne(d => d.FkApreturnSupplier).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_APReturnSuppliers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_ARSaleOrders");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_MMBatchProducts");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ApreturnSupplierItems).HasConstraintName("FK_APReturnSupplierItems_PMProjects");
        });

        modelBuilder.Entity<Apsupplier>(entity =>
        {
            entity.HasKey(e => e.ApsupplierId).HasName("PK_Supplier");

            entity.ToTable("APSuppliers", tb => tb.HasTrigger("TRG_InsertUpdateSupplier"));

            entity.Property(e => e.ApsupplierActiveCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ApsupplierBankAccountCurrency1Navigation).WithMany(p => p.ApsupplierApsupplierBankAccountCurrency1Navigations).HasConstraintName("FK_MASuppliers_GECurrencies1");

            entity.HasOne(d => d.ApsupplierBankAccountCurrency2Navigation).WithMany(p => p.ApsupplierApsupplierBankAccountCurrency2Navigations).HasConstraintName("FK_MASuppliers_GECurrencies2");

            entity.HasOne(d => d.ApsupplierBankAccountCurrency3Navigation).WithMany(p => p.ApsupplierApsupplierBankAccountCurrency3Navigations).HasConstraintName("FK_MASuppliers_GECurrencies3");

            entity.HasOne(d => d.ApsupplierBankAccountCurrency4Navigation).WithMany(p => p.ApsupplierApsupplierBankAccountCurrency4Navigations).HasConstraintName("FK_MASuppliers_GECurrencies4");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.ApsupplierFkAcaccounts).HasConstraintName("FK_APSuppliers_ACAccounts");

            entity.HasOne(d => d.FkAcaccountPurchase).WithMany(p => p.ApsupplierFkAcaccountPurchases).HasConstraintName("FK_APSuppliers_ACAccountPurchases");

            entity.HasOne(d => d.FkAcaccountSale).WithMany(p => p.ApsupplierFkAcaccountSales).HasConstraintName("FK_APSuppliers_ACAccountSales");

            entity.HasOne(d => d.FkApsupplierParent).WithMany(p => p.InverseFkApsupplierParent).HasConstraintName("FK_MASuppliers_MASuppliers");

            entity.HasOne(d => d.FkApsupplierTypeAccountConfig).WithMany(p => p.Apsuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSuppliers_FK_APSupplierTypeAccountConfigID");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Apsuppliers).HasConstraintName("FK_APSuppliers_BRBranchs");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.Apsuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSuppliers_GECountrys");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApsupplierFkGecurrencies).HasConstraintName("FK_MASuppliers_GECurrencies");

            entity.HasOne(d => d.FkGedistrict).WithMany(p => p.Apsuppliers).HasConstraintName("FK_APSuppliers_GEDistricts");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.Apsuppliers).HasConstraintName("FK_MASuppliers_GELanguages");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.Apsuppliers).HasConstraintName("FK_APSuppliers_GEPaymentTerms");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.Apsuppliers).HasConstraintName("FK_MASuppliers_MAShippingMethods");

            entity.HasOne(d => d.FkGestateProvince).WithMany(p => p.Apsuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSuppliers_GEStateProvinces");
        });

        modelBuilder.Entity<ApsupplierComment>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApsupplierComments).HasConstraintName("FK_APSupplierComments_APSuppliers");
        });

        modelBuilder.Entity<ApsupplierContact>(entity =>
        {
            entity.Property(e => e.ApsupplierContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ApsupplierContactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApsupplierContacts).HasConstraintName("FK_APSupplierContacts_APSuppliers");
        });

        modelBuilder.Entity<ApsupplierDepartment>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApsupplierDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierDepartments_APSuppliers");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ApsupplierDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierDepartments_ICDepartments");
        });

        modelBuilder.Entity<ApsupplierDiscount>(entity =>
        {
            entity.Property(e => e.ApsupplierDiscountId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.FkAddiscount).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASupplierDiscounts_ADDiscounts");

            entity.HasOne(d => d.FkApsupplier).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASupplierDiscounts_MASuppliers");
        });

        modelBuilder.Entity<ApsupplierPayment>(entity =>
        {
            entity.HasOne(d => d.FkAclistAccountBank).WithMany(p => p.ApsupplierPayments).HasConstraintName("FK__APSupplie__FK_AC__795867B0");

            entity.HasOne(d => d.FkAcloanReceipt).WithMany(p => p.ApsupplierPayments).HasConstraintName("FK__APSupplie__FK_AC__78644377");

            entity.HasOne(d => d.FkApassociatedSupplier).WithMany(p => p.ApsupplierPaymentFkApassociatedSuppliers).HasConstraintName("FK_APSupplierPayments_APAssociatedSuppliers");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApsupplierPaymentFkApsuppliers).HasConstraintName("FK_APSupplierPayments_APSuppliers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ApsupplierPayments).HasConstraintName("FK_APSupplierPayments_BRBranchs");

            entity.HasOne(d => d.FkCscashFund).WithMany(p => p.ApsupplierPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierPayments_CSCashFunds");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.ApsupplierPayments).HasConstraintName("FK_APSupplierPayments_CSCompanyBanks");

            entity.HasOne(d => d.FkGeassCurrency).WithMany(p => p.ApsupplierPaymentFkGeassCurrencies).HasConstraintName("FK_APSupplierPayments_GECurrencies1");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ApsupplierPaymentFkGecurrencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierPayments_GECurrencies");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.ApsupplierPaymentFkHremployeeApproveds).HasConstraintName("FK_APSupplierPayments_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployeeCompleted).WithMany(p => p.ApsupplierPaymentFkHremployeeCompleteds).HasConstraintName("FK_APSupplierPayments_HREmployeeCompleteds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ApsupplierPaymentFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierPayments_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ApsupplierPayments).HasConstraintName("FK_APSupplierPayments_PMProjects");
        });

        modelBuilder.Entity<ApsupplierPaymentDetail>(entity =>
        {
            entity.HasKey(e => e.ApsupplierPaymentDetailId).HasName("PK_APDocumentPaymentDetailID");

            entity.HasOne(d => d.FkApsupplierPayment).WithMany(p => p.ApsupplierPaymentDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierPaymentDetails_APSupplierPayments");
        });

        modelBuilder.Entity<ApsupplierPaymentDocument>(entity =>
        {
            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.ApsupplierPaymentDocuments).HasConstraintName("FK_APSupplierPaymentDocuments_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.ApsupplierPaymentDocumentFkAccreditAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierPaymentDocuments_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.ApsupplierPaymentDocumentFkAcdebitAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierPaymentDocuments_ACAccounts");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.ApsupplierPaymentDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierPaymentDocuments_ACEntryTypes");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.ApsupplierPaymentDocuments).HasConstraintName("FK_APSupplierPaymentDocuments_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkApsupplierPayment).WithMany(p => p.ApsupplierPaymentDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APSupplierPaymentDocuments_APSupplierPayments");

            entity.HasOne(d => d.FkHradvanceRefund).WithMany(p => p.ApsupplierPaymentDocuments).HasConstraintName("FK_APSupplierPaymentDocuments_HRAdvanceRefunds");
        });

        modelBuilder.Entity<ApsupplierProductDiscount>(entity =>
        {
            entity.HasKey(e => e.ApsupplierProductDiscountId).HasName("PK_MASupplierProductDiscount");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApsupplierProductDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASupplierProductDiscount_MASuppliers");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApsupplierProductDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASupplierProductDiscount_MAProducts");
        });

        modelBuilder.Entity<ApsupplierProductGroupDiscount>(entity =>
        {
            entity.HasKey(e => e.ApsupplierProductGroupDiscountId).HasName("PK_MASupplierProductGroupDiscount1");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApsupplierProductGroupDiscounts).HasConstraintName("FK_MASupplierProductGroupDiscount_MASuppliers");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ApsupplierProductGroupDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASupplierProductGroupDiscount_MAProductGroup");
        });

        modelBuilder.Entity<ApsupplierProductNumber>(entity =>
        {
            entity.HasKey(e => e.ApsupplierProductNumberId).HasName("PK_MASupplierProductNumber");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ApsupplierProductNumbers).HasConstraintName("FK_MASupplierProductNumber_MASuppliers");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ApsupplierProductNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASupplierProductNumber_MAProducts");
        });

        modelBuilder.Entity<ApsupplierTypeAccountConfig>(entity =>
        {
            entity.HasOne(d => d.FkAcaccountDeposit).WithMany(p => p.ApsupplierTypeAccountConfigFkAcaccountDeposits).HasConstraintName("FK_APSupplierTypeAccountConfigs_FK_ACAccountDepositID");

            entity.HasOne(d => d.FkAcaccountPurchase).WithMany(p => p.ApsupplierTypeAccountConfigFkAcaccountPurchases).HasConstraintName("FK_APSupplierTypeAccountConfigs_FK_ACAccountPurchaseID");

            entity.HasOne(d => d.FkAcaccountSale).WithMany(p => p.ApsupplierTypeAccountConfigFkAcaccountSales).HasConstraintName("FK_APSupplierTypeAccountConfigs_FK_ACAccountSaleID");
        });

        modelBuilder.Entity<Aracceptance>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.Aracceptances).HasConstraintName("FK_ARAcceptances_ACCostCenters");

            entity.HasOne(d => d.FkArinvoiceRequest).WithMany(p => p.Aracceptances).HasConstraintName("FK_ARAcceptances_ARInvoiceRequests");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.Aracceptances).HasConstraintName("FK_ARAcceptances_ARSaleContracts");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.Aracceptances).HasConstraintName("FK_ARAcceptances_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Aracceptances).HasConstraintName("FK_ARAcceptances_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Aracceptances).HasConstraintName("FK_ARAcceptances_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Aracceptances).HasConstraintName("FK_ARAcceptances_PMProjects");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.Aracceptances).HasConstraintName("FK_ARAcceptances_PMTemplates");
        });

        modelBuilder.Entity<AracceptanceItem>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ACCostCenters");

            entity.HasOne(d => d.FkAracceptance).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ARAcceptances");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AracceptanceItemFkIcproducts).HasConstraintName("FK_ARAcceptanceItems_ICProducts");

            entity.HasOne(d => d.FkIcsectionProduct).WithMany(p => p.AracceptanceItemFkIcsectionProducts).HasConstraintName("FK_ARAcceptanceItems_ICSectionProducts");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ICShipments");

            entity.HasOne(d => d.FkIcshipmentItem).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ICShipmentItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_ICStocks");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.AracceptanceItems).HasConstraintName("FK_ARAcceptanceItems_PMTemplateItems");
        });

        modelBuilder.Entity<AracceptanceItemWork>(entity =>
        {
            entity.HasOne(d => d.FkAracceptance).WithMany(p => p.AracceptanceItemWorks).HasConstraintName("FK_ARAcceptanceItemWorks_ARAcceptances");

            entity.HasOne(d => d.FkArsaleOrderItemWork).WithMany(p => p.AracceptanceItemWorks).HasConstraintName("FK_ARAcceptanceItemWorks_ARSaleOrderItemWorks");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.AracceptanceItemWorks).HasConstraintName("FK_ARAcceptanceItemWorks_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AracceptanceItemWorks).HasConstraintName("FK_ARAcceptanceItemWorks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.AracceptanceItemWorks).HasConstraintName("FK_ARAcceptanceItemWorks_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AracceptanceItemWorks).HasConstraintName("FK_ARAcceptanceItemWorks_ICProducts");
        });

        modelBuilder.Entity<Aractivity>(entity =>
        {
            entity.HasKey(e => e.AractivityId).HasName("PK__ARActivi__915903E461B296F6");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.Aractivities).HasConstraintName("FK_ARActivitys_ADUserGroups");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Aractivities).HasConstraintName("FKmg214u6n5db7hbuh03aquqx8x");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Aractivities).HasConstraintName("FKnbk9nwu6nrmpjv4cjexyab36b");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.Aractivities).HasConstraintName("FK1upeqbs9dfdy2cgt12eiet4xs");
        });

        modelBuilder.Entity<AractivitysHistory>(entity =>
        {
            entity.HasKey(e => new { e.AractivityId, e.Rev }).HasName("PK__ARActivi__BDF6F9E0EEE87BB1");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.AractivitysHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKb287xjj69e6fhwbrgtlrnuhum");
        });

        modelBuilder.Entity<AradjustSaleOrderQuantity>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.AradjustSaleOrderQuantities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARAdjustSaleOrderQuantitys_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AradjustSaleOrderQuantities).HasConstraintName("FK_ARAdjustSaleOrderQuantitys_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.AradjustSaleOrderQuantities).HasConstraintName("FK_ARAdjustSaleOrderQuantitys_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AradjustSaleOrderQuantities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARAdjustSaleOrderQuantitys_HREmployees");
        });

        modelBuilder.Entity<AradjustSaleOrderQuantityItem>(entity =>
        {
            entity.HasOne(d => d.FkAradjustSaleOrderQuantity).WithMany(p => p.AradjustSaleOrderQuantityItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARAdjustSaleOrderQuantityItems_ARAdjustSaleOrderQuantitys");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.AradjustSaleOrderQuantityItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARAdjustSaleOrderQuantityItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.AradjustSaleOrderQuantityItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARAdjustSaleOrderQuantityItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.AradjustSaleOrderQuantityItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARAdjustSaleOrderQuantityItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.AradjustSaleOrderQuantityItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARAdjustSaleOrderQuantityItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.AradjustSaleOrderQuantityItems).HasConstraintName("FK_ARAdjustSaleOrderQuantityItems_ICStocks");
        });

        modelBuilder.Entity<Arallocation>(entity =>
        {
            entity.HasKey(e => e.ArallocationId).HasName("PK__ARAlloca__F68F5FC9040F928D");

            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.Arallocations).HasConstraintName("FK_ARAllocations_ARDeliveryPlans");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Arallocations).HasConstraintName("FK_ARAllocations_BRBranchs");

            entity.HasOne(d => d.FkHrdriverEmployee).WithMany(p => p.ArallocationFkHrdriverEmployees).HasConstraintName("FK_ARAllocations_HREmployees1");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArallocationFkHremployees).HasConstraintName("FK_ARAllocations_HREmployees");

            entity.HasOne(d => d.FkHrproposedEmployee).WithMany(p => p.ArallocationFkHrproposedEmployees).HasConstraintName("FK_ARAllocations_HREmployees2");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Arallocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARAllocations_PMProjects");
        });

        modelBuilder.Entity<ArallocationItem>(entity =>
        {
            entity.HasKey(e => e.ArallocationItemId).HasName("PK__ARAlloca__4907F9D60BB0B455");

            entity.HasOne(d => d.FkAcasset).WithMany(p => p.ArallocationItems).HasConstraintName("FK_ARAllocationItems_ACAssets");

            entity.HasOne(d => d.FkArallocation).WithMany(p => p.ArallocationItems).HasConstraintName("FK_ARAllocationItems_ARAllocations");

            entity.HasOne(d => d.FkArdeliveryPlanWorkAsset).WithMany(p => p.ArallocationItems).HasConstraintName("FK_ARAllocationItems_ARDeliveryPlanWorkAssets");

            entity.HasOne(d => d.FkArdeliveryPlanWork).WithMany(p => p.ArallocationItems).HasConstraintName("FK_ARAllocationItems_ARDeliveryPlanWorks");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArallocationItems).HasConstraintName("FK_ARAllocationItems_ARSaleOrders");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArallocationItems).HasConstraintName("FK_ARAllocationItems_ICProducts");

            entity.HasOne(d => d.FkIcproductIdentifiedEquipment).WithMany(p => p.ArallocationItems).HasConstraintName("FK_ARAllocationItems_ICProductIdentifiedEquipments");
        });

        modelBuilder.Entity<ArcalculateDiscount>(entity =>
        {
            entity.HasOne(d => d.FkArcustomerDistributionChannel).WithMany(p => p.ArcalculateDiscounts).HasConstraintName("FK_ARCalculateDiscounts_ARCustomerDistributionChannels");

            entity.HasOne(d => d.FkArdiscountProgram).WithMany(p => p.ArcalculateDiscounts).HasConstraintName("FK_ARCalculateDiscounts_ARDiscountPrograms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcalculateDiscounts).HasConstraintName("FK_ARCalculateDiscounts_HREmployees");
        });

        modelBuilder.Entity<ArcalculateDiscountItem>(entity =>
        {
            entity.HasOne(d => d.FkArcalculateDiscount).WithMany(p => p.ArcalculateDiscountItems).HasConstraintName("FK_ARCalculateDiscountItems_ARCalculateDiscounts");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.ArcalculateDiscountItems).HasConstraintName("FK_ARCalculateDiscountItems_HREmployeeApproved");
        });

        modelBuilder.Entity<Arcampaign>(entity =>
        {
            entity.HasKey(e => e.ArcampaignId).HasName("PK__ARCampai__34661166A693BF06");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.Arcampaigns).HasConstraintName("FK_ARCampaigns_ADUserGroups");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Arcampaigns).HasConstraintName("FKjv622j5lgngb6vx6xhkgxbuve");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Arcampaigns).HasConstraintName("FKhgnk7fmrg4a3gsf8jpmxmpr9");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.Arcampaigns).HasConstraintName("FKgmk7t2f7oubronh9qdv8haphm");
        });

        modelBuilder.Entity<ArcampaignsHistory>(entity =>
        {
            entity.HasKey(e => new { e.ArcampaignId, e.Rev }).HasName("PK__ARCampai__18C9EB62BA7E9BEE");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.ArcampaignsHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK5tgsgsqqc4fqq6nwoh7eovfs3");
        });

        modelBuilder.Entity<ArcancelSaleForecast>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcancelSaleForecasts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelSaleForecasts_ARCustomers");

            entity.HasOne(d => d.FkArsaleForecast).WithMany(p => p.ArcancelSaleForecasts).HasConstraintName("FK_ARCancelSaleForecasts_ARSaleForecast");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArcancelSaleForecasts).HasConstraintName("FK_ARCancelSaleForecasts_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArcancelSaleForecasts).HasConstraintName("FK_ARCancelSaleForecasts_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcancelSaleForecasts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelSaleForecasts_HREmployees");
        });

        modelBuilder.Entity<ArcancelSaleForecastItem>(entity =>
        {
            entity.HasOne(d => d.FkArcancelSaleForecast).WithMany(p => p.ArcancelSaleForecastItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelSaleForecastItems_ARCancelSaleForecasts");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArcancelSaleForecastItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelSaleForecastItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArcancelSaleForecastItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelSaleForecastItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArcancelSaleForecastItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelSaleForecastItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcancelSaleForecastItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelSaleForecastItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArcancelSaleForecastItems).HasConstraintName("FK_ARCancelSaleForecastItems_ICStocks");
        });

        modelBuilder.Entity<ArcancelVoucher>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArcancelVouchers).HasConstraintName("FK_ARCancelVouchers_ACCostCenters");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcancelVouchers).HasConstraintName("FK_ARCancelVouchers_ARCustomers");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArcancelVouchers).HasConstraintName("FK_ARCancelVouchers_ARSaleContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArcancelVouchers).HasConstraintName("FK_ARCancelVouchers_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArcancelVouchers).HasConstraintName("FK_ARCancelVouchers_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcancelVouchers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelVouchers_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArcancelVouchers).HasConstraintName("FK_ARCancelVouchers_PMProjects");
        });

        modelBuilder.Entity<ArcancelVoucherItem>(entity =>
        {
            entity.HasOne(d => d.FkArcancelVoucher).WithMany(p => p.ArcancelVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelVoucherItems_ARCancelVouchers");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArcancelVoucherItems).HasConstraintName("FK_ARCancelVoucherItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArcancelVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelVoucherItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArcancelVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelVoucherItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArcancelVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelVoucherItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcancelVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCancelVoucherItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArcancelVoucherItems).HasConstraintName("FK_ARCancelVoucherItems_ICStocks");
        });

        modelBuilder.Entity<ArcancelVoucherItemCost>(entity =>
        {
            entity.HasOne(d => d.FkArcancelVoucher).WithMany(p => p.ArcancelVoucherItemCosts).HasConstraintName("FK_ARCancelVoucherItemCosts_ARCancelVouchers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArcancelVoucherItemCosts).HasConstraintName("FK_ARCancelVoucherItemCosts_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArcancelVoucherItemCosts).HasConstraintName("FK_ARCancelVoucherItemCosts_ARSaleOrderItems");

            entity.HasOne(d => d.FkArsaleOrderItemWork).WithMany(p => p.ArcancelVoucherItemCosts).HasConstraintName("FK_ARCancelVoucherItemCosts_ARSaleOrderItemWorks");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArcancelVoucherItemCosts).HasConstraintName("FK_ARCancelVoucherItemCosts_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArcancelVoucherItemCosts).HasConstraintName("FK_ARCancelVoucherItemCosts_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArcancelVoucherItemCosts).HasConstraintName("FK_ARCancelVoucherItemCosts_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcancelVoucherItemCosts).HasConstraintName("FK_ARCancelVoucherItemCosts_ICProducts");
        });

        modelBuilder.Entity<ArcanceledDeliveryPlan>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArcanceledDeliveryPlans).HasConstraintName("FK_ARCanceledDeliveryPlans_ACCostCenters");

            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArcanceledDeliveryPlans).HasConstraintName("FK_ARCanceledDeliveryPlans_ARDeliveryPlans");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArcanceledDeliveryPlans).HasConstraintName("FK_ARCanceledDeliveryPlans_ARSaleContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArcanceledDeliveryPlans).HasConstraintName("FK_ARCanceledDeliveryPlans_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcanceledDeliveryPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCanceledDeliveryPlans_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArcanceledDeliveryPlans).HasConstraintName("FK_ARCanceledDeliveryPlans_PMProjects");
        });

        modelBuilder.Entity<ArcanceledDeliveryPlanItem>(entity =>
        {
            entity.HasOne(d => d.FkArcanceledDeliveryPlan).WithMany(p => p.ArcanceledDeliveryPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCanceledDeliveryPlanItems_ARCanceledDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanItem).WithMany(p => p.ArcanceledDeliveryPlanItems).HasConstraintName("FK_ARCanceledDeliveryPlanItems_ARDeliveryPlanItems");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArcanceledDeliveryPlanItems).HasConstraintName("FK_ARCanceledDeliveryPlanItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArcanceledDeliveryPlanItems).HasConstraintName("FK_ARCanceledDeliveryPlanItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArcanceledDeliveryPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCanceledDeliveryPlanItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcanceledDeliveryPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCanceledDeliveryPlanItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArcanceledDeliveryPlanItems).HasConstraintName("FK_ARCanceledDeliveryPlanItems_ICStocks");
        });

        modelBuilder.Entity<ArclearInvoice>(entity =>
        {
            entity.HasOne(d => d.FkAcaccountSale).WithMany(p => p.ArclearInvoices).HasConstraintName("FK_ARClearInvoices_ACAccounts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArclearInvoices).HasConstraintName("FK_ARClearInvoices_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArclearInvoices).HasConstraintName("FK_ARClearInvoices_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArclearInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARClearInvoices_HREmployees");
        });

        modelBuilder.Entity<ArclearInvoiceDocument>(entity =>
        {
            entity.HasOne(d => d.FkArclearInvoice).WithMany(p => p.ArclearInvoiceDocuments).HasConstraintName("FK_ARClearInvoiceDocuments_ARClearInvoices");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArclearInvoiceDocuments).HasConstraintName("FK_ARClearInvoiceDocuments_GECurrencies");
        });

        modelBuilder.Entity<ArclearInvoiceInvoice>(entity =>
        {
            entity.HasOne(d => d.FkArclearInvoice).WithMany(p => p.ArclearInvoiceInvoices).HasConstraintName("FK_ARClearInvoiceInvoices_ARClearInvoices");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArclearInvoiceInvoices).HasConstraintName("FK_ARClearInvoiceInvoices_ARInvoices");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArclearInvoiceInvoices).HasConstraintName("FK_ARClearInvoiceInvoices_GECurrencies");
        });

        modelBuilder.Entity<ArclearingDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcbankTransaction).WithMany(p => p.ArclearingDetails).HasConstraintName("FK_ARClearingDetails_ACBankTransactions");

            entity.HasOne(d => d.FkArcustomerPayment).WithMany(p => p.ArclearingDetails).HasConstraintName("FK_ARClearingDetails_ARCustomerPayments");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArclearingDetails).HasConstraintName("FK_ARClearingDetails_ARInvoices");

            entity.HasOne(d => d.FkArpaymentProposal).WithMany(p => p.ArclearingDetails).HasConstraintName("FK_ARClearingDetails_ARPaymentProposals");

            entity.HasOne(d => d.FkArreceiptVoucher).WithMany(p => p.ArclearingDetails).HasConstraintName("FK_ARClearingDetails_ARReceiptVouchers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArclearingDetails).HasConstraintName("FK_ARClearingDetails_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderPaymentTime).WithMany(p => p.ArclearingDetails).HasConstraintName("FK_ARClearingDetails_ARSaleOrderPaymentTimes");
        });

        modelBuilder.Entity<Arcomment>(entity =>
        {
            entity.HasKey(e => e.ArcommentId).HasName("PK__ARCommen__EA3E2E24F4DA9C07");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Arcomments).HasConstraintName("FK68kv0f1w996oo4rhbue2y48pa");
        });

        modelBuilder.Entity<Arcommission>(entity =>
        {
            entity.HasKey(e => e.ArcommissionId).HasName("PK_FAARCommissions");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.Arcommissions).HasConstraintName("FK_ARCommissions_ARSaleOrders");
        });

        modelBuilder.Entity<ArconfigOriginalUnitPrice>(entity =>
        {
            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArconfigOriginalUnitPrices).HasConstraintName("FK_ARConfigOriginalUnitPrices_GECurrencies");
        });

        modelBuilder.Entity<ArcontainerLoader>(entity =>
        {
            entity.HasKey(e => e.ArcontainerLoaderId).HasName("PK_FAContainerLoaders");

            entity.HasOne(d => d.FkArproductionPlanning).WithMany(p => p.ArcontainerLoaders).HasConstraintName("FK__ARContain__FK_AR__39B34BAA");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArcontainerLoaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARContainerLoaders_BRBranchs");

            entity.HasOne(d => d.FkGecontainer).WithMany(p => p.ArcontainerLoaders).HasConstraintName("FK_ARContainerLoaders_GEContainers");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcontainerLoaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARContainerLoaders_HREmployees");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ArcontainerLoaders).HasConstraintName("FK_ARContainerLoaders_MMBatchProducts");
        });

        modelBuilder.Entity<ArcontainerLoaderItem>(entity =>
        {
            entity.HasKey(e => e.ArcontainerLoaderItemId).HasName("PK_FAContainerLoaderItems");

            entity.HasOne(d => d.FkArcontainerLoader).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ARContainerLoaders");

            entity.HasOne(d => d.FkArproductionPlanningItem).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK__ARContain__FK_AR__3AA76FE3");

            entity.HasOne(d => d.FkArsaleForecast).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ARSaleForecasts");

            entity.HasOne(d => d.FkArsaleForecastItem).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ARSaleForecastItems");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.ArcontainerLoaderItemFkIcproductAttributeQualities).HasConstraintName("FK_ARContainerLoaderItems_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ArcontainerLoaderItemFkIcproductAttributeTtmts).HasConstraintName("FK_ARContainerLoaderItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ArcontainerLoaderItems).HasConstraintName("FK_ARContainerLoaderItems_MMBatchProducts");
        });

        modelBuilder.Entity<ArcontainerLoaderItemDetail>(entity =>
        {
            entity.HasKey(e => e.ArcontainerLoaderItemDetailId).HasName("PK_FAContainerLoaderItemDetails");

            entity.HasOne(d => d.FkArcontainerLoader).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ARContainerLoaders");

            entity.HasOne(d => d.FkArcontainerLoaderItem).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ARContainerLoaderItems");

            entity.HasOne(d => d.FkArsaleForecast).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ARSaleForecasts");

            entity.HasOne(d => d.FkArsaleForecastItem).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ARSaleForecastItems");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.ArcontainerLoaderItemDetailFkIcproductForBatches).HasConstraintName("FK_ARContainerLoaderItemDetails_ICProductForBatchs");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcontainerLoaderItemDetailFkIcproducts).HasConstraintName("FK_ARContainerLoaderItemDetails_ICProducts");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.ArcontainerLoaderItemDetails).HasConstraintName("FK_ARContainerLoaderItemDetails_MMBatchProductProductionNormItems");
        });

        modelBuilder.Entity<Arcoordinator>(entity =>
        {
            entity.HasKey(e => e.ArcoordinatorId).HasName("PK__ARCoordi__28EA4B6947A359C6");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Arcoordinators).HasConstraintName("FKt34ptdj7rd1e80h6dolo6aydk");
        });

        modelBuilder.Entity<ArcreditNote>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcreditNotes).HasConstraintName("FK_ARCreditNotes_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArcreditNotes).HasConstraintName("FK_ARCreditNotes_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArcreditNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCreditNotes_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcreditNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCreditNotes_HREmployees");
        });

        modelBuilder.Entity<ArcreditNoteInvoice>(entity =>
        {
            entity.HasOne(d => d.FkArcreditNote).WithMany(p => p.ArcreditNoteInvoices).HasConstraintName("FK_ARCreditNoteInvoices_ARCreditNotes");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArcreditNoteInvoices).HasConstraintName("FK_ARCreditNoteInvoices_ARInvoices");
        });

        modelBuilder.Entity<ArcreditNoteItem>(entity =>
        {
            entity.HasOne(d => d.FkArcreditNote).WithMany(p => p.ArcreditNoteItems).HasConstraintName("FK_ARCreditNoteItems_ARCreditNotes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcreditNoteItems).HasConstraintName("FK_ARCreditNoteItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArcreditNoteItems).HasConstraintName("FK_ARCreditNoteItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.ArcreditNoteItems).HasConstraintName("FK_ARCreditNoteItems_ICStockSlots");
        });

        modelBuilder.Entity<ArcreditNoteItemInvoiceItem>(entity =>
        {
            entity.HasKey(e => e.ArcreditNoteItemInvoiceItemId).HasName("PK_ARCreditNoteInvoiceItems");

            entity.HasOne(d => d.FkArcreditNoteItem).WithMany(p => p.ArcreditNoteItemInvoiceItems).HasConstraintName("FK_ARCreditNoteInvoiceItems_ARCreditNoteItems");

            entity.HasOne(d => d.FkArinvoiceItem).WithMany(p => p.ArcreditNoteItemInvoiceItems).HasConstraintName("FK_ARCreditNoteInvoiceItems_ARInvoiceItems");
        });

        modelBuilder.Entity<Arcustomer>(entity =>
        {
            entity.HasKey(e => e.ArcustomerId).HasName("PK_Customer");

            entity.ToTable("ARCustomers", tb => tb.HasTrigger("TRG_InsertUpdateCustomer"));

            entity.HasOne(d => d.FkAcaccountDeposit).WithMany(p => p.ArcustomerFkAcaccountDeposits).HasConstraintName("FK_ARCustomers_ACAccountDeposits");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.ArcustomerFkAcaccounts).HasConstraintName("FK_ARCustomers_ACAccounts");

            entity.HasOne(d => d.FkAcaccountPurchase).WithMany(p => p.ArcustomerFkAcaccountPurchases).HasConstraintName("FK_ARCustomers_ACAccountPurchases");

            entity.HasOne(d => d.FkAcaccountSale).WithMany(p => p.ArcustomerFkAcaccountSales).HasConstraintName("FK_ARCustomers_ACAccountSales");

            entity.HasOne(d => d.FkAdfengShuisColor).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_ADFengShuisColors");

            entity.HasOne(d => d.FkAdfengShuisDirection).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_ADFengShuisDirections");

            entity.HasOne(d => d.FkAdfengShuisGenaral).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_ADFengShuisGenarals");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_ADUserGroups");

            entity.HasOne(d => d.FkArcustomerBusinessType).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_ARCustomerBusinessTypes");

            entity.HasOne(d => d.FkArcustomerResource).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_ARCustomerResources");

            entity.HasOne(d => d.FkArcustomerTypeAccountConfig).WithMany(p => p.Arcustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomers_FK_ARCustomerTypeAccountConfigID");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_ARPriceLevels");

            entity.HasOne(d => d.FkArprospectCustomer).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_ARProspectCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Arcustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomers_GECurrencies");

            entity.HasOne(d => d.FkGedeliveryCountry).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_GEDeliveryCountrys");

            entity.HasOne(d => d.FkGedeliveryDistrict).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_GEDeliveryDistricts");

            entity.HasOne(d => d.FkGedeliveryStateProvince).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_GEDeliveryStateProvinces");

            entity.HasOne(d => d.FkGedeliveryStreet).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_GEDeliveryStreets");

            entity.HasOne(d => d.FkGedeliveryWard).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_GEDeliveryWards");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.ArcustomerFkGelocations).HasConstraintName("FK_ARCustomers_GELocations");

            entity.HasOne(d => d.FkGelocationId1Navigation).WithMany(p => p.ArcustomerFkGelocationId1Navigations).HasConstraintName("FK_ARCustomers_GELocations1");

            entity.HasOne(d => d.FkGelocationId2Navigation).WithMany(p => p.ArcustomerFkGelocationId2Navigations).HasConstraintName("FK_ARCustomers_GELocations2");

            entity.HasOne(d => d.FkGelocationId3Navigation).WithMany(p => p.ArcustomerFkGelocationId3Navigations).HasConstraintName("FK_ARCustomers_GELocations3");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.Arcustomers).HasConstraintName("FK_ARCustomers_GEPaymentTerms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcustomerFkHremployees).HasConstraintName("FK5v39qulxoi9meni502k4v9t6h");

            entity.HasOne(d => d.FkHremployeeManagement).WithMany(p => p.ArcustomerFkHremployeeManagements).HasConstraintName("FK_ARCustomers_HREmployees");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.Arcustomers).HasConstraintName("FK5okh7m54vfvlj8dg9won55i2m");
        });

        modelBuilder.Entity<ArcustomerComment>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerComments).HasConstraintName("FK_ARCustomerComments_ARCustomers");
        });

        modelBuilder.Entity<ArcustomerContact>(entity =>
        {
            entity.Property(e => e.ArcustomerContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArcustomerContactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.ArcustomerContacts).HasConstraintName("FK_ARCustomerContacts_ADUserGroups");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerContacts).HasConstraintName("FK_ARCustomerContacts_ARCustomers");

            entity.HasOne(d => d.FkArcustomerResource).WithMany(p => p.ArcustomerContacts).HasConstraintName("FK_ARCustomerContacts_ARCustomerResources");

            entity.HasOne(d => d.FkArprospectCustomer).WithMany(p => p.ArcustomerContacts).HasConstraintName("FK_ARCustomerContacts_ARProspectCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArcustomerContacts).HasConstraintName("FKmw96luj356mb7al64i91reiib");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.ArcustomerContacts).HasConstraintName("FKi5shbsmbrwr44cskwc3h5vsr6");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcustomerContacts).HasConstraintName("FKogp5hfaokmqbobvstl03l8n3p");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.ArcustomerContacts).HasConstraintName("FK2xf95gnw08lofmdxsueshgf5c");
        });

        modelBuilder.Entity<ArcustomerContactGroup>(entity =>
        {
            entity.HasKey(e => e.ArcustomerContactGroupId).HasName("PK__ARCustom__E478AFE5B9C93BBD");

            entity.HasOne(d => d.FkArcustomerContact).WithMany(p => p.ArcustomerContactGroups).HasConstraintName("FKdfcoxkcvaw738cealv7w185sl");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerContactGroups).HasConstraintName("FKqdw2orxpkbpu7yncxp2o0fuwt");
        });

        modelBuilder.Entity<ArcustomerContactGroupsHistory>(entity =>
        {
            entity.HasKey(e => new { e.ArcustomerContactGroupId, e.Rev }).HasName("PK__ARCustom__C8D755E1CCCC4CCD");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.ArcustomerContactGroupsHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKsm52f6ybbp05hdrs4gq54rkn");
        });

        modelBuilder.Entity<ArcustomerContactsHistory>(entity =>
        {
            entity.HasKey(e => new { e.ArcustomerContactId, e.Rev }).HasName("PK__ARCustom__DBA045ED4AB8CD52");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.ArcustomerContactsHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKnix7wxmo71qthtp0cd39h6rr4");
        });

        modelBuilder.Entity<ArcustomerDiscount>(entity =>
        {
            entity.HasKey(e => e.ArcustomerDiscountId).HasName("PK_MACustomerDiscounts");

            entity.HasOne(d => d.FkAddiscount).WithMany(p => p.ArcustomerDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MACustomerDiscounts_ADDiscounts");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MACustomerDiscounts_MACustomers");
        });

        modelBuilder.Entity<ArcustomerDistributionChannel>(entity =>
        {
            entity.HasKey(e => e.ArcustomerDistributionChannelId).HasName("PK_ARCustomerDistributionChannelID");
        });

        modelBuilder.Entity<ArcustomerInfoContact>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerInfoContacts).HasConstraintName("FK_ARCustomerInfoContacts_ARCustomers");
        });

        modelBuilder.Entity<ArcustomerPayment>(entity =>
        {
            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.ArcustomerPayments).HasConstraintName("FK_ARCustomerPayments_ACSegments");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerPayments).HasConstraintName("FK_ARCustomerPayments_ARCustomers");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArcustomerPayments).HasConstraintName("FK_ARCustomerPayments_ARSaleContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArcustomerPayments).HasConstraintName("FK_ARCustomerPayments_BRBranchs");

            entity.HasOne(d => d.FkCscashFund).WithMany(p => p.ArcustomerPayments).HasConstraintName("FK_ARCustomerPayments_CSCashFunds");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.ArcustomerPayments).HasConstraintName("FK_ARCustomerPayments_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArcustomerPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPayments_GECurrencies");

            entity.HasOne(d => d.FkHremployeeCompleted).WithMany(p => p.ArcustomerPaymentFkHremployeeCompleteds).HasConstraintName("FK_ARCustomerPayments_HREmployeeCompleteds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArcustomerPaymentFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPayments_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArcustomerPayments).HasConstraintName("FK_ARCustomerPayments_PMProjects");
        });

        modelBuilder.Entity<ArcustomerPaymentCurrency>(entity =>
        {
            entity.HasOne(d => d.FkArcustomerPaymentDetail).WithMany(p => p.ArcustomerPaymentCurrencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPaymentCurrencys_ARCustomerPaymentDetails");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArcustomerPaymentCurrencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPaymentCurrencys_GECurrencies");
        });

        modelBuilder.Entity<ArcustomerPaymentDetail>(entity =>
        {
            entity.HasOne(d => d.FkArcustomerPayment).WithMany(p => p.ArcustomerPaymentDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPaymentDetails_ARCustomerPayments");

            entity.HasOne(d => d.FkCscashFund).WithMany(p => p.ArcustomerPaymentDetails).HasConstraintName("FK_ARCustomerPaymentDetails_CSCashFunds");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.ArcustomerPaymentDetails).HasConstraintName("FK_ARCustomerPaymentDetails_CSCompanyBanks");
        });

        modelBuilder.Entity<ArcustomerPaymentDocument>(entity =>
        {
            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.ArcustomerPaymentDocuments).HasConstraintName("FK_ARCustomerPaymentDocuments_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.ArcustomerPaymentDocumentFkAccreditAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPaymentDocuments_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.ArcustomerPaymentDocumentFkAcdebitAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPaymentDocuments_ACAccounts");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.ArcustomerPaymentDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPaymentDocuments_ACEntryTypes");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.ArcustomerPaymentDocuments).HasConstraintName("FK_ARCustomerPaymentDocuments_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkArcustomerPayment).WithMany(p => p.ArcustomerPaymentDocuments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARCustomerPaymentDocuments_ARCustomerPayments");

            entity.HasOne(d => d.FkHradvanceRefund).WithMany(p => p.ArcustomerPaymentDocuments).HasConstraintName("FK_ARCustomerPaymentDocuments_HRAdvanceRefunds");
        });

        modelBuilder.Entity<ArcustomerPaymentTimePayment>(entity =>
        {
            entity.HasOne(d => d.FkArcustomerPayment).WithMany(p => p.ArcustomerPaymentTimePayments).HasConstraintName("FK_ARCustomerPaymentTimePayments_ARCustomerPayments");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArcustomerPaymentTimePayments).HasConstraintName("FK_ARCustomerPaymentTimePayments_ARInvoices");

            entity.HasOne(d => d.FkArpaymentProposal).WithMany(p => p.ArcustomerPaymentTimePayments).HasConstraintName("FK_ARCustomerPaymentTimePayments_ARPaymentProposals");

            entity.HasOne(d => d.FkArpaymentProposalItem).WithMany(p => p.ArcustomerPaymentTimePayments).HasConstraintName("FK_ARCustomerPaymentTimePayments_ARPaymentProposalItems");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArcustomerPaymentTimePayments).HasConstraintName("FK_ARCustomerPaymentTimePayments_ARSaleContracts");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArcustomerPaymentTimePayments).HasConstraintName("FK_ARCustomerPaymentTimePayments_ARSaleOrders");
        });

        modelBuilder.Entity<ArcustomerProductDiscount>(entity =>
        {
            entity.HasKey(e => e.ArcustomerProductDiscountId).HasName("PK_MACustomerProductDiscount");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerProductDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MACustomerProductDiscount_MACustomers");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcustomerProductDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MACustomerProductDiscount_MAProducts");
        });

        modelBuilder.Entity<ArcustomerProductGroupDiscount>(entity =>
        {
            entity.HasKey(e => e.ArcustomerProductGroupDiscountId).HasName("PK_MACustomerProductGroupDiscount1");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerProductGroupDiscounts).HasConstraintName("FK_MACustomerProductGroupDiscount_MACustomers");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArcustomerProductGroupDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MACustomerProductGroupDiscount_MAProductGroup");
        });

        modelBuilder.Entity<ArcustomerProductNumber>(entity =>
        {
            entity.HasKey(e => e.ArcustomerProductNumberId).HasName("PK_MACustomerProductNumber");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArcustomerProductNumbers).HasConstraintName("FK_MACustomerProductNumber_MACustomers");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArcustomerProductNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MACustomerProductNumber_MAProducts");
        });

        modelBuilder.Entity<ArcustomerResource>(entity =>
        {
            entity.HasKey(e => e.ArcustomerResourceId).HasName("PK_ARCustomerResourceID");
        });

        modelBuilder.Entity<ArcustomerSaleOrderTypeConfig>(entity =>
        {
            entity.HasKey(e => e.ArcustomerSaleOrderTypeConfigId).HasName("PK_ARCustomerSaleOrderTypeConfigID");
        });

        modelBuilder.Entity<ArcustomerTypeAccountConfig>(entity =>
        {
            entity.HasOne(d => d.FkAcaccountDeposit).WithMany(p => p.ArcustomerTypeAccountConfigFkAcaccountDeposits).HasConstraintName("FK_ARCustomerTypeAccountConfigs_FK_ACAccountDepositID");

            entity.HasOne(d => d.FkAcaccountPurchase).WithMany(p => p.ArcustomerTypeAccountConfigFkAcaccountPurchases).HasConstraintName("FK_ARCustomerTypeAccountConfigs_FK_ACAccountPurchaseID");

            entity.HasOne(d => d.FkAcaccountSale).WithMany(p => p.ArcustomerTypeAccountConfigFkAcaccountSales).HasConstraintName("FK_ARCustomerTypeAccountConfigs_FK_ACAccountSaleID");
        });

        modelBuilder.Entity<ArcustomersHistory>(entity =>
        {
            entity.HasKey(e => new { e.ArcustomerId, e.Rev }).HasName("PK__ARCustom__A96B170D92C5E38D");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.ArcustomersHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKtcqpiqjuq42ihfeask53gr2kw");
        });

        modelBuilder.Entity<Ardelivery>(entity =>
        {
            entity.HasKey(e => e.ArdeliveryId).HasName("PK_Deliverys");

            entity.HasOne(d => d.FkHrdeliveryEmployee).WithMany(p => p.ArdeliveryFkHrdeliveryEmployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARDeliverys_HREmployees2");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArdeliveryFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARDeliverys_HREmployees");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.Ardeliveries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARDeliverys_VMVehicles");
        });

        modelBuilder.Entity<ArdeliveryMethod>(entity =>
        {
            entity.HasKey(e => e.ArdeliveryMethodId).HasName("PK_DeliveryMethod");
        });

        modelBuilder.Entity<ArdeliveryPlan>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArdeliveryPlans).HasConstraintName("FK_ARDeliveryPlans_ACCostCenters");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArdeliveryPlans).HasConstraintName("FK_ARDeliveryPlans_ARSaleContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArdeliveryPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARDeliveryPlans_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.ArdeliveryPlanFkHremployeeApproveds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARDeliveryPlans_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArdeliveryPlanFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARDeliveryPlans_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ArdeliveryPlans).HasConstraintName("FK_ARDeliveryPlans_ICProductAttributes");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArdeliveryPlans).HasConstraintName("FK_ARDeliveryPlans_ICStocks");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArdeliveryPlans).HasConstraintName("FK_ARDeliveryPlans_PMProjects");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.ArdeliveryPlans).HasConstraintName("FK_ARDeliveryPlans_PMTemplates");
        });

        modelBuilder.Entity<ArdeliveryPlanFile>(entity =>
        {
            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanFiles).HasConstraintName("FK_ARDeliveryPlanFiles_ARDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanItem).WithMany(p => p.ArdeliveryPlanFiles).HasConstraintName("FK_ARDeliveryPlanFiles_ARDeliveryPlanItems");

            entity.HasOne(d => d.FkArdeliveryPlanReportIssue).WithMany(p => p.ArdeliveryPlanFiles).HasConstraintName("FK_ARDeliveryPlanFiles_ARDeliveryPlanReportIssues");

            entity.HasOne(d => d.FkArdeliveryPlanTruck).WithMany(p => p.ArdeliveryPlanFiles).HasConstraintName("FK_ARDeliveryPlanFiles_ARDeliveryPlanTrucks");

            entity.HasOne(d => d.FkArdeliveryPlanTruckItem).WithMany(p => p.ArdeliveryPlanFiles).HasConstraintName("FK_ARDeliveryPlanFiles_ARDeliveryPlanTruckItems");

            entity.HasOne(d => d.FkArdeliveryPlanTruckPoint).WithMany(p => p.ArdeliveryPlanFiles).HasConstraintName("FK_ARDeliveryPlanFiles_ARDeliveryPlanTruckPoints");

            entity.HasOne(d => d.FkArdeliveryPlanWork).WithMany(p => p.ArdeliveryPlanFiles).HasConstraintName("FK_ARDeliveryPlanFiles_ARDeliveryPlanWorks");

            entity.HasOne(d => d.FkArdeliveryPlanWorkTask).WithMany(p => p.ArdeliveryPlanFiles).HasConstraintName("FK_ARDeliveryPlanFiles_ARDeliveryPlanWorkTasks");
        });

        modelBuilder.Entity<ArdeliveryPlanItem>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ACCostCenters");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ARCustomers");

            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ARDeliveryPlans");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkArsaleReturn).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ARSaleReturns");

            entity.HasOne(d => d.FkArsaleReturnItem).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ARSaleReturnItems");

            entity.HasOne(d => d.FkGedeliveryDistrict).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_GEDeliveryDistricts");

            entity.HasOne(d => d.FkGedeliveryStateProvince).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_GEDeliveryStateProvinces");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.ArdeliveryPlanItemFkIcproductAttributeQualities).HasConstraintName("FK_ARDeliveryPlanItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ArdeliveryPlanItemFkIcproductAttributeTtmts).HasConstraintName("FK_ARDeliveryPlanItems_ICProductAttributes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArdeliveryPlanItemFkIcproducts).HasConstraintName("FK_ARDeliveryPlanItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ICProductSeries");

            entity.HasOne(d => d.FkIcsectionProduct).WithMany(p => p.ArdeliveryPlanItemFkIcsectionProducts).HasConstraintName("FK_ARDeliveryPlanItems_ICSectionProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ICStocks");

            entity.HasOne(d => d.FkIctransfer).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ICTransfers");

            entity.HasOne(d => d.FkIctransferItem).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_ICTransferItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_MMBatchProducts");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.ArdeliveryPlanItems).HasConstraintName("FK_ARDeliveryPlanItems_PMTemplateItems");
        });

        modelBuilder.Entity<ArdeliveryPlanMachineDevice>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArdeliveryPlanMachineDevices).HasConstraintName("FK_ARDeliveryPlanMachineDevices_ARCustomers");

            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanMachineDevices).HasConstraintName("FK_ARDeliveryPlanMachineDevices_ARDeliveryPlans");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArdeliveryPlanMachineDevices).HasConstraintName("FK_ARDeliveryPlanMachineDevices_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArdeliveryPlanMachineDevices).HasConstraintName("FK_ARDeliveryPlanMachineDevices_ARSaleOrderItems");

            entity.HasOne(d => d.FkGedeliveryDistrict).WithMany(p => p.ArdeliveryPlanMachineDevices).HasConstraintName("FK_ARDeliveryPlanMachineDevices_GEDeliveryDistricts");

            entity.HasOne(d => d.FkGedeliveryStateProvince).WithMany(p => p.ArdeliveryPlanMachineDevices).HasConstraintName("FK_ARDeliveryPlanMachineDevices_GEDeliveryStateProvinces");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArdeliveryPlanMachineDevices).HasConstraintName("FK_ARDeliveryPlanMachineDevices_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArdeliveryPlanMachineDevices).HasConstraintName("FK_ARDeliveryPlanMachineDevices_ICProducts");
        });

        modelBuilder.Entity<ArdeliveryPlanReportIssue>(entity =>
        {
            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanReportIssues).HasConstraintName("FK_ARDeliveryPlanReportIssues_ARDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanTruck).WithMany(p => p.ArdeliveryPlanReportIssues).HasConstraintName("FK_ARDeliveryPlanReportIssues_ARDeliveryPlanTrucks");

            entity.HasOne(d => d.FkArdeliveryPlanTruckPoint).WithMany(p => p.ArdeliveryPlanReportIssues).HasConstraintName("FK_ARDeliveryPlanReportIssues_ARDeliveryPlanTruckPoints");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArdeliveryPlanReportIssues).HasConstraintName("FK_ARDeliveryPlanReportIssues_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArdeliveryPlanReportIssues).HasConstraintName("FK_ARDeliveryPlanReportIssues_HREmployees");
        });

        modelBuilder.Entity<ArdeliveryPlanTruck>(entity =>
        {
            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanTrucks).HasConstraintName("FK_ARDeliveryPlanTrucks_ARDeliveryPlans");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArdeliveryPlanTrucks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARDeliveryPlanTrucks_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.ArdeliveryPlanTrucks).HasConstraintName("FK_ARDeliveryPlanTrucks_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.ArdeliveryPlanTrucks).HasConstraintName("FK_ARDeliveryPlanTrucks_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeDelivery).WithMany(p => p.ArdeliveryPlanTruckFkHremployeeDeliveries).HasConstraintName("FK_ARDeliveryPlanTrucks_HREmployeeDeliverys");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArdeliveryPlanTruckFkHremployees).HasConstraintName("FK_ARDeliveryPlanTrucks_HREmployees");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArdeliveryPlanTrucks).HasConstraintName("FK_ARDeliveryPlanTrucks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArdeliveryPlanTrucks).HasConstraintName("FK_ARDeliveryPlanTrucks_ICProducts");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.ArdeliveryPlanTrucks).HasConstraintName("FK_ARDeliveryPlanTrucks_VMVehicles");
        });

        modelBuilder.Entity<ArdeliveryPlanTruckItem>(entity =>
        {
            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ARDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanItem).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ARDeliveryPlanItems");

            entity.HasOne(d => d.FkArdeliveryPlanTruck).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ARDeliveryPlanTrucks");

            entity.HasOne(d => d.FkArdeliveryPlanTruckPoint).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ARDeliveryPlanTruckPoints");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkArsaleReturn).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ARSaleReturns");

            entity.HasOne(d => d.FkArsaleReturnItem).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ARSaleReturnItems");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArdeliveryPlanTruckItemFkIcproducts).HasConstraintName("FK_ARDeliveryPlanTruckItems_ICProducts");

            entity.HasOne(d => d.FkIcproductTruck).WithMany(p => p.ArdeliveryPlanTruckItemFkIcproductTrucks).HasConstraintName("FK_ARDeliveryPlanTruckItems_ICProducts1");

            entity.HasOne(d => d.FkIctransfer).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ICTransfers");

            entity.HasOne(d => d.FkIctransferItem).WithMany(p => p.ArdeliveryPlanTruckItems).HasConstraintName("FK_ARDeliveryPlanTruckItems_ICTransferItems");
        });

        modelBuilder.Entity<ArdeliveryPlanTruckPoint>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_ARCustomers");

            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_ARDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanTruck).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_ARDeliveryPlanTrucks");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleReturn).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_ARSaleReturns");

            entity.HasOne(d => d.FkGedeliveryDistrict).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_GEDeliveryDistricts");

            entity.HasOne(d => d.FkGedeliveryStateProvince).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_GEDeliveryStateProvinces");

            entity.HasOne(d => d.FkIcproductTruck).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_ICProducts");

            entity.HasOne(d => d.FkIctransfer).WithMany(p => p.ArdeliveryPlanTruckPoints).HasConstraintName("FK_ARDeliveryPlanTruckPoints_ICTransfers");
        });

        modelBuilder.Entity<ArdeliveryPlanWork>(entity =>
        {
            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanWorks).HasConstraintName("FK_ARDeliveryPlanWorks_ARDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanItem).WithMany(p => p.ArdeliveryPlanWorks).HasConstraintName("FK_ARDeliveryPlanWorks_ARDeliveryPlanItems");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArdeliveryPlanWorks).HasConstraintName("FK_ARDeliveryPlanWorks_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArdeliveryPlanWorks).HasConstraintName("FK_ARDeliveryPlanWorks_ARSaleOrderItems");

            entity.HasOne(d => d.FkArsaleOrderItemWork).WithMany(p => p.ArdeliveryPlanWorks).HasConstraintName("FK_ARDeliveryPlanWorks_ARSaleOrderItemWorks");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArdeliveryPlanWorks).HasConstraintName("FK_ARDeliveryPlanWorks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArdeliveryPlanWorks).HasConstraintName("FK_ARDeliveryPlanWorks_ICProducts");
        });

        modelBuilder.Entity<ArdeliveryPlanWorkAsset>(entity =>
        {
            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanWorkAssets).HasConstraintName("FK_ARDeliveryPlanWorkAssets_ARDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanItem).WithMany(p => p.ArdeliveryPlanWorkAssets).HasConstraintName("FK_ARDeliveryPlanWorkAssets_ARDeliveryPlanItems");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArdeliveryPlanWorkAssets).HasConstraintName("FK_ARDeliveryPlanWorkAssets_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArdeliveryPlanWorkAssets).HasConstraintName("FK_ARDeliveryPlanWorkAssets_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArdeliveryPlanWorkAssets).HasConstraintName("FK_ARDeliveryPlanWorkAssets_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArdeliveryPlanWorkAssets).HasConstraintName("FK_ARDeliveryPlanWorkAssets_ICProducts");
        });

        modelBuilder.Entity<ArdeliveryPlanWorkTask>(entity =>
        {
            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_ARDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanItem).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_ARDeliveryPlanItems");

            entity.HasOne(d => d.FkArdeliveryPlanWork).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_ARDeliveryPlanWorks");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_ARSaleOrderItems");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArdeliveryPlanWorkTaskFkHremployees).HasConstraintName("FK_ARDeliveryPlanWorkTasks_HREmployees");

            entity.HasOne(d => d.FkHremployeeOwner).WithMany(p => p.ArdeliveryPlanWorkTaskFkHremployeeOwners).HasConstraintName("FK_ARDeliveryPlanWorkTasks_HREmployeeOwners");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_ICProducts");

            entity.HasOne(d => d.FkIctask).WithMany(p => p.ArdeliveryPlanWorkTasks).HasConstraintName("FK_ARDeliveryPlanWorkTasks_ICTasks");
        });

        modelBuilder.Entity<ArdiscountProgram>(entity =>
        {
            entity.HasOne(d => d.FkArcustomerDistributionChannel).WithMany(p => p.ArdiscountPrograms).HasConstraintName("FK_ARDiscountPrograms_ARCustomerDistributionChannels");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArdiscountPrograms).HasConstraintName("FK_ARDiscountPrograms_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArdiscountPrograms).HasConstraintName("FK_ARDiscountPrograms_HREmployees");
        });

        modelBuilder.Entity<ArdiscountProgramItem>(entity =>
        {
            entity.HasOne(d => d.FkArdiscountProgram).WithMany(p => p.ArdiscountProgramItems).HasConstraintName("FK_ARDiscountProgramItems_ARDiscountPrograms");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArdiscountProgramItems).HasConstraintName("FK_ARDiscountProgramItems_ICProducts");
        });

        modelBuilder.Entity<ArdiscountProgramItemTarget>(entity =>
        {
            entity.HasOne(d => d.FkArdiscountProgram).WithMany(p => p.ArdiscountProgramItemTargets).HasConstraintName("FK_ARDiscountProgramItemTargets_ARDiscountPrograms");
        });

        modelBuilder.Entity<ArdocumentPayment>(entity =>
        {
            entity.HasOne(d => d.FkArcustomerPayment).WithMany(p => p.ArdocumentPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARDocumentPayments_ARCustomerPayments");

            entity.HasOne(d => d.FkAropenDocument).WithMany(p => p.ArdocumentPayments).HasConstraintName("FK_ARDocumentPayments_AROpenDocuments");
        });

        modelBuilder.Entity<AremailTracking>(entity =>
        {
            entity.HasKey(e => e.AremailTrackingId).HasName("PK__AREmailT__129A5F4907DAEF6D");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AremailTrackings).HasConstraintName("FK_AREmailTrackings_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AremailTrackings).HasConstraintName("FK_AREmailTrackings_HREmployees");
        });

        modelBuilder.Entity<Arestimate>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Arestimates).HasConstraintName("FK_AREstimates_ARCustomers");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.Arestimates).HasConstraintName("FK_AREstimates_ARPriceLevels");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Arestimates).HasConstraintName("FK_AREstimates_GECurrencies");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.Arestimates).HasConstraintName("FK_AREstimates_GEShippingMethods");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Arestimates).HasConstraintName("FK_AREstimates_HREmployees");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Arestimates).HasConstraintName("FK_AREstimates_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.Arestimates).HasConstraintName("FK_AREstimates_ICStockSlots");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Arestimates).HasConstraintName("FK_AREstimates_PMProjects");
        });

        modelBuilder.Entity<ArestimateItem>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_APSuppliers");

            entity.HasOne(d => d.FkArestimate).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_AREstimates");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_ICStockSlots");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_PMProjects");

            entity.HasOne(d => d.FkPmprojectNorm).WithMany(p => p.ArestimateItems).HasConstraintName("FK_AREstimateItems_PMProjectNorms");
        });

        modelBuilder.Entity<ArfeePaymentCommission>(entity =>
        {
            entity.HasOne(d => d.FkAcdocument).WithMany(p => p.ArfeePaymentCommissions).HasConstraintName("FK_ARFeePaymentCommissions_ACDocuments");
        });

        modelBuilder.Entity<Arhistory>(entity =>
        {
            entity.HasKey(e => e.ArhistoryId).HasName("PK_ARHistory");

            entity.Property(e => e.ArhistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.ArhistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.ArhistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<ArhistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkArhistory).WithMany(p => p.ArhistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARHistoryDetails_ARHistory");
        });

        modelBuilder.Entity<Arinvoice>(entity =>
        {
            entity.HasKey(e => e.ArinvoiceId).HasName("PK_FAInvoices");

            entity.Property(e => e.ArinvoiceActiveCheck).HasDefaultValueSql("((1))");
            entity.Property(e => e.ArinvoiceDeliveryContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArinvoiceDeliveryContactHeaderMessage).HasComment("Anrede fuer Briefe");
            entity.Property(e => e.ArinvoiceInvoiceContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArinvoiceInvoiceContactHeaderMessage).HasComment("Anrede fuer Briefe");
            entity.Property(e => e.ArinvoicePaymentContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArinvoicePaymentContactHeaderMessage).HasComment("Anrede fuer Briefe");
            entity.Property(e => e.ArinvoiceSocontactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArinvoiceSocontactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ACCostCenters");

            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ACEInvoiceTypes");

            entity.HasOne(d => d.FkActaxUnit).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ACTaxUnits");

            entity.HasOne(d => d.FkArassociatedSeller).WithMany(p => p.ArinvoiceFkArassociatedSellers).HasConstraintName("FK_ARInvoices_HREmployees2");

            entity.HasOne(d => d.FkArcustomerContactPayment).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ARCustomerContacts");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ARCustomers");

            entity.HasOne(d => d.FkArinvoiceRequest).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ARInvoiceRequests");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ARPriceLevels");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ARSaleContracts");

            entity.HasOne(d => d.FkArseller).WithMany(p => p.ArinvoiceFkArsellers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoices_HREmployees1");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Arinvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoices_GECurrencies");

            entity.HasOne(d => d.FkGeterminal).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_GETerminals");

            entity.HasOne(d => d.FkHrdeliveryEmployee).WithMany(p => p.ArinvoiceFkHrdeliveryEmployees).HasConstraintName("FK_ARInvoices_HREmployees3");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArinvoiceFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoices_HREmployees");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.Arinvoices).HasConstraintName("ARInvoices_FK_ICShipmentID");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_MMBatchProductID");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_PMProjects");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.Arinvoices).HasConstraintName("FK_ARInvoices_PMTemplates");
        });

        modelBuilder.Entity<ArinvoiceCommission>(entity =>
        {
            entity.HasKey(e => e.ArinvoiceCommissionId).HasName("PK_FAARInvoiceCommissions");

            entity.HasOne(d => d.FkArcommission).WithMany(p => p.ArinvoiceCommissions).HasConstraintName("FK_ARInvoiceCommissions_ARCommissions");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArinvoiceCommissions).HasConstraintName("FK_ARInvoiceCommissions_ARInvoices");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArinvoiceCommissions).HasConstraintName("FK_ARInvoiceCommissions_ARSaleOrders");
        });

        modelBuilder.Entity<ArinvoiceItem>(entity =>
        {
            entity.HasKey(e => e.ArinvoiceItemId).HasName("PK_FAInvoiceItems");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.ArinvoiceItemFkAcaccounts).HasConstraintName("FK_ARInvoiceItems_FK_ACAccountID");

            entity.HasOne(d => d.FkAcaccountRevenue).WithMany(p => p.ArinvoiceItemFkAcaccountRevenues).HasConstraintName("FK_ARInvoiceItems_ACAccounts");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ACCostCenters");

            entity.HasOne(d => d.FkAracceptance).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ARAcceptances");

            entity.HasOne(d => d.FkAracceptanceItem).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ARAcceptanceItems");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ARInvoices");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_GECountrys");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ICModels");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.ArinvoiceItemFkIcproductAttributeQualities).HasConstraintName("FK_ARInvoiceItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ArinvoiceItemFkIcproductAttributeTtmts).HasConstraintName("FK_ARInvoiceItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.ArinvoiceItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_ARInvoiceItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArinvoiceItemFkIcproducts).HasConstraintName("FK_ARInvoiceItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ICProductSeries");

            entity.HasOne(d => d.FkIcsectionProduct).WithMany(p => p.ArinvoiceItemFkIcsectionProducts).HasConstraintName("FK_ARInvoiceItems_ICSectionProducts");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ICShipments");

            entity.HasOne(d => d.FkIcshipmentItem).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_ICShipmentItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArinvoiceItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItems_ICStocks");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.ArinvoiceItems).HasConstraintName("FK_ARInvoiceItems_PMTemplateItems");
        });

        modelBuilder.Entity<ArinvoiceItemComponent>(entity =>
        {
            entity.HasOne(d => d.FkArinvoiceItem).WithMany(p => p.ArinvoiceItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItemComponents_ARInvoiceItems");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArinvoiceItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItemComponents_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArinvoiceItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItemComponents_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArinvoiceItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItemComponents_ICStocks");
        });

        modelBuilder.Entity<ArinvoiceItemPackage>(entity =>
        {
            entity.HasOne(d => d.FkArinvoiceItem).WithMany(p => p.ArinvoiceItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItemPackages_ARInvoiceItems");

            entity.HasOne(d => d.FkIcpackage).WithMany(p => p.ArinvoiceItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItemPackages_ICPackages");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArinvoiceItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItemPackages_ARInvoiceItemPackages");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArinvoiceItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceItemPackages_ICStocks");
        });

        modelBuilder.Entity<ArinvoiceItemShipmentItem>(entity =>
        {
            entity.HasOne(d => d.FkArinvoiceItem).WithMany(p => p.ArinvoiceItemShipmentItems).HasConstraintName("FK_ARInvoiceItemShipmentItems_ARInvoiceItems");

            entity.HasOne(d => d.FkIcshipmentItem).WithMany(p => p.ArinvoiceItemShipmentItems).HasConstraintName("FK_ARInvoiceItemShipmentItems_ICShipmentItems");
        });

        modelBuilder.Entity<ArinvoiceItemWork>(entity =>
        {
            entity.HasOne(d => d.FkAracceptanceItemWork).WithMany(p => p.ArinvoiceItemWorks).HasConstraintName("FK_ARInvoiceItemWorks_ARAcceptanceItemWorks");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArinvoiceItemWorks).HasConstraintName("FK_ARInvoiceItemWorks_ARInvoices");

            entity.HasOne(d => d.FkArinvoiceItem).WithMany(p => p.ArinvoiceItemWorks).HasConstraintName("FK_ARInvoiceItemWorks_ARInvoiceItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArinvoiceItemWorks).HasConstraintName("FK_ARInvoiceItemWorks_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArinvoiceItemWorks).HasConstraintName("FK_ARInvoiceItemWorks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArinvoiceItemWorks).HasConstraintName("FK_ARInvoiceItemWorks_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArinvoiceItemWorks).HasConstraintName("FK_ARInvoiceItemWorks_ICProducts");
        });

        modelBuilder.Entity<ArinvoiceRequest>(entity =>
        {
            entity.HasKey(e => e.ArinvoiceRequestId).HasName("PK_ADNewConfigValues");
        });

        modelBuilder.Entity<ArinvoiceShipment>(entity =>
        {
            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArinvoiceShipments).HasConstraintName("FK_ARInvoiceShipments_ARInvoices");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.ArinvoiceShipments).HasConstraintName("FK_ARInvoiceShipments_ICShipments");
        });

        modelBuilder.Entity<ArinvoiceTemplate>(entity =>
        {
            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArinvoiceTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceTemplates_ARInvoices");
        });

        modelBuilder.Entity<ArinvoiceTransaction>(entity =>
        {
            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArinvoiceTransactions).HasConstraintName("FK_ARInvoiceTransactions_ARSaleContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArinvoiceTransactions).HasConstraintName("FK_ARInvoiceTransactions_BRBRanchs");
        });

        modelBuilder.Entity<Arnotification>(entity =>
        {
            entity.HasKey(e => e.ArnotificationId).HasName("PK__ARNotifi__1D56A63C119D557B");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.Arnotifications).HasConstraintName("FK_ARNotifications_ADUserGroups");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Arnotifications).HasConstraintName("FK1fi4s8lppaopvs84lod8fovwg");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Arnotifications).HasConstraintName("FK7737nrinqbc44wu38yl28n4eh");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.Arnotifications).HasConstraintName("FKmdboi1pb8ofo7pmweslq0fwnh");
        });

        modelBuilder.Entity<AropenDocument>(entity =>
        {
            entity.Property(e => e.AropenDocumentIsDiscountPercentCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.AropenDocuments).HasConstraintName("FK_AROpenDocuments_ARCustomers");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.AropenDocuments).HasConstraintName("FK_AROpenDocuments_ARInvoices");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AropenDocuments).HasConstraintName("FK_AROpenDocuments_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.AropenDocuments).HasConstraintName("FK_AROpenDocuments_HREmployees");
        });

        modelBuilder.Entity<Aropportunity>(entity =>
        {
            entity.HasKey(e => e.AropportunityId).HasName("PK__AROpport__D419BB8FB561CA8F");

            entity.HasOne(d => d.Arcampaign).WithMany(p => p.Aropportunities).HasConstraintName("FK8o1vcqft1yislc8andl0guwiu");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.Aropportunities).HasConstraintName("FK_AROpportunitys_ADUserGroups");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Aropportunities).HasConstraintName("FKllh1nw0f8y0b6m83twfhx0c4f");

            entity.HasOne(d => d.FkArcustomerResource).WithMany(p => p.Aropportunities).HasConstraintName("FK_AROpportunitys_ARCustomerResources");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Aropportunities).HasConstraintName("FKpiwq9ktbruiqxxk00q7aquxr9");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Aropportunities).HasConstraintName("FK6o4r0wpgi0vetibfx412233ur");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.Aropportunities).HasConstraintName("FK3od3kq1w91drvelbfbpgrec84");
        });

        modelBuilder.Entity<AropportunityContact>(entity =>
        {
            entity.HasKey(e => e.AropportunityContactId).HasName("PK__AROpport__F142FD04608DD441");

            entity.HasOne(d => d.FkArcustomerContact).WithMany(p => p.AropportunityContacts).HasConstraintName("FKhr4lem9otfxu0t0u38xyccf44");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.AropportunityContacts).HasConstraintName("FKb2hbjoaehv0qi60qvb9pxfht6");
        });

        modelBuilder.Entity<AropportunityContactGroup>(entity =>
        {
            entity.HasKey(e => e.AropportunityContactGroupId).HasName("PK__AROpport__825F310DE219827B");

            entity.HasOne(d => d.FkArcustomerContact).WithMany(p => p.AropportunityContactGroups).HasConstraintName("FK4q6lm7fkov47wyr8d3pw49x89");

            entity.HasOne(d => d.FkAropportunity).WithMany(p => p.AropportunityContactGroups).HasConstraintName("FKi364ojp9933nqtyenl6ov37k3");
        });

        modelBuilder.Entity<AropportunityContactGroupsHistory>(entity =>
        {
            entity.HasKey(e => new { e.AropportunityContactGroupId, e.Rev }).HasName("PK__AROpport__AEF0CB09327F2868");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.AropportunityContactGroupsHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKenj0rceb6btuaq08s6r0pnpv9");
        });

        modelBuilder.Entity<AropportunitysHistory>(entity =>
        {
            entity.HasKey(e => new { e.AropportunityId, e.Rev }).HasName("PK__AROpport__F8B6418BE18861A6");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.AropportunitysHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKsc4wim4ee6ypjj4ubi1m2pc9d");
        });

        modelBuilder.Entity<ArpaymentProposal>(entity =>
        {
            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_ACSegments");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_ARCustomers");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_ARInvoices");

            entity.HasOne(d => d.FkAropportunity).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_AROpportunitys");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeAccountant).WithMany(p => p.ArpaymentProposalFkHremployeeAccountants).HasConstraintName("FK_ARPaymentProposals_HREmployeeAccountants");

            entity.HasOne(d => d.FkHremployeeHeadAccountant).WithMany(p => p.ArpaymentProposalFkHremployeeHeadAccountants).HasConstraintName("FK_ARPaymentProposals_HREmployeeHeadAccountants");

            entity.HasOne(d => d.FkHremployeeHeadDepartment).WithMany(p => p.ArpaymentProposalFkHremployeeHeadDepartments).HasConstraintName("FK_ARPaymentProposals_HREmployeeHeadDepartments");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArpaymentProposalFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARPaymentProposals_HREmployees");

            entity.HasOne(d => d.FkHremployeeManager).WithMany(p => p.ArpaymentProposalFkHremployeeManagers).HasConstraintName("FK_ARPaymentProposals_HREmployeeManagers");

            entity.HasOne(d => d.FkHremployeeReceiptNavigation).WithMany(p => p.ArpaymentProposalFkHremployeeReceiptNavigations).HasConstraintName("FK_ARPaymentProposals_HREmployees1");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_ICReceipts");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArpaymentProposals).HasConstraintName("FK_ARPaymentProposals_PMProjects");
        });

        modelBuilder.Entity<ArpaymentProposalItem>(entity =>
        {
            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArpaymentProposalItems).HasConstraintName("FK_ARPaymentProposalItems_ARInvoices");

            entity.HasOne(d => d.FkArpaymentProposal).WithMany(p => p.ArpaymentProposalItems).HasConstraintName("FK_ARPaymentProposalItems_ARPaymentProposals");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArpaymentProposalItems).HasConstraintName("FK_ARPaymentProposalItems_ARSaleContracts");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArpaymentProposalItems).HasConstraintName("FK_ARPaymentProposalItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderPaymentTime).WithMany(p => p.ArpaymentProposalItems).HasConstraintName("FK_ARPaymentProposalItems_ARSaleOrderPaymentTimes");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArpaymentProposalItems).HasConstraintName("FK_ARPaymentProposalItems_GECurrencies");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.ArpaymentProposalItems).HasConstraintName("FK_ARPaymentProposalItems_ICReceipts");
        });

        modelBuilder.Entity<ArpospaymentDetail>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.ArpospaymentDetails).HasConstraintName("FK_ARPOSPaymentDetails_ACAccounts");

            entity.HasOne(d => d.FkArcustomerPayment).WithMany(p => p.ArpospaymentDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARPOSPaymentDetails_ARCustomerPayments");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArpospaymentDetails).HasConstraintName("FK_ARPOSPaymentDetails_ARInvoices");

            entity.HasOne(d => d.FkCscashFund).WithMany(p => p.ArpospaymentDetails).HasConstraintName("FK_ARPOSPaymentDetails_CSCashFunds");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.ArpospaymentDetails).HasConstraintName("FK_ARPOSPaymentDetails_CSCompanyBanks");
        });

        modelBuilder.Entity<ArpriceLevel>(entity =>
        {
            entity.HasKey(e => e.ArpriceLevelId).HasName("PK_MAPrices");
        });

        modelBuilder.Entity<ArpriceSheet>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArpriceSheets).HasConstraintName("FK_ARPriceSheets_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArpriceSheets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARPriceSheets_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArpriceSheets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARPriceSheets_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArpriceSheets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARPriceSheets_HREmployees");
        });

        modelBuilder.Entity<ArpriceSheetComment>(entity =>
        {
            entity.HasOne(d => d.FkArpriceSheet).WithMany(p => p.ArpriceSheetComments).HasConstraintName("FK_ARPriceSheetComments_ARPriceSheets");
        });

        modelBuilder.Entity<ArpriceSheetItem>(entity =>
        {
            entity.HasOne(d => d.FkArpriceSheet).WithMany(p => p.ArpriceSheetItems).HasConstraintName("FK_ARPriceSheetItems_ARPriceSheets");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArpriceSheetItems).HasConstraintName("FK_ARPriceSheetItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArpriceSheetItems).HasConstraintName("FK_ARPriceSheetItems_ICProducts");
        });

        modelBuilder.Entity<ArpriceSheetItemWork>(entity =>
        {
            entity.HasOne(d => d.FkArpriceSheet).WithMany(p => p.ArpriceSheetItemWorks).HasConstraintName("FK_ARPriceSheetItemWorks_ARPriceSheets");

            entity.HasOne(d => d.FkArpriceSheetItem).WithMany(p => p.ArpriceSheetItemWorks).HasConstraintName("FK_ARPriceSheetItemWorks_ARPriceSheetItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArpriceSheetItemWorks).HasConstraintName("FK_ARPriceSheetItemWorks_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArpriceSheetItemWorks).HasConstraintName("FK_ARPriceSheetItemWorks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArpriceSheetItemWorks).HasConstraintName("FK_ARPriceSheetItemWorks_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArpriceSheetItemWorks).HasConstraintName("FK_ARPriceSheetItemWorks_ICProducts");
        });

        modelBuilder.Entity<ArproductionPlanning>(entity =>
        {
            entity.HasKey(e => e.ArproductionPlanningId).HasName("PK_FAProductionPlannings");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArproductionPlannings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARProductionPlannings_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArproductionPlannings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARProductionPlannings_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.ArproductionPlanningFkHremployeeApproveds).HasConstraintName("FK_ARProductionPlannings_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArproductionPlanningFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARProductionPlannings_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ArproductionPlannings).HasConstraintName("FK_ARProductionPlannings_ICProductAttributes");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.ArproductionPlannings).HasConstraintName("FK_ARProductionPlannings_MMWorkShops");
        });

        modelBuilder.Entity<ArproductionPlanningItem>(entity =>
        {
            entity.HasKey(e => e.ArproductionPlanningItemId).HasName("PK_FAProductionPlanningItems");

            entity.HasOne(d => d.FkArcontainerLoader).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ARContainerLoaders");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ARCustomers");

            entity.HasOne(d => d.FkArproductionPlanning).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ARProductionPlannings");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArproductionPlanningItems).HasConstraintName("FK_ARProductionPlanningItems_ICProducts");
        });

        modelBuilder.Entity<Arproposal>(entity =>
        {
            entity.HasKey(e => e.ArproposalId).HasName("PK_PriceList");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_ACCostCenters");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_ARCustomers");

            entity.HasOne(d => d.FkArestimate).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_AREstimates");

            entity.HasOne(d => d.FkAropportunity).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_AROpportunitys");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_ARPriceLevels");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_ARSaleContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_BRBranchs");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArproposalFkGecurrencies).HasConstraintName("FK_ARProposals_GECurrencies");

            entity.HasOne(d => d.FkGecurrencyId2Navigation).WithMany(p => p.ArproposalFkGecurrencyId2Navigations).HasConstraintName("ARProposals_FK_GECurrencyID21");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.Arproposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARProposals_GEPaymentTerms");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_GEShippingMethods");

            entity.HasOne(d => d.FkGeterminal).WithMany(p => p.Arproposals).HasConstraintName("ARProposals_GETerminals");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Arproposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARProposals_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_PMProjects");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.Arproposals).HasConstraintName("FK_ARProposals_PMTemplates");
        });

        modelBuilder.Entity<ArproposalArea>(entity =>
        {
            entity.HasOne(d => d.FkArproposal).WithMany(p => p.ArproposalAreas).HasConstraintName("FK_ARProposalAreas_ARProposals");

            entity.HasOne(d => d.FkArproposalItem).WithMany(p => p.ArproposalAreas).HasConstraintName("FK_ARProposalAreas_ARProposalItems");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArproposalAreas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARProposalAreas_ICProducts");

            entity.HasOne(d => d.FkIcproductTemplate).WithMany(p => p.ArproposalAreas).HasConstraintName("FK_ARProposalAreas_ICProductTemplates");
        });

        modelBuilder.Entity<ArproposalAreaItem>(entity =>
        {
            entity.HasOne(d => d.FkArproposalArea).WithMany(p => p.ArproposalAreaItems).HasConstraintName("FK_ARProposalAreaItems_ARProposalAreas");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArproposalAreaItems).HasConstraintName("FK_ARProposalAreaItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductFormulaPriceConfig).WithMany(p => p.ArproposalAreaItems).HasConstraintName("FK_ARProposalAreaItems_ICProductFormulaPriceConfigs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArproposalAreaItems).HasConstraintName("FK_ARProposalAreaItems_ICProducts");

            entity.HasOne(d => d.FkIcproductTemplate).WithMany(p => p.ArproposalAreaItems).HasConstraintName("FK_ARProposalAreaItems_ICProductTemplates");

            entity.HasOne(d => d.FkIcproductTemplateItem).WithMany(p => p.ArproposalAreaItems).HasConstraintName("FK_ARProposalAreaItems_ICProductTemplateItems");
        });

        modelBuilder.Entity<ArproposalItem>(entity =>
        {
            entity.HasKey(e => e.ArproposalItemId).HasName("PK_PriceListDetails");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ACCostCenters");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_APSuppliers");

            entity.HasOne(d => d.FkArestimateItem).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_AREstimateItems");

            entity.HasOne(d => d.FkArproposal).WithMany(p => p.ArproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARProposalItems_ARProposals");

            entity.HasOne(d => d.FkIccollection).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ICCollections");

            entity.HasOne(d => d.FkIccollectionItem).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ICCollectionItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeColor).WithMany(p => p.ArproposalItemFkIcproductAttributeColors).HasConstraintName("FK_ARProposalItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.ArproposalItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_ARProposalItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductFormulaPriceConfig).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ICProductFormulaPriceConfigs");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArproposalItemFkIcproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARProposalItems_ICProducts");

            entity.HasOne(d => d.FkIcsectionProduct).WithMany(p => p.ArproposalItemFkIcsectionProducts).HasConstraintName("FK_ARProposalItems_ICSectionProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_ICStockSlots");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.ArproposalItems).HasConstraintName("FK_ARProposalItems_PMTemplateItems");
        });

        modelBuilder.Entity<ArproposalItemWork>(entity =>
        {
            entity.HasOne(d => d.FkArproposal).WithMany(p => p.ArproposalItemWorks).HasConstraintName("FK_ARProposalItemWorks_ARProposals");

            entity.HasOne(d => d.FkArproposalItem).WithMany(p => p.ArproposalItemWorks).HasConstraintName("FK_ARProposalItemWorks_ARProposalItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArproposalItemWorks).HasConstraintName("FK_ARProposalItemWorks_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArproposalItemWorks).HasConstraintName("FK_ARProposalItemWorks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArproposalItemWorks).HasConstraintName("FK_ARProposalItemWorks_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArproposalItemWorks).HasConstraintName("FK_ARProposalItemWorks_ICProducts");
        });

        modelBuilder.Entity<ArproposalItemWorkItem>(entity =>
        {
            entity.HasOne(d => d.FkArproposal).WithMany(p => p.ArproposalItemWorkItems).HasConstraintName("FK_ARProposalItemWorkItems_ARProposals");

            entity.HasOne(d => d.FkArproposalItem).WithMany(p => p.ArproposalItemWorkItems).HasConstraintName("FK_ARProposalItemWorkItems_ARProposalItems");

            entity.HasOne(d => d.FkArproposalItemWork).WithMany(p => p.ArproposalItemWorkItems).HasConstraintName("FK_ARProposalItemWorkItems_ARProposalItemWorks");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArproposalItemWorkItems).HasConstraintName("FK_ARProposalItemWorkItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArproposalItemWorkItems).HasConstraintName("FK_ARProposalItemWorkItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArproposalItemWorkItems).HasConstraintName("FK_ARProposalItemWorkItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArproposalItemWorkItems).HasConstraintName("FK_ARProposalItemWorkItems_ICProducts");
        });

        modelBuilder.Entity<ArproposalItemWorkTask>(entity =>
        {
            entity.HasOne(d => d.FkArproposal).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_ARProposals");

            entity.HasOne(d => d.FkArproposalItemWork).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_ARSaleOrderItemWorks");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_HREmployees");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_ICProducts");

            entity.HasOne(d => d.FkIctask).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_ICTasks");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.ArproposalItemWorkTasks).HasConstraintName("FK_ARProposalItemWorkTasks_PMProjectTypes");
        });

        modelBuilder.Entity<ArproposalPaymentTime>(entity =>
        {
            entity.HasOne(d => d.FkArcustomerPayment).WithMany(p => p.ArproposalPaymentTimes).HasConstraintName("FK_ARProposalPaymentTimes_ARCustomerPaymentID");

            entity.HasOne(d => d.FkArproposal).WithMany(p => p.ArproposalPaymentTimes).HasConstraintName("FK_ARProposalPaymentTimes_ARProposals");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.ArproposalPaymentTimes).HasConstraintName("FK_ARProposalPaymentTimes_GEPaymentTerms");

            entity.HasOne(d => d.FkGepaymentTermItem).WithMany(p => p.ArproposalPaymentTimes).HasConstraintName("FK_ARProposalPaymentTimes_GEPaymentTermItems");
        });

        modelBuilder.Entity<ArproposalTemplateItem>(entity =>
        {
            entity.HasKey(e => e.ArproposalTemplateItemId).HasName("PK__ARProposalTemplate");

            entity.HasOne(d => d.FkArproposal).WithMany(p => p.ArproposalTemplateItems).HasConstraintName("FK_ARProposalTemplateItems_ARProposals");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArproposalTemplateItems).HasConstraintName("FK_ARProposalTemplateItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArproposalTemplateItems).HasConstraintName("FK_ARProposalTemplateItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArproposalTemplateItems).HasConstraintName("FK_ARProposalTemplateItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArproposalTemplateItems).HasConstraintName("FK_ARProposalTemplateItems_ICProducts");

            entity.HasOne(d => d.FkIcproductWorkGroup).WithMany(p => p.ArproposalTemplateItemFkIcproductWorkGroups).HasConstraintName("FK_ARProposalTemplateItems_ICProductWorkGroups");

            entity.HasOne(d => d.FkIcproductWorkGroupParent).WithMany(p => p.ArproposalTemplateItemFkIcproductWorkGroupParents).HasConstraintName("FK_ARProposalTemplateItems_ICProductWorkGroupParents");

            entity.HasOne(d => d.FkPmphaseType).WithMany(p => p.ArproposalTemplateItems).HasConstraintName("FK_ARProposalTemplateItems_PMPhaseTypes");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.ArproposalTemplateItems).HasConstraintName("FK_ARProposalTemplateItems_PMTemplates");
        });

        modelBuilder.Entity<ArprospectCustomer>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.ArprospectCustomers).HasConstraintName("FK_ARProspectCustomers_ADUserGroups");

            entity.HasOne(d => d.FkArcustomerResource).WithMany(p => p.ArprospectCustomers).HasConstraintName("FK_ARProspectCustomers_ARCustomerResources");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArprospectCustomers).HasConstraintName("FKgphfryihnuwmwf6oebc875n6a");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.ArprospectCustomers).HasConstraintName("FK3074wr6l35fi4opktbalxw8o7");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArprospectCustomers).HasConstraintName("FKppq9nofpwmr5o3i56f87s8lmm");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.ArprospectCustomers).HasConstraintName("FKqupcbxw2cldpa4kuros4tmyt2");
        });

        modelBuilder.Entity<ArprospectCustomersHistory>(entity =>
        {
            entity.HasKey(e => new { e.ArprospectCustomerId, e.Rev }).HasName("PK__ARProspe__0B4F184D7E0FE098");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.ArprospectCustomersHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKbao58rarohdb1tnps3uuoxpg4");
        });

        modelBuilder.Entity<ArreceiptVoucher>(entity =>
        {
            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.ArreceiptVouchers).HasConstraintName("FK_ARReceiptVouchers_ACSegments");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArreceiptVouchers).HasConstraintName("FK_ARReceiptVouchers_ARSaleContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArreceiptVouchers).HasConstraintName("FK_ARReceiptVouchers_BRBranchs");

            entity.HasOne(d => d.FkCscashFund).WithMany(p => p.ArreceiptVouchers).HasConstraintName("FK_ARReceiptVouchers_CSCashFunds");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.ArreceiptVouchers).HasConstraintName("FK_ARReceiptVouchers_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArreceiptVouchers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceiptVouchers_GECurrencies");

            entity.HasOne(d => d.FkHremployeeCompleted).WithMany(p => p.ArreceiptVoucherFkHremployeeCompleteds).HasConstraintName("FK_ARReceiptVouchers_HREmployeeCompleted_HREmployees");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArreceiptVoucherFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceiptVouchers_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArreceiptVouchers).HasConstraintName("FK_ARReceiptVouchers_PMProjects");
        });

        modelBuilder.Entity<ArreceiptVoucherItem>(entity =>
        {
            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.ArreceiptVoucherItemFkAccreditAccounts).HasConstraintName("FK_ARReceiptVoucherItems_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.ArreceiptVoucherItemFkAcdebitAccounts).HasConstraintName("FK_ARReceiptVoucherItems_ACAccounts");

            entity.HasOne(d => d.FkAcentryType).WithMany(p => p.ArreceiptVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceiptVoucherItems_ACEntryTypes");

            entity.HasOne(d => d.FkArreceiptVoucher).WithMany(p => p.ArreceiptVoucherItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceiptVoucherItems_ARReceiptVouchers");

            entity.HasOne(d => d.FkHradvanceRefund).WithMany(p => p.ArreceiptVoucherItems).HasConstraintName("FK_ARReceiptVoucherItems_HRAdvanceRefunds");
        });

        modelBuilder.Entity<Arreception>(entity =>
        {
            entity.HasKey(e => e.ArreceptionId).HasName("PK__ARRecept__0E895EBD79E709D5");

            entity.HasOne(d => d.FkAcequipmentState).WithMany(p => p.Arreceptions).HasConstraintName("FK_ARReceptions_ACEquipmentStates");

            entity.HasOne(d => d.FkArallocation).WithMany(p => p.Arreceptions).HasConstraintName("FK_ARReceptions_ARAllocations");

            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.Arreceptions).HasConstraintName("FK_ARReceptions_ARDeliveryPlans");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Arreceptions).HasConstraintName("FK_ARReceptions_BRBranchs");

            entity.HasOne(d => d.FkHrdriverEmployee).WithMany(p => p.ArreceptionFkHrdriverEmployees).HasConstraintName("FK_ARReceptions_HREmployees1");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArreceptionFkHremployees).HasConstraintName("FK_ARReceptions_HREmployees");

            entity.HasOne(d => d.FkHrreturnEmployee).WithMany(p => p.ArreceptionFkHrreturnEmployees).HasConstraintName("FK_ARReceptions_HREmployees2");
        });

        modelBuilder.Entity<ArreceptionItem>(entity =>
        {
            entity.HasKey(e => e.ArreceptionItemId).HasName("PK__ARRecept__4BCBD1FF0A1D719E");

            entity.HasOne(d => d.FkAcasset).WithMany(p => p.ArreceptionItems).HasConstraintName("FK_ARReceptionItems_ACAssets");

            entity.HasOne(d => d.FkArallocationItem).WithMany(p => p.ArreceptionItems).HasConstraintName("FK_ARReceptionItems_ARAllocationItems");

            entity.HasOne(d => d.FkArreception).WithMany(p => p.ArreceptionItems).HasConstraintName("FK_ARReceptionItems_ARReceptions");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArreceptionItems).HasConstraintName("FK_ARReceptionItems_ARSaleOrders");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArreceptionItems).HasConstraintName("FK_ARReceptionItems_ICProducts");

            entity.HasOne(d => d.FkIcproductIdentifiedEquipment).WithMany(p => p.ArreceptionItems).HasConstraintName("FK_ARReceptionItems_ICProductIdentifiedEquipments");
        });

        modelBuilder.Entity<Arremind>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Arreminds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReminds_ARCustomers");

            entity.HasOne(d => d.FkArproposal).WithMany(p => p.Arreminds).HasConstraintName("FK_ARReminds_ARProposals");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.Arreminds).HasConstraintName("FK_ARReminds_ARSaleOrders");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Arreminds).HasConstraintName("FK_ARReminds_HREmployees");
        });

        modelBuilder.Entity<ArrevenueForecast>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArrevenueForecasts).HasConstraintName("FK_ARRevenueForecasts_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArrevenueForecasts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARRevenueForecasts_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArrevenueForecasts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARRevenueForecasts_HREmployees");
        });

        modelBuilder.Entity<ArrevenueForecastItem>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArrevenueForecastItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARRevenueForecastItems_ARCustomers");

            entity.HasOne(d => d.FkArrevenueForecast).WithMany(p => p.ArrevenueForecastItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARRevenueForecastItems_ARRevenueForecasts");
        });

        modelBuilder.Entity<ArsaleContract>(entity =>
        {
            entity.HasKey(e => e.ArsaleContractId).HasName("PK_SaleContract");

            entity.HasOne(d => d.FkArproposal).WithMany(p => p.ArsaleContracts).HasConstraintName("FK_ARSaleContracts_ARProposals");

            entity.HasOne(d => d.FkArsaleContractGroup).WithMany(p => p.ArsaleContracts).HasConstraintName("FK_ARSaleContracts_ARSaleContractGroups");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArsaleContracts).HasConstraintName("FK_ARSaleContracts_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArsaleContracts).HasConstraintName("FK_ARSaleContracts_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArsaleContracts).HasConstraintName("FK_ARSaleContracts_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArsaleContracts).HasConstraintName("FK_ARSaleContracts_PMProjects");
        });

        modelBuilder.Entity<ArsaleContractGroup>(entity =>
        {
            entity.HasKey(e => e.ArsaleContractGroupId).HasName("PK_SaleContractGroup");
        });

        modelBuilder.Entity<ArsaleContractTemplate>(entity =>
        {
            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArsaleContractTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleContractTemplates_ARSaleContracts");
        });

        modelBuilder.Entity<ArsaleForecast>(entity =>
        {
            entity.Property(e => e.ArsaleForecastActiveCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FkArassociatedSeller).WithMany(p => p.ArsaleForecastFkArassociatedSellers).HasConstraintName("FK_ARSaleForecasts_HREmployees2");

            entity.HasOne(d => d.FkArcustomerContactDelivery).WithMany(p => p.ArsaleForecastFkArcustomerContactDeliveries).HasConstraintName("FK_ARSaleForecasts_ARCustomerContacts1");

            entity.HasOne(d => d.FkArcustomerContactPayment).WithMany(p => p.ArsaleForecastFkArcustomerContactPayments).HasConstraintName("FK_ARSaleForecasts_ARCustomerContacts");

            entity.HasOne(d => d.FkArcustomerContactSf).WithMany(p => p.ArsaleForecastFkArcustomerContactSfs).HasConstraintName("FK_ARSaleForecasts_ARCustomerContacts2");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArsaleForecasts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleForecasts_MACustomers");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.ArsaleForecasts).HasConstraintName("FK_ARSaleForecasts_ARPriceLevels");

            entity.HasOne(d => d.FkArseller).WithMany(p => p.ArsaleForecastFkArsellers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleForecasts_HREmployees1");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArsaleForecasts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleForecasts_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArsaleForecastFkGecurrencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleForecasts_GECurrencies");

            entity.HasOne(d => d.FkGecurrencyId2Navigation).WithMany(p => p.ArsaleForecastFkGecurrencyId2Navigations).HasConstraintName("FK_ARSaleForecasts_GECurrencies2");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.ArsaleForecasts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleForecasts_GEPaymentTerms");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.ArsaleForecasts).HasConstraintName("FK_ARSaleForecasts_MAShippingMethods");

            entity.HasOne(d => d.FkGevatregion).WithMany(p => p.ArsaleForecasts).HasConstraintName("FK_ARSaleForecasts_GEVATRegions");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArsaleForecastFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleForecasts_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ArsaleForecasts).HasConstraintName("FK_ARSaleForecasts_ICProductAttributes");
        });

        modelBuilder.Entity<ArsaleForecastItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleForecast).WithMany(p => p.ArsaleForecastItems).HasConstraintName("FK_ARSaleForecastItems_ARSaleForecasts");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArsaleForecastItems).HasConstraintName("FK_ARSaleForecastItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArsaleForecastItems).HasConstraintName("FK_ARSaleForecastItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArsaleForecastItems).HasConstraintName("FK_ARSaleForecastItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleForecastItems).HasConstraintName("FK_ARSaleForecastItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArsaleForecastItems).HasConstraintName("FK_ARSaleForecastItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArsaleForecastItems).HasConstraintName("FK_ARSaleForecastItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.ArsaleForecastItems).HasConstraintName("FK_ARSaleForecastItems_ICStockSlots");
        });

        modelBuilder.Entity<ArsaleForecastTemplate>(entity =>
        {
            entity.HasOne(d => d.FkArsaleForecast).WithMany(p => p.ArsaleForecastTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleForecastTemplates_ARSaleForecasts");
        });

        modelBuilder.Entity<ArsaleOrder>(entity =>
        {
            entity.HasKey(e => e.ArsaleOrderId).HasName("PK_FASellOrders");

            entity.Property(e => e.ArsaleOrderActiveCheck).HasDefaultValueSql("((1))");
            entity.Property(e => e.ArsaleOrderDeliveryContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArsaleOrderDeliveryContactHeaderMessage).HasComment("Anrede fuer Briefe");
            entity.Property(e => e.ArsaleOrderInvoiceContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArsaleOrderInvoiceContactHeaderMessage).HasComment("Anrede fuer Briefe");
            entity.Property(e => e.ArsaleOrderPaymentContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArsaleOrderPaymentContactHeaderMessage).HasComment("Anrede fuer Briefe");
            entity.Property(e => e.ArsaleOrderSocontactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArsaleOrderSocontactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_ACCostCenters");

            entity.HasOne(d => d.FkArassociatedSeller).WithMany(p => p.ArsaleOrderFkArassociatedSellers).HasConstraintName("FK_ARSaleOrders_HREmployees2");

            entity.HasOne(d => d.FkArcustomerContactDelivery).WithMany(p => p.ArsaleOrderFkArcustomerContactDeliveries).HasConstraintName("FK_ARSaleOrders_ARCustomerContacts1");

            entity.HasOne(d => d.FkArcustomerContactPayment).WithMany(p => p.ArsaleOrderFkArcustomerContactPayments).HasConstraintName("FK_ARSaleOrders_ARCustomerContacts");

            entity.HasOne(d => d.FkArcustomerContactSo).WithMany(p => p.ArsaleOrderFkArcustomerContactSos).HasConstraintName("FK_ARSaleOrders_ARCustomerContacts2");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_FASellOrders_MACustomers");

            entity.HasOne(d => d.FkArdeliveryMethod).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_ARDeliveryMethods");

            entity.HasOne(d => d.FkArinvoiceRequest).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_FASellOrders_ARInvoiceRequests");

            entity.HasOne(d => d.FkAropportunity).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_AROpportunitys");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_ARPriceLevels");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_ARSaleContracts");

            entity.HasOne(d => d.FkArseller).WithMany(p => p.ArsaleOrderFkArsellers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleOrders_HREmployees1");

            entity.HasOne(d => d.FkArshipper).WithMany(p => p.ArsaleOrderFkArshippers).HasConstraintName("FK_ARSaleOrders_ARShippers");

            entity.HasOne(d => d.FkArsubSeller).WithMany(p => p.ArsaleOrderFkArsubSellers).HasConstraintName("FK_ARSaleOrders_HREmployees3");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArsaleOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleOrders_BRBranchs");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_FASellOrders_CSCompanyBanks");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArsaleOrderFkGecurrencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellOrders_GECurrencies");

            entity.HasOne(d => d.FkGecurrencyId2Navigation).WithMany(p => p.ArsaleOrderFkGecurrencyId2Navigations).HasConstraintName("FK_ARSaleOrders_GECurrencies");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.ArsaleOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleOrders_GEPaymentTerms");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_FASellOrders_MAShippingMethods");

            entity.HasOne(d => d.FkGeterminal).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_GETerminals");

            entity.HasOne(d => d.FkGevatregion).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_FASellOrders_GEVATRegions");

            entity.HasOne(d => d.FkHremployee2D).WithMany(p => p.ArsaleOrderFkHremployee2Ds).HasConstraintName("FK_ARSaleOrders_HREmployee2DID");

            entity.HasOne(d => d.FkHremployee3D).WithMany(p => p.ArsaleOrderFkHremployee3Ds).HasConstraintName("FK_ARSaleOrders_HREmployee3DID");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArsaleOrderFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleOrders_HREmployees");

            entity.HasOne(d => d.FkHremployeeManager2D).WithMany(p => p.ArsaleOrderFkHremployeeManager2Ds).HasConstraintName("FK_ARSaleOrders_HREmployeeManager2DID");

            entity.HasOne(d => d.FkHremployeeManager3D).WithMany(p => p.ArsaleOrderFkHremployeeManager3Ds).HasConstraintName("FK_ARSaleOrders_HREmployeeManager3DID");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_ICProductAttributes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_MMBatchProducts");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_PMProjects");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.ArsaleOrders).HasConstraintName("FK_ARSaleOrders_PMTemplates");
        });

        modelBuilder.Entity<ArsaleOrderHistory>(entity =>
        {
            entity.HasKey(e => e.ArsaleOrderHistoryId).HasName("PK_HISellOrderHistorys");

            entity.HasOne(d => d.FkAduser).WithMany(p => p.ArsaleOrderHistories).HasConstraintName("FK_ARSaleOrderHistorys_ADUsers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderHistories).HasConstraintName("FK_ARSaleOrderHistorys_ARSaleOrders");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArsaleOrderHistories).HasConstraintName("FK_ARSaleOrderHistorys_HREmployees");
        });

        modelBuilder.Entity<ArsaleOrderHistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrderHistory).WithMany(p => p.ArsaleOrderHistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleOrderHistorys_ARSaleOrderHistorys");
        });

        modelBuilder.Entity<ArsaleOrderItem>(entity =>
        {
            entity.HasKey(e => e.ArsaleOrderItemId).HasName("PK_FASellOrderItems");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ACCostCenters");

            entity.HasOne(d => d.FkArsaleForecast).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ARSaleForecasts");

            entity.HasOne(d => d.FkArsaleForecastItem).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ARSaleForecastItems");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ARSaleOrders");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_GECountrys");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICDepartments");

            entity.HasOne(d => d.FkIclengthGroup).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICLengthGroups");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICModels");

            entity.HasOne(d => d.FkIcperimeterGroup).WithMany(p => p.ArsaleOrderItems).HasConstraintName("ARSaleOrderItems_FK_ICPerimeterGroupID");

            entity.HasOne(d => d.FkIcproductAttributeColor).WithMany(p => p.ArsaleOrderItemFkIcproductAttributeColors).HasConstraintName("FK_ARSaleOrderItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.ArsaleOrderItemFkIcproductAttributeQualities).HasConstraintName("FK_ARSaleOrderItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.ArsaleOrderItemFkIcproductAttributeTtmts).HasConstraintName("FK_ARSaleOrderItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.ArsaleOrderItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_ARSaleOrderItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductFormulaPriceConfig).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICProductFormulaPriceConfigss");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleOrderItemFkIcproducts).HasConstraintName("FK_ARSaleOrderItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICProductSeries");

            entity.HasOne(d => d.FkIcsectionProduct).WithMany(p => p.ArsaleOrderItemFkIcsectionProducts).HasConstraintName("FK_ARSaleOrderItems_ICSectionProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_ICStockSlots");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_MMAllocationPlans");

            entity.HasOne(d => d.FkMmallocationPlanItem).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_MMAllocationPlanItems");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.ArsaleOrderItems).HasConstraintName("FK_ARSaleOrderItems_PMTemplateItems");
        });

        modelBuilder.Entity<ArsaleOrderItemAllocationFee>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderItemAllocationFees).HasConstraintName("FK_ARSaleOrderItemAllocationFees_ARSaleOrders");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleOrderItemAllocationFees).HasConstraintName("FK_ARSaleOrderItemAllocationFees_ICProducts");
        });

        modelBuilder.Entity<ArsaleOrderItemContainer>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderItemContainers).HasConstraintName("FK_ARSaleOrderItemContainers_ARSaleOrders");

            entity.HasOne(d => d.FkGecontainer).WithMany(p => p.ArsaleOrderItemContainers).HasConstraintName("FK_ARSaleOrderItemContainers_GEContainers");
        });

        modelBuilder.Entity<ArsaleOrderItemOtherFee>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderItemOtherFees).HasConstraintName("FK_ARSaleOrderItemOtherFees_ARSaleOrders");
        });

        modelBuilder.Entity<ArsaleOrderItemWork>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderItemWorks).HasConstraintName("FK_ARSaleOrderItemWorks_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArsaleOrderItemWorks).HasConstraintName("FK_ARSaleOrderItemWorks_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArsaleOrderItemWorks).HasConstraintName("FK_ARSaleOrderItemWorks_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArsaleOrderItemWorks).HasConstraintName("FK_ARSaleOrderItemWorks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArsaleOrderItemWorks).HasConstraintName("FK_ARSaleOrderItemWorks_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleOrderItemWorks).HasConstraintName("FK_ARSaleOrderItemWorks_ICProducts");
        });

        modelBuilder.Entity<ArsaleOrderItemWorkItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderItemWorkItems).HasConstraintName("FK_ARSaleOrderItemWorkItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArsaleOrderItemWorkItems).HasConstraintName("FK_ARSaleOrderItemWorkItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkArsaleOrderItemWork).WithMany(p => p.ArsaleOrderItemWorkItems).HasConstraintName("FK_ARSaleOrderItemWorkItems_ARSaleOrderItemWorks");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArsaleOrderItemWorkItems).HasConstraintName("FK_ARSaleOrderItemWorkItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArsaleOrderItemWorkItems).HasConstraintName("FK_ARSaleOrderItemWorkItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArsaleOrderItemWorkItems).HasConstraintName("FK_ARSaleOrderItemWorkItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleOrderItemWorkItems).HasConstraintName("FK_ARSaleOrderItemWorkItems_ICProducts");
        });

        modelBuilder.Entity<ArsaleOrderItemWorkTask>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_ARSaleOrderItems");

            entity.HasOne(d => d.FkArsaleOrderItemWork).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_ARSaleOrderItemWorks");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_HREmployees");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_ICProducts");

            entity.HasOne(d => d.FkIctask).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_ICTasks");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.ArsaleOrderItemWorkTasks).HasConstraintName("FK_ARSaleOrderItemWorkTasks_PMProjectTypes");
        });

        modelBuilder.Entity<ArsaleOrderPaymentTime>(entity =>
        {
            entity.HasOne(d => d.FkArcustomerPayment).WithMany(p => p.ArsaleOrderPaymentTimes).HasConstraintName("FK_ARSaleOrderPaymentTimes_ARCustomerPaymentID");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderPaymentTimes).HasConstraintName("FK_ARSaleOrderPaymentTimes_ARSaleOrders");

            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.ArsaleOrderPaymentTimes).HasConstraintName("FK_ARSaleOrderPaymentTimes_GEPaymentTerms");

            entity.HasOne(d => d.FkGepaymentTermItem).WithMany(p => p.ArsaleOrderPaymentTimes).HasConstraintName("FK_ARSaleOrderPaymentTimes_GEPaymentTermItems");
        });

        modelBuilder.Entity<ArsaleOrderPaymentTimeTemplate>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrderPaymentTime).WithMany(p => p.ArsaleOrderPaymentTimeTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleOrderPaymentTimeTemplates_ARSaleOrderPaymentTimes");
        });

        modelBuilder.Entity<ArsaleOrderSaleTypeConfig>(entity =>
        {
            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArsaleOrderSaleTypeConfigs).HasConstraintName("FK_ARSaleOrderSaleTypeConfigs_GECurrencies");
        });

        modelBuilder.Entity<ArsaleOrderTemplate>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsaleOrderTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleOrderTemplates_ARSaleOrders");
        });

        modelBuilder.Entity<ArsaleReturn>(entity =>
        {
            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.ArsaleReturns).HasConstraintName("FK_ARSaleReturns_ACCostCenters");

            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.ArsaleReturns).HasConstraintName("FK_ARSaleReturns_ACEInvoiceTypes");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.ArsaleReturns).HasConstraintName("FK_ARSaleReturns_ARCustomers");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.ArsaleReturns).HasConstraintName("FK_ARSaleReturns_ARSaleContracts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArsaleReturns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturns_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArsaleReturns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturns_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.ArsaleReturns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturns_HREmployees");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArsaleReturns).HasConstraintName("FK_ARSaleReturns_ICStocks");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.ArsaleReturns).HasConstraintName("FK_ARSaleReturns_PMProjects");
        });

        modelBuilder.Entity<ArsaleReturnItem>(entity =>
        {
            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.ArsaleReturnItems).HasConstraintName("ARSaleReturnItems_ACCostObjects");

            entity.HasOne(d => d.FkAcoffsetAccount).WithMany(p => p.ArsaleReturnItems).HasConstraintName("ARSaleReturnItems_ACOffsetAccounts");

            entity.HasOne(d => d.FkArsaleReturn).WithMany(p => p.ArsaleReturnItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItems_ARSaleReturns");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.ArsaleReturnItems).HasConstraintName("FK_ARSaleReturnItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.ArsaleReturnItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.ArsaleReturnItems).HasConstraintName("FK_ARSaleReturnItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleReturnItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArsaleReturnItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArsaleReturnItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItems_ICStocks");
        });

        modelBuilder.Entity<ArsaleReturnItemComponent>(entity =>
        {
            entity.HasOne(d => d.FkArsaleReturnItem).WithMany(p => p.ArsaleReturnItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItemComponents_ARSaleReturnItems");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsaleReturnItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItemComponents_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArsaleReturnItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItemComponents_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArsaleReturnItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSaleReturnItemComponents_ICStocks");
        });

        modelBuilder.Entity<Arsalesman>(entity =>
        {
            entity.HasKey(e => e.ArsalesmanId).HasName("PK_Salesmans");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.Arsalesmen).HasConstraintName("FK_ARSalesmans_ARSaleOrders");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Arsalesmen).HasConstraintName("FK_ARSalesmans_HREmployees");
        });

        modelBuilder.Entity<Arseller>(entity =>
        {
            entity.HasKey(e => e.ArsellerId).HasName("PK_SalePerson");

            entity.Property(e => e.ArsellerActiveCheck)
                .HasDefaultValueSql("((1))")
                .HasComment("Active\r\nInactive\r\nDeleted\r\nDummy");
            entity.Property(e => e.ArsellerContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArsellerContactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.ArsellerBankAccountCurrency1Navigation).WithMany(p => p.ArsellerArsellerBankAccountCurrency1Navigations).HasConstraintName("FK_MASellers_GECurrencies");

            entity.HasOne(d => d.ArsellerBankAccountCurrency2Navigation).WithMany(p => p.ArsellerArsellerBankAccountCurrency2Navigations).HasConstraintName("FK_MASellers_GECurrencies1");

            entity.HasOne(d => d.ArsellerBankAccountCurrency3Navigation).WithMany(p => p.ArsellerArsellerBankAccountCurrency3Navigations).HasConstraintName("FK_MASellers_GECurrencies2");

            entity.HasOne(d => d.ArsellerBankAccountCurrency4Navigation).WithMany(p => p.ArsellerArsellerBankAccountCurrency4Navigations).HasConstraintName("FK_MASellers_GECurrencies3");

            entity.HasOne(d => d.FkArsellerContactLanguageIdcomboNavigation).WithMany(p => p.ArsellerFkArsellerContactLanguageIdcomboNavigations).HasConstraintName("FK_MASellers_GELanguages");

            entity.HasOne(d => d.FkArsellerParent).WithMany(p => p.InverseFkArsellerParent).HasConstraintName("FK_MASellers_MASellers1");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArsellerFkGecurrencies).HasConstraintName("FK_MASellers_GECurrencies4");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.ArsellerFkGelanguages).HasConstraintName("FK_MASellers_GELanguages1");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.Arsellers).HasConstraintName("FK_MASellers_MAShippingMethods");
        });

        modelBuilder.Entity<ArsellerContact>(entity =>
        {
            entity.Property(e => e.ArsellerContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.ArsellerContactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.FkArseller).WithMany(p => p.ArsellerContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSellerContacts_ARSellers");
        });

        modelBuilder.Entity<ArsellerProduct>(entity =>
        {
            entity.HasKey(e => e.ArsellerProductId).HasName("PK_MASellerProduct");

            entity.HasOne(d => d.Arseller).WithMany(p => p.ArsellerProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASellerProduct_MASellers");

            entity.HasOne(d => d.Icproduct).WithMany(p => p.ArsellerProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASellerProduct_MAProducts");
        });

        modelBuilder.Entity<ArsellerProductGroup>(entity =>
        {
            entity.HasKey(e => e.ArsellerProductGroupId).HasName("PK_MASellerProductGroups");

            entity.HasOne(d => d.Arseller).WithMany(p => p.ArsellerProductGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASellerProductGroup_MASellers");

            entity.HasOne(d => d.IcproductGroup).WithMany(p => p.ArsellerProductGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASellerProductGroup_MAProductGroup");
        });

        modelBuilder.Entity<ArsfitemComponent>(entity =>
        {
            entity.HasOne(d => d.FkArsaleForecastItem).WithMany(p => p.ArsfitemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSFItemComponents_ARSaleForecastItems");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsfitemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSFItemComponents_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArsfitemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSFItemComponents_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArsfitemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSFItemComponents_ICStocks");
        });

        modelBuilder.Entity<ArsoitemComponent>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.ArsoitemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSOItemComponents_ARSaleOrderItems");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.ArsoitemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSOItemComponents_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.ArsoitemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSOItemComponents_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.ArsoitemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARSOItemComponents_ICStocks");
        });

        modelBuilder.Entity<ArsopaymentTimeInvoiceDetail>(entity =>
        {
            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.ArsopaymentTimeInvoiceDetailFkAccreditAccounts).HasConstraintName("FK_ARSOPaymentTimeInvoiceDetails_ACAccounts1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.ArsopaymentTimeInvoiceDetailFkAcdebitAccounts).HasConstraintName("FK_ARSOPaymentTimeInvoiceDetails_ACAccounts");

            entity.HasOne(d => d.FkArinvoice).WithMany(p => p.ArsopaymentTimeInvoiceDetails).HasConstraintName("FK_ARSOPaymentTimeInvoiceDetails_ARInvoices");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.ArsopaymentTimeInvoiceDetails).HasConstraintName("FK_ARSOPaymentTimeInvoiceDetails_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderPaymentTime).WithMany(p => p.ArsopaymentTimeInvoiceDetails).HasConstraintName("FK_ARSOPaymentTimeInvoiceDetails_ARSaleOrderPaymentTimes");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.ArsopaymentTimeInvoiceDetails).HasConstraintName("FK_ARSOPaymentTimeInvoiceDetails_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.ArsopaymentTimeInvoiceDetails).HasConstraintName("FK_ARSOPaymentTimeInvoiceDetails_GECurrencies");
        });

        modelBuilder.Entity<AuditDataChange>(entity =>
        {
            entity.Property(e => e.ChangeDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Brbranch>(entity =>
        {
            entity.HasKey(e => e.BrbranchId).HasName("PK_BRBranchServers");

            entity.ToTable("BRBranchs", tb => tb.HasTrigger("TRG_InsertUpdateBranch"));

            entity.Property(e => e.BrbranchContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.BrbranchContactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.BrbranchParent).WithMany(p => p.InverseBrbranchParent).HasConstraintName("FK_BRBranchs_BRBranchs");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.Brbranches).HasConstraintName("FK_BRBranchs_GELocations");
        });

        modelBuilder.Entity<Brhistory>(entity =>
        {
            entity.HasKey(e => e.BrhistoryId).HasName("PK_BRHistory");

            entity.Property(e => e.BrhistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.BrhistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.BrhistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<BrhistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkBrhistory).WithMany(p => p.BrhistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRHistoryDetails_BRHistory");
        });

        modelBuilder.Entity<Brpositem>(entity =>
        {
            entity.HasOne(d => d.FkBrpos).WithMany(p => p.Brpositems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRPOSItems_BRPOSs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.Brpositems).HasConstraintName("FK_BRPOSItems_ICDepartments");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.Brpositems).HasConstraintName("FK_BRPOSItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.Brpositems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRPOSItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Brpositems).HasConstraintName("FK_BRPOSItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.Brpositems).HasConstraintName("FK_BRPOSItems_ICStockSlots");
        });

        modelBuilder.Entity<BrposredemptionItem>(entity =>
        {
            entity.HasOne(d => d.FkBrpos).WithMany(p => p.BrposredemptionItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRPOSRedemptionItems_BRPOSs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.BrposredemptionItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRPOSRedemptionItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.BrposredemptionItems).HasConstraintName("FK_BRPOSRedemptionItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.BrposredemptionItems).HasConstraintName("FK_BRPOSRedemptionItems_ICStockSlots");
        });

        modelBuilder.Entity<Brposs>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Brposses).HasConstraintName("FK_BRPOSs_ARCustomers");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.Brposses).HasConstraintName("FK_BRPOSs_ARPriceLevels");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Brposses).HasConstraintName("FK_BRPOSs_GECurrencies");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.Brposses).HasConstraintName("FK_BRPOSs_GEShippingMethods");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Brposses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRPOSs_HREmployees");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Brposses).HasConstraintName("FK_BRPOSs_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.Brposses).HasConstraintName("FK_BRPOSs_ICStockSlots");
        });

        modelBuilder.Entity<BrpostingHistory>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.BrpostingHistories).HasConstraintName("FK_BRPostingHistorys_BRBranchs");
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasIndex(e => e.Key, "CX_HangFire_Counter").IsClustered();
        });

        modelBuilder.Entity<CrmcallCenterManager>(entity =>
        {
            entity.HasKey(e => e.CrmcallCenterManagerId).HasName("PK__CRMCallC__DC9A187846EB2023");

            entity.Property(e => e.CrmcallCenterManagerId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CrmcallCenterManagerCdr>(entity =>
        {
            entity.HasKey(e => e.CrmcallCenterManagerCdrId).HasName("PK__CRMCallC__16C0C8B3C63FC8A7");

            entity.Property(e => e.CrmcallCenterManagerCdrId).ValueGeneratedNever();
        });

        modelBuilder.Entity<CscashFund>(entity =>
        {
            entity.HasOne(d => d.FkAcacount).WithMany(p => p.CscashFunds).HasConstraintName("FK_CSCashFunds_ACAccounts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.CscashFunds).HasConstraintName("FK_CSCashFunds_BRBranchs");
        });

        modelBuilder.Entity<Cscompany>(entity =>
        {
            entity.HasKey(e => e.CscompanyId).HasName("PK_A1Company");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Cscompanies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CSCompanys_BRBranchs");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.Cscompanies).HasConstraintName("FK_CSCompanys_GELanguages");

            entity.HasOne(d => d.FkGepurchaseCurrency).WithMany(p => p.CscompanyFkGepurchaseCurrencies).HasConstraintName("FK_CSCompanys_GECurrencies");

            entity.HasOne(d => d.FkGesaleCurrency).WithMany(p => p.CscompanyFkGesaleCurrencies).HasConstraintName("FK_CSCompanys_GECurrencies1");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Cscompanies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CSCompanys_ICStocks");
        });

        modelBuilder.Entity<CscompanyBank>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.CscompanyBanks).HasConstraintName("FK_CSCompanyBanks_BRBranchs");
        });

        modelBuilder.Entity<CscompanyConfig>(entity =>
        {
            entity.HasKey(e => e.A1companyConfigId).HasName("PK_A1CompanyConfigs");

            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.CscompanyConfigs).HasConstraintName("FK_A1CompanyConfigs_ADUserGroups");
        });

        modelBuilder.Entity<Faaddress>(entity =>
        {
            entity.Property(e => e.FaaddressId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Facontact>(entity =>
        {
            entity.Property(e => e.FacontactId).ValueGeneratedNever();
            entity.Property(e => e.FacontactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.FacontactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.Faaddress).WithMany(p => p.Facontacts).HasConstraintName("FK_FAContacts_FAAddress");

            entity.HasOne(d => d.FalanguageIdcomboNavigation).WithMany(p => p.Facontacts).HasConstraintName("FK_FAContacts_GELanguages");
        });

        modelBuilder.Entity<FacreditNote>(entity =>
        {
            entity.Property(e => e.FacreditNoteId).ValueGeneratedNever();
            entity.Property(e => e.FacreditNoteIsDiscountPercentCheck).HasDefaultValueSql("((1))");
            entity.Property(e => e.FacreditNoteStornoCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FacurrencyIdcomboNavigation).WithMany(p => p.FacreditNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACreditNotes_GECurrencies");

            entity.HasOne(d => d.FacustomerIdcomboNavigation).WithMany(p => p.FacreditNotes).HasConstraintName("FK_FACreditNotes_MACustomers");

            entity.HasOne(d => d.FalanguageIdcomboNavigation).WithMany(p => p.FacreditNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACreditNotes_GELanguages");

            entity.HasOne(d => d.FasellerIdcomboNavigation).WithMany(p => p.FacreditNotes).HasConstraintName("FK_FACreditNotes_MASellers");

            entity.HasOne(d => d.FashippingMethod).WithMany(p => p.FacreditNotes).HasConstraintName("FK_FACreditNotes_MAShippingMethods");

            entity.HasOne(d => d.FavatregionIdcomboNavigation).WithMany(p => p.FacreditNotes).HasConstraintName("FK_FACreditNotes_GEVATRegions");
        });

        modelBuilder.Entity<FacreditNoteContact>(entity =>
        {
            entity.HasKey(e => e.FacreditNoteContactId).HasName("PK_CreditNoteContact");

            entity.Property(e => e.FacreditNoteContactId).ValueGeneratedNever();

            entity.HasOne(d => d.Facontact).WithMany(p => p.FacreditNoteContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACreditNoteContacts_FAContacts");

            entity.HasOne(d => d.FacreditNote).WithMany(p => p.FacreditNoteContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACreditNoteContacts_FACreditNotes");
        });

        modelBuilder.Entity<FacreditNoteDiscount>(entity =>
        {
            entity.HasKey(e => e.FacreditNoteDiscountId).HasName("PK_CreditNoteDiscount");

            entity.Property(e => e.FacreditNoteDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.FacreditNote).WithMany(p => p.FacreditNoteDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACreditNoteDiscounts_FACreditNotes");

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FacreditNoteDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACreditNoteDiscounts_ADDiscounts");
        });

        modelBuilder.Entity<FacreditNoteHistory>(entity =>
        {
            entity.HasKey(e => e.FacreditNoteHistoryId).HasName("PK_HICreditNoteHistorys");

            entity.Property(e => e.FacreditNoteHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.FacreditNote).WithMany(p => p.FacreditNoteHistories).HasConstraintName("FK_FACreditNoteHistorys_FACreditNotes");

            entity.HasOne(d => d.Facustomer).WithMany(p => p.FacreditNoteHistories).HasConstraintName("FK_FACreditNoteHistorys_MACustomers");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FacreditNoteHistories).HasConstraintName("FK_FACreditNoteHistorys_ADUsers");
        });

        modelBuilder.Entity<FacreditNoteItem>(entity =>
        {
            entity.Property(e => e.FacreditNoteItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FacreditNote).WithMany(p => p.FacreditNoteItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FACreditNoteItems_FACreditNotes");

            entity.HasOne(d => d.FaproductIdcomboNavigation).WithMany(p => p.FacreditNoteItems).HasConstraintName("FK_FACreditNoteItems_MAProducts");

            entity.HasOne(d => d.FastockIdcomboNavigation).WithMany(p => p.FacreditNoteItems).HasConstraintName("FK_FACreditNoteItems_MAStocks");

            entity.HasOne(d => d.FastockSlotIdcomboNavigation).WithMany(p => p.FacreditNoteItems).HasConstraintName("FK_FACreditNoteItems_MAStockSlots");

            entity.HasOne(d => d.FatextIdcomboNavigation).WithMany(p => p.FacreditNoteItems).HasConstraintName("FK_FACreditNoteItems_GETexts");
        });

        modelBuilder.Entity<FacreditNoteItemDiscount>(entity =>
        {
            entity.Property(e => e.FacreditNoteItemDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.FacreditNoteItem).WithMany(p => p.FacreditNoteItemDiscounts).HasConstraintName("FK_FACreditNoteItemDiscount_FACreditNoteItems");

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FacreditNoteItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FACreditNoteItemDiscount_ADDiscounts");
        });

        modelBuilder.Entity<FainvoiceContact>(entity =>
        {
            entity.HasKey(e => e.FainvoiceContactId).HasName("PK_InvoiceContact");

            entity.Property(e => e.FainvoiceContactId).ValueGeneratedNever();

            entity.HasOne(d => d.Facontact).WithMany(p => p.FainvoiceContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAInvoiceContacts_FAContacts");

            entity.HasOne(d => d.Fainvoice).WithMany(p => p.FainvoiceContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAInvoiceContacts_FAInvoices");
        });

        modelBuilder.Entity<FainvoiceCreditNote>(entity =>
        {
            entity.Property(e => e.FainvoiceCreditNoteId).ValueGeneratedNever();

            entity.HasOne(d => d.FacreditNote).WithMany(p => p.FainvoiceCreditNotes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FAInvoiceCreditNotes_FACreditNotes");

            entity.HasOne(d => d.Fainvoice).WithMany(p => p.FainvoiceCreditNotes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FAInvoiceCreditNotes_FAInvoices");
        });

        modelBuilder.Entity<FainvoiceDiscount>(entity =>
        {
            entity.HasKey(e => e.FainvoiceDiscountId).HasName("PK_InvoiceDiscount");

            entity.Property(e => e.FainvoiceDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FainvoiceDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAInvoiceDiscounts_ADDiscounts");

            entity.HasOne(d => d.Fainvoice).WithMany(p => p.FainvoiceDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAInvoiceDiscounts_FAInvoices");
        });

        modelBuilder.Entity<FainvoiceHistory>(entity =>
        {
            entity.HasKey(e => e.FainvoiceHistoryId).HasName("PK_HIInvoiceHistorys");

            entity.Property(e => e.FainvoiceHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.Facustomer).WithMany(p => p.FainvoiceHistories).HasConstraintName("FK_FAInvoiceHistorys_MACustomers");

            entity.HasOne(d => d.Fainvoice).WithMany(p => p.FainvoiceHistories).HasConstraintName("FK_FAInvoiceHistorys_FAInvoices");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FainvoiceHistories).HasConstraintName("FK_FAInvoiceHistorys_ADUsers");
        });

        modelBuilder.Entity<FainvoiceItemCreditNoteItem>(entity =>
        {
            entity.Property(e => e.FainvoiceItemCreditNoteItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FacreditNoteItem).WithMany(p => p.FainvoiceItemCreditNoteItems).HasConstraintName("FK_FAInvoiceItemCreditNoteItems_FACreditNoteItems");
        });

        modelBuilder.Entity<FainvoiceItemDiscount>(entity =>
        {
            entity.HasOne(d => d.Fadiscount).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAInvoiceItemDiscount_ADDiscounts");
        });

        modelBuilder.Entity<FainvoiceItemDiscount1>(entity =>
        {
            entity.Property(e => e.NewfainvoiceItemDiscount).IsFixedLength();
        });

        modelBuilder.Entity<FainvoiceItemSellReturnItem>(entity =>
        {
            entity.Property(e => e.FainvoiceItemSellReturnItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FasellReturnItem).WithMany(p => p.FainvoiceItemSellReturnItems).HasConstraintName("FK_FAInvoiceItemSellReturnItems_FASellReturnItems");
        });

        modelBuilder.Entity<FainvoiceSellReturn>(entity =>
        {
            entity.Property(e => e.FainvoiceSellReturnId).ValueGeneratedNever();

            entity.HasOne(d => d.Fainvoice).WithMany(p => p.FainvoiceSellReturns).HasConstraintName("FK_FAInvoiceSellReturns_FAInvoices");

            entity.HasOne(d => d.FasellReturn).WithMany(p => p.FainvoiceSellReturns).HasConstraintName("FK_FAInvoiceSellReturns_FASellReturns");
        });

        modelBuilder.Entity<FaproposalContact>(entity =>
        {
            entity.HasKey(e => e.FaproposalContactId).HasName("PK_ProposalContact");

            entity.Property(e => e.FaproposalContactId).ValueGeneratedNever();

            entity.HasOne(d => d.Facontact).WithMany(p => p.FaproposalContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAProposalContacts_FAContacts");

            entity.HasOne(d => d.Faproposal).WithMany(p => p.FaproposalContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAProposalContacts_FAProposals");
        });

        modelBuilder.Entity<FaproposalDiscount>(entity =>
        {
            entity.HasKey(e => e.FaproposalDiscountId).HasName("PK_ProposalDiscount");

            entity.Property(e => e.FaproposalDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FaproposalDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAProposalDiscounts_ADDiscounts");

            entity.HasOne(d => d.Faproposal).WithMany(p => p.FaproposalDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAProposalDiscounts_FAProposals");
        });

        modelBuilder.Entity<FaproposalHistory>(entity =>
        {
            entity.HasKey(e => e.FaproposalHistoryId).HasName("PK_HIProposalHistorys");

            entity.Property(e => e.FaproposalHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.Facustomer).WithMany(p => p.FaproposalHistories).HasConstraintName("FK_FAProposalHistorys_MACustomers");

            entity.HasOne(d => d.Faproposal).WithMany(p => p.FaproposalHistories).HasConstraintName("FK_FAProposalHistorys_FAProposals");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FaproposalHistories).HasConstraintName("FK_FAProposalHistorys_ADUsers");
        });

        modelBuilder.Entity<FaproposalItem>(entity =>
        {
            entity.Property(e => e.FaproposalItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FaproductIdcomboNavigation).WithMany(p => p.FaproposalItems).HasConstraintName("FK_FAProposalItems_MAProducts");

            entity.HasOne(d => d.Faproposal).WithMany(p => p.FaproposalItems).HasConstraintName("FK_FAProposalItems_FAProposals");

            entity.HasOne(d => d.FastockIdcomboNavigation).WithMany(p => p.FaproposalItems).HasConstraintName("FK_FAProposalItems_MAStocks");

            entity.HasOne(d => d.FastockSlotIdcomboNavigation).WithMany(p => p.FaproposalItems).HasConstraintName("FK_FAProposalItems_MAStockSlots");

            entity.HasOne(d => d.FatextIdcomboNavigation).WithMany(p => p.FaproposalItems).HasConstraintName("FK_FAProposalItems_GETexts");
        });

        modelBuilder.Entity<FaproposalItemDiscount>(entity =>
        {
            entity.Property(e => e.FaproposalItemDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FaproposalItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAProposalItemDiscount_ADDiscounts");

            entity.HasOne(d => d.FaproposalItem).WithMany(p => p.FaproposalItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAProposalItemDiscount_FAProposalItems");
        });

        modelBuilder.Entity<FaproposalItemSellOrderItem>(entity =>
        {
            entity.Property(e => e.FaproposalItemSellOrderItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FaproposalItem).WithMany(p => p.FaproposalItemSellOrderItems).HasConstraintName("FK_FAProposalItemSellOrderItems_FAProposalItems");

            entity.HasOne(d => d.FasellOrderItem).WithMany(p => p.FaproposalItemSellOrderItems).HasConstraintName("FK_FAProposalItemSellOrderItems_FASellOrderItems");
        });

        modelBuilder.Entity<FaproposalSellOrder>(entity =>
        {
            entity.Property(e => e.FaproposalSellOrderId).ValueGeneratedNever();

            entity.HasOne(d => d.Faproposal).WithMany(p => p.FaproposalSellOrders).HasConstraintName("FK_FAProposalSellOrders_FAProposals");

            entity.HasOne(d => d.FasellOrder).WithMany(p => p.FaproposalSellOrders).HasConstraintName("FK_FAProposalSellOrders_FASellOrders");
        });

        modelBuilder.Entity<FapurchaseOrder>(entity =>
        {
            entity.Property(e => e.FapurchaseOrderId).ValueGeneratedNever();
            entity.Property(e => e.FapurchaseOrderIsDiscountPercentCheck).HasDefaultValueSql("((1))");
            entity.Property(e => e.FapurchaseOrderStornoCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FacurrencyIdcomboNavigation).WithMany(p => p.FapurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrders_GECurrencies");

            entity.HasOne(d => d.FalanguageIdcomboNavigation).WithMany(p => p.FapurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrders_GELanguages");

            entity.HasOne(d => d.FashippingMethod).WithMany(p => p.FapurchaseOrders).HasConstraintName("FK_FAPurchaseOrders_MAShippingMethods");

            entity.HasOne(d => d.FastockIdcomboNavigation).WithMany(p => p.FapurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrders_MAStocks");

            entity.HasOne(d => d.FastockSlotIdcomboNavigation).WithMany(p => p.FapurchaseOrders).HasConstraintName("FK_FAPurchaseOrders_MAStockSlots");

            entity.HasOne(d => d.FasupplierIdcomboNavigation).WithMany(p => p.FapurchaseOrders).HasConstraintName("FK_FAPurchaseOrders_MASuppliers");

            entity.HasOne(d => d.FavatregionIdcomboNavigation).WithMany(p => p.FapurchaseOrders).HasConstraintName("FK_FAPurchaseOrders_GEVATRegions");
        });

        modelBuilder.Entity<FapurchaseOrderContact>(entity =>
        {
            entity.HasKey(e => e.FapurchaseOrderContactId).HasName("PK_PurchaseOrderContact");

            entity.Property(e => e.FapurchaseOrderContactId).ValueGeneratedNever();

            entity.HasOne(d => d.Facontact).WithMany(p => p.FapurchaseOrderContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrderContacts_FAContacts");

            entity.HasOne(d => d.FapurchaseOrder).WithMany(p => p.FapurchaseOrderContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrderContacts_FAPurchaseOrders");
        });

        modelBuilder.Entity<FapurchaseOrderDiscount>(entity =>
        {
            entity.HasKey(e => e.FapurchaseOrderDiscountId).HasName("PK_PurchaseOrderDiscount");

            entity.Property(e => e.FapurchaseOrderDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FapurchaseOrderDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrderDiscounts_ADDiscounts");

            entity.HasOne(d => d.FapurchaseOrder).WithMany(p => p.FapurchaseOrderDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrderDiscounts_FAPurchaseOrders");
        });

        modelBuilder.Entity<FapurchaseOrderHistory>(entity =>
        {
            entity.HasKey(e => e.FapurchaseOrderHistoryId).HasName("PK_HIPurchaseOrderHistorys");

            entity.Property(e => e.FapurchaseOrderHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.FapurchaseOrder).WithMany(p => p.FapurchaseOrderHistories).HasConstraintName("FK_FAPurchaseOrderHistorys_FAPurchaseOrders");

            entity.HasOne(d => d.Fasupplier).WithMany(p => p.FapurchaseOrderHistories).HasConstraintName("FK_FAPurchaseOrderHistorys_MASuppliers");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FapurchaseOrderHistories).HasConstraintName("FK_FAPurchaseOrderHistorys_ADUsers");
        });

        modelBuilder.Entity<FapurchaseOrderItem>(entity =>
        {
            entity.Property(e => e.FapurchaseOrderItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FaproductIdcomboNavigation).WithMany(p => p.FapurchaseOrderItems).HasConstraintName("FK_FAPurchaseOrderItems_MAProducts");

            entity.HasOne(d => d.FapurchaseOrder).WithMany(p => p.FapurchaseOrderItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FAPurchaseOrderItems_FAPurchaseOrders");

            entity.HasOne(d => d.FastockIdcomboNavigation).WithMany(p => p.FapurchaseOrderItems).HasConstraintName("FK_FAPurchaseOrderItems_MAStocks");

            entity.HasOne(d => d.FastockSlotIdcomboNavigation).WithMany(p => p.FapurchaseOrderItems).HasConstraintName("FK_FAPurchaseOrderItems_MAStockSlots");

            entity.HasOne(d => d.FatextIdcomboNavigation).WithMany(p => p.FapurchaseOrderItems).HasConstraintName("FK_FAPurchaseOrderItems_GETexts");
        });

        modelBuilder.Entity<FapurchaseOrderItemDiscount>(entity =>
        {
            entity.Property(e => e.FapurchaseOrderItemDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FapurchaseOrderItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrderItemDiscount_ADDiscounts");

            entity.HasOne(d => d.FapurchaseOrderItem).WithMany(p => p.FapurchaseOrderItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAPurchaseOrderItemDiscount_FAPurchaseOrderItems");
        });

        modelBuilder.Entity<FapurchaseOrderItemReceiptItem>(entity =>
        {
            entity.HasKey(e => e.FapurchaseOrderItemReceiptItemId).HasName("PK_FAReceiptItemPurchaseOrderItems");

            entity.Property(e => e.FapurchaseOrderItemReceiptItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FapurchaseOrderItem).WithMany(p => p.FapurchaseOrderItemReceiptItems).HasConstraintName("FK_FAReceiptItemPurchaseOrderItems_FAPurchaseOrderItems");

            entity.HasOne(d => d.FareceiptItem).WithMany(p => p.FapurchaseOrderItemReceiptItems).HasConstraintName("FK_FAReceiptItemPurchaseOrderItems_FAReceiptItems");
        });

        modelBuilder.Entity<FapurchaseOrderItemSellOrderItem>(entity =>
        {
            entity.Property(e => e.FapurchaseOrderItemSellOrderItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FapurchaseOrderItem).WithMany(p => p.FapurchaseOrderItemSellOrderItems).HasConstraintName("FK_FAPurchaseOrderItemSellOrderItems_FAPurchaseOrderItems");

            entity.HasOne(d => d.FasellOrderItem).WithMany(p => p.FapurchaseOrderItemSellOrderItems).HasConstraintName("FK_FAPurchaseOrderItemSellOrderItems_FASellOrderItems");
        });

        modelBuilder.Entity<FapurchaseOrderReceipt>(entity =>
        {
            entity.HasKey(e => e.FapurchaseOrderReceiptId).HasName("PK_FAReceiptSellOrders");

            entity.Property(e => e.FapurchaseOrderReceiptId).ValueGeneratedNever();

            entity.HasOne(d => d.FapurchaseOrder).WithMany(p => p.FapurchaseOrderReceipts).HasConstraintName("FK_FAReceiptPurchaseOrders_FAPurchaseOrders");

            entity.HasOne(d => d.Fareceipt).WithMany(p => p.FapurchaseOrderReceipts).HasConstraintName("FK_FAReceiptPurchaseOrders_FAReceipts");
        });

        modelBuilder.Entity<FapurchaseOrderSellOrder>(entity =>
        {
            entity.Property(e => e.FapurchaseOrderSellOrderId).ValueGeneratedNever();

            entity.HasOne(d => d.FapurchaseOrder).WithMany(p => p.FapurchaseOrderSellOrders).HasConstraintName("FK_FAPurchaseOrderSellOrders_FAPurchaseOrders");

            entity.HasOne(d => d.FasellOrder).WithMany(p => p.FapurchaseOrderSellOrders).HasConstraintName("FK_FAPurchaseOrderSellOrders_FASellOrders");
        });

        modelBuilder.Entity<FareceiptContact>(entity =>
        {
            entity.HasKey(e => e.FareceiptContactId).HasName("PK_ReceiptContact");

            entity.Property(e => e.FareceiptContactId).ValueGeneratedNever();

            entity.HasOne(d => d.Facontact).WithMany(p => p.FareceiptContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReceiptContacts_FAContacts");

            entity.HasOne(d => d.Fareceipt).WithMany(p => p.FareceiptContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReceiptContacts_FAReceipts");
        });

        modelBuilder.Entity<FareceiptCreditNote>(entity =>
        {
            entity.Property(e => e.FareceiptCreditNoteId).ValueGeneratedNever();

            entity.HasOne(d => d.FacreditNote).WithMany(p => p.FareceiptCreditNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReceiptCreditNotes_FACreditNotes");

            entity.HasOne(d => d.Fareceipt).WithMany(p => p.FareceiptCreditNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReceiptCreditNotes_FAReceipts");
        });

        modelBuilder.Entity<FareceiptDiscount>(entity =>
        {
            entity.HasKey(e => e.FareceiptDiscountId).HasName("PK_ReceiptDiscount");

            entity.Property(e => e.FareceiptDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FareceiptDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReceiptDiscounts_ADDiscounts");

            entity.HasOne(d => d.Fareceipt).WithMany(p => p.FareceiptDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReceiptDiscounts_FAReceipts");
        });

        modelBuilder.Entity<FareceiptHistory>(entity =>
        {
            entity.HasKey(e => e.FareceiptHistoryId).HasName("PK_HIReceiptHistorys");

            entity.Property(e => e.FareceiptHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.Fareceipt).WithMany(p => p.FareceiptHistories).HasConstraintName("FK_FAReceiptHistorys_FAReceipts");

            entity.HasOne(d => d.Fasupplier).WithMany(p => p.FareceiptHistories).HasConstraintName("FK_FAReceiptHistorys_MASuppliers");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FareceiptHistories).HasConstraintName("FK_FAReceiptHistorys_ADUsers");
        });

        modelBuilder.Entity<FareceiptItemCreditNoteItem>(entity =>
        {
            entity.Property(e => e.FareceiptItemCreditNoteItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FacreditNoteItem).WithMany(p => p.FareceiptItemCreditNoteItems).HasConstraintName("FK_FAReceiptItemCreditNoteItems_FACreditNoteItems");

            entity.HasOne(d => d.FareceiptItem).WithMany(p => p.FareceiptItemCreditNoteItems).HasConstraintName("FK_FAReceiptItemCreditNoteItems_FAReceiptItems");
        });

        modelBuilder.Entity<FareceiptItemDiscount>(entity =>
        {
            entity.Property(e => e.FareceiptItemDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FareceiptItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReceiptItemDiscount_ADDiscounts");

            entity.HasOne(d => d.FareceiptItem).WithMany(p => p.FareceiptItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReceiptItemDiscount_FAReceiptItems");
        });

        modelBuilder.Entity<FareturnSupplier>(entity =>
        {
            entity.Property(e => e.FareturnSupplierId).ValueGeneratedNever();
            entity.Property(e => e.FareturnSupplierIsDiscountPercentCheck).HasDefaultValueSql("((1))");
            entity.Property(e => e.FareturnSupplierStornoCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FacurrencyIdcomboNavigation).WithMany(p => p.FareturnSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReturnSuppliers_GECurrencies");

            entity.HasOne(d => d.FacustomerIdcomboNavigation).WithMany(p => p.FareturnSuppliers).HasConstraintName("FK_FAReturnSuppliers_MACustomers");

            entity.HasOne(d => d.FalanguageIdcomboNavigation).WithMany(p => p.FareturnSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReturnSuppliers_GELanguages");

            entity.HasOne(d => d.FasellerIdcomboNavigation).WithMany(p => p.FareturnSuppliers).HasConstraintName("FK_FAReturnSuppliers_MASellers");

            entity.HasOne(d => d.FashippingMethod).WithMany(p => p.FareturnSuppliers).HasConstraintName("FK_FAReturnSuppliers_MAShippingMethods");

            entity.HasOne(d => d.FavatregionIdcomboNavigation).WithMany(p => p.FareturnSuppliers).HasConstraintName("FK_FAReturnSuppliers_GEVATRegions");
        });

        modelBuilder.Entity<FareturnSupplierContact>(entity =>
        {
            entity.HasKey(e => e.FareturnSupplierContactId).HasName("PK_ReturnSupplierContact");

            entity.Property(e => e.FareturnSupplierContactId).ValueGeneratedNever();
            entity.Property(e => e.NewfareturnSupplierContact).IsFixedLength();

            entity.HasOne(d => d.Facontact).WithMany(p => p.FareturnSupplierContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReturnSupplierContacts_FAContacts");

            entity.HasOne(d => d.FareturnSupplier).WithMany(p => p.FareturnSupplierContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReturnSupplierContacts_FAReturnSuppliers");
        });

        modelBuilder.Entity<FareturnSupplierDiscount>(entity =>
        {
            entity.Property(e => e.NewfashipmentDiscount).IsFixedLength();

            entity.HasOne(d => d.Fadiscount).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReturnSupplierDiscount_ADDiscounts");

            entity.HasOne(d => d.FareturnSupplier).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReturnSupplierDiscount_FAReturnSuppliers");
        });

        modelBuilder.Entity<FareturnSupplierHistory>(entity =>
        {
            entity.HasKey(e => e.FareturnSupplierHistoryId).HasName("PK_HIReturnSupplierHistorys");

            entity.Property(e => e.FareturnSupplierHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.FareturnSupplier).WithMany(p => p.FareturnSupplierHistories).HasConstraintName("FK_FAReturnSupplierHistorys_FAReturnSuppliers1");

            entity.HasOne(d => d.Fasupplier).WithMany(p => p.FareturnSupplierHistories).HasConstraintName("FK_FAReturnSupplierHistorys_MASuppliers");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FareturnSupplierHistories).HasConstraintName("FK_FAReturnSupplierHistorys_ADUsers1");
        });

        modelBuilder.Entity<FareturnSupplierInvoice>(entity =>
        {
            entity.Property(e => e.FareturnSupplierInvoiceId).ValueGeneratedNever();

            entity.HasOne(d => d.Fainvoice).WithMany(p => p.FareturnSupplierInvoices).HasConstraintName("FK_FAReturnSupplierInvoices_FAInvoices");

            entity.HasOne(d => d.FareturnSupplier).WithMany(p => p.FareturnSupplierInvoices).HasConstraintName("FK_FAReturnSupplierInvoices_FAReturnSuppliers");
        });

        modelBuilder.Entity<FareturnSupplierItem>(entity =>
        {
            entity.Property(e => e.FareturnSupplierItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FaproductIdcomboNavigation).WithMany(p => p.FareturnSupplierItems).HasConstraintName("FK_FAReturnSupplierItems_MAProducts");

            entity.HasOne(d => d.FareturnSupplier).WithMany(p => p.FareturnSupplierItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FAReturnSupplierItems_FAReturnSuppliers");

            entity.HasOne(d => d.FastockSlotIdcomboNavigation).WithMany(p => p.FareturnSupplierItems).HasConstraintName("FK_FAReturnSupplierItems_MAStockSlots");

            entity.HasOne(d => d.FatextIdcomboNavigation).WithMany(p => p.FareturnSupplierItems).HasConstraintName("FK_FAReturnSupplierItems_GETexts");
        });

        modelBuilder.Entity<FareturnSupplierItemDiscount>(entity =>
        {
            entity.HasOne(d => d.Fadiscount).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReturnSupplierItemDiscount_ADDiscounts");

            entity.HasOne(d => d.FareturnSupplierItem).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAReturnSupplierItemDiscount_FAReturnSupplierItems");
        });

        modelBuilder.Entity<FareturnSupplierItemReceiptItem>(entity =>
        {
            entity.HasKey(e => e.FareturnSupplierItemReceiptItemId).HasName("PK_FAReturnSupplierItemInvoiceItems");

            entity.Property(e => e.FareturnSupplierItemReceiptItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FareceiptItem).WithMany(p => p.FareturnSupplierItemReceiptItems).HasConstraintName("FK_FAReturnSupplierItemReceiptItems_FAReceiptItems");

            entity.HasOne(d => d.FareturnSupplierItem).WithMany(p => p.FareturnSupplierItemReceiptItems).HasConstraintName("FK_FAReturnSupplierItemReceiptItems_FAReturnSupplierItems");
        });

        modelBuilder.Entity<FasellOrderContact>(entity =>
        {
            entity.HasKey(e => e.FasellOrderContactId).HasName("PK_SellOrderContact");

            entity.Property(e => e.FasellOrderContactId).ValueGeneratedNever();

            entity.HasOne(d => d.FasellOrder).WithMany(p => p.FasellOrderContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellOrderContacts_FASellOrders");
        });

        modelBuilder.Entity<FasellOrderDiscount>(entity =>
        {
            entity.HasKey(e => e.FasellOrderDiscountId).HasName("PK_SellOrderDiscount");

            entity.Property(e => e.FasellOrderDiscountId).ValueGeneratedNever();
            entity.Property(e => e.FadiscountId).HasComment("0:Percent\r\n1:Amount");

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FasellOrderDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellOrderDiscounts_ADDiscounts");

            entity.HasOne(d => d.FasellOrder).WithMany(p => p.FasellOrderDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellOrderDiscounts_FASellOrders");
        });

        modelBuilder.Entity<FasellOrderItemDiscount>(entity =>
        {
            entity.Property(e => e.FadiscountId).HasComment("0:Percent\r\n1:Amount");

            entity.HasOne(d => d.Fadiscount).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellOrderItemDiscount_ADDiscounts");

            entity.HasOne(d => d.FasellOrderItem).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellOrderItemDiscount_FASellOrderItems");
        });

        modelBuilder.Entity<FasellReturn>(entity =>
        {
            entity.Property(e => e.FasellReturnId).ValueGeneratedNever();
            entity.Property(e => e.FasellReturnIsDiscountPercentCheck).HasDefaultValueSql("((1))");
            entity.Property(e => e.FasellReturnStornoCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FacurrencyIdcomboNavigation).WithMany(p => p.FasellReturns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellReturns_GECurrencies");

            entity.HasOne(d => d.FacustomerIdcomboNavigation).WithMany(p => p.FasellReturns).HasConstraintName("FK_FASellReturns_MACustomers");

            entity.HasOne(d => d.FalanguageIdcomboNavigation).WithMany(p => p.FasellReturns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellReturns_GELanguages");

            entity.HasOne(d => d.FasellerIdcomboNavigation).WithMany(p => p.FasellReturns).HasConstraintName("FK_FASellReturns_MASellers");

            entity.HasOne(d => d.FavatregionIdcomboNavigation).WithMany(p => p.FasellReturns).HasConstraintName("FK_FASellReturns_GEVATRegions");
        });

        modelBuilder.Entity<FasellReturnContact>(entity =>
        {
            entity.HasKey(e => e.FasellReturnContactId).HasName("PK_SellReturnContact");

            entity.Property(e => e.FasellReturnContactId).ValueGeneratedNever();

            entity.HasOne(d => d.Facontact).WithMany(p => p.FasellReturnContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellReturnContacts_FAContacts");

            entity.HasOne(d => d.FasellReturn).WithMany(p => p.FasellReturnContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellReturnContacts_FASellReturns");
        });

        modelBuilder.Entity<FasellReturnDiscount>(entity =>
        {
            entity.HasKey(e => e.FasellReturnDiscountId).HasName("PK_SellReturnDiscount");

            entity.Property(e => e.FasellReturnDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FasellReturnDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellReturnDiscounts_ADDiscounts");

            entity.HasOne(d => d.FasellReturn).WithMany(p => p.FasellReturnDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellReturnDiscounts_FASellReturns");
        });

        modelBuilder.Entity<FasellReturnHistory>(entity =>
        {
            entity.Property(e => e.FasellReturnHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.Facustomer).WithMany(p => p.FasellReturnHistories).HasConstraintName("FK_FASellReturnHistorys_MACustomers");

            entity.HasOne(d => d.FasellReturn).WithMany(p => p.FasellReturnHistories).HasConstraintName("FK_FASellReturnHistorys_FASellReturns");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FasellReturnHistories).HasConstraintName("FK_FASellReturnHistorys_ADUsers");
        });

        modelBuilder.Entity<FasellReturnItem>(entity =>
        {
            entity.Property(e => e.FasellReturnItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FaproductIdcomboNavigation).WithMany(p => p.FasellReturnItems).HasConstraintName("FK_FASellReturnItems_MAProducts");

            entity.HasOne(d => d.FasellReturn).WithMany(p => p.FasellReturnItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FASellReturnItems_FASellReturns");

            entity.HasOne(d => d.FastockIdcomboNavigation).WithMany(p => p.FasellReturnItems).HasConstraintName("FK_FASellReturnItems_MAStocks");

            entity.HasOne(d => d.FastockSlotIdcomboNavigation).WithMany(p => p.FasellReturnItems).HasConstraintName("FK_FASellReturnItems_MAStockSlots");

            entity.HasOne(d => d.FatextIdcomboNavigation).WithMany(p => p.FasellReturnItems).HasConstraintName("FK_FASellReturnItems_GETexts");
        });

        modelBuilder.Entity<FasellReturnItemDiscount>(entity =>
        {
            entity.Property(e => e.FasellReturnItemDiscountId).ValueGeneratedNever();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FasellReturnItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellReturnItemDiscount_ADDiscounts");

            entity.HasOne(d => d.FasellReturnItem).WithMany(p => p.FasellReturnItemDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FASellReturnItemDiscount_FASellReturnItems");
        });

        modelBuilder.Entity<FasellReturnItemReceiptItem>(entity =>
        {
            entity.HasKey(e => e.FasellReturnItemReceiptItemId).HasName("PK_FASellReturnItemReceiptItem");

            entity.Property(e => e.FasellReturnItemReceiptItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FareceiptItem).WithMany(p => p.FasellReturnItemReceiptItems).HasConstraintName("FK_FASellReturnItemReceiptItem_FAReceiptItems");

            entity.HasOne(d => d.FasellReturnItem).WithMany(p => p.FasellReturnItemReceiptItems).HasConstraintName("FK_FASellReturnItemReceiptItem_FASellReturnItems");
        });

        modelBuilder.Entity<FasellReturnReceipt>(entity =>
        {
            entity.Property(e => e.FasellReturnReceiptId).ValueGeneratedNever();

            entity.HasOne(d => d.Fareceipt).WithMany(p => p.FasellReturnReceipts).HasConstraintName("FK_FASellReturnReceipts_FAReceipts");

            entity.HasOne(d => d.FasellReturn).WithMany(p => p.FasellReturnReceipts).HasConstraintName("FK_FASellReturnReceipts_FASellReturns");
        });

        modelBuilder.Entity<FashipmentContact>(entity =>
        {
            entity.HasKey(e => e.FashipmentContactId).HasName("PK_ShipmentContact");

            entity.Property(e => e.FashipmentContactId).ValueGeneratedNever();
            entity.Property(e => e.NewfashipmentContact).IsFixedLength();

            entity.HasOne(d => d.Facontact).WithMany(p => p.FashipmentContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAShipmentContacts_FAContacts");

            entity.HasOne(d => d.Fashipment).WithMany(p => p.FashipmentContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAShipmentContacts_FAShipments");
        });

        modelBuilder.Entity<FashipmentDiscount>(entity =>
        {
            entity.HasKey(e => e.FashipmentDiscountId).HasName("PK_ShipmentDiscount");

            entity.Property(e => e.FashipmentDiscountId).ValueGeneratedNever();
            entity.Property(e => e.NewfashipmentDiscount).IsFixedLength();

            entity.HasOne(d => d.Fadiscount).WithMany(p => p.FashipmentDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAShipmentDiscounts_ADDiscounts");

            entity.HasOne(d => d.Fashipment).WithMany(p => p.FashipmentDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAShipmentDiscounts_FAShipments");
        });

        modelBuilder.Entity<FashipmentHistory>(entity =>
        {
            entity.HasKey(e => e.FashipmentHistoryId).HasName("PK_HIShipmentHistorys");

            entity.Property(e => e.FashipmentHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.Facustomer).WithMany(p => p.FashipmentHistories).HasConstraintName("FK_FAShipmentHistorys_MACustomers");

            entity.HasOne(d => d.Fashipment).WithMany(p => p.FashipmentHistories).HasConstraintName("FK_FAShipmentHistorys_FAShipments");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FashipmentHistories).HasConstraintName("FK_FAShipmentHistorys_ADUsers");
        });

        modelBuilder.Entity<FashipmentInvoice>(entity =>
        {
            entity.Property(e => e.FashipmentInvoiceId).ValueGeneratedNever();

            entity.HasOne(d => d.Fainvoice).WithMany(p => p.FashipmentInvoices).HasConstraintName("FK_FAShipmentInvoices_FAInvoices");

            entity.HasOne(d => d.Fashipment).WithMany(p => p.FashipmentInvoices).HasConstraintName("FK_FAShipmentInvoices_FAShipments");
        });

        modelBuilder.Entity<FashipmentItemDiscount>(entity =>
        {
            entity.HasOne(d => d.Fadiscount).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAShipmentItemDiscount_ADDiscounts");

            entity.HasOne(d => d.FashipmentItem).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAShipmentItemDiscount_FAShipmentItems");
        });

        modelBuilder.Entity<FashipmentItemInvoiceItem>(entity =>
        {
            entity.Property(e => e.FashipmentItemInvoiceItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FashipmentItem).WithMany(p => p.FashipmentItemInvoiceItems).HasConstraintName("FK_FAShipmentItemInvoiceItems_FAShipmentItems");
        });

        modelBuilder.Entity<Fatransfer>(entity =>
        {
            entity.Property(e => e.FatransferId).ValueGeneratedNever();
            entity.Property(e => e.FatransferStornoCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FatransferStockInContact).WithMany(p => p.FatransferFatransferStockInContacts).HasConstraintName("FK_FATransfers_MAStocks1");

            entity.HasOne(d => d.FatransferStockOutContact).WithMany(p => p.FatransferFatransferStockOutContacts).HasConstraintName("FK_FATransfers_MAStocks");

            entity.HasOne(d => d.FatransferWorkingContact).WithMany(p => p.FatransferFatransferWorkingContacts).HasConstraintName("FK_FATransfers_MAStocks2");
        });

        modelBuilder.Entity<FatransferHistory>(entity =>
        {
            entity.Property(e => e.FatransferHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.Fatransfer).WithMany(p => p.FatransferHistories).HasConstraintName("FK_FATransferHistorys_FATransfers");

            entity.HasOne(d => d.Fauser).WithMany(p => p.FatransferHistories).HasConstraintName("FK_FATransferHistorys_ADUsers");
        });

        modelBuilder.Entity<FatransferStockInItem>(entity =>
        {
            entity.Property(e => e.FatransferStockInItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FaproductIdcomboNavigation).WithMany(p => p.FatransferStockInItems).HasConstraintName("FK_FATransferStockInItems_MAProducts");

            entity.HasOne(d => d.FastockIdcomboNavigation).WithMany(p => p.FatransferStockInItems).HasConstraintName("FK_FATransferStockInItems_MAStocks");

            entity.HasOne(d => d.FastockSlotIdcomboNavigation).WithMany(p => p.FatransferStockInItems).HasConstraintName("FK_FATransferStockInItems_MAStockSlots");

            entity.HasOne(d => d.FatextIdcomboNavigation).WithMany(p => p.FatransferStockInItems).HasConstraintName("FK_FATransferStockInItems_GETexts");

            entity.HasOne(d => d.Fatransfer).WithMany(p => p.FatransferStockInItems).HasConstraintName("FK_FATransferStockInItems_FATransfers");
        });

        modelBuilder.Entity<FatransferStockOutItem>(entity =>
        {
            entity.Property(e => e.FatransferStockOutItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FaproductIdcomboNavigation).WithMany(p => p.FatransferStockOutItems).HasConstraintName("FK_FATransferStockOutItems_MAProducts");

            entity.HasOne(d => d.FastockIdcomboNavigation).WithMany(p => p.FatransferStockOutItems).HasConstraintName("FK_FATransferStockOutItems_MAStocks");

            entity.HasOne(d => d.FastockSlotIdcomboNavigation).WithMany(p => p.FatransferStockOutItems).HasConstraintName("FK_FATransferStockOutItems_MAStockSlots");

            entity.HasOne(d => d.FatextIdcomboNavigation).WithMany(p => p.FatransferStockOutItems).HasConstraintName("FK_FATransferStockOutItems_GETexts");

            entity.HasOne(d => d.Fatransfer).WithMany(p => p.FatransferStockOutItems).HasConstraintName("FK_FATransferStockOutItems_FATransfers");
        });

        modelBuilder.Entity<FatransferStockOutItemTransferStockInItem>(entity =>
        {
            entity.HasKey(e => e.FatransferStockOutItemTransferStockInItemId).HasName("PK_FATransferReceiptItems");

            entity.Property(e => e.FatransferStockOutItemTransferStockInItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FatransferStockInItem).WithMany(p => p.FatransferStockOutItemTransferStockInItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FATransferStockOutItemTransferStockInItems_FATransferStockInItems");

            entity.HasOne(d => d.FatransferStockOutItem).WithMany(p => p.FatransferStockOutItemTransferStockInItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FATransferStockOutItemTransferStockInItems_FATransferStockOutItems");
        });

        modelBuilder.Entity<GeaccountingFormulaItem>(entity =>
        {
            entity.HasOne(d => d.FkGeaccountingFormula).WithMany(p => p.GeaccountingFormulaItems).HasConstraintName("FK_GEAccountingFormulaItems_GEAccountingFormulas");
        });

        modelBuilder.Entity<Gebank>(entity =>
        {
            entity.HasKey(e => e.GebankId).HasName("PK_Bank");
        });

        modelBuilder.Entity<Gecorrespondence>(entity =>
        {
            entity.HasOne(d => d.Gemodule).WithMany(p => p.Gecorrespondences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GECorrespondences_STModules");
        });

        modelBuilder.Entity<Gecurrency>(entity =>
        {
            entity.HasKey(e => e.GecurrencyId).HasName("PK_Currency");

            entity.HasOne(d => d.FkStfieldFormatGroup).WithMany(p => p.Gecurrencies).HasConstraintName("FK_GECurrencies_STFieldFormatGroups");
        });

        modelBuilder.Entity<GecurrencyExchangeRate>(entity =>
        {
            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.GecurrencyExchangeRates).HasConstraintName("FK_GECurrencyExchangeRates_GECurrencies");
        });

        modelBuilder.Entity<GecurrencyHistory>(entity =>
        {
            entity.HasKey(e => e.GecurrencyHistoryId).HasName("PK_CurrencyHistory");

            entity.HasOne(d => d.Gecurrency).WithMany(p => p.GecurrencyHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GECurrencyHistory_GECurrencies");
        });

        modelBuilder.Entity<Gedistrict>(entity =>
        {
            entity.HasOne(d => d.FkGestateProvince).WithMany(p => p.Gedistricts).HasConstraintName("FK_GEDistricts_GEStateProvinces");
        });

        modelBuilder.Entity<GefiscalPeriod>(entity =>
        {
            entity.HasKey(e => e.GefiscalPeriodId).HasName("PK_ADPeriodes");

            entity.HasOne(d => d.FkGefiscalYear).WithMany(p => p.GefiscalPeriods).HasConstraintName("FK_ADFiscalPeriods_ADFiscalYears");
        });

        modelBuilder.Entity<GefiscalYear>(entity =>
        {
            entity.HasKey(e => e.GefiscalYearId).HasName("PK_ADFiscalYears");
        });

        modelBuilder.Entity<GehistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkGeobjectHistory).WithMany(p => p.GehistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEHistoryDetails_GEObjectHistory");
        });

        modelBuilder.Entity<GehistoryDetailOfProductBranchPrice>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.GehistoryDetailOfProductBranchPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEHistoryDetailOfProductBranchPrices_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.GehistoryDetailOfProductBranchPrices).HasConstraintName("FK_GEHistoryDetailOfProductBranchPrices_GECurrencies");

            entity.HasOne(d => d.FkGeobjectHistory).WithMany(p => p.GehistoryDetailOfProductBranchPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEHistoryDetailOfProductBranchPrices_GEObjectHistory");
        });

        modelBuilder.Entity<Gelanguage>(entity =>
        {
            entity.HasKey(e => e.GelanguageId).HasName("PK_Language");
        });

        modelBuilder.Entity<Gelocation>(entity =>
        {
            entity.HasOne(d => d.GelocationParent).WithMany(p => p.InverseGelocationParent).HasConstraintName("FK_GELocations_GELocations");
        });

        modelBuilder.Entity<Genumbering>(entity =>
        {
            entity.Property(e => e.GenumberingDesc)
                .HasDefaultValueSql("((0))")
                .HasComment("0:Auto\r\n1:Manual");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Genumberings).HasConstraintName("FK_GENumbering_BRBranchs");
        });

        modelBuilder.Entity<Geobject>(entity =>
        {
            entity.HasKey(e => e.GeobjectId).HasName("PK__GEObject__9D7A49732708C312");
        });

        modelBuilder.Entity<GepackageNumeringConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.GepackageNumeringConfigs).HasConstraintName("FK_GEPackageNumeringConfigs_ICProductAttributes");
        });

        modelBuilder.Entity<GepaymentTermItem>(entity =>
        {
            entity.HasOne(d => d.FkGepaymentTerm).WithMany(p => p.GepaymentTermItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEPaymentTermItemItems_GEPaymentTerms");
        });

        modelBuilder.Entity<Geregion>(entity =>
        {
            entity.HasOne(d => d.FkGecountry).WithMany(p => p.Geregions).HasConstraintName("FK_GERegions_GECountrys");
        });

        modelBuilder.Entity<GeshippingMethod>(entity =>
        {
            entity.HasKey(e => e.GeshippingMethodId).HasName("PK_CustomerShippingMethod");

            entity.Property(e => e.GeshippingMethodActiveCheck).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<GestateProvince>(entity =>
        {
            entity.HasOne(d => d.FkGecountry).WithMany(p => p.GestateProvinces).HasConstraintName("FK_GEStateProvinces_GECountrys");

            entity.HasOne(d => d.FkGeregion).WithMany(p => p.GestateProvinces).HasConstraintName("FK_GEStateProvinces_GERegions");
        });

        modelBuilder.Entity<GestockNumbering>(entity =>
        {
            entity.HasKey(e => e.GestockNumberingId).HasName("PK_GLStockNumberings");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.GestockNumberings).HasConstraintName("FK_GEStockNumberings_ICStocks");
        });

        modelBuilder.Entity<Gestreet>(entity =>
        {
            entity.HasOne(d => d.FkGeward).WithMany(p => p.Gestreets).HasConstraintName("FK_GEStreets_GEWards");
        });

        modelBuilder.Entity<Getemplate>(entity =>
        {
            entity.HasKey(e => e.GetemplateId).HasName("PK_MEMedicalTemplates");
        });

        modelBuilder.Entity<Getext>(entity =>
        {
            entity.HasKey(e => e.GetextId).HasName("PK_GEText");

            entity.HasOne(d => d.GelanguageIdcomboNavigation).WithMany(p => p.Getexts).HasConstraintName("FK_GETexts_GELanguages");
        });

        modelBuilder.Entity<GeunitCostContainer>(entity =>
        {
            entity.HasOne(d => d.FkGecontainer).WithMany(p => p.GeunitCostContainers).HasConstraintName("GEUnitCostContainers_FK_GEContainerID");
        });

        modelBuilder.Entity<GeuserAudit>(entity =>
        {
            entity.HasKey(e => e.GeuserAuditId).HasName("PK_UserAudit");

            entity.Property(e => e.GeuserAuditAction).HasComment("0:Create\r\n1:Modify\r\n2:Delete");
        });

        modelBuilder.Entity<Geward>(entity =>
        {
            entity.HasOne(d => d.FkGedistrict).WithMany(p => p.Gewards).HasConstraintName("FK_GEWards_GEDistricts");
        });

        modelBuilder.Entity<Glaccount>(entity =>
        {
            entity.Property(e => e.GlaccountId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Field }).HasName("PK_HangFire_Hash");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<HradjustSocialInsurance>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HradjustSocialInsurances).HasConstraintName("FK_HRAdjustSocialInsurances_BRBranchs");
        });

        modelBuilder.Entity<HradvanceRefund>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HradvanceRefunds).HasConstraintName("FK_HRAdvanceRefunds_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.HradvanceRefunds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAdvanceRefunds_GECurrencies");

            entity.HasOne(d => d.FkHremployeeCompleted).WithMany(p => p.HradvanceRefundFkHremployeeCompleteds).HasConstraintName("FK_HRAdvanceRefunds_HREmployeeCompleteds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HradvanceRefundFkHremployees).HasConstraintName("FK_HRAdvanceRefunds_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.HradvanceRefunds).HasConstraintName("FK_HRAdvanceRefunds_PMProjects");
        });

        modelBuilder.Entity<HradvanceRefundItemInvoice>(entity =>
        {
            entity.HasOne(d => d.FkAcbankTransaction).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_ACBankTransactions");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_FK_ACCostCenterID");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_ACCostObjects");

            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.HradvanceRefundItemInvoiceFkAccreditAccounts).HasConstraintName("FK_HRAdvanceRefundItemInvoices_ACAccounts_1");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.HradvanceRefundItemInvoiceFkAcdebitAccounts).HasConstraintName("FK_HRAdvanceRefundItemInvoices_FK_ACDebitAccountID");

            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_ACEInvoiceTypes");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_FK_ACSegmentID");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkHradvanceRefund).WithMany(p => p.HradvanceRefundItemInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAdvanceRefundItemInvoices_HRAdvanceRefunds");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_FK_HRDepartmentID");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_PMProjects");

            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.HradvanceRefundItemInvoices).HasConstraintName("FK_HRAdvanceRefundItemInvoices_VMVehicles");
        });

        modelBuilder.Entity<HradvanceRefundItemRequest>(entity =>
        {
            entity.HasOne(d => d.FkHradvanceRefund).WithMany(p => p.HradvanceRefundItemRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAdvanceRefundItemRequests_HRAdvanceRefunds");

            entity.HasOne(d => d.FkHradvanceRequest).WithMany(p => p.HradvanceRefundItemRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAdvanceRefundItemRequests_HRAdvanceRequests");

            entity.HasOne(d => d.FkHradvanceRequestItem).WithMany(p => p.HradvanceRefundItemRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAdvanceRefundItemRequests_HRAdvanceRequestItems");
        });

        modelBuilder.Entity<HradvanceRefundTemplate>(entity =>
        {
            entity.HasOne(d => d.FkHradvanceRefund).WithMany(p => p.HradvanceRefundTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAdvanceRefundTemplates_HRAdvanceRefunds");
        });

        modelBuilder.Entity<HradvanceRequest>(entity =>
        {
            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.HradvanceRequests).HasConstraintName("FK_HRAdvanceRequests_ACSegments");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HradvanceRequests).HasConstraintName("FK_HRAdvanceRequests_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.HradvanceRequests).HasConstraintName("FK_HRAdvanceRequests_GECurrencies");

            entity.HasOne(d => d.FkHremployeeCompleted).WithMany(p => p.HradvanceRequestFkHremployeeCompleteds).HasConstraintName("FK_HRAdvanceRequests_HREmployeeCompleteds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HradvanceRequestFkHremployees).HasConstraintName("FK_HRAdvanceRequests_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.HradvanceRequests).HasConstraintName("FK_HRAdvanceRequests_PMProjects");
        });

        modelBuilder.Entity<HradvanceRequestItem>(entity =>
        {
            entity.HasOne(d => d.FkHradvanceRequest).WithMany(p => p.HradvanceRequestItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAdvanceRequestItems_HRAdvanceRequests");
        });

        modelBuilder.Entity<HradvanceRequestItemLoanDetail>(entity =>
        {
            entity.HasOne(d => d.FkHradvanceRequestItem).WithMany(p => p.HradvanceRequestItemLoanDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAdvanceRequestItemLoanDetails_HRAdvanceRequestItems");
        });

        modelBuilder.Entity<HradvanceRequestPaymentTime>(entity =>
        {
            entity.HasOne(d => d.FkAcbankTransaction).WithMany(p => p.HradvanceRequestPaymentTimes).HasConstraintName("FK_HRAdvanceRequestPaymentTimes_ACBankTransactions");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.HradvanceRequestPaymentTimes).HasConstraintName("FK_HRAdvanceRequestPaymentTimes_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkAppaymentVoucher).WithMany(p => p.HradvanceRequestPaymentTimes).HasConstraintName("FK_HRAdvanceRequestPaymentTimes_APPaymentVouchers");

            entity.HasOne(d => d.FkHradvanceRequest).WithMany(p => p.HradvanceRequestPaymentTimes).HasConstraintName("FK_HRAdvanceRequestPaymentTimes_HRAdvanceRequests");

            entity.HasOne(d => d.FkHradvanceRequestItem).WithMany(p => p.HradvanceRequestPaymentTimes).HasConstraintName("FK_HRAdvanceRequestPaymentTimes_HRAdvanceRequestItems");
        });

        modelBuilder.Entity<Hrallowance>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Hrallowances).HasConstraintName("FK_HRAllowances_BRBranchs");
        });

        modelBuilder.Entity<HrallowanceConfig>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.HrallowanceConfigs).HasConstraintName("FK_HRAllowanceConfigs_HREmployeePayrollFormulas");
        });

        modelBuilder.Entity<HrallowanceItem>(entity =>
        {
            entity.HasOne(d => d.FkHrallowance).WithMany(p => p.HrallowanceItemFkHrallowances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAllowanceItems_HRAllowances");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrallowanceItemFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAllowanceItems_HREmployees");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.HrallowanceItemFkIcmeasureUnits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAllowanceItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.HrallowanceItemFkIcproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAllowanceItems_ICProducts");
        });

        modelBuilder.Entity<HrallowanceManageConfigHistory>(entity =>
        {
            entity.HasOne(d => d.FkHrallowanceManageConfig).WithMany(p => p.HrallowanceManageConfigHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRAllowanceManageConfigHistorys_HRAllowanceManageConfigs");

            entity.HasOne(d => d.FkHremployeeUserChange).WithMany(p => p.HrallowanceManageConfigHistories).HasConstraintName("FK_HRAllowanceManageConfigHistorys_HREmployees");
        });

        modelBuilder.Entity<HrapproveEditEmployee>(entity =>
        {
            entity.HasOne(d => d.FkHrapproveEmployee).WithMany(p => p.HrapproveEditEmployeeFkHrapproveEmployees).HasConstraintName("FK_HRApproveEditEmployees_HRApproveEmployees");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrapproveEditEmployeeFkHremployees).HasConstraintName("FK_HRApproveEditEmployees_HREmployees");
        });

        modelBuilder.Entity<HrapproveLeaveDay>(entity =>
        {
            entity.HasOne(d => d.FkHrapproveEmployee).WithMany(p => p.HrapproveLeaveDayFkHrapproveEmployees).HasConstraintName("FK_HRApproveLeaveDays_HRApproveEmployees");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrapproveLeaveDayFkHremployees).HasConstraintName("FK_HRApproveLeaveDays_HREmployees");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HrapproveLeaveDays).HasConstraintName("FK_HRApproveLeaveDays_HRTimeSheetParams");
        });

        modelBuilder.Entity<HrarrangementShift>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrarrangementShifts).HasConstraintName("FK_HRArrangementShifts_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrarrangementShifts).HasConstraintName("FK_HREmployeeArrangementShifts_FK_HREmployeeID");
        });

        modelBuilder.Entity<HrarrangementShiftEntry>(entity =>
        {
            entity.HasOne(d => d.FkHremployeeArrangementShift).WithMany(p => p.HrarrangementShiftEntries).HasConstraintName("FK_HRArrangementShiftEntrys_HREmployeeArrangementShifts");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrarrangementShiftEntries).HasConstraintName("FK_HRArrangementShiftEntrys_FK_HREmployeeID");

            entity.HasOne(d => d.FkHrworkingShift).WithMany(p => p.HrarrangementShiftEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRArrangementShiftEntrys_HRWorkingShiftID");
        });

        modelBuilder.Entity<HratmcardPayroll>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HratmcardPayrolls).HasConstraintName("FK_HRATMCardPayrolls_BRBranchs");

            entity.HasOne(d => d.FkCscompanyBank).WithMany(p => p.HratmcardPayrolls).HasConstraintName("FK_HRATMCardPayrolls_CSCompanyBanks");

            entity.HasOne(d => d.FkHrpayRoll).WithMany(p => p.HratmcardPayrolls).HasConstraintName("FK_HRATMCardPayrolls_HRPayRolls");
        });

        modelBuilder.Entity<Hrauthorization>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrauthorizationFkBrbranches).HasConstraintName("FK_HRAuthorizations_BRBranchs");

            entity.HasOne(d => d.FkBrbranchIdtoWorkNavigation).WithMany(p => p.HrauthorizationFkBrbranchIdtoWorkNavigations).HasConstraintName("FK_HRAuthorizations_BRBranchs1");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Hrauthorizations).HasConstraintName("FK_HRAuthorizations_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Hrauthorizations).HasConstraintName("FK_HRAuthorizations_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeAuthorizationSignerNavigation).WithMany(p => p.HrauthorizationFkHremployeeAuthorizationSignerNavigations).HasConstraintName("FK_HRAuthorizations_EmployeeAuthorizationSigner");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrauthorizationFkHremployees).HasConstraintName("FK_HRAuthorizations_HREmployees");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.Hrauthorizations).HasConstraintName("FK_HRAuthorizations_HRLevels");
        });

        modelBuilder.Entity<HrbillingIntimate>(entity =>
        {
            entity.HasKey(e => e.HrbillingIntimateId).HasName("PK__HRBillingIntimates");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrbillingIntimates).HasConstraintName("FK_HRBillingIntimates_HREmployees");
        });

        modelBuilder.Entity<HrbonusSale>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrbonusSales).HasConstraintName("FK_HRBonusSales_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrbonusSales).HasConstraintName("FK_HREmployeeBonusSales_FK_HREmployeeID");
        });

        modelBuilder.Entity<HrbonusSaleItem>(entity =>
        {
            entity.HasOne(d => d.FkHrbonusSale).WithMany(p => p.HrbonusSaleItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRBonusSaleItems_HRBonusSales");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrbonusSaleItems).HasConstraintName("FK_HRBonusSaleItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HrbonusSaleItems).HasConstraintName("FK_HRBonusSaleItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrbonusSaleItemFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRBonusSaleItems_HREmployees");

            entity.HasOne(d => d.FkHremployeeId2Navigation).WithMany(p => p.HrbonusSaleItemFkHremployeeId2Navigations).HasConstraintName("HRBonusSaleItems_HREmployees");
        });

        modelBuilder.Entity<HrbreakTime>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.HrbreakTimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRBreakTimes_HREmployeePayrollFormulas");
        });

        modelBuilder.Entity<HrbugManagement>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrbugManagements).HasConstraintName("FK_HRBugManagements_HREmployees");

            entity.HasOne(d => d.FkHrerrorType).WithMany(p => p.HrbugManagements).HasConstraintName("FK_HRBugManagements_HRErrorTypes");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.HrbugManagements).HasConstraintName("FK_HRBugManagements_MMOperations");
        });

        modelBuilder.Entity<HrbugManagementTemplate>(entity =>
        {
            entity.HasOne(d => d.FkHrbugManagement).WithMany(p => p.HrbugManagementTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRBugManagementTemplates_HRBugManagements");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrbugManagementTemplates).HasConstraintName("FK_HRBugManagementTemplates_HREmployees");
        });

        modelBuilder.Entity<HrcalendarEntry>(entity =>
        {
            entity.HasOne(d => d.FkHrcalendar).WithMany(p => p.HrcalendarEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRCalendarEntrys_HRCalendars");
        });

        modelBuilder.Entity<Hrcandidate>(entity =>
        {
            entity.HasOne(d => d.FkGecountry).WithMany(p => p.Hrcandidates).HasConstraintName("FK_HRCandidates_GECountrys");

            entity.HasOne(d => d.FkGedistrict).WithMany(p => p.Hrcandidates).HasConstraintName("FK_HRCandidates_GEDistricts");

            entity.HasOne(d => d.FkGeidcardStateProvince).WithMany(p => p.HrcandidateFkGeidcardStateProvinces).HasConstraintName("FK_HRCandidates_GEIDCardStateProvinceID");

            entity.HasOne(d => d.FkGenationality).WithMany(p => p.Hrcandidates).HasConstraintName("FK_HRCandidates_GENationalitys");

            entity.HasOne(d => d.FkGereligion).WithMany(p => p.Hrcandidates).HasConstraintName("FK_HRCandidates_GEReligions");

            entity.HasOne(d => d.FkGestateProvince).WithMany(p => p.HrcandidateFkGestateProvinces).HasConstraintName("FK_HRCandidates_GEStateProvinces");
        });

        modelBuilder.Entity<HrcandidateCertificate>(entity =>
        {
            entity.HasOne(d => d.FkHrcandidate).WithMany(p => p.HrcandidateCertificates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRCandidateCertificates_HRCandidates");
        });

        modelBuilder.Entity<HrcandidateTemplate>(entity =>
        {
            entity.HasOne(d => d.FkHrcandidate).WithMany(p => p.HrcandidateTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRCandidateTemplates_HRCandidates");
        });

        modelBuilder.Entity<HrclassSchedule>(entity =>
        {
            entity.HasOne(d => d.FkHrtrainningClass).WithMany(p => p.HrclassSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRClassSchedules_HRTrainningClass");
        });

        modelBuilder.Entity<HrconfigRank>(entity =>
        {
            entity.HasOne(d => d.FkHrconfigScale).WithMany(p => p.HrconfigRanks).HasConstraintName("FK_HRConfigScales_HRConfigRanks");
        });

        modelBuilder.Entity<HrconfigSalesFormulaPayroll>(entity =>
        {
            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.HrconfigSalesFormulaPayrollFkHremployeeApproveds).HasConstraintName("FK_HRConfigSalesFormulaPayrolls_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrconfigSalesFormulaPayrollFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRConfigSalesFormulaPayrolls_HREmployees");
        });

        modelBuilder.Entity<HrconfigSalesFormulaPayrollItem>(entity =>
        {
            entity.HasOne(d => d.FkHrconfigSalesFormulaPayroll).WithMany(p => p.HrconfigSalesFormulaPayrollItems).HasConstraintName("FK_HRConfigSalesFormulaPayrollItems_HRConfigSalesFormulaPayrolls");
        });

        modelBuilder.Entity<HrconfigSalesTarget>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrconfigSalesTargets).HasConstraintName("FK_HRConfigSalesTargets_BRBranchs");

            entity.HasOne(d => d.FkCscompany).WithMany(p => p.HrconfigSalesTargets).HasConstraintName("FK_HRConfigSalesTargets_CSCompanys");

            entity.HasOne(d => d.FkHrconfigSalesTargetParent).WithMany(p => p.InverseFkHrconfigSalesTargetParent).HasConstraintName("FK_HRConfigSalesTargets_HRConfigSalesTargets");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.HrconfigSalesTargetFkHremployeeApproveds).HasConstraintName("FK_HRConfigSalesTargets_HREmployees1");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrconfigSalesTargetFkHremployees).HasConstraintName("FK_HRConfigSalesTargets_HREmployees");
        });

        modelBuilder.Entity<HrconfigSalesTargetItem>(entity =>
        {
            entity.HasOne(d => d.FkHrconfigSalesTarget).WithMany(p => p.HrconfigSalesTargetItems).HasConstraintName("FK_HRConfigSalesTargetItems_HRConfigSalesTargets");
        });

        modelBuilder.Entity<Hrdepartment>(entity =>
        {
            entity.Property(e => e.HrdepartmentTotalEmployee).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Hrdepartments).HasConstraintName("FK_HRDepartments_BRBranchs");
        });

        modelBuilder.Entity<HrdepartmentGroupCapacity>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HrdepartmentGroupCapacities).HasConstraintName("FK_HRDepartmentGroupCapacitys_HRDepartmentRoomGroupItems");
        });

        modelBuilder.Entity<HrdepartmentGroupOperation>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HrdepartmentGroupOperations).HasConstraintName("FK_HRDepartmentGroupOperations_HRDepartmentRoomGroupItems");
        });

        modelBuilder.Entity<HrdepartmentRoom>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrdepartmentRooms).HasConstraintName("FK_HRDepartmentRooms_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrdepartmentRooms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRooms_HRDepartments");
        });

        modelBuilder.Entity<HrdepartmentRoomGroup>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrdepartmentRoomGroupFkBrbranches).HasConstraintName("FK_HRDepartmentRoomGroups_BRBranchs");

            entity.HasOne(d => d.FkBrbranchId2Navigation).WithMany(p => p.HrdepartmentRoomGroupFkBrbranchId2Navigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroups_BRBranch2s");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrdepartmentRoomGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroups_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HrdepartmentRoomGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroups_HRDepartmentRooms");
        });

        modelBuilder.Entity<HrdepartmentRoomGroupItem>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.HrdepartmentRoomGroupItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroupItems_HRDepartmentRoomGroups");
        });

        modelBuilder.Entity<HrdepartmentRoomGroupTeam>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrdepartmentRoomGroupTeams).HasConstraintName("FK_HRDepartmentRoomGroupTeams_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrdepartmentRoomGroupTeams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroupTeams_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.HrdepartmentRoomGroupTeams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroupTeams_HRDepartmentRoomGroups");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HrdepartmentRoomGroupTeams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroupTeams_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HrdepartmentRoomGroupTeams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroupTeams_HRDepartmentRooms");
        });

        modelBuilder.Entity<HrdepartmentRoomGroupTeamItem>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoomGroupTeam).WithMany(p => p.HrdepartmentRoomGroupTeamItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDepartmentRoomGroupTeamItems_HRDepartmentRoomGroupTeams");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.HrdepartmentRoomGroupTeamItems).HasConstraintName("FK_HRDepartmentRoomGroupTeamItems_MMLines");
        });

        modelBuilder.Entity<HrdepartmentRoomLeaveDayConfig>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HrdepartmentRoomLeaveDayConfigs).HasConstraintName("HRDepartmentRoomLeaveDayConfigs_FK_HRDepartmentRoomID");
        });

        modelBuilder.Entity<Hrdiscipline>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Hrdisciplines).HasConstraintName("FK_HRDisciplines_BRBranchs");

            entity.HasOne(d => d.FkHremployeeRequestNavigation).WithMany(p => p.Hrdisciplines).HasConstraintName("FK_HREmployeeDisciplines_FK_HREmployeeRequest");
        });

        modelBuilder.Entity<Hrdormitory>(entity =>
        {
            entity.HasKey(e => e.HrdormitoryId).HasName("FK_HRDormitorys");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Hrdormitories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDormitorys_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Hrdormitories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDormitorys_HREmployees");
        });

        modelBuilder.Entity<HrdormitoryCost>(entity =>
        {
            entity.HasKey(e => e.HrdormitoryCostId).HasName("FK_HRDormitoryCosts");
        });

        modelBuilder.Entity<HrdormitoryCostItem>(entity =>
        {
            entity.HasKey(e => e.HrdormitoryCostItemId).HasName("FK_HRDormitoryCostItems");

            entity.HasOne(d => d.FkHrdormitoryCost).WithMany(p => p.HrdormitoryCostItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRDormitoryCostItems_FK_DormitoryCostID");

            entity.HasOne(d => d.FkHrdormitory).WithMany(p => p.HrdormitoryCostItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("HRDormitoryCostItems_FK_HRDormitoryID");
        });

        modelBuilder.Entity<HrdormitoryItem>(entity =>
        {
            entity.HasKey(e => e.HrdormitoryItemId).HasName("FK_HRDormitoryItems");

            entity.HasOne(d => d.FkHrdormitory).WithMany(p => p.HrdormitoryItems).HasConstraintName("FK_HRDormitoryItems_HRDormitorys");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.HrdormitoryItems).HasConstraintName("FK_HRDormitoryItems_ICProducts");
        });

        modelBuilder.Entity<Hremployee>(entity =>
        {
            entity.ToTable("HREmployees", tb => tb.HasTrigger("TRG_InsertUpdateEmployee"));

            entity.HasOne(d => d.FkAcaccountDeposit).WithMany(p => p.HremployeeFkAcaccountDeposits).HasConstraintName("FK_HREmployees_ACAccountDeposits");

            entity.HasOne(d => d.FkAcaccountPurchase).WithMany(p => p.HremployeeFkAcaccountPurchases).HasConstraintName("FK_HREmployees_ACAccountPurchases");

            entity.HasOne(d => d.FkAcaccountSale).WithMany(p => p.HremployeeFkAcaccountSales).HasConstraintName("FK_HREmployees_ACAccountSales");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Hremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployees_BRBranchs");

            entity.HasOne(d => d.FkGeidcardStateProvince).WithMany(p => p.HremployeeFkGeidcardStateProvinces).HasConstraintName("FK_HREmployees_GEStateProvinces2");

            entity.HasOne(d => d.FkGenationality).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_GENationalitys");

            entity.HasOne(d => d.FkGenativeStateProvince).WithMany(p => p.HremployeeFkGenativeStateProvinces).HasConstraintName("FK_HREmployees_GEStateProvinces");

            entity.HasOne(d => d.FkGereligion).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_GEReligions");

            entity.HasOne(d => d.FkGestateProvinceBirthPlace).WithMany(p => p.HremployeeFkGestateProvinceBirthPlaces).HasConstraintName("FK_HREmployees_GEStateProvinces3");

            entity.HasOne(d => d.FkGestateProvinceIdbhxhNavigation).WithMany(p => p.HremployeeFkGestateProvinceIdbhxhNavigations).HasConstraintName("FK_HREmployees_GEStateProvinces1");

            entity.HasOne(d => d.FkHrallowanceManageConfig).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_HRAllowanceManageConfig");

            entity.HasOne(d => d.FkHrconfigRank).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_HRConfigRanks");

            entity.HasOne(d => d.FkHrconfigScale).WithMany(p => p.Hremployees).HasConstraintName("FK_HRConfigScales_HREmployees");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Hremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployees_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupTeamItem).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_HRDepartmentRoomGroupTeamItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Hremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployees_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.Hremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployees_HREmployeePayrollFormulas");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_HRLevels");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.Hremployees).HasConstraintName("HREmployees_FK_HRTimeSheetParamID");

            entity.HasOne(d => d.FkHrtimeSheetScale).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_HRTimeSheetScales");

            entity.HasOne(d => d.FkHrworkingShift).WithMany(p => p.Hremployees).HasConstraintName("FK_HREmployees_HRWorkingShifts");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.Hremployees).HasConstraintName("HREmployees_FK_MMWorkShopID");
        });

        modelBuilder.Entity<HremployeeAbsence>(entity =>
        {
            entity.HasOne(d => d.FkHrclassSchedule).WithMany(p => p.HremployeeAbsences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeAbsences_HRClassSchedules");

            entity.HasOne(d => d.FkHremployeeStudent).WithMany(p => p.HremployeeAbsenceFkHremployeeStudents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeAbsences_HREmployees1");

            entity.HasOne(d => d.FkHremployeeTeacher).WithMany(p => p.HremployeeAbsenceFkHremployeeTeachers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeAbsences_HREmployees");

            entity.HasOne(d => d.FkHrtrainningClass).WithMany(p => p.HremployeeAbsences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeAbsences_HRTrainningClass");

            entity.HasOne(d => d.FkHrtrainningCourse).WithMany(p => p.HremployeeAbsences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeAbsences_HRTrainningCourses");
        });

        modelBuilder.Entity<HremployeeAdjustSocialInsurance>(entity =>
        {
            entity.HasOne(d => d.FkHradjustSocialInsurance).WithMany(p => p.HremployeeAdjustSocialInsurances).HasConstraintName("FK_HREmployeeAdjustSocialInsurances_HRAdjustSocialInsurances");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeeAdjustSocialInsurances).HasConstraintName("FK_HREmployeeAdjustSocialInsurances_HRLevels");
        });

        modelBuilder.Entity<HremployeeAllowance>(entity =>
        {
            entity.HasOne(d => d.FkHrallowance).WithMany(p => p.HremployeeAllowances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeAllowances_HRAllowances");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeAllowances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeAllowances_HREmployees");
        });

        modelBuilder.Entity<HremployeeArrangementShift>(entity =>
        {
            entity.HasOne(d => d.FkHrarrangementShift).WithMany(p => p.HremployeeArrangementShifts).HasConstraintName("FK_HREmployeeArrangementShifts_HRArrangementShifts");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeArrangementShifts).HasConstraintName("FK_HREmployeeArrangementShifts_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeArrangementShifts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeArrangementShifts_HREmployees");
        });

        modelBuilder.Entity<HremployeeArrearSocialInsurance>(entity =>
        {
            entity.HasOne(d => d.FkHradjustSocialInsurance).WithMany(p => p.HremployeeArrearSocialInsurances).HasConstraintName("FK_HREmployeeArrearSocialInsurances_HRAdjustSocialInsurances");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeArrearSocialInsurances).HasConstraintName("FK_HREmployeeArrearSocialInsurances_HREmployees");
        });

        modelBuilder.Entity<HremployeeAtmcardManage>(entity =>
        {
            entity.HasOne(d => d.FkHratmcardManage).WithMany(p => p.HremployeeAtmcardManages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeATMCardManages_HRDepartments");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeAtmcardManages).HasConstraintName("FK_HREmployeeATMCardManages_HREmployees");
        });

        modelBuilder.Entity<HremployeeAtmcardPayroll>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch1Navigation).WithMany(p => p.HremployeeAtmcardPayrollFkBrbranch1Navigations).HasConstraintName("FK_HREmployeeATMCardPayrolls_BRBranchs1");

            entity.HasOne(d => d.FkBrbranch2Navigation).WithMany(p => p.HremployeeAtmcardPayrollFkBrbranch2Navigations).HasConstraintName("FK_HREmployeeATMCardPayrolls_BRBranchs2");

            entity.HasOne(d => d.FkHratmcardPayroll).WithMany(p => p.HremployeeAtmcardPayrolls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeATMCardPayrolls_HRATMCardPayrolls");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeAtmcardPayrolls).HasConstraintName("FK_HREmployeeATMCardPayrolls_HREmployees");
        });

        modelBuilder.Entity<HremployeeCertificate>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeCertificates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeCertificates_HREmployees");
        });

        modelBuilder.Entity<HremployeeComission>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.HremployeeComissions).HasConstraintName("FK_HREmployeeComissions_HREmployeePayrollFormulas");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeeComissions).HasConstraintName("FK_HREmployeeComissions_HRLevels");
        });

        modelBuilder.Entity<HremployeeComissionItem>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeComissionItems).HasConstraintName("FK_HREmployeeComissionItems_BRBranchs");

            entity.HasOne(d => d.FkHremployeeComission).WithMany(p => p.HremployeeComissionItems).HasConstraintName("FK_HREmployeeComissionItems_HREmployeeComissions");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeComissionItems).HasConstraintName("FK_HREmployeeComissionItems_HREmployees");
        });

        modelBuilder.Entity<HremployeeCommissionBranch>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeCommissionBranches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeCommissionBranchs_BRBranchs");

            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.HremployeeCommissionBranches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeCommissionBranchs_HREmployeePayrollFormulas");
        });

        modelBuilder.Entity<HremployeeContact>(entity =>
        {
            entity.HasOne(d => d.FkGecountry).WithMany(p => p.HremployeeContacts).HasConstraintName("FK_HREmployeeContacts_GECountrys");

            entity.HasOne(d => d.FkGedistrict).WithMany(p => p.HremployeeContacts).HasConstraintName("FK_HREmployeeContacts_GEDistricts");

            entity.HasOne(d => d.FkGestateProvince).WithMany(p => p.HremployeeContacts).HasConstraintName("FK_HREmployeeContacts_GEStateProvinces");

            entity.HasOne(d => d.FkGeward).WithMany(p => p.HremployeeContacts).HasConstraintName("FK_HREmployeeContacts_GEWards");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeContacts).HasConstraintName("FK_HREmployeeContacts_HREmployees");
        });

        modelBuilder.Entity<HremployeeContactPerson>(entity =>
        {
            entity.HasOne(d => d.FkGecountry).WithMany(p => p.HremployeeContactPeople).HasConstraintName("FK_HREmployeeContactPersons_GECountrys");

            entity.HasOne(d => d.FkGedistrict).WithMany(p => p.HremployeeContactPeople).HasConstraintName("FK_HREmployeeContactPersons_GEDistricts");

            entity.HasOne(d => d.FkGestateProvince).WithMany(p => p.HremployeeContactPeople).HasConstraintName("FK_HREmployeeContactPersons_GEStateProvinces");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeContactPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeContactPersons_HREmployees");

            entity.HasOne(d => d.FkHrrelationship).WithMany(p => p.HremployeeContactPeople).HasConstraintName("FK_HREmployeeContactPersons_HRRelationships");
        });

        modelBuilder.Entity<HremployeeContract>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeContractFkBrbranches).HasConstraintName("FK_HREmployeeContracts_BRBranchs");

            entity.HasOne(d => d.FkBrbranchIdtoWorkNavigation).WithMany(p => p.HremployeeContractFkBrbranchIdtoWorkNavigations).HasConstraintName("FK_HREmployeeContracts_BRBranchs1");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeeContracts).HasConstraintName("FK_HREmployeeContracts_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HremployeeContracts).HasConstraintName("FK_HREmployeeContracts_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupTeamItem).WithMany(p => p.HremployeeContracts).HasConstraintName("FK_HREmployeeContracts_HRDepartmentRoomGroupTeamItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeContracts).HasConstraintName("FK_HREmployeeContracts_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeContractFkHremployees).HasConstraintName("FK_HREmployeeContracts_HREmployees");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeeContracts).HasConstraintName("FK_HREmployeeContracts_HRLevels");

            entity.HasOne(d => d.HremployeeContractSignerNavigation).WithMany(p => p.HremployeeContractHremployeeContractSignerNavigations).HasConstraintName("FK_HREmployeeContracts_HREmployees1");
        });

        modelBuilder.Entity<HremployeeDiscipline>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeDisciplines).HasConstraintName("FK_HREmployeeDisciplines_HRDepartmentRooms");

            entity.HasOne(d => d.FkHrdiscipline).WithMany(p => p.HremployeeDisciplines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeDisciplines_HRDisciplines");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeDisciplineFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeDisciplines_HREmployees");

            entity.HasOne(d => d.FkHremployeeId2Navigation).WithMany(p => p.HremployeeDisciplineFkHremployeeId2Navigations).HasConstraintName("FK_HREmployeeDisciplines_HREmployees2");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeeDisciplineFkHrlevels).HasConstraintName("FK_HREmployeeDisciplines_FK_HRLevelID");

            entity.HasOne(d => d.FkHrlevelId2Navigation).WithMany(p => p.HremployeeDisciplineFkHrlevelId2Navigations).HasConstraintName("HREmployeeDisciplines_HRLevels");
        });

        modelBuilder.Entity<HremployeeEvaluation>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeEvaluations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeEvaluations_HREmployees");

            entity.HasOne(d => d.FkHrevaluation).WithMany(p => p.HremployeeEvaluations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeEvaluations_HREvaluations");

            entity.HasOne(d => d.FkHrevaluationRank).WithMany(p => p.HremployeeEvaluations).HasConstraintName("FK_HREmployeeEvaluations_HREvaluationRanks");

            entity.HasOne(d => d.FkHrtemplateRank).WithMany(p => p.HremployeeEvaluations).HasConstraintName("FK_HREmployeeEvaluations_HRTemplateRanks");
        });

        modelBuilder.Entity<HremployeeGroup>(entity =>
        {
            entity.HasKey(e => e.HremployeeGroupId).HasName("PK_HREmployeeGroupID");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeGroups_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeGroups_HREmployees");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.HremployeeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeGroups_HRGroups");
        });

        modelBuilder.Entity<HremployeeGroupAppStaff>(entity =>
        {
            entity.HasKey(e => e.HremployeeGroupAppStaffId).HasName("PK_HREmployeeGroupAppStaffID");

            entity.HasOne(d => d.FkAdgroupAppStaff).WithMany(p => p.HremployeeGroupAppStaffs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeGroupAppStaffs_ADGroupAppStaffs");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeGroupAppStaffs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeGroupAppStaffs_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeGroupAppStaffs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeGroupAppStaffs_HREmployees");
        });

        modelBuilder.Entity<HremployeeGroupOrderWeb>(entity =>
        {
            entity.HasKey(e => e.HremployeeGroupOrderWebId).HasName("PK_HREmployeeGroupOrderWebID");

            entity.HasOne(d => d.FkAdgroupOrderWeb).WithMany(p => p.HremployeeGroupOrderWebs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeGroupOrderWebs_ADGroupOrderWebs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeGroupOrderWebs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeGroupOrderWebs_HREmployees");
        });

        modelBuilder.Entity<HremployeeIdentityCardTemplate>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeIdentityCardTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeIdentityCardTemplates_HREmployees");
        });

        modelBuilder.Entity<HremployeeKpievaluationItem>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeeKpievaluationItems).HasConstraintName("FK_HREmployeeKPIEvaluationItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeKpievaluationItems).HasConstraintName("FK_HREmployeeKPIEvaluationItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeKpievaluationItems).HasConstraintName("FK_HREmployeeKPIEvaluationItems_HREmployees");

            entity.HasOne(d => d.FkHremployeeKpiregistrationItem).WithMany(p => p.HremployeeKpievaluationItems).HasConstraintName("FK_HREmployeeKPIEvaluationItems_HREmployeeKPIRegistrationItems");

            entity.HasOne(d => d.FkHrkpievaluation).WithMany(p => p.HremployeeKpievaluationItems).HasConstraintName("FK_HREmployeeKPIEvaluationItems_HRKPIEvaluations");

            entity.HasOne(d => d.FkHrkpiregistration).WithMany(p => p.HremployeeKpievaluationItems).HasConstraintName("FK_HREmployeeKPIEvaluationItems_HRKPIRegistrations");
        });

        modelBuilder.Entity<HremployeeKpiregistrationItem>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeeKpiregistrationItems).HasConstraintName("FK_HREmployeeKPIRegistrationItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeKpiregistrationItems).HasConstraintName("FK_HREmployeeKPIRegistrationItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeKpiregistrationItems).HasConstraintName("FK_HREmployeeKPIRegistrationItems_HREmployees");

            entity.HasOne(d => d.FkHrkpiregistration).WithMany(p => p.HremployeeKpiregistrationItems).HasConstraintName("FK_HREmployeeKPIRegistrationItems_HRKPIRegistrations");
        });

        modelBuilder.Entity<HremployeeLreg>(entity =>
        {
            entity.HasKey(e => e.HremployeeLregId).HasName("PK__HREmployeeLRegs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeLregs).HasConstraintName("FK_HREmployeeLRegs_HREmployees");
        });

        modelBuilder.Entity<HremployeeOt>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeeOts).HasConstraintName("FK_HREmployeeOTs_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HremployeeOts).HasConstraintName("FK_HREmployeeOTs_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeOts).HasConstraintName("FK_HREmployeeOTs_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeOtFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeOTs_HREmployees");

            entity.HasOne(d => d.FkHremployeeId2Navigation).WithMany(p => p.HremployeeOtFkHremployeeId2Navigations).HasConstraintName("HREmployeeOTs_HREmployees");

            entity.HasOne(d => d.FkHroverTime).WithMany(p => p.HremployeeOts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeOTs_HROverTimes");
        });

        modelBuilder.Entity<HremployeeOtfactor>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeOtfactors).HasConstraintName("FK_HREmployeeOTFactors_HREmployees");
        });

        modelBuilder.Entity<HremployeePause>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeePauses).HasConstraintName("FK_HREmployeePauses_HREmployees");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HremployeePauses).HasConstraintName("FK_HREmployeePauses_HRTimeSheetParams");
        });

        modelBuilder.Entity<HremployeePayRoll>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeePayRolls).HasConstraintName("FK_HREmployeePayRolls_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeePayRolls).HasConstraintName("FK_HREmployeePayRolls_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeePayRolls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeePayRolls_HREmployees");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeePayRolls).HasConstraintName("FK_HREmployeePayRolls_HRLevels");

            entity.HasOne(d => d.FkHrpayRoll).WithMany(p => p.HremployeePayRolls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeePayRolls_HRPayRolls");
        });

        modelBuilder.Entity<HremployeePayRollAudit>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeePayRollAudits).HasConstraintName("FK_HREmployeePayRollAudits_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeePayRollAudits).HasConstraintName("FK_HREmployeePayRollAudits_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeePayRollAudits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeePayRollAudits_HREmployees");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeePayRollAudits).HasConstraintName("FK_HREmployeePayRollAudits_HRLevels");

            entity.HasOne(d => d.FkHrpayRollAudit).WithMany(p => p.HremployeePayRollAudits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeePayRollAudits_HRPayRollAudits");
        });

        modelBuilder.Entity<HremployeePayRollAuditDetail>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayRollAudit).WithMany(p => p.HremployeePayRollAuditDetails).HasConstraintName("FK_HREmployeePayRollAuditDetails_HREmployeePayRollAudits");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HremployeePayRollAuditDetails).HasConstraintName("FK_HREmployeePayRollAuditDetails_HRTimeSheetParams");
        });

        modelBuilder.Entity<HremployeePayRollConfig>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeePayRollConfigs).HasConstraintName("FK_HREmployeePayRollConfigs_HREmployees");

            entity.HasOne(d => d.FkHrpayRollConfig).WithMany(p => p.HremployeePayRollConfigs).HasConstraintName("FK_HREmployeePayRollConfigs_HRPayRollConfigs");
        });

        modelBuilder.Entity<HremployeePayrollDetail>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayroll).WithMany(p => p.HremployeePayrollDetails).HasConstraintName("FK_HREmployeePayrollDetails_HREmployeePayrolls");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HremployeePayrollDetails).HasConstraintName("FK_HREmployeePayrollDetails_HRTimeSheetParams");
        });

        modelBuilder.Entity<HremployeePayrollFormulaItem>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.HremployeePayrollFormulaItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeePayrollFormulaItems_HREmployeePayrollFormulas");
        });

        modelBuilder.Entity<HremployeePieceWage>(entity =>
        {
            entity.HasOne(d => d.FkHrproductPieceWage).WithMany(p => p.HremployeePieceWages).HasConstraintName("FK_HREmployeePieceWages_HRProductPieceWages");
        });

        modelBuilder.Entity<HremployeePieceWageItem>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeePieceWageItems).HasConstraintName("FK_HREmployeePieceWageItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HremployeePieceWageItems).HasConstraintName("FK_HREmployeePieceWageItems_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeePieceWageItems).HasConstraintName("FK_HREmployeePieceWageItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeePieceWageItemFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeePieceWageItems_HREmployees");

            entity.HasOne(d => d.FkHremployeeId2Navigation).WithMany(p => p.HremployeePieceWageItemFkHremployeeId2Navigations).HasConstraintName("HREmployeePieceWageItems_HREmployees");

            entity.HasOne(d => d.FkHremployeePieceWage).WithMany(p => p.HremployeePieceWageItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeePieceWageItems_HREmployeePieceWages");
        });

        modelBuilder.Entity<HremployeePieceWork>(entity =>
        {
            entity.HasOne(d => d.FkAdmatchCodeBatchComponentNavigation).WithMany(p => p.HremployeePieceWorks).HasConstraintName("FK_HREmployeePieceWorks_ADMatchCodes");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.HremployeePieceWorks).HasConstraintName("FK_HREmployeePieceWorks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.HremployeePieceWorks).HasConstraintName("FK_HREmployeePieceWorks_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.HremployeePieceWorks).HasConstraintName("FK_HREmployeePieceWorks_MMOperations");
        });

        modelBuilder.Entity<HremployeeReward>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeRewards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeRewards_HREmployees");

            entity.HasOne(d => d.FkHrreward).WithMany(p => p.HremployeeRewards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeRewards_HRRewards");
        });

        modelBuilder.Entity<HremployeeSalaryConfig>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeSalaryConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeSalaryConfigs_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeeSalaryConfigs).HasConstraintName("FK_HREmployeeSalaryConfigs_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HremployeeSalaryConfigs).HasConstraintName("FK_HREmployeeSalaryConfigs_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeSalaryConfigs).HasConstraintName("FK_HREmployeeSalaryConfigs_HRDepartmentRooms");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeeSalaryConfigs).HasConstraintName("FK_HREmployeeSalaryConfigs_HRLevels");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.HremployeeSalaryConfigs).HasConstraintName("HREmployeeSalaryConfigs_FK_MMWorkShopID");
        });

        modelBuilder.Entity<HremployeeSchedule>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeSchedules_HREmployees");

            entity.HasOne(d => d.FkHrschedule).WithMany(p => p.HremployeeSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeSchedules_HRSchedules");

            entity.HasOne(d => d.FkHrworkingShift).WithMany(p => p.HremployeeSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeSchedules_HRWorkingShifts");
        });

        modelBuilder.Entity<HremployeeSocialInsuranceChange>(entity =>
        {
            entity.HasOne(d => d.FkHradjustSocialInsurance).WithMany(p => p.HremployeeSocialInsuranceChangeFkHradjustSocialInsurances).HasConstraintName("FK_HREmployeeSocialInsuranceChanges_HRAdjustSocialInsurances");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeSocialInsuranceChangeFkHremployees).HasConstraintName("FK_HREmployeeSocialInsuranceChanges_HREmployees");
        });

        modelBuilder.Entity<HremployeeTimeSheet>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeTimeSheets).HasConstraintName("FK_HREmployeeTimeSheets_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeTimeSheets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeTimeSheets_HREmployees");

            entity.HasOne(d => d.FkHrtimeSheet).WithMany(p => p.HremployeeTimeSheets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeTimeSheets_HRTimeSheets");
        });

        modelBuilder.Entity<HremployeeTimeSheetAudit>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeTimeSheetAudits).HasConstraintName("FK_HREmployeeTimeSheetAudits_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeTimeSheetAudits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeTimeSheetAudits_HREmployees");

            entity.HasOne(d => d.FkHrtimeSheetAudit).WithMany(p => p.HremployeeTimeSheetAudits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeTimeSheetAudits_HRTimeSheetAudits");
        });

        modelBuilder.Entity<HremployeeTimeSheetAuditOtdetail>(entity =>
        {
            entity.HasOne(d => d.FkHremployeeTimeSheetAudit).WithMany(p => p.HremployeeTimeSheetAuditOtdetails).HasConstraintName("FK_HREmployeeTimeSheetAuditOTDetails_HREmployeeTimeSheetAudits");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HremployeeTimeSheetAuditOtdetails).HasConstraintName("FK_HREmployeeTimeSheetAuditOTDetails_HRTimeSheetParams");
        });

        modelBuilder.Entity<HremployeeTimeSheetOtdetail>(entity =>
        {
            entity.HasOne(d => d.FkHremployeeTimeSheet).WithMany(p => p.HremployeeTimeSheetOtdetails).HasConstraintName("FK_HREmployeeTimeSheetOTDetails_HREmployeeTimeSheets");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HremployeeTimeSheetOtdetails).HasConstraintName("FK_HREmployeeTimeSheetOTDetails_HRTimeSheetParams");
        });

        modelBuilder.Entity<HremployeeTranfer>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeTranfers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeTranfers_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeeTranfers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeTranfers_HRDepartments1");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HremployeeTranfers).HasConstraintName("FK_HREmployeeTranfers_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupTeamItem).WithMany(p => p.HremployeeTranfers).HasConstraintName("FK_HREmployeeTranfers_HRDepartmentRoomGroupTeamItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeTranfers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeTranfers_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeContract).WithMany(p => p.HremployeeTranfers).HasConstraintName("FK_HREmployeeTranfers_HREmployeeContracts");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeTranferFkHremployees).HasConstraintName("FK_HREmployeeTranfers_HREmployees");

            entity.HasOne(d => d.FkHremployeeReceived).WithMany(p => p.HremployeeTranferFkHremployeeReceiveds).HasConstraintName("FK_HREmployeeTranfers_HREmployeeReceiveds");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeeTranfers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeTranfers_HRLevels");

            entity.HasOne(d => d.HremployeeTranferSignerNavigation).WithMany(p => p.HremployeeTranferHremployeeTranferSignerNavigations).HasConstraintName("FK_HREmployeeTranfers_HREmployees1");
        });

        modelBuilder.Entity<HremployeeTransmit>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeTransmits).HasConstraintName("FK_HREmployeeTransmits_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HremployeeTransmits).HasConstraintName("FK_HREmployeeTransmits_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HremployeeTransmits).HasConstraintName("FK_HREmployeeTransmits_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeTransmits).HasConstraintName("FK_HREmployeeTransmits_HRDepartmentRooms");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeeTransmits).HasConstraintName("FK_HREmployeeTransmits_HRLevels");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.HremployeeTransmits).HasConstraintName("FK_HREmployeeTransmits_MMWorkShopID");
        });

        modelBuilder.Entity<HremployeeTransmitItem>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HremployeeTransmitItems).HasConstraintName("FK_HREmployeeTransmitItems_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HremployeeTransmitItems).HasConstraintName("FK_HREmployeeTransmitItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeTransmitItems).HasConstraintName("FK_HREmployeeTransmitItems_HREmployees");

            entity.HasOne(d => d.FkHremployeeTransmit).WithMany(p => p.HremployeeTransmitItems).HasConstraintName("FK_HREmployeeTransmitItems_HREmployeeTransmits");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HremployeeTransmitItems).HasConstraintName("FK_HREmployeeTransmitItems_HRLevels");
        });

        modelBuilder.Entity<HremployeeWorkSchedule>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HremployeeWorkSchedules).HasConstraintName("FK_HREmployeeWorkSchedules_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApprove).WithMany(p => p.HremployeeWorkSchedules).HasConstraintName("FK_ HREmployeeWorkSchedules_HREmployee2");
        });

        modelBuilder.Entity<HremployeeWorkScheduleItem>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeWorkScheduleItemFkHremployees).HasConstraintName("FK_HREmployeeWorkScheduleItems_HREmployees");

            entity.HasOne(d => d.FkHremployeeWorkSchedule).WithMany(p => p.HremployeeWorkScheduleItemFkHremployeeWorkSchedules).HasConstraintName("FK_HREmployeeWorkScheduleItems_HREmployeeWorkSchedules");
        });

        modelBuilder.Entity<HremployeeWorkingShift>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HremployeeWorkingShifts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeWorkingShifts_HREmployees");

            entity.HasOne(d => d.FkHrworkingShift).WithMany(p => p.HremployeeWorkingShifts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREmployeeWorkingShifts_HRWorkingShifts");
        });

        modelBuilder.Entity<HremployeesBackup20190731>(entity =>
        {
            entity.Property(e => e.HremployeeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Hrevaluation>(entity =>
        {
            entity.HasOne(d => d.FkHrevaluationTemplate).WithMany(p => p.Hrevaluations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREvaluations_HREvaluationTemplates");
        });

        modelBuilder.Entity<HrevaluationDetail>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrevaluationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREvaluationDetails_HREmployees");

            entity.HasOne(d => d.FkHrevaluation).WithMany(p => p.HrevaluationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREvaluationDetails_HREvaluations");

            entity.HasOne(d => d.FkHrevaluationStandard).WithMany(p => p.HrevaluationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HREvaluationDetails_HREvaluationStandards");
        });

        modelBuilder.Entity<HrevaluationStandard>(entity =>
        {
            entity.HasOne(d => d.HrevaluationStandardParent).WithMany(p => p.InverseHrevaluationStandardParent).HasConstraintName("FK_HREvaluationStandards_HREvaluationStandards1");
        });

        modelBuilder.Entity<Hrgroup>(entity =>
        {
            entity.HasKey(e => e.HrgroupId).HasName("PK__HRGroups__EB9B9AA44230ABD8");

            entity.Property(e => e.HrgroupIsManager).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Hrgroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRGroups_BRBranchs");

            entity.HasOne(d => d.FkCreatedUser).WithMany(p => p.Hrgroups).HasConstraintName("FK_HRGroups_HREmployees");
        });

        modelBuilder.Entity<Hrkpi>(entity =>
        {
            entity.Property(e => e.FkHrdepartmentId).HasDefaultValueSql("((0))");
            entity.Property(e => e.FkHrdepartmentRoomId).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Hrkpis).HasConstraintName("FK_HRKPIs_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Hrkpis).HasConstraintName("FK_HRKPIs_HRDepartmentRooms");
        });

        modelBuilder.Entity<Hrkpievaluation>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrkpievaluationFkBrbranches).HasConstraintName("FK_HRKPIEvaluations_BRBranchs");

            entity.HasOne(d => d.FkBrbranchId2Navigation).WithMany(p => p.HrkpievaluationFkBrbranchId2Navigations).HasConstraintName("FK_HRKPIEvaluations_BRBranch2");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Hrkpievaluations).HasConstraintName("FK_HRKPIEvaluations_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Hrkpievaluations).HasConstraintName("FK_HRKPIEvaluations_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrkpievaluationFkHremployees).HasConstraintName("FK_HRKPIEvaluations_HREmployees");

            entity.HasOne(d => d.FkHremployeeId2Navigation).WithMany(p => p.HrkpievaluationFkHremployeeId2Navigations).HasConstraintName("FK_HRKPIEvaluations_HREmployees2");

            entity.HasOne(d => d.FkHrkpiregistration).WithMany(p => p.Hrkpievaluations).HasConstraintName("FK_HRKPIEvaluations_HRKPIRegistrations");
        });

        modelBuilder.Entity<HrkpievaluationItem>(entity =>
        {
            entity.HasOne(d => d.FkHremployeeKpievaluationItem).WithMany(p => p.HrkpievaluationItems).HasConstraintName("FK_HRKPIEvaluationItems_HREmployeeKPIEvaluationItems");

            entity.HasOne(d => d.FkHrkpievaluation).WithMany(p => p.HrkpievaluationItems).HasConstraintName("FK_HRKPIEvaluationItems_HRKPIEvaluations");

            entity.HasOne(d => d.FkHrkpiform).WithMany(p => p.HrkpievaluationItems).HasConstraintName("FK_HRKPIEvaluationItems_HRKPIFroms");

            entity.HasOne(d => d.FkHrkpiformItem).WithMany(p => p.HrkpievaluationItems).HasConstraintName("FK_HRKPIEvaluationItems_HRKPIFormItems");

            entity.HasOne(d => d.FkHrkpi).WithMany(p => p.HrkpievaluationItems).HasConstraintName("FK_HRKPIEvaluationItems_HRKPIs");

            entity.HasOne(d => d.FkHrkpiregistration).WithMany(p => p.HrkpievaluationItems).HasConstraintName("FK_HRKPIEvaluationItems_HRKPIRegistrations");

            entity.HasOne(d => d.FkHrkpiregistrationItem).WithMany(p => p.HrkpievaluationItems).HasConstraintName("FK_HRKPIEvaluationItems_HRKPIRegistrationItems");
        });

        modelBuilder.Entity<HrkpievaluationItemTarget>(entity =>
        {
            entity.HasOne(d => d.FkHrkpievaluation).WithMany(p => p.HrkpievaluationItemTargets).HasConstraintName("FK_HRKPIEvaluationItemTargets_HRKPIEvaluations");

            entity.HasOne(d => d.FkHrkpi).WithMany(p => p.HrkpievaluationItemTargets).HasConstraintName("FK_HRKPIEvaluationItemTargets_HRKPIs");
        });

        modelBuilder.Entity<Hrkpiform>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrkpiformFkBrbranches).HasConstraintName("FK_HRKPIForms_BRBranchs");

            entity.HasOne(d => d.FkBrbranchId2Navigation).WithMany(p => p.HrkpiformFkBrbranchId2Navigations).HasConstraintName("FK_HRKPIForms_BRBranchs2");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Hrkpiforms).HasConstraintName("FK_HRKPIForms_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Hrkpiforms).HasConstraintName("FK_HRKPIForms_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Hrkpiforms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRKPIForms_HREmployees");
        });

        modelBuilder.Entity<HrkpiformItem>(entity =>
        {
            entity.Property(e => e.FkHrdepartmentId).HasDefaultValueSql("((0))");
            entity.Property(e => e.FkHrdepartmentRoomId).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrkpiformItems).HasConstraintName("FK_HRKPIFormItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HrkpiformItems).HasConstraintName("FK_HRKPIFormItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHrkpiform).WithMany(p => p.HrkpiformItemFkHrkpiforms).HasConstraintName("FK_HRKPIFormItems_HRKPIForms");

            entity.HasOne(d => d.FkHrkpi).WithMany(p => p.HrkpiformItems).HasConstraintName("FK_HRKPIFormItems_HRKPIs");

            entity.HasOne(d => d.HrkpiformParent).WithMany(p => p.HrkpiformItemHrkpiformParents).HasConstraintName("FK_HRKPIFormItems_HRKPIForms2");
        });

        modelBuilder.Entity<Hrkpiregistration>(entity =>
        {
            entity.Property(e => e.HrkpiregistrationName).HasDefaultValueSql("('')");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrkpiregistrationFkBrbranches).HasConstraintName("FK_HRKPIRegistrations_BRBranchs");

            entity.HasOne(d => d.FkBrbranchId2Navigation).WithMany(p => p.HrkpiregistrationFkBrbranchId2Navigations).HasConstraintName("FK_HRKPIRegistrations_BRBranch2");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Hrkpiregistrations).HasConstraintName("FK_HRKPIRegistrations_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Hrkpiregistrations).HasConstraintName("FK_HRKPIRegistrations_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrkpiregistrationFkHremployees).HasConstraintName("FK_HRKPIRegistrations_HREmployees");

            entity.HasOne(d => d.FkHremployeeId2Navigation).WithMany(p => p.HrkpiregistrationFkHremployeeId2Navigations).HasConstraintName("FK_HRKPIRegistrations_HREmployees2");

            entity.HasOne(d => d.FkHrkpiform).WithMany(p => p.Hrkpiregistrations).HasConstraintName("FK_HRKPIRegistrations_HRKPIForms");
        });

        modelBuilder.Entity<HrkpiregistrationItem>(entity =>
        {
            entity.HasOne(d => d.FkHremployeeKpiregistrationItem).WithMany(p => p.HrkpiregistrationItems).HasConstraintName("FK_HRKPIRegistrationItems_HREmployeeKPIRegistrationItems");

            entity.HasOne(d => d.FkHrkpiform).WithMany(p => p.HrkpiregistrationItems).HasConstraintName("FK_HRKPIRegistrationItems_HRKPIFroms");

            entity.HasOne(d => d.FkHrkpiformItem).WithMany(p => p.HrkpiregistrationItems).HasConstraintName("FK_HRKPIRegistrationItems_HRKPIFormItems");

            entity.HasOne(d => d.FkHrkpi).WithMany(p => p.HrkpiregistrationItems).HasConstraintName("FK_HRKPIRegistrationItems_HRKPIs");

            entity.HasOne(d => d.FkHrkpiregistration).WithMany(p => p.HrkpiregistrationItems).HasConstraintName("FK_HRKPIRegistrationItems_HRKPIRegistrations");
        });

        modelBuilder.Entity<HrkpiregistrationItemTarget>(entity =>
        {
            entity.HasOne(d => d.FkHrkpi).WithMany(p => p.HrkpiregistrationItemTargets).HasConstraintName("FK_HRKPIRegistrationItemTargets_HRKPIs");

            entity.HasOne(d => d.FkHrkpiregistration).WithMany(p => p.HrkpiregistrationItemTargets).HasConstraintName("FK_HRKPIRegistrationItemTargets_HRKPIRegistrations");
        });

        modelBuilder.Entity<HrlabouringConfigItem>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrlabouringConfigItems).HasConstraintName("HRLabouringConfigItems_FK_HRDepartmentID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.HrlabouringConfigItems).HasConstraintName("HRLabouringConfigItems_FK_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HrlabouringConfigItems).HasConstraintName("HRLabouringConfigItems_FK_HRDepartmentRoomID");

            entity.HasOne(d => d.FkHrlabouringConfig).WithMany(p => p.HrlabouringConfigItems).HasConstraintName("HRLabouringConfigItems_FK_HRLabouringConfigID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.HrlabouringConfigItems).HasConstraintName("HRLabouringConfigItems_FK_MMOperationID");
        });

        modelBuilder.Entity<HrleaveApplication>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrleaveApplications).HasConstraintName("FK_HRLeaveApplications_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApprove).WithMany(p => p.HrleaveApplicationFkHremployeeApproves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRLeaveApplications_HREmployees3");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrleaveApplicationFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRLeaveApplications_HREmployees");

            entity.HasOne(d => d.FkHremployeeLeave).WithMany(p => p.HrleaveApplicationFkHremployeeLeaves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRLeaveApplications_HREmployees2");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HrleaveApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRLeaveApplications_HRTimeSheetParams");
        });

        modelBuilder.Entity<HrleaveDay>(entity =>
        {
            entity.HasKey(e => e.HrleaveDayId).HasName("PK_HRDayOffs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrleaveDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRLeaveDays_HREmployees");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HrleaveDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRLeaveDays_HRTimeSheetParams");
        });

        modelBuilder.Entity<Hrlevel>(entity =>
        {
            entity.HasKey(e => e.HrlevelId).HasName("PK_HRPositions");
        });

        modelBuilder.Entity<HrlevelDetail>(entity =>
        {
            entity.HasKey(e => e.HrlevelDetailId).HasName("PK_HRPositionDetails");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrlevelDetails).HasConstraintName("FK_HRLevelDetails_HRDepartments");

            entity.HasOne(d => d.FkHremployeeApprover).WithMany(p => p.HrlevelDetailFkHremployeeApprovers).HasConstraintName("FK_HRLevelDetails_HREmployees2");

            entity.HasOne(d => d.FkHremployeeConsider).WithMany(p => p.HrlevelDetailFkHremployeeConsiders).HasConstraintName("FK_HRLevelDetails_HREmployees1");

            entity.HasOne(d => d.FkHremployeeEditer).WithMany(p => p.HrlevelDetailFkHremployeeEditers).HasConstraintName("FK_HRLevelDetails_HREmployees");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrlevelDetails).HasConstraintName("FK_HRLevelDetails_HRLevels");
        });

        modelBuilder.Entity<HrlevelDutiesResponsibilitiesOther>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrlevelDutiesResponsibilitiesOthers).HasConstraintName("FK_HRLevelDutiesResponsibilitiesOthers_HRLevels");
        });

        modelBuilder.Entity<HrlevelDutiesResponsibilitiess>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrlevelDutiesResponsibilitiesses).HasConstraintName("FK_HRLevelDutiesResponsibilitiess_HRLevels");
        });

        modelBuilder.Entity<HrlevelExternalCompanyRelationship>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrlevelExternalCompanyRelationships).HasConstraintName("FK_HRLevelExternalCompanyRelationships_HRLevels");
        });

        modelBuilder.Entity<HrlevelExternalDepartmentRelationship>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrlevelExternalDepartmentRelationships).HasConstraintName("FK_HRLevelExternalDepartmentRelationships_HRLevels");
        });

        modelBuilder.Entity<HrlevelInternalRelationship>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrlevelInternalRelationships).HasConstraintName("FK_HRLevelInternalRelationships_HRLevels");
        });

        modelBuilder.Entity<HrlevelJurisdiction>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrlevelJurisdictions).HasConstraintName("FK_HRLevelJurisdictions_HRLevels");
        });

        modelBuilder.Entity<HrlevelWorkSummary>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrlevelWorkSummaries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRLevelWorkSummarys_HRLevelID");
        });

        modelBuilder.Entity<HrmachineTimeKeeper>(entity =>
        {
            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.HrmachineTimeKeepers).HasConstraintName("HRMachineTimeKeepers_FK_MMWorkShopID");
        });

        modelBuilder.Entity<Hrmail>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Hrmails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRMails_HREmployees");
        });

        modelBuilder.Entity<HrmailAttachment>(entity =>
        {
            entity.HasOne(d => d.FkHrmail).WithMany(p => p.HrmailAttachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRMailAttachments_HRMails");
        });

        modelBuilder.Entity<HrmanufactureTimeSheet>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrmanufactureTimeSheets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRManufactureTimeSheets_HREmployees");
        });

        modelBuilder.Entity<HrmanufactureTimeSheetItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_ARSaleOrders");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_HREmployees");

            entity.HasOne(d => d.FkHrmanufactureTimeSheet).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_HRManufactureTimeSheets");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.HrmanufactureTimeSheetItemFkIcproducts).HasConstraintName("FK_HRManufactureTimeSheetItems_ICProducts");

            entity.HasOne(d => d.FkIcproductIdforBatchNavigation).WithMany(p => p.HrmanufactureTimeSheetItemFkIcproductIdforBatchNavigations).HasConstraintName("FK_HRManufactureTimeSheetItems_ICProducts_1");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_MMOperations");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_MMProductionNorms");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.HrmanufactureTimeSheetItems).HasConstraintName("FK_HRManufactureTimeSheetItems_MMProposals");
        });

        modelBuilder.Entity<Hrotfactor>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.Hrotfactors).HasConstraintName("FK_HROTFactors_HREmployeePayrollFormulas");
        });

        modelBuilder.Entity<HrotherLeaveDayConfig>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrotherLeaveDayConfigs).HasConstraintName("HROtherLeaveDayConfigs_FK_HRDepartmentID");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrotherLeaveDayConfigs).HasConstraintName("HROtherLeaveDayConfigs_FK_HREmployeeID");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrotherLeaveDayConfigs).HasConstraintName("HROtherLeaveDayConfigs_FK_HRLevelID");
        });

        modelBuilder.Entity<HrpayRoll>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrpayRolls).HasConstraintName("FK_HRPayRolls_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrpayRolls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRPayRolls_HREmployees");
        });

        modelBuilder.Entity<HrpayRollAudit>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrpayRollAudits).HasConstraintName("FK_HRPayRollAudits_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrpayRollAudits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRPayRollAudits_HREmployees");
        });

        modelBuilder.Entity<HrquarterReward>(entity =>
        {
            entity.HasKey(e => e.HrquarterRewardId).HasName("PK_HRQuarterRewardServer");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrquarterRewards).HasConstraintName("FK_HRQuarterRewards_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrquarterRewards).HasConstraintName("FK_HRQuarterRewards_HREmployees");
        });

        modelBuilder.Entity<HrrecruitmentNeed>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrrecruitmentNeeds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRecruitmentNeeds_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrrecruitmentNeeds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRecruitmentNeeds_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HrrecruitmentNeeds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRecruitmentNeeds_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrrecruitmentNeeds).HasConstraintName("FK_HRRecruitmentNeeds_HREmployees");
        });

        modelBuilder.Entity<HrrecruitmentNeedItem>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrrecruitmentNeedItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRecruitmentNeedItems_HRLevels");

            entity.HasOne(d => d.FkHrrecruitmentNeed).WithMany(p => p.HrrecruitmentNeedItems).HasConstraintName("FK_HRRecruitmentNeedItems_HRRecruitmentNeeds");
        });

        modelBuilder.Entity<HrrecruitmentPlan>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrrecruitmentPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRecruitmentPlans_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrrecruitmentPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRecruitmentPlans_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.HrrecruitmentPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRecruitmentPlans_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrrecruitmentPlans).HasConstraintName("FK_HRRecruitmentPlans_HREmployees");
        });

        modelBuilder.Entity<HrrecruitmentPlanItem>(entity =>
        {
            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrrecruitmentPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRecruitmentPlanItems_HRLevels");

            entity.HasOne(d => d.FkHrrecruitmentNeed).WithMany(p => p.HrrecruitmentPlanItems).HasConstraintName("FK_HRRecruitmentPlanItems_HRRecruitmentNeeds");

            entity.HasOne(d => d.FkHrrecruitmentNeedItem).WithMany(p => p.HrrecruitmentPlanItems).HasConstraintName("FK_HRRecruitmentPlanItems_HRRecruitmentNeedItems");

            entity.HasOne(d => d.FkHrrecruitmentPlan).WithMany(p => p.HrrecruitmentPlanItems).HasConstraintName("FK_HRRecruitmentPlanItems_HRRecruitmentPlans");
        });

        modelBuilder.Entity<HrregisterDormitory>(entity =>
        {
            entity.HasKey(e => e.HrregisterDormitoryId).HasName("FK_HRRegisterDormitorys");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrregisterDormitories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRegisterDormitorys_BRBranchs");

            entity.HasOne(d => d.FkHrdormitory).WithMany(p => p.HrregisterDormitories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRegisterDormitorys_HRDormitorys");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrregisterDormitoryFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRegisterDormitorys_HREmployees");

            entity.HasOne(d => d.FkHremployeeManagerNavigation).WithMany(p => p.HrregisterDormitoryFkHremployeeManagerNavigations).HasConstraintName("HRRegisterDormitoryItems_FK_HREmployeeManager");
        });

        modelBuilder.Entity<HrregisterDormitoryItem>(entity =>
        {
            entity.HasKey(e => e.HrregisterDormitoryItemId).HasName("FK_HRRegisterDormitoryItems");

            entity.HasOne(d => d.FkHremployeeContactPerson).WithMany(p => p.HrregisterDormitoryItems).HasConstraintName("HRRegisterDormitoryItems_FK_HREmployeeContactPersonID");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrregisterDormitoryItems).HasConstraintName("FK_HRRegisterDormitoryItems_HREmployees");

            entity.HasOne(d => d.FkHrregisterDormitory).WithMany(p => p.HrregisterDormitoryItems).HasConstraintName("FK_HRRegisterDormitoryItems_HRRegisterDormitorys");

            entity.HasOne(d => d.FkHrrelationship).WithMany(p => p.HrregisterDormitoryItems).HasConstraintName("HRRegisterDormitoryItems_FK_HRRelationshipID");
        });

        modelBuilder.Entity<HrrequestEditEmployee>(entity =>
        {
            entity.HasOne(d => d.FkHrapproveEmployee).WithMany(p => p.HrrequestEditEmployeeFkHrapproveEmployees).HasConstraintName("FK_HRRequestEditEmployees_HRApproveEmployees");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrrequestEditEmployeeFkHremployees).HasConstraintName("FK_HRRequestEditEmployees_HREmployees");

            entity.HasOne(d => d.HrrequestEditEmployeeBranch).WithMany(p => p.HrrequestEditEmployees).HasConstraintName("FK_HRRequestEditEmployees_BRRequestEditEmployeeBranchs");

            entity.HasOne(d => d.HrrequestEditEmployeeDepartment).WithMany(p => p.HrrequestEditEmployees).HasConstraintName("FK_HRRequestEditEmployees_HRRequestEditEmployeeDepartments");

            entity.HasOne(d => d.HrrequestEditEmployeeDepartmentRoom).WithMany(p => p.HrrequestEditEmployees).HasConstraintName("FK_HRRequestEditEmployees_HRRequestEditEmployeeDepartmentRooms");

            entity.HasOne(d => d.HrrequestEditEmployeeLevel).WithMany(p => p.HrrequestEditEmployees).HasConstraintName("FK_HRRequestEditEmployees_HRRequestEditEmployeeLevels");
        });

        modelBuilder.Entity<HrrequestLeaveDay>(entity =>
        {
            entity.HasOne(d => d.FkHrapproveEmployee).WithMany(p => p.HrrequestLeaveDayFkHrapproveEmployees).HasConstraintName("FK_HRRequestLeaveDays_HRApproveEmployees");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrrequestLeaveDayFkHremployees).HasConstraintName("FK_HRRequestLeaveDays_HREmployees");

            entity.HasOne(d => d.FkHremployeeLeave).WithMany(p => p.HrrequestLeaveDayFkHremployeeLeaves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRequestLeaveDays_HREmployees2");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HrrequestLeaveDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRRequestLeaveDays_HRTimeSheetParams");
        });

        modelBuilder.Entity<Hrreward>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Hrrewards).HasConstraintName("FK_HRRewards_BRBranchs");
        });

        modelBuilder.Entity<Hrschedule>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Hrschedules).HasConstraintName("FK_HRSchedules_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Hrschedules).HasConstraintName("FK_HRSchedules_HREmployees");
        });

        modelBuilder.Entity<HrsocialInsuranceDeclaration>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrsocialInsuranceDeclarations).HasConstraintName("FK_HRSocialInsuranceDeclarations_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrsocialInsuranceDeclarations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRSocialInsuranceDeclarations_HREmployees");
        });

        modelBuilder.Entity<HrsocialInsuranceDeclarationItem>(entity =>
        {
            entity.HasOne(d => d.FkAdinsurranceCondition).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_ADInsurranceConditions");

            entity.HasOne(d => d.FkAdinsurrancePaper).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_ADInsurrancePapers");

            entity.HasOne(d => d.FkAdinsurrancePlan).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_ADInsurrancePlans");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GECountrys");

            entity.HasOne(d => d.FkGedistrict).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GEDistricts");

            entity.HasOne(d => d.FkGeidcardStateProvince).WithMany(p => p.HrsocialInsuranceDeclarationItemFkGeidcardStateProvinces).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GEStateProvinces");

            entity.HasOne(d => d.FkGeidcardStateProvinceId2Navigation).WithMany(p => p.HrsocialInsuranceDeclarationItemFkGeidcardStateProvinceId2Navigations).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GEStateProvinces2");

            entity.HasOne(d => d.FkGenationality).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GENationalitys");

            entity.HasOne(d => d.FkGewardIdchuHoNavigation).WithMany(p => p.HrsocialInsuranceDeclarationItemFkGewardIdchuHoNavigations).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GEWards1");

            entity.HasOne(d => d.FkGewardIdkhaiSinhNavigation).WithMany(p => p.HrsocialInsuranceDeclarationItemFkGewardIdkhaiSinhNavigations).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GEWards3");

            entity.HasOne(d => d.FkGewardIdlienHeNavigation).WithMany(p => p.HrsocialInsuranceDeclarationItemFkGewardIdlienHeNavigations).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GEWards2");

            entity.HasOne(d => d.FkGewardIdthuongTruNavigation).WithMany(p => p.HrsocialInsuranceDeclarationItemFkGewardIdthuongTruNavigations).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_GEWards4");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_HRDepartments");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_HREmployees");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_HRLevels");

            entity.HasOne(d => d.FkHrsocialInsuranceDeclaration).WithMany(p => p.HrsocialInsuranceDeclarationItems).HasConstraintName("FK_HRSocialInsuranceDeclarationItems_HRSocialInsuranceDeclarations");
        });

        modelBuilder.Entity<HrsplitRatio>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrsplitRatios).HasConstraintName("FK_HRSplitRatios_BRBranchs");

            entity.HasOne(d => d.FkCscompany).WithMany(p => p.HrsplitRatios).HasConstraintName("FK_HRSplitRatios_CSCompanys");
        });

        modelBuilder.Entity<HrstandardQuestion>(entity =>
        {
            entity.HasOne(d => d.FkHrevaluationQuestion).WithMany(p => p.HrstandardQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRStandardQuestions_HREvaluationQuestions");

            entity.HasOne(d => d.FkHrevaluationStandard).WithMany(p => p.HrstandardQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRStandardQuestions_HREvaluationStandards");
        });

        modelBuilder.Entity<HrtemplateRank>(entity =>
        {
            entity.HasOne(d => d.FkHrevaluationRank).WithMany(p => p.HrtemplateRanks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTemplateRanks_HREvaluationRanks");

            entity.HasOne(d => d.FkHrevaluationTemplate).WithMany(p => p.HrtemplateRanks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTemplateRanks_HREvaluationTemplates");
        });

        modelBuilder.Entity<HrtemplateStandard>(entity =>
        {
            entity.HasOne(d => d.FkHrevaluationStandard).WithMany(p => p.HrtemplateStandards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTemplateStandards_HREvaluationStandards");

            entity.HasOne(d => d.FkHrevaluationTemplate).WithMany(p => p.HrtemplateStandards)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTemplateStandards_HREvaluationTemplates");
        });

        modelBuilder.Entity<HrtimeKeeper>(entity =>
        {
            entity.HasOne(d => d.FkHrmachineTimeKeeper).WithMany(p => p.HrtimeKeepers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeKeepers_HRMachineTimeKeepers");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.HrtimeKeepers).HasConstraintName("HRTimeKeepers_FK_MMWorkShopID");
        });

        modelBuilder.Entity<HrtimeKeeperComplete>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.HrtimeKeeperCompletes).HasConstraintName("FK_HRTimeKeeperCompletes_HRDepartments");

            entity.HasOne(d => d.FkHrlevel).WithMany(p => p.HrtimeKeeperCompletes).HasConstraintName("FK_HRTimeKeeperCompletes_HRLevels");

            entity.HasOne(d => d.FkHrmachineTimeKeeper).WithMany(p => p.HrtimeKeeperCompletes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeKeeperCompletes_HRMachineTimeKeepers");

            entity.HasOne(d => d.FkHrtimeKeeper).WithMany(p => p.HrtimeKeeperCompletes).HasConstraintName("FK_HRTimeKeeperCompletes_HRTimeKeepers");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.HrtimeKeeperCompletes).HasConstraintName("HRTimeKeeperCompletes_FK_MMWorkShopID");
        });

        modelBuilder.Entity<HrtimeKeeperHistory>(entity =>
        {
            entity.HasKey(e => e.HrtimeKeeperHistoryId).HasName("PK_HRTimeKeeperHistory");

            entity.HasOne(d => d.FkHrtimeKeeperComplete).WithMany(p => p.HrtimeKeeperHistories).HasConstraintName("FK_HRTimeKeeperHistorys_HRTimeKeeperCompletes");
        });

        modelBuilder.Entity<HrtimeKeeperHistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkHrtimeKeeperHistory).WithMany(p => p.HrtimeKeeperHistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeKeeperHistoryDetails_HRTimeKeeperHistory");
        });

        modelBuilder.Entity<HrtimeSheet>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrtimeSheets).HasConstraintName("FK_HRTimeSheets_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrtimeSheets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheets_HREmployees");
        });

        modelBuilder.Entity<HrtimeSheetAudit>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.HrtimeSheetAudits).HasConstraintName("FK_HRTimeSheetAudits_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrtimeSheetAudits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetAudits_HREmployees");

            entity.HasOne(d => d.FkHrtimeSheet).WithMany(p => p.HrtimeSheetAudits).HasConstraintName("FK_HRTimeSheetAudits_HRTimeSheets");
        });

        modelBuilder.Entity<HrtimeSheetAuditEntry>(entity =>
        {
            entity.HasKey(e => e.HrtimeSheetAuditEntryId).HasName("PK_HRTimeSheetAuditDetails");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrtimeSheetAuditEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetAuditEntrys_HREmployees");

            entity.HasOne(d => d.FkHremployeeTimeSheetAudit).WithMany(p => p.HrtimeSheetAuditEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetAuditEntrys_HREmployeeTimeSheetAudits");

            entity.HasOne(d => d.FkHrtimeSheetAudit).WithMany(p => p.HrtimeSheetAuditEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetAuditEntrys_HRTimeSheetAudits");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HrtimeSheetAuditEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetAuditEntrys_HRTimeSheetParams");
        });

        modelBuilder.Entity<HrtimeSheetEntry>(entity =>
        {
            entity.HasKey(e => e.HrtimeSheetEntryId).HasName("PK_HRTimeSheetDetails");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrtimeSheetEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetEntrys_HREmployees");

            entity.HasOne(d => d.FkHremployeeTimeSheet).WithMany(p => p.HrtimeSheetEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetEntrys_HREmployeeTimeSheets");

            entity.HasOne(d => d.FkHrtimeSheet).WithMany(p => p.HrtimeSheetEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetEntrys_HRTimeSheets");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HrtimeSheetEntries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTimeSheetEntrys_HRTimeSheetParams");
        });

        modelBuilder.Entity<HrtimeSheetLevel>(entity =>
        {
            entity.HasOne(d => d.FkHrtimeSheetScale).WithMany(p => p.HrtimeSheetLevels).HasConstraintName("FK_HRTimeSheetLevels_HRTimeSheetScales");
        });

        modelBuilder.Entity<HrtimesheetConfig>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.HrtimesheetConfigs).HasConstraintName("FK_HRTimesheetConfigs_HREmployeePayrollFormulas");
        });

        modelBuilder.Entity<HrtimesheetEmployeeLate>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.HrtimesheetEmployeeLates).HasConstraintName("FK_HRTimesheetEmployeeLates_HREmployeePayrollFormulas");
        });

        modelBuilder.Entity<HrtrainningClass>(entity =>
        {
            entity.HasOne(d => d.FkHrtrainningCourse).WithMany(p => p.HrtrainningClasses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTrainningClass_HRTrainningClass");
        });

        modelBuilder.Entity<HrtrainningEmployee>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrtrainningEmployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTrainningEmployees_HREmployees");

            entity.HasOne(d => d.FkHrtrainningClass).WithMany(p => p.HrtrainningEmployees).HasConstraintName("FK_HRTrainningEmployees_HRTrainningClass");

            entity.HasOne(d => d.FkHrtrainningCourse).WithMany(p => p.HrtrainningEmployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTrainningEmployees_HRTrainningCourses");
        });

        modelBuilder.Entity<HrtrainningSchedule>(entity =>
        {
            entity.HasOne(d => d.FkHrclassSchedule).WithMany(p => p.HrtrainningSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTrainningSchedules_HRClassSchedules");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.HrtrainningSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTrainningSchedules_HREmployees");

            entity.HasOne(d => d.FkHrtrainningClass).WithMany(p => p.HrtrainningSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HRTrainningSchedules_HRTrainningClass");
        });

        modelBuilder.Entity<HrworkingFeeConfig>(entity =>
        {
            entity.HasOne(d => d.FkGestateProvince).WithMany(p => p.HrworkingFeeConfigs).HasConstraintName("FK_HRWorkingFeeConfigs_GEStateProvinces");

            entity.HasOne(d => d.FkHrcostTypeConfig).WithMany(p => p.HrworkingFeeConfigs).HasConstraintName("FK_HRWorkingFeeConfigs_HRCostTypeConfigs");
        });

        modelBuilder.Entity<HrworkingShift>(entity =>
        {
            entity.HasOne(d => d.FkHremployeePayrollFormula).WithMany(p => p.HrworkingShiftFkHremployeePayrollFormulas).HasConstraintName("FK_HRWorkingShifts_HREmployeePayrollFormulas");

            entity.HasOne(d => d.FkHrtimeSheetParam).WithMany(p => p.HrworkingShiftFkHrtimeSheetParams).HasConstraintName("FK_HRWorkingShifts_HRTimeSheetParams");

            entity.HasOne(d => d.FkHrworkingShift).WithMany(p => p.InverseFkHrworkingShift).HasConstraintName("FK_HRWorkingShifts_HRWorkingShifts");
        });

        modelBuilder.Entity<Icadjustment>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Icadjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAdjustments_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Icadjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAdjustments_GECurrencies");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Icadjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAdjustments_HREmployees");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Icadjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAdjustments_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.Icadjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAdjustments_ICStockSlots");
        });

        modelBuilder.Entity<IcadjustmentItem>(entity =>
        {
            entity.HasOne(d => d.FkIcadjustment).WithMany(p => p.IcadjustmentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAdjustmentItems_ICAdjustments");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcadjustmentItems).HasConstraintName("FK_ICAdjustmentItems_ICDepartments");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcadjustmentItems).HasConstraintName("FK_ICAdjustmentItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcadjustmentItems).HasConstraintName("FK_ICAdjustmentItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcadjustmentItems).HasConstraintName("FK_ICAdjustmentItems_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.IcadjustmentItems).HasConstraintName("FK_ICAdjustmentItems_ICStockSlots");
        });

        modelBuilder.Entity<IcassembleProduct>(entity =>
        {
            entity.HasKey(e => e.IcassembleProductId).HasName("PK_ICAssembleProduct");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcassembleProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAssembleProducts_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcassembleProducts).HasConstraintName("FK_ICAssembleProducts_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcassembleProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAssembleProducts_ICStocks");
        });

        modelBuilder.Entity<IcassembleProductDetail>(entity =>
        {
            entity.HasKey(e => e.IcassembleProductDetailId).HasName("PK_ICAssembleProductDetail");

            entity.HasOne(d => d.FkIcassembleProduct).WithMany(p => p.IcassembleProductDetails).HasConstraintName("FK_ICAssembleProductDetails_ICAssembleProducts");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcassembleProductDetails).HasConstraintName("FK_ICAssembleProductDetails_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcassembleProductDetails).HasConstraintName("FK_ICAssembleProductDetails_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcassembleProductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICAssembleProductDetails_ICStocks");
        });

        modelBuilder.Entity<IcaverageCost>(entity =>
        {
            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcaverageCosts).HasConstraintName("FK_ICAverageCosts_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcaverageCosts).HasConstraintName("FK_ICAverageCosts_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcaverageCosts).HasConstraintName("FK_ICAverageCosts_ICStocks");
        });

        modelBuilder.Entity<Icbarcode>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Icbarcodes).HasConstraintName("FK_ICBarcodes_HREmployees");
        });

        modelBuilder.Entity<IcbarcodeItem>(entity =>
        {
            entity.HasOne(d => d.FkIcbarcode).WithMany(p => p.IcbarcodeItems).HasConstraintName("FK_ICBarcodeItems_ICBarcodes");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcbarcodeItems).HasConstraintName("FK_ICBarcodeItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcbarcodeItems).HasConstraintName("FK_ICBarcodeItems_ICProducts");
        });

        modelBuilder.Entity<IcbravoProduct>(entity =>
        {
            entity.HasKey(e => e.IcbravoProductId).HasName("PK__ICBravoP__479A82C857DD3DAE");
        });

        modelBuilder.Entity<Iccollection>(entity =>
        {
            entity.HasKey(e => e.IccollectionId).HasName("PK__ICCollec__1CF741C97FE6CE92");

            entity.HasOne(d => d.FkHremployeeApprove).WithMany(p => p.IccollectionFkHremployeeApproves).HasConstraintName("FK_ICCollections_HREmployeeApproves");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IccollectionFkHremployees).HasConstraintName("FK_ICCollections_HREmployees");
        });

        modelBuilder.Entity<IccollectionItem>(entity =>
        {
            entity.HasOne(d => d.FkIccollection).WithMany(p => p.IccollectionItems).HasConstraintName("FK_ICCollectionItems_ICCollections");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IccollectionItems).HasConstraintName("FK_ICCollectionItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IccollectionItems).HasConstraintName("FK_ICCollectionItems_ICProducts");
        });

        modelBuilder.Entity<IcconfigAccordWoodType>(entity =>
        {
            entity.Property(e => e.IcconfigAccordWoodTypeId).ValueGeneratedNever();

            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.IcconfigAccordWoodTypeFkIcproductAttributes).HasConstraintName("FK_ICConfigAccordWoodTypes_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcconfigAccordWoodTypeFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICConfigAccordWoodTypes_ICProductAttributes");
        });

        modelBuilder.Entity<IcconversionProposal>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcconversionProposals).HasConstraintName("FK_ICConversionProposals_BRBranchs");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.IcconversionProposals).HasConstraintName("FK_ICConversionProposals_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcconversionProposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICConversionProposals_HREmployees");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcconversionProposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICConversionProposals_ICStocks");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.IcconversionProposals).HasConstraintName("FK_ICConversionProposals_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IcconversionProposals).HasConstraintName("FK_ICConversionProposals_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.IcconversionProposals).HasConstraintName("FK_ICConversionProposals_MMWorkShops");
        });

        modelBuilder.Entity<IcconversionProposalItem>(entity =>
        {
            entity.HasOne(d => d.FkIcconversionProposal).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_ICConversionProposals");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_ICStocks");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_MMAllocationPlans");

            entity.HasOne(d => d.FkMmallocationPlanItem).WithMany(p => p.IcconversionProposalItems).HasConstraintName("FK_ICConversionProposalItems_MMAllocationPlanItems");
        });

        modelBuilder.Entity<IcdepartmentAttribute>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcdepartmentAttributes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICDepartments_ICDepartmentAttributes");
        });

        modelBuilder.Entity<IcdepartmentAttributeValue>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartmentAttribute).WithMany(p => p.IcdepartmentAttributeValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICDepartmentAttributes_ICDepartmentAttributeValues");
        });

        modelBuilder.Entity<IcdepartmentFormat>(entity =>
        {
            entity.HasKey(e => e.IcdepartmentFormatId).HasName("PK_DepartmentFormat");

            entity.HasOne(d => d.FkStfieldFormatGroup).WithMany(p => p.IcdepartmentFormats).HasConstraintName("FK_ICDepartmentFormats_STFieldFormatGroups");
        });

        modelBuilder.Entity<IcdisassembleProduct>(entity =>
        {
            entity.HasKey(e => e.IcdisassembleProductId).HasName("PK_ICDisassembleProduct");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcdisassembleProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICDisassembleProducts_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcdisassembleProducts).HasConstraintName("FK_ICDisassembleProducts_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcdisassembleProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICDisassembleProducts_ICStocks");
        });

        modelBuilder.Entity<IcdisassembleProductDetail>(entity =>
        {
            entity.HasKey(e => e.IcdisassembleProductDetailId).HasName("PK_ICDisassembleProductDetail");

            entity.HasOne(d => d.FkIcdisassembleProduct).WithMany(p => p.IcdisassembleProductDetails).HasConstraintName("FK_ICDisassembleProductDetails_ICDisassembleProducts");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcdisassembleProductDetails).HasConstraintName("FK_ICDisassembleProductDetails_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcdisassembleProductDetails).HasConstraintName("FK_ICDisassembleProductDetails_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcdisassembleProductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICDisassembleProductDetails_ICStocks");
        });

        modelBuilder.Entity<IcfeeConfig>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.IcfeeConfigs).HasConstraintName("FK_ICFeeConfigs_ACAccounts");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.IcfeeConfigs).HasConstraintName("FK_ICFeeConfigs_GELocations");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcfeeConfigs).HasConstraintName("FK_ICFeeConfigs_ICMeasureUnits");
        });

        modelBuilder.Entity<Ichistory>(entity =>
        {
            entity.HasKey(e => e.IchistoryId).HasName("PK_ICHistory");

            entity.Property(e => e.IchistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.IchistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.IchistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<IcimportAndExportReason>(entity =>
        {
            entity.HasOne(d => d.FkAcacount).WithMany(p => p.IcimportAndExportReasons).HasConstraintName("FK_ICImportAndExportReasons_ACAccounts");
        });

        modelBuilder.Entity<IcimportEquipment>(entity =>
        {
            entity.HasKey(e => e.IcimportEquipmentId).HasName("PK__ICImport__B6F171D3452B2744");
        });

        modelBuilder.Entity<IcimportReceiptShipment>(entity =>
        {
            entity.HasKey(e => e.IcimportReceiptShipmentId).HasName("PK__ICImport__EB2303D175637EF4");
        });

        modelBuilder.Entity<IcimportStockMinMax>(entity =>
        {
            entity.HasKey(e => e.IcimportStockMinMaxId).HasName("PK_ImportStockMinMaxs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcimportStockMinMaxes).HasConstraintName("FK_ICImportStockMinMaxs_ICProducts");
        });

        modelBuilder.Entity<IcinitializedInventoryStock>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinitializedInventoryStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInitializedInventoryStocks_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcinitializedInventoryStocks).HasConstraintName("ICInitializedInventoryStocks_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinitializedInventoryStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInitializedInventoryStocks_ICStocks");
        });

        modelBuilder.Entity<IcinvAdjustment>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinvAdjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInvAdjustments_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcinvAdjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInvAdjustments_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinvAdjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInvAdjustments_ICStocks");
        });

        modelBuilder.Entity<IcinvBalance>(entity =>
        {
            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinvBalances).HasConstraintName("FK_ICInvBalances_ICStocks");
        });

        modelBuilder.Entity<IcinventoryItemPackage>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinventoryItemPackages).HasConstraintName("FK_ICInventoryItemPackages_ICProducts");

            entity.HasOne(d => d.FkIcproductPackageItem).WithMany(p => p.IcinventoryItemPackages).HasConstraintName("FK_ICInventoryItemPackages_ICProductPackageItems");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcinventoryItemPackages).HasConstraintName("FK_ICInventoryItemPackages_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinventoryItemPackages).HasConstraintName("FK_ICInventoryItemPackages_ICStocks");
        });

        modelBuilder.Entity<IcinventoryPackage>(entity =>
        {
            entity.HasOne(d => d.FkIcpackage).WithMany(p => p.IcinventoryPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryPackages_ICPackages");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinventoryPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryPackages_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinventoryPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryPackages_ICStocks");
        });

        modelBuilder.Entity<IcinventoryPermission>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.IcinventoryPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryPermissions_ADUserGroups");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinventoryPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryPermissions_ICStocks");
        });

        modelBuilder.Entity<IcinventoryStock>(entity =>
        {
            entity.HasKey(e => e.IcinventoryStockId).HasName("PK_AAInventoryStock");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinventoryStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AAInventoryStock_MAProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcinventoryStocks).HasConstraintName("FK_ICInventoryStocks_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinventoryStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AAInventoryStock_MAStocks");
        });

        modelBuilder.Entity<IcinventoryStockCount>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcinventoryStockCounts).HasConstraintName("FK_ICInventoryStockCounts_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcinventoryStockCounts).HasConstraintName("FK_ICInventoryStockCounts_HREmployees");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcinventoryStockCounts).HasConstraintName("FK_ICInventoryStockCounts_ICDepartments");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcinventoryStockCounts).HasConstraintName("FK_ICInventoryStockCounts_ICProductGroups");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinventoryStockCounts).HasConstraintName("FK_ICInventoryStockCounts_ICStocks");
        });

        modelBuilder.Entity<IcinventoryStockCountItem>(entity =>
        {
            entity.HasOne(d => d.FkIcinventoryStockCount).WithMany(p => p.IcinventoryStockCountItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryStockCountItems_ICInventoryStockCounts");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinventoryStockCountItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryStockCountItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcinventoryStockCountItems).HasConstraintName("FK_ICInventoryStockCountItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinventoryStockCountItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryStockCountItems_ICStockID");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.IcinventoryStockCountItems).HasConstraintName("FK_ICInventoryStockCountItems_ICStockSlots");
        });

        modelBuilder.Entity<IcinventoryStockSerial>(entity =>
        {
            entity.HasKey(e => e.IcinventoryStockSerialId).HasName("PK_ICInventoryStockSeries");

            entity.HasOne(d => d.FkIcinventoryStock).WithMany(p => p.IcinventoryStockSerials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryStockSeries_ICInventoryStocks");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinventoryStockSerials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryStockSeries_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcinventoryStockSerials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICInventoryStockSeries_ICStocks");
        });

        modelBuilder.Entity<IcinventoryStockSlot>(entity =>
        {
            entity.HasKey(e => e.IcinventoryStockSlotId).HasName("PK_MAProductSlots");

            entity.HasOne(d => d.FkIcinventoryStock).WithMany(p => p.IcinventoryStockSlots).HasConstraintName("FK_AAInventoryStockSlot_AAInventoryStock");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinventoryStockSlots)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AAInventoryStockSlot_MAProducts");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.IcinventoryStockSlots)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AAInventoryStockSlot_MAStockSlots");
        });

        modelBuilder.Entity<IcinventoryStockSlotSeries>(entity =>
        {
            entity.HasKey(e => e.AainventoryStockSlotSerieId).HasName("PK_MAProductSlotSeries");

            entity.HasOne(d => d.FkIcinventoryStockSlot).WithMany(p => p.IcinventoryStockSlotSeries).HasConstraintName("FK_AAInventoryStockSlotSeries_AAInventoryStockSlot");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcinventoryStockSlotSeries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AAInventoryStockSlotSeries_MAProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcinventoryStockSlotSeries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AAInventoryStockSlotSeries_MAProductSeries");
        });

        modelBuilder.Entity<IcmachineGroup>(entity =>
        {
            entity.HasOne(d => d.FkAcasset).WithMany(p => p.IcmachineGroups).HasConstraintName("FK_ICMachineGroups_FK_ACAssetID");

            entity.HasOne(d => d.FkIcmachine).WithMany(p => p.IcmachineGroups).HasConstraintName("ICMachineGroups_FK_ICMachineID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcmachineGroups).HasConstraintName("FK_ICMachineGroups_FK_ICProductID");

            entity.HasOne(d => d.FkIcproductIdentifiedEquipment).WithMany(p => p.IcmachineGroups).HasConstraintName("FK_ICMachineGroups_FK_ICProductIdentifiedEquipmentID");
        });

        modelBuilder.Entity<IcmaterialConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcmaterialConfigs).HasConstraintName("FK_ICMaterialConfigs_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttHttypeNavigation).WithMany(p => p.IcmaterialConfigFkIcproductAttHttypeNavigations).HasConstraintName("FK_ICMaterialConfigs_ICProductAttHTType");

            entity.HasOne(d => d.FkIcproductAttPackingMaterialSpecialityNavigation).WithMany(p => p.IcmaterialConfigFkIcproductAttPackingMaterialSpecialityNavigations).HasConstraintName("FK_ICMaterialConfigs_ICProductAttPackingMaterialSpeciality");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcmaterialConfigFkIcproductAttributeWoodTypes).HasConstraintName("ICMaterialConfigs_FK_ICProductAttributes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcmaterialConfigs).HasConstraintName("ICMaterialConfigs_FK_ICProductID");
        });

        modelBuilder.Entity<IcmodelDetail>(entity =>
        {
            entity.HasKey(e => e.IcmodelDetailId).HasName("PK_ICModelDetailss");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.IcmodelDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICModelDetails_ICModels");
        });

        modelBuilder.Entity<Icpackage>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.Icpackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICPackages_APSuppliers");
        });

        modelBuilder.Entity<IcpackageProduct>(entity =>
        {
            entity.HasOne(d => d.FkIcpackage).WithMany(p => p.IcpackageProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICPackageProducts_ICPackages");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcpackageProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICPackageProducts_ICProducts");
        });

        modelBuilder.Entity<IcpackagingNormItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcpackagingNormItems).HasConstraintName("FK_ICPackagingNormItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcpackagingNormItemFkIcproducts).HasConstraintName("FK_ICPackagingNormItems_ICProducts");

            entity.HasOne(d => d.FkIcproductParent).WithMany(p => p.IcpackagingNormItemFkIcproductParents).HasConstraintName("FK_ICPackagingNormItems_ICProductParents");
        });

        modelBuilder.Entity<IcpriceAdjustment>(entity =>
        {
            entity.HasKey(e => e.IcpriceAdjustmentId).HasName("PK_FAPriceAdjustments");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcpriceAdjustments).HasConstraintName("FK_ICPriceAdjustments_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcpriceAdjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICPriceAdjustments_HREmployees");
        });

        modelBuilder.Entity<IcpriceAdjustmentItem>(entity =>
        {
            entity.HasKey(e => e.IcpriceAdjustmentItemId).HasName("PK_FAPriceAdjustmentItems");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcpriceAdjustmentItems).HasConstraintName("FK_ICPriceAdjustmentItems_ICDepartments");

            entity.HasOne(d => d.FkIcinventoryStock).WithMany(p => p.IcpriceAdjustmentItems).HasConstraintName("FK_ICPriceAdjustmentItems_ICInventoryStocks");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcpriceAdjustmentItems).HasConstraintName("FK_ICPriceAdjustmentItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcpriceAdjustment).WithMany(p => p.IcpriceAdjustmentItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICPriceAdjustments_FAICPriceAdjustments");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcpriceAdjustmentItems).HasConstraintName("FK_ICPriceAdjustmentItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcpriceAdjustmentItems).HasConstraintName("FK_FAICPriceAdjustmentItems_MAProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcpriceAdjustmentItems).HasConstraintName("FK_ICPriceAdjustmentItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcpriceAdjustmentItems).HasConstraintName("FK_ICPriceAdjustmentItems_ICStocks");
        });

        modelBuilder.Entity<Icproduct>(entity =>
        {
            entity.HasKey(e => e.IcproductId).HasName("PK_Item");

            entity.HasOne(d => d.FkAcaccountCostPrice).WithMany(p => p.IcproductFkAcaccountCostPrices).HasConstraintName("FK_ICProducts_ACAccountCostPrices");

            entity.HasOne(d => d.FkAcaccountDiscount).WithMany(p => p.IcproductFkAcaccountDiscounts).HasConstraintName("FK_ICProducts_ACAccountDiscounts");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.IcproductFkAcaccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProducts_ACAccounts");

            entity.HasOne(d => d.FkAcaccountRevenueHinterLand).WithMany(p => p.IcproductFkAcaccountRevenueHinterLands).HasConstraintName("FK_ICProducts_ACAccountRevenueHinterLands");

            entity.HasOne(d => d.FkAcaccountRevenue).WithMany(p => p.IcproductFkAcaccountRevenues).HasConstraintName("FK_ICProducts_ACAccountRevenues");

            entity.HasOne(d => d.FkAcaccountRevenueInternal).WithMany(p => p.IcproductFkAcaccountRevenueInternals).HasConstraintName("FK_ICProducts_ACAccountInventorys");

            entity.HasOne(d => d.FkAcaccountSaleReturn).WithMany(p => p.IcproductFkAcaccountSaleReturns).HasConstraintName("FK_ICProducts_ACAccountSaleReturns");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_ACCostCenter");

            entity.HasOne(d => d.FkAcdepreciationAccount).WithMany(p => p.IcproductFkAcdepreciationAccounts).HasConstraintName("FK_ICProducts_ACAccounts3");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.IcproductFkAcdepreciationCostAccounts).HasConstraintName("FK_ICProducts_ACAccounts2");

            entity.HasOne(d => d.FkAcequipmentTypeAccountConfig).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_ACEquipmentTypeAccountConfigs");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_ACSegment");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_APSuppliers");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Icproducts).HasConstraintName("ICProducts_FK_ARCustomerID");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_GECountrys");

            entity.HasOne(d => d.FkGevat).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_GEVATs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_ICDepartments");

            entity.HasOne(d => d.FkIclengthGroup).WithMany(p => p.Icproducts).HasConstraintName("ICProducts_FK_ICLengthGroupID");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_ICModels");

            entity.HasOne(d => d.FkIcperimeterGroup).WithMany(p => p.Icproducts).HasConstraintName("ICProducts_FK_ICPerimeterGroupID");

            entity.HasOne(d => d.FkIcpriceCalculationMethod).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_ICPriceCalculationMethods");

            entity.HasOne(d => d.FkIcprodAttPackingMaterialSize).WithMany(p => p.IcproductFkIcprodAttPackingMaterialSizes).HasConstraintName("FK_ICProducts_ICProductAttributes5");

            entity.HasOne(d => d.FkIcprodAttPackingMaterialSpeciality).WithMany(p => p.IcproductFkIcprodAttPackingMaterialSpecialities).HasConstraintName("FK_ICProducts_ICProductAttributes4");

            entity.HasOne(d => d.FkIcprodAttPackingMaterialWeightPerVolume).WithMany(p => p.IcproductFkIcprodAttPackingMaterialWeightPerVolumes).HasConstraintName("FK_ICProducts_ICProductAttributes6");

            entity.HasOne(d => d.FkIcproductAttributeColor).WithMany(p => p.IcproductFkIcproductAttributeColors).HasConstraintName("FK_ICProducts_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeFinishing).WithMany(p => p.IcproductFkIcproductAttributeFinishings).HasConstraintName("FK_ICProducts_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcproductFkIcproductAttributeQualities).HasConstraintName("ICProducts_FK_ICProductAttributeQualityID");

            entity.HasOne(d => d.FkIcproductAttributeSemiProductSpeciality).WithMany(p => p.IcproductFkIcproductAttributeSemiProductSpecialities).HasConstraintName("FK_ICProducts_ICProductAttributes7");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcproductFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICProducts_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductBasicUnit).WithMany(p => p.IcproductFkIcproductBasicUnits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProducts_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductCarcass).WithMany(p => p.InverseFkIcproductCarcass).HasConstraintName("FK_ICProducts_ICProductCarcass");

            entity.HasOne(d => d.FkIcproductFormulaPriceConfig).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_ICProductFormulaPriceConfigs");

            entity.HasOne(d => d.FkIcproductGroupHeight).WithMany(p => p.Icproducts).HasConstraintName("FK_ICProducts_ICProductGroupHeights");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.Icproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProducts_ICProductGroups");

            entity.HasOne(d => d.FkIcproductParent).WithMany(p => p.InverseFkIcproductParent).HasConstraintName("ICProducts_FK_ICProductParentID");

            entity.HasOne(d => d.FkIcproductPurchaseUnit).WithMany(p => p.IcproductFkIcproductPurchaseUnits).HasConstraintName("FK_ICProducts_ICMeasureUnits2");

            entity.HasOne(d => d.FkIcproductSaleUnit).WithMany(p => p.IcproductFkIcproductSaleUnits).HasConstraintName("FK_ICProducts_ICMeasureUnits1");

            entity.HasOne(d => d.FkIcproductThickGroup).WithMany(p => p.IcproductFkIcproductThickGroups).HasConstraintName("FK_ICProducts_ICProductAttributes8");

            entity.HasOne(d => d.FkIcproductTypeAccountConfig).WithMany(p => p.Icproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProducts_FK_ICProductTypeAccountConfigID");

            entity.HasOne(d => d.FkIcwidthGroup).WithMany(p => p.Icproducts).HasConstraintName("ICProducts_FK_ICWidthGroupID");

            entity.HasOne(d => d.FkMmprocess).WithMany(p => p.Icproducts).HasConstraintName("ICProducts_MMProcesss");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.Icproducts).HasConstraintName("ICProducts_MMProductionNormItems");
        });

        modelBuilder.Entity<IcproductAlternative>(entity =>
        {
            entity.HasKey(e => e.IcproductAlternativeId).HasName("PK_MAProductAlternativs");

            entity.HasOne(d => d.FkIcproductAlternativeChild).WithMany(p => p.IcproductAlternativeFkIcproductAlternativeChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductAlternativChild_MAProducts");

            entity.HasOne(d => d.FkIcproductAlternativeParent).WithMany(p => p.IcproductAlternativeFkIcproductAlternativeParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductAlternativParent_MAProducts");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcproductAlternatives).HasConstraintName("FK_MAProductAlternativParent_ICProductAttributeWoodTypeID");
        });

        modelBuilder.Entity<IcproductApplyPrice>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcproductApplyPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductApplyPrices_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcproductApplyPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductApplyPrices_HREmployees");
        });

        modelBuilder.Entity<IcproductApplyPriceItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcproductApplyPriceItems).HasConstraintName("FK_ICProductApplyPriceItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductApplyPrice).WithMany(p => p.IcproductApplyPriceItems).HasConstraintName("FK_ICProductApplyPriceItems_ICProductApplyPrices");

            entity.HasOne(d => d.FkIcproductAttributeColor).WithMany(p => p.IcproductApplyPriceItemFkIcproductAttributeColors).HasConstraintName("FK_ICProductApplyPriceItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcproductApplyPriceItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICProductApplyPriceItems_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductFormulaPriceConfig).WithMany(p => p.IcproductApplyPriceItems).HasConstraintName("FK_ICProductApplyPriceItems_ICProductFormulaPriceConfigs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductApplyPriceItems).HasConstraintName("FK_ICProductApplyPriceItems_ICProducts");
        });

        modelBuilder.Entity<IcproductAttribute>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.IcproductAttributes).HasConstraintName("FK_ICProductAttributes_ARCustomers");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcproductAttributes).HasConstraintName("FK_ICProductAttributes_ICProductGroups");
        });

        modelBuilder.Entity<IcproductAttributeItem>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.IcproductAttributeItems).HasConstraintName("FK_ICProductAttributeItems_ICProductAttributes");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IcproductAttributeItems).HasConstraintName("FK_ICProductAttributeItems_MMOperations");

            entity.HasOne(d => d.FkMmprocess).WithMany(p => p.IcproductAttributeItems).HasConstraintName("ICProductAttributeItems_FK_MMProcessID");
        });

        modelBuilder.Entity<IcproductAttributeWood>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.IcproductAttributeWoods).HasConstraintName("ICProductAttributeWoods_FK_ICProductAttributeID");
        });

        modelBuilder.Entity<IcproductBranch>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcproductBranches).HasConstraintName("FK_ICProductBranchs_BRBranchs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductBranches).HasConstraintName("FK_ICProductBranchs_ICProducts");
        });

        modelBuilder.Entity<IcproductBranchPrice>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcproductBranchPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductBranchPrices_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.IcproductBranchPrices).HasConstraintName("FK_ICProductBranchPrices_GECurrencies");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductBranchPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductBranchPrices_ICProducts");
        });

        modelBuilder.Entity<IcproductColorSchema>(entity =>
        {
            entity.HasKey(e => e.IcproductColorSchemaId).HasName("PK_MAProductColorTables");
        });

        modelBuilder.Entity<IcproductColorSchemaItem>(entity =>
        {
            entity.HasKey(e => e.IcproductColorSchemaItemId).HasName("PK_MAProductColors");

            entity.HasOne(d => d.FkIcproductColorSchema).WithMany(p => p.IcproductColorSchemaItems).HasConstraintName("FK_MAProductColorSchemaItems_MAProductColorSchemas");
        });

        modelBuilder.Entity<IcproductColorSchemaItemName>(entity =>
        {
            entity.HasKey(e => e.IcproductColorSchemaItemNameId).HasName("PK_MAProductColorNames");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.IcproductColorSchemaItemNames).HasConstraintName("FK_MAProductColorSchemaItemNames_GELanguages");

            entity.HasOne(d => d.FkIcproductColorSchemaItem).WithMany(p => p.IcproductColorSchemaItemNames)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MAProductColorSchemaItemNames_MAProductColorSchemaItems");
        });

        modelBuilder.Entity<IcproductComponent>(entity =>
        {
            entity.HasKey(e => e.IcproductComponentId).HasName("PK_MAProductComponent");

            entity.HasOne(d => d.FkIcproductComponentChild).WithMany(p => p.IcproductComponentFkIcproductComponentChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductChild_MAProducts");

            entity.HasOne(d => d.FkIcproductComponentParent).WithMany(p => p.IcproductComponentFkIcproductComponentParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductParent_MAProducts");
        });

        modelBuilder.Entity<IcproductConfigRate>(entity =>
        {
            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcproductConfigRates).HasConstraintName("FK_ICProductConfigRates_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductConfigRates).HasConstraintName("FK_ICProductConfigRates_ICProducts");

            entity.HasOne(d => d.FkStmodule).WithMany(p => p.IcproductConfigRates).HasConstraintName("FK_ICProductConfigRates_STModules");
        });

        modelBuilder.Entity<IcproductContainerDetail>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductContainerDetails).HasConstraintName("FK_ICProductContainerDetails_ICProducts");
        });

        modelBuilder.Entity<IcproductConversion>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcproductConversions).HasConstraintName("FK_ICProductConversions_HREmployees");

            entity.HasOne(d => d.FkIcfromStock).WithMany(p => p.IcproductConversionFkIcfromStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductConversions_ICFromStocks");

            entity.HasOne(d => d.FkIctoStock).WithMany(p => p.IcproductConversionFkIctoStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductConversions_ICToStocks");
        });

        modelBuilder.Entity<IcproductConversionItem>(entity =>
        {
            entity.HasKey(e => e.IcproductConversionItemId).HasName("PK_ICProductConversionItem");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.IcproductConversionItems).HasConstraintName("ICProductConversionItems_ACAccounts");

            entity.HasOne(d => d.FkIcconversionProposal).WithMany(p => p.IcproductConversionItems).HasConstraintName("FK_ICProductConversionItems_ICConversionProposals");

            entity.HasOne(d => d.FkIcconversionProposalItem).WithMany(p => p.IcproductConversionItems).HasConstraintName("FK_ICProductConversionItems_ICConversionProposalItems");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcproductConversionItems).HasConstraintName("FK_ICProductConversionItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductConversion).WithMany(p => p.IcproductConversionItems).HasConstraintName("FK_ICProductConversionItems_ICProductConversions");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductConversionItems).HasConstraintName("FK_ICProductConversionItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcproductConversionItems).HasConstraintName("FK_ICProductConversionItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcproductConversionItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductConversionItems_ICStocks");
        });

        modelBuilder.Entity<IcproductCriteriaItem>(entity =>
        {
            entity.HasOne(d => d.FkIcproductCriteria).WithMany(p => p.IcproductCriteriaItems).HasConstraintName("FK_ICProductCriteriaItems_ICProductCriterias");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductCriteriaItems).HasConstraintName("FK_ICProductCriteriaItems_ICProducts");
        });

        modelBuilder.Entity<IcproductCustomer>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.IcproductCustomers).HasConstraintName("FK_ICProductCustomers_ARCustomers");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductCustomers).HasConstraintName("FK_ICProductCustomers_ICProducts");
        });

        modelBuilder.Entity<IcproductCustomerPrice>(entity =>
        {
            entity.HasKey(e => e.IcproductCustomerPriceId).HasName("PK__ICProduc__9B6C256F161B0F24");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.IcproductCustomerPrices).HasConstraintName("FKq92fyw328qs7cef7vt6o8gpwf");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductCustomerPrices).HasConstraintName("FK61suwt2r8d2pqgs5kt02dkwc8");
        });

        modelBuilder.Entity<IcproductDesc>(entity =>
        {
            entity.HasKey(e => e.IcproductDescId).HasName("PK_MAProductDesc");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.IcproductDescs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductDescs_GELanguages");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductDescs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductDescs_MAProducts");
        });

        modelBuilder.Entity<IcproductDetail>(entity =>
        {
            entity.HasKey(e => e.IcproductDetailId).HasName("PK_MAProductDetail");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductDetailFkIcproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductDetails_ICProducts");

            entity.HasOne(d => d.FkIcproductParent).WithMany(p => p.IcproductDetailFkIcproductParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductDetails_ICProducts1");
        });

        modelBuilder.Entity<IcproductDiscount>(entity =>
        {
            entity.HasKey(e => e.IcproductDiscountId).HasName("PK_MAProductDiscounts");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductDiscounts_MAProducts");
        });

        modelBuilder.Entity<IcproductFile>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductFiles).HasConstraintName("FK_ICProductFiles_ICProducts");
        });

        modelBuilder.Entity<IcproductGroup>(entity =>
        {
            entity.HasKey(e => e.IcproductGroupId).HasName("PK_MAProductGroup");

            entity.HasOne(d => d.FkGevat).WithMany(p => p.IcproductGroups).HasConstraintName("FK_ICProductGroups_GEVATs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcproductGroups).HasConstraintName("FK_ICDepartments_ICProductGroups");

            entity.HasOne(d => d.FkIcproductTypeAccountConfig).WithMany(p => p.IcproductGroups).HasConstraintName("FK_ICProductGroups_ICProductTypeAccountConfigs");
        });

        modelBuilder.Entity<IcproductGroupMeasureUnit>(entity =>
        {
            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcproductGroupMeasureUnits).HasConstraintName("ICProductGroupMeasureUnits_FK_ICProductGroupID");
        });

        modelBuilder.Entity<IcproductGroupRelation>(entity =>
        {
            entity.HasKey(e => e.IcproductGroupRelationId).HasName("PK_MAProductGroupRelation");

            entity.HasOne(d => d.FkIcproductGroupRelationChild).WithMany(p => p.IcproductGroupRelationFkIcproductGroupRelationChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductGroupChild_MAProductGroups");

            entity.HasOne(d => d.FkIcproductGroupRelationParent).WithMany(p => p.IcproductGroupRelationFkIcproductGroupRelationParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductGroupParent_MAProductGroup");
        });

        modelBuilder.Entity<IcproductIdentifiedEquipment>(entity =>
        {
            entity.HasKey(e => e.IcproductIdentifiedEquipmentId).HasName("PK_ICProductIdentifiedEquipmentID");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.IcproductIdentifiedEquipments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICProductIdentifiedEquipments_ACCostCenters");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.IcproductIdentifiedEquipments).HasConstraintName("FK_ICProductIdentifiedEquipments_ACAccounts");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.IcproductIdentifiedEquipments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICProductIdentifiedEquipments_ACSegments");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.IcproductIdentifiedEquipments).HasConstraintName("FK_ICProductIdentifiedEquipments_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.IcproductIdentifiedEquipments).HasConstraintName("FK_ICProductIdentifiedEquipments_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.IcproductIdentifiedEquipments).HasConstraintName("FK_ICProductIdentifiedEquipments_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.IcproductIdentifiedEquipments).HasConstraintName("FK_ICProductIdentifiedEquipments_HREmployeeUserID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductIdentifiedEquipments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductIdentifiedEquipments_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcproductIdentifiedEquipments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductIdentifiedEquipments_ICProductSeries");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.IcproductIdentifiedEquipments).HasConstraintName("FK_ICProductIdentifiedEquipments_MMLineID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.IcproductIdentifiedEquipments).HasConstraintName("FK_ICProductIdentifiedEquipments_MMWorkShopID");
        });

        modelBuilder.Entity<IcproductItem>(entity =>
        {
            entity.HasKey(e => e.IcproductItemId).HasName("PK_MAProductItem");

            entity.HasOne(d => d.FkIcproductCarcass).WithMany(p => p.IcproductItemFkIcproductCarcasses).HasConstraintName("FK_ICProductItems_ICProducts3");

            entity.HasOne(d => d.FkIcproductItemChild).WithMany(p => p.IcproductItemFkIcproductItemChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductChild_ICProducts");

            entity.HasOne(d => d.FkIcproductItemParent).WithMany(p => p.IcproductItemFkIcproductItemParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductParent_ICProducts");
        });

        modelBuilder.Entity<IcproductItemMaterial>(entity =>
        {
            entity.HasOne(d => d.FkIcproductCarcass).WithMany(p => p.IcproductItemMaterialFkIcproductCarcasses).HasConstraintName("FK_ICProductItemMaterials_ICProductCarcasss");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductItemMaterialFkIcproducts).HasConstraintName("FK_ICProductItemMaterials_ICProducts");

            entity.HasOne(d => d.FkIcproductMaterial).WithMany(p => p.IcproductItemMaterialFkIcproductMaterials).HasConstraintName("FK_ICProductItemMaterials_ICProductIngredients");
        });

        modelBuilder.Entity<IcproductItemMaterialLog>(entity =>
        {
            entity.HasKey(e => e.IcproductItemMaterialLogId).HasName("PK_ICProductItemMaterialLogIDs");
        });

        modelBuilder.Entity<IcproductItemProcesss>(entity =>
        {
            entity.HasOne(d => d.FkIcproductCarcass).WithMany(p => p.IcproductItemProcesssFkIcproductCarcasses).HasConstraintName("FK_ICProductItemProcesss_ICProductCarcasss");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductItemProcesssFkIcproducts).HasConstraintName("FK_ICProductItemProcesss_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IcproductItemProcessses).HasConstraintName("ICProductItemProcesss_FK_MMOperationID");

            entity.HasOne(d => d.FkMmprocess).WithMany(p => p.IcproductItemProcessses).HasConstraintName("ICProductItemProcesss_FK_MMProcessID");
        });

        modelBuilder.Entity<IcproductMeasureUnit>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcproductMeasureUnits).HasConstraintName("FK_ICProductMeasureUnits_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductMeasureUnits).HasConstraintName("FK_ICProductMeasureUnits_ICProducts");
        });

        modelBuilder.Entity<IcproductOperation>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductOperations).HasConstraintName("FK_ICProductOperations_ICProducts");
        });

        modelBuilder.Entity<IcproductOutsourcing>(entity =>
        {
            entity.HasKey(e => e.IcproductOutsourcingId).HasName("PK_MAProductOutsourcings");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcproductOutsourcings).HasConstraintName("FK_MAProductOutsourcings_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductOutsourcingChild).WithMany(p => p.IcproductOutsourcingFkIcproductOutsourcingChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductOutsourcingChild_MAProducts");

            entity.HasOne(d => d.FkIcproductOutsourcingParent).WithMany(p => p.IcproductOutsourcingFkIcproductOutsourcingParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductOutsourcingParent_MAProducts");
        });

        modelBuilder.Entity<IcproductPackage>(entity =>
        {
            entity.HasKey(e => e.IcproductPackageId).HasName("PK_MAProductPackage");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductPackages).HasConstraintName("FK_ICProductPackages_ICProducts");
        });

        modelBuilder.Entity<IcproductPackageBackup>(entity =>
        {
            entity.Property(e => e.IcproductPackageId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<IcproductPackageItem>(entity =>
        {
            entity.HasKey(e => e.IcproductPackageItemId).HasName("PK_MAProductPackageItem");

            entity.HasOne(d => d.FkIcproductPackage).WithMany(p => p.IcproductPackageItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductPackageItems_ICProductPackages");
        });

        modelBuilder.Entity<IcproductPackageItemBackup>(entity =>
        {
            entity.Property(e => e.IcproductPackageItemId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<IcproductPackageItemDetail>(entity =>
        {
            entity.HasKey(e => e.IcproductPackageItemDetailId).HasName("PK_MAProductPackageItemDetail");

            entity.HasOne(d => d.FkIcproductDetail).WithMany(p => p.IcproductPackageItemDetails).HasConstraintName("FK_ICProductPackageItemDetails_ICProductDetails");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductPackageItemDetails).HasConstraintName("FK_ICProductPackageItemDetails_ICProducts");

            entity.HasOne(d => d.FkIcproductPackageItem).WithMany(p => p.IcproductPackageItemDetails).HasConstraintName("FK_ICProductPackageItemDetails_ICProductPackageItems");
        });

        modelBuilder.Entity<IcproductPackingDetail>(entity =>
        {
            entity.HasOne(d => d.FkIcprodAttPackingMaterialWeightPerVolume).WithMany(p => p.IcproductPackingDetailFkIcprodAttPackingMaterialWeightPerVolumes).HasConstraintName("FK_ICProductPackingDetails_FK_ICProdAttPackingMaterialWeightPerVolumeID");

            entity.HasOne(d => d.FkIcproductAttributeSpeciality).WithMany(p => p.IcproductPackingDetailFkIcproductAttributeSpecialities).HasConstraintName("FK_ICProductPackingDetails_ICProductAttPackingMaterialSpeciality");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductPackingDetails).HasConstraintName("ICProductPackingDetails_FK_ICProductID");
        });

        modelBuilder.Entity<IcproductPrice>(entity =>
        {
            entity.HasKey(e => e.IcproductPriceId).HasName("PK_MAProductPrice");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.IcproductPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductPrices_MAPrices");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductPrices_MAProducts");
        });

        modelBuilder.Entity<IcproductProductAttribute>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.IcproductProductAttributes).HasConstraintName("FK_ICProductProductAttributes_ICProductAttributes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductProductAttributes).HasConstraintName("FK_ICProductProductAttributes_ICProducts");
        });

        modelBuilder.Entity<IcproductProfile>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductProfiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductProfiles_ICProducts");
        });

        modelBuilder.Entity<IcproductSerialNumber>(entity =>
        {
            entity.HasKey(e => e.IcproductSerialNumberId).HasName("PK_ICProductSerialNumberID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductSerialNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductSerialNumbers_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcproductSerialNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductSerialNumbers_ICProductSeries");
        });

        modelBuilder.Entity<IcproductSeries>(entity =>
        {
            entity.HasKey(e => e.IcproductSerieId).HasName("PK_MAProductSeries");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.IcproductSeries).HasConstraintName("FK_ICProductSeries_GECountrys");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.IcproductSeries).HasConstraintName("FK_ICProductSeries_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.IcproductSeries).HasConstraintName("FK_ICProductSeries_ICModels");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcproductSeriesFkIcproductAttributeQualities).HasConstraintName("FK_ICProductSeries_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcproductSeriesFkIcproductAttributeTtmts).HasConstraintName("FK_ICProductSeries_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcproductSeriesFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICProductSeries_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.IcproductSeriesFkIcproductForBatches).HasConstraintName("FK_ICProductSeries_ICProducts1");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductSeriesFkIcproducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductSeries_MAProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcproductSeries).HasConstraintName("FK_ICProductSeries_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IcproductSeries).HasConstraintName("FK_ICProductSeries_MMOperations");
        });

        modelBuilder.Entity<IcproductSizeSchema>(entity =>
        {
            entity.HasKey(e => e.IcproductSizeSchemaId).HasName("PK_MAProductSizeTables");
        });

        modelBuilder.Entity<IcproductSizeSchemaItem>(entity =>
        {
            entity.HasKey(e => e.IcproductSizeSchemaItemId).HasName("PK_MAProductSizes");

            entity.HasOne(d => d.IcproductSizeSchema).WithMany(p => p.IcproductSizeSchemaItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MAProductSizeSchemaItems_MAProductSizeSchemas");
        });

        modelBuilder.Entity<IcproductSizeSchemaItemName>(entity =>
        {
            entity.HasKey(e => e.IcproductSizeSchemaItemNameId).HasName("PK_MAProductSizeNames");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.IcproductSizeSchemaItemNames).HasConstraintName("FK_MAProductSizeSchemaItemNames_GELanguages");

            entity.HasOne(d => d.FkIcproductSizeSchemaItem).WithMany(p => p.IcproductSizeSchemaItemNames)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MAProductSizeSchemaItemNames_MAProductSizeSchemaItems");
        });

        modelBuilder.Entity<IcproductSub>(entity =>
        {
            entity.HasKey(e => e.IcproductSubId).HasName("PK_MAProductSubs");

            entity.HasOne(d => d.FkIcproductSubChild).WithMany(p => p.IcproductSubFkIcproductSubChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductSubs_MAProducts");

            entity.HasOne(d => d.FkIcproductSubParent).WithMany(p => p.IcproductSubFkIcproductSubParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductSubs_MAProducts1");
        });

        modelBuilder.Entity<IcproductSubplement>(entity =>
        {
            entity.HasKey(e => e.IcproductSubplementId).HasName("PK_MAProductSubplements");

            entity.HasOne(d => d.FkIcproductSubplementChild).WithMany(p => p.IcproductSubplementFkIcproductSubplementChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductSubplementChild_MAProducts");

            entity.HasOne(d => d.FkIcproductSubplementParent).WithMany(p => p.IcproductSubplementFkIcproductSubplementParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductSubplementParent_MAProducts");
        });

        modelBuilder.Entity<IcproductSupplier>(entity =>
        {
            entity.HasKey(e => e.IcproductSupplierId).HasName("PK_MAProductSuppliers");

            entity.Property(e => e.IcproductSupplierNumber).HasComment("Bestell-Nr , ASrtikelnummer des Lieferant");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.IcproductSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductSuppliers_MASuppliers");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAProductSuppliers_MAProducts");
        });

        modelBuilder.Entity<IcproductTask>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.IcproductTasks).HasConstraintName("FK_ICProductTasks_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.IcproductTasks).HasConstraintName("FK_ICProductTasks_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcproductTasks).HasConstraintName("FK_ICProductTasks_HREmployees");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcproductTasks).HasConstraintName("FK_ICProductTasks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductTaskFkIcproducts).HasConstraintName("FK_ICProductTasks_ICProducts");

            entity.HasOne(d => d.FkIcproductParent).WithMany(p => p.IcproductTaskFkIcproductParents).HasConstraintName("FK_ICProductParents_ICProducts");

            entity.HasOne(d => d.FkIctask).WithMany(p => p.IcproductTasks).HasConstraintName("FK_ICProductTasks_ICTasks");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.IcproductTasks).HasConstraintName("FK_ICProductTasks_PMProjectTypes");
        });

        modelBuilder.Entity<IcproductTemplate>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductTemplates_ICProducts");
        });

        modelBuilder.Entity<IcproductTemplateItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcproductTemplateItems).HasConstraintName("FK_ICProductTemplateItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductFormulaPriceConfig).WithMany(p => p.IcproductTemplateItems).HasConstraintName("FK_ICProductTemplateItems_ICProductFormulaPriceConfigs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductTemplateItems).HasConstraintName("FK_ICProductTemplateItems_ICProducts");

            entity.HasOne(d => d.FkIcproductTemplate).WithMany(p => p.IcproductTemplateItems).HasConstraintName("FK_ICProductTemplateItems_ICProductTemplates");
        });

        modelBuilder.Entity<IcproductTolenrance>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductTolenrances).HasConstraintName("FK_ICProductTolenrances_ICProducts");
        });

        modelBuilder.Entity<IcproductTypeAccountConfig>(entity =>
        {
            entity.HasOne(d => d.FkAcaccountCostPrice).WithMany(p => p.IcproductTypeAccountConfigFkAcaccountCostPrices).HasConstraintName("FK_ICProductTypeAccountConfigs_FK_ACAccountCostPriceID");

            entity.HasOne(d => d.FkAcaccountDiscount).WithMany(p => p.IcproductTypeAccountConfigFkAcaccountDiscounts).HasConstraintName("FK_ICProductTypeAccountConfigs_FK_ACAccountDiscountID");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.IcproductTypeAccountConfigFkAcaccounts).HasConstraintName("FK_ICProductTypeAccountConfigs_FK_ACAccountID");

            entity.HasOne(d => d.FkAcaccountRevenueHinterLand).WithMany(p => p.IcproductTypeAccountConfigFkAcaccountRevenueHinterLands).HasConstraintName("FK_ICProductTypeAccountConfigs_ACAccountRevenueHinterLandID");

            entity.HasOne(d => d.FkAcaccountRevenue).WithMany(p => p.IcproductTypeAccountConfigFkAcaccountRevenues).HasConstraintName("FK_ICProductTypeAccountConfigs_FK_ACAccountRevenueID");

            entity.HasOne(d => d.FkAcaccountRevenueInternal).WithMany(p => p.IcproductTypeAccountConfigFkAcaccountRevenueInternals).HasConstraintName("FK_ICProductTypeAccountConfigs_FK_ACAccountRevenueInternalID");

            entity.HasOne(d => d.FkAcaccountSaleReturn).WithMany(p => p.IcproductTypeAccountConfigFkAcaccountSaleReturns).HasConstraintName("FK_ICProductTypeAccountConfigs_FK_ACAccountSaleReturnID");
        });

        modelBuilder.Entity<IcproductUnit>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcproductUnits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductUnits_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductUnits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductUnits_ICProducts");
        });

        modelBuilder.Entity<IcproductWorkGroup>(entity =>
        {
            entity.HasKey(e => e.IcproductWorkGroupId).HasName("PK__ICProduc__70D6B2962FC95530");

            entity.HasOne(d => d.FkPmphaseType).WithMany(p => p.IcproductWorkGroups).HasConstraintName("FK_ICProductWorkGroups_PMPhaseTypes");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.IcproductWorkGroups).HasConstraintName("FK_ICProductWorkGroups_PMProjectTypes");
        });

        modelBuilder.Entity<IcproductWorkItem>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcproductWorkItemFkIcproducts).HasConstraintName("FK_ICProductWorkItems_ICProducts");

            entity.HasOne(d => d.FkIcproductWorkItemChild).WithMany(p => p.IcproductWorkItemFkIcproductWorkItemChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductWorkItemChilds_ICProducts");

            entity.HasOne(d => d.FkIcproductWorkItemParent).WithMany(p => p.IcproductWorkItemFkIcproductWorkItemParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductWorkItemParents_ICProducts");
        });

        modelBuilder.Entity<Icpromotion>(entity =>
        {
            entity.Property(e => e.IcpromotionActiveCheck).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<IcpromotionItem>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcpromotionItems).HasConstraintName("FK_ICPromotionItems_ICDepartments");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcpromotionItems).HasConstraintName("FK_ICPromotionItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcpromotionItems).HasConstraintName("FK_ICPromotionItems_ICProducts");

            entity.HasOne(d => d.FkIcpromotion).WithMany(p => p.IcpromotionItems).HasConstraintName("FK_ICPromotionItems_ICPromotions");
        });

        modelBuilder.Entity<IcpromotionItemDetail>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcpromotionItemDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICPromotionItemDetails_ICProducts");

            entity.HasOne(d => d.FkIcpromotionItem).WithMany(p => p.IcpromotionItemDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICPromotionItemDetails_ICPromotionItems");
        });

        modelBuilder.Entity<Icreceipt>(entity =>
        {
            entity.HasKey(e => e.IcreceiptId).HasName("PK_FAReceipts");

            entity.Property(e => e.IcreceiptActiveCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_ACCostCenters");

            entity.HasOne(d => d.FkAceinvoiceType).WithMany(p => p.Icreceipts).HasConstraintName("FK__ICReceipt__FK_AC__7C1FC5C2");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_ACSegments");

            entity.HasOne(d => d.FkAppurchaseContract).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_APPurchaseContracts");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_APPurchaseOrders");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_APSuppliers");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_ARCustomers");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_ARSaleContracts");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_BRBranchs");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_GECountrys");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Icreceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceipts_GECurrencies");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_GEShippingMethods");

            entity.HasOne(d => d.FkGeterminal).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_GETerminals");

            entity.HasOne(d => d.FkHrdeliveryEmployee).WithMany(p => p.IcreceiptFkHrdeliveryEmployees).HasConstraintName("FK_ICReceipts_HREmployees2");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Icreceipts).HasConstraintName("ICReceipts_FK_HRDepartmentID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.Icreceipts).HasConstraintName("ICReceipts_FK_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Icreceipts).HasConstraintName("ICReceipts_FK_HRDepartmentRoomID");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcreceiptFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceipts_HREmployees");

            entity.HasOne(d => d.FkIcimportAndExportReason).WithMany(p => p.Icreceipts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Receipts_ICImportAndExportReasons");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcreceiptFkIcproductAttributeQualities).HasConstraintName("FK_ICReceipts_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcreceiptFkIcproductAttributeTtmts).HasConstraintName("FK_ICReceipts_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcreceiptFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICReceipts_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcreceiptFkIcproducts).HasConstraintName("FK_ICReceipts_ICProducts");

            entity.HasOne(d => d.FkIcproductTransfer).WithMany(p => p.IcreceiptFkIcproductTransfers).HasConstraintName("FK_ICReceipts_ICProductTransfers");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcreceiptFkMmbatchProducts).HasConstraintName("FK_ICReceipts_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductTransfer).WithMany(p => p.IcreceiptFkMmbatchProductTransfers).HasConstraintName("FK_ICReceipts_MMBatchProductTransfers");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_MMOperations");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Icreceipts).HasConstraintName("FK_ICReceipts_PMProjects");

            entity.HasOne(d => d.IcreceiptProposedEmployee).WithMany(p => p.IcreceiptIcreceiptProposedEmployees).HasConstraintName("FK_ICReceipts_ICReceiptProposedEmployeeID");
        });

        modelBuilder.Entity<IcreceiptCd>(entity =>
        {
            entity.HasKey(e => e.IcreceiptCdid).HasName("PK_FAReceiptCDs");

            entity.Property(e => e.IcreceiptCdactiveCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_ACSegments");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_APPurchaseOrders");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.IcreceiptCds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptCDs_APSuppliers");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_BRBranchs");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_GECountrys");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.IcreceiptCds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptCDs_GECurrencies");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_GEShippingMethods");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcreceiptCds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptCDs_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcreceiptCdFkIcproductAttributeQualities).HasConstraintName("FK_ICReceiptCDs_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcreceiptCdFkIcproductAttributeTtmts).HasConstraintName("FK_ICReceiptCDs_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcreceiptCdFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICReceiptCDs_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcreceiptCds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptCDs_ICStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_ICStockSlots");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_MMBatchProductItems");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IcreceiptCds).HasConstraintName("FK_ICReceiptCDs_MMOperations");
        });

        modelBuilder.Entity<IcreceiptCditem>(entity =>
        {
            entity.HasKey(e => e.IcreceiptCditemId).HasName("PK_FAReceiptCDItems");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ACAccounts");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItemes_APPurchaseOrders");

            entity.HasOne(d => d.FkAppurchaseOrderItem).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItemes_APPurchaseOrderItems");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_GECountrys");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_HRDepartmentRoomGroupID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_HREmployeeUserID");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ICModels");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcreceiptCditemFkIcproductAttributeQualities).HasConstraintName("FK_ICReceiptCDItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcreceiptCditemFkIcproductAttributeTtmts).HasConstraintName("FK_ICReceiptCDItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcreceiptCditemFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICReceiptCDItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.IcreceiptCditemFkIcproductForBatches).HasConstraintName("FK_ICReceiptCDItems_ICProducts2");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcreceiptCditemFkIcproducts).HasConstraintName("FK_FAReceiptCDItems_MAProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ICProductSeries");

            entity.HasOne(d => d.FkIcreceiptCd).WithMany(p => p.IcreceiptCditems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FAReceiptCDItems_FAReceiptCDs");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ICShipments");

            entity.HasOne(d => d.FkIcshipmentItem).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_ICShipmentItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_FAReceiptCDItems_MAStocks");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_FAReceiptCDItems_MAStockSlots");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_MMAllocationProposals");

            entity.HasOne(d => d.FkMmallocationProposalItem).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_MMAllocationProposalItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_MMLineID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.IcreceiptCditems).HasConstraintName("FK_ICReceiptCDItems_MMWorkShopID");
        });

        modelBuilder.Entity<IcreceiptComponentItem>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcreceiptComponentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptComponentItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcreceiptComponentItems).HasConstraintName("FK_ICReceiptComponentItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcreceiptComponentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptComponentItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcreceiptComponentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptComponentItems_ICProducts");

            entity.HasOne(d => d.FkIcreceiptItem).WithMany(p => p.IcreceiptComponentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptComponentItems_ICReceiptItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcreceiptComponentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptComponentItems_ICStocks");
        });

        modelBuilder.Entity<IcreceiptItem>(entity =>
        {
            entity.HasKey(e => e.IcreceiptItemId).HasName("PK_FAReceiptItems");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.IcreceiptItemFkAcaccounts).HasConstraintName("FK_ICReceiptItems_ACAccounts");

            entity.HasOne(d => d.FkAcasset).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ACAssets");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.IcreceiptItems).HasConstraintName("ICReceiptItems_ACCostObjects");

            entity.HasOne(d => d.FkAcoffsetAccount).WithMany(p => p.IcreceiptItemFkAcoffsetAccounts).HasConstraintName("ICReceiptItems_ACOffsetAccounts");

            entity.HasOne(d => d.FkActransitInAccount).WithMany(p => p.IcreceiptItemFkActransitInAccounts).HasConstraintName("ICReceiptItems_ACTransitInAccounts");

            entity.HasOne(d => d.FkApbillOfLading).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_APBillOfLadings");

            entity.HasOne(d => d.FkApbillOfLadingItem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_APBillOfLadingItems");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItemes_APPurchaseOrders");

            entity.HasOne(d => d.FkAppurchaseOrderItem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItemes_APPurchaseOrderItems");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ARSaleOrders");

            entity.HasOne(d => d.FkGecontainer).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_GEContainers");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_GECountrys");

            entity.HasOne(d => d.FkGeterminal).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_GETerminals");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_HRDepartmentRoomGroupID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_HREmployeeUserID");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICDepartments");

            entity.HasOne(d => d.FkIcimportAndExportReason).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICImportAndExportReasons");

            entity.HasOne(d => d.FkIclengthGroup).WithMany(p => p.IcreceiptItems).HasConstraintName("ICReceiptItems_FK_ICLengthGroupID");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICModels");

            entity.HasOne(d => d.FkIcperimeterGroup).WithMany(p => p.IcreceiptItems).HasConstraintName("ICReceiptItems_FK_ICPerimeterGroupID");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcreceiptItemFkIcproductAttributeQualities).HasConstraintName("FK_ICReceiptItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcreceiptItemFkIcproductAttributeTtmts).HasConstraintName("FK_ICReceiptItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcreceiptItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICReceiptItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductEquipment).WithMany(p => p.IcreceiptItemFkIcproductEquipments).HasConstraintName("ICReceiptItems_ICProductEquipments");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.IcreceiptItemFkIcproductForBatches).HasConstraintName("FK_ICReceiptItems_ICProducts2");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcreceiptItemFkIcproducts).HasConstraintName("FK_FAReceiptItems_MAProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICProductSeries");

            entity.HasOne(d => d.FkIcreceiptCd).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItem_ReceiptCDs");

            entity.HasOne(d => d.FkIcreceiptCditem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItem_ReceiptCDItem");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.IcreceiptItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FAReceiptItems_FAReceipts");

            entity.HasOne(d => d.FkIcreplaceProduct).WithMany(p => p.IcreceiptItemFkIcreplaceProducts).HasConstraintName("FK_ICReceiptItems_ICReplaceProducts");

            entity.HasOne(d => d.FkIcsectionProduct).WithMany(p => p.IcreceiptItemFkIcsectionProducts).HasConstraintName("FK_ICReceiptItems_ICSectionProducts");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICShipments");

            entity.HasOne(d => d.FkIcshipmentItem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_ICShipmentItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_FAReceiptItems_MAStocks");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMAllocationProposals");

            entity.HasOne(d => d.FkMmallocationProposalItem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMAllocationProposalItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMLineID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMOperations");

            entity.HasOne(d => d.FkMmupdatePositionItem).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMUpdatePositionItems");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_MMWorkShopID");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.IcreceiptItems).HasConstraintName("FK_ICReceiptItems_PMProjects");
        });

        modelBuilder.Entity<IcreceiptItemCont>(entity =>
        {
            entity.HasOne(d => d.FkGecontainer).WithMany(p => p.IcreceiptItemConts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICReceiptItemConts_GEContainers");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.IcreceiptItemConts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICReceiptItemConts_ICReceipts");
        });

        modelBuilder.Entity<IcreceiptItemContFee>(entity =>
        {
            entity.HasOne(d => d.FkGecontainer).WithMany(p => p.IcreceiptItemContFees)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICReceiptItemContFees_GEContainers");

            entity.HasOne(d => d.FkGeunitCost).WithMany(p => p.IcreceiptItemContFees)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICReceiptItemContFees_GEUnitCosts");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.IcreceiptItemContFees)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICReceiptItemContFees_ICReceipts");
        });

        modelBuilder.Entity<IcreceiptItemLog>(entity =>
        {
            entity.HasOne(d => d.FkGeobjectHistory).WithMany(p => p.IcreceiptItemLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptItemLogs_GEObjectHistory");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.IcreceiptItemLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptItemLogs_ICReceipts");

            entity.HasOne(d => d.FkIcreceiptItem).WithMany(p => p.IcreceiptItemLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptItemLogs_ICReceiptItems");
        });

        modelBuilder.Entity<IcreceiptItemPackage>(entity =>
        {
            entity.HasOne(d => d.FkIcreceiptComponentItem).WithMany(p => p.IcreceiptItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReceiptItemPackages_ICReceiptComponentItems");
        });

        modelBuilder.Entity<IcreceiptPackageItem>(entity =>
        {
            entity.HasKey(e => e.IcreceiptPackageItemId).HasName("PK_MAReceiptPackageItem");

            entity.HasOne(d => d.FkApinvoiceInPackageItem).WithMany(p => p.IcreceiptPackageItems).HasConstraintName("FK_ICReceiptPackageItems_APInvoiceInPackageItems");

            entity.HasOne(d => d.FkAppopackageItem).WithMany(p => p.IcreceiptPackageItems).HasConstraintName("FK_ICReceiptPackageItems_APPOPackageItems");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcreceiptPackageItems).HasConstraintName("FK_ICReceiptPackageItems_ICProducts");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.IcreceiptPackageItems).HasConstraintName("FK_ICReceiptPackageItems_ICReceipts");
        });

        modelBuilder.Entity<IcreceiptPackageItemDetail>(entity =>
        {
            entity.HasKey(e => e.IcreceiptPackageItemDetailId).HasName("PK_MAReceiptPackageItemDetail");

            entity.HasOne(d => d.FkApinvoiceInPackageItem).WithMany(p => p.IcreceiptPackageItemDetails).HasConstraintName("FK_ICReceiptPackageItemDetails_APInvoiceInPackageItems");

            entity.HasOne(d => d.FkAppopackageItem).WithMany(p => p.IcreceiptPackageItemDetails).HasConstraintName("FK_ICReceiptPackageItemDetails_APPOPackageItems");

            entity.HasOne(d => d.FkIcproductDetail).WithMany(p => p.IcreceiptPackageItemDetails).HasConstraintName("FK_ICReceiptPackageItemDetails_ICProductDetails");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcreceiptPackageItemDetails).HasConstraintName("FK_ICReceiptPackageItemDetails_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcreceiptPackageItemDetails).HasConstraintName("FK_ICReceiptPackageItemDetails_ICProductSeries");

            entity.HasOne(d => d.FkIcreceiptPackageItem).WithMany(p => p.IcreceiptPackageItemDetails).HasConstraintName("FK_ICReceiptPackageItemDetails_ICReceiptPackageItems");
        });

        modelBuilder.Entity<IcreturnShipping>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcreturnShippings).HasConstraintName("FK_ICReturnShippings_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcreturnShippings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReturnShippings_HREmployees");

            entity.HasOne(d => d.FkIcshipmentSaleOrder).WithMany(p => p.IcreturnShippings).HasConstraintName("FK_ICReturnShippings_ICShipmentSaleOrders");
        });

        modelBuilder.Entity<IcreturnShippingItem>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcreturnShippingItems).HasConstraintName("FK_ICReturnShippingItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcreturnShippingItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReturnShippingItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcreturnShippingItems).HasConstraintName("FK_ICReturnShippingItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcreturnShippingItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReturnShippingItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcreturnShippingItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReturnShippingItems_ICProductSeries");

            entity.HasOne(d => d.FkIcreturnShipping).WithMany(p => p.IcreturnShippingItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReturnShippingItems_ICReturnShippings");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.IcreturnShippingItems).HasConstraintName("FK_ICReturnShippingItems_ICShipments");

            entity.HasOne(d => d.FkIcshipmentItem).WithMany(p => p.IcreturnShippingItems).HasConstraintName("FK_ICReturnShippingItems_ICShipmentItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcreturnShippingItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICReturnShippingItems_ICStocks");
        });

        modelBuilder.Entity<Icshipment>(entity =>
        {
            entity.HasKey(e => e.IcshipmentId).HasName("PK_FAShipments");

            entity.Property(e => e.IcshipmentActiveCheck).HasDefaultValueSql("((1))");
            entity.Property(e => e.IcshipmentDeliveryContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.IcshipmentDeliveryContactHeaderMessage).HasComment("Anrede fuer Briefe");
            entity.Property(e => e.IcshipmentInvoiceContactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.IcshipmentInvoiceContactHeaderMessage).HasComment("Anrede fuer Briefe");
            entity.Property(e => e.IcshipmentSocontactHeaderLetter).HasComment("fuer Umschlag: zB. Z.Hand Herrn Meyer");
            entity.Property(e => e.IcshipmentSocontactHeaderMessage).HasComment("Anrede fuer Briefe");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_ACCostCenters");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_ACSegments");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.Icshipments).HasConstraintName("FK_FAShipments_APPurchaseOrders");

            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_APSuppliers");

            entity.HasOne(d => d.FkArassociatedSeller).WithMany(p => p.IcshipmentFkArassociatedSellers).HasConstraintName("FK_ICShipments_HREmployees1");

            entity.HasOne(d => d.FkArinvoiceRequest).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_ARInvoiceRequests");

            entity.HasOne(d => d.FkArpriceLevel).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_ARPriceLevels");

            entity.HasOne(d => d.FkArsaleContract).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_ARSaleContracts");

            entity.HasOne(d => d.FkArseller).WithMany(p => p.IcshipmentFkArsellers).HasConstraintName("FK_FAShipments_MASellers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_BRBranchs");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_GECountrys");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Icshipments).HasConstraintName("FK_FAShipments_GECurrencies");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.Icshipments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAShipments_GELanguages");

            entity.HasOne(d => d.FkGeshippingMethod).WithMany(p => p.Icshipments).HasConstraintName("FK_FAShipments_MAShippingMethods");

            entity.HasOne(d => d.FkGevatregion).WithMany(p => p.Icshipments).HasConstraintName("FK_FAShipments_GEVATRegions");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Icshipments).HasConstraintName("FK_Shipments_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcshipmentFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipments_HREmployees");

            entity.HasOne(d => d.FkHremployeeRecever).WithMany(p => p.IcshipmentFkHremployeeRecevers).HasConstraintName("FK_ICShipments_HREmployees2");

            entity.HasOne(d => d.FkIcimportAndExportReason).WithMany(p => p.Icshipments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipments_ICImportAndExportReasons");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcshipmentFkIcproductAttributeQualities).HasConstraintName("FK_ICShipments_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcshipmentFkIcproductAttributeTtmts).HasConstraintName("FK_ICShipments_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcshipmentFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICShipments_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcshipmentFkIcproducts).HasConstraintName("FK_ICShipments_ICProducts");

            entity.HasOne(d => d.FkIcproductTransfer).WithMany(p => p.IcshipmentFkIcproductTransfers).HasConstraintName("FK_ICShipments_ICProductTransfers");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Icshipments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipments_ICStocks");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_MMAllocationPlans");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_MMAllocationProposals");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcshipmentFkMmbatchProducts).HasConstraintName("FK_ICShipments_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductTransfer).WithMany(p => p.IcshipmentFkMmbatchProductTransfers).HasConstraintName("FK_ICShipments_MMBatchProductTransfers");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_MMWorkShops");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_PMProjects");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.Icshipments).HasConstraintName("FK_ICShipments_PMTemplates");
        });

        modelBuilder.Entity<IcshipmentItem>(entity =>
        {
            entity.HasKey(e => e.IcshipmentItemId).HasName("PK_FAShipmentItems");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.IcshipmentItemFkAcaccounts).HasConstraintName("FK_ICShipmentItems_ACAccounts");

            entity.HasOne(d => d.FkAcasset).WithMany(p => p.IcshipmentItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICShipmentItems_ACAssets");

            entity.HasOne(d => d.FkAccostCenter).WithMany(p => p.IcshipmentItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICShipmentItems_ACCostCenters");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.IcshipmentItems).HasConstraintName("ICShipmentItems_ACCostObjects");

            entity.HasOne(d => d.FkAcdepreciationCostAccount).WithMany(p => p.IcshipmentItemFkAcdepreciationCostAccounts).HasConstraintName("FK_ICShipmentItems_ICShipmentItems");

            entity.HasOne(d => d.FkAcoffsetAccount).WithMany(p => p.IcshipmentItemFkAcoffsetAccounts).HasConstraintName("ICShipmentItems_ACOffsetAccounts");

            entity.HasOne(d => d.FkAcsegment).WithMany(p => p.IcshipmentItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ICShipmentItems_ACSegments");

            entity.HasOne(d => d.FkActransitInAccount).WithMany(p => p.IcshipmentItemFkActransitInAccounts).HasConstraintName("ICShipmentItems_ACTransitInAccounts");

            entity.HasOne(d => d.FkAcunfinishedConstructionCost).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ACUnfinishedConstructionCosts");

            entity.HasOne(d => d.FkArdeliveryPlan).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ARDeliveryPlans");

            entity.HasOne(d => d.FkArdeliveryPlanItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ARDeliveryPlanItems");

            entity.HasOne(d => d.FkArdeliveryPlanWork).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ARDeliveryPlanWorks");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_GECountrys");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoomGroup).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_HRDepartmentRoomGroupID");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployeeUser).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_HREmployeeUserID");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICDepartments");

            entity.HasOne(d => d.FkIcimportAndExportReason).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICImportAndExportReasons");

            entity.HasOne(d => d.FkIclengthGroup).WithMany(p => p.IcshipmentItems).HasConstraintName("ICShipmentItems_ICLengthGroups");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICModels");

            entity.HasOne(d => d.FkIcperimeterGroup).WithMany(p => p.IcshipmentItems).HasConstraintName("ICShipmentItems_ICPerimeterGroups");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcshipmentItemFkIcproductAttributeQualities).HasConstraintName("FK_ICShipmentItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcshipmentItemFkIcproductAttributeTtmts).HasConstraintName("FK_ICShipmentItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IcshipmentItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICShipmentItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductEquipment).WithMany(p => p.IcshipmentItemFkIcproductEquipments).HasConstraintName("ICShipmentItems_ICProductEquipments");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.IcshipmentItemFkIcproductForBatches).HasConstraintName("FK_ICShipmentItems_ICProducts2");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcshipmentItemFkIcproducts).HasConstraintName("FK_FAShipmentItems_MAProducts");

            entity.HasOne(d => d.FkIcproductIdentifiedEquipment).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICProductIdentifiedEquipments");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICProductSeries");

            entity.HasOne(d => d.FkIcreceipt).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICReceipts");

            entity.HasOne(d => d.FkIcreceiptItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICReceiptItems");

            entity.HasOne(d => d.FkIcsectionProduct).WithMany(p => p.IcshipmentItemFkIcsectionProducts).HasConstraintName("FK_ICShipmentItems_ICProducts");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.IcshipmentItems)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FAShipmentItems_FAShipments");

            entity.HasOne(d => d.FkIcshipmentProposal).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICShipmentProposals");

            entity.HasOne(d => d.FkIcshipmentProposalItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_ICShipmentProposalItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_FAShipmentItems_FAShipmentItems");

            entity.HasOne(d => d.FkIcstockSlot).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_FAShipmentItems_MAStockSlots");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_MMAllocationProposals");

            entity.HasOne(d => d.FkMmallocationProposalItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_MMAllocationProposalItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_MMLineID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_MMOperations");

            entity.HasOne(d => d.FkMmupdatePositionItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_MMUpdatePositionItems");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_MMWorkShopID");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_PMProjects");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.IcshipmentItems).HasConstraintName("FK_ICShipmentItems_PMTemplateItems");
        });

        modelBuilder.Entity<IcshipmentItemComponent>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcshipmentItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipmentItemComponents_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcshipmentItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipmentItemComponents_ICProductSeries");

            entity.HasOne(d => d.FkIcshipmentItem).WithMany(p => p.IcshipmentItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipmentItemComponents_ICShipmentItems");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcshipmentItemComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipmentItemComponents_ICStocks");
        });

        modelBuilder.Entity<IcshipmentItemSaleOrderItem>(entity =>
        {
            entity.HasKey(e => e.IcshipmentItemSaleOrderItemId).HasName("PK_FASellOrderShipmentDetails");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.IcshipmentItemSaleOrderItems).HasConstraintName("FK_FASellOrderShipmentItems_FASellOrderItems");

            entity.HasOne(d => d.FkIcshipmentItem).WithMany(p => p.IcshipmentItemSaleOrderItems).HasConstraintName("FK_FASellOrderItemShipmentItems_FAShipmentItems");
        });

        modelBuilder.Entity<IcshipmentPackage>(entity =>
        {
            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.IcshipmentPackages).HasConstraintName("FK_ICShipmentPackages_ICShipments");
        });

        modelBuilder.Entity<IcshipmentPackageItem>(entity =>
        {
            entity.HasKey(e => e.IcshipmentPackageItemId).HasName("PK_MAShipmentPackageItem");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.IcshipmentPackageItems).HasConstraintName("FK_ICShipmentPackageItems_ICShipments");
        });

        modelBuilder.Entity<IcshipmentPackageItemDetail>(entity =>
        {
            entity.HasKey(e => e.IcshipmentPackageItemDetailId).HasName("PK_MAShipmentPackageItemDetail");

            entity.HasOne(d => d.FkIcproductDetail).WithMany(p => p.IcshipmentPackageItemDetails).HasConstraintName("FK_ICShipmentPackageItemDetails_ICProductDetails");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcshipmentPackageItemDetails).HasConstraintName("FK_ICShipmentPackageItemDetails_ICProducts");

            entity.HasOne(d => d.FkIcshipmentPackageItem).WithMany(p => p.IcshipmentPackageItemDetails).HasConstraintName("FK_ICShipmentPackageItemDetails_ICShipmentPackageItems");
        });

        modelBuilder.Entity<IcshipmentPlan>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcshipmentPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipmentPlans_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.IcshipmentPlanFkHremployeeApproveds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipmentPlans_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcshipmentPlanFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICShipmentPlans_HREmployees");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcshipmentPlans).HasConstraintName("FK_ICShipmentPlans_ICStocks");
        });

        modelBuilder.Entity<IcshipmentProposal>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.IcshipmentProposals).HasConstraintName("FK_ICShipmentProposals_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IcshipmentProposals).HasConstraintName("FK_ICShipmentProposals_BRBranchs");

            entity.HasOne(d => d.FkHrapprovedEmployee).WithMany(p => p.IcshipmentProposalFkHrapprovedEmployees).HasConstraintName("FK_ICShipmentProposals_HREmployeeApproves");

            entity.HasOne(d => d.FkHrdiscardEmployee).WithMany(p => p.IcshipmentProposalFkHrdiscardEmployees).HasConstraintName("FK_ICShipmentProposals_HREmployeeDiscards");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IcshipmentProposalFkHremployees).HasConstraintName("FK_ICShipmentProposals_HREmployees");

            entity.HasOne(d => d.FkHrproposalEmployee).WithMany(p => p.IcshipmentProposalFkHrproposalEmployees).HasConstraintName("FK_ICShipmentProposals_HREmployeeProposal");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcshipmentProposals).HasConstraintName("FK_ICShipmentProposals_ICProductAttributes");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcshipmentProposals).HasConstraintName("FK_ICShipmentProposals_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcshipmentProposals).HasConstraintName("FK_ICShipmentProposals_MMBatchProducts");
        });

        modelBuilder.Entity<IcshipmentProposalItem>(entity =>
        {
            entity.HasOne(d => d.FkArcontainerLoader).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ARContainerLoaders");

            entity.HasOne(d => d.FkArcontainerLoaderItem).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ARContainerLoaderItems");

            entity.HasOne(d => d.FkArproductionPlanningItem).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ARProductionPlanningItems");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_GECountrys");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ICModels");

            entity.HasOne(d => d.FkIcproductAttributeColorNavigation).WithMany(p => p.IcshipmentProposalItemFkIcproductAttributeColorNavigations).HasConstraintName("FK_ICShipmentProposalItems_ICProductAttributeColors");

            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.IcshipmentProposalItemFkIcproductAttributes).HasConstraintName("FK_ICShipmentProposalItems_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductAttributePaintTypeNavigation).WithMany(p => p.IcshipmentProposalItemFkIcproductAttributePaintTypeNavigations).HasConstraintName("FK_ICShipmentProposalItems_ICProductAttributePaintTypes");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.IcshipmentProposalItemFkIcproductAttributeQualities).HasConstraintName("FK_ICShipmentProposalItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.IcshipmentProposalItemFkIcproductAttributeTtmts).HasConstraintName("FK_ICShipmentProposalItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcshipmentProposalItemFkIcproducts).HasConstraintName("FK_ICShipmentProposalItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ICProductSeries");

            entity.HasOne(d => d.FkIcshipmentProposal).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ICShipmentProposals");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IcshipmentProposalItems).HasConstraintName("FK_ICShipmentProposalItems_MMBatchProducts");
        });

        modelBuilder.Entity<IcshipmentSaleOrder>(entity =>
        {
            entity.HasKey(e => e.IcshipmentSaleOrderId).HasName("PK_FASellOrderShipments");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.IcshipmentSaleOrders).HasConstraintName("FK_FASellOrderShipments_FASellOrders");

            entity.HasOne(d => d.FkIcshipment).WithMany(p => p.IcshipmentSaleOrders)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FASellOrderShipments_FAShipments");
        });

        modelBuilder.Entity<Icstock>(entity =>
        {
            entity.HasKey(e => e.IcstockId).HasName("PK_MAStocks");

            entity.Property(e => e.IcstockActiveCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.Icstocks).HasConstraintName("FK_ICStocks_ACAccounts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Icstocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICStocks_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Icstocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAStocks_GECurrencies");

            entity.HasOne(d => d.FkGelanguage).WithMany(p => p.Icstocks).HasConstraintName("FK_MAStocks_GELanguages");
        });

        modelBuilder.Entity<IcstockConfigRate>(entity =>
        {
            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IcstockConfigRates).HasConstraintName("ICStockConfigRates_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IcstockConfigRates).HasConstraintName("ICStockConfigRates_ICProducts");
        });

        modelBuilder.Entity<IcstockSlot>(entity =>
        {
            entity.HasKey(e => e.IcstockSlotId).HasName("PK_MAStockSlot");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcstockSlots).HasConstraintName("FK_MAStockSlot_MAStocks");
        });

        modelBuilder.Entity<Ictask>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Ictasks).HasConstraintName("FK_ICTasks_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Ictasks).HasConstraintName("FK_ICTasks_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Ictasks).HasConstraintName("FK_ICTasks_HREmployees");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.Ictasks).HasConstraintName("FK_ICTasks_ICMeasureUnits");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.Ictasks).HasConstraintName("FK_ICTasks_PMProjectTypes");
        });

        modelBuilder.Entity<Ictransaction>(entity =>
        {
            entity.HasOne(d => d.FkIcstock).WithMany(p => p.Ictransactions).HasConstraintName("FK_ICTransactions_ICStocks");
        });

        modelBuilder.Entity<Ictransfer>(entity =>
        {
            entity.HasOne(d => d.FkAppurchaseOrder).WithMany(p => p.Ictransfers).HasConstraintName("FK_ICTransfers_APPurchaseOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Ictransfers).HasConstraintName("FK_ICTransfers_BRBranchs");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.Ictransfers).HasConstraintName("ICTransfers_GECurrencies");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.Ictransfers).HasConstraintName("ICTransfers_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Ictransfers).HasConstraintName("ICTransfers_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IctransferFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransfers_HREmployees");

            entity.HasOne(d => d.FkHremployeeRecever).WithMany(p => p.IctransferFkHremployeeRecevers).HasConstraintName("FK_ICTransfers_HREmployees2");

            entity.HasOne(d => d.FkIcfromStock).WithMany(p => p.IctransferFkIcfromStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransfers_ICStocks");

            entity.HasOne(d => d.FkIctoStock).WithMany(p => p.IctransferFkIctoStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransfers_ICStocks1");

            entity.HasOne(d => d.FkIctransferParent).WithMany(p => p.InverseFkIctransferParent).HasConstraintName("FK_ICTransfers_ICTransfers1");

            entity.HasOne(d => d.FkIctransitStock).WithMany(p => p.IctransferFkIctransitStocks).HasConstraintName("FK_ICTransfers_ICStocks2");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.Ictransfers).HasConstraintName("FK_ICTransfers_MMBatchProducts");
        });

        modelBuilder.Entity<IctransferItem>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.IctransferItemFkAcaccounts).HasConstraintName("ICTransferItems_ACAccounts");

            entity.HasOne(d => d.FkAccostObject).WithMany(p => p.IctransferItems).HasConstraintName("ICTransferItems_ACCostObjects");

            entity.HasOne(d => d.FkAcoffsetAccount).WithMany(p => p.IctransferItemFkAcoffsetAccounts).HasConstraintName("ICTransferItems_ACOffsetAccounts");

            entity.HasOne(d => d.FkActransitInAccount).WithMany(p => p.IctransferItemFkActransitInAccounts).HasConstraintName("ICTransferItems_ACTransitInAccounts");

            entity.HasOne(d => d.FkArdeliveryPlanWork).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ARDeliveryPlanWorks");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkArsaleOrderItemWork).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ARSaleOrderItemWorks");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ICDepartments");

            entity.HasOne(d => d.FkIcfromStock).WithMany(p => p.IctransferItemFkIcfromStocks).HasConstraintName("FK_ICTransferItems_ICStocks");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ICModels");

            entity.HasOne(d => d.FkIcproductEquipment).WithMany(p => p.IctransferItemFkIcproductEquipments).HasConstraintName("ICTransferItems_ICProductEquipments");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IctransferItemFkIcproducts).HasConstraintName("FK_ICTransferItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ICProductSeries");

            entity.HasOne(d => d.FkIctoStock).WithMany(p => p.IctransferItemFkIctoStocks).HasConstraintName("FK_ICTransferItems_ICStocks1");

            entity.HasOne(d => d.FkIctransfer).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_ICTransfers");

            entity.HasOne(d => d.FkIctransitStock).WithMany(p => p.IctransferItemFkIctransitStocks).HasConstraintName("FK_ICTransferItems_ICStocks2");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.IctransferItems).HasConstraintName("FK_ICTransferItems_MMOperations");
        });

        modelBuilder.Entity<IctransferItemPackage>(entity =>
        {
            entity.HasOne(d => d.FkIcpackage).WithMany(p => p.IctransferItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransferItemPackages_ICPackages");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IctransferItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransferItemPackages_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IctransferItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransferItemPackages_ICStocks");

            entity.HasOne(d => d.FkIctransferItem).WithMany(p => p.IctransferItemPackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransferItemPackages_ICTransferItems");
        });

        modelBuilder.Entity<IctransferLog>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IctransferLogs).HasConstraintName("FK_ICTransferLogs_BRBranchs");

            entity.HasOne(d => d.FkIcfromStock).WithMany(p => p.IctransferLogFkIcfromStocks).HasConstraintName("FK_ICTransferLogs_ICStocks");

            entity.HasOne(d => d.FkIctoStock).WithMany(p => p.IctransferLogFkIctoStocks).HasConstraintName("FK_ICTransferLogs_ICStocks1");

            entity.HasOne(d => d.FkIctransitStock).WithMany(p => p.IctransferLogFkIctransitStocks).HasConstraintName("FK_ICTransferLogs_ICStocks2");
        });

        modelBuilder.Entity<IctransferLogItem>(entity =>
        {
            entity.HasOne(d => d.FkIcfromStock).WithMany(p => p.IctransferLogItemFkIcfromStocks).HasConstraintName("FK_ICTransferLogItems_ICStocks");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IctransferLogItems).HasConstraintName("FK_ICTransferLogItems_ICProducts");

            entity.HasOne(d => d.FkIcproductNavigation).WithMany(p => p.IctransferLogItemFkIcproductNavigations).HasConstraintName("FK_ICTransferLogItems_ICStocks1");

            entity.HasOne(d => d.FkIctransferLog).WithMany(p => p.IctransferLogItems).HasConstraintName("FK_ICTransferLogItems_ICTransferLogs");

            entity.HasOne(d => d.FkIctransitStock).WithMany(p => p.IctransferLogItemFkIctransitStocks).HasConstraintName("FK_ICTransferLogItems_ICStocks2");
        });

        modelBuilder.Entity<IctransferProposal>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.IctransferProposals).HasConstraintName("FK_ICTransferProposals_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.IctransferProposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransferProposals_HREmployees");

            entity.HasOne(d => d.FkIcfromStock).WithMany(p => p.IctransferProposalFkIcfromStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransferProposals_ICStocks");

            entity.HasOne(d => d.FkIctoStock).WithMany(p => p.IctransferProposalFkIctoStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICTransferProposals_ICStocks1");

            entity.HasOne(d => d.FkIctransitStock).WithMany(p => p.IctransferProposalFkIctransitStocks).HasConstraintName("FK_ICTransferProposals_ICStocks2");
        });

        modelBuilder.Entity<IctransferProposalItem>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.IctransferProposalItems).HasConstraintName("FK_ICTransferProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcfromStock).WithMany(p => p.IctransferProposalItemFkIcfromStocks).HasConstraintName("FK_ICTransferProposalItems_ICStocks");

            entity.HasOne(d => d.FkIcproductAttributeColor).WithMany(p => p.IctransferProposalItemFkIcproductAttributeColors).HasConstraintName("FK_ICTransferProposalItems_ICProductAttributeColor");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.IctransferProposalItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_ICTransferProposalItems_ICProductAttributesWoodType");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.IctransferProposalItems).HasConstraintName("FK_ICTransferProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.IctransferProposalItems).HasConstraintName("FK_ICTransferProposalItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.IctransferProposalItems).HasConstraintName("FK_ICTransferProposalItems_ICProductSeries");

            entity.HasOne(d => d.FkIctoStock).WithMany(p => p.IctransferProposalItemFkIctoStocks).HasConstraintName("FK_ICTransferProposalItems_ICStocks1");

            entity.HasOne(d => d.FkIctransferProposal).WithMany(p => p.IctransferProposalItems).HasConstraintName("FK_ICTransferProposalItems_ICTransferProposals");

            entity.HasOne(d => d.FkIctransitStock).WithMany(p => p.IctransferProposalItemFkIctransitStocks).HasConstraintName("FK_ICTransferProposalItems_ICStocks2");
        });

        modelBuilder.Entity<IcvitualTransaction>(entity =>
        {
            entity.HasOne(d => d.FkIcstockExt).WithMany(p => p.IcvitualTransactionFkIcstockExts).HasConstraintName("FK_ICVitualTransactions_ICStockExts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.IcvitualTransactionFkIcstocks).HasConstraintName("FK_ICVitualTransactions_ICStocks");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName").HasFilter("([StateName] IS NOT NULL)");
        });

        modelBuilder.Entity<JobParameter>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Name }).HasName("PK_HangFire_JobParameter");

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameters).HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobQueue>(entity =>
        {
            entity.HasKey(e => new { e.Queue, e.Id }).HasName("PK_HangFire_JobQueue");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_List");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MmallocationPlan>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmallocationPlans).HasConstraintName("FK_MMAllocationPlans_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmallocationPlans).HasConstraintName("MMAllocationPlans_FK_ARSaleOrderID");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmallocationPlans).HasConstraintName("FK_MMAllocationPlans_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmallocationPlans).HasConstraintName("FK_MMAllocationPlans_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmallocationPlans).HasConstraintName("FK_MMAllocationPlans_ICProductAttributes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmallocationPlans).HasConstraintName("FK_MMAllocationPlans_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmallocationPlans).HasConstraintName("MMAllocationPlans_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmallocationPlans).HasConstraintName("FK_MMAllocationPlans_MMBatchProductItems");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmallocationPlans).HasConstraintName("MMAllocationPlans_FK_MMLineID");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmallocationPlans).HasConstraintName("FK_MMAllocationPlans_MMWoodPlans");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmallocationPlans).HasConstraintName("MMAllocationPlans_FK_MMWorkShopID");
        });

        modelBuilder.Entity<MmallocationPlanItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_ARSaleOrders");

            entity.HasOne(d => d.FkIcbpmeasureUnit).WithMany(p => p.MmallocationPlanItemFkIcbpmeasureUnits).HasConstraintName("FK_MMAllocationPlanItems_ICMeasureUnits1");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmallocationPlanItemFkIcmeasureUnits).HasConstraintName("FK_MMAllocationPlanItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_ICModels");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmallocationPlanItemFkIcproductAttributeQualities).HasConstraintName("FK_MMAllocationPlanItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmallocationPlanItemFkIcproductAttributeTtmts).HasConstraintName("FK_MMAllocationPlanItems_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmallocationPlanItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMAllocationPlanItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmallocationPlanItemFkIcproductForBatches).HasConstraintName("FK_MMAllocationPlanItems_ICProducts2");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmallocationPlanItemFkIcproducts).HasConstraintName("FK_MMAllocationPlanItems_ICProducts");

            entity.HasOne(d => d.FkIcproductWoodIngredient).WithMany(p => p.MmallocationPlanItemFkIcproductWoodIngredients).HasConstraintName("FK_MMAllocationPlanItems_ICProducts_WoodIngredient");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_MMAllocationPlans");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmallocationPlanItems).HasConstraintName("MMAllocationPlanItems_FK_MMLineID");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmallocationPlanItems).HasConstraintName("MMAllocationPlanItems_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_MMOperations");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmallocationPlanItems).HasConstraintName("FK_MMAllocationPlanItems_MMWoodPlans");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmallocationPlanItems).HasConstraintName("MMAllocationPlanItems_FK_MMWorkShopID");
        });

        modelBuilder.Entity<MmallocationProposal>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_MMAllocationProposals_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_MMAllocationProposals_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_MMAllocationProposals_BRBranchs");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_AllocationProposals_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_MMAllocationProposals_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmallocationProposalFkHremployees).HasConstraintName("FK_MMAllocationProposals_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_MMAllocationProposals_ICProductAttributes");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_MMAllocationProposals_MMAllocationPlans");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_MMAllocationProposals_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmallocationProposals).HasConstraintName("MMAllocationProposals_FK_MMLineID");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmallocationProposals).HasConstraintName("MMAllocationProposals_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmallocationProposals).HasConstraintName("FK_MMAllocationProposals_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmallocationProposals).HasConstraintName("MMAllocationProposals_FK_MMWorkShopID");

            entity.HasOne(d => d.MmallocationProposalProposedEmployee).WithMany(p => p.MmallocationProposalMmallocationProposalProposedEmployees).HasConstraintName("FK_MMAllocationProposals_HREmployees1");
        });

        modelBuilder.Entity<MmallocationProposalItem>(entity =>
        {
            entity.HasOne(d => d.FkGecountry).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_GECountrys");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcmodelDetail).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_ICModelDetails");

            entity.HasOne(d => d.FkIcmodel).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_ICModels");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmallocationProposalItemFkIcproductAttributeQualities).HasConstraintName("FK_MMAllocationProposalItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmallocationProposalItemFkIcproductAttributeTtmts).HasConstraintName("FK_MMAllocationProposalItems_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmallocationProposalItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMAllocationProposalItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmallocationProposalItemFkIcproductForBatches).HasConstraintName("FK_MMAllocationProposalItems_ICProducts2");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmallocationProposalItemFkIcproducts).HasConstraintName("FK_MMAllocationProposalItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_ICStocks");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_MMAllocationPlans");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_MMAllocationProposals");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmallocationProposalItems).HasConstraintName("FK_MMAllocationProposalItems_MMOperations");
        });

        modelBuilder.Entity<MmbatchItemPlan>(entity =>
        {
            entity.HasKey(e => e.MmbatchItemPlanId).HasName("PK_MMBatchItemPlanes");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmbatchItemPlans).HasConstraintName("FK_MMBatchItemPlans_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmbatchItemPlans).HasConstraintName("FK_MMBatchItemPlans_ARSaleOrders");

            entity.HasOne(d => d.FkHremployeeApprovedNavigation).WithMany(p => p.MmbatchItemPlanFkHremployeeApprovedNavigations).HasConstraintName("FK_MMBatchItemPlans_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmbatchItemPlanFkHremployees).HasConstraintName("FK_MMBatchItemPlans_HREmployees");

            entity.HasOne(d => d.FkHremployeeValidatedNavigation).WithMany(p => p.MmbatchItemPlanFkHremployeeValidatedNavigations).HasConstraintName("FK_MMBatchItemPlans_HREmployeeValidateds");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmbatchItemPlans).HasConstraintName("FK_MMBatchItemPlans_ICProductAttributes");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchItemPlans).HasConstraintName("FK_MMBatchItemPlans_MMBatchProducts");
        });

        modelBuilder.Entity<MmbatchItemWood>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmbatchItemWoods).HasConstraintName("FK_MMBatchItemWoods_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmbatchItemWoods).HasConstraintName("FK_MMBatchItemWoods_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmbatchItemWoods).HasConstraintName("FK_MMBatchItemWoods_ICProductAttributes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchItemWoods).HasConstraintName("FK_MMBatchItemWoods_ICProducts");

            entity.HasOne(d => d.FkMmbatchItemPlan).WithMany(p => p.MmbatchItemWoods).HasConstraintName("FK_MMBatchItemWoods_MMBatchItemPlans");
        });

        modelBuilder.Entity<MmbatchProduct>(entity =>
        {
            entity.HasKey(e => e.MmbatchProductId).HasName("PK_MMBatchProductes");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmbatchProducts).HasConstraintName("FK_MMBatchProductes_ARCustomers");

            entity.HasOne(d => d.FkArproductionPlanning).WithMany(p => p.MmbatchProducts).HasConstraintName("FK_MMBatchProducts_ARProductionPlannings");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmbatchProducts).HasConstraintName("FK_MMBatchProducts_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmbatchProducts).HasConstraintName("FK_MMBatchProductes_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmbatchProducts).HasConstraintName("FK_MMBatchProducts_ICProductAttributes");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmbatchProducts).HasConstraintName("FK_MMBatchProducts_MMOperations");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmbatchProducts).HasConstraintName("MMBatchProducts_FK_MMProposalID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmbatchProducts).HasConstraintName("FK_MMBatchProducts_MMWorkShops");
        });

        modelBuilder.Entity<MmbatchProductCompletionPercentage>(entity =>
        {
            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductCompletionPercentages).HasConstraintName("FK_MMBatchProductCompletionPercentages_MMBatchProduct");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmbatchProductCompletionPercentages).HasConstraintName("FK_MMBatchProductCompletionPercentages_MMBatchProductProductionNormItem");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmbatchProductCompletionPercentages).HasConstraintName("FK_MMBatchProductCompletionPercentages_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostFactor).WithMany(p => p.MmbatchProductCompletionPercentages).HasConstraintName("FK_MMBatchProductCompletionPercentages_MMProductionCostFactor");
        });

        modelBuilder.Entity<MmbatchProductInputItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmbatchProductInputItems).HasConstraintName("FK_MMBatchProductInputItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchProductInputItems).HasConstraintName("FK_MMBatchProductInputItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.MmbatchProductInputItems).HasConstraintName("FK_MMBatchProductInputItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.MmbatchProductInputItems).HasConstraintName("FK_MMBatchProductInputItems_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductInputItems).HasConstraintName("FK_MMBatchProductInputItems_MMBatchProducts");
        });

        modelBuilder.Entity<MmbatchProductItem>(entity =>
        {
            entity.HasKey(e => e.MmbatchProductItemId).HasName("PK_MMBatchProductItemes");

            entity.HasOne(d => d.FkArproductionPlanning).WithMany(p => p.MmbatchProductItems).HasConstraintName("FK_MMBatchProductItems_ARProductionPlannings");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmbatchProductItems).HasConstraintName("FK_MMBatchProductItems_ARSaleOrders");

            entity.HasOne(d => d.FkGecountry).WithMany(p => p.MmbatchProductItems).HasConstraintName("MMBatchProductItems_FK_GECountryID");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmbatchProductItems).HasConstraintName("FK_MMBatchProductItems_FK_ICMeasureUnitID");

            entity.HasOne(d => d.FkIcproductAttributeColor).WithMany(p => p.MmbatchProductItemFkIcproductAttributeColors).HasConstraintName("FK_MMBatchProductItems_FK_ICProductAttributeID2");

            entity.HasOne(d => d.FkIcproductAttributeHttype).WithMany(p => p.MmbatchProductItemFkIcproductAttributeHttypes).HasConstraintName("FK_MMBatchProductItems_FK_ICProductAttributeID3");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmbatchProductItemFkIcproductAttributeQualities).HasConstraintName("FK_MMBatchProductItems_ICProductAttributes5");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmbatchProductItemFkIcproductAttributeTtmts).HasConstraintName("FK_MMBatchProductItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmbatchProductItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMBatchProductItems_FK_ICProductAttributeID1");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchProductItems).HasConstraintName("FK_MMBatchProductItemes_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductItems).HasConstraintName("FK_MMBatchProductItemes_MMBatchProducts");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmbatchProductItems).HasConstraintName("FK_MMBatchProductItemes_MMProductionNorms");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmbatchProductItems).HasConstraintName("MMBatchProductItems_FK_MMProposalID");
        });

        modelBuilder.Entity<MmbatchProductItemGeneralPlan>(entity =>
        {
            entity.HasKey(e => e.MmbatchProductItemGeneralPlanId).HasName("PK_MMBatchProductItemGeneralPlanes");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductItemGeneralPlans).HasConstraintName("FK_MMBatchProductItemGeneralPlanes_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmbatchProductItemGeneralPlans).HasConstraintName("FK_MMBatchProductItemGeneralPlans_MMLines");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmbatchProductItemGeneralPlans).HasConstraintName("FK_MMBatchProductItemGeneralPlans_MMWorkShops");
        });

        modelBuilder.Entity<MmbatchProductItemOperation>(entity =>
        {
            entity.HasKey(e => e.MmbatchProductItemOperationId).HasName("PK_MMBatchProductItemOperationsTemp");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchProductItemOperations).HasConstraintName("FK_MMBatchProductItemOperationsTemp_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductItemOperations).HasConstraintName("FK_MMBatchProductItemOperationsTemp_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmbatchProductItemOperations).HasConstraintName("FK_MMBatchProductItemOperationsTemp_MMBatchProductItems");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmbatchProductItemOperations).HasConstraintName("FK_MMBatchProductItemOperationsTemp_MMOperations");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmbatchProductItemOperations).HasConstraintName("FK_MMBatchProductItemOperationsTemp_MMProductionNorms");
        });

        modelBuilder.Entity<MmbatchProductItemOperationInfo>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchProductItemOperationInfos).HasConstraintName("FK_MMBatchProductItemOperationInfos_ICProducts");

            entity.HasOne(d => d.FkMmbatchProductItemOperation).WithMany(p => p.MmbatchProductItemOperationInfos).HasConstraintName("FK_MMBatchProductItemOperationInfos_MMBatchProductItemOperations");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmbatchProductItemOperationInfos).HasConstraintName("FK_MMBatchProductItemOperationInfos_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmbatchProductItemOperationInfos).HasConstraintName("FK_MMBatchProductItemOperationInfos_MMOperations");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmbatchProductItemOperationInfos).HasConstraintName("FK_MMBatchProductItemOperationInfos_MMProductionNorms");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmbatchProductItemOperationInfos).HasConstraintName("FK_MMBatchProductItemOperationInfos_MMProductionNormItems");

            entity.HasOne(d => d.FkMmproductionNormItemOperation).WithMany(p => p.MmbatchProductItemOperationInfos).HasConstraintName("FK_MMBatchProductItemOperationInfos_MMProductionNormItemOperations");
        });

        modelBuilder.Entity<MmbatchProductItemOutSourcing>(entity =>
        {
            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductItemOutSourcings).HasConstraintName("FK_MMBatchProductItemOutSourcings_MMBatchProducts");
        });

        modelBuilder.Entity<MmbatchProductProductionNormItem>(entity =>
        {
            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductProductionNormItems).HasConstraintName("FK_MMBatchProductProductionNormItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmbatchProductProductionNormItems).HasConstraintName("FK_MMBatchProductProductionNormItems_MMProductionNorms");
        });

        modelBuilder.Entity<MmbatchProductProductionNormItemEquipment>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmbatchProductProductionNormItemEquipments).HasConstraintName("FK_MMBatchProductProductionNormItemEquipments_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAlternative).WithMany(p => p.MmbatchProductProductionNormItemEquipmentFkIcproductAlternatives).HasConstraintName("FK_MMBatchProductProductionNormItemEquipments_ICProductAlternatives");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchProductProductionNormItemEquipmentFkIcproducts).HasConstraintName("FK_MMBatchProductProductionNormItemEquipments_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductProductionNormItemEquipments).HasConstraintName("FK_MMBatchProductProductionNormItemEquipments_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmbatchProductProductionNormItemEquipments).HasConstraintName("FK_MMBatchProductProductionNormItemEquipments_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmbatchProductProductionNormItemEquipments).HasConstraintName("FK_MMBatchProductProductionNormItemEquipments_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmbatchProductProductionNormItemEquipments).HasConstraintName("FK_MMBatchProductProductionNormItemEquipments_MMOperations");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmbatchProductProductionNormItemEquipments).HasConstraintName("FK_MMBatchProductProductionNormItemEquipments_MMProductionNormItems");
        });

        modelBuilder.Entity<MmbatchProductProductionNormItemHardware>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmbatchProductProductionNormItemHardwares).HasConstraintName("FK_MMBatchProductProductionNormItemHardwares_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAlternative).WithMany(p => p.MmbatchProductProductionNormItemHardwareFkIcproductAlternatives).HasConstraintName("FK_MMBatchProductProductionNormItemHardwares_ICProductAlternatives");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchProductProductionNormItemHardwareFkIcproducts).HasConstraintName("FK_MMBatchProductProductionNormItemHardwares_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductProductionNormItemHardwares).HasConstraintName("FK_MMBatchProductProductionNormItemHardwares_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmbatchProductProductionNormItemHardwares).HasConstraintName("FK_MMBatchProductProductionNormItemHardwares_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmbatchProductProductionNormItemHardwares).HasConstraintName("FK_MMBatchProductProductionNormItemHardwares_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmbatchProductProductionNormItemHardwares).HasConstraintName("FK_MMBatchProductProductionNormItemHardwares_MMOperations");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmbatchProductProductionNormItemHardwares).HasConstraintName("FK_MMBatchProductProductionNormItemHardwares_MMProductionNormItems");
        });

        modelBuilder.Entity<MmbatchProductProductionNormItemMeterial>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmbatchProductProductionNormItemMeterials).HasConstraintName("FK_MMBatchProductProductionNormItemMeterials_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAlternative).WithMany(p => p.MmbatchProductProductionNormItemMeterialFkIcproductAlternatives).HasConstraintName("FK_MMBatchProductProductionNormItemMeterials_ICProductAlternatives");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchProductProductionNormItemMeterialFkIcproducts).HasConstraintName("FK_MMBatchProductProductionNormItemMeterials_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductProductionNormItemMeterials).HasConstraintName("FK_MMBatchProductProductionNormItemMeterials_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmbatchProductProductionNormItemMeterials).HasConstraintName("FK_MMBatchProductProductionNormItemMeterials_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmbatchProductProductionNormItemMeterials).HasConstraintName("FK_MMBatchProductProductionNormItemMeterials_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmformula).WithMany(p => p.MmbatchProductProductionNormItemMeterials).HasConstraintName("FK_MMBatchProductProductionNormItemMeterials_MMFormulas");
        });

        modelBuilder.Entity<MmbatchProductProductionNormItemPaint>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.MmbatchProductProductionNormItemPaints).HasConstraintName("FK_MMBatchProductProductionNormItemPaints_ICProductAttributes");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbatchProductProductionNormItemPaints).HasConstraintName("FK_MMBatchProductProductionNormItemPaints_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmbatchProductProductionNormItemPaints).HasConstraintName("FK_MMBatchProductProductionNormItemPaints_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmbatchProductProductionNormItemPaints).HasConstraintName("FK_MMBatchProductProductionNormItemPaints_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmbatchProductProductionNormItemPaints).HasConstraintName("FK_MMBatchProductProductionNormItemPaints_MMProductionNormItems");
        });

        modelBuilder.Entity<MmbatchProductProductionNormItemProcesss>(entity =>
        {
            entity.HasOne(d => d.FkIcproductCarcass).WithMany(p => p.MmbatchProductProductionNormItemProcesssFkIcproductCarcasses).HasConstraintName("FK_MMBatchProductProductionNormItemProcesss_ICProductCarcasss");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbatchProductProductionNormItemProcesssFkIcproducts).HasConstraintName("FK_MMBatchProductProductionNormItemProcesss_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmbatchProductProductionNormItemProcessses).HasConstraintName("MMBatchProductProductionNormItemProcesss_FK_MMOperationID");

            entity.HasOne(d => d.FkMmprocess).WithMany(p => p.MmbatchProductProductionNormItemProcessses).HasConstraintName("MMBatchProductProductionNormItemProcesss_FK_MMProcessID");
        });

        modelBuilder.Entity<MmbpoperationDepartment>(entity =>
        {
            entity.HasKey(e => e.MmbpoperationDepartmentId).HasName("PK_FABPOperationDepartments");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmbpoperationDepartments).HasConstraintName("FK_MMBPOperationDepartments_HRDepartmentID");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.MmbpoperationDepartments).HasConstraintName("FK_MMBPOperationDepartments_HRDepartmentRooms");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmbpoperationDepartments).HasConstraintName("FK_MMBPOperationDepartments_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmbpoperationDepartments).HasConstraintName("FK_MMBPOperationDepartments_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmbpoperationDepartments).HasConstraintName("FK_MMBPOperationDepartments_MMBatchProductItems");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmbpoperationDepartments).HasConstraintName("FK_MMBPOperationDepartments_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmbpoperationDepartments).HasConstraintName("FK_MMBPOperationDepartments_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmbpoperationDepartments).HasConstraintName("FK_MMBPOperationDepartments_MMWorkShops");
        });

        modelBuilder.Entity<MmcalculatorProductionNormCost>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmcalculatorProductionNormCosts).HasConstraintName("FK_MMCalculatorProductionNormCosts_ARCustomers");

            entity.HasOne(d => d.FkGecurrency).WithMany(p => p.MmcalculatorProductionNormCosts).HasConstraintName("MMCalculatorProductionNormCosts_FK_GECurrencyID");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmcalculatorProductionNormCosts).HasConstraintName("MMCalculatorProductionNormCosts_FK_ICProductGroupID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmcalculatorProductionNormCosts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MMCalculatorProductionNormCosts_FK_ICProductID");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmcalculatorProductionNormCosts).HasConstraintName("PK_MMCalculatorProductionNormCosts_MMBatchProducts");

            entity.HasOne(d => d.FkMmprocess).WithMany(p => p.MmcalculatorProductionNormCosts).HasConstraintName("MMCalculatorProductionNormCosts_FK_MMProcessID");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmcalculatorProductionNormCosts).HasConstraintName("MMCalculatorProductionNormCosts_FK_MMProductionNormID");
        });

        modelBuilder.Entity<MmcalculatorProductionNormCostItem>(entity =>
        {
            entity.HasOne(d => d.FkMmcalculatorProductionNormCost).WithMany(p => p.MmcalculatorProductionNormCostItems).HasConstraintName("MMCalculatorProductionNormCostItems_FK_MMCalculatorProductionNormCostID");
        });

        modelBuilder.Entity<MmcalculatorProductionNormItem>(entity =>
        {
            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmcalculatorProductionNormItems).HasConstraintName("FK_MMCalculatorProductionNormItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmcalculatorProductionNormItems).HasConstraintName("FK_MMCalculatorProductionNormItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmcalculatorProductionNormItems).HasConstraintName("FK_MMCalculatorProductionNormItems_MMBatchProductProductionNormItems");
        });

        modelBuilder.Entity<MmcalculatorProductionNormItemMaterial>(entity =>
        {
            entity.HasKey(e => e.MmcalculatorProductionNormItemMaterialId).HasName("PK_[MMCalculatorProductionNormItemMaterials");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmcalculatorProductionNormItemMaterials).HasConstraintName("FK_MMCalculatorProductionNormItemMaterials_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductMaterial).WithMany(p => p.MmcalculatorProductionNormItemMaterials).HasConstraintName("FK_MMCalculatorProductionNormItemMaterials_ICProductMaterials");

            entity.HasOne(d => d.FkMmcalculatorProductionNormCost).WithMany(p => p.MmcalculatorProductionNormItemMaterials).HasConstraintName("FK_MMCalculatorProductionNormItemMaterials_MMCalculatorProductionNormCosts");
        });

        modelBuilder.Entity<MmcancelAllocationPlan>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmcancelAllocationPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMCancelAllocationPlans_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmcancelAllocationPlans).HasConstraintName("FK_MMCancelAllocationPlans_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmcancelAllocationPlans).HasConstraintName("FK_MMCancelAllocationPlans_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmcancelAllocationPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMCancelAllocationPlans_HREmployees");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmcancelAllocationPlans).HasConstraintName("FK_MMCancelAllocationPlans_ICProducts");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.MmcancelAllocationPlans).HasConstraintName("FK_MMCancelAllocationPlans_MMAllocationPlans");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmcancelAllocationPlans).HasConstraintName("FK_MMCancelAllocationPlans_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmcancelAllocationPlans).HasConstraintName("FK_MMCancelAllocationPlans_MMBatchProductItems");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmcancelAllocationPlans).HasConstraintName("FK_MMCancelAllocationPlans_MMWoodPlans");
        });

        modelBuilder.Entity<MmcancelAllocationPlanItem>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmcancelAllocationPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMCancelAllocationPlanItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmcancelAllocationPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMCancelAllocationPlanItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmcancelAllocationPlanItems).HasConstraintName("FK_MMCancelAllocationPlanItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmcancelAllocationPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMCancelAllocationPlanItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmcancelAllocationPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMCancelAllocationPlanItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.MmcancelAllocationPlanItems).HasConstraintName("FK_MMCancelAllocationPlanItems_ICStocks");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.MmcancelAllocationPlanItems).HasConstraintName("FK_MMCancelAllocationPlanItems_MMAllocationPlans");

            entity.HasOne(d => d.FkMmallocationPlanItem).WithMany(p => p.MmcancelAllocationPlanItems).HasConstraintName("FK_MMCancelAllocationPlanItems_MMAllocationPlanItems");

            entity.HasOne(d => d.FkMmcancelAllocationPlan).WithMany(p => p.MmcancelAllocationPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMCancelAllocationPlanItems_MMCancelAllocationPlans");
        });

        modelBuilder.Entity<MmcancelAllocationProposal>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmcancelAllocationProposals).HasConstraintName("FK_MMCancelAllocationProposals_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmcancelAllocationProposalFkHremployees).HasConstraintName("FK_MMCancelAllocationProposals_HREmployees");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.MmcancelAllocationProposals).HasConstraintName("FK_MMCancelAllocationProposals_MMAllocationProposals");

            entity.HasOne(d => d.MmcancelAllocationProposalApprovedEmployeeNavigation).WithMany(p => p.MmcancelAllocationProposalMmcancelAllocationProposalApprovedEmployeeNavigations).HasConstraintName("FK_MMCancelAllocationProposals_MMCancelAllocationProposalApprovedEmployee");
        });

        modelBuilder.Entity<MmcancelAllocationProposalItem>(entity =>
        {
            entity.HasOne(d => d.FkGecountry).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_GECountrys");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmcancelAllocationProposalItemFkIcproductAttributeQualities).HasConstraintName("FK_MMCancelAllocationProposalItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmcancelAllocationProposalItemFkIcproductAttributeTtmts).HasConstraintName("FK_MMCancelAllocationProposalItems_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmcancelAllocationProposalItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMCancelAllocationProposalItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmcancelAllocationProposalItemFkIcproductForBatches).HasConstraintName("FK_MMCancelAllocationProposalItems_ICProducts2");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmcancelAllocationProposalItemFkIcproducts).HasConstraintName("FK_MMCancelAllocationProposalItems_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_ICProductSeries");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_ICStocks");

            entity.HasOne(d => d.FkMmallocationPlan).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_MMAllocationPlans");

            entity.HasOne(d => d.FkMmallocationPlanItem).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_MMAllocationPlanItems");

            entity.HasOne(d => d.FkMmallocationProposal).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_MMAllocationProposals");

            entity.HasOne(d => d.FkMmallocationProposalItem).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_MMAllocationProposalItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmcancelAllocationProposal).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_MMCancelAllocationProposals");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmcancelAllocationProposalItems).HasConstraintName("FK_MMCancelAllocationProposalItems_MMOperations");
        });

        modelBuilder.Entity<MmcanceledPurchasePlan>(entity =>
        {
            entity.HasKey(e => e.MmcanceledPurchasePlanId).HasName("PK_MMCanceledPurchasePlanes");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmcanceledPurchasePlans).HasConstraintName("FK_MMCanceledPurchasePlans_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmcanceledPurchasePlans).HasConstraintName("FK_MMCanceledPurchasePlans_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmcanceledPurchasePlans).HasConstraintName("FK_MMCanceledPurchasePlans_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApprovedNavigation).WithMany(p => p.MmcanceledPurchasePlanFkHremployeeApprovedNavigations).HasConstraintName("FK_MMCanceledPurchasePlans_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmcanceledPurchasePlanFkHremployees).HasConstraintName("FK_MMCanceledPurchasePlans_HREmployees");

            entity.HasOne(d => d.FkHremployeeValidatedNavigation).WithMany(p => p.MmcanceledPurchasePlanFkHremployeeValidatedNavigations).HasConstraintName("FK_MMCanceledPurchasePlans_HREmployeeValidateds");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmcanceledPurchasePlans).HasConstraintName("FK_MMCanceledPurchasePlans_ICProductAttributes");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmcanceledPurchasePlans).HasConstraintName("FK_MMCanceledPurchasePlans_MMBatchProducts");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.MmcanceledPurchasePlans).HasConstraintName("FK_MMCanceledPurchasePlans_MMPurchasePlans");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmcanceledPurchasePlans).HasConstraintName("FK_MMCanceledPurchasePlans_MMWoodPlans");
        });

        modelBuilder.Entity<MmcanceledPurchasePlanItem>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_APSuppliers");

            entity.HasOne(d => d.FkIcbpmeasureUnit).WithMany(p => p.MmcanceledPurchasePlanItemFkIcbpmeasureUnits).HasConstraintName("FK_MMCanceledPurchasePlanItems_ICMeasureUnits1");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmcanceledPurchasePlanItemFkIcmeasureUnits).HasConstraintName("FK_MMCanceledPurchasePlanItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmcanceledPurchasePlanItemFkIcproductAttributeQualities).HasConstraintName("FK_MMCanceledPurchasePlanItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmcanceledPurchasePlanItemFkIcproductAttributeTtmts).HasConstraintName("FK_MMCanceledPurchasePlanItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmcanceledPurchasePlanItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMCanceledPurchasePlanItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmcanceledPurchasePlanItemFkIcproductForBatches).HasConstraintName("FK_MMCanceledPurchasePlanItems_ICProducts_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmcanceledPurchasePlanItemFkIcproducts).HasConstraintName("FK_ICProducts_MMCanceledPurchasePlanItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmcanceledPurchasePlan).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMCanceledPurchasePlans");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.MmcanceledPurchasePlanItemFkMmfromOperations).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMOperations1");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMBatchProductPlans");

            entity.HasOne(d => d.FkMmpurchasePlanItem).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMPurchasePlanItems");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.MmcanceledPurchasePlanItemFkMmtoOperations).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMOperations2");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMWoodPlans");

            entity.HasOne(d => d.FkMmwoodPlanItemDetail).WithMany(p => p.MmcanceledPurchasePlanItems).HasConstraintName("FK_MMCanceledPurchasePlanItems_MMWoodPlanItemDetails");
        });

        modelBuilder.Entity<MmchangeBominformation>(entity =>
        {
            entity.HasKey(e => e.MmchangeBominformationId).HasName("PK_MMChangeBOMInformationes");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmchangeBominformations).HasConstraintName("FK_MMChangeBOMInformationes_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmchangeBominformations).HasConstraintName("FK_MMChangeBOMInformationes_ARSaleOrders");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmchangeBominformationFkHremployees).HasConstraintName("FK_MMChangeBOMInformationes_HREmployees");

            entity.HasOne(d => d.FkHremployeeIdapprovedNavigation).WithMany(p => p.MmchangeBominformationFkHremployeeIdapprovedNavigations).HasConstraintName("FK_MMChangeBOMInformationes_HREmployeesApproved");

            entity.HasOne(d => d.FkHremployeeIdvalidatedNavigation).WithMany(p => p.MmchangeBominformationFkHremployeeIdvalidatedNavigations).HasConstraintName("FK_MMChangeBOMInformationes_HREmployeesValidated");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmchangeBominformations).HasConstraintName("FK_MMChangeBOMInformations_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmchangeBominformations).HasConstraintName("MMChangeBOMInformations_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmchangeBominformations).HasConstraintName("MMChangeBOMInformations_FK_MMProductionNormID");
        });

        modelBuilder.Entity<MmchangeBominformationItem>(entity =>
        {
            entity.HasKey(e => e.MmchangeBominformationItemId).HasName("PK_MMChangeBOMInformationItemes");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmchangeBominformationItems).HasConstraintName("FK_MMChangeBOMInformationItems_ICDepartments");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmchangeBominformationItems).HasConstraintName("FK_MMChangeBOMInformationItems_ICProducts");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmchangeBominformationItems).HasConstraintName("FK_MMChangeBOMInformationItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmchangeBominformation).WithMany(p => p.MmchangeBominformationItems).HasConstraintName("FK_MMChangeBOMInformationItemes_MMChangeBOMInformations");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmchangeBominformationItems).HasConstraintName("FK_MMProductionNormID_MMChangeBOMInformations");
        });

        modelBuilder.Entity<MmchangeDeliveryDateBatchProduct>(entity =>
        {
            entity.HasKey(e => e.MmchangeDeliveryDateBatchProductId).HasName("PK_FAChangeDeliveryDateBatchProducts");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmchangeDeliveryDateBatchProducts).HasConstraintName("FK_MMChangeDeliveryDateBatchProducts_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmchangeDeliveryDateBatchProducts).HasConstraintName("FK_MMChangeDeliveryDateBatchProducts_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmchangeDeliveryDateBatchProducts).HasConstraintName("FK_MMChangeDeliveryDateBatchProducts_HREmployees");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmchangeDeliveryDateBatchProducts).HasConstraintName("FK_MMChangeDeliveryDateBatchProducts_MMBatchProducts");
        });

        modelBuilder.Entity<MmchangeDeliveryDateBatchProductItem>(entity =>
        {
            entity.HasKey(e => e.MmchangeDeliveryDateBatchProductItemId).HasName("PK_FAChangeDeliveryDateBatchProductItems");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmchangeDeliveryDateBatchProductItems).HasConstraintName("FK_MMChangeDeliveryDateBatchProductItems_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmchangeDeliveryDateBatchProductItems).HasConstraintName("FK_MMChangeDeliveryDateBatchProductItems_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmchangeDeliveryDateBatchProductItems).HasConstraintName("FK_MMChangeDeliveryDateBatchProductItems_BRBranchs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmchangeDeliveryDateBatchProductItems).HasConstraintName("FK_MMChangeDeliveryDateBatchProductItems_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmchangeDeliveryDateBatchProductItems).HasConstraintName("FK_MMChangeDeliveryDateBatchProductItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmchangeDeliveryDateBatchProductItems).HasConstraintName("FK_MMChangeDeliveryDateBatchProductItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmchangeDeliveryDateBatchProduct).WithMany(p => p.MmchangeDeliveryDateBatchProductItems).HasConstraintName("FK_MMChangeDeliveryDateBatchProductItems_MMChangeDeliveryDateBatchProducts");
        });

        modelBuilder.Entity<MmconfigAccountOperation>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.MmconfigAccountOperationFkAcaccounts).HasConstraintName("FK_MMConfigAccountOperations_ACAccounts");

            entity.HasOne(d => d.FkAccostAccount).WithMany(p => p.MmconfigAccountOperationFkAccostAccounts).HasConstraintName("FK_MMConfigAccountOperations_ACAccountCost");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.MmconfigAccountOperationFkAcdebitAccounts).HasConstraintName("FK_MMConfigAccountOperations_ACAccountDebit");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmconfigAccountOperations).HasConstraintName("FK_MMConfigAccountOperations_HRDepartments");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmconfigAccountOperations).HasConstraintName("FK_MMConfigAccountOperations_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmconfigAccountOperations).HasConstraintName("FK_MMConfigAccountOperations_MMWorkShops");
        });

        modelBuilder.Entity<MmconsumableConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.MmconsumableConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMConsumableConfigs_ICProductAttributes");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmconsumableConfigs).HasConstraintName("FK_MMConsumableConfigs_ICProducts");
        });

        modelBuilder.Entity<MmdefaultAllocationOperationConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmdefaultAllocationOperationConfigs).HasConstraintName("FK_MMDefaultAllocationOperationConfigs_ICDepartments");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmdefaultAllocationOperationConfigs).HasConstraintName("FK_MMDefaultAllocationOperationConfigs_ICProductGroups");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmdefaultAllocationOperationConfigs).HasConstraintName("FK_MMDefaultAllocationOperationConfigs_MMOperations");
        });

        modelBuilder.Entity<MmdepartmentAndOperation>(entity =>
        {
            entity.HasKey(e => e.MmdepartmentAndOperationId).HasName("PK_FADepartmentAndOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmdepartmentAndOperations).HasConstraintName("FK_MMDepartmentAndOperations_MMWorkShops");
        });

        modelBuilder.Entity<MmdepartmentCapacityConfig>(entity =>
        {
            entity.HasKey(e => e.MmdepartmentCapacityConfigId).HasName("PK_MMDepartmentCapacityConfiges");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmdepartmentCapacityConfigs).HasConstraintName("FK_MMDepartmentCapacityConfigs_MMLines");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmdepartmentCapacityConfigs).HasConstraintName("FK_MMDepartmentCapacityConfigs_MMWorkShops");
        });

        modelBuilder.Entity<MmdepartmentCapacityDetail>(entity =>
        {
            entity.HasKey(e => e.MmdepartmentCapacityDetailId).HasName("PK_MMDepartmentCapacityDetailes");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmdepartmentCapacityDetails).HasConstraintName("FK_MMDepartmentCapacityDetails_MMLines");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmdepartmentCapacityDetails).HasConstraintName("FK_MMDepartmentCapacityDetails_MMWorkShops");
        });

        modelBuilder.Entity<MmexchangeMeasureUnitConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcfromMeasureUnit).WithMany(p => p.MmexchangeMeasureUnitConfigFkIcfromMeasureUnits).HasConstraintName("FK_MMExchangeMeasureUnitConfigs_ICMeasureUnits1");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmexchangeMeasureUnitConfigs).HasConstraintName("FK_MMExchangeMeasureUnitConfigs_ICProducts");

            entity.HasOne(d => d.FkIctoMeasureUnit).WithMany(p => p.MmexchangeMeasureUnitConfigFkIctoMeasureUnits).HasConstraintName("FK_MMExchangeMeasureUnitConfigs_ICMeasureUnits2");
        });

        modelBuilder.Entity<MmexchangeRateConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmexchangeRateConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICDepartments_MMExchangeRateConfigs");

            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.MmexchangeRateConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductAttributes_MMExchangeRateConfigs");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmexchangeRateConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICProductGroups_MMExchangeRateConfigs");
        });

        modelBuilder.Entity<MmexecuteTimeConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmexecuteTimeConfigs).HasConstraintName("FK_MMExecuteTimeConfigs_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmexecuteTimeConfigs).HasConstraintName("FK_MMExecuteTimeConfigs_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmexecuteTimeConfigs).HasConstraintName("FK_MMExecuteTimeConfigs_MMOperations");
        });

        modelBuilder.Entity<MmfalseConditional>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmfalseConditionals).HasConstraintName("FK_MMFalseConditionals_BRBranchs");

            entity.HasOne(d => d.FkHrcheckerEmployee).WithMany(p => p.MmfalseConditionalFkHrcheckerEmployees).HasConstraintName("FK_MMFalseConditionals_FK_HRCheckerEmployeeID");

            entity.HasOne(d => d.FkHrreceiverEmployee).WithMany(p => p.MmfalseConditionalFkHrreceiverEmployees).HasConstraintName("FK_MMFalseConditionals_FK_HRReceiverEmployeeID");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmfalseConditionals).HasConstraintName("FK_MMFalseConditionals_ICProductAttributeWoodType");
        });

        modelBuilder.Entity<MmfalseConditionalDetail>(entity =>
        {
            entity.HasOne(d => d.FkMmconfigFalseConditional).WithMany(p => p.MmfalseConditionalDetails).HasConstraintName("FK_MMFalseConditionalDetails_MMConfigFalseConditionals");

            entity.HasOne(d => d.FkMmfalseConditional).WithMany(p => p.MmfalseConditionalDetails).HasConstraintName("FK_MMFalseConditionalDetails_MMFalseConditionals");

            entity.HasOne(d => d.FkMmfalseConditionalItem).WithMany(p => p.MmfalseConditionalDetails).HasConstraintName("FK_MMFalseConditionalDetails_MMFalseConditionalItems");
        });

        modelBuilder.Entity<MmfalseConditionalItem>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmfalseConditionalItems).HasConstraintName("FK_MMFalseConditionals_ICProductAttributeQuality");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.MmfalseConditionalItems).HasConstraintName("FK_MMFalseConditionalItems_ICProductSeries");

            entity.HasOne(d => d.FkMmfalseConditional).WithMany(p => p.MmfalseConditionalItems).HasConstraintName("FK_MMFalseConditionalItems_MMFalseConditionals");
        });

        modelBuilder.Entity<Mmformula>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Mmformulas).HasConstraintName("FK_MMFormulas_HREmployees");
        });

        modelBuilder.Entity<MmformulaConfiguration>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.MmformulaConfigurations).HasConstraintName("FK_MMFormulaConfigurations_APSuppliers");

            entity.HasOne(d => d.FkMmformula).WithMany(p => p.MmformulaConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMFormulaConfigurations_MMFormulas");
        });

        modelBuilder.Entity<Mmhistory>(entity =>
        {
            entity.HasKey(e => e.MmhistoryId).HasName("PK_MMHistory");

            entity.Property(e => e.MmhistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.MmhistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.MmhistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<MmhistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkMmhistory).WithMany(p => p.MmhistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMHistoryDetails_MMHistory");
        });

        modelBuilder.Entity<MminProgressStatistic>(entity =>
        {
            entity.HasKey(e => e.MminProgressStatisticId).HasName("PK_MMEndingInProgressStatistics");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MminProgressStatistics).HasConstraintName("FK_MMInProgressStatistics_ARSaleOrder");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MminProgressStatistics).HasConstraintName("FK_MMInProgressStatistics_HRDepartment");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MminProgressStatistics).HasConstraintName("FK_MMInProgressStatistics_MMBatchProduct");

            entity.HasOne(d => d.FkMmproductionCostFormula).WithMany(p => p.MminProgressStatistics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMInProgressStatistics_MMProductionCostFormulas");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MminProgressStatistics).HasConstraintName("FK_MMEndingInProgressStatistics_MMWorkShop");
        });

        modelBuilder.Entity<MminProgressStatisticDetail>(entity =>
        {
            entity.HasKey(e => e.MminProgressStatisticDetailId).HasName("PK_MMEndingInProgressStatisticDetails");

            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.MminProgressStatisticDetailFkAcaccounts).HasConstraintName("FK_MMInProgressStatisticDetails_ACAccounts1");

            entity.HasOne(d => d.FkAcoffsetAccount).WithMany(p => p.MminProgressStatisticDetailFkAcoffsetAccounts).HasConstraintName("FK_MMInProgressStatisticDetails_ACOffsetAccountID");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MminProgressStatisticDetails).HasConstraintName("FK_MMInProgressStatisticDetails_ARSaleOrders");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MminProgressStatisticDetailFkIcproductForBatches).HasConstraintName("FK_MMInProgressStatisticDetails_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MminProgressStatisticDetails).HasConstraintName("FK_MMInProgressStatisticDetails_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MminProgressStatisticDetailFkIcproducts).HasConstraintName("FK_MMInProgressStatisticDetails_ICProduct");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MminProgressStatisticDetails).HasConstraintName("FK_MMInProgressStatisticDetails_MMBatchProduct");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MminProgressStatisticDetails).HasConstraintName("FK_MMInProgressStatisticDetails_MMBatchProductProductionNormItem");

            entity.HasOne(d => d.FkMminProgressStatistic).WithMany(p => p.MminProgressStatisticDetails).HasConstraintName("FK_MMInProgressStatisticDetails_MMInProgressStatistic");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MminProgressStatisticDetails).HasConstraintName("FK_MMInProgressStatisticDetails_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostFactor).WithMany(p => p.MminProgressStatisticDetails).HasConstraintName("FK_MMInProgressStatisticDetails_MMProductionCostFactor");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MminProgressStatisticDetails).HasConstraintName("FK_MMInProgressStatisticDetails_MMWorkShops");
        });

        modelBuilder.Entity<MmjobTicket>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmjobTickets).HasConstraintName("FK_MMJobTickets_BRBranchs");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.MmjobTickets).HasConstraintName("MMJobTickets_FK_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmjobTickets).HasConstraintName("FK_MMJobTickets_HREmployees");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmjobTickets).HasConstraintName("FK_MMJobTickets_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmjobTickets).HasConstraintName("FK_MMJobTickets_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmjobTickets).HasConstraintName("FK_MMJobTickets_MMWorkShops");
        });

        modelBuilder.Entity<MmjobTicketItem>(entity =>
        {
            entity.HasOne(d => d.FkMmjobTicket).WithMany(p => p.MmjobTicketItems).HasConstraintName("FK_MMJobTicketItems_MMJobTickets");

            entity.HasOne(d => d.FkMmoperationDetailPlanItemChild).WithMany(p => p.MmjobTicketItems).HasConstraintName("FK_MMJobTicketItems_MMOperationDetailPlanItemChilds");
        });

        modelBuilder.Entity<MmjobTicketItemEmployee>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmjobTicketItemEmployees).HasConstraintName("FK_MMJobTicketItemEmployees_HREmployees");

            entity.HasOne(d => d.FkMmjobTicketItem).WithMany(p => p.MmjobTicketItemEmployees).HasConstraintName("FK_MMJobTicketItemEmployees_MMJobTicketItems");
        });

        modelBuilder.Entity<MmlabourProductivityTargetConfig>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmlabourProductivityTargetConfigs).HasConstraintName("MMLabourProductivityTargetConfigs_FK_HRDepartmentID");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmlabourProductivityTargetConfigs).HasConstraintName("FK_MMLabourProductivityTargetConfigs_MMLineID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmlabourProductivityTargetConfigs).HasConstraintName("FK_MMLabourProductivityTargetConfigs_MMWorkShopID");
        });

        modelBuilder.Entity<Mmline>(entity =>
        {
            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.Mmlines).HasConstraintName("FK_MMLines_MMWorkShops");
        });

        modelBuilder.Entity<MmlineOperation>(entity =>
        {
            entity.HasOne(d => d.FkIcstock).WithMany(p => p.MmlineOperations).HasConstraintName("FK_MMLineOperations_ICStocks");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmlineOperations).HasConstraintName("FK_MMLineOperations_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmlineOperations).HasConstraintName("FK_MMLineOperations_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmlineOperations).HasConstraintName("FK_MMLineOperations_MMWorkShops");
        });

        modelBuilder.Entity<MmmachineUnit>(entity =>
        {
            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmmachineUnits).HasConstraintName("FK_MMMachineUnits_MMLines");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmmachineUnits).HasConstraintName("FK_MMMachineUnits_MMWorkShops");
        });

        modelBuilder.Entity<MmmachineUnitCapacity>(entity =>
        {
            entity.HasOne(d => d.FkMmmachineUnit).WithMany(p => p.MmmachineUnitCapacities).HasConstraintName("FK_MMMachineUnitCapacitys_MMMachineUnits");
        });

        modelBuilder.Entity<MmmachineUnitItem>(entity =>
        {
            entity.HasOne(d => d.FkMmmachineUnit).WithMany(p => p.MmmachineUnitItems).HasConstraintName("FK_MMMachineUnitItems_MMMachineUnits");
        });

        modelBuilder.Entity<MmmachineUnitOperation>(entity =>
        {
            entity.HasOne(d => d.FkMmmachineUnit).WithMany(p => p.MmmachineUnitOperations).HasConstraintName("FK_MMMachineUnitOperations_MMMachineUnits");
        });

        modelBuilder.Entity<MmmergeBomchange>(entity =>
        {
            entity.HasKey(e => e.MmmergeBomchangeId).HasName("PK_MMMergeBOMChangees");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmmergeBomchanges).HasConstraintName("FK_MMMergeBOMChanges_HREmployees");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmmergeBomchanges).HasConstraintName("FK_MMMergeBOMChanges_MMProductionNorms");
        });

        modelBuilder.Entity<MmmergeBomchangeBatchProduct>(entity =>
        {
            entity.HasKey(e => e.MmmergeBomchangeBatchProductId).HasName("PK_MMMergeBOMChangeBatchProductes");

            entity.HasOne(d => d.FkHremployeeApprove).WithMany(p => p.MmmergeBomchangeBatchProducts).HasConstraintName("FK_MMMergeBOMChangeBatchProducts_FK_HREmployeeApproveID");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmmergeBomchangeBatchProducts).HasConstraintName("FK_MMMergeBOMChangeBatchProducts_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmmergeBomchange).WithMany(p => p.MmmergeBomchangeBatchProducts).HasConstraintName("FK_MMMergeBOMChangeBatchProducts_FK_MMMergeBOMChangeID");
        });

        modelBuilder.Entity<MmmergeBomchangeItemBomlog>(entity =>
        {
            entity.HasOne(d => d.FkMmmergeBomchange).WithMany(p => p.MmmergeBomchangeItemBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemBOMLogs_FK_MMMergeBOMChangeID");
        });

        modelBuilder.Entity<MmmergeBomchangeItemBplog>(entity =>
        {
            entity.HasOne(d => d.FkMmmergeBomchange).WithMany(p => p.MmmergeBomchangeItemBplogs).HasConstraintName("FK_MMMergeBOMChangeItemBPLogs_FK_MMMergeBOMChangeID");
        });

        modelBuilder.Entity<MmmergeBomchangeItemMaterialBomlog>(entity =>
        {
            entity.HasKey(e => e.MmmergeBomchangeItemMaterialBomlogId).HasName("PK_MMMergeBOMChangeItemMaterialBOMLogIDs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmmergeBomchangeItemMaterialBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemMaterialBOMLogs_FK_ICProductID");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmmergeBomchangeItemMaterialBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemMaterialBOMLogs_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmmergeBomchange).WithMany(p => p.MmmergeBomchangeItemMaterialBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemMaterialBOMLogs_FK_MMMergeBOMChangeID");
        });

        modelBuilder.Entity<MmmergeBomchangeItemMaterialBplog>(entity =>
        {
            entity.HasKey(e => e.MmmergeBomchangeItemMaterialBplogId).HasName("PK_MMMergeBOMChangeItemMaterialBPLogIDs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmmergeBomchangeItemMaterialBplogs).HasConstraintName("FK_MMMergeBOMChangeItemMaterialBPLogs_FK_ICProductID");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmmergeBomchangeItemMaterialBplogs).HasConstraintName("FK_MMMergeBOMChangeItemMaterialBPLogs_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmmergeBomchange).WithMany(p => p.MmmergeBomchangeItemMaterialBplogs).HasConstraintName("FK_MMMergeBOMChangeItemMaterialBPLogs_FK_MMMergeBOMChangeID");
        });

        modelBuilder.Entity<MmmergeBomchangeItemProcessBomlog>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmmergeBomchangeItemProcessBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBOMLogs_FK_ICProductID");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmmergeBomchangeItemProcessBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBOMLogs_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmmergeBomchange).WithMany(p => p.MmmergeBomchangeItemProcessBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBOMLogs_FK_MMMergeBOMChangeID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmmergeBomchangeItemProcessBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBOMLogs_FK_MMOperationID");

            entity.HasOne(d => d.FkMmprocess).WithMany(p => p.MmmergeBomchangeItemProcessBomlogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBOMLogs_FK_MMProcessID");
        });

        modelBuilder.Entity<MmmergeBomchangeItemProcessBplog>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmmergeBomchangeItemProcessBplogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBPLogs_FK_ICProductID");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmmergeBomchangeItemProcessBplogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBPLogs_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmmergeBomchange).WithMany(p => p.MmmergeBomchangeItemProcessBplogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBPLogs_FK_MMMergeBOMChangeID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmmergeBomchangeItemProcessBplogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBPLogs_FK_MMOperationID");

            entity.HasOne(d => d.FkMmprocess).WithMany(p => p.MmmergeBomchangeItemProcessBplogs).HasConstraintName("FK_MMMergeBOMChangeItemProcessBPLogs_FK_MMProcessID");
        });

        modelBuilder.Entity<MmnormTemplate>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmnormTemplates).HasConstraintName("FK_MMNormTemplates_HREmployees");
        });

        modelBuilder.Entity<MmnormTemplateItem>(entity =>
        {
            entity.HasOne(d => d.FkMmnormTemplate).WithMany(p => p.MmnormTemplateItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMNormTemplateItems_MMNormTemplates");
        });

        modelBuilder.Entity<MmnormTemplateProduct>(entity =>
        {
            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmnormTemplateProducts).HasConstraintName("FK_MMNormTemplateProducts_ICProductGroups");

            entity.HasOne(d => d.FkMmnormTemplate).WithMany(p => p.MmnormTemplateProducts).HasConstraintName("FK_MMNormTemplateProducts_MMNormTemplates");
        });

        modelBuilder.Entity<Mmoperation>(entity =>
        {
            entity.HasOne(d => d.FkAcaccount).WithMany(p => p.MmoperationFkAcaccounts).HasConstraintName("FK_MMOperations_ACAccounts");

            entity.HasOne(d => d.FkAccostAccount).WithMany(p => p.MmoperationFkAccostAccounts).HasConstraintName("FK_MMOperations_ACCostAccounts");

            entity.HasOne(d => d.FkAcingrogressAccount).WithMany(p => p.MmoperationFkAcingrogressAccounts).HasConstraintName("FK_MMOperations_ACIngrogressAccounts");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Mmoperations).HasConstraintName("FK_MMOperations_BRBranchs");

            entity.HasOne(d => d.FkMmoperationSyn).WithMany(p => p.InverseFkMmoperationSyn).HasConstraintName("FK_MMOperations_MMOperationSyns");
        });

        modelBuilder.Entity<MmoperationDetailPlan>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmoperationDetailPlans).HasConstraintName("FK_MMOperationDetailPlans_BRBranchs");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.MmoperationDetailPlans).HasConstraintName("MMOperationDetailPlans_FK_HRDepartmentRoomGroupItemID");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmoperationDetailPlanFkHremployees).HasConstraintName("FK_MMOperationDetailPlans_HREmployees");

            entity.HasOne(d => d.FkHremployeeIdapprovedNavigation).WithMany(p => p.MmoperationDetailPlanFkHremployeeIdapprovedNavigations).HasConstraintName("FK_MMOperationDetailPlans_HREmployees_Approved");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmoperationDetailPlans).HasConstraintName("FK_MMOperationDetailPlans_MMLines");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.InverseFkMmoperationDetailPlan).HasConstraintName("MMOperationDetailPlans_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationDetailPlans).HasConstraintName("FK_MMOperationDetailPlans_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmoperationDetailPlans).HasConstraintName("FK_MMOperationDetailPlans_MMWorkShops");
        });

        modelBuilder.Entity<MmoperationDetailPlanCancel>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmoperationDetailPlanCancels).HasConstraintName("MMOperationDetailPlanCancels_FK_BRBranchID");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmoperationDetailPlanCancelFkHremployees).HasConstraintName("MMOperationDetailPlanCancels_FK_HREmployeeID");

            entity.HasOne(d => d.FkHremployeeIdapprovedNavigation).WithMany(p => p.MmoperationDetailPlanCancelFkHremployeeIdapprovedNavigations).HasConstraintName("MMOperationDetailPlanCancels_FK_HREmployeeIDApproved");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmoperationDetailPlanCancels).HasConstraintName("MMOperationDetailPlanCancels_FK_MMLineID");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmoperationDetailPlanCancels).HasConstraintName("MMOperationDetailPlanCancels_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationDetailPlanCancels).HasConstraintName("MMOperationDetailPlanCancels_FK_MMOperationID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmoperationDetailPlanCancels).HasConstraintName("MMOperationDetailPlanCancels_FK_MMWorkShopID");
        });

        modelBuilder.Entity<MmoperationDetailPlanCancelItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("FK_MMOperationDetailPlanCancelItems_ARSaleOrders");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmoperationDetailPlanCancelItemFkIcproductForBatches).HasConstraintName("FK_MMOperationDetailPlanCancelItems_ICProductFroBatchs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmoperationDetailPlanCancelItemFkIcproducts).HasConstraintName("FK_MMOperationDetailPlanCancelItems_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("FK_MMOperationDetailPlanCancelItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("FK_MMOperationDetailPlanCancelItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("FK_MMOperationDetailPlanCancelItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmoperationDetailPlanCancel).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("MMOperationDetailPlanCancelItems_FK_MMOperationDetailPlanCancelID");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("MMOperationDetailPlanCancelItems_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmoperationDetailPlanItemChild).WithMany(p => p.MmoperationDetailPlanCancelItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MMOperationDetailPlanCancelItems_FK_MMOperationDetailPlanItemChildID");

            entity.HasOne(d => d.FkMmoperationDetailPlanItem).WithMany(p => p.MmoperationDetailPlanCancelItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMOperationDetailPlanCancelItems_MMOperationDetailPlanItems");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("FK_MMOperationDetailPlanCancelItems_MMOperations");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("FK_MMOperationDetailPlanCancelItems_MMProductionNorms");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmoperationDetailPlanCancelItems).HasConstraintName("FK_MMOperationDetailPlanCancelItems_MMProductionNormItems");
        });

        modelBuilder.Entity<MmoperationDetailPlanCapacity>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmoperationDetailPlanCapacities).HasConstraintName("FK_MMOperationDetailPlanCapacitys_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmoperationDetailPlanCapacityFkHremployees).HasConstraintName("FK_MMOperationDetailPlanCapacitys_HREmployees");

            entity.HasOne(d => d.FkHremployeeIdapprovedNavigation).WithMany(p => p.MmoperationDetailPlanCapacityFkHremployeeIdapprovedNavigations).HasConstraintName("FK_MMOperationDetailPlanCapacitys_HREmployees_Approved");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmoperationDetailPlanCapacities).HasConstraintName("FK_MMOperationDetailPlanCapacitys_MMLines");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmoperationDetailPlanCapacities).HasConstraintName("FK_MMOperationDetailPlanCapacitys_MMOperationDetailPlans");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationDetailPlanCapacities).HasConstraintName("FK_MMOperationDetailPlanCapacitys_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmoperationDetailPlanCapacities).HasConstraintName("FK_MMOperationDetailPlanCapacitys_MMWorkShops");
        });

        modelBuilder.Entity<MmoperationDetailPlanCapacityItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmoperationDetailPlanCapacityItems).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_ARSaleOrders");

            entity.HasOne(d => d.FkHrdepartmentRoomGroupItem).WithMany(p => p.MmoperationDetailPlanCapacityItems).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_HRDepartmentRoomGroupItems");

            entity.HasOne(d => d.FkHremployeeGive).WithMany(p => p.MmoperationDetailPlanCapacityItemFkHremployeeGives).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_HREmployeeGives");

            entity.HasOne(d => d.FkHremployeeQc).WithMany(p => p.MmoperationDetailPlanCapacityItemFkHremployeeQcs).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_HREmployeeQCs");

            entity.HasOne(d => d.FkHremployeeTake).WithMany(p => p.MmoperationDetailPlanCapacityItemFkHremployeeTakes).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_HREmployeeTakes");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmoperationDetailPlanCapacityItemFkIcproductForBatches).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_ICProductFroBatchs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmoperationDetailPlanCapacityItemFkIcproducts).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmoperationDetailPlanCapacityItems).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmoperationDetailPlanCapacityItems).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_MMLines");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationDetailPlanCapacityItems).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmoperationDetailPlanCapacityItems).HasConstraintName("FK_MMOperationDetailPlanCapacityItems_MMWorkShops");
        });

        modelBuilder.Entity<MmoperationDetailPlanItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmoperationDetailPlanItems).HasConstraintName("FK_MMOperationDetailPlanItems_ARSaleOrders");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmoperationDetailPlanItems).HasConstraintName("FK_MMOperationDetailPlanItems_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmoperationDetailPlanItems).HasConstraintName("FK_MMOperationDetailPlanItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmoperationDetailPlanItems).HasConstraintName("FK_MMOperationDetailPlanItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmoperationDetailPlanItems).HasConstraintName("FK_MMOperationDetailPlanItems_MMLines");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmoperationDetailPlanItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMOperationDetailPlanItems_MMOperationDetailPlans");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationDetailPlanItems).HasConstraintName("FK_MMOperationDetailPlanItems_MMOperations");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmoperationDetailPlanItems).HasConstraintName("FK_MMOperationDetailPlanItems_MMProductionNorms");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmoperationDetailPlanItems).HasConstraintName("FK_MMOperationDetailPlanItems_MMWorkShops");
        });

        modelBuilder.Entity<MmoperationDetailPlanItemChild>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmoperationDetailPlanItemChildren).HasConstraintName("FK_MMOperationDetailPlanItemChilds_ARSaleOrders");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmoperationDetailPlanItemChildFkIcproductForBatches).HasConstraintName("FK_MMOperationDetailPlanItemChilds_ICProductFroBatchs");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmoperationDetailPlanItemChildFkIcproducts).HasConstraintName("FK_MMOperationDetailPlanItemChilds_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmoperationDetailPlanItemChildren).HasConstraintName("FK_MMOperationDetailPlanItemChilds_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmoperationDetailPlanItemChildren).HasConstraintName("FK_MMOperationDetailPlanItemChilds_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmoperationDetailPlanItemChildren).HasConstraintName("MMOperationDetailPlanItemChilds_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationDetailPlanItemChildren).HasConstraintName("FK_MMOperationDetailPlanItemChilds_MMOperations");
        });

        modelBuilder.Entity<MmoperationDetailPlanItemChildDateDetail>(entity =>
        {
            entity.HasOne(d => d.FkMmoperationDetailPlanItemChild).WithMany(p => p.MmoperationDetailPlanItemChildDateDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMOperationDetailPlanItemChildDateDetails_MMOperationDetailPlanItemChilds");
        });

        modelBuilder.Entity<MmoperationDetailPlanItemDateDetail>(entity =>
        {
            entity.HasOne(d => d.FkMmoperationDetailPlanItem).WithMany(p => p.MmoperationDetailPlanItemDateDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMOperationDetailPlanItemDateDetails_MMOperationDetailPlanItems");
        });

        modelBuilder.Entity<MmoperationMachineGroup>(entity =>
        {
            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationMachineGroups).HasConstraintName("FK_MMOperationMachineGroups_MMOperations");
        });

        modelBuilder.Entity<MmoperationProduct>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmoperationProducts).HasConstraintName("FK_MMOperationProducts_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmoperationProducts).HasConstraintName("FK_MMOperationProducts_MMOperations");
        });

        modelBuilder.Entity<MmoverallInsideDimensionConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttributePackingMaterialSpeciality).WithMany(p => p.MmoverallInsideDimensionConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMOverallInsideDimensionConfigs_ICProductAttributes");
        });

        modelBuilder.Entity<MmpaintProcessConfig>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmpaintProcessConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMPaintProcessConfigs_HREmployees");
        });

        modelBuilder.Entity<MmpaintProcessConfigItem>(entity =>
        {
            entity.HasOne(d => d.FkMmformulaIdpaintANavigation).WithMany(p => p.MmpaintProcessConfigItemFkMmformulaIdpaintANavigations).HasConstraintName("FK_MMPaintProcessConfigItems_MMFormulasA");

            entity.HasOne(d => d.FkMmformulaIdpaintBNavigation).WithMany(p => p.MmpaintProcessConfigItemFkMmformulaIdpaintBNavigations).HasConstraintName("FK_MMPaintProcessConfigItems_MMFormulasB");

            entity.HasOne(d => d.FkMmformulaIdpaintCNavigation).WithMany(p => p.MmpaintProcessConfigItemFkMmformulaIdpaintCNavigations).HasConstraintName("FK_MMPaintProcessConfigItems_MMFormulasC");

            entity.HasOne(d => d.FkMmpaintProcessConfig).WithMany(p => p.MmpaintProcessConfigItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMPaintProcessConfigItems_MMPaintProcessConfigs");
        });

        modelBuilder.Entity<MmpaintProcessesItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmpaintProcessesItems).HasConstraintName("FK_MMPaintProcessesItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmpaintProcessesItems).HasConstraintName("FK_MMPaintProcessesItems_ICProducts");

            entity.HasOne(d => d.FkMmpaintProcesses).WithMany(p => p.MmpaintProcessesItems).HasConstraintName("FK_MMPaintProcessesItems_MMPaintProcessess");
        });

        modelBuilder.Entity<MmpaintProcessess>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.MmpaintProcessesses).HasConstraintName("FK_MMPaintProcessess_APSuppliers");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmpaintProcessesses).HasConstraintName("FK_MMPaintProcessess_ARCustomers");

            entity.HasOne(d => d.FkIcproductAttributeColor).WithMany(p => p.MmpaintProcessessFkIcproductAttributeColors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMPaintProcessess_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductAttributeHt).WithMany(p => p.MmpaintProcessessFkIcproductAttributeHts).HasConstraintName("FK_MMPaintProcessess_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmpaintProcessesses).HasConstraintName("FK_MMPaintProcessess_ICProductGroups");
        });

        modelBuilder.Entity<MmprintRouting>(entity =>
        {
            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmprintRoutingFkIcproductForBatches).HasConstraintName("MMPrintRoutings_FK_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmprintRoutingFkIcproducts).HasConstraintName("MMPrintRoutings_FK_ICProductID");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmprintRoutings).HasConstraintName("MMPrintRoutings_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmprintRoutings).HasConstraintName("MMPrintRoutings_FK_MMOperationID");
        });

        modelBuilder.Entity<MmprocessChange>(entity =>
        {
            entity.HasKey(e => e.MmprocessChangeId).HasName("PK_MMProcessChangees");

            entity.HasOne(d => d.FkMmchangeBominformationItem).WithMany(p => p.MmprocessChanges).HasConstraintName("FK_MMProcessChangees_MMChangeBOMInformationItems");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmprocessChanges).HasConstraintName("FK_MMProcessChanges_MMProductionNormItems");
        });

        modelBuilder.Entity<MmprocessChangeDetail>(entity =>
        {
            entity.HasKey(e => e.MmprocessChangeDetailId).HasName("PK_MMProcessChangeDetailes");

            entity.HasOne(d => d.FkMmchangeBominformationItem).WithMany(p => p.MmprocessChangeDetails).HasConstraintName("FK_MMProcessChangeDetails_MMChangeBOMInformationItems");
        });

        modelBuilder.Entity<MmprocessChangeItem>(entity =>
        {
            entity.HasKey(e => e.MmprocessChangeItemId).HasName("PK_MMProcessChangeItemes");

            entity.HasOne(d => d.FkMmchangeBominformationItem).WithMany(p => p.MmprocessChangeItems).HasConstraintName("FK_MMProcessChangeItemes_MMChangeBOMInformationItems");
        });

        modelBuilder.Entity<MmprocessInfo>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmprocessInfos).HasConstraintName("FK_MMProcessInfos_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeItem).WithMany(p => p.MmprocessInfos).HasConstraintName("FK_MMProcessInfos_ICProductAttributeItems");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmprocessInfos).HasConstraintName("FK_MMProcessInfos_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmprocessInfos).HasConstraintName("FK_MMProcessInfos_MMOperations");
        });

        modelBuilder.Entity<MmprocessProduct>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmprocessProducts).HasConstraintName("FK_MMProcessProducts_ICProducts");

            entity.HasOne(d => d.FkMmprocess).WithMany(p => p.MmprocessProducts).HasConstraintName("FK_MMProcessProducts_MMProcesss");
        });

        modelBuilder.Entity<Mmprocesss>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Mmprocessses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProcesss_HREmployees");
        });

        modelBuilder.Entity<MmproductGroupTypeSwitchingConfig>(entity =>
        {
            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductGroupTypeSwitchingConfigs).HasConstraintName("MMProductGroupTypeSwitchingConfigs_FK_MMOperationID");
        });

        modelBuilder.Entity<MmproductPrice>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_ARSaleOrders");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_ICProductGroups");

            entity.HasOne(d => d.FkIcproductIdforBatchNavigation).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_ICProducts");

            entity.HasOne(d => d.FkIcproductSerie).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_ICProductSeries");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductPrices_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_MMOperations");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductPrices_MMProductionCosts");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_MMProductionNorms");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmproductPrices).HasConstraintName("FK_MMProductPrices_MMProposals");
        });

        modelBuilder.Entity<MmproductPriceIncomplete>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductPriceIncompletes).HasConstraintName("FK_MMProductPriceIncompletes_ARSaleOrders");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmproductPriceIncompletes).HasConstraintName("FK_MMProductPriceIncompletes_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductPriceIncompletes).HasConstraintName("FK_MMProductPriceIncompletes_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductPriceIncompletes).HasConstraintName("FK_MMProductPriceIncompletes_ICProductGroups");

            entity.HasOne(d => d.FkIcproductIdforBatchNavigation).WithMany(p => p.MmproductPriceIncompletes).HasConstraintName("FK_MMProductPriceIncompletes_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductPriceIncompletes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductPriceIncompletes_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductPriceIncompletes).HasConstraintName("FK_MMProductPriceIncompletes_MMOperations");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductPriceIncompletes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductPriceIncompletes_MMProductionCosts");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductPriceIncompletes).HasConstraintName("FK_MMProductPriceIncompletes_MMProductionNorms");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmproductPriceIncompletes).HasConstraintName("FK_MMProductPriceIncompletes_MMProposals");
        });

        modelBuilder.Entity<MmproductionCompletionTimeConfig>(entity =>
        {
            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCompletionTimeConfigs).HasConstraintName("FK_MMProductionCompletionTimeConfigs_MMOperations");
        });

        modelBuilder.Entity<MmproductionComplexityByOperation>(entity =>
        {
            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionComplexityByOperations).HasConstraintName("FK_MMProductionComplexityByOperations_MMOperations");
        });

        modelBuilder.Entity<MmproductionCostCalculation>(entity =>
        {
            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostCalculations).HasConstraintName("FK_MMProductionCostCalculations_MMOperations");

            entity.HasOne(d => d.FkMmproductionCostFormula).WithMany(p => p.MmproductionCostCalculations).HasConstraintName("FK_MMProductionCostCalculations_MMProductionCostFormula");
        });

        modelBuilder.Entity<MmproductionCostCalculationAllocation>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_ARSaleOrder");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_HRDepartment");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_ICProductGroup");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_ICProduct");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_MMBatchProduct");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostCalculation).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_MMProductionCostCalculation");

            entity.HasOne(d => d.FkMmproductionCostFactor).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_MMProductionCostFactor");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_MMWorkShops");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.MmproductionCostCalculationAllocations).HasConstraintName("FK_MMProductionCostCalculationAllocations_PMProject");
        });

        modelBuilder.Entity<MmproductionCostCalculationDetailCost>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductionCostCalculationDetailCosts).HasConstraintName("FK_MMProductionCostCalculationDetailCosts_ARSaleOrder");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductionCostCalculationDetailCosts).HasConstraintName("FK_MMProductionCostCalculationDetailCosts_ICProductGroup");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionCostCalculationDetailCosts).HasConstraintName("FK_MMProductionCostCalculationDetailCosts_ICProduct");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostCalculationDetailCosts).HasConstraintName("FK_MMProductionCostCalculationDetailCosts_MMBatchProduct");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostCalculationDetailCosts).HasConstraintName("FK_MMProductionCostCalculationDetailCosts_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostCalculation).WithMany(p => p.MmproductionCostCalculationDetailCosts).HasConstraintName("FK_MMProductionCostCalculationDetailCosts_MMProductionCostCalculation");

            entity.HasOne(d => d.FkMmproductionCostFactor).WithMany(p => p.MmproductionCostCalculationDetailCosts).HasConstraintName("FK_MMProductionCostCalculationDetailCosts_MMProductionCostFactor");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmproductionCostCalculationDetailCosts).HasConstraintName("FK_MMProductionCostCalculationDetailCosts_MMWorkShops");
        });

        modelBuilder.Entity<MmproductionCostCalculationItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_ARSaleOrder");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_HRDepartment");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_ICProductGroup");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_ICProduct");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_MMBatchProduct");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostCalculation).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_MMProductionCostCalculation");

            entity.HasOne(d => d.FkMmproductionCostFactor).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_MMProductionCostFactor");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_MMWorkShops");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.MmproductionCostCalculationItems).HasConstraintName("FK_MMProductionCostCalculationItems_PMProject");
        });

        modelBuilder.Entity<MmproductionCostCalculationPrice>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_ARSaleOrder");

            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_HRDepartment");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_ICProductGroup");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_ICProduct");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_MMBatchProduct");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostCalculation).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_MMProductionCostCalculation");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_MMWorkShopID");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.MmproductionCostCalculationPrices).HasConstraintName("FK_MMProductionCostCalculationPrices_PMProject");
        });

        modelBuilder.Entity<MmproductionCostDirectLaborCost>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_ARSaleOrders");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_HREmployees");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionCostDirectLaborCostFkIcproducts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_ICProducts");

            entity.HasOne(d => d.FkIcproductIdforBatchNavigation).WithMany(p => p.MmproductionCostDirectLaborCostFkIcproductIdforBatchNavigations).HasConstraintName("FK_MMProductionCostDirectLaborCosts_ICProducts1");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_ICStocks");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_MMOperations");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_MMProductionCosts");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_MMProductionNorms");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmproductionCostDirectLaborCosts).HasConstraintName("FK_MMProductionCostDirectLaborCosts_MMProposals");
        });

        modelBuilder.Entity<MmproductionCostFactor>(entity =>
        {
            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.MmproductionCostFactorFkAccreditAccounts).HasConstraintName("FK_MMProductionCostFactors_ACCreditAccount");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.MmproductionCostFactorFkAcdebitAccounts).HasConstraintName("FK_MMProductionCostFactors_ACDebitAccount");

            entity.HasOne(d => d.FkAcinProgressAccount).WithMany(p => p.MmproductionCostFactorFkAcinProgressAccounts).HasConstraintName("FK_MMProductionCostFactors_ACInProgressAccount");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostFactors).HasConstraintName("FK_MMProductionCostFactors_MMOperations");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmproductionCostFactors).HasConstraintName("FK_MMProductionCostFactors_MMWorkShops");
        });

        modelBuilder.Entity<MmproductionCostFactorAllocationRate>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmproductionCostFactorAllocationRates).HasConstraintName("FK_MMProductionCostFactorAllocationRates_HRDepartment");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostFactorAllocationRates).HasConstraintName("FK_MMProductionCostFactorAllocationRates_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostFactor).WithMany(p => p.MmproductionCostFactorAllocationRates).HasConstraintName("FK_MMProductionCostFactorAllocationRates_MMProductionCostFactor");
        });

        modelBuilder.Entity<MmproductionCostFormulaDetail>(entity =>
        {
            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.MmproductionCostFormulaDetailFkAccreditAccounts).HasConstraintName("FK_MMProductionCostFormulaDetails_ACCreditAccount");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.MmproductionCostFormulaDetailFkAcdebitAccounts).HasConstraintName("FK_MMProductionCostFormulaDetails_ACDebitAccount");

            entity.HasOne(d => d.FkAcinProgressAccount).WithMany(p => p.MmproductionCostFormulaDetailFkAcinProgressAccounts).HasConstraintName("FK_MMProductionCostFormulaDetails_ACInProgressAccount");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostFormulaDetails).HasConstraintName("FK_MMProductionCostFormulaDetails_MMOperations");

            entity.HasOne(d => d.FkMmproductionCostFactorGroup).WithMany(p => p.MmproductionCostFormulaDetails).HasConstraintName("FK_MMProductionCostFormulaDetails_MMProductionCostFactorGroup");

            entity.HasOne(d => d.FkMmproductionCostFactor).WithMany(p => p.MmproductionCostFormulaDetailFkMmproductionCostFactors).HasConstraintName("FK_MMProductionCostFormulaDetails_MMProductionCostFactor");

            entity.HasOne(d => d.FkMmproductionCostFormula).WithMany(p => p.MmproductionCostFormulaDetails).HasConstraintName("FK_MMProductionCostFormulaDetails_MMProductionCostFormula");

            entity.HasOne(d => d.FkMmrefProductionCostFactor).WithMany(p => p.MmproductionCostFormulaDetailFkMmrefProductionCostFactors).HasConstraintName("FK_MMProductionCostFormulaDetails_MMRefProductionCostFactor");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmproductionCostFormulaDetails).HasConstraintName("FK_MMProductionCostFormulaDetails_MMWorkShops");
        });

        modelBuilder.Entity<MmproductionCostFormulaOperation>(entity =>
        {
            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostFormulaOperations).HasConstraintName("FK_MMProductionCostFormulaOperations_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostFormula).WithMany(p => p.MmproductionCostFormulaOperations).HasConstraintName("FK_MMProductionCostFormulaOperations_MMProductionCostFormula");
        });

        modelBuilder.Entity<MmproductionCostFormulaOperationItem>(entity =>
        {
            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostFormulaOperationItems).HasConstraintName("FK_MMProductionCostFormulaOperationItems_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostFormula).WithMany(p => p.MmproductionCostFormulaOperationItems).HasConstraintName("FK_MMProductionCostFormulaOperationItems_MMProductionCostFormula");
        });

        modelBuilder.Entity<MmproductionCostFormulaProduct>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmproductionCostFormulaProducts).HasConstraintName("FK_MMProductionCostFormulaProducts_ICDepartments");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductionCostFormulaProducts).HasConstraintName("FK_MMProductionCostFormulaProducts_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionCostFormulaProducts).HasConstraintName("FK_MMProductionCostFormulaProducts_ICProduct");

            entity.HasOne(d => d.FkMmproductionCostFormula).WithMany(p => p.MmproductionCostFormulaProducts).HasConstraintName("FK_MMProductionCostFormulaProducts_MMProductionCostFormula");
        });

        modelBuilder.Entity<MmproductionCostGeneralCostAllocation>(entity =>
        {
            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.MmproductionCostGeneralCostAllocationFkAccreditAccounts).HasConstraintName("FK_MMProductionCostGeneralCostAllocations_ACCreditAccount");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.MmproductionCostGeneralCostAllocationFkAcdebitAccounts).HasConstraintName("FK_MMProductionCostGeneralCostAllocations_ACDebitAccount");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmproductionCostGeneralCostAllocations).HasConstraintName("FK_MMProductionCostGeneralCostAllocations_BRBranchs");

            entity.HasOne(d => d.FkMmproductionCostFactor).WithMany(p => p.MmproductionCostGeneralCostAllocations).HasConstraintName("FK_MMProductionCostGeneralCostAllocations_MMProductionCostFactor");
        });

        modelBuilder.Entity<MmproductionCostGeneralCostAllocationCollectDocument>(entity =>
        {
            entity.HasOne(d => d.FkAcactualCostBudgetDetail).WithMany(p => p.MmproductionCostGeneralCostAllocationCollectDocuments).HasConstraintName("FK_MMProductionCostGeneralCostAllocationCollectDocuments_ACActualCostBudgetDetail");

            entity.HasOne(d => d.FkMmproductionCostGeneralCostAllocation).WithMany(p => p.MmproductionCostGeneralCostAllocationCollectDocuments).HasConstraintName("FK_MMProductionCostGeneralCostAllocationCollectDocuments_MMProductionCostGeneralCostAllocation");
        });

        modelBuilder.Entity<MmproductionCostGeneralCostAllocationDetail>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmproductionCostGeneralCostAllocationDetails).HasConstraintName("FK_MMProductionCostGeneralCostAllocationDetails_HRDepartment");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostGeneralCostAllocationDetails).HasConstraintName("FK_MMProductionCostGeneralCostAllocationDetails_MMOperation");

            entity.HasOne(d => d.FkMmproductionCostGeneralCostAllocation).WithMany(p => p.MmproductionCostGeneralCostAllocationDetails).HasConstraintName("FK_MMProductionCostGeneralCostAllocationDetails_MMProductionCostGeneralCostAllocation");
        });

        modelBuilder.Entity<MmproductionCostIngredientCost>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCosts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCosts_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostDd>(entity =>
        {
            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostIngredientCostDds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostDDs_MMBatchProducts");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostDds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostDDs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostDddg>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostDddgs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostDDDGs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostDdlr>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostDdlrs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostDDLRs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostDdsc>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostDdscs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostDDSCs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostDdson>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostDdsons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostDDSons_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostDdtc>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostDdtcs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostDDTCs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostDg>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostDgs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostDGs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostLr>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostLrs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostLRs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostSc>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostScs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostSCs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostSon>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostSons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostSons_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostIngredientCostTc>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostIngredientCostTcs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostIngredientCostTCs_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductionCostItems).HasConstraintName("FK_MMProductionCostItems_ARSaleOrders");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmproductionCostItems).HasConstraintName("FK_MMProductionCostItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductionCostItems).HasConstraintName("FK_MMProductionCostItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproductionCostItems).HasConstraintName("FK_MMProductionCostItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproductIdforBatchNavigation).WithMany(p => p.MmproductionCostItems).HasConstraintName("FK_MMProductionCostItems_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostItems).HasConstraintName("FK_MMProductionCostItems_MMOperations");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostItems_MMProductionCosts");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductionCostItems).HasConstraintName("FK_MMProductionCostItems_MMProductionNorms");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmproductionCostItems).HasConstraintName("FK_MMProductionCostItems_MMProposals");
        });

        modelBuilder.Entity<MmproductionCostOtherFee>(entity =>
        {
            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostOtherFees).HasConstraintName("FK_MMProductionCostOtherFees_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostOtherFees).HasConstraintName("FK_MMProductionCostOtherFees_MMOperations");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostOtherFees).HasConstraintName("FK_MMProductionCostOtherFees_MMProductionCosts");
        });

        modelBuilder.Entity<MmproductionCostOverall>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductionCostOveralls).HasConstraintName("FK_MMProductionCostOveralls_ARSaleOrders");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionCostOveralls).HasConstraintName("FK_MMProductionCostOveralls_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmproductionCostOveralls).HasConstraintName("FK_MMProductionCostOveralls_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionCostOveralls).HasConstraintName("FK_MMProductionCostOveralls_MMOperations");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmproductionCostOveralls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionCostOveralls_MMProductionCosts");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductionCostOveralls).HasConstraintName("FK_MMProductionCostOveralls_MMProductionNorms");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmproductionCostOveralls).HasConstraintName("FK_MMProductionCostOveralls_MMProposals");
        });

        modelBuilder.Entity<MmproductionNorm>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproductionNorms).HasConstraintName("FK_MMProductionNorms_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.MmproductionNorms).HasConstraintName("FK_MMProductionNorms_ARSaleOrderItems");

            entity.HasOne(d => d.FkHremployeeEquipmentValidateNavigation).WithMany(p => p.MmproductionNormFkHremployeeEquipmentValidateNavigations).HasConstraintName("FK_MMProductionNorms_FK_HREmployees_EquipmentValidate");

            entity.HasOne(d => d.FkHremployeeHardwareApproveNavigation).WithMany(p => p.MmproductionNormFkHremployeeHardwareApproveNavigations).HasConstraintName("FK_MMProductionNorms_FK_HREmployees_HardwareApprove");

            entity.HasOne(d => d.FkHremployeeHardwareValidateNavigation).WithMany(p => p.MmproductionNormFkHremployeeHardwareValidateNavigations).HasConstraintName("FK_MMProductionNorms_FK_HREmployees_HardwareValidate");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmproductionNormFkHremployees).HasConstraintName("FK_MMProductionNorms_HREmployees");

            entity.HasOne(d => d.FkHremployeeOperationApproveNavigation).WithMany(p => p.MmproductionNormFkHremployeeOperationApproveNavigations).HasConstraintName("FK_MMProductionNorms_FK_HREmployees_OperationApprove");

            entity.HasOne(d => d.FkHremployeeOperationValidateNavigation).WithMany(p => p.MmproductionNormFkHremployeeOperationValidateNavigations).HasConstraintName("FK_MMProductionNorms_FK_HREmployees_OperationValidate");

            entity.HasOne(d => d.FkHremployeePackingMaterialApproveNavigation).WithMany(p => p.MmproductionNormFkHremployeePackingMaterialApproveNavigations).HasConstraintName("FK_MMProductionNorms_HREmployees_PackingMaterialApprove");

            entity.HasOne(d => d.FkHremployeePackingMaterialValidateNavigation).WithMany(p => p.MmproductionNormFkHremployeePackingMaterialValidateNavigations).HasConstraintName("FK_MMProductionNorms_HREmployees_PackingMaterialValidate");

            entity.HasOne(d => d.FkHremployeePaintApproveNavigation).WithMany(p => p.MmproductionNormFkHremployeePaintApproveNavigations).HasConstraintName("FK_MMProductionNorms_HREmployees_PaintApproves");

            entity.HasOne(d => d.FkHremployeePaintValidateNavigation).WithMany(p => p.MmproductionNormFkHremployeePaintValidateNavigations).HasConstraintName("FK_MMProductionNorms_HREmployees_PaintValidates");

            entity.HasOne(d => d.FkHremployeeWoodApproveNavigation).WithMany(p => p.MmproductionNormFkHremployeeWoodApproveNavigations).HasConstraintName("FK_MMProductionNorms_HREmployees_WoodApprove");

            entity.HasOne(d => d.FkHremployeeWoodValidateNavigation).WithMany(p => p.MmproductionNormFkHremployeeWoodValidateNavigations).HasConstraintName("FK_MMProductionNorms_HREmployees_WoodValidate");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionNorms).HasConstraintName("FK_MMProductionNorms_ICProducts");
        });

        modelBuilder.Entity<MmproductionNormCostFactor>(entity =>
        {
            entity.HasOne(d => d.FkAccreditAccount).WithMany(p => p.MmproductionNormCostFactorFkAccreditAccounts).HasConstraintName("MMProductionNormCostFactors_FK_ACCreditAccountID");

            entity.HasOne(d => d.FkAcdebitAccount).WithMany(p => p.MmproductionNormCostFactorFkAcdebitAccounts).HasConstraintName("MMProductionNormCostFactors_FK_ACDebitAccountID");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductionNormCostFactors).HasConstraintName("FK_MMProductionNormCostFactors_ICMeasureUnits");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionNormCostFactors).HasConstraintName("MMProductionNormCostFactors_FK_MMOperationID");

            entity.HasOne(d => d.FkMmproductionNormFactor).WithMany(p => p.MmproductionNormCostFactors).HasConstraintName("MMProductionNormCostFactors_FK_MMProductionNormFactorID");
        });

        modelBuilder.Entity<MmproductionNormItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductionNormItems).HasConstraintName("FK_MMProductionNormItems_ICMeasureUnits");

            entity.HasOne(d => d.FkMmpaintProcesses).WithMany(p => p.MmproductionNormItems).HasConstraintName("FK_MMProductionNormItems_MMPaintProcessess");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductionNormItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionNormItems_MMProductionNorms");
        });

        modelBuilder.Entity<MmproductionNormItemConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.MmproductionNormItemConfigs).HasConstraintName("FK_MMProductionNormItemConfigs_ICProductAttributes");
        });

        modelBuilder.Entity<MmproductionNormItemEquipment>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductionNormItemEquipments).HasConstraintName("FK_MMProductionNormItemEquipments_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAlternative).WithMany(p => p.MmproductionNormItemEquipmentFkIcproductAlternatives).HasConstraintName("FK_MMProductionNormItemEquipments_ICProductAlternatives");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionNormItemEquipmentFkIcproducts).HasConstraintName("FK_MMProductionNormItemEquipments_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionNormItemEquipments).HasConstraintName("FK_MMProductionNormItemEquipments_MMOperations");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmproductionNormItemEquipments).HasConstraintName("FK_MMProductionNormItemEquipments_MMProductionNormItems");
        });

        modelBuilder.Entity<MmproductionNormItemHardware>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductionNormItemHardwares).HasConstraintName("FK_MMProductionNormItemHardwares_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAlternative).WithMany(p => p.MmproductionNormItemHardwareFkIcproductAlternatives).HasConstraintName("FK_MMProductionNormItemHardwares_ICProductAlternatives");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionNormItemHardwareFkIcproducts).HasConstraintName("FK_MMProductionNormItemHardwares_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionNormItemHardwares).HasConstraintName("FK_MMProductionNormItemHardwares_MMOperations");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmproductionNormItemHardwares).HasConstraintName("FK_MMProductionNormItemHardwares_MMProductionNormItems");
        });

        modelBuilder.Entity<MmproductionNormItemMeterial>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproductionNormItemMeterials).HasConstraintName("FK_MMProductionNormItemMeterials_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAlternative).WithMany(p => p.MmproductionNormItemMeterialFkIcproductAlternatives).HasConstraintName("FK_MMProductionNormItemMeterials_ICProductAlternatives");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionNormItemMeterialFkIcproducts).HasConstraintName("FK_MMProductionNormItemMeterials_ICProducts");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmproductionNormItemMeterials).HasConstraintName("FK_MMProductionNormItemMeterials_MMProductionNormItems");
        });

        modelBuilder.Entity<MmproductionNormItemOperation>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproductionNormItemOperations).HasConstraintName("FK_MMProductionNormItemOperations_ICProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmproductionNormItemOperations).HasConstraintName("FK_MMProductionNormItemOperations_MMOperations");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductionNormItemOperations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionNormItemOperations_MMProductionNorms");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmproductionNormItemOperations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionNormItemOperations_MMProductionNormItems");
        });

        modelBuilder.Entity<MmproductionNormItemPacking>(entity =>
        {
            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductionNormItemPackings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProductionNormItemPackings_MMProductionNorms");
        });

        modelBuilder.Entity<MmproductionNormItemPaint>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttribute).WithMany(p => p.MmproductionNormItemPaints).HasConstraintName("FK_MMProductionNormItemPaints_ICProductAttributes");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmproductionNormItemPaintFkMmproductionNorms).HasConstraintName("FK_MMProductionNormItemPaints_MMProductionNorms");

            entity.HasOne(d => d.FkMmproductionNormItem).WithMany(p => p.MmproductionNormItemPaintFkMmproductionNormItems).HasConstraintName("FK_MMProductionNormItemPaints_MMProductionNormItems");
        });

        modelBuilder.Entity<MmprofileManagementItem>(entity =>
        {
            entity.HasKey(e => e.MmprofileManagementItemId).HasName("PK_MMProfileManagementItems_1");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmprofileManagementItems).HasConstraintName("FK_MMProfileManagementItems_HREmployees");

            entity.HasOne(d => d.FkMmproductionNorm).WithMany(p => p.MmprofileManagementItems).HasConstraintName("FK_MMProfileManagementItems_MMProductionNorms");
        });

        modelBuilder.Entity<Mmproposal>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Mmproposals).HasConstraintName("FK_MMProposals_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.Mmproposals).HasConstraintName("FK_MMProposals_FK_ARSaleOrderID");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Mmproposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProposals_BRBranchs");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.Mmproposals).HasConstraintName("FK_MMProposals_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.Mmproposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProposals_HREmployees");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.Mmproposals).HasConstraintName("FK_MMProposals_ICProductAttributes");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.Mmproposals).HasConstraintName("FK_MMProposals_MMOperations");
        });

        modelBuilder.Entity<MmproposalItem>(entity =>
        {
            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmproposalItems).HasConstraintName("FK_MMProposalItem_ARSaleOrder");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.MmproposalItems).HasConstraintName("FK_MMProposalItems_ARSaleOrderItem");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmproposalItems).HasConstraintName("FK_MMProposalItems_BRBranchs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeColor).WithMany(p => p.MmproposalItemFkIcproductAttributeColors).HasConstraintName("FK_MMProposalItems_ICProductAttributes3");

            entity.HasOne(d => d.FkIcproductAttributeHttype).WithMany(p => p.MmproposalItemFkIcproductAttributeHttypes).HasConstraintName("FK_MMProposalItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmproposalItemFkIcproductAttributeQualities).HasConstraintName("FK_MMProposalItems_ICProductAttributes5");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmproposalItemFkIcproductAttributeTtmts).HasConstraintName("FK_MMProposalItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmproposalItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMProposalItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProposalItems_ICProducts");

            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmproposalItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProposalItems_MMProposals");
        });

        modelBuilder.Entity<MmproposalTemplate>(entity =>
        {
            entity.HasOne(d => d.FkMmproposal).WithMany(p => p.MmproposalTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMProposalTemplates_MMProposals");
        });

        modelBuilder.Entity<MmpurchasePlan>(entity =>
        {
            entity.HasKey(e => e.MmpurchasePlanId).HasName("PK_MMPurchasePlanes");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmpurchasePlans).HasConstraintName("FK_MMPurchasePlans_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmpurchasePlans).HasConstraintName("FK_MMPurchasePlans_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmpurchasePlans).HasConstraintName("FK_MMPurchasePlans_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApprovedNavigation).WithMany(p => p.MmpurchasePlanFkHremployeeApprovedNavigations).HasConstraintName("FK_MMPurchasePlans_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmpurchasePlanFkHremployees).HasConstraintName("FK_MMPurchasePlans_HREmployees");

            entity.HasOne(d => d.FkHremployeeValidatedNavigation).WithMany(p => p.MmpurchasePlanFkHremployeeValidatedNavigations).HasConstraintName("FK_MMPurchasePlans_HREmployeeValidateds");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmpurchasePlans).HasConstraintName("FK_MMPurchasePlans_ICProductAttributes");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmpurchasePlans).HasConstraintName("FK_MMPurchasePlans_MMBatchProducts");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmpurchasePlans).HasConstraintName("FK_MMPurchasePlans_MMWoodPlans");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmpurchasePlans).HasConstraintName("FK_MMPurchasePlans_MMWorkShops");
        });

        modelBuilder.Entity<MmpurchasePlanInPutItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmpurchasePlanInPutItems).HasConstraintName("FK_MMPurchasePlanInPutItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmpurchasePlanInPutItemFkIcproductAttributeQualities).HasConstraintName("FK_MMPurchasePlanInPutItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmpurchasePlanInPutItemFkIcproductAttributeTtmts).HasConstraintName("FK_MMPurchasePlanInPutItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmpurchasePlanInPutItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMPurchasePlanInPutItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmpurchasePlanInPutItemFkIcproductForBatches).HasConstraintName("FK_MMPurchasePlanInPutItems_ICProducts_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmpurchasePlanInPutItemFkIcproducts).HasConstraintName("FK_MMPurchasePlanInPutItems_ICProducts1");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmpurchasePlanInPutItems).HasConstraintName("FK_MMPurchasePlanInPutItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.MmpurchasePlanInPutItemFkMmfromOperations).HasConstraintName("FK_MMPurchasePlanInPutItems_MMOperations1");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.MmpurchasePlanInPutItems).HasConstraintName("FK_MMPurchasePlanInPutItems_MMBatchProductPlans");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.MmpurchasePlanInPutItemFkMmtoOperations).HasConstraintName("FK_MMPurchasePlanInPutItems_MMOperations2");
        });

        modelBuilder.Entity<MmpurchasePlanItem>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("FK_MMPurchasePlanItems_APSuppliers");

            entity.HasOne(d => d.FkIcbpmeasureUnit).WithMany(p => p.MmpurchasePlanItemFkIcbpmeasureUnits).HasConstraintName("FK_MMPurchasePlanItems_ICMeasureUnits1");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmpurchasePlanItemFkIcmeasureUnits).HasConstraintName("FK_MMPurchasePlanItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmpurchasePlanItemFkIcproductAttributeQualities).HasConstraintName("FK_MMPurchasePlanItems_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmpurchasePlanItemFkIcproductAttributeTtmts).HasConstraintName("FK_MMPurchasePlanItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmpurchasePlanItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMPurchasePlanItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmpurchasePlanItemFkIcproductForBatches).HasConstraintName("FK_MMPurchasePlanItems_ICProducts_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmpurchasePlanItemFkIcproducts).HasConstraintName("FK_ICProducts_MMPurchasePlanItems");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("FK_MMPurchasePlanItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("FK_MMPurchasePlanItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("FK_MMPurchasePlanItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.MmpurchasePlanItemFkMmfromOperations).HasConstraintName("FK_MMPurchasePlanItems_MMOperations1");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("MMPurchasePlanItems_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("FK_MMPurchasePlanItems_MMBatchProductPlans");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.MmpurchasePlanItemFkMmtoOperations).HasConstraintName("FK_MMPurchasePlanItems_MMOperations2");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("FK_MMPurchasePlanItems_MMWoodPlans");

            entity.HasOne(d => d.FkMmwoodPlanItemDetail).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("FK_MMPurchasePlanItems_MMWoodPlanItemDetails");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmpurchasePlanItems).HasConstraintName("FK_MMPurchasePlanItems_MMWorkShops");
        });

        modelBuilder.Entity<MmpurchasePlanItemTotal>(entity =>
        {
            entity.HasOne(d => d.FkApsupplier).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("FK_MMPurchasePlanItemTotals_APSuppliers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("FK_MMPurchasePlanItemTotals_ARSaleOrders");

            entity.HasOne(d => d.FkIcbpmeasureUnit).WithMany(p => p.MmpurchasePlanItemTotalFkIcbpmeasureUnits).HasConstraintName("FK_MMPurchasePlanItemTotals_ICMeasureUnits1");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmpurchasePlanItemTotalFkIcmeasureUnits).HasConstraintName("FK_MMPurchasePlanItemTotals_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmpurchasePlanItemTotalFkIcproductAttributeQualities).HasConstraintName("FK_MMPurchasePlanItemTotals_ICProductAttributes4");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmpurchasePlanItemTotalFkIcproductAttributeTtmts).HasConstraintName("FK_MMPurchasePlanItemTotals_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmpurchasePlanItemTotalFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMPurchasePlanItemTotals_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmpurchasePlanItemTotalFkIcproductForBatches).HasConstraintName("FK_MMPurchasePlanItemTotals_ICProducts_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmpurchasePlanItemTotalFkIcproducts).HasConstraintName("FK_MMPurchasePlanItemTotals_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("FK_MMPurchasePlanItemTotals_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("FK_MMPurchasePlanItemTotals_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("FK_MMPurchasePlanItemTotals_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmfromOperation).WithMany(p => p.MmpurchasePlanItemTotalFkMmfromOperations).HasConstraintName("FK_MMPurchasePlanItemTotals_MMOperations1");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("MMPurchasePlanItemTotals_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmoperationDetailPlanItemChild).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("MMPurchasePlanItemTotals_FK_MMOperationDetailPlanItemChildID");

            entity.HasOne(d => d.FkMmoperationDetailPlanItem).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("MMPurchasePlanItemTotals_FK_MMOperationDetailPlanItemID");

            entity.HasOne(d => d.FkMmpurchasePlan).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("FK_MMPurchasePlanItemTotals_MMBatchProductPlans");

            entity.HasOne(d => d.FkMmtoOperation).WithMany(p => p.MmpurchasePlanItemTotalFkMmtoOperations).HasConstraintName("FK_MMPurchasePlanItemTotals_MMOperations2");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("FK_MMPurchasePlanItemTotals_MMWoodPlans");

            entity.HasOne(d => d.FkMmwoodPlanItemDetail).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("FK_MMPurchasePlanItemTotals_MMWoodPlanItemDetails");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmpurchasePlanItemTotals).HasConstraintName("MMPurchasePlanItemTotals_MMWorkShops");
        });

        modelBuilder.Entity<MmpurchasePlanTracking>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmpurchasePlanTrackingFkIcproducts).HasConstraintName("FK_MMPurchasePlanTrackings_ICProducts");

            entity.HasOne(d => d.FkIcsemiProduct).WithMany(p => p.MmpurchasePlanTrackingFkIcsemiProducts).HasConstraintName("FK_MMPurchasePlanTrackings_SemiICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmpurchasePlanTrackings).HasConstraintName("FK_MMPurchasePlanTrackings_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmpurchasePlanTrackings).HasConstraintName("FK_MMPurchasePlanTrackings_MMOperations");
        });

        modelBuilder.Entity<MmquantityAllocationPercentConfig>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.MmquantityAllocationPercentConfigs).HasConstraintName("MMQuantityAllocationPercentConfigs_FK_HRDepartmentID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmquantityAllocationPercentConfigs).HasConstraintName("FK_MMQuantityAllocationPercentConfigs_MMWorkShops");
        });

        modelBuilder.Entity<MmreuseSpecificateConfig>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttributeSpeciality).WithMany(p => p.MmreuseSpecificateConfigFkIcproductAttributeSpecialities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMReuseSpecificateConfigs_ICProducttAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmreuseSpecificateConfigFkIcproductAttributeWoodTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMReuseSpecificateConfigs_ICProducttAttributes");
        });

        modelBuilder.Entity<MmsemiProductIngredient>(entity =>
        {
            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmsemiProductIngredients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMSemiProductIngredients_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmsemiProductIngredients).HasConstraintName("FK_MMSemiProductIngredients_MMOperations");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmsemiProductIngredients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMSemiProductIngredients_MMProductionCosts");
        });

        modelBuilder.Entity<MmsemiProductIngredientItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmsemiProductIngredientItems).HasConstraintName("FK_MMSemiProductIngredientItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.MmsemiProductIngredientItems).HasConstraintName("FK_MMSemiProductIngredientItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmsemiProductIngredientItems).HasConstraintName("FK_MMSemiProductIngredientItems_ICProducts");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmsemiProductIngredientItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMSemiProductIngredientItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmoperation).WithMany(p => p.MmsemiProductIngredientItems).HasConstraintName("FK_MMSemiProductIngredientItems_MMOperations");

            entity.HasOne(d => d.FkMmproductionCost).WithMany(p => p.MmsemiProductIngredientItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMSemiProductIngredientItems_MMProductionCosts");

            entity.HasOne(d => d.FkMmsemiProductIngredient).WithMany(p => p.MmsemiProductIngredientItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMSemiProductIngredientItems_MMSemiProductIngredients");
        });

        modelBuilder.Entity<MmupdatePosition>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmupdatePositionFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMUpdatePositions_HREmployees");

            entity.HasOne(d => d.FkHremployeeIdapprovedNavigation).WithMany(p => p.MmupdatePositionFkHremployeeIdapprovedNavigations).HasConstraintName("FK_MMUpdatePositions_HREmployees_Approved");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.MmupdatePositions).HasConstraintName("FK_MMUpdatePositions_FK_ICStockID");
        });

        modelBuilder.Entity<MmupdatePositionItem>(entity =>
        {
            entity.HasOne(d => d.FkMmupdatePosition).WithMany(p => p.MmupdatePositionItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMUpdatePositionItems_MMUpdatePositions");
        });

        modelBuilder.Entity<MmwoodPlan>(entity =>
        {
            entity.HasKey(e => e.MmwoodPlanId).HasName("PK_MMWoodPlanes");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.MmwoodPlans).HasConstraintName("FK_MMWoodPlans_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.MmwoodPlans).HasConstraintName("FK_MMWoodPlans_ARSaleOrders");

            entity.HasOne(d => d.FkHremployeeApprovedNavigation).WithMany(p => p.MmwoodPlanFkHremployeeApprovedNavigations).HasConstraintName("FK_MMWoodPlans_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.MmwoodPlanFkHremployees).HasConstraintName("FK_MMWoodPlans_HREmployees");

            entity.HasOne(d => d.FkHremployeeValidatedNavigation).WithMany(p => p.MmwoodPlanFkHremployeeValidatedNavigations).HasConstraintName("FK_MMWoodPlans_HREmployeeValidateds");

            entity.HasOne(d => d.FkIcproductAttributeTtmt).WithMany(p => p.MmwoodPlans).HasConstraintName("FK_MMWoodPlans_ICProductAttributes");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmwoodPlans).HasConstraintName("FK_MMWoodPlans_MMBatchProducts");

            entity.HasOne(d => d.FkMmline).WithMany(p => p.MmwoodPlans).HasConstraintName("MMWoodPlans_FK_MMLineID");

            entity.HasOne(d => d.FkMmoperationDetailPlan).WithMany(p => p.MmwoodPlans).HasConstraintName("MMWoodPlans_FK_MMOperationDetailPlanID");

            entity.HasOne(d => d.FkMmworkShop).WithMany(p => p.MmwoodPlans).HasConstraintName("MMWoodPlans_FK_MMWorkShopID");
        });

        modelBuilder.Entity<MmwoodPlanItem>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.MmwoodPlanItems).HasConstraintName("FK_MMWoodPlanItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.MmwoodPlanItems).HasConstraintName("FK_MMWoodPlanItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmwoodPlanItemFkIcproductAttributeQualities).HasConstraintName("MMWoodPlanItems_FK_ICProductAttributeQualityID");

            entity.HasOne(d => d.FkIcproductAttributeSpeciality).WithMany(p => p.MmwoodPlanItemFkIcproductAttributeSpecialities).HasConstraintName("FK_MMWoodPlanItems_ICProductAttributes2");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmwoodPlanItemFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMWoodPlanItems_ICProductAttributes1");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmwoodPlanItemFkIcproductForBatches).HasConstraintName("MMWoodPlanItems_FK_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmwoodPlanItemFkIcproducts).HasConstraintName("FK_MMWoodPlanItems_ICProducts");

            entity.HasOne(d => d.FkIcproductWoodIngredient).WithMany(p => p.MmwoodPlanItemFkIcproductWoodIngredients).HasConstraintName("FK_MMWoodPlanItems_ICProducts_WoodIngredientID");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmwoodPlanItems).HasConstraintName("FK_MMWoodPlanItems_MMBatchProducts");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmwoodPlanItems).HasConstraintName("FK_MMWoodPlanItems_MMBatchProductItems");

            entity.HasOne(d => d.FkMmbatchProductProductionNormItem).WithMany(p => p.MmwoodPlanItems).HasConstraintName("FK_MMWoodPlanItems_MMBatchProductProductionNormItems");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmwoodPlanItems).HasConstraintName("FK_MMWoodPlanItems_MMWoodPlans");
        });

        modelBuilder.Entity<MmwoodPlanItemDetail>(entity =>
        {
            entity.HasOne(d => d.FkIcproductAttributeQuality).WithMany(p => p.MmwoodPlanItemDetailFkIcproductAttributeQualities).HasConstraintName("MMWoodPlanItemDetails_FK_ICProductAttributeQualityID");

            entity.HasOne(d => d.FkIcproductAttributeWoodType).WithMany(p => p.MmwoodPlanItemDetailFkIcproductAttributeWoodTypes).HasConstraintName("FK_MMWoodPlanItemDetails_ICProductAttributes");

            entity.HasOne(d => d.FkIcproductForBatch).WithMany(p => p.MmwoodPlanItemDetailFkIcproductForBatches).HasConstraintName("MMWoodPlanItemDetails_FK_ICProductForBatchID");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.MmwoodPlanItemDetailFkIcproducts).HasConstraintName("FK_MMWoodPlanItemDetails_ICProducts");

            entity.HasOne(d => d.FkIcsemiProduct).WithMany(p => p.MmwoodPlanItemDetailFkIcsemiProducts).HasConstraintName("FK_MMWoodPlanItemDetails_ICProducts1");

            entity.HasOne(d => d.FkMmbatchProduct).WithMany(p => p.MmwoodPlanItemDetails).HasConstraintName("MMWoodPlanItemDetails_FK_MMBatchProductID");

            entity.HasOne(d => d.FkMmbatchProductItem).WithMany(p => p.MmwoodPlanItemDetails).HasConstraintName("MMWoodPlanItemDetails_FK_MMBatchProductItemID");

            entity.HasOne(d => d.FkMmwoodPlan).WithMany(p => p.MmwoodPlanItemDetails).HasConstraintName("FK_MMWoodPlanItemDetails_MMWoodPlans");

            entity.HasOne(d => d.FkMmwoodPlanItem).WithMany(p => p.MmwoodPlanItemDetails).HasConstraintName("FK_MMWoodPlanItemDetails_MMWoodPlanItems");
        });

        modelBuilder.Entity<MmworkShop>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.MmworkShops)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MMWorkShops_BRBranchs");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.MmworkShops).HasConstraintName("FK_MMWorkShops_GELocations");
        });

        modelBuilder.Entity<NganhHangOld>(entity =>
        {
            entity.Property(e => e.IcdepartmentId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<NumberRoman>(entity =>
        {
            entity.Property(e => e.Roman).IsFixedLength();
        });

        modelBuilder.Entity<Oeproposal>(entity =>
        {
            entity.HasKey(e => e.OeproposalId).HasName("PK_FAProposals");

            entity.Property(e => e.OeproposalId).ValueGeneratedNever();
            entity.Property(e => e.OeproposalInactiveCheck).HasDefaultValueSql("((1))");
            entity.Property(e => e.OeproposalIsDiscountPercentCheck).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Arcustomer).WithMany(p => p.Oeproposals).HasConstraintName("FK_FAProposals_MACustomers");

            entity.HasOne(d => d.Arseller).WithMany(p => p.Oeproposals).HasConstraintName("FK_FAProposals_MASellers");

            entity.HasOne(d => d.Gecurrency).WithMany(p => p.Oeproposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAProposals_GECurrencies");

            entity.HasOne(d => d.Gelanguage).WithMany(p => p.Oeproposals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAProposals_GELanguages");

            entity.HasOne(d => d.Gevatregion).WithMany(p => p.Oeproposals).HasConstraintName("FK_FAProposals_GEVATRegions");
        });

        modelBuilder.Entity<PmbuidingCommand>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.PmbuidingCommands).HasConstraintName("FK_PMBuidingCommands_ARCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.PmbuidingCommands).HasConstraintName("FK_PMBuidingCommands_BRBranchs");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.PmbuidingCommands).HasConstraintName("FK_PMBuidingCommands_HRDepartmentRooms");

            entity.HasOne(d => d.FkPmbuidingProposal).WithMany(p => p.PmbuidingCommands).HasConstraintName("FK_PMBuidingCommands_PMBuidingProposals");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmbuidingCommands).HasConstraintName("FK_PMBuidingCommands_PMProjects");
        });

        modelBuilder.Entity<PmbuidingCommandItem>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.PmbuidingCommandItems).HasConstraintName("FK_PMBuidingCommandItems_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmbuidingCommandItems).HasConstraintName("FK_PMBuidingCommandItems_HREmployees");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.PmbuidingCommandItems).HasConstraintName("FK_PMBuidingCommandItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmbuidingCommandItems).HasConstraintName("FK_PMBuidingCommandItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.PmbuidingCommandItems).HasConstraintName("FK_PMBuidingCommandItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmbuidingCommandItems).HasConstraintName("FK_PMBuidingCommandItems_ICProducts");

            entity.HasOne(d => d.FkPmbuidingProposal).WithMany(p => p.PmbuidingCommandItems).HasConstraintName("FK_PMBuidingCommandItems_PMBuidingProposals");

            entity.HasOne(d => d.FkPmbuidingProposalItem).WithMany(p => p.PmbuidingCommandItems).HasConstraintName("FK_PMBuidingCommandItems_PMBuidingProposalItems");
        });

        modelBuilder.Entity<PmbuidingProposal>(entity =>
        {
            entity.HasKey(e => e.PmbuidingProposalId).HasName("PK__PMBuidin__2A4F1DB33E177487");

            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.PmbuidingProposals).HasConstraintName("FK_PMBuidingProposals_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.PmbuidingProposals).HasConstraintName("FK_PMBuidingProposals_ARSaleOrders");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.PmbuidingProposals).HasConstraintName("FK_PMBuidingProposals_BRBranchs");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.PmbuidingProposals).HasConstraintName("FK_PMBuidingProposals_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmbuidingProposals).HasConstraintName("FK_PMBuidingProposals_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmbuidingProposals).HasConstraintName("FK_PMBuidingProposals_PMProjects");
        });

        modelBuilder.Entity<PmbuidingProposalItem>(entity =>
        {
            entity.HasKey(e => e.PmbuidingProposalItemId).HasName("PK__PMBuidin__35B62851512A48FB");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.PmbuidingProposalItems).HasConstraintName("FK_PMBuidingProposalItems_ARSaleOrders");

            entity.HasOne(d => d.FkArsaleOrderItem).WithMany(p => p.PmbuidingProposalItems).HasConstraintName("FK_PMBuidingProposalItems_ARSaleOrderItems");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.PmbuidingProposalItems).HasConstraintName("FK_PMBuidingProposalItems_BRBranchs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.PmbuidingProposalItems).HasConstraintName("FK_PMBuidingProposalItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmbuidingProposalItems).HasConstraintName("FK_PMBuidingProposalItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.PmbuidingProposalItems).HasConstraintName("FK_PMBuidingProposalItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmbuidingProposalItems).HasConstraintName("FK_PMBuidingProposalItems_ICProducts");

            entity.HasOne(d => d.FkPmbuidingProposal).WithMany(p => p.PmbuidingProposalItems).HasConstraintName("FK_PMBuidingProposalItems_PMBuidingProposals");
        });

        modelBuilder.Entity<PmbuildingAllocation>(entity =>
        {
            entity.HasOne(d => d.FkHremployeeApprovedNavigation).WithMany(p => p.PmbuildingAllocationFkHremployeeApprovedNavigations).HasConstraintName("FK_PMBuildingAllocations_FK_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmbuildingAllocationFkHremployees).HasConstraintName("FK_PMBuildingAllocations_HREmployees");

            entity.HasOne(d => d.FkHremployeeValidatedNavigation).WithMany(p => p.PmbuildingAllocationFkHremployeeValidatedNavigations).HasConstraintName("FK_PMBuildingAllocations_HREmployeeValidateds");

            entity.HasOne(d => d.FkPmbuildingPlan).WithMany(p => p.PmbuildingAllocations).HasConstraintName("FK_PMBuildingAllocations_PMBuildingPlans");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmbuildingAllocations).HasConstraintName("FK_PMBuildingAllocations_PMProjects");
        });

        modelBuilder.Entity<PmbuildingAllocationItem>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmbuildingAllocationItemFkHremployees).HasConstraintName("FK_PMBuildingAllocationItems_HREmployees");

            entity.HasOne(d => d.FkHremployeeOwner).WithMany(p => p.PmbuildingAllocationItemFkHremployeeOwners).HasConstraintName("FK_PMBuildingAllocationItems_HREmployeeOwners");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.PmbuildingAllocationItems).HasConstraintName("FK_PMBuildingAllocationItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmbuildingAllocationItems).HasConstraintName("FK_PMBuildingAllocationItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmbuildingAllocationItems).HasConstraintName("FK_PMBuildingAllocationItems_ICProducts");

            entity.HasOne(d => d.FkPmbuildingAllocation).WithMany(p => p.PmbuildingAllocationItems).HasConstraintName("FK_PMBuildingAllocationItems_PMBuildingAllocations");

            entity.HasOne(d => d.FkPmbuildingPlan).WithMany(p => p.PmbuildingAllocationItems).HasConstraintName("FK_PMBuildingAllocationItems_PMBuildingPlans");

            entity.HasOne(d => d.FkPmbuildingPlanItem).WithMany(p => p.PmbuildingAllocationItems).HasConstraintName("FK_PMBuildingAllocationItems_PMBuildingPlanItems");
        });

        modelBuilder.Entity<PmbuildingPlan>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.PmbuildingPlans).HasConstraintName("FK_PMBuildingPlans_ARCustomers");

            entity.HasOne(d => d.FkArsaleOrder).WithMany(p => p.PmbuildingPlans).HasConstraintName("FK_PMBuildingPlans_ARSaleOrders");

            entity.HasOne(d => d.FkHremployeeApprovedNavigation).WithMany(p => p.PmbuildingPlanFkHremployeeApprovedNavigations).HasConstraintName("FK_PMBuildingPlans_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmbuildingPlanFkHremployees).HasConstraintName("FK_PMBuildingPlans_HREmployees");

            entity.HasOne(d => d.FkHremployeeValidatedNavigation).WithMany(p => p.PmbuildingPlanFkHremployeeValidatedNavigations).HasConstraintName("FK_PMBuildingPlans_HREmployeeValidateds");

            entity.HasOne(d => d.FkPmbuidingCommand).WithMany(p => p.PmbuildingPlans).HasConstraintName("FK_PMBuildingPlans_PMBuidingCommands");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmbuildingPlans).HasConstraintName("FK_PMBuildingPlans_PMProjects");
        });

        modelBuilder.Entity<PmbuildingPlanItem>(entity =>
        {
            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.PmbuildingPlanItems).HasConstraintName("FK_PMBuildingPlanItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmbuildingPlanItems).HasConstraintName("FK_PMBuildingPlanItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmbuildingPlanItems).HasConstraintName("FK_PMBuildingPlanItems_ICProducts");

            entity.HasOne(d => d.FkPmbuidingCommand).WithMany(p => p.PmbuildingPlanItems).HasConstraintName("FK_PMBuildingPlanItems_PMBuidingCommands");

            entity.HasOne(d => d.FkPmbuidingCommandItem).WithMany(p => p.PmbuildingPlanItems).HasConstraintName("FK_PMBuildingPlanItems_PMBuidingCommandItems");

            entity.HasOne(d => d.FkPmbuildingPlan).WithMany(p => p.PmbuildingPlanItems).HasConstraintName("FK_PMBuildingPlanItems_PMBuildingPlans");
        });

        modelBuilder.Entity<Pmhistory>(entity =>
        {
            entity.HasKey(e => e.PmhistoryId).HasName("PK_PMHistory");

            entity.Property(e => e.PmhistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.PmhistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.PmhistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<PmhistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkPmhistory).WithMany(p => p.PmhistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMHistoryDetails_PMHistory");
        });

        modelBuilder.Entity<PmphaseType>(entity =>
        {
            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.PmphaseTypes).HasConstraintName("FK_PMPhaseTypes_PMProjectTypes");
        });

        modelBuilder.Entity<Pmproject>(entity =>
        {
            entity.HasOne(d => d.FkArcustomer).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_ARCustomers");

            entity.HasOne(d => d.FkArprospectCustomer).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_ARProspectCustomers");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_BRBranchs");

            entity.HasOne(d => d.FkGedistrict).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_GEDistricts");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_GELocations");

            entity.HasOne(d => d.FkGestateProvince).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_GEStateProvinces");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmprojectFkHremployees).HasConstraintName("FK_PMProjects_HREmployees");

            entity.HasOne(d => d.FkHrprojectOwnerEmployee).WithMany(p => p.PmprojectFkHrprojectOwnerEmployees).HasConstraintName("FK_PMProjects_HRProjectOwnerEmployees");

            entity.HasOne(d => d.FkPmprojectProfile).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_PMProjectProfiles");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_PMProjectTypes");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.Pmprojects).HasConstraintName("FK_PMProjects_PMTemplates");
        });

        modelBuilder.Entity<PmprojectBidsProfile>(entity =>
        {
            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectBidsProfiles).HasConstraintName("FK_PMProjectBidsProfiles_PMProjects");
        });

        modelBuilder.Entity<PmprojectContact>(entity =>
        {
            entity.HasOne(d => d.FkGelocation).WithMany(p => p.PmprojectContacts).HasConstraintName("FK_PMProjectContacts_GELocations");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectContacts).HasConstraintName("FK_PMProjectContacts_PMProjects");
        });

        modelBuilder.Entity<PmprojectLocation>(entity =>
        {
            entity.HasOne(d => d.FkGedistrict).WithMany(p => p.PmprojectLocations).HasConstraintName("FK_GEDistricts_GELocations");

            entity.HasOne(d => d.FkGelocation).WithMany(p => p.PmprojectLocations).HasConstraintName("FK_PMProjectLocations_GELocations");

            entity.HasOne(d => d.FkGestateProvince).WithMany(p => p.PmprojectLocations).HasConstraintName("FK_GEStateProvinces_GELocations");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectLocations).HasConstraintName("FK_PMProjectLocations_PMProjects");
        });

        modelBuilder.Entity<PmprojectMaterialItem>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmprojectMaterialItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMProjectMaterialItems_ICProducts");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.PmprojectMaterialItems).HasConstraintName("FK_PMProjectMaterialItems_ICStocks");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectMaterialItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMProjectMaterialItems_PMProjects");

            entity.HasOne(d => d.FkPmprojectMaterial).WithMany(p => p.PmprojectMaterialItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMProjectMaterialItems_PMProjectMaterials");

            entity.HasOne(d => d.FkPmprojectPhase).WithMany(p => p.PmprojectMaterialItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMProjectMaterialItems_PMProjectPhases");
        });

        modelBuilder.Entity<PmprojectNorm>(entity =>
        {
            entity.HasKey(e => e.PmprojectNormId).HasName("PK__PMProjec__B034D573348E0A4D");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_BRBranchs");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_ICProducts");

            entity.HasOne(d => d.FkIcproductWorkGroup).WithMany(p => p.PmprojectNormFkIcproductWorkGroups).HasConstraintName("FK_PMProjectNorms_ICProductWorkGroups");

            entity.HasOne(d => d.FkIcproductWorkGroupParent).WithMany(p => p.PmprojectNormFkIcproductWorkGroupParents).HasConstraintName("FK_PMProjectNorms_ICProductWorkGroupParents");

            entity.HasOne(d => d.FkIcstock).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_ICStocks");

            entity.HasOne(d => d.FkPmphaseType).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_PMPhaseTypes");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_PMProjects");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_PMTemplates");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.PmprojectNorms).HasConstraintName("FK_PMProjectNorms_PMTemplateItems");
        });

        modelBuilder.Entity<PmprojectNormHistory>(entity =>
        {
            entity.HasKey(e => e.PmprojectNormHistoryId).HasName("PK_PMProjectNormHistory");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmprojectNormHistories).HasConstraintName("FK_PMProjectNormHistorys_HREmployees");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectNormHistories).HasConstraintName("FK_PMProjectNormHistorys_PMProjects");

            entity.HasOne(d => d.FkPmprojectNorm).WithMany(p => p.PmprojectNormHistories).HasConstraintName("FK_PMProjectNormHistorys_PMProjectNorms");
        });

        modelBuilder.Entity<PmprojectNormItem>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmprojectNormItems).HasConstraintName("FK_PMProjectNormItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmprojectNormItems).HasConstraintName("FK_PMProjectNormItems_ICProducts");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectNormItems).HasConstraintName("FK_PMProjectNormItems_PMProjects");

            entity.HasOne(d => d.FkPmprojectNorm).WithMany(p => p.PmprojectNormItems).HasConstraintName("FK_PMProjectNormItems_PMProjectNorms");

            entity.HasOne(d => d.FkPmtemplateItemComponent).WithMany(p => p.PmprojectNormItems).HasConstraintName("FK_PMProjectNormItems_PMTemplateItemComponents");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.PmprojectNormItems).HasConstraintName("FK_PMProjectNormItems_PMTemplateItems");
        });

        modelBuilder.Entity<PmprojectNormTask>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_HREmployees");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_ICMeasureUnits");

            entity.HasOne(d => d.FkIctask).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_ICTasks");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_PMProjects");

            entity.HasOne(d => d.FkPmprojectNorm).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_PMProjectNorms");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_PMProjectTypes");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_PMTemplates");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.PmprojectNormTasks).HasConstraintName("FK_PMProjectNormTasks_PMTemplateItems");
        });

        modelBuilder.Entity<PmprojectPhase>(entity =>
        {
            entity.HasOne(d => d.FkPmphaseType).WithMany(p => p.PmprojectPhases)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMProjectPhases_PMPhaseTypes");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectPhases)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMProjectPhases_PMProjects");
        });

        modelBuilder.Entity<PmprojectPhaseResource>(entity =>
        {
            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmprojectPhaseResources).HasConstraintName("FK_PMProjectPhaseResources_ICProducts");

            entity.HasOne(d => d.FkPmprojectPhase).WithMany(p => p.PmprojectPhaseResources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMProjectPhaseResources_PMProjectPhases");
        });

        modelBuilder.Entity<PmprojectProfilePhaseResource>(entity =>
        {
            entity.HasKey(e => e.PmprojectProfilePhaseResourceId).HasName("PK_PMProjectProfileResources");
        });

        modelBuilder.Entity<PmprojectTemplateRelationship>(entity =>
        {
            entity.HasOne(d => d.FkPmphaseType).WithMany(p => p.PmprojectTemplateRelationships).HasConstraintName("FK_PMProjectTemplateRelationships_PMPhaseTypes");

            entity.HasOne(d => d.FkPmproject).WithMany(p => p.PmprojectTemplateRelationships).HasConstraintName("FK_PMProjectTemplateRelationships_PMProjects");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.PmprojectTemplateRelationships).HasConstraintName("FK_PMProjectTemplateRelationships_PMTemplates");
        });

        modelBuilder.Entity<PmprojectType>(entity =>
        {
            entity.HasKey(e => e.PmprojectTypeId).HasName("PK__PMProjec__763071E80F5C859E");
        });

        modelBuilder.Entity<PmsaleWork>(entity =>
        {
            entity.HasKey(e => e.PmsaleWorkId).HasName("FK_PMSaleWorks");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.PmsaleWorks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMSaleWorks_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApproved).WithMany(p => p.PmsaleWorkFkHremployeeApproveds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMSaleWorks_HREmployeeApproveds");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmsaleWorkFkHremployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PMSaleWorks_HREmployees");
        });

        modelBuilder.Entity<PmsaleWorkItem>(entity =>
        {
            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmsaleWorkItems).HasConstraintName("FK_PMSaleWorkItems_HREmployees");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmsaleWorkItems).HasConstraintName("FK_PMSaleWorkItems_ICProducts");

            entity.HasOne(d => d.FkPmsaleWork).WithMany(p => p.PmsaleWorkItems).HasConstraintName("FK_PMSaleWorkItems_PMSaleWorks");
        });

        modelBuilder.Entity<Pmtask>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.Pmtasks).HasConstraintName("FK_PMTasks_ADUserGroups");

            entity.HasOne(d => d.FkHremployeeCreated).WithMany(p => p.PmtaskFkHremployeeCreateds).HasConstraintName("FK_PMTasks_HREmployeeCreateds");

            entity.HasOne(d => d.FkHremployeeUpdated).WithMany(p => p.PmtaskFkHremployeeUpdateds).HasConstraintName("FK_PMTasks_HREmployeeUpdateds");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.Pmtasks).HasConstraintName("FK_PMTasks_HRGroups");
        });

        modelBuilder.Entity<PmtaskAssign>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.PmtaskAssigns).HasConstraintName("FK_PMTaskAssigns_ADUserGroups");

            entity.HasOne(d => d.FkHrgroup).WithMany(p => p.PmtaskAssigns).HasConstraintName("FK_PMTaskAssigns_HRGroups");

            entity.HasOne(d => d.FkPmtask).WithMany(p => p.PmtaskAssigns).HasConstraintName("FK_PMTaskAssigns_PMTasks");
        });

        modelBuilder.Entity<PmtaskAssignsHistory>(entity =>
        {
            entity.HasKey(e => new { e.PmtaskAssignId, e.Rev }).HasName("PK__PMTaskAs__D39671D345B8E107");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.PmtaskAssignsHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKq557wfoh2klfeoh7mr2gc9oi0");
        });

        modelBuilder.Entity<PmtaskComment>(entity =>
        {
            entity.HasKey(e => e.PmtaskCommentId).HasName("PK_PMTaskCommands");
        });

        modelBuilder.Entity<PmtaskFile>(entity =>
        {
            entity.HasOne(d => d.FkPmtask).WithMany(p => p.PmtaskFiles).HasConstraintName("FK_PMTaskFiles_PMTasks");

            entity.HasOne(d => d.FkPmtaskReportIssue).WithMany(p => p.PmtaskFiles).HasConstraintName("FK_PMTaskFiles_PMTaskReportIssues");
        });

        modelBuilder.Entity<PmtaskReportIssue>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.PmtaskReportIssues).HasConstraintName("FK_PMTaskReportIssues_BRBranchs");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmtaskReportIssues).HasConstraintName("FK_PMTaskReportIssues_HREmployees");

            entity.HasOne(d => d.FkPmtask).WithMany(p => p.PmtaskReportIssues).HasConstraintName("FK_PMTaskReportIssues_PMTasks");
        });

        modelBuilder.Entity<PmtasksHistory>(entity =>
        {
            entity.HasKey(e => new { e.PmtaskId, e.Rev }).HasName("PK__PMTasks___E177E5E58F91BE49");

            entity.HasOne(d => d.RevNavigation).WithMany(p => p.PmtasksHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKgx6axl25loll4pbsug81kmjfi");
        });

        modelBuilder.Entity<Pmtemplate>(entity =>
        {
            entity.HasKey(e => e.PmtemplateId).HasName("PK__PMTempla__852B8A32208711A0");

            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Pmtemplates).HasConstraintName("FK_PMTemplates_BRBranchs");

            entity.HasOne(d => d.FkHremployeeApprove).WithMany(p => p.PmtemplateFkHremployeeApproves).HasConstraintName("FK_PMTemplates_HREmployeeApproves");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmtemplateFkHremployees).HasConstraintName("FK_PMTemplates_HREmployees");

            entity.HasOne(d => d.FkPmphaseType).WithMany(p => p.Pmtemplates).HasConstraintName("FK_PMTemplates_PMPhaseTypes");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.Pmtemplates).HasConstraintName("FK_PMTemplates_PMProjectTypes");
        });

        modelBuilder.Entity<PmtemplateItem>(entity =>
        {
            entity.HasKey(e => e.PmtemplateItemId).HasName("PK__PMTempla__92C6926227340F2F");

            entity.HasOne(d => d.FkIcdepartment).WithMany(p => p.PmtemplateItems).HasConstraintName("FK_PMTemplateItems_ICDepartments");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmtemplateItems).HasConstraintName("FK_PMTemplateItems_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductGroup).WithMany(p => p.PmtemplateItems).HasConstraintName("FK_PMTemplateItems_ICProductGroups");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmtemplateItems).HasConstraintName("FK_PMTemplateItems_ICProducts");

            entity.HasOne(d => d.FkIcproductWorkGroup).WithMany(p => p.PmtemplateItemFkIcproductWorkGroups).HasConstraintName("FK_PMTemplateItems_ICProductWorkGroups");

            entity.HasOne(d => d.FkIcproductWorkGroupParent).WithMany(p => p.PmtemplateItemFkIcproductWorkGroupParents).HasConstraintName("FK_PMTemplateItems_ICProductWorkGroupParents");

            entity.HasOne(d => d.FkPmphaseType).WithMany(p => p.PmtemplateItems).HasConstraintName("FK_PMTemplateItems_PMPhaseTypes");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.PmtemplateItems).HasConstraintName("FK_PMTemplateItems_PMTemplates");
        });

        modelBuilder.Entity<PmtemplateItemComponent>(entity =>
        {
            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmtemplateItemComponents).HasConstraintName("FK_PMTemplateItemComponents_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproduct).WithMany(p => p.PmtemplateItemComponentFkIcproducts).HasConstraintName("FK_PMTemplateItemComponents_ICProducts");

            entity.HasOne(d => d.FkIcproductWork).WithMany(p => p.PmtemplateItemComponentFkIcproductWorks).HasConstraintName("FK_PMTemplateItemComponents_ICProductWorks");

            entity.HasOne(d => d.FkIcproductWorkItem).WithMany(p => p.PmtemplateItemComponents).HasConstraintName("FK_PMTemplateItemComponents_ICProductWorkItems");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.PmtemplateItemComponents).HasConstraintName("FK_PMTemplateItemComponents_PMTemplates");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.PmtemplateItemComponents).HasConstraintName("FK_PMTemplateItemComponents_PMTemplateItems");
        });

        modelBuilder.Entity<PmtemplateItemTask>(entity =>
        {
            entity.HasOne(d => d.FkHrdepartment).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_HRDepartments");

            entity.HasOne(d => d.FkHrdepartmentRoom).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_HRDepartmentRooms");

            entity.HasOne(d => d.FkHremployee).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_HREmployees");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_ICMeasureUnits");

            entity.HasOne(d => d.FkIcproductTask).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_ICProductTasks");

            entity.HasOne(d => d.FkIctask).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_ICTasks");

            entity.HasOne(d => d.FkPmprojectType).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_PMProjectTypes");

            entity.HasOne(d => d.FkPmtemplate).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_PMTemplates");

            entity.HasOne(d => d.FkPmtemplateItem).WithMany(p => p.PmtemplateItemTasks).HasConstraintName("FK_PMTemplateItemTasks_PMTemplateItems");
        });

        modelBuilder.Entity<Revinfo>(entity =>
        {
            entity.HasKey(e => e.Rev).HasName("PK__REVINFO__CAFFA0437C51E49A");
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Value }).HasName("PK_HangFire_Set");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.Score, "IX_HangFire_Set_Score").HasFilter("([Score] IS NOT NULL)");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Id }).HasName("PK_HangFire_State");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Job).WithMany(p => p.States).HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<Stfield>(entity =>
        {
            entity.HasKey(e => e.StfieldId).HasName("PK_Field_1");

            entity.Property(e => e.StfieldStatus).HasComment("Active\r\nDeleted");

            entity.HasOne(d => d.Stscreen).WithMany(p => p.Stfields).HasConstraintName("FK_Field_Screen");

            entity.HasOne(d => d.StuserGroup).WithMany(p => p.Stfields)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STField_ADUserGroup");
        });

        modelBuilder.Entity<StfieldColumn>(entity =>
        {
            entity.HasOne(d => d.Stfield).WithMany(p => p.StfieldColumns).HasConstraintName("FK_STFieldColumns_STFields");
        });

        modelBuilder.Entity<StfieldColumnPermission>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.StfieldColumnPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STFieldColumnPermissions_ADUserGroups");
        });

        modelBuilder.Entity<StfieldEvent>(entity =>
        {
            entity.HasKey(e => e.StfieldEventId).HasName("PK_FieldEvent");

            entity.HasOne(d => d.Stfield).WithMany(p => p.StfieldEvents).HasConstraintName("FK_FieldEvent_Field");
        });

        modelBuilder.Entity<StfieldEventFunction>(entity =>
        {
            entity.HasKey(e => e.StfieldEventFunctionId).HasName("PK_FieldEventFunction");

            entity.HasOne(d => d.StfieldEvent).WithMany(p => p.StfieldEventFunctions).HasConstraintName("FK_FieldEventFunction_FieldEvent");
        });

        modelBuilder.Entity<StfieldEventFunctionParameter>(entity =>
        {
            entity.HasKey(e => e.StfieldEventFunctionParameterId).HasName("PK_FieldEventFunctionParameter");

            entity.HasOne(d => d.StfieldEventFunction).WithMany(p => p.StfieldEventFunctionParameters).HasConstraintName("FK_FieldEventFunctionParameter_FieldEventFunction");
        });

        modelBuilder.Entity<StfieldEventParameter>(entity =>
        {
            entity.HasKey(e => e.StfieldEventParameterId).HasName("PK_FieldEventParameter");

            entity.HasOne(d => d.StfieldEvent).WithMany(p => p.StfieldEventParameters).HasConstraintName("FK_FieldEventParameter_FieldEvent");
        });

        modelBuilder.Entity<StfieldFormat>(entity =>
        {
            entity.HasOne(d => d.StfieldFormatGroup).WithMany(p => p.StfieldFormats).HasConstraintName("FK_STFieldFormats_STFieldFormatGroups");
        });

        modelBuilder.Entity<StfieldLanguage>(entity =>
        {
            entity.HasKey(e => e.StfieldLanguageId).HasName("PK_FieldLanguage");
        });

        modelBuilder.Entity<StfieldPermission>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.StfieldPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STFieldPermissions_ADUserGroups");
        });

        modelBuilder.Entity<StgridResultColumnDisplay>(entity =>
        {
            entity.HasKey(e => e.StgridResultColumnDisplayId).HasName("PK_GridResultColumnDisplay");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.StgridResultColumnDisplays).HasConstraintName("FK_GridResultColumnDisplay_Module");
        });

        modelBuilder.Entity<Stmodule>(entity =>
        {
            entity.HasKey(e => e.StmoduleId).HasName("PK_Module");
        });

        modelBuilder.Entity<StmoduleDescription>(entity =>
        {
            entity.HasKey(e => e.StmoduleDescriptionId).HasName("PK_ModuleDescription");

            entity.HasOne(d => d.Stlanguage).WithMany(p => p.StmoduleDescriptions).HasConstraintName("FK_ModuleDescription_Language");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.StmoduleDescriptions).HasConstraintName("FK_ModuleDescription_Module");
        });

        modelBuilder.Entity<StmoduleDescriptionsLanguage>(entity =>
        {
            entity.HasKey(e => e.StmoduleDescriptionsLanguageId).HasName("PK_ModuleDescriptionsLanguage");
        });

        modelBuilder.Entity<StmoduleFunction>(entity =>
        {
            entity.HasKey(e => e.StmoduleFunctionId).HasName("PK_ModuleFunction");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.StmoduleFunctions).HasConstraintName("FK_ModuleFunction_Module");
        });

        modelBuilder.Entity<StmoduleFunctionParameter>(entity =>
        {
            entity.HasKey(e => e.StmoduleFunctionParameterId).HasName("PK_ModuleFunctionParameter");

            entity.HasOne(d => d.StmoduleFunction).WithMany(p => p.StmoduleFunctionParameters).HasConstraintName("FK_ModuleFunctionParameter_ModuleFunction");
        });

        modelBuilder.Entity<StmoduleFunctionParameterValue>(entity =>
        {
            entity.HasKey(e => e.StmoduleFunctionParameterValueId).HasName("PK_ModuleFunctionParameterValue");

            entity.HasOne(d => d.StmoduleFunctionParameter).WithMany(p => p.StmoduleFunctionParameterValues).HasConstraintName("FK_ModuleFunctionParameterValue_ModuleFunctionParameter");

            entity.HasOne(d => d.StuserGroup).WithMany(p => p.StmoduleFunctionParameterValues).HasConstraintName("FK_STModuleFunctionParameterValue_ADUserGroup");
        });

        modelBuilder.Entity<StmoduleSearchField>(entity =>
        {
            entity.HasKey(e => e.StmoduleSearchFieldId).HasName("PK_ModuleSearchFields");

            entity.HasOne(d => d.StmoduleStatus).WithMany(p => p.StmoduleSearchFields).HasConstraintName("FK_ModuleSearchFields_ModuleStatus");
        });

        modelBuilder.Entity<StmoduleStatus>(entity =>
        {
            entity.HasKey(e => e.StmoduleStatusId).HasName("PK_ModuleStatus");

            entity.Property(e => e.StmoduleStatusStatus).HasComment("Open\r\nClose\r\nHide");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.StmoduleStatuses).HasConstraintName("FK_ModuleStatus_Module");

            entity.HasOne(d => d.Stuser).WithMany(p => p.StmoduleStatuses).HasConstraintName("FK_STModuleStatus_ADUser");
        });

        modelBuilder.Entity<StmoduleTable>(entity =>
        {
            entity.HasKey(e => e.StmoduleTableId).HasName("PK_TableForModule_1");

            entity.Property(e => e.StmoduleTableType).HasComment("0:Table\r\n1:View");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.StmoduleTables).HasConstraintName("FK_ModuleTables_Module");
        });

        modelBuilder.Entity<StmoduleToUserGroupSection>(entity =>
        {
            entity.HasKey(e => e.StmoduleToUserGroupSectionId).HasName("PK_ModuleToUserGroupApplication");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.StmoduleToUserGroupSections).HasConstraintName("FK_ModuleToUserGroupApplication_Module");

            entity.HasOne(d => d.StuserGroupSection).WithMany(p => p.StmoduleToUserGroupSections).HasConstraintName("FK_ModuleToUserGroup_UserGroup");
        });

        modelBuilder.Entity<StobjectStatus>(entity =>
        {
            entity.HasKey(e => e.StobjectStatusId).HasName("PK_ObjectStatus");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.StobjectStatuses).HasConstraintName("FK_ObjectStatus_Module");
        });

        modelBuilder.Entity<Stscreen>(entity =>
        {
            entity.HasKey(e => e.StscreenId).HasName("PK_Screen");

            entity.Property(e => e.StscreenShowInfoPanel).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Stmodule).WithMany(p => p.Stscreens).HasConstraintName("FK_Screen_Module");

            entity.HasOne(d => d.StuserGroup).WithMany(p => p.Stscreens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STScreen_ADUserGroup");
        });

        modelBuilder.Entity<StscreenLanguage>(entity =>
        {
            entity.HasKey(e => e.StscreenLanguageId).HasName("PK_ScreenLanguage");
        });

        modelBuilder.Entity<StscreenPermission>(entity =>
        {
            entity.HasOne(d => d.FkAduserGroup).WithMany(p => p.StscreenPermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STScreenPermissions_ADUserGroups");
        });

        modelBuilder.Entity<Sttoolbar>(entity =>
        {
            entity.HasOne(d => d.Stmodule).WithMany(p => p.Sttoolbars).HasConstraintName("FK_STToolbars_STModules");

            entity.HasOne(d => d.StuserGroup).WithMany(p => p.Sttoolbars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STToolbars_ADUserGroups");
        });

        modelBuilder.Entity<SttoolbarFunction>(entity =>
        {
            entity.HasKey(e => e.SttoolbarFunctionId).HasName("PK_STToolbarFunction");

            entity.HasOne(d => d.Sttoolbar).WithMany(p => p.SttoolbarFunctions).HasConstraintName("FK_STToolbarFunction_STToolbars");
        });

        modelBuilder.Entity<SttoolbarFunctionParameter>(entity =>
        {
            entity.HasKey(e => e.SttoolbarFunctionParameterId).HasName("PK_AS");

            entity.HasOne(d => d.SttoolbarFunction).WithMany(p => p.SttoolbarFunctionParameters).HasConstraintName("FK_STToolbarFunctionParameters_STToolbarFunctions");
        });

        modelBuilder.Entity<SttransactionLogger>(entity =>
        {
            entity.Property(e => e.SttransactionLoggerId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<StuserFieldColumn>(entity =>
        {
            entity.HasKey(e => e.StuserFieldColumnId).HasName("PK_ADUserFieldColumns");
        });

        modelBuilder.Entity<VAcaccountingLedger>(entity =>
        {
            entity.ToView("V_ACAccountingLedgers");
        });

        modelBuilder.Entity<VAcobject>(entity =>
        {
            entity.ToView("V_ACObjects");
        });

        modelBuilder.Entity<VIcproduct>(entity =>
        {
            entity.ToView("V_ICProducts");
        });

        modelBuilder.Entity<VMmproductionCostCalculationAllocation>(entity =>
        {
            entity.ToView("V_MMProductionCostCalculationAllocations");
        });

        modelBuilder.Entity<VProductionCostInvoice>(entity =>
        {
            entity.ToView("V_ProductionCostInvoices");
        });

        modelBuilder.Entity<Vacbalance>(entity =>
        {
            entity.ToView("VACBalances");
        });

        modelBuilder.Entity<Vactransaction>(entity =>
        {
            entity.ToView("VACTransactions");
        });

        modelBuilder.Entity<VapinvoiceInVatIn>(entity =>
        {
            entity.ToView("VAPInvoiceInVatIns");
        });

        modelBuilder.Entity<VapinvoiceInVatInsForReport>(entity =>
        {
            entity.ToView("VAPInvoiceInVatInsForReports");
        });

        modelBuilder.Entity<VapinvoiceInVatInsForReportsTt06>(entity =>
        {
            entity.ToView("VAPInvoiceInVatInsForReports_TT06");
        });

        modelBuilder.Entity<VarinvoiceVatOut>(entity =>
        {
            entity.ToView("VARInvoiceVatOuts");
        });

        modelBuilder.Entity<VarinvoiceVatOutsForReport>(entity =>
        {
            entity.ToView("VARInvoiceVatOutsForReport");
        });

        modelBuilder.Entity<Vcdtk>(entity =>
        {
            entity.ToView("Vcdtk");
        });

        modelBuilder.Entity<Vmhistory>(entity =>
        {
            entity.HasKey(e => e.VmhistoryId).HasName("PK_VMHistory");

            entity.Property(e => e.VmhistoryColumnName).HasDefaultValueSql("('')");
            entity.Property(e => e.VmhistoryNewValue).HasDefaultValueSql("('')");
            entity.Property(e => e.VmhistoryOldValue).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<VmhistoryDetail>(entity =>
        {
            entity.HasOne(d => d.FkVmhistory).WithMany(p => p.VmhistoryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VMHistoryDetails_VMHistory");
        });

        modelBuilder.Entity<VmoduleName>(entity =>
        {
            entity.ToView("VModuleNames");
        });

        modelBuilder.Entity<Vmvehicle>(entity =>
        {
            entity.HasOne(d => d.FkBrbranch).WithMany(p => p.Vmvehicles).HasConstraintName("FK_VMVehicles_BRBranchs");

            entity.HasOne(d => d.FkIcmeasureUnit).WithMany(p => p.Vmvehicles).HasConstraintName("FK_VMVehicles_ICMeasureUnits");

            entity.HasOne(d => d.FkVmvehicleGroup).WithMany(p => p.Vmvehicles).HasConstraintName("FK_VMVehicles_VMVehicleGroups");
        });

        modelBuilder.Entity<VmvehicleEmployee>(entity =>
        {
            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.VmvehicleEmployees).HasConstraintName("FK_VMVehicleEmployees_VMVehicles");
        });

        modelBuilder.Entity<VmvehicleFuelLog>(entity =>
        {
            entity.HasOne(d => d.FkVmvehicle).WithMany(p => p.VmvehicleFuelLogs).HasConstraintName("FK_VMVehicleFuelLogs_VMVehicles");
        });

        modelBuilder.Entity<Vsocai>(entity =>
        {
            entity.ToView("VSocai");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
