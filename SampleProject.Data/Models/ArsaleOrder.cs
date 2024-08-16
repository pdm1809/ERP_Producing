using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrders")]
[Microsoft.EntityFrameworkCore.Index("ArsaleOrderNo", "ArsaleOrderDate", "FkBrbranchId", "FkArcustomerId", "ArsaleOrderReference", "ArsaleOrderTypeCombo", Name = "Idx_ARSaleOrders")]
public partial class ArsaleOrder
{
    [Key]
    [Column("ARSaleOrderID")]
    public int ArsaleOrderId { get; set; }

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
    public int? FkArcustomerId { get; set; }

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
    [Column("ARSaleOrderNo")]
    [StringLength(50)]
    public string ArsaleOrderNo { get; set; }

    [Column("ARSaleOrderName")]
    [StringLength(100)]
    public string ArsaleOrderName { get; set; }

    [Column("ARSaleOrderDesc")]
    [StringLength(512)]
    public string ArsaleOrderDesc { get; set; }

    [Column("ARSaleOrderStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderStatus { get; set; }

    [Column("ARSaleOrderPaymentTerm")]
    [StringLength(50)]
    public string ArsaleOrderPaymentTerm { get; set; }

    [Column("ARPaymentMethodCombo")]
    [StringLength(50)]
    public string ArpaymentMethodCombo { get; set; }

    [Column("ARSaleOrderDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderDate { get; set; }

    [Column("ARSaleOrderValidateDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderValidateDate { get; set; }

    [Column("ARSaleOrderDeliveryDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderDeliveryDate { get; set; }

    [Column("ARSaleOrderDeliveryTime", TypeName = "datetime")]
    public DateTime? ArsaleOrderDeliveryTime { get; set; }

    [Column("ARSaleOrderDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderDiscountPerCent { get; set; }

    [Column("ARSaleOrderDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderDiscountFix { get; set; }

    [Column("ARSaleOrderReference")]
    [StringLength(512)]
    public string ArsaleOrderReference { get; set; }

    [Column("ARSaleOrderActiveCheck")]
    public bool? ArsaleOrderActiveCheck { get; set; }

    [Column("ARSaleOrderTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderTaxNumber { get; set; }

    [Column("ARSaleOrderTypeCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderTypeCombo { get; set; }

    [Column("ARSaleOrderNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderNetAmount { get; set; }

    [Column("ARSaleOrderTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderTaxPercent { get; set; }

    [Column("ARSaleOrderTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderTaxAmount { get; set; }

    [Column("ARSaleOrderSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderSubTotalAmount { get; set; }

    [Column("ARSaleOrderTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderTotalAmount { get; set; }

    [Column("ARSaleOrderDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderDepositBalance { get; set; }

    [Column("ARSaleOrderBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderBalanceDue { get; set; }

    [Column("FK_ARCustomerContactSOID")]
    public int? FkArcustomerContactSoid { get; set; }

    [Column("ARSaleOrderSOContactName")]
    [StringLength(50)]
    public string ArsaleOrderSocontactName { get; set; }

    [Column("ARSaleOrderSOContactBirthday", TypeName = "datetime")]
    public DateTime? ArsaleOrderSocontactBirthday { get; set; }

    [Column("ARSaleOrderSOContactFirstName")]
    [StringLength(50)]
    public string ArsaleOrderSocontactFirstName { get; set; }

    [Column("ARSaleOrderSOContactLastName")]
    [StringLength(50)]
    public string ArsaleOrderSocontactLastName { get; set; }

    [Column("ARSaleOrderSOContactTitle")]
    [StringLength(50)]
    public string ArsaleOrderSocontactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARSaleOrderSOContactHeaderLetter")]
    [StringLength(100)]
    public string ArsaleOrderSocontactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARSaleOrderSOContactHeaderMessage")]
    [StringLength(255)]
    public string ArsaleOrderSocontactHeaderMessage { get; set; }

    [Column("ARSaleOrderSOContactEmail1")]
    [StringLength(100)]
    public string ArsaleOrderSocontactEmail1 { get; set; }

    [Column("ARSaleOrderSOContactEmail2")]
    [StringLength(100)]
    public string ArsaleOrderSocontactEmail2 { get; set; }

    [Column("ARSaleOrderSOContactWebsite")]
    [StringLength(100)]
    public string ArsaleOrderSocontactWebsite { get; set; }

    [Column("ARSaleOrderSOContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderSocontactPhonePrivate { get; set; }

    [Column("ARSaleOrderSOContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderSocontactPhone { get; set; }

    [Column("ARSaleOrderSOContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderSocontactPhone1 { get; set; }

    [Column("ARSaleOrderSOContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderSocontactCellPhone { get; set; }

    [Column("ARSaleOrderSOContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderSocontactCellPhone1 { get; set; }

    [Column("ARSaleOrderSOContactFax")]
    [StringLength(50)]
    public string ArsaleOrderSocontactFax { get; set; }

    [Column("ARSaleOrderSOContactType")]
    [StringLength(50)]
    public string ArsaleOrderSocontactType { get; set; }

    [Column("ARSaleOrderSOContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsaleOrderSocontactInformation { get; set; }

    [Column("ARSaleOrderSOContactDepartment")]
    [StringLength(50)]
    public string ArsaleOrderSocontactDepartment { get; set; }

    [Column("ARSaleOrderSOContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsaleOrderSocontactRoom { get; set; }

    [Column("ARSaleOrderSOAddressLine1")]
    [StringLength(200)]
    public string ArsaleOrderSoaddressLine1 { get; set; }

    [Column("ARSaleOrderSOAddressLine2")]
    [StringLength(200)]
    public string ArsaleOrderSoaddressLine2 { get; set; }

    [Column("ARSaleOrderSOAddressLine3")]
    [StringLength(200)]
    public string ArsaleOrderSoaddressLine3 { get; set; }

    [Column("ARSaleOrderSOAddressStreet")]
    [StringLength(200)]
    public string ArsaleOrderSoaddressStreet { get; set; }

    [Column("ARSaleOrderSOAddressCity")]
    [StringLength(50)]
    public string ArsaleOrderSoaddressCity { get; set; }

    [Column("ARSaleOrderSOAddressPostalCode")]
    [StringLength(50)]
    public string ArsaleOrderSoaddressPostalCode { get; set; }

    [Column("ARSaleOrderSOAddressStateProvince")]
    [StringLength(50)]
    public string ArsaleOrderSoaddressStateProvince { get; set; }

    [Column("ARSaleOrderSOAddressZipCode")]
    [StringLength(50)]
    public string ArsaleOrderSoaddressZipCode { get; set; }

    [Column("ARSaleOrderSOAddressCountry")]
    [StringLength(50)]
    public string ArsaleOrderSoaddressCountry { get; set; }

    [Column("ARSaleOrderSODiffPricePercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderSodiffPricePercent { get; set; }

    [Column("ARSaleOrderSODiffPriceAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderSodiffPriceAmount { get; set; }

    [Column("ARSaleOrderSOCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderSocommissionPercent { get; set; }

    [Column("ARSaleOrderSOCommissionAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderSocommissionAmount { get; set; }

    [Column("FK_ARCustomerContactInvoiceID")]
    public int? FkArcustomerContactInvoiceId { get; set; }

    [Column("ARSaleOrderInvoiceContactName")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceContactName { get; set; }

    [Column("ARSaleOrderInvoiceContactFirstName")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceContactFirstName { get; set; }

    [Column("ARSaleOrderInvoiceContactLastName")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceContactLastName { get; set; }

    [Column("ARSaleOrderInvoiceContactTitle")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARSaleOrderInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string ArsaleOrderInvoiceContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARSaleOrderInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string ArsaleOrderInvoiceContactHeaderMessage { get; set; }

    [Column("ARSaleOrderInvoiceContactEmail1")]
    [StringLength(100)]
    public string ArsaleOrderInvoiceContactEmail1 { get; set; }

    [Column("ARSaleOrderInvoiceContactEmail2")]
    [StringLength(100)]
    public string ArsaleOrderInvoiceContactEmail2 { get; set; }

    [Column("ARSaleOrderInvoiceContactWebsite")]
    [StringLength(100)]
    public string ArsaleOrderInvoiceContactWebsite { get; set; }

    [Column("ARSaleOrderInvoiceContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderInvoiceContactPhonePrivate { get; set; }

    [Column("ARSaleOrderInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderInvoiceContactPhone { get; set; }

    [Column("ARSaleOrderInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderInvoiceContactPhone1 { get; set; }

    [Column("ARSaleOrderInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderInvoiceContactCellPhone { get; set; }

    [Column("ARSaleOrderInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderInvoiceContactCellPhone1 { get; set; }

    [Column("ARSaleOrderInvoiceContactFax")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceContactFax { get; set; }

    [Column("ARSaleOrderInvoiceContactType")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceContactType { get; set; }

    [Column("ARSaleOrderInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsaleOrderInvoiceContactInformation { get; set; }

    [Column("ARSaleOrderInvoiceContactDepartment")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceContactDepartment { get; set; }

    [Column("ARSaleOrderInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsaleOrderInvoiceContactRoom { get; set; }

    [Column("ARSaleOrderInvoiceAddressLine1")]
    [StringLength(200)]
    public string ArsaleOrderInvoiceAddressLine1 { get; set; }

    [Column("ARSaleOrderInvoiceAddressLine2")]
    [StringLength(200)]
    public string ArsaleOrderInvoiceAddressLine2 { get; set; }

    [Column("ARSaleOrderInvoiceAddressLine3")]
    [StringLength(200)]
    public string ArsaleOrderInvoiceAddressLine3 { get; set; }

    [Column("ARSaleOrderInvoiceAddressStreet")]
    [StringLength(200)]
    public string ArsaleOrderInvoiceAddressStreet { get; set; }

    [Column("ARSaleOrderInvoiceAddressCity")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceAddressCity { get; set; }

    [Column("ARSaleOrderInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceAddressPostalCode { get; set; }

    [Column("ARSaleOrderInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceAddressStateProvince { get; set; }

    [Column("ARSaleOrderInvoiceAddressZipCode")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceAddressZipCode { get; set; }

    [Column("ARSaleOrderInvoiceAddressCountry")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceAddressCountry { get; set; }

    [Column("FK_ARCustomerContactDeliveryID")]
    public int? FkArcustomerContactDeliveryId { get; set; }

    [Column("ARSaleOrderDeliveryContactName")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryContactName { get; set; }

    [Column("ARSaleOrderDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? ArsaleOrderDeliveryContactBirthday { get; set; }

    [Column("ARSaleOrderDeliveryContactFirstName")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryContactFirstName { get; set; }

    [Column("ARSaleOrderDeliveryContactLastName")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryContactLastName { get; set; }

    [Column("ARSaleOrderDeliveryContactTitle")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARSaleOrderDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string ArsaleOrderDeliveryContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARSaleOrderDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string ArsaleOrderDeliveryContactHeaderMessage { get; set; }

    [Column("ARSaleOrderDeliveryContactEmail1")]
    [StringLength(100)]
    public string ArsaleOrderDeliveryContactEmail1 { get; set; }

    [Column("ARSaleOrderDeliveryContactEmail2")]
    [StringLength(100)]
    public string ArsaleOrderDeliveryContactEmail2 { get; set; }

    [Column("ARSaleOrderDeliveryContactWebsite")]
    [StringLength(100)]
    public string ArsaleOrderDeliveryContactWebsite { get; set; }

    [Column("ARSaleOrderDeliveryContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderDeliveryContactPhonePrivate { get; set; }

    [Column("ARSaleOrderDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderDeliveryContactPhone { get; set; }

    [Column("ARSaleOrderDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderDeliveryContactPhone1 { get; set; }

    [Column("ARSaleOrderDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderDeliveryContactCellPhone { get; set; }

    [Column("ARSaleOrderDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderDeliveryContactCellPhone1 { get; set; }

    [Column("ARSaleOrderDeliveryContactFax")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryContactFax { get; set; }

    [Column("ARSaleOrderDeliveryContactType")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryContactType { get; set; }

    [Column("ARSaleOrderDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsaleOrderDeliveryContactInformation { get; set; }

    [Column("ARSaleOrderDeliveryContactDepartment")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryContactDepartment { get; set; }

    [Column("ARSaleOrderDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsaleOrderDeliveryContactRoom { get; set; }

    [Column("ARSaleOrderDeliveryAddressLine1")]
    [StringLength(200)]
    public string ArsaleOrderDeliveryAddressLine1 { get; set; }

    [Column("ARSaleOrderDeliveryAddressLine2")]
    [StringLength(200)]
    public string ArsaleOrderDeliveryAddressLine2 { get; set; }

    [Column("ARSaleOrderDeliveryAddressLine3")]
    [StringLength(200)]
    public string ArsaleOrderDeliveryAddressLine3 { get; set; }

    [Column("ARSaleOrderDeliveryAddressStreet")]
    [StringLength(200)]
    public string ArsaleOrderDeliveryAddressStreet { get; set; }

    [Column("ARSaleOrderDeliveryAddressCity")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryAddressCity { get; set; }

    [Column("ARSaleOrderDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryAddressPostalCode { get; set; }

    [Column("ARSaleOrderDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryAddressStateProvince { get; set; }

    [Column("ARSaleOrderDeliveryAddressZipCode")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryAddressZipCode { get; set; }

    [Column("ARSaleOrderDeliveryAddressCountry")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryAddressCountry { get; set; }

    [Column("FK_ARCustomerContactPaymentID")]
    public int? FkArcustomerContactPaymentId { get; set; }

    [Column("ARSaleOrderPaymentContactName")]
    [StringLength(50)]
    public string ArsaleOrderPaymentContactName { get; set; }

    [Column("ARSaleOrderPaymentContactBirthday", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentContactBirthday { get; set; }

    [Column("ARSaleOrderPaymentContactFirstName")]
    [StringLength(50)]
    public string ArsaleOrderPaymentContactFirstName { get; set; }

    [Column("ARSaleOrderPaymentContactLastName")]
    [StringLength(50)]
    public string ArsaleOrderPaymentContactLastName { get; set; }

    [Column("ARSaleOrderPaymentContactTitle")]
    [StringLength(50)]
    public string ArsaleOrderPaymentContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARSaleOrderPaymentContactHeaderLetter")]
    [StringLength(100)]
    public string ArsaleOrderPaymentContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARSaleOrderPaymentContactHeaderMessage")]
    [StringLength(255)]
    public string ArsaleOrderPaymentContactHeaderMessage { get; set; }

    [Column("ARSaleOrderPaymentContactEmail1")]
    [StringLength(100)]
    public string ArsaleOrderPaymentContactEmail1 { get; set; }

    [Column("ARSaleOrderPaymentContactEmail2")]
    [StringLength(100)]
    public string ArsaleOrderPaymentContactEmail2 { get; set; }

    [Column("ARSaleOrderPaymentContactWebsite")]
    [StringLength(100)]
    public string ArsaleOrderPaymentContactWebsite { get; set; }

    [Column("ARSaleOrderPaymentContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderPaymentContactPhonePrivate { get; set; }

    [Column("ARSaleOrderPaymentContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderPaymentContactPhone { get; set; }

    [Column("ARSaleOrderPaymentContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderPaymentContactPhone1 { get; set; }

    [Column("ARSaleOrderPaymentContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderPaymentContactCellPhone { get; set; }

    [Column("ARSaleOrderPaymentContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderPaymentContactCellPhone1 { get; set; }

    [Column("ARSaleOrderPaymentContactFax")]
    [StringLength(50)]
    public string ArsaleOrderPaymentContactFax { get; set; }

    [Column("ARSaleOrderPaymentContactType")]
    [StringLength(50)]
    public string ArsaleOrderPaymentContactType { get; set; }

    [Column("ARSaleOrderPaymentContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsaleOrderPaymentContactInformation { get; set; }

    [Column("ARSaleOrderPaymentContactDepartment")]
    [StringLength(50)]
    public string ArsaleOrderPaymentContactDepartment { get; set; }

    [Column("ARSaleOrderPaymentContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsaleOrderPaymentContactRoom { get; set; }

    [Column("ARSaleOrderPaymentAddressLine1")]
    [StringLength(200)]
    public string ArsaleOrderPaymentAddressLine1 { get; set; }

    [Column("ARSaleOrderPaymentAddressLine2")]
    [StringLength(200)]
    public string ArsaleOrderPaymentAddressLine2 { get; set; }

    [Column("ARSaleOrderPaymentAddressLine3")]
    [StringLength(200)]
    public string ArsaleOrderPaymentAddressLine3 { get; set; }

    [Column("ARSaleOrderPaymentAddressStreet")]
    [StringLength(200)]
    public string ArsaleOrderPaymentAddressStreet { get; set; }

    [Column("ARSaleOrderPaymentAddressCity")]
    [StringLength(50)]
    public string ArsaleOrderPaymentAddressCity { get; set; }

    [Column("ARSaleOrderPaymentAddressPostalCode")]
    [StringLength(50)]
    public string ArsaleOrderPaymentAddressPostalCode { get; set; }

    [Column("ARSaleOrderPaymentAddressStateProvince")]
    [StringLength(50)]
    public string ArsaleOrderPaymentAddressStateProvince { get; set; }

    [Column("ARSaleOrderPaymentAddressZipCode")]
    [StringLength(50)]
    public string ArsaleOrderPaymentAddressZipCode { get; set; }

    [Column("ARSaleOrderPaymentAddressCountry")]
    [StringLength(50)]
    public string ArsaleOrderPaymentAddressCountry { get; set; }

    [Column("ARSaleOrderShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderShippingFees { get; set; }

    [Column("ARSaleOrderShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderShippingExtraFees { get; set; }

    [Column("ARSaleOrderShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderShippingInsuranceFees { get; set; }

    [Column("ARSaleOrderShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderShippingPackagingFees { get; set; }

    [Column("ARSaleOrderShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderShippingReservedFees1 { get; set; }

    [Column("ARSaleOrderShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderShippingReservedFees2 { get; set; }

    [Column("ARSaleOrderShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderShippingReservedFees3 { get; set; }

    [Column("ARSaleOrderShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderShippingReservedFees4 { get; set; }

    [Column("ARSaleOrderShippingMethodDesc")]
    [StringLength(255)]
    public string ArsaleOrderShippingMethodDesc { get; set; }

    [Column("ARSaleOrderShippingMethodName")]
    [StringLength(50)]
    public string ArsaleOrderShippingMethodName { get; set; }

    [Column("ARSaleOrderExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARSaleOrderTransferredDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderTransferredDate { get; set; }

    [Column("ARSaleOrderMainSellerCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderMainSellerCommissionPercent { get; set; }

    [Column("ARSaleOrderAssSellerCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderAssSellerCommissionPercent { get; set; }

    [Column("FK_BRTransferredBranchID")]
    public int? FkBrtransferredBranchId { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int FkGepaymentTermId { get; set; }

    [Column("ARShippingType")]
    [StringLength(50)]
    public string ArshippingType { get; set; }

    [Column("ARSaleOrderPaymentDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPaymentDate { get; set; }

    [Column("ARSaleOrderQuantityContainer")]
    [StringLength(100)]
    public string ArsaleOrderQuantityContainer { get; set; }

    [Column("ARSaleOrderTransshipment")]
    [StringLength(100)]
    public string ArsaleOrderTransshipment { get; set; }

    [Column("ARSaleOrderPONo")]
    [StringLength(50)]
    public string ArsaleOrderPono { get; set; }

    [Column("ARSaleOrderPODate", TypeName = "datetime")]
    public DateTime? ArsaleOrderPodate { get; set; }

    [Column("ARSaleOrderType")]
    [StringLength(50)]
    public string ArsaleOrderType { get; set; }

    [Column("ARSaleOrderBatchStatus")]
    [StringLength(50)]
    public string ArsaleOrderBatchStatus { get; set; }

    [Column("ARSaleOrderCustomerName")]
    [StringLength(256)]
    public string ArsaleOrderCustomerName { get; set; }

    [Column("ARSaleOrderInvoiceAddressTaxCode")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceAddressTaxCode { get; set; }

    [Column("ARSaleOrderInvoiceAddressTel")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceAddressTel { get; set; }

    [Column("ARSaleOrderInvoiceAddressFax")]
    [StringLength(50)]
    public string ArsaleOrderInvoiceAddressFax { get; set; }

    [Column("ARSaleOrderDeliveryAddressTaxCode")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryAddressTaxCode { get; set; }

    [Column("ARSaleOrderDeliveryAddressTel")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryAddressTel { get; set; }

    [Column("ARSaleOrderDeliveryAddressFax")]
    [StringLength(50)]
    public string ArsaleOrderDeliveryAddressFax { get; set; }

    [Column("ARSaleOrderPaymentAddressTaxCode")]
    [StringLength(50)]
    public string ArsaleOrderPaymentAddressTaxCode { get; set; }

    [Column("ARSaleOrderPaymentAddressTel")]
    [StringLength(50)]
    public string ArsaleOrderPaymentAddressTel { get; set; }

    [Column("ARSaleOrderPaymentAddressFax")]
    [StringLength(50)]
    public string ArsaleOrderPaymentAddressFax { get; set; }

    [Column("ARSaleOrderTotalProduct", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderTotalProduct { get; set; }

    [Column("ARSaleOrderContQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderContQty { get; set; }

    [Column("ARSaleOrderPortOFDischarge")]
    [StringLength(256)]
    public string ArsaleOrderPortOfdischarge { get; set; }

    [Column("ARSaleOrderPortPartialShipment")]
    public bool? ArsaleOrderPortPartialShipment { get; set; }

    [Column("ARSaleOrderPortTranShipment")]
    public bool? ArsaleOrderPortTranShipment { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("ARSaleOrderPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPaidAmount { get; set; }

    [Column("ARSaleOrderInvoiceAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderInvoiceAmount { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("ARSaleOrderProductType")]
    [StringLength(50)]
    public string ArsaleOrderProductType { get; set; }

    [Column("FK_GECurrencyID2")]
    public int? FkGecurrencyId2 { get; set; }

    [Column("ARSaleOrderExchangeRate2", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderExchangeRate2 { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("ARSaleOrderSaleType")]
    [StringLength(50)]
    public string ArsaleOrderSaleType { get; set; }

    [Column("ARSaleOrderSaleAgreement")]
    [StringLength(250)]
    public string ArsaleOrderSaleAgreement { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ARSaleOrderTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderTotalCost { get; set; }

    [Column("FK_ARSubSellerID")]
    public int? FkArsubSellerId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("ARSaleOrderParentID")]
    public int? ArsaleOrderParentId { get; set; }

    [Column("ARSaleOrderIsAcceptance")]
    public bool? ArsaleOrderIsAcceptance { get; set; }

    [Column("ARSaleOrderDocumentType")]
    [StringLength(50)]
    public string ArsaleOrderDocumentType { get; set; }

    [Column("ARSaleOrderTotalDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderTotalDiscountFix { get; set; }

    [Column("ACObjectReferenceNo")]
    [StringLength(50)]
    public string AcobjectReferenceNo { get; set; }

    [Column("ARSaleOrderDiscountPerCentAllItem", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderDiscountPerCentAllItem { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ARSaleOrderDeliveryActualDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderDeliveryActualDate { get; set; }

    [Column("ARSaleOrderPreDeliverySurvey")]
    public bool? ArsaleOrderPreDeliverySurvey { get; set; }

    [Column("ARSalesOrderDeliveryTime", TypeName = "datetime")]
    public DateTime? ArsalesOrderDeliveryTime { get; set; }

    [Column("ARSalesOrderDeliveryFloorType")]
    [StringLength(50)]
    public string ArsalesOrderDeliveryFloorType { get; set; }

    [Column("ARSalesOrderDeliveryFloorNumber")]
    public int? ArsalesOrderDeliveryFloorNumber { get; set; }

    [Column("FK_HREmployee2DID")]
    public int? FkHremployee2Did { get; set; }

    [Column("FK_HREmployee3DID")]
    public int? FkHremployee3Did { get; set; }

    [Column("FK_HREmployeeManager2DID")]
    public int? FkHremployeeManager2Did { get; set; }

    [Column("FK_HREmployeeManager3DID")]
    public int? FkHremployeeManager3Did { get; set; }

    [Column("ARSaleOrderPriceCostTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderPriceCostTotalAmount { get; set; }

    [Column("ARSaleOrderBrokerPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderBrokerPercent { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("ARAssObjectType")]
    [StringLength(50)]
    public string ArassObjectType { get; set; }

    [Column("FK_AROpportunityID")]
    public int? FkAropportunityId { get; set; }

    [Column("ARSaleOrderIsReceiveBill")]
    public bool? ArsaleOrderIsReceiveBill { get; set; }

    [Column("FK_ARDeliveryMethodID")]
    public int? FkArdeliveryMethodId { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("ARSaleOrderIsDeliveryPlan")]
    public bool? ArsaleOrderIsDeliveryPlan { get; set; }

    [Column("ARSaleOrderIsSaleOrderShipment")]
    public bool? ArsaleOrderIsSaleOrderShipment { get; set; }

    [Column("ARSaleOrderIsInvoiceAndShipment")]
    public bool? ArsaleOrderIsInvoiceAndShipment { get; set; }

    [Column("ARSaleOrderIsVehicleAllocation")]
    public bool? ArsaleOrderIsVehicleAllocation { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_ARInvoiceRequestID")]
    public int? FkArinvoiceRequestId { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("FK_ARDiscountProgramID")]
    public int? FkArdiscountProgramId { get; set; }

    [Column("ARSaleOrderPortOFLoading")]
    [StringLength(256)]
    public string ArsaleOrderPortOfloading { get; set; }

    [Column("ARSaleOrderIsContainerLoader")]
    public bool? ArsaleOrderIsContainerLoader { get; set; }

    [Column("FK_ARShipperID")]
    public int? FkArshipperId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [Column("FK_GETerminalID")]
    public int? FkGeterminalId { get; set; }

    [Column("ARSaleOrderPortPartialShipmentText")]
    [StringLength(100)]
    public string ArsaleOrderPortPartialShipmentText { get; set; }

    [Column("ARSaleOrderPortTranShipmentText")]
    [StringLength(100)]
    public string ArsaleOrderPortTranShipmentText { get; set; }

    [Column("ARSaleOrderProject")]
    [StringLength(100)]
    public string ArsaleOrderProject { get; set; }

    [Column("ARSaleOrderInvoiceRequest")]
    [StringLength(100)]
    public string ArsaleOrderInvoiceRequest { get; set; }

    [Column("ARSaleOrderSaleContract")]
    [StringLength(100)]
    public string ArsaleOrderSaleContract { get; set; }

    [Required]
    [Column("ARListOfSalesChannelType")]
    [StringLength(50)]
    public string ArlistOfSalesChannelType { get; set; }

    [Column("ARSaleOrderComment")]
    public byte[] ArsaleOrderComment { get; set; }

    [Column("ARSaleOrderInternalComment")]
    public byte[] ArsaleOrderInternalComment { get; set; }

    [Column("ARSaleOrderCBM", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderCbm { get; set; }

    [Column("ARSaleOrderPortShippingLineText")]
    [StringLength(500)]
    public string ArsaleOrderPortShippingLineText { get; set; }

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<AcclearingDebtInvoiceItem> AcclearingDebtInvoiceItems { get; set; } = new List<AcclearingDebtInvoiceItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<Aracceptance> Aracceptances { get; set; } = new List<Aracceptance>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArallocationItem> ArallocationItems { get; set; } = new List<ArallocationItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; } = new List<ArcancelVoucherItemCost>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArcanceledDeliveryPlanItem> ArcanceledDeliveryPlanItems { get; set; } = new List<ArcanceledDeliveryPlanItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArclearingDetail> ArclearingDetails { get; set; } = new List<ArclearingDetail>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<Arcommission> Arcommissions { get; set; } = new List<Arcommission>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArcontainerLoaderItemDetail> ArcontainerLoaderItemDetails { get; set; } = new List<ArcontainerLoaderItemDetail>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArcontainerLoaderItem> ArcontainerLoaderItems { get; set; } = new List<ArcontainerLoaderItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArcustomerPaymentTimePayment> ArcustomerPaymentTimePayments { get; set; } = new List<ArcustomerPaymentTimePayment>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; } = new List<ArdeliveryPlanMachineDevice>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArdeliveryPlanWorkAsset> ArdeliveryPlanWorkAssets { get; set; } = new List<ArdeliveryPlanWorkAsset>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArdeliveryPlanWork> ArdeliveryPlanWorks { get; set; } = new List<ArdeliveryPlanWork>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArinvoiceCommission> ArinvoiceCommissions { get; set; } = new List<ArinvoiceCommission>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArpaymentProposalItem> ArpaymentProposalItems { get; set; } = new List<ArpaymentProposalItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArproductionPlanningItem> ArproductionPlanningItems { get; set; } = new List<ArproductionPlanningItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArreceptionItem> ArreceptionItems { get; set; } = new List<ArreceptionItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<Arremind> Arreminds { get; set; } = new List<Arremind>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderHistory> ArsaleOrderHistories { get; set; } = new List<ArsaleOrderHistory>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderItemAllocationFee> ArsaleOrderItemAllocationFees { get; set; } = new List<ArsaleOrderItemAllocationFee>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderItemContainer> ArsaleOrderItemContainers { get; set; } = new List<ArsaleOrderItemContainer>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderItemOtherFee> ArsaleOrderItemOtherFees { get; set; } = new List<ArsaleOrderItemOtherFee>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderItemWorkItem> ArsaleOrderItemWorkItems { get; set; } = new List<ArsaleOrderItemWorkItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderItemWork> ArsaleOrderItemWorks { get; set; } = new List<ArsaleOrderItemWork>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderPaymentTime> ArsaleOrderPaymentTimes { get; set; } = new List<ArsaleOrderPaymentTime>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsaleOrderTemplate> ArsaleOrderTemplates { get; set; } = new List<ArsaleOrderTemplate>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<Arsalesman> Arsalesmen { get; set; } = new List<Arsalesman>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<ArsopaymentTimeInvoiceDetail> ArsopaymentTimeInvoiceDetails { get; set; } = new List<ArsopaymentTimeInvoiceDetail>();

    [InverseProperty("FasellOrder")]
    public virtual ICollection<FaproposalSellOrder> FaproposalSellOrders { get; set; } = new List<FaproposalSellOrder>();

    [InverseProperty("FasellOrder")]
    public virtual ICollection<FapurchaseOrderSellOrder> FapurchaseOrderSellOrders { get; set; } = new List<FapurchaseOrderSellOrder>();

    [InverseProperty("FasellOrder")]
    public virtual ICollection<FasellOrderContact> FasellOrderContacts { get; set; } = new List<FasellOrderContact>();

    [InverseProperty("FasellOrder")]
    public virtual ICollection<FasellOrderDiscount> FasellOrderDiscounts { get; set; } = new List<FasellOrderDiscount>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ArsaleOrders")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkArassociatedSellerId")]
    [InverseProperty("ArsaleOrderFkArassociatedSellers")]
    public virtual Hremployee FkArassociatedSeller { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArsaleOrders")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArcustomerContactDeliveryId")]
    [InverseProperty("ArsaleOrderFkArcustomerContactDeliveries")]
    public virtual ArcustomerContact FkArcustomerContactDelivery { get; set; }

    [ForeignKey("FkArcustomerContactPaymentId")]
    [InverseProperty("ArsaleOrderFkArcustomerContactPayments")]
    public virtual ArcustomerContact FkArcustomerContactPayment { get; set; }

    [ForeignKey("FkArcustomerContactSoid")]
    [InverseProperty("ArsaleOrderFkArcustomerContactSos")]
    public virtual ArcustomerContact FkArcustomerContactSo { get; set; }

    [ForeignKey("FkArdeliveryMethodId")]
    [InverseProperty("ArsaleOrders")]
    public virtual ArdeliveryMethod FkArdeliveryMethod { get; set; }

    [ForeignKey("FkArinvoiceRequestId")]
    [InverseProperty("ArsaleOrders")]
    public virtual ArinvoiceRequest FkArinvoiceRequest { get; set; }

    [ForeignKey("FkAropportunityId")]
    [InverseProperty("ArsaleOrders")]
    public virtual Aropportunity FkAropportunity { get; set; }

    [ForeignKey("FkArpriceLevelId")]
    [InverseProperty("ArsaleOrders")]
    public virtual ArpriceLevel FkArpriceLevel { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArsaleOrders")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkArsellerId")]
    [InverseProperty("ArsaleOrderFkArsellers")]
    public virtual Hremployee FkArseller { get; set; }

    [ForeignKey("FkArshipperId")]
    [InverseProperty("ArsaleOrderFkArshippers")]
    public virtual Hremployee FkArshipper { get; set; }

    [ForeignKey("FkArsubSellerId")]
    [InverseProperty("ArsaleOrderFkArsubSellers")]
    public virtual Hremployee FkArsubSeller { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArsaleOrders")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCscompanyBankId")]
    [InverseProperty("ArsaleOrders")]
    public virtual CscompanyBank FkCscompanyBank { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArsaleOrderFkGecurrencies")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGecurrencyId2")]
    [InverseProperty("ArsaleOrderFkGecurrencyId2Navigations")]
    public virtual Gecurrency FkGecurrencyId2Navigation { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("ArsaleOrders")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("ArsaleOrders")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkGeterminalId")]
    [InverseProperty("ArsaleOrders")]
    public virtual Geterminal FkGeterminal { get; set; }

    [ForeignKey("FkGevatregionId")]
    [InverseProperty("ArsaleOrders")]
    public virtual Gevatregion FkGevatregion { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArsaleOrderFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployee2Did")]
    [InverseProperty("ArsaleOrderFkHremployee2Ds")]
    public virtual Hremployee FkHremployee2D { get; set; }

    [ForeignKey("FkHremployee3Did")]
    [InverseProperty("ArsaleOrderFkHremployee3Ds")]
    public virtual Hremployee FkHremployee3D { get; set; }

    [ForeignKey("FkHremployeeManager2Did")]
    [InverseProperty("ArsaleOrderFkHremployeeManager2Ds")]
    public virtual Hremployee FkHremployeeManager2D { get; set; }

    [ForeignKey("FkHremployeeManager3Did")]
    [InverseProperty("ArsaleOrderFkHremployeeManager3Ds")]
    public virtual Hremployee FkHremployeeManager3D { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleOrders")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("ArsaleOrders")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("ArsaleOrders")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArsaleOrders")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("ArsaleOrders")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<IcshipmentSaleOrder> IcshipmentSaleOrders { get; set; } = new List<IcshipmentSaleOrder>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmbatchItemPlan> MmbatchItemPlans { get; set; } = new List<MmbatchItemPlan>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItems { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlans { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmchangeBominformation> MmchangeBominformations { get; set; } = new List<MmchangeBominformation>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmchangeDeliveryDateBatchProductItem> MmchangeDeliveryDateBatchProductItems { get; set; } = new List<MmchangeDeliveryDateBatchProductItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; } = new List<MminProgressStatisticDetail>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MminProgressStatistic> MminProgressStatistics { get; set; } = new List<MminProgressStatistic>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItems { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmoperationDetailPlanItemChild> MmoperationDetailPlanItemChildren { get; set; } = new List<MmoperationDetailPlanItemChild>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductionCostCalculationDetailCost> MmproductionCostCalculationDetailCosts { get; set; } = new List<MmproductionCostCalculationDetailCost>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductionCostOverall> MmproductionCostOveralls { get; set; } = new List<MmproductionCostOverall>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproductionNorm> MmproductionNorms { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmproposalItem> MmproposalItems { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<Mmproposal> Mmproposals { get; set; } = new List<Mmproposal>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlans { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<MmwoodPlan> MmwoodPlans { get; set; } = new List<MmwoodPlan>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<PmbuidingProposalItem> PmbuidingProposalItems { get; set; } = new List<PmbuidingProposalItem>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<PmbuidingProposal> PmbuidingProposals { get; set; } = new List<PmbuidingProposal>();

    [InverseProperty("FkArsaleOrder")]
    public virtual ICollection<PmbuildingPlan> PmbuildingPlans { get; set; } = new List<PmbuildingPlan>();
}
