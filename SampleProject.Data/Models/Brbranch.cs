using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("BRBranchs")]
[Microsoft.EntityFrameworkCore.Index("BrbranchNo", Name = "Idx_BRBranchs")]
public partial class Brbranch
{
    [Key]
    [Column("BRBranchID")]
    public int BrbranchId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("BRBranchServerName")]
    [StringLength(50)]
    public string BrbranchServerName { get; set; }

    [Column("BRBranchServerAliasName")]
    [StringLength(50)]
    public string BrbranchServerAliasName { get; set; }

    [Column("BRBranchDatabase")]
    [StringLength(50)]
    public string BrbranchDatabase { get; set; }

    [Column("BRBranchDatabaseUser")]
    [StringLength(50)]
    public string BrbranchDatabaseUser { get; set; }

    [Column("BRBranchDatabasePassword")]
    [StringLength(50)]
    public string BrbranchDatabasePassword { get; set; }

    [Column("BRBranchRemoteUserName")]
    [StringLength(50)]
    public string BrbranchRemoteUserName { get; set; }

    [Column("BRBranchRemotePassword")]
    [StringLength(50)]
    public string BrbranchRemotePassword { get; set; }

    [Required]
    [Column("BRBranchNo")]
    [StringLength(50)]
    public string BrbranchNo { get; set; }

    [Required]
    [Column("BRBranchName")]
    [StringLength(100)]
    public string BrbranchName { get; set; }

    [Column("BRBranchDesc")]
    [StringLength(512)]
    public string BrbranchDesc { get; set; }

    [Required]
    [Column("BRBranchType")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchType { get; set; }

    [Column("BRBranchActiveCheck")]
    public bool? BrbranchActiveCheck { get; set; }

    [Column("BRBranchMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode01Combo { get; set; }

    [Column("BRBranchMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode02Combo { get; set; }

    [Column("BRBranchMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode03Combo { get; set; }

    [Column("BRBranchMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode04Combo { get; set; }

    [Column("BRBranchMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode05Combo { get; set; }

    [Column("BRBranchMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode06Combo { get; set; }

    [Column("BRBranchMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode07Combo { get; set; }

    [Column("BRBranchMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode08Combo { get; set; }

    [Column("BRBranchMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode09Combo { get; set; }

    [Column("BRBranchMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchMatchCode10Combo { get; set; }

    [Column("BRBranchContactName")]
    [StringLength(50)]
    public string BrbranchContactName { get; set; }

    [Column("BRBranchContactBirthday", TypeName = "datetime")]
    public DateTime? BrbranchContactBirthday { get; set; }

    [Column("BRBranchContactFirstName")]
    [StringLength(50)]
    public string BrbranchContactFirstName { get; set; }

    [Column("BRBranchContactLastName")]
    [StringLength(50)]
    public string BrbranchContactLastName { get; set; }

    [Column("BRBranchContactTitle")]
    [StringLength(50)]
    public string BrbranchContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("BRBranchContactHeaderLetter")]
    [StringLength(100)]
    public string BrbranchContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("BRBranchContactHeaderMessage")]
    [StringLength(255)]
    public string BrbranchContactHeaderMessage { get; set; }

    [Column("BRBranchContactEmail1")]
    [StringLength(100)]
    public string BrbranchContactEmail1 { get; set; }

    [Column("BRBranchContactEmail2")]
    [StringLength(100)]
    public string BrbranchContactEmail2 { get; set; }

    [Column("BRBranchContactWebsite")]
    [StringLength(100)]
    public string BrbranchContactWebsite { get; set; }

    [Column("BRBranchContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchContactPhonePrivate { get; set; }

    [Column("BRBranchContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchContactPhone { get; set; }

    [Column("BRBranchContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchContactPhone1 { get; set; }

    [Column("BRBranchContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchContactCellPhone1 { get; set; }

    [Column("BRBranchContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrbranchContactCellPhone { get; set; }

    [Column("BRBranchContactFax")]
    [StringLength(50)]
    public string BrbranchContactFax { get; set; }

    [Column("BRBranchContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string BrbranchContactInformation { get; set; }

    [Column("BRBranchContactDepartment")]
    [StringLength(50)]
    public string BrbranchContactDepartment { get; set; }

    [Column("BRBranchContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string BrbranchContactRoom { get; set; }

    [Column("BRBranchContactAddressStreet")]
    [StringLength(200)]
    public string BrbranchContactAddressStreet { get; set; }

    [Column("BRBranchContactAddressLine1")]
    [StringLength(200)]
    public string BrbranchContactAddressLine1 { get; set; }

    [Column("BRBranchContactAddressLine2")]
    [StringLength(200)]
    public string BrbranchContactAddressLine2 { get; set; }

    [Column("BRBranchContactAddressLine3")]
    [StringLength(200)]
    public string BrbranchContactAddressLine3 { get; set; }

    [Column("BRBranchContactAddressCity")]
    [StringLength(50)]
    public string BrbranchContactAddressCity { get; set; }

    [Column("BRBranchContactAddressPostalCode")]
    [StringLength(50)]
    public string BrbranchContactAddressPostalCode { get; set; }

    [Column("BRBranchContactAddressStateProvince")]
    [StringLength(50)]
    public string BrbranchContactAddressStateProvince { get; set; }

    [Column("BRBranchContactAddressZipCode")]
    [StringLength(50)]
    public string BrbranchContactAddressZipCode { get; set; }

    [Column("BRBranchContactAddressCountry")]
    [StringLength(50)]
    public string BrbranchContactAddressCountry { get; set; }

    [Column("BRBranchParentID")]
    public int? BrbranchParentId { get; set; }

    [Column("BRBranchCompanyName")]
    [StringLength(100)]
    public string BrbranchCompanyName { get; set; }

    [Column("BRBranchWarrantyPhone")]
    [StringLength(50)]
    public string BrbranchWarrantyPhone { get; set; }

    [Column("FK_ACAccountDepositID")]
    public int? FkAcaccountDepositId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("BRBranchBankCode")]
    [StringLength(255)]
    [Unicode(false)]
    public string BrbranchBankCode { get; set; }

    [Column("BRBranchBankName")]
    [StringLength(255)]
    [Unicode(false)]
    public string BrbranchBankName { get; set; }

    [Column("BRBranchContactLevel")]
    [StringLength(255)]
    [Unicode(false)]
    public string BrbranchContactLevel { get; set; }

    [Column("BRBranchTaxNumber")]
    [StringLength(255)]
    [Unicode(false)]
    public string BrbranchTaxNumber { get; set; }

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcaccountDetail> AcaccountDetails { get; set; } = new List<AcaccountDetail>();

    [InverseProperty("FkBrbranchCentral")]
    public virtual ICollection<AcaccountingSheet> AcaccountingSheetFkBrbranchCentrals { get; set; } = new List<AcaccountingSheet>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcaccountingSheet> AcaccountingSheetFkBrbranches { get; set; } = new List<AcaccountingSheet>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcadjustIncreaseOrDecreaseAsset> AcadjustIncreaseOrDecreaseAssetFkBrbranches { get; set; } = new List<AcadjustIncreaseOrDecreaseAsset>();

    [InverseProperty("FkBrinvoiceBranch")]
    public virtual ICollection<AcadjustIncreaseOrDecreaseAsset> AcadjustIncreaseOrDecreaseAssetFkBrinvoiceBranches { get; set; } = new List<AcadjustIncreaseOrDecreaseAsset>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcassetReceipt> AcassetReceipts { get; set; } = new List<AcassetReceipt>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcbalanceAmountArisingObjectDetail> AcbalanceAmountArisingObjectDetails { get; set; } = new List<AcbalanceAmountArisingObjectDetail>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcbalanceAmountArising> AcbalanceAmountArisings { get; set; } = new List<AcbalanceAmountArising>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcbankTransaction> AcbankTransactions { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcbudgetTracking> AcbudgetTrackings { get; set; } = new List<AcbudgetTracking>();

    [InverseProperty("FkBrbranchCentral")]
    public virtual ICollection<AcbusinessResult> AcbusinessResultFkBrbranchCentrals { get; set; } = new List<AcbusinessResult>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcbusinessResult> AcbusinessResultFkBrbranches { get; set; } = new List<AcbusinessResult>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcclearingDebt> AcclearingDebts { get; set; } = new List<AcclearingDebt>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AccostBudgetDetail> AccostBudgetDetails { get; set; } = new List<AccostBudgetDetail>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AccostObject> AccostObjectFkBrbranches { get; set; } = new List<AccostObject>();

    [InverseProperty("FkBrcostedBranch")]
    public virtual ICollection<AccostObject> AccostObjectFkBrcostedBranches { get; set; } = new List<AccostObject>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Acdevice> Acdevices { get; set; } = new List<Acdevice>();

    [InverseProperty("FkBrcostedBranch")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Acdocument> Acdocuments { get; set; } = new List<Acdocument>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcendingAllocation> AcendingAllocations { get; set; } = new List<AcendingAllocation>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AclistAccountBank> AclistAccountBanks { get; set; } = new List<AclistAccountBank>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcloanAgreement> AcloanAgreements { get; set; } = new List<AcloanAgreement>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcloanReceiptItem> AcloanReceiptItems { get; set; } = new List<AcloanReceiptItem>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcloanReceiptPayDoc> AcloanReceiptPayDocs { get; set; } = new List<AcloanReceiptPayDoc>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcloanReceipt> AcloanReceipts { get; set; } = new List<AcloanReceipt>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcmoneyChange> AcmoneyChanges { get; set; } = new List<AcmoneyChange>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcretailVat> AcretailVats { get; set; } = new List<AcretailVat>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcsalaryCalculation> AcsalaryCalculations { get; set; } = new List<AcsalaryCalculation>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcstopAllocationEquipment> AcstopAllocationEquipments { get; set; } = new List<AcstopAllocationEquipment>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AcstopDepreciationAsset> AcstopDepreciationAssets { get; set; } = new List<AcstopDepreciationAsset>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ActaxUnit> ActaxUnits { get; set; } = new List<ActaxUnit>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AdappUserPermission> AdappUserPermissions { get; set; } = new List<AdappUserPermission>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AddataViewPermissionAppStaff> AddataViewPermissionAppStaffs { get; set; } = new List<AddataViewPermissionAppStaff>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AddataViewPermission> AddataViewPermissions { get; set; } = new List<AddataViewPermission>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AdgroupAppStaff> AdgroupAppStaffs { get; set; } = new List<AdgroupAppStaff>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApallocationCost> ApallocationCosts { get; set; } = new List<ApallocationCost>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApbillOfLading> ApbillOfLadings { get; set; } = new List<ApbillOfLading>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApcancelPurchaseOrder> ApcancelPurchaseOrders { get; set; } = new List<ApcancelPurchaseOrder>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApcancelPurchaseProposal> ApcancelPurchaseProposals { get; set; } = new List<ApcancelPurchaseProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApclearInvoiceIn> ApclearInvoiceIns { get; set; } = new List<ApclearInvoiceIn>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceInFkBrbranches { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkBrcreatedBranch")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceInFkBrcreatedBranches { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AppaymentVoucher> AppaymentVouchers { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetails { get; set; } = new List<AppopaymentTimeInvoiceInDetail>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AppriceSheet> AppriceSheets { get; set; } = new List<AppriceSheet>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Approposal> Approposals { get; set; } = new List<Approposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AppurchaseContract> AppurchaseContracts { get; set; } = new List<AppurchaseContract>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApreturnSupplier> ApreturnSuppliers { get; set; } = new List<ApreturnSupplier>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPayments { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Apsupplier> Apsuppliers { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Aracceptance> Aracceptances { get; set; } = new List<Aracceptance>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Aractivity> Aractivities { get; set; } = new List<Aractivity>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AradjustSaleOrderQuantity> AradjustSaleOrderQuantities { get; set; } = new List<AradjustSaleOrderQuantity>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Arallocation> Arallocations { get; set; } = new List<Arallocation>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Arcampaign> Arcampaigns { get; set; } = new List<Arcampaign>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArcancelSaleForecast> ArcancelSaleForecasts { get; set; } = new List<ArcancelSaleForecast>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArcancelVoucher> ArcancelVouchers { get; set; } = new List<ArcancelVoucher>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArcanceledDeliveryPlan> ArcanceledDeliveryPlans { get; set; } = new List<ArcanceledDeliveryPlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArclearInvoice> ArclearInvoices { get; set; } = new List<ArclearInvoice>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArcontainerLoader> ArcontainerLoaders { get; set; } = new List<ArcontainerLoader>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArcreditNote> ArcreditNotes { get; set; } = new List<ArcreditNote>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArcustomerContact> ArcustomerContacts { get; set; } = new List<ArcustomerContact>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPayments { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArdeliveryPlanReportIssue> ArdeliveryPlanReportIssues { get; set; } = new List<ArdeliveryPlanReportIssue>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTrucks { get; set; } = new List<ArdeliveryPlanTruck>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArdeliveryPlan> ArdeliveryPlans { get; set; } = new List<ArdeliveryPlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArdiscountProgram> ArdiscountPrograms { get; set; } = new List<ArdiscountProgram>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AremailTracking> AremailTrackings { get; set; } = new List<AremailTracking>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArinvoiceTransaction> ArinvoiceTransactions { get; set; } = new List<ArinvoiceTransaction>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Arnotification> Arnotifications { get; set; } = new List<Arnotification>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AropenDocument> AropenDocuments { get; set; } = new List<AropenDocument>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Aropportunity> Aropportunities { get; set; } = new List<Aropportunity>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<AropportunityContact> AropportunityContacts { get; set; } = new List<AropportunityContact>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArpriceSheet> ArpriceSheets { get; set; } = new List<ArpriceSheet>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArproductionPlanning> ArproductionPlannings { get; set; } = new List<ArproductionPlanning>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArprospectCustomer> ArprospectCustomers { get; set; } = new List<ArprospectCustomer>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVouchers { get; set; } = new List<ArreceiptVoucher>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Arreception> Arreceptions { get; set; } = new List<Arreception>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArrevenueForecast> ArrevenueForecasts { get; set; } = new List<ArrevenueForecast>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArsaleContract> ArsaleContracts { get; set; } = new List<ArsaleContract>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArsaleForecast> ArsaleForecasts { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArsaleReturn> ArsaleReturns { get; set; } = new List<ArsaleReturn>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<ArsopaymentTimeInvoiceDetail> ArsopaymentTimeInvoiceDetails { get; set; } = new List<ArsopaymentTimeInvoiceDetail>();

    [ForeignKey("BrbranchParentId")]
    [InverseProperty("InverseBrbranchParent")]
    public virtual Brbranch BrbranchParent { get; set; }

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<BrpostingHistory> BrpostingHistories { get; set; } = new List<BrpostingHistory>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<CscashFund> CscashFunds { get; set; } = new List<CscashFund>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Cscompany> Cscompanies { get; set; } = new List<Cscompany>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<CscompanyBank> CscompanyBanks { get; set; } = new List<CscompanyBank>();

    [ForeignKey("FkGelocationId")]
    [InverseProperty("Brbranches")]
    public virtual Gelocation FkGelocation { get; set; }

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<GehistoryDetailOfProductBranchPrice> GehistoryDetailOfProductBranchPrices { get; set; } = new List<GehistoryDetailOfProductBranchPrice>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Genumbering> Genumberings { get; set; } = new List<Genumbering>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HradjustSocialInsurance> HradjustSocialInsurances { get; set; } = new List<HradjustSocialInsurance>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HradvanceRefund> HradvanceRefunds { get; set; } = new List<HradvanceRefund>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HradvanceRequest> HradvanceRequests { get; set; } = new List<HradvanceRequest>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrallowance> Hrallowances { get; set; } = new List<Hrallowance>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrarrangementShift> HrarrangementShifts { get; set; } = new List<HrarrangementShift>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HratmcardPayroll> HratmcardPayrolls { get; set; } = new List<HratmcardPayroll>();

    [InverseProperty("FkBrbranchIdtoWorkNavigation")]
    public virtual ICollection<Hrauthorization> HrauthorizationFkBrbranchIdtoWorkNavigations { get; set; } = new List<Hrauthorization>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrauthorization> HrauthorizationFkBrbranches { get; set; } = new List<Hrauthorization>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrbonusSale> HrbonusSales { get; set; } = new List<HrbonusSale>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrconfigSalesTarget> HrconfigSalesTargets { get; set; } = new List<HrconfigSalesTarget>();

    [InverseProperty("FkBrbranchId2Navigation")]
    public virtual ICollection<HrdepartmentRoomGroup> HrdepartmentRoomGroupFkBrbranchId2Navigations { get; set; } = new List<HrdepartmentRoomGroup>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrdepartmentRoomGroup> HrdepartmentRoomGroupFkBrbranches { get; set; } = new List<HrdepartmentRoomGroup>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrdepartmentRoomGroupTeam> HrdepartmentRoomGroupTeams { get; set; } = new List<HrdepartmentRoomGroupTeam>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrdepartmentRoom> HrdepartmentRooms { get; set; } = new List<HrdepartmentRoom>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrdepartment> Hrdepartments { get; set; } = new List<Hrdepartment>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrdiscipline> Hrdisciplines { get; set; } = new List<Hrdiscipline>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrdormitory> Hrdormitories { get; set; } = new List<Hrdormitory>();

    [InverseProperty("FkBrbranch1Navigation")]
    public virtual ICollection<HremployeeAtmcardPayroll> HremployeeAtmcardPayrollFkBrbranch1Navigations { get; set; } = new List<HremployeeAtmcardPayroll>();

    [InverseProperty("FkBrbranch2Navigation")]
    public virtual ICollection<HremployeeAtmcardPayroll> HremployeeAtmcardPayrollFkBrbranch2Navigations { get; set; } = new List<HremployeeAtmcardPayroll>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeComissionItem> HremployeeComissionItems { get; set; } = new List<HremployeeComissionItem>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeCommissionBranch> HremployeeCommissionBranches { get; set; } = new List<HremployeeCommissionBranch>();

    [InverseProperty("FkBrbranchIdtoWorkNavigation")]
    public virtual ICollection<HremployeeContract> HremployeeContractFkBrbranchIdtoWorkNavigations { get; set; } = new List<HremployeeContract>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeContract> HremployeeContractFkBrbranches { get; set; } = new List<HremployeeContract>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeGroupAppStaff> HremployeeGroupAppStaffs { get; set; } = new List<HremployeeGroupAppStaff>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeGroup> HremployeeGroups { get; set; } = new List<HremployeeGroup>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeSalaryConfig> HremployeeSalaryConfigs { get; set; } = new List<HremployeeSalaryConfig>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranfers { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeTransmit> HremployeeTransmits { get; set; } = new List<HremployeeTransmit>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HremployeeWorkSchedule> HremployeeWorkSchedules { get; set; } = new List<HremployeeWorkSchedule>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrgroup> Hrgroups { get; set; } = new List<Hrgroup>();

    [InverseProperty("FkBrbranchId2Navigation")]
    public virtual ICollection<Hrkpievaluation> HrkpievaluationFkBrbranchId2Navigations { get; set; } = new List<Hrkpievaluation>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrkpievaluation> HrkpievaluationFkBrbranches { get; set; } = new List<Hrkpievaluation>();

    [InverseProperty("FkBrbranchId2Navigation")]
    public virtual ICollection<Hrkpiform> HrkpiformFkBrbranchId2Navigations { get; set; } = new List<Hrkpiform>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrkpiform> HrkpiformFkBrbranches { get; set; } = new List<Hrkpiform>();

    [InverseProperty("FkBrbranchId2Navigation")]
    public virtual ICollection<Hrkpiregistration> HrkpiregistrationFkBrbranchId2Navigations { get; set; } = new List<Hrkpiregistration>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrkpiregistration> HrkpiregistrationFkBrbranches { get; set; } = new List<Hrkpiregistration>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrleaveApplication> HrleaveApplications { get; set; } = new List<HrleaveApplication>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrpayRollAudit> HrpayRollAudits { get; set; } = new List<HrpayRollAudit>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrpayRoll> HrpayRolls { get; set; } = new List<HrpayRoll>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrquarterReward> HrquarterRewards { get; set; } = new List<HrquarterReward>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrrecruitmentNeed> HrrecruitmentNeeds { get; set; } = new List<HrrecruitmentNeed>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrrecruitmentPlan> HrrecruitmentPlans { get; set; } = new List<HrrecruitmentPlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrregisterDormitory> HrregisterDormitories { get; set; } = new List<HrregisterDormitory>();

    [InverseProperty("HrrequestEditEmployeeBranch")]
    public virtual ICollection<HrrequestEditEmployee> HrrequestEditEmployees { get; set; } = new List<HrrequestEditEmployee>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrreward> Hrrewards { get; set; } = new List<Hrreward>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Hrschedule> Hrschedules { get; set; } = new List<Hrschedule>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrsocialInsuranceDeclaration> HrsocialInsuranceDeclarations { get; set; } = new List<HrsocialInsuranceDeclaration>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrsplitRatio> HrsplitRatios { get; set; } = new List<HrsplitRatio>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrtimeSheetAudit> HrtimeSheetAudits { get; set; } = new List<HrtimeSheetAudit>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<HrtimeSheet> HrtimeSheets { get; set; } = new List<HrtimeSheet>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Icadjustment> Icadjustments { get; set; } = new List<Icadjustment>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcconversionProposal> IcconversionProposals { get; set; } = new List<IcconversionProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcinventoryStockCount> IcinventoryStockCounts { get; set; } = new List<IcinventoryStockCount>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcpriceAdjustment> IcpriceAdjustments { get; set; } = new List<IcpriceAdjustment>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcproductApplyPrice> IcproductApplyPrices { get; set; } = new List<IcproductApplyPrice>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcproductBranchPrice> IcproductBranchPrices { get; set; } = new List<IcproductBranchPrice>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcproductBranch> IcproductBranches { get; set; } = new List<IcproductBranch>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcreturnShipping> IcreturnShippings { get; set; } = new List<IcreturnShipping>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcshipmentPlan> IcshipmentPlans { get; set; } = new List<IcshipmentPlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposals { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Icstock> Icstocks { get; set; } = new List<Icstock>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IctransferLog> IctransferLogs { get; set; } = new List<IctransferLog>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<IctransferProposal> IctransferProposals { get; set; } = new List<IctransferProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Ictransfer> Ictransfers { get; set; } = new List<Ictransfer>();

    [InverseProperty("BrbranchParent")]
    public virtual ICollection<Brbranch> InverseBrbranchParent { get; set; } = new List<Brbranch>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmbatchProduct> MmbatchProducts { get; set; } = new List<MmbatchProduct>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmcancelAllocationProposal> MmcancelAllocationProposals { get; set; } = new List<MmcancelAllocationProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlans { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmchangeDeliveryDateBatchProductItem> MmchangeDeliveryDateBatchProductItems { get; set; } = new List<MmchangeDeliveryDateBatchProductItem>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmchangeDeliveryDateBatchProduct> MmchangeDeliveryDateBatchProducts { get; set; } = new List<MmchangeDeliveryDateBatchProduct>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmfalseConditional> MmfalseConditionals { get; set; } = new List<MmfalseConditional>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmjobTicket> MmjobTickets { get; set; } = new List<MmjobTicket>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmoperationDetailPlanCancel> MmoperationDetailPlanCancels { get; set; } = new List<MmoperationDetailPlanCancel>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmoperationDetailPlanCapacity> MmoperationDetailPlanCapacities { get; set; } = new List<MmoperationDetailPlanCapacity>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmoperationDetailPlan> MmoperationDetailPlans { get; set; } = new List<MmoperationDetailPlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Mmoperation> Mmoperations { get; set; } = new List<Mmoperation>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmproductionCostGeneralCostAllocation> MmproductionCostGeneralCostAllocations { get; set; } = new List<MmproductionCostGeneralCostAllocation>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmproposalItem> MmproposalItems { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Mmproposal> Mmproposals { get; set; } = new List<Mmproposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlans { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<MmworkShop> MmworkShops { get; set; } = new List<MmworkShop>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<PmbuidingCommandItem> PmbuidingCommandItems { get; set; } = new List<PmbuidingCommandItem>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<PmbuidingCommand> PmbuidingCommands { get; set; } = new List<PmbuidingCommand>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<PmbuidingProposalItem> PmbuidingProposalItems { get; set; } = new List<PmbuidingProposalItem>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<PmbuidingProposal> PmbuidingProposals { get; set; } = new List<PmbuidingProposal>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Pmproject> Pmprojects { get; set; } = new List<Pmproject>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<PmsaleWork> PmsaleWorks { get; set; } = new List<PmsaleWork>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<PmtaskReportIssue> PmtaskReportIssues { get; set; } = new List<PmtaskReportIssue>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Pmtemplate> Pmtemplates { get; set; } = new List<Pmtemplate>();

    [InverseProperty("FkBrbranch")]
    public virtual ICollection<Vmvehicle> Vmvehicles { get; set; } = new List<Vmvehicle>();
}
