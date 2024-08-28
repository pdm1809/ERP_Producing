using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSuppliers")]
[Microsoft.EntityFrameworkCore.Index("ApsupplierNo", "FkBrbranchId", "ApsupplierTypeCombo", Name = "Idx_APSuppliers")]
public partial class Apsupplier
{
    [Key]
    [Column("APSupplierID")]
    public int ApsupplierId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_APSupplierParentID")]
    public int? FkApsupplierParentId { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("APSupplierNo")]
    [StringLength(50)]
    public string ApsupplierNo { get; set; }

    [Column("APSupplierName")]
    [StringLength(255)]
    public string ApsupplierName { get; set; }

    [Column("APSupplierName1")]
    [StringLength(100)]
    public string ApsupplierName1 { get; set; }

    [Column("APSupplierName2")]
    [StringLength(100)]
    public string ApsupplierName2 { get; set; }

    [Column("APSupplierName3")]
    [StringLength(100)]
    public string ApsupplierName3 { get; set; }

    [Column("APSupplierDesc")]
    [StringLength(255)]
    public string ApsupplierDesc { get; set; }

    [Required]
    [Column("APSupplierActiveCheck")]
    public bool? ApsupplierActiveCheck { get; set; }

    [Column("APSupplierWebsite")]
    [StringLength(100)]
    public string ApsupplierWebsite { get; set; }

