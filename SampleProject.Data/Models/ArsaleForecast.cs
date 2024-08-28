using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleForecasts")]
public partial class ArsaleForecast
{
    [Key]
    [Column("ARSaleForecastID")]
    public int ArsaleForecastId { get; set; }

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

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

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

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Required]
    [Column("ARSaleForecastNo")]
    [StringLength(50)]
    public string ArsaleForecastNo { get; set; }

    [Column("ARSaleForecastName")]
    [StringLength(100)]
    public string ArsaleForecastName { get; set; }

    [Column("ARSaleForecastDesc")]
    [StringLength(512)]
    public string ArsaleForecastDesc { get; set; }

    [Column("ARSaleForecastStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastStatus { get; set; }

    [Column("ARSaleForecastPaymentTerm")]
    [StringLength(50)]
    public string ArsaleForecastPaymentTerm { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARSaleForecastDate", TypeName = "datetime")]
    public DateTime ArsaleForecastDate { get; set; }

    [Column("ARSaleForecastValidateDate", TypeName = "datetime")]
    public DateTime? ArsaleForecastValidateDate { get; set; }

    [Column("ARSaleForecastDeliveryDate", TypeName = "datetime")]
    public DateTime? ArsaleForecastDeliveryDate { get; set; }

    [Column("ARSaleForecastDeliveryTime", TypeName = "datetime")]
    public DateTime? ArsaleForecastDeliveryTime { get; set; }

    [Column("ARSaleForecastDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastDiscountPerCent { get; set; }

    [Column("ARSaleForecastDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastDiscountFix { get; set; }

    [Column("ARSaleForecastReference")]
    [StringLength(50)]
    public string ArsaleForecastReference { get; set; }

    [Column("ARSaleForecastActiveCheck")]
    public bool? ArsaleForecastActiveCheck { get; set; }

    [Column("ARSaleForecastTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastTaxNumber { get; set; }

    [Column("ARSaleForecastTypeCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastTypeCombo { get; set; }

    [Column("ARSaleForecastNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastNetAmount { get; set; }

    [Column("ARSaleForecastTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastTaxPercent { get; set; }

    [Column("ARSaleForecastTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastTaxAmount { get; set; }

    [Column("ARSaleForecastSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastSubTotalAmount { get; set; }

    [Column("ARSaleForecastTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastTotalAmount { get; set; }

    [Column("ARSaleForecastDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastDepositBalance { get; set; }

    [Column("ARSaleForecastBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastBalanceDue { get; set; }

    [Column("FK_ARCustomerContactSFID")]
    public int? FkArcustomerContactSfid { get; set; }

    [Column("ARSaleForecastSFContactName")]
    [StringLength(50)]
    public string ArsaleForecastSfcontactName { get; set; }

    [Column("ARSaleForecastSFContactBirthday", TypeName = "datetime")]
    public DateTime? ArsaleForecastSfcontactBirthday { get; set; }

    [Column("ARSaleForecastSFContactFirstName")]
    [StringLength(50)]
    public string ArsaleForecastSfcontactFirstName { get; set; }

    [Column("ARSaleForecastSFContactLastName")]
    [StringLength(50)]
    public string ArsaleForecastSfcontactLastName { get; set; }

    [Column("ARSaleForecastSFContactTitle")]
    [StringLength(50)]
    public string ArsaleForecastSfcontactTitle { get; set; }

    [Column("ARSaleForecastSFContactHeaderLetter")]
    [StringLength(100)]
    public string ArsaleForecastSfcontactHeaderLetter { get; set; }

    [Column("ARSaleForecastSFContactHeaderMessage")]
    [StringLength(255)]
    public string ArsaleForecastSfcontactHeaderMessage { get; set; }

    [Column("ARSaleForecastSFContactEmail1")]
    [StringLength(100)]
    public string ArsaleForecastSfcontactEmail1 { get; set; }

    [Column("ARSaleForecastSFContactEmail2")]
    [StringLength(100)]
    public string ArsaleForecastSfcontactEmail2 { get; set; }

    [Column("ARSaleForecastSFContactWebsite")]
    [StringLength(100)]
    public string ArsaleForecastSfcontactWebsite { get; set; }

    [Column("ARSaleForecastSFContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastSfcontactPhonePrivate { get; set; }

    [Column("ARSaleForecastSFContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastSfcontactPhone { get; set; }

    [Column("ARSaleForecastSFContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastSfcontactPhone1 { get; set; }

    [Column("ARSaleForecastSFContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastSfcontactCellPhone { get; set; }

    [Column("ARSaleForecastSFContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastSfcontactCellPhone1 { get; set; }

    [Column("ARSaleForecastSFContactFax")]
    [StringLength(50)]
    public string ArsaleForecastSfcontactFax { get; set; }

    [Column("ARSaleForecastSFContactType")]
    [StringLength(50)]
    public string ArsaleForecastSfcontactType { get; set; }

    [Column("ARSaleForecastSFContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsaleForecastSfcontactInformation { get; set; }

    [Column("ARSaleForecastSFContactDepartment")]
    [StringLength(50)]
    public string ArsaleForecastSfcontactDepartment { get; set; }

    [Column("ARSaleForecastSFContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsaleForecastSfcontactRoom { get; set; }

    [Column("ARSaleForecastSFAddressLine1")]
    [StringLength(200)]
    public string ArsaleForecastSfaddressLine1 { get; set; }

    [Column("ARSaleForecastSFAddressLine2")]
    [StringLength(200)]
    public string ArsaleForecastSfaddressLine2 { get; set; }

    [Column("ARSaleForecastSFAddressLine3")]
    [StringLength(200)]
    public string ArsaleForecastSfaddressLine3 { get; set; }

    [Column("ARSaleForecastSFAddressStreet")]
    [StringLength(200)]
    public string ArsaleForecastSfaddressStreet { get; set; }

    [Column("ARSaleForecastSFAddressCity")]
    [StringLength(50)]
    public string ArsaleForecastSfaddressCity { get; set; }

    [Column("ARSaleForecastSFAddressPostalCode")]
    [StringLength(50)]
    public string ArsaleForecastSfaddressPostalCode { get; set; }

    [Column("ARSaleForecastSFAddressStateProvince")]
    [StringLength(50)]
    public string ArsaleForecastSfaddressStateProvince { get; set; }

    [Column("ARSaleForecastSFAddressZipCode")]
    [StringLength(50)]
    public string ArsaleForecastSfaddressZipCode { get; set; }

    [Column("ARSaleForecastSFAddressCountry")]
    [StringLength(50)]
    public string ArsaleForecastSfaddressCountry { get; set; }

    [Column("ARSaleForecastSFDiffPricePercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastSfdiffPricePercent { get; set; }

    [Column("ARSaleForecastSFDiffPriceAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastSfdiffPriceAmount { get; set; }

    [Column("ARSaleForecastSFCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastSfcommissionPercent { get; set; }

    [Column("ARSaleForecastSFCommissionAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastSfcommissionAmount { get; set; }

    [Column("FK_ARCustomerContactInvoiceID")]
    public int? FkArcustomerContactInvoiceId { get; set; }

    [Column("ARSaleForecastInvoiceContactName")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceContactName { get; set; }

    [Column("ARSaleForecastInvoiceContactFirstName")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceContactFirstName { get; set; }

    [Column("ARSaleForecastInvoiceContactLastName")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceContactLastName { get; set; }

    [Column("ARSaleForecastInvoiceContactTitle")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceContactTitle { get; set; }

    [Column("ARSaleForecastInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string ArsaleForecastInvoiceContactHeaderLetter { get; set; }

    [Column("ARSaleForecastInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string ArsaleForecastInvoiceContactHeaderMessage { get; set; }

    [Column("ARSaleForecastInvoiceContactEmail1")]
    [StringLength(100)]
    public string ArsaleForecastInvoiceContactEmail1 { get; set; }

    [Column("ARSaleForecastInvoiceContactEmail2")]
    [StringLength(100)]
    public string ArsaleForecastInvoiceContactEmail2 { get; set; }

    [Column("ARSaleForecastInvoiceContactWebsite")]
    [StringLength(100)]
    public string ArsaleForecastInvoiceContactWebsite { get; set; }

    [Column("ARSaleForecastInvoiceContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastInvoiceContactPhonePrivate { get; set; }

    [Column("ARSaleForecastInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastInvoiceContactPhone { get; set; }

    [Column("ARSaleForecastInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastInvoiceContactPhone1 { get; set; }

    [Column("ARSaleForecastInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastInvoiceContactCellPhone { get; set; }

    [Column("ARSaleForecastInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastInvoiceContactCellPhone1 { get; set; }

    [Column("ARSaleForecastInvoiceContactFax")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceContactFax { get; set; }

    [Column("ARSaleForecastInvoiceContactType")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceContactType { get; set; }

    [Column("ARSaleForecastInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsaleForecastInvoiceContactInformation { get; set; }

    [Column("ARSaleForecastInvoiceContactDepartment")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceContactDepartment { get; set; }

    [Column("ARSaleForecastInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsaleForecastInvoiceContactRoom { get; set; }

    [Column("ARSaleForecastInvoiceAddressLine1")]
    [StringLength(200)]
    public string ArsaleForecastInvoiceAddressLine1 { get; set; }

    [Column("ARSaleForecastInvoiceAddressLine2")]
    [StringLength(200)]
    public string ArsaleForecastInvoiceAddressLine2 { get; set; }

    [Column("ARSaleForecastInvoiceAddressLine3")]
    [StringLength(200)]
    public string ArsaleForecastInvoiceAddressLine3 { get; set; }

    [Column("ARSaleForecastInvoiceAddressStreet")]
    [StringLength(200)]
    public string ArsaleForecastInvoiceAddressStreet { get; set; }

    [Column("ARSaleForecastInvoiceAddressCity")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceAddressCity { get; set; }

    [Column("ARSaleForecastInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceAddressPostalCode { get; set; }

    [Column("ARSaleForecastInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceAddressStateProvince { get; set; }

    [Column("ARSaleForecastInvoiceAddressZipCode")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceAddressZipCode { get; set; }

    [Column("ARSaleForecastInvoiceAddressCountry")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceAddressCountry { get; set; }

    [Column("FK_ARCustomerContactDeliveryID")]
    public int? FkArcustomerContactDeliveryId { get; set; }

    [Column("ARSaleForecastDeliveryContactName")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryContactName { get; set; }

    [Column("ARSaleForecastDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? ArsaleForecastDeliveryContactBirthday { get; set; }

    [Column("ARSaleForecastDeliveryContactFirstName")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryContactFirstName { get; set; }

    [Column("ARSaleForecastDeliveryContactLastName")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryContactLastName { get; set; }

    [Column("ARSaleForecastDeliveryContactTitle")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryContactTitle { get; set; }

    [Column("ARSaleForecastDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string ArsaleForecastDeliveryContactHeaderLetter { get; set; }

    [Column("ARSaleForecastDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string ArsaleForecastDeliveryContactHeaderMessage { get; set; }

    [Column("ARSaleForecastDeliveryContactEmail1")]
    [StringLength(100)]
    public string ArsaleForecastDeliveryContactEmail1 { get; set; }

    [Column("ARSaleForecastDeliveryContactEmail2")]
    [StringLength(100)]
    public string ArsaleForecastDeliveryContactEmail2 { get; set; }

    [Column("ARSaleForecastDeliveryContactWebsite")]
    [StringLength(100)]
    public string ArsaleForecastDeliveryContactWebsite { get; set; }

    [Column("ARSaleForecastDeliveryContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastDeliveryContactPhonePrivate { get; set; }

    [Column("ARSaleForecastDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastDeliveryContactPhone { get; set; }

    [Column("ARSaleForecastDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastDeliveryContactPhone1 { get; set; }

    [Column("ARSaleForecastDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastDeliveryContactCellPhone { get; set; }

    [Column("ARSaleForecastDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastDeliveryContactCellPhone1 { get; set; }

    [Column("ARSaleForecastDeliveryContactFax")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryContactFax { get; set; }

    [Column("ARSaleForecastDeliveryContactType")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryContactType { get; set; }

    [Column("ARSaleForecastDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsaleForecastDeliveryContactInformation { get; set; }

    [Column("ARSaleForecastDeliveryContactDepartment")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryContactDepartment { get; set; }

    [Column("ARSaleForecastDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsaleForecastDeliveryContactRoom { get; set; }

    [Column("ARSaleForecastDeliveryAddressLine1")]
    [StringLength(200)]
    public string ArsaleForecastDeliveryAddressLine1 { get; set; }

    [Column("ARSaleForecastDeliveryAddressLine2")]
    [StringLength(200)]
    public string ArsaleForecastDeliveryAddressLine2 { get; set; }

    [Column("ARSaleForecastDeliveryAddressLine3")]
    [StringLength(200)]
    public string ArsaleForecastDeliveryAddressLine3 { get; set; }

    [Column("ARSaleForecastDeliveryAddressStreet")]
    [StringLength(200)]
    public string ArsaleForecastDeliveryAddressStreet { get; set; }

    [Column("ARSaleForecastDeliveryAddressCity")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryAddressCity { get; set; }

    [Column("ARSaleForecastDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryAddressPostalCode { get; set; }

    [Column("ARSaleForecastDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryAddressStateProvince { get; set; }

    [Column("ARSaleForecastDeliveryAddressZipCode")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryAddressZipCode { get; set; }

    [Column("ARSaleForecastDeliveryAddressCountry")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryAddressCountry { get; set; }

    [Column("FK_ARCustomerContactPaymentID")]
    public int? FkArcustomerContactPaymentId { get; set; }

    [Column("ARSaleForecastPaymentContactName")]
    [StringLength(50)]
    public string ArsaleForecastPaymentContactName { get; set; }

    [Column("ARSaleForecastPaymentContactBirthday", TypeName = "datetime")]
    public DateTime? ArsaleForecastPaymentContactBirthday { get; set; }

    [Column("ARSaleForecastPaymentContactFirstName")]
    [StringLength(50)]
    public string ArsaleForecastPaymentContactFirstName { get; set; }

    [Column("ARSaleForecastPaymentContactLastName")]
    [StringLength(50)]
    public string ArsaleForecastPaymentContactLastName { get; set; }

    [Column("ARSaleForecastPaymentContactTitle")]
    [StringLength(50)]
    public string ArsaleForecastPaymentContactTitle { get; set; }

    [Column("ARSaleForecastPaymentContactHeaderLetter")]
    [StringLength(100)]
    public string ArsaleForecastPaymentContactHeaderLetter { get; set; }

    [Column("ARSaleForecastPaymentContactHeaderMessage")]
    [StringLength(255)]
    public string ArsaleForecastPaymentContactHeaderMessage { get; set; }

    [Column("ARSaleForecastPaymentContactEmail1")]
    [StringLength(100)]
    public string ArsaleForecastPaymentContactEmail1 { get; set; }

    [Column("ARSaleForecastPaymentContactEmail2")]
    [StringLength(100)]
    public string ArsaleForecastPaymentContactEmail2 { get; set; }

    [Column("ARSaleForecastPaymentContactWebsite")]
    [StringLength(100)]
    public string ArsaleForecastPaymentContactWebsite { get; set; }

    [Column("ARSaleForecastPaymentContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastPaymentContactPhonePrivate { get; set; }

    [Column("ARSaleForecastPaymentContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastPaymentContactPhone { get; set; }

    [Column("ARSaleForecastPaymentContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastPaymentContactPhone1 { get; set; }

    [Column("ARSaleForecastPaymentContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastPaymentContactCellPhone { get; set; }

    [Column("ARSaleForecastPaymentContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleForecastPaymentContactCellPhone1 { get; set; }

    [Column("ARSaleForecastPaymentContactFax")]
    [StringLength(50)]
    public string ArsaleForecastPaymentContactFax { get; set; }

    [Column("ARSaleForecastPaymentContactType")]
    [StringLength(50)]
    public string ArsaleForecastPaymentContactType { get; set; }

    [Column("ARSaleForecastPaymentContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsaleForecastPaymentContactInformation { get; set; }

    [Column("ARSaleForecastPaymentContactDepartment")]
    [StringLength(50)]
    public string ArsaleForecastPaymentContactDepartment { get; set; }

    [Column("ARSaleForecastPaymentContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsaleForecastPaymentContactRoom { get; set; }

    [Column("ARSaleForecastPaymentAddressLine1")]
    [StringLength(200)]
    public string ArsaleForecastPaymentAddressLine1 { get; set; }

    [Column("ARSaleForecastPaymentAddressLine2")]
    [StringLength(200)]
    public string ArsaleForecastPaymentAddressLine2 { get; set; }

    [Column("ARSaleForecastPaymentAddressLine3")]
    [StringLength(200)]
    public string ArsaleForecastPaymentAddressLine3 { get; set; }

    [Column("ARSaleForecastPaymentAddressStreet")]
    [StringLength(200)]
    public string ArsaleForecastPaymentAddressStreet { get; set; }

    [Column("ARSaleForecastPaymentAddressCity")]
    [StringLength(50)]
    public string ArsaleForecastPaymentAddressCity { get; set; }

    [Column("ARSaleForecastPaymentAddressPostalCode")]
    [StringLength(50)]
    public string ArsaleForecastPaymentAddressPostalCode { get; set; }

    [Column("ARSaleForecastPaymentAddressStateProvince")]
    [StringLength(50)]
    public string ArsaleForecastPaymentAddressStateProvince { get; set; }

    [Column("ARSaleForecastPaymentAddressZipCode")]
    [StringLength(50)]
    public string ArsaleForecastPaymentAddressZipCode { get; set; }

    [Column("ARSaleForecastPaymentAddressCountry")]
    [StringLength(50)]
    public string ArsaleForecastPaymentAddressCountry { get; set; }

    [Column("ARSaleForecastShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastShippingFees { get; set; }

    [Column("ARSaleForecastShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastShippingExtraFees { get; set; }

    [Column("ARSaleForecastShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastShippingInsuranceFees { get; set; }

    [Column("ARSaleForecastShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastShippingPackagingFees { get; set; }

    [Column("ARSaleForecastShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastShippingReservedFees1 { get; set; }

    [Column("ARSaleForecastShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastShippingReservedFees2 { get; set; }

    [Column("ARSaleForecastShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastShippingReservedFees3 { get; set; }

    [Column("ARSaleForecastShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastShippingReservedFees4 { get; set; }

    [Column("ARSaleForecastShippingMethodDesc")]
    [StringLength(255)]
    public string ArsaleForecastShippingMethodDesc { get; set; }

    [Column("ARSaleForecastShippingMethodName")]
    [StringLength(50)]
    public string ArsaleForecastShippingMethodName { get; set; }

    [Column("ARSaleForecastExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARSaleForecastTransferredDate", TypeName = "datetime")]
    public DateTime? ArsaleForecastTransferredDate { get; set; }

    [Column("ARSaleForecastMainSellerCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastMainSellerCommissionPercent { get; set; }

    [Column("ARSaleForecastAssSellerCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastAssSellerCommissionPercent { get; set; }

    [Required]
    [Column("ARShippingType")]
    [StringLength(50)]
    public string ArshippingType { get; set; }

    [Column("ARSaleForecastPaymentDate", TypeName = "datetime")]
    public DateTime? ArsaleForecastPaymentDate { get; set; }

    [Column("ARSaleForecastQuantityContainer")]
    [StringLength(100)]
    public string ArsaleForecastQuantityContainer { get; set; }

    [Required]
    [Column("ARSaleForecastTransshipment")]
    [StringLength(100)]
    public string ArsaleForecastTransshipment { get; set; }

    [Column("ARSaleForecastPONo")]
    [StringLength(50)]
    public string ArsaleForecastPono { get; set; }

    [Column("ARSaleForecastPODate", TypeName = "datetime")]
    public DateTime? ArsaleForecastPodate { get; set; }

    [Column("ARSaleForecastType")]
    [StringLength(50)]
    public string ArsaleForecastType { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int FkGepaymentTermId { get; set; }

    [Column("ARSaleForecastCustomerName")]
    [StringLength(256)]
    public string ArsaleForecastCustomerName { get; set; }

    [Column("ARSaleForecastInvoiceAddressTaxCode")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceAddressTaxCode { get; set; }

    [Column("ARSaleForecastInvoiceAddressTel")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceAddressTel { get; set; }

    [Column("ARSaleForecastInvoiceAddressFax")]
    [StringLength(50)]
    public string ArsaleForecastInvoiceAddressFax { get; set; }

    [Column("ARSaleForecastDeliveryAddressTaxCode")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryAddressTaxCode { get; set; }

    [Column("ARSaleForecastDeliveryAddressTel")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryAddressTel { get; set; }

    [Column("ARSaleForecastDeliveryAddressFax")]
    [StringLength(50)]
    public string ArsaleForecastDeliveryAddressFax { get; set; }

    [Column("ARSaleForecastPaymentAddressTaxCode")]
    [StringLength(50)]
    public string ArsaleForecastPaymentAddressTaxCode { get; set; }

    [Column("ARSaleForecastPaymentAddressTel")]
    [StringLength(50)]
    public string ArsaleForecastPaymentAddressTel { get; set; }

    [Column("ARSaleForecastPaymentAddressFax")]
    [StringLength(50)]
    public string ArsaleForecastPaymentAddressFax { get; set; }

    [Column("ARSaleForecastTotalProduct", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastTotalProduct { get; set; }

    [Column("ARSaleForecastContQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastContQty { get; set; }

    [Column("FK_BRTransferredBranchID")]
    public int? FkBrtransferredBranchId { get; set; }

    [Column("ARSaleForecastProductType")]
    [StringLength(225)]
    public string ArsaleForecastProductType { get; set; }

    [Column("FK_GECurrencyID2")]
    public int? FkGecurrencyId2 { get; set; }

    [Column("ARSaleForecastExchangeRate2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastExchangeRate2 { get; set; }

    [Required]
    [Column("ARSaleForecastSaleType")]
    [StringLength(50)]
    public string ArsaleForecastSaleType { get; set; }

    [Column("ARSaleForecastDiscountPerCentForItem", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastDiscountPerCentForItem { get; set; }

    [Column("ARSaleForecastPercentQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastPercentQty { get; set; }

    [Column("ARSaleForecastTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastTotalCost { get; set; }

    [Column("ARSaleForecastSOCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastSocommissionPercent { get; set; }

    [Column("ARSaleForecastSOCommissionAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleForecastSocommissionAmount { get; set; }

    [Column("ARSaleForecastComment")]
    [MaxLength(8000)]
    public byte[] ArsaleForecastComment { get; set; }

    [Column("ARSaleForecastInternalComment")]
    [MaxLength(8000)]
    public byte[] ArsaleForecastInternalComment { get; set; }

    [InverseProperty("FkArsaleForecast")]
    public virtual ICollection<ArcancelSaleForecast> ArcancelSaleForecasts { get; set; } = new List<ArcancelSaleForecast>();

    [InverseProperty("FkArsaleForecast")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkArsaleForecast")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkArsaleForecast")]
    public virtual ICollection<ArsaleForecastItem> ArsaleForecastItems { get; set; } = new List<ArsaleForecastItem>();

    [InverseProperty("FkArsaleForecast")]
    public virtual ICollection<ArsaleForecastTemplate> ArsaleForecastTemplates { get; set; } = new List<ArsaleForecastTemplate>();

    [InverseProperty("FkArsaleForecast")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [ForeignKey("FkArassociatedSellerId")]
    [InverseProperty("ArsaleForecastFkArassociatedSellers")]
    public virtual Hremployee FkArassociatedSeller { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArsaleForecasts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArcustomerContactDeliveryId")]
    [InverseProperty("ArsaleForecastFkArcustomerContactDeliveries")]
    public virtual ArcustomerContact FkArcustomerContactDelivery { get; set; }

    [ForeignKey("FkArcustomerContactPaymentId")]
    [InverseProperty("ArsaleForecastFkArcustomerContactPayments")]
    public virtual ArcustomerContact FkArcustomerContactPayment { get; set; }

    [ForeignKey("FkArcustomerContactSfid")]
    [InverseProperty("ArsaleForecastFkArcustomerContactSfs")]
    public virtual ArcustomerContact FkArcustomerContactSf { get; set; }

    [ForeignKey("FkArpriceLevelId")]
    [InverseProperty("ArsaleForecasts")]
    public virtual ArpriceLevel FkArpriceLevel { get; set; }

    [ForeignKey("FkArsellerId")]
    [InverseProperty("ArsaleForecastFkArsellers")]
    public virtual Hremployee FkArseller { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArsaleForecasts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArsaleForecastFkGecurrencies")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGecurrencyId2")]
    [InverseProperty("ArsaleForecastFkGecurrencyId2Navigations")]
    public virtual Gecurrency FkGecurrencyId2Navigation { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("ArsaleForecasts")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("ArsaleForecasts")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkGevatregionId")]
    [InverseProperty("ArsaleForecasts")]
    public virtual Gevatregion FkGevatregion { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArsaleForecastFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ArsaleForecasts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }
}
