using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomers")]
[Microsoft.EntityFrameworkCore.Index("ArcustomerNo", "FkBrbranchId", "ArcustomerTypeCombo", Name = "Idx_ARCustomers")]
public partial class Arcustomer
{
    [Key]
    [Column("ARCustomerID")]
    public int ArcustomerId { get; set; }

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

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_ARSellerID")]
    public int? FkArsellerId { get; set; }

    [Column("FK_ARPriceListID1")]
    public int? FkArpriceListId1 { get; set; }

    [Column("FK_ARPriceListID2")]
    public int? FkArpriceListId2 { get; set; }

    [Column("FK_ARPriceListID3")]
    public int? FkArpriceListId3 { get; set; }

    [Column("FK_ARPriceListID4")]
    public int? FkArpriceListId4 { get; set; }

    [Column("FK_ARPriceLevelID")]
    public int? FkArpriceLevelId { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARCustomerPaymentTerm")]
    [StringLength(50)]
    public string ArcustomerPaymentTerm { get; set; }

    [Required]
    [Column("ARCustomerNo")]
    [StringLength(50)]
    public string ArcustomerNo { get; set; }

    [Column("ARCustomerName")]
    [StringLength(4000)]
    public string ArcustomerName { get; set; }

    [Column("ARCustomerName1")]
    [StringLength(100)]
    public string ArcustomerName1 { get; set; }

    [Column("ARCustomerName2")]
    [StringLength(100)]
    public string ArcustomerName2 { get; set; }

    [Column("ARCustomerName3")]
    [StringLength(100)]
    public string ArcustomerName3 { get; set; }

    [Column("ARCustomerDesc")]
    [StringLength(255)]
    public string ArcustomerDesc { get; set; }

    [Column("ARCustomerActiveCheck")]
    public bool ArcustomerActiveCheck { get; set; }

    [Column("ARCustomerWebsite")]
    [StringLength(100)]
    public string ArcustomerWebsite { get; set; }

    [Column("ARCustomerTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerTaxNumber { get; set; }

    [Column("ARCustomerDiscount", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerDiscount { get; set; }

    [Column("ARCustomerCreditLimit", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerCreditLimit { get; set; }

    [Column("ARCustomerOwing", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerOwing { get; set; }

    [Column("ARCustomerDueDays")]
    public int? ArcustomerDueDays { get; set; }

    [Column("ARCustomerMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode01Combo { get; set; }

    [Column("ARCustomerMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode02Combo { get; set; }

    [Column("ARCustomerMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode03Combo { get; set; }

    [Column("ARCustomerMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode04Combo { get; set; }

    [Column("ARCustomerMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode05Combo { get; set; }

    [Column("ARCustomerMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode06Combo { get; set; }

    [Column("ARCustomerMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode07Combo { get; set; }

    [Column("ARCustomerMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode08Combo { get; set; }

    [Column("ARCustomerMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode09Combo { get; set; }

    [Column("ARCustomerMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode10Combo { get; set; }

    [Column("ARCustomerMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode11Combo { get; set; }

    [Column("ARCustomerMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode12Combo { get; set; }

    [Column("ARCustomerMatchCode13Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode13Combo { get; set; }

    [Column("ARCustomerMatchCode14Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode14Combo { get; set; }

    [Column("ARCustomerMatchCode15Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode15Combo { get; set; }

    [Column("ARCustomerMatchCode16Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerMatchCode16Combo { get; set; }

    [Required]
    [Column("ARCustomerTypeCombo")]
    [StringLength(50)]
    public string ArcustomerTypeCombo { get; set; }

    [Column("ARCustomerStartDate", TypeName = "datetime")]
    public DateTime? ArcustomerStartDate { get; set; }

    [Column("ARCustomerTel1")]
    [StringLength(50)]
    public string ArcustomerTel1 { get; set; }

    [Column("ARCustomerTel2")]
    [StringLength(50)]
    public string ArcustomerTel2 { get; set; }

    [Column("ARCustomerTel3")]
    [StringLength(50)]
    public string ArcustomerTel3 { get; set; }

    [Column("ARCustomerContactName")]
    [StringLength(50)]
    public string ArcustomerContactName { get; set; }

    [Column("ARCustomerContactBirthday", TypeName = "datetime")]
    public DateTime? ArcustomerContactBirthday { get; set; }

    [Column("ARCustomerContactFirstName")]
    [StringLength(50)]
    public string ArcustomerContactFirstName { get; set; }

    [Column("ARCustomerContactLastName")]
    [StringLength(50)]
    public string ArcustomerContactLastName { get; set; }

    [Column("ARCustomerContactTitle")]
    [StringLength(50)]
    public string ArcustomerContactTitle { get; set; }

    [Column("ARCustomerContactHeaderLetter")]
    [StringLength(100)]
    public string ArcustomerContactHeaderLetter { get; set; }

    [Column("ARCustomerContactHeaderMessage")]
    [StringLength(255)]
    public string ArcustomerContactHeaderMessage { get; set; }

    [Column("ARCustomerContactEmail1")]
    [StringLength(100)]
    public string ArcustomerContactEmail1 { get; set; }

    [Column("ARCustomerContactEmail2")]
    [StringLength(100)]
    public string ArcustomerContactEmail2 { get; set; }

    [Column("ARCustomerContactWebsite")]
    [StringLength(100)]
    public string ArcustomerContactWebsite { get; set; }

    [Column("ARCustomerContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactPhonePrivate { get; set; }

    [Column("ARCustomerContactPhone")]
    [StringLength(50)]
    public string ArcustomerContactPhone { get; set; }

    [Column("ARCustomerContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactPhone1 { get; set; }

    [Column("ARCustomerContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactCellPhone1 { get; set; }

    [Column("ARCustomerContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactCellPhone { get; set; }

    [Column("ARCustomerContactFax")]
    [StringLength(50)]
    public string ArcustomerContactFax { get; set; }

    [Column("ARCustomerContactInformation")]
    [StringLength(2000)]
    public string ArcustomerContactInformation { get; set; }

    [Column("ARCustomerContactDepartment")]
    [StringLength(50)]
    public string ArcustomerContactDepartment { get; set; }

    [Column("ARCustomerContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArcustomerContactRoom { get; set; }

    [Column("ARCustomerContactAddressLine1")]
    [StringLength(200)]
    public string ArcustomerContactAddressLine1 { get; set; }

    [Column("ARCustomerContactAddressLine2")]
    [StringLength(200)]
    public string ArcustomerContactAddressLine2 { get; set; }

    [Column("ARCustomerContactAddressLine3")]
    [StringLength(200)]
    public string ArcustomerContactAddressLine3 { get; set; }

    [Column("ARCustomerContactAddressCity")]
    [StringLength(50)]
    public string ArcustomerContactAddressCity { get; set; }

    [Column("ARCustomerContactAddressStateProvince")]
    [StringLength(50)]
    public string ArcustomerContactAddressStateProvince { get; set; }

    [Column("ARCustomerContactAddressCountry")]
    [StringLength(50)]
    public string ArcustomerContactAddressCountry { get; set; }

    [Column("ARCustomerContactAddressPostalCode")]
    [StringLength(50)]
    public string ArcustomerContactAddressPostalCode { get; set; }

    [Column("ARCustomerInvoiceAddressStreet")]
    [StringLength(200)]
    public string ArcustomerInvoiceAddressStreet { get; set; }

    [Column("ARCustomerInvoiceAddressLine1")]
    [StringLength(200)]
    public string ArcustomerInvoiceAddressLine1 { get; set; }

    [Column("ARCustomerInvoiceAddressLine2")]
    [StringLength(200)]
    public string ArcustomerInvoiceAddressLine2 { get; set; }

    [Column("ARCustomerInvoiceAddressLine3")]
    [StringLength(200)]
    public string ArcustomerInvoiceAddressLine3 { get; set; }

    [Column("ARCustomerInvoiceAddressCity")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressCity { get; set; }

    [Column("ARCustomerInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressPostalCode { get; set; }

    [Column("ARCustomerInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressStateProvince { get; set; }

    [Column("ARCustomerInvoiceAddressZipCode")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressZipCode { get; set; }

    [Column("ARCustomerInvoiceAddressCountry")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressCountry { get; set; }

    [Column("ARCustomerDeliveryAddressStreet")]
    [StringLength(200)]
    public string ArcustomerDeliveryAddressStreet { get; set; }

    [Column("ARCustomerDeliveryAddressLine1")]
    [StringLength(200)]
    public string ArcustomerDeliveryAddressLine1 { get; set; }

    [Column("ARCustomerDeliveryAddressLine2")]
    [StringLength(200)]
    public string ArcustomerDeliveryAddressLine2 { get; set; }

    [Column("ARCustomerDeliveryAddressLine3")]
    [StringLength(200)]
    public string ArcustomerDeliveryAddressLine3 { get; set; }

    [Column("ARCustomerDeliveryAddressCity")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressCity { get; set; }

    [Column("ARCustomerDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressPostalCode { get; set; }

    [Column("ARCustomerDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressStateProvince { get; set; }

    [Column("ARCustomerDeliveryAddressZipCode")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressZipCode { get; set; }

    [Column("ARCustomerDeliveryAddressCountry")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressCountry { get; set; }

    [Column("ARCustomerPaymentAddressStreet")]
    [StringLength(200)]
    public string ArcustomerPaymentAddressStreet { get; set; }

    [Column("ARCustomerPaymentAddressLine1")]
    [StringLength(200)]
    public string ArcustomerPaymentAddressLine1 { get; set; }

    [Column("ARCustomerPaymentAddressLine2")]
    [StringLength(200)]
    public string ArcustomerPaymentAddressLine2 { get; set; }

    [Column("ARCustomerPaymentAddressLine3")]
    [StringLength(200)]
    public string ArcustomerPaymentAddressLine3 { get; set; }

    [Column("ARCustomerPaymentAddressCity")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressCity { get; set; }

    [Column("ARCustomerPaymentAddressPostalCode")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressPostalCode { get; set; }

    [Column("ARCustomerPaymentAddressStateProvince")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressStateProvince { get; set; }

    [Column("ARCustomerPaymentAddressZipCode")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressZipCode { get; set; }

    [Column("ARCustomerPaymentAddressCountry")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressCountry { get; set; }

    [Column("ARCustomerBankCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerBankCode { get; set; }

    [Column("ARCustomerBankAccount1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerBankAccount1 { get; set; }

    [Column("ARCustomerBankAccountCurrency1")]
    public int? ArcustomerBankAccountCurrency1 { get; set; }

    [Column("ARCustomerBankAccount2")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerBankAccount2 { get; set; }

    [Column("ARCustomerBankAccountCurrency2")]
    public int? ArcustomerBankAccountCurrency2 { get; set; }

    [Column("ARCustomerBankAccount3")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerBankAccount3 { get; set; }

    [Column("ARCustomerBankAccountCurrency3")]
    public int? ArcustomerBankAccountCurrency3 { get; set; }

    [Column("ARCustomerBankAccount4")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerBankAccount4 { get; set; }

    [Column("ARCustomerBankAccountCurrency4")]
    public int? ArcustomerBankAccountCurrency4 { get; set; }

    [Column("ARCustomerBankName")]
    [StringLength(50)]
    public string ArcustomerBankName { get; set; }

    public bool? IsBuyingLocked { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARCustomerTransferredDate", TypeName = "datetime")]
    public DateTime? ArcustomerTransferredDate { get; set; }

    [Column("FK_GELocationID1")]
    public int? FkGelocationId1 { get; set; }

    [Column("FK_GELocationID2")]
    public int? FkGelocationId2 { get; set; }

    [Column("FK_GELocationID3")]
    public int? FkGelocationId3 { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int? FkGepaymentTermId { get; set; }

    [Column("ARCustomerLevel")]
    [StringLength(100)]
    public string ArcustomerLevel { get; set; }

    [Column("ARCustomerNoOfOldSys")]
    [StringLength(50)]
    public string ArcustomerNoOfOldSys { get; set; }

    [Column("ARCustomerInvoiceAddressTaxCode")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressTaxCode { get; set; }

    [Column("ARCustomerInvoiceAddressTel")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressTel { get; set; }

    [Column("ARCustomerInvoiceAddressFax")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressFax { get; set; }

    [Column("ARCustomerDeliveryAddressTaxCode")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressTaxCode { get; set; }

    [Column("ARCustomerDeliveryAddressTel")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressTel { get; set; }

    [Column("ARCustomerDeliveryAddressFax")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressFax { get; set; }

    [Column("ARCustomerPaymentAddressTaxCode")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressTaxCode { get; set; }

    [Column("ARCustomerPaymentAddressTel")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressTel { get; set; }

    [Column("ARCustomerPaymentAddressFax")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressFax { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ARCustomerCMND")]
    [StringLength(50)]
    public string ArcustomerCmnd { get; set; }

    [Column("ARCustomerDeliveryContactName")]
    [StringLength(256)]
    public string ArcustomerDeliveryContactName { get; set; }

    [Column("ARCustomerSex")]
    [StringLength(256)]
    [Unicode(false)]
    public string ArcustomerSex { get; set; }

    [Column("ARCustomerStatus")]
    [StringLength(256)]
    [Unicode(false)]
    public string ArcustomerStatus { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_ACAccountDepositID")]
    public int? FkAcaccountDepositId { get; set; }

    [Column("ARCustomerPaymentAddressWard")]
    [StringLength(256)]
    public string ArcustomerPaymentAddressWard { get; set; }

    [Column("FK_GEDeliveryDistrictID")]
    public int? FkGedeliveryDistrictId { get; set; }

    [Column("FK_GEDeliveryStateProvinceID")]
    public int? FkGedeliveryStateProvinceId { get; set; }

    [Column("FK_GEDeliveryWardID")]
    public int? FkGedeliveryWardId { get; set; }

    [Column("FK_GEDeliveryStreetID")]
    public int? FkGedeliveryStreetId { get; set; }

    [Column("ARCustomerDeliveryHomeNumber")]
    [StringLength(128)]
    public string ArcustomerDeliveryHomeNumber { get; set; }

    [Column("FK_GEDeliveryCountryID")]
    public int? FkGedeliveryCountryId { get; set; }

    [Column("FK_ARCustomerTypeAccountConfigID")]
    public int FkArcustomerTypeAccountConfigId { get; set; }

    [Column("FK_ARCustomerResourceID")]
    public int? FkArcustomerResourceId { get; set; }

    [Column("ARCustomerAssignedTo")]
    [StringLength(2000)]
    public string ArcustomerAssignedTo { get; set; }

    [Column("ARCustomerBonusScore")]
    public int? ArcustomerBonusScore { get; set; }

    [Column("ARCustomerBusiness")]
    [StringLength(2000)]
    public string ArcustomerBusiness { get; set; }

    [Column("ARCustomerChangedUser")]
    [StringLength(50)]
    public string ArcustomerChangedUser { get; set; }

    [Column("ARCustomerClassify")]
    [StringLength(2000)]
    public string ArcustomerClassify { get; set; }

    [Column("ARCustomerCompanyEstablishmentDay", TypeName = "datetime")]
    public DateTime? ArcustomerCompanyEstablishmentDay { get; set; }

    [Column("CreatedUserID")]
    public int? CreatedUserId { get; set; }

    [Column("ARCustomerGroupCombo")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerGroupCombo { get; set; }

    [Column("ARCustomerContactAddressDistrict")]
    [StringLength(2000)]
    public string ArcustomerContactAddressDistrict { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARCustomerEvaluate")]
    public int? ArcustomerEvaluate { get; set; }

    [Column("ARGender")]
    [StringLength(255)]
    [Unicode(false)]
    public string Argender { get; set; }

    [Column("ARCustomerGroup")]
    [StringLength(500)]
    public string ArcustomerGroup { get; set; }

    [Column("REV")]
    public int? Rev { get; set; }

    [Column("REVTYPE")]
    public int? Revtype { get; set; }

    [Column("ARCustomerRevenueDueYear", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerRevenueDueYear { get; set; }

    [Column("ARCustomerStockCode")]
    [StringLength(500)]
    [Unicode(false)]
    public string ArcustomerStockCode { get; set; }

    [Column("UpdatedUserID")]
    public int? UpdatedUserId { get; set; }

    [Column("FK_ARProspectCustomerID")]
    public int? FkArprospectCustomerId { get; set; }

    [Column("FK_ADFengShuisColorID")]
    public int? FkAdfengShuisColorId { get; set; }

    [Column("FK_ADFengShuisGenaralID")]
    public int? FkAdfengShuisGenaralId { get; set; }

    [Column("FK_ADFengShuisDirectionID")]
    public int? FkAdfengShuisDirectionId { get; set; }

    [Column("ARCustomerLunarBirthday")]
    [StringLength(50)]
    public string ArcustomerLunarBirthday { get; set; }

    [Column("ARCustomerCRMType")]
    [StringLength(50)]
    public string ArcustomerCrmtype { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [Column("ARCustomerAvailableCredit", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerAvailableCredit { get; set; }

    [Column("ARCustomerInvoiceContactName")]
    [StringLength(256)]
    public string ArcustomerInvoiceContactName { get; set; }

    [Column("ARCustomerPaymentContactName")]
    [StringLength(256)]
    public string ArcustomerPaymentContactName { get; set; }

    [Column("ARCustomerDeliveryAddressEmail")]
    [StringLength(50)]
    public string ArcustomerDeliveryAddressEmail { get; set; }

    [Column("ARCustomerPaymentAddressEmail")]
    [StringLength(50)]
    public string ArcustomerPaymentAddressEmail { get; set; }

    [Column("FK_HREmployeeManagementID")]
    public int? FkHremployeeManagementId { get; set; }

    [Column("FK_ARCustomerBusinessTypeID")]
    public int? FkArcustomerBusinessTypeId { get; set; }

    [Column("ARCustomerInvoiceAddressEmail")]
    [StringLength(50)]
    public string ArcustomerInvoiceAddressEmail { get; set; }

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Approposal> Approposals { get; set; } = new List<Approposal>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<AradjustSaleOrderQuantity> AradjustSaleOrderQuantities { get; set; } = new List<AradjustSaleOrderQuantity>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcancelSaleForecast> ArcancelSaleForecasts { get; set; } = new List<ArcancelSaleForecast>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcancelVoucher> ArcancelVouchers { get; set; } = new List<ArcancelVoucher>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcreditNote> ArcreditNotes { get; set; } = new List<ArcreditNote>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerComment> ArcustomerComments { get; set; } = new List<ArcustomerComment>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerContactGroup> ArcustomerContactGroups { get; set; } = new List<ArcustomerContactGroup>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerContact> ArcustomerContacts { get; set; } = new List<ArcustomerContact>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerDiscount> ArcustomerDiscounts { get; set; } = new List<ArcustomerDiscount>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerInfoContact> ArcustomerInfoContacts { get; set; } = new List<ArcustomerInfoContact>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPayments { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerProductDiscount> ArcustomerProductDiscounts { get; set; } = new List<ArcustomerProductDiscount>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerProductGroupDiscount> ArcustomerProductGroupDiscounts { get; set; } = new List<ArcustomerProductGroupDiscount>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArcustomerProductNumber> ArcustomerProductNumbers { get; set; } = new List<ArcustomerProductNumber>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; } = new List<ArdeliveryPlanMachineDevice>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Arestimate> Arestimates { get; set; } = new List<Arestimate>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<AropenDocument> AropenDocuments { get; set; } = new List<AropenDocument>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Aropportunity> Aropportunities { get; set; } = new List<Aropportunity>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArpriceSheet> ArpriceSheets { get; set; } = new List<ArpriceSheet>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArproductionPlanning> ArproductionPlannings { get; set; } = new List<ArproductionPlanning>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Arremind> Arreminds { get; set; } = new List<Arremind>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArrevenueForecastItem> ArrevenueForecastItems { get; set; } = new List<ArrevenueForecastItem>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArrevenueForecast> ArrevenueForecasts { get; set; } = new List<ArrevenueForecast>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArsaleForecast> ArsaleForecasts { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<ArsaleReturn> ArsaleReturns { get; set; } = new List<ArsaleReturn>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Brposs> Brposses { get; set; } = new List<Brposs>();

    [InverseProperty("Facustomer")]
    public virtual ICollection<FacreditNoteHistory> FacreditNoteHistories { get; set; } = new List<FacreditNoteHistory>();

    [InverseProperty("FacustomerIdcomboNavigation")]
    public virtual ICollection<FacreditNote> FacreditNotes { get; set; } = new List<FacreditNote>();

    [InverseProperty("Facustomer")]
    public virtual ICollection<FainvoiceHistory> FainvoiceHistories { get; set; } = new List<FainvoiceHistory>();

    [InverseProperty("Facustomer")]
    public virtual ICollection<FaproposalHistory> FaproposalHistories { get; set; } = new List<FaproposalHistory>();

    [InverseProperty("FacustomerIdcomboNavigation")]
    public virtual ICollection<FareturnSupplier> FareturnSuppliers { get; set; } = new List<FareturnSupplier>();

    [InverseProperty("Facustomer")]
    public virtual ICollection<FasellReturnHistory> FasellReturnHistories { get; set; } = new List<FasellReturnHistory>();

    [InverseProperty("FacustomerIdcomboNavigation")]
    public virtual ICollection<FasellReturn> FasellReturns { get; set; } = new List<FasellReturn>();

    [InverseProperty("Facustomer")]
    public virtual ICollection<FashipmentHistory> FashipmentHistories { get; set; } = new List<FashipmentHistory>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("ArcustomerFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcaccountDepositId")]
    [InverseProperty("ArcustomerFkAcaccountDeposits")]
    public virtual Acaccount FkAcaccountDeposit { get; set; }

    [ForeignKey("FkAcaccountPurchaseId")]
    [InverseProperty("ArcustomerFkAcaccountPurchases")]
    public virtual Acaccount FkAcaccountPurchase { get; set; }

    [ForeignKey("FkAcaccountSaleId")]
    [InverseProperty("ArcustomerFkAcaccountSales")]
    public virtual Acaccount FkAcaccountSale { get; set; }

    [ForeignKey("FkAdfengShuisColorId")]
    [InverseProperty("Arcustomers")]
    public virtual AdfengShuisColor FkAdfengShuisColor { get; set; }

    [ForeignKey("FkAdfengShuisDirectionId")]
    [InverseProperty("Arcustomers")]
    public virtual AdfengShuisDirection FkAdfengShuisDirection { get; set; }

    [ForeignKey("FkAdfengShuisGenaralId")]
    [InverseProperty("Arcustomers")]
    public virtual AdfengShuisGenaral FkAdfengShuisGenaral { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("Arcustomers")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkArcustomerBusinessTypeId")]
    [InverseProperty("Arcustomers")]
    public virtual ArcustomerBusinessType FkArcustomerBusinessType { get; set; }

    [ForeignKey("FkArcustomerResourceId")]
    [InverseProperty("Arcustomers")]
    public virtual ArcustomerResource FkArcustomerResource { get; set; }

    [ForeignKey("FkArcustomerTypeAccountConfigId")]
    [InverseProperty("Arcustomers")]
    public virtual ArcustomerTypeAccountConfig FkArcustomerTypeAccountConfig { get; set; }

    [ForeignKey("FkArpriceLevelId")]
    [InverseProperty("Arcustomers")]
    public virtual ArpriceLevel FkArpriceLevel { get; set; }

    [ForeignKey("FkArprospectCustomerId")]
    [InverseProperty("Arcustomers")]
    public virtual ArprospectCustomer FkArprospectCustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Arcustomers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Arcustomers")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGedeliveryCountryId")]
    [InverseProperty("Arcustomers")]
    public virtual Gecountry FkGedeliveryCountry { get; set; }

    [ForeignKey("FkGedeliveryDistrictId")]
    [InverseProperty("Arcustomers")]
    public virtual Gedistrict FkGedeliveryDistrict { get; set; }

    [ForeignKey("FkGedeliveryStateProvinceId")]
    [InverseProperty("Arcustomers")]
    public virtual GestateProvince FkGedeliveryStateProvince { get; set; }

    [ForeignKey("FkGedeliveryStreetId")]
    [InverseProperty("Arcustomers")]
    public virtual Gestreet FkGedeliveryStreet { get; set; }

    [ForeignKey("FkGedeliveryWardId")]
    [InverseProperty("Arcustomers")]
    public virtual Geward FkGedeliveryWard { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("ArcustomerFkGelocations")]
    public virtual Gelocation FkGelocation { get; set; }

    [ForeignKey("FkGelocationId1")]
    [InverseProperty("ArcustomerFkGelocationId1Navigations")]
    public virtual Gelocation FkGelocationId1Navigation { get; set; }

    [ForeignKey("FkGelocationId2")]
    [InverseProperty("ArcustomerFkGelocationId2Navigations")]
    public virtual Gelocation FkGelocationId2Navigation { get; set; }

    [ForeignKey("FkGelocationId3")]
    [InverseProperty("ArcustomerFkGelocationId3Navigations")]
    public virtual Gelocation FkGelocationId3Navigation { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("Arcustomers")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcustomerFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeManagementId")]
    [InverseProperty("ArcustomerFkHremployeeManagements")]
    public virtual Hremployee FkHremployeeManagement { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("Arcustomers")]
    public virtual Hrgroup FkHrgroup { get; set; }

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<IcproductAttribute> IcproductAttributes { get; set; } = new List<IcproductAttribute>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<IcproductCustomerPrice> IcproductCustomerPrices { get; set; } = new List<IcproductCustomerPrice>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<IcproductCustomer> IcproductCustomers { get; set; } = new List<IcproductCustomer>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposals { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmbatchItemPlan> MmbatchItemPlans { get; set; } = new List<MmbatchItemPlan>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmbatchProduct> MmbatchProducts { get; set; } = new List<MmbatchProduct>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmcalculatorProductionNormCost> MmcalculatorProductionNormCosts { get; set; } = new List<MmcalculatorProductionNormCost>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlans { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmchangeBominformation> MmchangeBominformations { get; set; } = new List<MmchangeBominformation>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmchangeDeliveryDateBatchProductItem> MmchangeDeliveryDateBatchProductItems { get; set; } = new List<MmchangeDeliveryDateBatchProductItem>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmchangeDeliveryDateBatchProduct> MmchangeDeliveryDateBatchProducts { get; set; } = new List<MmchangeDeliveryDateBatchProduct>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmpaintProcessess> MmpaintProcessesses { get; set; } = new List<MmpaintProcessess>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Mmproposal> Mmproposals { get; set; } = new List<Mmproposal>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlans { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<MmwoodPlan> MmwoodPlans { get; set; } = new List<MmwoodPlan>();

    [InverseProperty("Arcustomer")]
    public virtual ICollection<Oeproposal> Oeproposals { get; set; } = new List<Oeproposal>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<PmbuidingCommand> PmbuidingCommands { get; set; } = new List<PmbuidingCommand>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<PmbuidingProposal> PmbuidingProposals { get; set; } = new List<PmbuidingProposal>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<PmbuildingPlan> PmbuildingPlans { get; set; } = new List<PmbuildingPlan>();

    [InverseProperty("FkArcustomer")]
    public virtual ICollection<Pmproject> Pmprojects { get; set; } = new List<Pmproject>();
}