    [Column("APSupplierTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierTaxNumber { get; set; }

    [Column("APPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentMethodCombo { get; set; }

    [Column("APSupplierPaymentTerm")]
    [StringLength(50)]
    public string ApsupplierPaymentTerm { get; set; }

    [Column("APSupplierDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierDiscount { get; set; }

    [Column("APSupplierDebitLimit", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierDebitLimit { get; set; }

    [Column("APSupplierOwing", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierOwing { get; set; }

    [Column("APSupplierMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode01Combo { get; set; }

    [Column("APSupplierMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode02Combo { get; set; }

    [Column("APSupplierMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode03Combo { get; set; }

    [Column("APSupplierMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode04Combo { get; set; }

    [Column("APSupplierMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode05Combo { get; set; }

    [Column("APSupplierMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode06Combo { get; set; }

    [Column("APSupplierMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode07Combo { get; set; }

    [Column("APSupplierMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode08Combo { get; set; }

    [Column("APSupplierMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode09Combo { get; set; }

    [Column("APSupplierMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode10Combo { get; set; }

    [Column("APSupplierMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode11Combo { get; set; }

    [Column("APSupplierMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode12Combo { get; set; }

    [Column("APSupplierMatchCode13Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode13Combo { get; set; }

    [Column("APSupplierMatchCode14Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode14Combo { get; set; }

    [Column("APSupplierMatchCode15Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode15Combo { get; set; }

    [Column("APSupplierMatchCode16Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierMatchCode16Combo { get; set; }

    [Column("APSupplierTypeCombo")]
    [StringLength(50)]
    public string ApsupplierTypeCombo { get; set; }

    [Column("APSupplierStartDate", TypeName = "datetime")]
    public DateTime? ApsupplierStartDate { get; set; }

    [Column("APSupplierTel1")]
    [StringLength(50)]
    public string ApsupplierTel1 { get; set; }

    [Column("APSupplierTel2")]
    [StringLength(50)]
    public string ApsupplierTel2 { get; set; }

    [Column("APSupplierTel3")]
    [StringLength(50)]
    public string ApsupplierTel3 { get; set; }

    [Column("APSupplierContactName")]
    [StringLength(50)]
    public string ApsupplierContactName { get; set; }

    [Column("APSupplierContactBirthday", TypeName = "datetime")]
    public DateTime? ApsupplierContactBirthday { get; set; }

    [Column("APSupplierContactFirstName")]
    [StringLength(50)]
    public string ApsupplierContactFirstName { get; set; }

    [Column("APSupplierContactLastName")]
    [StringLength(50)]
    public string ApsupplierContactLastName { get; set; }

    [Column("APSupplierContactTitle")]
    [StringLength(50)]
    public string ApsupplierContactTitle { get; set; }

    [Column("APSupplierContactHeaderLetter")]
    [StringLength(100)]
    public string ApsupplierContactHeaderLetter { get; set; }

    [Column("APSupplierContactHeaderMessage")]
    [StringLength(255)]
    public string ApsupplierContactHeaderMessage { get; set; }

    [Column("APSupplierContactEmail1")]
    [StringLength(100)]
    public string ApsupplierContactEmail1 { get; set; }

    [Column("APSupplierContactEmail2")]
    [StringLength(100)]
    public string ApsupplierContactEmail2 { get; set; }

    [Column("APSupplierContactWebsite")]
    [StringLength(100)]
    public string ApsupplierContactWebsite { get; set; }

    [Column("APSupplierContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactPhonePrivate { get; set; }

    [Column("APSupplierContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactPhone { get; set; }

    [Column("APSupplierContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactPhone1 { get; set; }

    [Column("APSupplierContactPhone2")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactPhone2 { get; set; }

    [Column("APSupplierContactPhone3")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactPhone3 { get; set; }

    [Column("APSupplierContactPhone4")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactPhone4 { get; set; }

    [Column("APSupplierContactCellPhone1")]
    [StringLength(256)]
    public string ApsupplierContactCellPhone1 { get; set; }

    [Column("APSupplierContactCellPhone")]
    [StringLength(256)]
    public string ApsupplierContactCellPhone { get; set; }

    [Column("APSupplierContactFax")]
    [StringLength(50)]
    public string ApsupplierContactFax { get; set; }

    [Column("APSupplierContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ApsupplierContactInformation { get; set; }

    [Column("APSupplierContactDepartment")]
    [StringLength(50)]
    public string ApsupplierContactDepartment { get; set; }

    [Column("APSupplierContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ApsupplierContactRoom { get; set; }

    [Column("APSupplierContactAddressStreet")]
    [StringLength(200)]
    public string ApsupplierContactAddressStreet { get; set; }

    [Required]
    [Column("APSupplierContactAddressLine1")]
    [StringLength(200)]
    public string ApsupplierContactAddressLine1 { get; set; }

    [Column("APSupplierContactAddressLine2")]
    [StringLength(200)]
    public string ApsupplierContactAddressLine2 { get; set; }

    [Column("APSupplierContactAddressLine3")]
    [StringLength(200)]
    public string ApsupplierContactAddressLine3 { get; set; }

    [Column("APSupplierContactAddressCity")]
    [StringLength(50)]
    public string ApsupplierContactAddressCity { get; set; }

    [Column("APSupplierContactAddressPostalCode")]
    [StringLength(50)]
    public string ApsupplierContactAddressPostalCode { get; set; }

    [Column("APSupplierContactAddressStateProvince")]
    [StringLength(50)]
    public string ApsupplierContactAddressStateProvince { get; set; }

    [Column("APSupplierContactAddressZipCode")]
    [StringLength(50)]
    public string ApsupplierContactAddressZipCode { get; set; }

    [Column("APSupplierContactAddressCountry")]
    [StringLength(50)]
    public string ApsupplierContactAddressCountry { get; set; }

    [Column("APSupplierBankName")]
    [StringLength(250)]
    public string ApsupplierBankName { get; set; }

    [Column("APSupplierBankAccount1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierBankAccount1 { get; set; }

    [Column("APSupplierBankAccountCurrency1")]
    public int? ApsupplierBankAccountCurrency1 { get; set; }

    [Column("APSupplierBankAccount2")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierBankAccount2 { get; set; }

    [Column("APSupplierBankAccountCurrency2")]
    public int? ApsupplierBankAccountCurrency2 { get; set; }

    [Column("APSupplierBankAccount3")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierBankAccount3 { get; set; }

    [Column("APSupplierBankAccountCurrency3")]
    public int? ApsupplierBankAccountCurrency3 { get; set; }

    [Column("APSupplierBankAccount4")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierBankAccount4 { get; set; }

    [Column("APSupplierBankAccountCurrency4")]
    public int? ApsupplierBankAccountCurrency4 { get; set; }

    [Column("APSupplierBankDesc")]
    [StringLength(255)]
    public string ApsupplierBankDesc { get; set; }

    [Column("APSupplierBankCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierBankCode { get; set; }

    [Column("APSupplierDueDays")]
    public int? ApsupplierDueDays { get; set; }

    public bool? IsBuyingLocked { get; set; }

    public bool? IsPaymentLocked { get; set; }

    [Column("FK_GECountryID")]
    public int FkGecountryId { get; set; }

    [Column("FK_GEStateProvinceID")]
    public int FkGestateProvinceId { get; set; }

    [Column("FK_GEDistrictID")]
    public int? FkGedistrictId { get; set; }

    [Column("APSupplierNoOfOldSys")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierNoOfOldSys { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int? FkGepaymentTermId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("APSupplierSWIFTCode")]
    [StringLength(50)]
    public string ApsupplierSwiftcode { get; set; }

    [Column("APSuppliersDiscountType")]
    [StringLength(50)]
    public string ApsuppliersDiscountType { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_ACAccountDepositID")]
    public int? FkAcaccountDepositId { get; set; }

    [Column("APSupplierOtherType")]
    [StringLength(50)]
    public string ApsupplierOtherType { get; set; }

    [Column("FK_APSupplierTypeAccountConfigID")]
    public int FkApsupplierTypeAccountConfigId { get; set; }

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<AcassetReceipt> AcassetReceipts { get; set; } = new List<AcassetReceipt>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApcancelPurchaseOrder> ApcancelPurchaseOrders { get; set; } = new List<ApcancelPurchaseOrder>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApopenDocument> ApopenDocuments { get; set; } = new List<ApopenDocument>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<AppurchaseOrderHistory> AppurchaseOrderHistories { get; set; } = new List<AppurchaseOrderHistory>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApreturnSupplier> ApreturnSuppliers { get; set; } = new List<ApreturnSupplier>();

    [ForeignKey("ApsupplierBankAccountCurrency1")]
    [InverseProperty("ApsupplierApsupplierBankAccountCurrency1Navigations")]
    public virtual Gecurrency ApsupplierBankAccountCurrency1Navigation { get; set; }

    [ForeignKey("ApsupplierBankAccountCurrency2")]
    [InverseProperty("ApsupplierApsupplierBankAccountCurrency2Navigations")]
    public virtual Gecurrency ApsupplierBankAccountCurrency2Navigation { get; set; }

    [ForeignKey("ApsupplierBankAccountCurrency3")]
    [InverseProperty("ApsupplierApsupplierBankAccountCurrency3Navigations")]
    public virtual Gecurrency ApsupplierBankAccountCurrency3Navigation { get; set; }

    [ForeignKey("ApsupplierBankAccountCurrency4")]
    [InverseProperty("ApsupplierApsupplierBankAccountCurrency4Navigations")]
    public virtual Gecurrency ApsupplierBankAccountCurrency4Navigation { get; set; }

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApsupplierComment> ApsupplierComments { get; set; } = new List<ApsupplierComment>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApsupplierContact> ApsupplierContacts { get; set; } = new List<ApsupplierContact>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApsupplierDepartment> ApsupplierDepartments { get; set; } = new List<ApsupplierDepartment>();

    [InverseProperty("FkApassociatedSupplier")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPaymentFkApassociatedSuppliers { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPaymentFkApsuppliers { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApsupplierProductDiscount> ApsupplierProductDiscounts { get; set; } = new List<ApsupplierProductDiscount>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApsupplierProductGroupDiscount> ApsupplierProductGroupDiscounts { get; set; } = new List<ApsupplierProductGroupDiscount>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ApsupplierProductNumber> ApsupplierProductNumbers { get; set; } = new List<ApsupplierProductNumber>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [InverseProperty("Fasupplier")]
    public virtual ICollection<FapurchaseOrderHistory> FapurchaseOrderHistories { get; set; } = new List<FapurchaseOrderHistory>();

    [InverseProperty("FasupplierIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrder> FapurchaseOrders { get; set; } = new List<FapurchaseOrder>();

    [InverseProperty("Fasupplier")]
    public virtual ICollection<FareceiptHistory> FareceiptHistories { get; set; } = new List<FareceiptHistory>();

    [InverseProperty("Fasupplier")]
    public virtual ICollection<FareturnSupplierHistory> FareturnSupplierHistories { get; set; } = new List<FareturnSupplierHistory>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("ApsupplierFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcaccountPurchaseId")]
    [InverseProperty("ApsupplierFkAcaccountPurchases")]
    public virtual Acaccount FkAcaccountPurchase { get; set; }

    [ForeignKey("FkAcaccountSaleId")]
    [InverseProperty("ApsupplierFkAcaccountSales")]
    public virtual Acaccount FkAcaccountSale { get; set; }

    [ForeignKey("FkApsupplierParentId")]
    [InverseProperty("InverseFkApsupplierParent")]
    public virtual Apsupplier FkApsupplierParent { get; set; }

    [ForeignKey("FkApsupplierTypeAccountConfigId")]
    [InverseProperty("Apsuppliers")]
    public virtual ApsupplierTypeAccountConfig FkApsupplierTypeAccountConfig { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Apsuppliers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("Apsuppliers")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApsupplierFkGecurrencies")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGedistrictId")]
    [InverseProperty("Apsuppliers")]
    public virtual Gedistrict FkGedistrict { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("Apsuppliers")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("Apsuppliers")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("Apsuppliers")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkGestateProvinceId")]
    [InverseProperty("Apsuppliers")]
    public virtual GestateProvince FkGestateProvince { get; set; }

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<Icpackage> Icpackages { get; set; } = new List<Icpackage>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<IcproductSupplier> IcproductSuppliers { get; set; } = new List<IcproductSupplier>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkApsupplierParent")]
    public virtual ICollection<Apsupplier> InverseFkApsupplierParent { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<MmcanceledPurchasePlanItem> MmcanceledPurchasePlanItems { get; set; } = new List<MmcanceledPurchasePlanItem>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<MmformulaConfiguration> MmformulaConfigurations { get; set; } = new List<MmformulaConfiguration>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<MmpaintProcessess> MmpaintProcessesses { get; set; } = new List<MmpaintProcessess>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkApsupplier")]
    public virtual ICollection<MmpurchasePlanItem> MmpurchasePlanItems { get; set; } = new List<MmpurchasePlanItem>();
}
