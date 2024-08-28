using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoices")]
[Microsoft.EntityFrameworkCore.Index("ArinvoiceNo", "ArinvoiceDate", "FkBrbranchId", "FkArcustomerId", "ArinvoiceReference", "ArinvoiceTypeCombo", Name = "Idx_ARInvoices")]
public partial class Arinvoice
{
    [Key]
    [Column("ARInvoiceID")]
    public int ArinvoiceId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_GEVATRegionID")]
    public int? FkGevatregionId { get; set; }

    [Column("FK_ARPriceLevelID")]
    public int? FkArpriceLevelId { get; set; }

    [Column("FK_ARSellerID")]
    public int FkArsellerId { get; set; }

    [Column("FK_ARAssociatedSellerID")]
    public int? FkArassociatedSellerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRDeliveryEmployeeID")]
    public int? FkHrdeliveryEmployeeId { get; set; }

    [Column("ARInvoiceStatus")]
    [StringLength(100)]
    public string ArinvoiceStatus { get; set; }

    [Column("ARInvoicePaymentTerm")]
    [StringLength(50)]
    public string ArinvoicePaymentTerm { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    public string ArpaymentMethodCombo { get; set; }

    [Required]
    [Column("ARInvoiceNo")]
    [StringLength(50)]
    public string ArinvoiceNo { get; set; }

    [Column("ARInvoiceName")]
    [StringLength(100)]
    public string ArinvoiceName { get; set; }

    [Column("ARInvoiceDesc")]
    [StringLength(512)]
    public string ArinvoiceDesc { get; set; }

    [Column("ARInvoiceDate", TypeName = "datetime")]
    public DateTime? ArinvoiceDate { get; set; }

    [Column("ARInvoiceValidateDate", TypeName = "datetime")]
    public DateTime? ArinvoiceValidateDate { get; set; }

    [Column("ARInvoiceDeliveryDate", TypeName = "datetime")]
    public DateTime? ArinvoiceDeliveryDate { get; set; }

    [Column("ARInvoiceDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceDiscountPerCent { get; set; }

    [Column("ARInvoiceDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceDiscountFix { get; set; }

    [Column("ARInvoiceReference")]
    [StringLength(150)]
    public string ArinvoiceReference { get; set; }

    [Column("ARInvoiceActiveCheck")]
    public bool? ArinvoiceActiveCheck { get; set; }

    [Column("ARInvoiceTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceTaxNumber { get; set; }

    [Column("ARInvoiceTypeCombo")]
    [StringLength(50)]
    public string ArinvoiceTypeCombo { get; set; }

    [Column("ARInvoiceNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceNetAmount { get; set; }

    [Column("ARInvoiceTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceTaxPercent { get; set; }

    [Column("ARInvoiceTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceTaxAmount { get; set; }

    [Column("ARInvoiceSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceSubTotalAmount { get; set; }

    [Column("ARInvoiceTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceTotalAmount { get; set; }

    [Column("ARInvoiceDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceDepositBalance { get; set; }

    [Column("ARInvoiceBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceBalanceDue { get; set; }

    [Column("FK_ARCustomerContactInvoiceID")]
    public int? FkArcustomerContactInvoiceId { get; set; }

    [Column("ARInvoiceInvoiceContactName")]
    [StringLength(50)]
    public string ArinvoiceInvoiceContactName { get; set; }

    [Column("ARInvoiceInvoiceContactFirstName")]
    [StringLength(50)]
    public string ArinvoiceInvoiceContactFirstName { get; set; }

    [Column("ARInvoiceInvoiceContactLastName")]
    [StringLength(50)]
    public string ArinvoiceInvoiceContactLastName { get; set; }

    [Column("ARInvoiceInvoiceContactTitle")]
    [StringLength(50)]
    public string ArinvoiceInvoiceContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARInvoiceInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string ArinvoiceInvoiceContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARInvoiceInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string ArinvoiceInvoiceContactHeaderMessage { get; set; }

    [Column("ARInvoiceInvoiceContactEmail1")]
    [StringLength(100)]
    public string ArinvoiceInvoiceContactEmail1 { get; set; }

    [Column("ARInvoiceInvoiceContactEmail2")]
    [StringLength(100)]
    public string ArinvoiceInvoiceContactEmail2 { get; set; }

    [Column("ARInvoiceInvoiceContactWebsite")]
    [StringLength(100)]
    public string ArinvoiceInvoiceContactWebsite { get; set; }

    [Column("ARInvoiceInvoiceContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceInvoiceContactPhonePrivate { get; set; }

    [Column("ARInvoiceInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceInvoiceContactPhone { get; set; }

    [Column("ARInvoiceInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceInvoiceContactPhone1 { get; set; }

    [Column("ARInvoiceInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceInvoiceContactCellPhone { get; set; }

    [Column("ARInvoiceInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceInvoiceContactCellPhone1 { get; set; }

    [Column("ARInvoiceInvoiceContactFax")]
    [StringLength(50)]
    public string ArinvoiceInvoiceContactFax { get; set; }

    [Column("ARInvoiceInvoiceContactType")]
    [StringLength(50)]
    public string ArinvoiceInvoiceContactType { get; set; }

    [Column("ARInvoiceInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArinvoiceInvoiceContactInformation { get; set; }

    [Column("ARInvoiceInvoiceContactDepartment")]
    [StringLength(50)]
    public string ArinvoiceInvoiceContactDepartment { get; set; }

    [Column("ARInvoiceInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArinvoiceInvoiceContactRoom { get; set; }

    [Column("ARInvoiceInvoiceAddressLine1")]
    [StringLength(200)]
    public string ArinvoiceInvoiceAddressLine1 { get; set; }

    [Column("ARInvoiceInvoiceAddressLine2")]
    [StringLength(200)]
    public string ArinvoiceInvoiceAddressLine2 { get; set; }

    [Column("ARInvoiceInvoiceAddressLine3")]
    [StringLength(200)]
    public string ArinvoiceInvoiceAddressLine3 { get; set; }

    [Column("ARInvoiceInvoiceAddressStreet")]
    [StringLength(200)]
    public string ArinvoiceInvoiceAddressStreet { get; set; }

    [Column("ARInvoiceInvoiceAddressCity")]
    [StringLength(50)]
    public string ArinvoiceInvoiceAddressCity { get; set; }

    [Column("ARInvoiceInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string ArinvoiceInvoiceAddressPostalCode { get; set; }

    [Column("ARInvoiceInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string ArinvoiceInvoiceAddressStateProvince { get; set; }

    [Column("ARInvoiceInvoiceAddressZipCode")]
    [StringLength(50)]
    public string ArinvoiceInvoiceAddressZipCode { get; set; }

    [Column("ARInvoiceInvoiceAddressCountry")]
    [StringLength(50)]
    public string ArinvoiceInvoiceAddressCountry { get; set; }

    [Column("FK_ARCustomerContactSOID")]
    public int? FkArcustomerContactSoid { get; set; }

    [Column("ARInvoiceSOContactName")]
    [StringLength(50)]
    public string ArinvoiceSocontactName { get; set; }

    [Column("ARInvoiceSOContactBirthday", TypeName = "datetime")]
    public DateTime? ArinvoiceSocontactBirthday { get; set; }

    [Column("ARInvoiceSOContactFirstName")]
    [StringLength(50)]
    public string ArinvoiceSocontactFirstName { get; set; }

    [Column("ARInvoiceSOContactLastName")]
    [StringLength(50)]
    public string ArinvoiceSocontactLastName { get; set; }

    [Column("ARInvoiceSOContactTitle")]
    [StringLength(50)]
    public string ArinvoiceSocontactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARInvoiceSOContactHeaderLetter")]
    [StringLength(100)]
    public string ArinvoiceSocontactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARInvoiceSOContactHeaderMessage")]
    [StringLength(255)]
    public string ArinvoiceSocontactHeaderMessage { get; set; }

    [Column("ARInvoiceSOContactEmail1")]
    [StringLength(100)]
    public string ArinvoiceSocontactEmail1 { get; set; }

    [Column("ARInvoiceSOContactEmail2")]
    [StringLength(100)]
    public string ArinvoiceSocontactEmail2 { get; set; }

    [Column("ARInvoiceSOContactWebsite")]
    [StringLength(100)]
    public string ArinvoiceSocontactWebsite { get; set; }

    [Column("ARInvoiceSOContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceSocontactPhonePrivate { get; set; }

    [Column("ARInvoiceSOContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceSocontactPhone { get; set; }

    [Column("ARInvoiceSOContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceSocontactPhone1 { get; set; }

    [Column("ARInvoiceSOContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceSocontactCellPhone { get; set; }

    [Column("ARInvoiceSOContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceSocontactCellPhone1 { get; set; }

    [Column("ARInvoiceSOContactFax")]
    [StringLength(50)]
    public string ArinvoiceSocontactFax { get; set; }

    [Column("ARInvoiceSOContactType")]
    [StringLength(50)]
    public string ArinvoiceSocontactType { get; set; }

    [Column("ARInvoiceSOContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArinvoiceSocontactInformation { get; set; }

    [Column("ARInvoiceSOContactDepartment")]
    [StringLength(50)]
    public string ArinvoiceSocontactDepartment { get; set; }

    [Column("ARInvoiceSOContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArinvoiceSocontactRoom { get; set; }

    [Column("ARInvoiceSOAddressLine1")]
    [StringLength(200)]
    public string ArinvoiceSoaddressLine1 { get; set; }

    [Column("ARInvoiceSOAddressLine2")]
    [StringLength(200)]
    public string ArinvoiceSoaddressLine2 { get; set; }

    [Column("ARInvoiceSOAddressLine3")]
    [StringLength(200)]
    public string ArinvoiceSoaddressLine3 { get; set; }

    [Column("ARInvoiceSOAddressStreet")]
    [StringLength(200)]
    public string ArinvoiceSoaddressStreet { get; set; }

    [Column("ARInvoiceSOAddressCity")]
    [StringLength(50)]
    public string ArinvoiceSoaddressCity { get; set; }

    [Column("ARInvoiceSOAddressPostalCode")]
    [StringLength(50)]
    public string ArinvoiceSoaddressPostalCode { get; set; }

    [Column("ARInvoiceSOAddressStateProvince")]
    [StringLength(50)]
    public string ArinvoiceSoaddressStateProvince { get; set; }

    [Column("ARInvoiceSOAddressZipCode")]
    [StringLength(50)]
    public string ArinvoiceSoaddressZipCode { get; set; }

    [Column("ARInvoiceSOAddressCountry")]
    [StringLength(50)]
    public string ArinvoiceSoaddressCountry { get; set; }

    [Column("FK_ARCustomerContactDeliveryID")]
    public int? FkArcustomerContactDeliveryId { get; set; }

    [Column("ARInvoiceDeliveryContactName")]
    [StringLength(50)]
    public string ArinvoiceDeliveryContactName { get; set; }

    [Column("ARInvoiceDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? ArinvoiceDeliveryContactBirthday { get; set; }

    [Column("ARInvoiceDeliveryContactFirstName")]
    [StringLength(50)]
    public string ArinvoiceDeliveryContactFirstName { get; set; }

    [Column("ARInvoiceDeliveryContactLastName")]
    [StringLength(50)]
    public string ArinvoiceDeliveryContactLastName { get; set; }

    [Column("ARInvoiceDeliveryContactTitle")]
    [StringLength(50)]
    public string ArinvoiceDeliveryContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARInvoiceDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string ArinvoiceDeliveryContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARInvoiceDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string ArinvoiceDeliveryContactHeaderMessage { get; set; }

    [Column("ARInvoiceDeliveryContactEmail1")]
    [StringLength(100)]
    public string ArinvoiceDeliveryContactEmail1 { get; set; }

    [Column("ARInvoiceDeliveryContactEmail2")]
    [StringLength(100)]
    public string ArinvoiceDeliveryContactEmail2 { get; set; }

    [Column("ARInvoiceDeliveryContactWebsite")]
    [StringLength(100)]
    public string ArinvoiceDeliveryContactWebsite { get; set; }

    [Column("ARInvoiceDeliveryContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceDeliveryContactPhonePrivate { get; set; }

    [Column("ARInvoiceDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceDeliveryContactPhone { get; set; }

    [Column("ARInvoiceDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceDeliveryContactPhone1 { get; set; }

    [Column("ARInvoiceDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceDeliveryContactCellPhone { get; set; }

    [Column("ARInvoiceDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoiceDeliveryContactCellPhone1 { get; set; }

    [Column("ARInvoiceDeliveryContactFax")]
    [StringLength(50)]
    public string ArinvoiceDeliveryContactFax { get; set; }

    [Column("ARInvoiceDeliveryContactType")]
    [StringLength(50)]
    public string ArinvoiceDeliveryContactType { get; set; }

    [Column("ARInvoiceDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArinvoiceDeliveryContactInformation { get; set; }

    [Column("ARInvoiceDeliveryContactDepartment")]
    [StringLength(50)]
    public string ArinvoiceDeliveryContactDepartment { get; set; }

    [Column("ARInvoiceDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArinvoiceDeliveryContactRoom { get; set; }

    [Column("ARInvoiceDeliveryAddressLine1")]
    [StringLength(200)]
    public string ArinvoiceDeliveryAddressLine1 { get; set; }

    [Column("ARInvoiceDeliveryAddressLine2")]
    [StringLength(200)]
    public string ArinvoiceDeliveryAddressLine2 { get; set; }

    [Column("ARInvoiceDeliveryAddressLine3")]
    [StringLength(200)]
    public string ArinvoiceDeliveryAddressLine3 { get; set; }

    [Column("ARInvoiceDeliveryAddressStreet")]
    [StringLength(200)]
    public string ArinvoiceDeliveryAddressStreet { get; set; }

    [Column("ARInvoiceDeliveryAddressCity")]
    [StringLength(50)]
    public string ArinvoiceDeliveryAddressCity { get; set; }

    [Column("ARInvoiceDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string ArinvoiceDeliveryAddressPostalCode { get; set; }

    [Column("ARInvoiceDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string ArinvoiceDeliveryAddressStateProvince { get; set; }

    [Column("ARInvoiceDeliveryAddressZipCode")]
    [StringLength(50)]
    public string ArinvoiceDeliveryAddressZipCode { get; set; }

    [Column("ARInvoiceDeliveryAddressCountry")]
    [StringLength(50)]
    public string ArinvoiceDeliveryAddressCountry { get; set; }

    [Column("FK_ARCustomerContactPaymentID")]
    public int? FkArcustomerContactPaymentId { get; set; }

    [Column("ARInvoicePaymentContactName")]
    [StringLength(50)]
    public string ArinvoicePaymentContactName { get; set; }

    [Column("ARInvoicePaymentContactBirthday", TypeName = "datetime")]
    public DateTime? ArinvoicePaymentContactBirthday { get; set; }

    [Column("ARInvoicePaymentContactFirstName")]
    [StringLength(50)]
    public string ArinvoicePaymentContactFirstName { get; set; }

    [Column("ARInvoicePaymentContactLastName")]
    [StringLength(50)]
    public string ArinvoicePaymentContactLastName { get; set; }

    [Column("ARInvoicePaymentContactTitle")]
    [StringLength(50)]
    public string ArinvoicePaymentContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARInvoicePaymentContactHeaderLetter")]
    [StringLength(100)]
    public string ArinvoicePaymentContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARInvoicePaymentContactHeaderMessage")]
    [StringLength(255)]
    public string ArinvoicePaymentContactHeaderMessage { get; set; }

    [Column("ARInvoicePaymentContactEmail1")]
    [StringLength(100)]
    public string ArinvoicePaymentContactEmail1 { get; set; }

    [Column("ARInvoicePaymentContactEmail2")]
    [StringLength(100)]
    public string ArinvoicePaymentContactEmail2 { get; set; }

    [Column("ARInvoicePaymentContactWebsite")]
    [StringLength(100)]
    public string ArinvoicePaymentContactWebsite { get; set; }

    [Column("ARInvoicePaymentContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoicePaymentContactPhonePrivate { get; set; }

    [Column("ARInvoicePaymentContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoicePaymentContactPhone { get; set; }

    [Column("ARInvoicePaymentContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoicePaymentContactPhone1 { get; set; }

    [Column("ARInvoicePaymentContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoicePaymentContactCellPhone { get; set; }

    [Column("ARInvoicePaymentContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArinvoicePaymentContactCellPhone1 { get; set; }

    [Column("ARInvoicePaymentContactFax")]
    [StringLength(50)]
    public string ArinvoicePaymentContactFax { get; set; }

    [Column("ARInvoicePaymentContactType")]
    [StringLength(50)]
    public string ArinvoicePaymentContactType { get; set; }

    [Column("ARInvoicePaymentContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArinvoicePaymentContactInformation { get; set; }

    [Column("ARInvoicePaymentContactDepartment")]
    [StringLength(50)]
    public string ArinvoicePaymentContactDepartment { get; set; }

    [Column("ARInvoicePaymentContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArinvoicePaymentContactRoom { get; set; }

    [Column("ARInvoicePaymentAddressLine1")]
    [StringLength(200)]
    public string ArinvoicePaymentAddressLine1 { get; set; }

    [Column("ARInvoicePaymentAddressLine2")]
    [StringLength(200)]
    public string ArinvoicePaymentAddressLine2 { get; set; }

    [Column("ARInvoicePaymentAddressLine3")]
    [StringLength(200)]
    public string ArinvoicePaymentAddressLine3 { get; set; }

    [Column("ARInvoicePaymentAddressStreet")]
    [StringLength(200)]
    public string ArinvoicePaymentAddressStreet { get; set; }

    [Column("ARInvoicePaymentAddressCity")]
    [StringLength(50)]
    public string ArinvoicePaymentAddressCity { get; set; }

    [Column("ARInvoicePaymentAddressPostalCode")]
    [StringLength(50)]
    public string ArinvoicePaymentAddressPostalCode { get; set; }

    [Column("ARInvoicePaymentAddressStateProvince")]
    [StringLength(50)]
    public string ArinvoicePaymentAddressStateProvince { get; set; }

    [Column("ARInvoicePaymentAddressZipCode")]
    [StringLength(50)]
    public string ArinvoicePaymentAddressZipCode { get; set; }

    [Column("ARInvoicePaymentAddressCountry")]
    [StringLength(50)]
    public string ArinvoicePaymentAddressCountry { get; set; }

    [Column("ARInvoiceShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceShippingFees { get; set; }

    [Column("ARInvoiceShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceShippingExtraFees { get; set; }

    [Column("ARInvoiceShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceShippingInsuranceFees { get; set; }

    [Column("ARInvoiceShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceShippingPackagingFees { get; set; }

    [Column("ARInvoiceShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceShippingReservedFees1 { get; set; }

    [Column("ARInvoiceShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceShippingReservedFees2 { get; set; }

    [Column("ARInvoiceShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceShippingReservedFees3 { get; set; }

    [Column("ARInvoiceShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceShippingReservedFees4 { get; set; }

    [Column("ARInvoiceShippingMethodDesc")]
    [StringLength(255)]
    public string ArinvoiceShippingMethodDesc { get; set; }

    [Column("ARInvoiceShippingMethodName")]
    [StringLength(50)]
    public string ArinvoiceShippingMethodName { get; set; }

    [Column("ARInvoiceExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARInvoiceTransferredDate", TypeName = "datetime")]
    public DateTime? ArinvoiceTransferredDate { get; set; }

    [Column("ARInvoiceComment")]
    [StringLength(512)]
    public string ArinvoiceComment { get; set; }

    [Column("ARInvoiceInternalComment")]
    [StringLength(512)]
    public string ArinvoiceInternalComment { get; set; }

    [Column("ARInvoiceOwingExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceOwingExchangeAmount { get; set; }

    [Column("ARInvoiceMainSellerCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceMainSellerCommissionPercent { get; set; }

    [Column("ARInvoiceAssSellerCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceAssSellerCommissionPercent { get; set; }

    [Column("ARInvoiceVATFormNo")]
    [StringLength(50)]
    public string ArinvoiceVatformNo { get; set; }

    [Column("ARInvoiceVATSymbol")]
    [StringLength(50)]
    public string ArinvoiceVatsymbol { get; set; }

    [Column("ARInvoiceVATInvoiceNo")]
    [StringLength(50)]
    public string ArinvoiceVatinvoiceNo { get; set; }

    [Column("ARInvoiceVATPaymentContactInformation")]
    [StringLength(512)]
    public string ArinvoiceVatpaymentContactInformation { get; set; }

    [Column("AROutputVATDocumentType")]
    [StringLength(1000)]
    public string AroutputVatdocumentType { get; set; }

    [Column("AROutputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string AroutputVatinvoiceNoCombo { get; set; }

    [Column("ARInvoiceVehicle")]
    [StringLength(512)]
    public string ArinvoiceVehicle { get; set; }

    [Column("ARInvoiceSOType")]
    [StringLength(50)]
    public string ArinvoiceSotype { get; set; }

    [Column("ARInvoiceProductType")]
    [StringLength(50)]
    public string ArinvoiceProductType { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("ARInvoicePONo")]
    [StringLength(50)]
    public string ArinvoicePono { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("ARInvoiceShippingMethod")]
    [StringLength(64)]
    public string ArinvoiceShippingMethod { get; set; }

    [Column("ARInvoicesCoordinatorReference")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArinvoicesCoordinatorReference { get; set; }

    [Column("ARInvoiceTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceTotalCost { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("ARInvoicePostedStatus")]
    [StringLength(50)]
    public string ArinvoicePostedStatus { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ARInvoiceIsReceiveBill")]
    public bool? ArinvoiceIsReceiveBill { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ARInvoiceRequestID")]
    public int? FkArinvoiceRequestId { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("ARInvoiceCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceCommissionPercent { get; set; }

    [Column("ARInvoiceCommissionAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceCommissionAmount { get; set; }

    [Column("ARInvoiceSaleAgreement")]
    [StringLength(250)]
    public string ArinvoiceSaleAgreement { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ARInvoiceSaleType")]
    [StringLength(50)]
    public string ArinvoiceSaleType { get; set; }

    [Column("FK_GETerminalID")]
    public int? FkGeterminalId { get; set; }

    [Column("ARInvoicePortOFDischarge")]
    [StringLength(256)]
    public string ArinvoicePortOfdischarge { get; set; }

    [Column("ARInvoicePortEndShipmentText")]
    [StringLength(256)]
    public string ArinvoicePortEndShipmentText { get; set; }

    [Column("ARInvoiceWaybillNumber")]
    [StringLength(256)]
    public string ArinvoiceWaybillNumber { get; set; }

    [Column("ARInvoiceProject")]
    [StringLength(100)]
    public string ArinvoiceProject { get; set; }

    [Column("ARInvoiceInvoiceRequest")]
    [StringLength(100)]
    public string ArinvoiceInvoiceRequest { get; set; }

    [Required]
    [Column("ARListOfSalesChannelType")]
    [StringLength(50)]
    public string ArlistOfSalesChannelType { get; set; }

    [Column("ARInvoiceReceivingAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceReceivingAmount { get; set; }

    [Column("ARInvoiceChangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceChangeAmount { get; set; }

    [Column("FK_ACTaxUnitID")]
    public int? FkActaxUnitId { get; set; }

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<AcclearingDebtInvoiceItem> AcclearingDebtInvoiceItems { get; set; } = new List<AcclearingDebtInvoiceItem>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ApbillOfLading> ApbillOfLadings { get; set; } = new List<ApbillOfLading>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ApfeePaymentInvoice> ApfeePaymentInvoices { get; set; } = new List<ApfeePaymentInvoice>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; } = new List<AppaymentVoucherInvoice>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArclearInvoiceInvoice> ArclearInvoiceInvoices { get; set; } = new List<ArclearInvoiceInvoice>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArclearingDetail> ArclearingDetails { get; set; } = new List<ArclearingDetail>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArcreditNoteInvoice> ArcreditNoteInvoices { get; set; } = new List<ArcreditNoteInvoice>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArcustomerPaymentTimePayment> ArcustomerPaymentTimePayments { get; set; } = new List<ArcustomerPaymentTimePayment>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArinvoiceCommission> ArinvoiceCommissions { get; set; } = new List<ArinvoiceCommission>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArinvoiceItemWork> ArinvoiceItemWorks { get; set; } = new List<ArinvoiceItemWork>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArinvoiceShipment> ArinvoiceShipments { get; set; } = new List<ArinvoiceShipment>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArinvoiceTemplate> ArinvoiceTemplates { get; set; } = new List<ArinvoiceTemplate>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<AropenDocument> AropenDocuments { get; set; } = new List<AropenDocument>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArpaymentProposalItem> ArpaymentProposalItems { get; set; } = new List<ArpaymentProposalItem>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArpospaymentDetail> ArpospaymentDetails { get; set; } = new List<ArpospaymentDetail>();

    [InverseProperty("FkArinvoice")]
    public virtual ICollection<ArsopaymentTimeInvoiceDetail> ArsopaymentTimeInvoiceDetails { get; set; } = new List<ArsopaymentTimeInvoiceDetail>();

    [InverseProperty("Fainvoice")]
    public virtual ICollection<FainvoiceContact> FainvoiceContacts { get; set; } = new List<FainvoiceContact>();

    [InverseProperty("Fainvoice")]
    public virtual ICollection<FainvoiceCreditNote> FainvoiceCreditNotes { get; set; } = new List<FainvoiceCreditNote>();

    [InverseProperty("Fainvoice")]
    public virtual ICollection<FainvoiceDiscount> FainvoiceDiscounts { get; set; } = new List<FainvoiceDiscount>();

    [InverseProperty("Fainvoice")]
    public virtual ICollection<FainvoiceHistory> FainvoiceHistories { get; set; } = new List<FainvoiceHistory>();

    [InverseProperty("Fainvoice")]
    public virtual ICollection<FainvoiceSellReturn> FainvoiceSellReturns { get; set; } = new List<FainvoiceSellReturn>();

    [InverseProperty("Fainvoice")]
    public virtual ICollection<FareturnSupplierInvoice> FareturnSupplierInvoices { get; set; } = new List<FareturnSupplierInvoice>();

    [InverseProperty("Fainvoice")]
    public virtual ICollection<FashipmentInvoice> FashipmentInvoices { get; set; } = new List<FashipmentInvoice>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("Arinvoices")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("Arinvoices")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkActaxUnitId")]
    [InverseProperty("Arinvoices")]
    public virtual ActaxUnit FkActaxUnit { get; set; }

    [ForeignKey("FkArassociatedSellerId")]
    [InverseProperty("ArinvoiceFkArassociatedSellers")]
    public virtual Hremployee FkArassociatedSeller { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Arinvoices")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArcustomerContactPaymentId")]
    [InverseProperty("Arinvoices")]
    public virtual CscompanyBank FkArcustomerContactPayment { get; set; }

    [ForeignKey("FkArinvoiceRequestId")]
    [InverseProperty("Arinvoices")]
    public virtual ArinvoiceRequest FkArinvoiceRequest { get; set; }

    [ForeignKey("FkArpriceLevelId")]
    [InverseProperty("Arinvoices")]
    public virtual ArpriceLevel FkArpriceLevel { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("Arinvoices")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkArsellerId")]
    [InverseProperty("ArinvoiceFkArsellers")]
    public virtual Hremployee FkArseller { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Arinvoices")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Arinvoices")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGeterminalId")]
    [InverseProperty("Arinvoices")]
    public virtual Geterminal FkGeterminal { get; set; }

    [ForeignKey("FkHrdeliveryEmployeeId")]
    [InverseProperty("ArinvoiceFkHrdeliveryEmployees")]
    public virtual Hremployee FkHrdeliveryEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArinvoiceFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("Arinvoices")]
    public virtual Icshipment FkIcshipment { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Arinvoices")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("Arinvoices")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("Arinvoices")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("Arinvoices")]
    public virtual Pmtemplate FkPmtemplate { get; set; }
}
