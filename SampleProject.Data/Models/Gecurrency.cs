using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GECurrencies")]
public partial class Gecurrency
{
    [Key]
    [Column("GECurrencyID")]
    public int GecurrencyId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("GECurrencyNo")]
    [StringLength(50)]
    public string GecurrencyNo { get; set; }

    [Required]
    [Column("GECurrencyName")]
    [StringLength(50)]
    public string GecurrencyName { get; set; }

    [Column("GECurrencyDesc")]
    [StringLength(510)]
    public string GecurrencyDesc { get; set; }

    [Column("GECurrencyDecimalNumber")]
    public int? GecurrencyDecimalNumber { get; set; }

    [Column("GECurrencyIsDefault")]
    public bool? GecurrencyIsDefault { get; set; }

    [Column("FK_STFieldFormatGroupID")]
    public int? FkStfieldFormatGroupId { get; set; }

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcaccountDetail> AcaccountDetails { get; set; } = new List<AcaccountDetail>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcactualCostBudget> AcactualCostBudgets { get; set; } = new List<AcactualCostBudget>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcadjustIncreaseOrDecreaseAsset> AcadjustIncreaseOrDecreaseAssets { get; set; } = new List<AcadjustIncreaseOrDecreaseAsset>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcassetReceipt> AcassetReceipts { get; set; } = new List<AcassetReceipt>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcbalanceAmountArisingObjectDetail> AcbalanceAmountArisingObjectDetails { get; set; } = new List<AcbalanceAmountArisingObjectDetail>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcbankTransaction> AcbankTransactions { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcclearingDebtInvoiceInItem> AcclearingDebtInvoiceInItems { get; set; } = new List<AcclearingDebtInvoiceInItem>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcclearingDebtInvoiceItem> AcclearingDebtInvoiceItems { get; set; } = new List<AcclearingDebtInvoiceItem>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcclearingDebt> AcclearingDebts { get; set; } = new List<AcclearingDebt>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AccostBudgetDetail> AccostBudgetDetails { get; set; } = new List<AccostBudgetDetail>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AccostBudget> AccostBudgets { get; set; } = new List<AccostBudget>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Acdocument> Acdocuments { get; set; } = new List<Acdocument>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcendingAllocation> AcendingAllocations { get; set; } = new List<AcendingAllocation>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcloanAgreement> AcloanAgreements { get; set; } = new List<AcloanAgreement>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcloanReceiptItem> AcloanReceiptItems { get; set; } = new List<AcloanReceiptItem>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcloanReceiptPayDoc> AcloanReceiptPayDocs { get; set; } = new List<AcloanReceiptPayDoc>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcloanReceipt> AcloanReceipts { get; set; } = new List<AcloanReceipt>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcmoneyChangeItem> AcmoneyChangeItems { get; set; } = new List<AcmoneyChangeItem>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcretailVat> AcretailVats { get; set; } = new List<AcretailVat>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcrevenueBudget> AcrevenueBudgets { get; set; } = new List<AcrevenueBudget>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AcsalaryCalculation> AcsalaryCalculations { get; set; } = new List<AcsalaryCalculation>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApbillOfLading> ApbillOfLadings { get; set; } = new List<ApbillOfLading>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApcancelPurchaseOrder> ApcancelPurchaseOrders { get; set; } = new List<ApcancelPurchaseOrder>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApclearInvoiceInDocument> ApclearInvoiceInDocuments { get; set; } = new List<ApclearInvoiceInDocument>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApclearInvoiceInInvoiceIn> ApclearInvoiceInInvoiceIns { get; set; } = new List<ApclearInvoiceInInvoiceIn>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApclearInvoiceIn> ApclearInvoiceIns { get; set; } = new List<ApclearInvoiceIn>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApopenDocument> ApopenDocuments { get; set; } = new List<ApopenDocument>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AppaymentProposalItem> AppaymentProposalItems { get; set; } = new List<AppaymentProposalItem>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AppaymentVoucher> AppaymentVouchers { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetails { get; set; } = new List<AppopaymentTimeInvoiceInDetail>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AppriceSheet> AppriceSheets { get; set; } = new List<AppriceSheet>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AppurchaseContract> AppurchaseContracts { get; set; } = new List<AppurchaseContract>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApreturnSupplier> ApreturnSuppliers { get; set; } = new List<ApreturnSupplier>();

    [InverseProperty("ApsupplierBankAccountCurrency1Navigation")]
    public virtual ICollection<Apsupplier> ApsupplierApsupplierBankAccountCurrency1Navigations { get; set; } = new List<Apsupplier>();

    [InverseProperty("ApsupplierBankAccountCurrency2Navigation")]
    public virtual ICollection<Apsupplier> ApsupplierApsupplierBankAccountCurrency2Navigations { get; set; } = new List<Apsupplier>();

    [InverseProperty("ApsupplierBankAccountCurrency3Navigation")]
    public virtual ICollection<Apsupplier> ApsupplierApsupplierBankAccountCurrency3Navigations { get; set; } = new List<Apsupplier>();

    [InverseProperty("ApsupplierBankAccountCurrency4Navigation")]
    public virtual ICollection<Apsupplier> ApsupplierApsupplierBankAccountCurrency4Navigations { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Apsupplier> ApsupplierFkGecurrencies { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkGeassCurrency")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPaymentFkGeassCurrencies { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPaymentFkGecurrencies { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<AradjustSaleOrderQuantity> AradjustSaleOrderQuantities { get; set; } = new List<AradjustSaleOrderQuantity>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArcancelSaleForecast> ArcancelSaleForecasts { get; set; } = new List<ArcancelSaleForecast>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArcancelVoucher> ArcancelVouchers { get; set; } = new List<ArcancelVoucher>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArclearInvoiceDocument> ArclearInvoiceDocuments { get; set; } = new List<ArclearInvoiceDocument>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArclearInvoiceInvoice> ArclearInvoiceInvoices { get; set; } = new List<ArclearInvoiceInvoice>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArclearInvoice> ArclearInvoices { get; set; } = new List<ArclearInvoice>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArconfigOriginalUnitPrice> ArconfigOriginalUnitPrices { get; set; } = new List<ArconfigOriginalUnitPrice>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArcreditNote> ArcreditNotes { get; set; } = new List<ArcreditNote>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArcustomerPaymentCurrency> ArcustomerPaymentCurrencies { get; set; } = new List<ArcustomerPaymentCurrency>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPayments { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Arestimate> Arestimates { get; set; } = new List<Arestimate>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArpaymentProposalItem> ArpaymentProposalItems { get; set; } = new List<ArpaymentProposalItem>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArpriceSheet> ArpriceSheets { get; set; } = new List<ArpriceSheet>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Arproposal> ArproposalFkGecurrencies { get; set; } = new List<Arproposal>();

    [InverseProperty("FkGecurrencyId2Navigation")]
    public virtual ICollection<Arproposal> ArproposalFkGecurrencyId2Navigations { get; set; } = new List<Arproposal>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVouchers { get; set; } = new List<ArreceiptVoucher>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArsaleContract> ArsaleContracts { get; set; } = new List<ArsaleContract>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArsaleForecast> ArsaleForecastFkGecurrencies { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkGecurrencyId2Navigation")]
    public virtual ICollection<ArsaleForecast> ArsaleForecastFkGecurrencyId2Navigations { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkGecurrencies { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkGecurrencyId2Navigation")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkGecurrencyId2Navigations { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArsaleOrderSaleTypeConfig> ArsaleOrderSaleTypeConfigs { get; set; } = new List<ArsaleOrderSaleTypeConfig>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArsaleReturn> ArsaleReturns { get; set; } = new List<ArsaleReturn>();

    [InverseProperty("ArsellerBankAccountCurrency1Navigation")]
    public virtual ICollection<Arseller> ArsellerArsellerBankAccountCurrency1Navigations { get; set; } = new List<Arseller>();

    [InverseProperty("ArsellerBankAccountCurrency2Navigation")]
    public virtual ICollection<Arseller> ArsellerArsellerBankAccountCurrency2Navigations { get; set; } = new List<Arseller>();

    [InverseProperty("ArsellerBankAccountCurrency3Navigation")]
    public virtual ICollection<Arseller> ArsellerArsellerBankAccountCurrency3Navigations { get; set; } = new List<Arseller>();

    [InverseProperty("ArsellerBankAccountCurrency4Navigation")]
    public virtual ICollection<Arseller> ArsellerArsellerBankAccountCurrency4Navigations { get; set; } = new List<Arseller>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Arseller> ArsellerFkGecurrencies { get; set; } = new List<Arseller>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<ArsopaymentTimeInvoiceDetail> ArsopaymentTimeInvoiceDetails { get; set; } = new List<ArsopaymentTimeInvoiceDetail>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Brposs> Brposses { get; set; } = new List<Brposs>();

    [InverseProperty("FkGepurchaseCurrency")]
    public virtual ICollection<Cscompany> CscompanyFkGepurchaseCurrencies { get; set; } = new List<Cscompany>();

    [InverseProperty("FkGesaleCurrency")]
    public virtual ICollection<Cscompany> CscompanyFkGesaleCurrencies { get; set; } = new List<Cscompany>();

    [InverseProperty("FacurrencyIdcomboNavigation")]
    public virtual ICollection<FacreditNote> FacreditNotes { get; set; } = new List<FacreditNote>();

    [InverseProperty("FacurrencyIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrder> FapurchaseOrders { get; set; } = new List<FapurchaseOrder>();

    [InverseProperty("FacurrencyIdcomboNavigation")]
    public virtual ICollection<FareturnSupplier> FareturnSuppliers { get; set; } = new List<FareturnSupplier>();

    [InverseProperty("FacurrencyIdcomboNavigation")]
    public virtual ICollection<FasellReturn> FasellReturns { get; set; } = new List<FasellReturn>();

    [ForeignKey("FkStfieldFormatGroupId")]
    [InverseProperty("Gecurrencies")]
    public virtual StfieldFormatGroup FkStfieldFormatGroup { get; set; }

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<GecurrencyExchangeRate> GecurrencyExchangeRates { get; set; } = new List<GecurrencyExchangeRate>();

    [InverseProperty("Gecurrency")]
    public virtual ICollection<GecurrencyHistory> GecurrencyHistories { get; set; } = new List<GecurrencyHistory>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<GehistoryDetailOfProductBranchPrice> GehistoryDetailOfProductBranchPrices { get; set; } = new List<GehistoryDetailOfProductBranchPrice>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<HradvanceRefund> HradvanceRefunds { get; set; } = new List<HradvanceRefund>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<HradvanceRequest> HradvanceRequests { get; set; } = new List<HradvanceRequest>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Icadjustment> Icadjustments { get; set; } = new List<Icadjustment>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<IcproductBranchPrice> IcproductBranchPrices { get; set; } = new List<IcproductBranchPrice>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Icstock> Icstocks { get; set; } = new List<Icstock>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<Ictransfer> Ictransfers { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkGecurrency")]
    public virtual ICollection<MmcalculatorProductionNormCost> MmcalculatorProductionNormCosts { get; set; } = new List<MmcalculatorProductionNormCost>();

    [InverseProperty("Gecurrency")]
    public virtual ICollection<Oeproposal> Oeproposals { get; set; } = new List<Oeproposal>();
}
