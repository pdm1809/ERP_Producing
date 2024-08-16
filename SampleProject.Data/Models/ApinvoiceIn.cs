using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APInvoiceIns")]
[Microsoft.EntityFrameworkCore.Index("ApinvoiceInNo", "ApinvoiceInDate", "FkBrbranchId", "FkApsupplierId", "ApinvoiceInReference", "ApinvoiceInType", Name = "Idx_APInvoiceIns")]
public partial class ApinvoiceIn
{
    [Key]
    [Column("APInvoiceInID")]
    public int ApinvoiceInId { get; set; }

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

    [Column("FK_GELanguageID")]
    public int FkGelanguageId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_BRCreatedBranchID")]
    public int? FkBrcreatedBranchId { get; set; }

    [Required]
    [Column("APInvoiceInNo")]
    [StringLength(50)]
    public string ApinvoiceInNo { get; set; }

    [Column("APInvoiceInSupplierNo")]
    [StringLength(50)]
    public string ApinvoiceInSupplierNo { get; set; }

    [Column("APInvoiceInName")]
    [StringLength(100)]
    public string ApinvoiceInName { get; set; }

    [Column("APInvoiceInDesc")]
    [StringLength(512)]
    public string ApinvoiceInDesc { get; set; }

    [Column("APInvoiceInComment")]
    [StringLength(512)]
    public string ApinvoiceInComment { get; set; }

    [Column("APInvoiceInDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInDate { get; set; }

    [Column("APInvoiceInValidateDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInValidateDate { get; set; }

    [Column("APInvoiceInDeliveryDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInDeliveryDate { get; set; }

    [Column("APInvoiceInDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInDiscountPerCent { get; set; }

    [Column("APInvoiceInDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInDiscountFix { get; set; }

    [Column("APInvoiceInReference")]
    [StringLength(150)]
    public string ApinvoiceInReference { get; set; }

    [Column("APInvoiceInActiveCheck")]
    public bool? ApinvoiceInActiveCheck { get; set; }

    [Column("APInvoiceInTaxNumber")]
    [StringLength(50)]
    public string ApinvoiceInTaxNumber { get; set; }

    [Column("APInvoiceInType")]
    [StringLength(50)]
    public string ApinvoiceInType { get; set; }

    [Column("APInvoiceInStatus")]
    [StringLength(100)]
    public string ApinvoiceInStatus { get; set; }

    [Column("APInvoiceInPaymentTerm")]
    [StringLength(50)]
    public string ApinvoiceInPaymentTerm { get; set; }

    [Column("APPaymentMethodCombo")]
    [StringLength(50)]
    public string AppaymentMethodCombo { get; set; }

    [Column("APInvoiceInTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInTaxPercent { get; set; }

    [Column("APInvoiceInTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInTaxAmount { get; set; }

    [Column("APInvoiceInSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInSubTotalCost { get; set; }

    [Column("APInvoiceInTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInTotalCost { get; set; }

    [Column("APInvoiceInDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInDepositBalance { get; set; }

    [Column("APInvoiceInBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInBalanceDue { get; set; }

    [Column("APInvoiceInMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode01Combo { get; set; }

    [Column("APInvoiceInMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode02Combo { get; set; }

    [Column("APInvoiceInMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode03Combo { get; set; }

    [Column("APInvoiceInMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode04Combo { get; set; }

    [Column("APInvoiceInMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode05Combo { get; set; }

    [Column("APInvoiceInMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode06Combo { get; set; }

    [Column("APInvoiceInMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode07Combo { get; set; }

    [Column("APInvoiceInMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode08Combo { get; set; }

    [Column("APInvoiceInMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode09Combo { get; set; }

    [Column("APInvoiceInMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode10Combo { get; set; }

    [Column("APInvoiceInMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode11Combo { get; set; }

    [Column("APInvoiceInMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInMatchCode12Combo { get; set; }

    [Column("APInvoiceInProject")]
    [StringLength(50)]
    public string ApinvoiceInProject { get; set; }

    [Column("FK_APSupplierContactInvoiceID")]
    public int? FkApsupplierContactInvoiceId { get; set; }

    [Column("APInvoiceInInvoiceContactName")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceContactName { get; set; }

    [Column("APInvoiceInInvoiceContactFirstName")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceContactFirstName { get; set; }

    [Column("APInvoiceInInvoiceContactLastName")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceContactLastName { get; set; }

    [Column("APInvoiceInInvoiceContactTitle")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceContactTitle { get; set; }

    [Column("APInvoiceInInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string ApinvoiceInInvoiceContactHeaderLetter { get; set; }

    [Column("APInvoiceInInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string ApinvoiceInInvoiceContactHeaderMessage { get; set; }

    [Column("APInvoiceInInvoiceContactEmail1")]
    [StringLength(100)]
    public string ApinvoiceInInvoiceContactEmail1 { get; set; }

    [Column("APInvoiceInInvoiceContactEmail2")]
    [StringLength(100)]
    public string ApinvoiceInInvoiceContactEmail2 { get; set; }

    [Column("APInvoiceInInvoiceContactWebsite")]
    [StringLength(100)]
    public string ApinvoiceInInvoiceContactWebsite { get; set; }

    [Column("APInvoiceInInvoiceContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInInvoiceContactPhonePrivat { get; set; }

    [Column("APInvoiceInInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInInvoiceContactPhone { get; set; }

    [Column("APInvoiceInInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInInvoiceContactPhone1 { get; set; }

    [Column("APInvoiceInInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInInvoiceContactCellPhone { get; set; }

    [Column("APInvoiceInInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInInvoiceContactCellPhone1 { get; set; }

    [Column("APInvoiceInInvoiceContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInInvoiceContactCellPhonePrivat { get; set; }

    [Column("APInvoiceInInvoiceContactFax")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceContactFax { get; set; }

    [Column("APInvoiceInInvoiceContactType")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceContactType { get; set; }

    [Column("APInvoiceInInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ApinvoiceInInvoiceContactInformation { get; set; }

    [Column("APInvoiceInInvoiceContactDepartment")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceContactDepartment { get; set; }

    [Column("APInvoiceInInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ApinvoiceInInvoiceContactRoom { get; set; }

    [Column("APInvoiceInInvoiceAddressLine1")]
    [StringLength(250)]
    public string ApinvoiceInInvoiceAddressLine1 { get; set; }

    [Column("APInvoiceInInvoiceAddressLine2")]
    [StringLength(250)]
    public string ApinvoiceInInvoiceAddressLine2 { get; set; }

    [Column("APInvoiceInInvoiceAddressLine3")]
    [StringLength(200)]
    public string ApinvoiceInInvoiceAddressLine3 { get; set; }

    [Column("APInvoiceInInvoiceAddressStreet")]
    [StringLength(200)]
    public string ApinvoiceInInvoiceAddressStreet { get; set; }

    [Column("APInvoiceInInvoiceAddressCity")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceAddressCity { get; set; }

    [Column("APInvoiceInInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceAddressPostalCode { get; set; }

    [Column("APInvoiceInInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceAddressStateProvince { get; set; }

    [Column("APInvoiceInInvoiceAddressZipCode")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceAddressZipCode { get; set; }

    [Column("APInvoiceInInvoiceAddressCountry")]
    [StringLength(50)]
    public string ApinvoiceInInvoiceAddressCountry { get; set; }

    [Column("FK_APSupplierContactPOID")]
    public int? FkApsupplierContactPoid { get; set; }

    [Column("APInvoiceInPOContactName")]
    [StringLength(50)]
    public string ApinvoiceInPocontactName { get; set; }

    [Column("APInvoiceInPOContactBirthday", TypeName = "datetime")]
    public DateTime? ApinvoiceInPocontactBirthday { get; set; }

    [Column("APInvoiceInPOContactFirstName")]
    [StringLength(50)]
    public string ApinvoiceInPocontactFirstName { get; set; }

    [Column("APInvoiceInPOContactLastName")]
    [StringLength(50)]
    public string ApinvoiceInPocontactLastName { get; set; }

    [Column("APInvoiceInPOContactTitle")]
    [StringLength(50)]
    public string ApinvoiceInPocontactTitle { get; set; }

    [Column("APInvoiceInPOContactHeaderLetter")]
    [StringLength(100)]
    public string ApinvoiceInPocontactHeaderLetter { get; set; }

    [Column("APInvoiceInPOContactHeaderMessage")]
    [StringLength(255)]
    public string ApinvoiceInPocontactHeaderMessage { get; set; }

    [Column("APInvoiceInPOContactEmail1")]
    [StringLength(100)]
    public string ApinvoiceInPocontactEmail1 { get; set; }

    [Column("APInvoiceInPOContactEmail2")]
    [StringLength(100)]
    public string ApinvoiceInPocontactEmail2 { get; set; }

    [Column("APInvoiceInPOContactWebsite")]
    [StringLength(100)]
    public string ApinvoiceInPocontactWebsite { get; set; }

    [Column("APInvoiceInPOContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInPocontactPhonePrivat { get; set; }

    [Column("APInvoiceInPOContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInPocontactPhone { get; set; }

    [Column("APInvoiceInPOContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInPocontactPhone1 { get; set; }

    [Column("APInvoiceInPOContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInPocontactCellPhone { get; set; }

    [Column("APInvoiceInPOContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInPocontactCellPhone1 { get; set; }

    [Column("APInvoiceInPOContactFax")]
    [StringLength(50)]
    public string ApinvoiceInPocontactFax { get; set; }

    [Column("APInvoiceInPOContactType")]
    [StringLength(50)]
    public string ApinvoiceInPocontactType { get; set; }

    [Column("APInvoiceInPOContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ApinvoiceInPocontactInformation { get; set; }

    [Column("APInvoiceInPOContactDepartment")]
    [StringLength(50)]
    public string ApinvoiceInPocontactDepartment { get; set; }

    [Column("APInvoiceInPOContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ApinvoiceInPocontactRoom { get; set; }

    [Column("APInvoiceInPOAddressLine1")]
    [StringLength(250)]
    public string ApinvoiceInPoaddressLine1 { get; set; }

    [Column("APInvoiceInPOAddressLine2")]
    [StringLength(250)]
    public string ApinvoiceInPoaddressLine2 { get; set; }

    [Column("APInvoiceInPOAddressLine3")]
    [StringLength(250)]
    public string ApinvoiceInPoaddressLine3 { get; set; }

    [Column("APInvoiceInPOAddressStreet")]
    [StringLength(200)]
    public string ApinvoiceInPoaddressStreet { get; set; }

    [Column("APInvoiceInPOAddressCity")]
    [StringLength(50)]
    public string ApinvoiceInPoaddressCity { get; set; }

    [Column("APInvoiceInPOAddressPostalCode")]
    [StringLength(50)]
    public string ApinvoiceInPoaddressPostalCode { get; set; }

    [Column("APInvoiceInPOAddressStateProvince")]
    [StringLength(50)]
    public string ApinvoiceInPoaddressStateProvince { get; set; }

    [Column("APInvoiceInPOAddressZipCode")]
    [StringLength(50)]
    public string ApinvoiceInPoaddressZipCode { get; set; }

    [Column("APInvoiceInPOAddressCountry")]
    [StringLength(50)]
    public string ApinvoiceInPoaddressCountry { get; set; }

    [Column("FK_APSupplierContactDeliveryID")]
    public int? FkApsupplierContactDeliveryId { get; set; }

    [Column("APInvoiceInDeliveryContactName")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryContactName { get; set; }

    [Column("APInvoiceInDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? ApinvoiceInDeliveryContactBirthday { get; set; }

    [Column("APInvoiceInDeliveryContactFirstName")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryContactFirstName { get; set; }

    [Column("APInvoiceInDeliveryContactLastName")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryContactLastName { get; set; }

    [Column("APInvoiceInDeliveryContactTitle")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryContactTitle { get; set; }

    [Column("APInvoiceInDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string ApinvoiceInDeliveryContactHeaderLetter { get; set; }

    [Column("APInvoiceInDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string ApinvoiceInDeliveryContactHeaderMessage { get; set; }

    [Column("APInvoiceInDeliveryContactEmail1")]
    [StringLength(100)]
    public string ApinvoiceInDeliveryContactEmail1 { get; set; }

    [Column("APInvoiceInDeliveryContactEmail2")]
    [StringLength(100)]
    public string ApinvoiceInDeliveryContactEmail2 { get; set; }

    [Column("APInvoiceInDeliveryContactWebsite")]
    [StringLength(100)]
    public string ApinvoiceInDeliveryContactWebsite { get; set; }

    [Column("APInvoiceInDeliveryContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInDeliveryContactPhonePrivat { get; set; }

    [Column("APInvoiceInDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInDeliveryContactPhone { get; set; }

    [Column("APInvoiceInDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInDeliveryContactPhone1 { get; set; }

    [Column("APInvoiceInDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInDeliveryContactCellPhone { get; set; }

    [Column("APInvoiceInDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInDeliveryContactCellPhone1 { get; set; }

    [Column("APInvoiceInDeliveryContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInDeliveryContactCellPhonePrivat { get; set; }

    [Column("APInvoiceInDeliveryContactFax")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryContactFax { get; set; }

    [Column("APInvoiceInDeliveryContactType")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryContactType { get; set; }

    [Column("APInvoiceInDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ApinvoiceInDeliveryContactInformation { get; set; }

    [Column("APInvoiceInDeliveryContactDepartment")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryContactDepartment { get; set; }

    [Column("APInvoiceInDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ApinvoiceInDeliveryContactRoom { get; set; }

    [Column("APInvoiceInDeliveryAddressName")]
    [StringLength(100)]
    public string ApinvoiceInDeliveryAddressName { get; set; }

    [Column("APInvoiceInDeliveryAddressLine1")]
    [StringLength(250)]
    public string ApinvoiceInDeliveryAddressLine1 { get; set; }

    [Column("APInvoiceInDeliveryAddressLine2")]
    [StringLength(250)]
    public string ApinvoiceInDeliveryAddressLine2 { get; set; }

    [Column("APInvoiceInDeliveryAddressLine3")]
    [StringLength(250)]
    public string ApinvoiceInDeliveryAddressLine3 { get; set; }

    [Column("APInvoiceInDeliveryAddressStreet")]
    [StringLength(200)]
    public string ApinvoiceInDeliveryAddressStreet { get; set; }

    [Column("APInvoiceInDeliveryAddressCity")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryAddressCity { get; set; }

    [Column("APInvoiceInDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryAddressPostalCode { get; set; }

    [Column("APInvoiceInDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryAddressStateProvince { get; set; }

    [Column("APInvoiceInDeliveryAddressZipCode")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryAddressZipCode { get; set; }

    [Column("APInvoiceInDeliveryAddressCountry")]
    [StringLength(50)]
    public string ApinvoiceInDeliveryAddressCountry { get; set; }

    [Column("APInvoiceInShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInShippingFees { get; set; }

    [Column("APInvoiceInShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInShippingExtraFees { get; set; }

    [Column("APInvoiceInShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInShippingInsuranceFees { get; set; }

    [Column("APInvoiceInShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInShippingPackagingFees { get; set; }

    [Column("APInvoiceInShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInShippingReservedFees1 { get; set; }

    [Column("APInvoiceInShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInShippingReservedFees2 { get; set; }

    [Column("APInvoiceInShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInShippingReservedFees3 { get; set; }

    [Column("APInvoiceInShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInShippingReservedFees4 { get; set; }

    [Column("APInvoiceInShippingMethodDesc")]
    [StringLength(255)]
    public string ApinvoiceInShippingMethodDesc { get; set; }

    [Column("APInvoiceInShippingMethodName")]
    [StringLength(50)]
    public string ApinvoiceInShippingMethodName { get; set; }

    [Column("APInvoiceInExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInExchangeRate { get; set; }

    [Column("APInvoiceInPackNo")]
    [StringLength(50)]
    public string ApinvoiceInPackNo { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("APInvoiceInTransferredDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInTransferredDate { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("APInvoiceInReceiptType")]
    [StringLength(50)]
    public string ApinvoiceInReceiptType { get; set; }

    [Column("APInvoiceInContainerNo")]
    [StringLength(50)]
    public string ApinvoiceInContainerNo { get; set; }

    [Column("APInvoiceInTotalQuantity", TypeName = "decimal(18, 5)")]
    public decimal? ApinvoiceInTotalQuantity { get; set; }

    [Column("APInvoiceInLogListNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApinvoiceInLogListNo { get; set; }

    [Column("APInvoiceInRoundWoodQty")]
    public int? ApinvoiceInRoundWoodQty { get; set; }

    [Column("APInvoiceInPackingList")]
    [StringLength(50)]
    public string ApinvoiceInPackingList { get; set; }

    [Column("APInvoiceInBillOfLanding")]
    [StringLength(50)]
    public string ApinvoiceInBillOfLanding { get; set; }

    [Column("APInvoiceInVATSymbol")]
    [StringLength(50)]
    public string ApinvoiceInVatsymbol { get; set; }

    [Column("APInvoiceInVATFormNo")]
    [StringLength(50)]
    public string ApinvoiceInVatformNo { get; set; }

    [Column("APInputVATDocumentType")]
    [StringLength(1000)]
    public string ApinputVatdocumentType { get; set; }

    [Column("APInputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string ApinputVatinvoiceNoCombo { get; set; }

    [Column("APInvoiceInSupplierNoDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInSupplierNoDate { get; set; }

    [Column("APInvoiceInContractNo")]
    [StringLength(50)]
    public string ApinvoiceInContractNo { get; set; }

    [Column("APInvoiceInContractDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInContractDate { get; set; }

    [Column("APInvoiceInVATDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInVatdate { get; set; }

    [Column("APInvoiceInSupplierTaxNumber")]
    [StringLength(50)]
    public string ApinvoiceInSupplierTaxNumber { get; set; }

    [Column("APInvoiceInPONo")]
    [StringLength(50)]
    public string ApinvoiceInPono { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("APAssObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApassObjectType { get; set; }

    [Column("APInvoiceInChannel")]
    [StringLength(50)]
    public string ApinvoiceInChannel { get; set; }

    [Column("APInvoiceInInvoiceDate", TypeName = "datetime")]
    public DateTime? ApinvoiceInInvoiceDate { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("APInvoiceInPostedStatus")]
    [StringLength(50)]
    public string ApinvoiceInPostedStatus { get; set; }

    [Column("FK_APPurchaseContractID")]
    public int? FkAppurchaseContractId { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("FK_GETerminalID")]
    public int? FkGeterminalId { get; set; }

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<AcclearingDebtInvoiceInItem> AcclearingDebtInvoiceInItems { get; set; } = new List<AcclearingDebtInvoiceInItem>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApallocationCostItemInvoiceIn> ApallocationCostItemInvoiceIns { get; set; } = new List<ApallocationCostItemInvoiceIn>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApallocationCostItemInvoice> ApallocationCostItemInvoices { get; set; } = new List<ApallocationCostItemInvoice>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApallocationCostItem> ApallocationCostItems { get; set; } = new List<ApallocationCostItem>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApbillOfLading> ApbillOfLadings { get; set; } = new List<ApbillOfLading>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApclearInvoiceInInvoiceIn> ApclearInvoiceInInvoiceIns { get; set; } = new List<ApclearInvoiceInInvoiceIn>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApclearingDetail> ApclearingDetails { get; set; } = new List<ApclearingDetail>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApfeePaymentInvoiceIn> ApfeePaymentInvoiceIns { get; set; } = new List<ApfeePaymentInvoiceIn>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApinvoiceInPackageItem> ApinvoiceInPackageItems { get; set; } = new List<ApinvoiceInPackageItem>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApopenDocument> ApopenDocuments { get; set; } = new List<ApopenDocument>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; } = new List<AppaymentVoucherInvoice>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetails { get; set; } = new List<AppopaymentTimeInvoiceInDetail>();

    [InverseProperty("FkApinvoiceIn")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkAppurchaseContractId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual AppurchaseContract FkAppurchaseContract { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ApinvoiceInFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrcreatedBranchId")]
    [InverseProperty("ApinvoiceInFkBrcreatedBranches")]
    public virtual Brbranch FkBrcreatedBranch { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkGeterminalId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual Geterminal FkGeterminal { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ApinvoiceInFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("ApinvoiceInFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ApinvoiceIns")]
    public virtual Pmproject FkPmproject { get; set; }
}
