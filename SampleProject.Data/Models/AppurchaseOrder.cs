using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseOrders")]
[Microsoft.EntityFrameworkCore.Index("AppurchaseOrderNo", "AppurchaseOrderDate", "FkBrbranchId", "FkApsupplierId", "AppurchaseOrderReference", "AppurchaseOrderType", Name = "Idx_APPurchaseOrders")]
public partial class AppurchaseOrder
{
    [Key]
    [Column("APPurchaseOrderID")]
    public int AppurchaseOrderId { get; set; }

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

    [Column("FK_GEVATRegionID")]
    public int? FkGevatregionId { get; set; }

    [Column("FK_ARSellerID")]
    public int? FkArsellerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("APPurchaseOrderStatus")]
    [StringLength(100)]
    public string AppurchaseOrderStatus { get; set; }

    [Column("APPurchaseOrderPaymentTerm")]
    [StringLength(50)]
    public string AppurchaseOrderPaymentTerm { get; set; }

    [Required]
    [Column("APPaymentMethodCombo")]
    [StringLength(50)]
    public string AppaymentMethodCombo { get; set; }

    [Required]
    [Column("APPurchaseOrderNo")]
    [StringLength(50)]
    public string AppurchaseOrderNo { get; set; }

    [Column("APPurchaseOrderName")]
    [StringLength(100)]
    public string AppurchaseOrderName { get; set; }

    [Column("APPurchaseOrderDesc")]
    [StringLength(512)]
    public string AppurchaseOrderDesc { get; set; }

    [Column("APPurchaseOrderComment")]
    [StringLength(512)]
    public string AppurchaseOrderComment { get; set; }

    [Column("APPurchaseOrderDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderDate { get; set; }

    [Column("APPurchaseOrderValidateDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderValidateDate { get; set; }

    [Column("APPurchaseOrderDeliveryDate", TypeName = "datetime")]
    public DateTime AppurchaseOrderDeliveryDate { get; set; }

    [Column("APPurchaseOrderPackingDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderPackingDate { get; set; }

    [Column("APPurchaseOrderDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderDiscountPerCent { get; set; }

    [Column("APPurchaseOrderDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderDiscountFix { get; set; }

    [Column("APPurchaseOrderReference")]
    [StringLength(150)]
    public string AppurchaseOrderReference { get; set; }

    [Column("APPurchaseOrderActiveCheck")]
    public bool? AppurchaseOrderActiveCheck { get; set; }

    [Column("APPurchaseOrderTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderTaxNumber { get; set; }

    [Column("APPurchaseOrderType")]
    [StringLength(50)]
    public string AppurchaseOrderType { get; set; }

    [Column("APPurchaseOrderTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderTaxPercent { get; set; }

    [Column("APPurchaseOrderTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderTaxAmount { get; set; }

    [Column("APPurchaseOrderSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderSubTotalCost { get; set; }

    [Column("APPurchaseOrderTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderTotalCost { get; set; }

    [Column("APPurchaseOrderDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderDepositBalance { get; set; }

    [Column("APPurchaseOrderBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderBalanceDue { get; set; }

    [Column("APPurchaseOrderMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode01Combo { get; set; }

    [Column("APPurchaseOrderMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode02Combo { get; set; }

    [Column("APPurchaseOrderMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode03Combo { get; set; }

    [Column("APPurchaseOrderMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode04Combo { get; set; }

    [Column("APPurchaseOrderMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode05Combo { get; set; }

    [Column("APPurchaseOrderMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode06Combo { get; set; }

    [Column("APPurchaseOrderMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode07Combo { get; set; }

    [Column("APPurchaseOrderMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode08Combo { get; set; }

    [Column("APPurchaseOrderMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode09Combo { get; set; }

    [Column("APPurchaseOrderMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode10Combo { get; set; }

    [Column("APPurchaseOrderMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode11Combo { get; set; }

    [Column("APPurchaseOrderMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderMatchCode12Combo { get; set; }

    [Column("APPurchaseOrderProject")]
    [StringLength(50)]
    public string AppurchaseOrderProject { get; set; }

    [Column("FK_APSupplierContactInvoiceID")]
    public int? FkApsupplierContactInvoiceId { get; set; }

    [Column("APPurchaseOrderInvoiceContactName")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceContactName { get; set; }

    [Column("APPurchaseOrderInvoiceContactFirstName")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceContactFirstName { get; set; }

    [Column("APPurchaseOrderInvoiceContactLastName")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceContactLastName { get; set; }

    [Column("APPurchaseOrderInvoiceContactTitle")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceContactTitle { get; set; }

    [Column("APPurchaseOrderInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string AppurchaseOrderInvoiceContactHeaderLetter { get; set; }

    [Column("APPurchaseOrderInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string AppurchaseOrderInvoiceContactHeaderMessage { get; set; }

    [Column("APPurchaseOrderInvoiceContactEmail1")]
    [StringLength(100)]
    public string AppurchaseOrderInvoiceContactEmail1 { get; set; }

    [Column("APPurchaseOrderInvoiceContactEmail2")]
    [StringLength(100)]
    public string AppurchaseOrderInvoiceContactEmail2 { get; set; }

    [Column("APPurchaseOrderInvoiceContactWebsite")]
    [StringLength(100)]
    public string AppurchaseOrderInvoiceContactWebsite { get; set; }

    [Column("APPurchaseOrderInvoiceContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderInvoiceContactPhonePrivat { get; set; }

    [Column("APPurchaseOrderInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderInvoiceContactPhone { get; set; }

    [Column("APPurchaseOrderInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderInvoiceContactPhone1 { get; set; }

    [Column("APPurchaseOrderInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderInvoiceContactCellPhone { get; set; }

    [Column("APPurchaseOrderInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderInvoiceContactCellPhone1 { get; set; }

    [Column("APPurchaseOrderInvoiceContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderInvoiceContactCellPhonePrivat { get; set; }

    [Column("APPurchaseOrderInvoiceContactFax")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceContactFax { get; set; }

    [Column("APPurchaseOrderInvoiceContactType")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceContactType { get; set; }

    [Column("APPurchaseOrderInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string AppurchaseOrderInvoiceContactInformation { get; set; }

    [Column("APPurchaseOrderInvoiceContactDepartment")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceContactDepartment { get; set; }

    [Column("APPurchaseOrderInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string AppurchaseOrderInvoiceContactRoom { get; set; }

    [Column("APPurchaseOrderInvoiceAddressLine1")]
    [StringLength(250)]
    public string AppurchaseOrderInvoiceAddressLine1 { get; set; }

    [Column("APPurchaseOrderInvoiceAddressLine2")]
    [StringLength(250)]
    public string AppurchaseOrderInvoiceAddressLine2 { get; set; }

    [Column("APPurchaseOrderInvoiceAddressLine3")]
    [StringLength(200)]
    public string AppurchaseOrderInvoiceAddressLine3 { get; set; }

    [Column("APPurchaseOrderInvoiceAddressStreet")]
    [StringLength(200)]
    public string AppurchaseOrderInvoiceAddressStreet { get; set; }

    [Column("APPurchaseOrderInvoiceAddressCity")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceAddressCity { get; set; }

    [Column("APPurchaseOrderInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceAddressPostalCode { get; set; }

    [Column("APPurchaseOrderInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceAddressStateProvince { get; set; }

    [Column("APPurchaseOrderInvoiceAddressZipCode")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceAddressZipCode { get; set; }

    [Column("APPurchaseOrderInvoiceAddressCountry")]
    [StringLength(50)]
    public string AppurchaseOrderInvoiceAddressCountry { get; set; }

    [Column("FK_APSupplierContactPOID")]
    public int? FkApsupplierContactPoid { get; set; }

    [Column("APPurchaseOrderPOContactName")]
    [StringLength(50)]
    public string AppurchaseOrderPocontactName { get; set; }

    [Column("APPurchaseOrderPOContactBirthday", TypeName = "datetime")]
    public DateTime? AppurchaseOrderPocontactBirthday { get; set; }

    [Column("APPurchaseOrderPOContactFirstName")]
    [StringLength(50)]
    public string AppurchaseOrderPocontactFirstName { get; set; }

    [Column("APPurchaseOrderPOContactLastName")]
    [StringLength(50)]
    public string AppurchaseOrderPocontactLastName { get; set; }

    [Column("APPurchaseOrderPOContactTitle")]
    [StringLength(50)]
    public string AppurchaseOrderPocontactTitle { get; set; }

    [Column("APPurchaseOrderPOContactHeaderLetter")]
    [StringLength(100)]
    public string AppurchaseOrderPocontactHeaderLetter { get; set; }

    [Column("APPurchaseOrderPOContactHeaderMessage")]
    [StringLength(255)]
    public string AppurchaseOrderPocontactHeaderMessage { get; set; }

    [Column("APPurchaseOrderPOContactEmail1")]
    [StringLength(100)]
    public string AppurchaseOrderPocontactEmail1 { get; set; }

    [Column("APPurchaseOrderPOContactEmail2")]
    [StringLength(100)]
    public string AppurchaseOrderPocontactEmail2 { get; set; }

    [Column("APPurchaseOrderPOContactWebsite")]
    [StringLength(100)]
    public string AppurchaseOrderPocontactWebsite { get; set; }

    [Column("APPurchaseOrderPOContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderPocontactPhonePrivat { get; set; }

    [Column("APPurchaseOrderPOContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderPocontactPhone { get; set; }

    [Column("APPurchaseOrderPOContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderPocontactPhone1 { get; set; }

    [Column("APPurchaseOrderPOContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderPocontactCellPhone { get; set; }

    [Column("APPurchaseOrderPOContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderPocontactCellPhone1 { get; set; }

    [Column("APPurchaseOrderPOContactFax")]
    [StringLength(50)]
    public string AppurchaseOrderPocontactFax { get; set; }

    [Column("APPurchaseOrderPOContactType")]
    [StringLength(50)]
    public string AppurchaseOrderPocontactType { get; set; }

    [Column("APPurchaseOrderPOContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string AppurchaseOrderPocontactInformation { get; set; }

    [Column("APPurchaseOrderPOContactDepartment")]
    [StringLength(50)]
    public string AppurchaseOrderPocontactDepartment { get; set; }

    [Column("APPurchaseOrderPOContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string AppurchaseOrderPocontactRoom { get; set; }

    [Column("APPurchaseOrderPOAddressLine1")]
    [StringLength(250)]
    public string AppurchaseOrderPoaddressLine1 { get; set; }

    [Column("APPurchaseOrderPOAddressLine2")]
    [StringLength(250)]
    public string AppurchaseOrderPoaddressLine2 { get; set; }

    [Column("APPurchaseOrderPOAddressLine3")]
    [StringLength(250)]
    public string AppurchaseOrderPoaddressLine3 { get; set; }

    [Column("APPurchaseOrderPOAddressStreet")]
    [StringLength(200)]
    public string AppurchaseOrderPoaddressStreet { get; set; }

    [Column("APPurchaseOrderPOAddressCity")]
    [StringLength(50)]
    public string AppurchaseOrderPoaddressCity { get; set; }

    [Column("APPurchaseOrderPOAddressPostalCode")]
    [StringLength(50)]
    public string AppurchaseOrderPoaddressPostalCode { get; set; }

    [Column("APPurchaseOrderPOAddressStateProvince")]
    [StringLength(50)]
    public string AppurchaseOrderPoaddressStateProvince { get; set; }

    [Column("APPurchaseOrderPOAddressZipCode")]
    [StringLength(50)]
    public string AppurchaseOrderPoaddressZipCode { get; set; }

    [Column("APPurchaseOrderPOAddressCountry")]
    [StringLength(50)]
    public string AppurchaseOrderPoaddressCountry { get; set; }

    [Column("FK_APSupplierContactDeliveryID")]
    public int? FkApsupplierContactDeliveryId { get; set; }

    [Column("APPurchaseOrderDeliveryContactName")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryContactName { get; set; }

    [Column("APPurchaseOrderDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? AppurchaseOrderDeliveryContactBirthday { get; set; }

    [Column("APPurchaseOrderDeliveryContactFirstName")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryContactFirstName { get; set; }

    [Column("APPurchaseOrderDeliveryContactLastName")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryContactLastName { get; set; }

    [Column("APPurchaseOrderDeliveryContactTitle")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryContactTitle { get; set; }

    [Column("APPurchaseOrderDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string AppurchaseOrderDeliveryContactHeaderLetter { get; set; }

    [Column("APPurchaseOrderDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string AppurchaseOrderDeliveryContactHeaderMessage { get; set; }

    [Column("APPurchaseOrderDeliveryContactEmail1")]
    [StringLength(100)]
    public string AppurchaseOrderDeliveryContactEmail1 { get; set; }

    [Column("APPurchaseOrderDeliveryContactEmail2")]
    [StringLength(100)]
    public string AppurchaseOrderDeliveryContactEmail2 { get; set; }

    [Column("APPurchaseOrderDeliveryContactWebsite")]
    [StringLength(100)]
    public string AppurchaseOrderDeliveryContactWebsite { get; set; }

    [Column("APPurchaseOrderDeliveryContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderDeliveryContactPhonePrivat { get; set; }

    [Column("APPurchaseOrderDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderDeliveryContactPhone { get; set; }

    [Column("APPurchaseOrderDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderDeliveryContactPhone1 { get; set; }

    [Column("APPurchaseOrderDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderDeliveryContactCellPhone { get; set; }

    [Column("APPurchaseOrderDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderDeliveryContactCellPhone1 { get; set; }

    [Column("APPurchaseOrderDeliveryContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppurchaseOrderDeliveryContactCellPhonePrivat { get; set; }

    [Column("APPurchaseOrderDeliveryContactFax")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryContactFax { get; set; }

    [Column("APPurchaseOrderDeliveryContactType")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryContactType { get; set; }

    [Column("APPurchaseOrderDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string AppurchaseOrderDeliveryContactInformation { get; set; }

    [Column("APPurchaseOrderDeliveryContactDepartment")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryContactDepartment { get; set; }

    [Column("APPurchaseOrderDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string AppurchaseOrderDeliveryContactRoom { get; set; }

    [Column("APPurchaseOrderDeliveryContactImage")]
    public byte[] AppurchaseOrderDeliveryContactImage { get; set; }

    [Column("APPurchaseOrderDeliveryAddressName")]
    [StringLength(100)]
    public string AppurchaseOrderDeliveryAddressName { get; set; }

    [Column("APPurchaseOrderDeliveryAddressLine1")]
    [StringLength(250)]
    public string AppurchaseOrderDeliveryAddressLine1 { get; set; }

    [Column("APPurchaseOrderDeliveryAddressLine2")]
    [StringLength(250)]
    public string AppurchaseOrderDeliveryAddressLine2 { get; set; }

    [Column("APPurchaseOrderDeliveryAddressLine3")]
    [StringLength(250)]
    public string AppurchaseOrderDeliveryAddressLine3 { get; set; }

    [Column("APPurchaseOrderDeliveryAddressStreet")]
    [StringLength(200)]
    public string AppurchaseOrderDeliveryAddressStreet { get; set; }

    [Column("APPurchaseOrderDeliveryAddressHouseNumber")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryAddressHouseNumber { get; set; }

    [Column("APPurchaseOrderDeliveryAddressCity")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryAddressCity { get; set; }

    [Column("APPurchaseOrderDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryAddressPostalCode { get; set; }

    [Column("APPurchaseOrderDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryAddressStateProvince { get; set; }

    [Column("APPurchaseOrderDeliveryAddressZipCode")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryAddressZipCode { get; set; }

    [Column("APPurchaseOrderDeliveryAddressCountry")]
    [StringLength(50)]
    public string AppurchaseOrderDeliveryAddressCountry { get; set; }

    [Column("APPurchaseOrderShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderShippingFees { get; set; }

    [Column("APPurchaseOrderShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderShippingExtraFees { get; set; }

    [Column("APPurchaseOrderShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderShippingInsuranceFees { get; set; }

    [Column("APPurchaseOrderShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderShippingPackagingFees { get; set; }

    [Column("APPurchaseOrderShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderShippingReservedFees1 { get; set; }

    [Column("APPurchaseOrderShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderShippingReservedFees2 { get; set; }

    [Column("APPurchaseOrderShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderShippingReservedFees3 { get; set; }

    [Column("APPurchaseOrderShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderShippingReservedFees4 { get; set; }

    [Column("APPurchaseOrderShippingMethodDesc")]
    [StringLength(255)]
    public string AppurchaseOrderShippingMethodDesc { get; set; }

    [Column("APPurchaseOrderShippingMethodName")]
    [StringLength(50)]
    public string AppurchaseOrderShippingMethodName { get; set; }

    [Column("APPurchaseOrderExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderExchangeRate { get; set; }

    [Column("APPurchaseOrderVolume", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderVolume { get; set; }

    [Required]
    [Column("APPurchaseOrderReceiptTypeCombo")]
    [StringLength(50)]
    public string AppurchaseOrderReceiptTypeCombo { get; set; }

    [Column("APPurchaseOrderPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderPaidAmount { get; set; }

    [Column("APPurchaseOrderInvoiceInAmount", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderInvoiceInAmount { get; set; }

    [Column("APPurchaseOrderSupplierNo")]
    [StringLength(200)]
    public string AppurchaseOrderSupplierNo { get; set; }

    [Column("APPurchaseOrderSupplierNoDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderSupplierNoDate { get; set; }

    [Column("APPurchaseOrderContractNo")]
    [StringLength(50)]
    public string AppurchaseOrderContractNo { get; set; }

    [Column("APPurchaseOrderContractDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderContractDate { get; set; }

    [Required]
    [Column("APPurchaseOrderChannel")]
    [StringLength(50)]
    public string AppurchaseOrderChannel { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("APPurchaseOrderProductPrice", TypeName = "decimal(18, 5)")]
    public decimal? AppurchaseOrderProductPrice { get; set; }

    [Column("APPurchaseOrderProposedEmployeeID")]
    public int? AppurchaseOrderProposedEmployeeId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("APPurchaseOrderPONo")]
    [StringLength(50)]
    public string AppurchaseOrderPono { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_GEPaymentTermID")]
    public int FkGepaymentTermId { get; set; }

    [Column("APPurchaseOrderPaymentTermRequest")]
    [StringLength(50)]
    public string AppurchaseOrderPaymentTermRequest { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApobjectType { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("APAssObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApassObjectType { get; set; }

    [Column("APPurchaseOrderPriceType")]
    [StringLength(50)]
    public string AppurchaseOrderPriceType { get; set; }

    [Column("FK_APPurchasingStaffID")]
    public int? FkAppurchasingStaffId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_APPurchaseContractID")]
    public int? FkAppurchaseContractId { get; set; }

    [Column("FK_GETerminalID")]
    public int? FkGeterminalId { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("APPurchaseOrderApproveStatus")]
    [StringLength(50)]
    public string AppurchaseOrderApproveStatus { get; set; }

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AcclearingDebtInvoiceInItem> AcclearingDebtInvoiceInItems { get; set; } = new List<AcclearingDebtInvoiceInItem>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<ApallocationCostItem> ApallocationCostItems { get; set; } = new List<ApallocationCostItem>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<ApallocationCost> ApallocationCosts { get; set; } = new List<ApallocationCost>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<ApclearingDetail> ApclearingDetails { get; set; } = new List<ApclearingDetail>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<ApfeePaymentPurchaseOrder> ApfeePaymentPurchaseOrders { get; set; } = new List<ApfeePaymentPurchaseOrder>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppaymentProposalItem> AppaymentProposalItems { get; set; } = new List<AppaymentProposalItem>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppaymentProposalPayment> AppaymentProposalPayments { get; set; } = new List<AppaymentProposalPayment>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; } = new List<AppaymentVoucherInvoice>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppopackageItem> AppopackageItems { get; set; } = new List<AppopackageItem>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppopaymentTimeInvoiceInDetail> AppopaymentTimeInvoiceInDetails { get; set; } = new List<AppopaymentTimeInvoiceInDetail>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppurchaseOrderHistory> AppurchaseOrderHistories { get; set; } = new List<AppurchaseOrderHistory>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppurchaseOrderItemDelivery> AppurchaseOrderItemDeliveries { get; set; } = new List<AppurchaseOrderItemDelivery>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppurchaseOrderItemOutSourcing> AppurchaseOrderItemOutSourcings { get; set; } = new List<AppurchaseOrderItemOutSourcing>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<AppurchaseOrderPaymentTime> AppurchaseOrderPaymentTimes { get; set; } = new List<AppurchaseOrderPaymentTime>();

    [ForeignKey("AppurchaseOrderProposedEmployeeId")]
    [InverseProperty("AppurchaseOrderAppurchaseOrderProposedEmployees")]
    public virtual Hremployee AppurchaseOrderProposedEmployee { get; set; }

    [ForeignKey("FkAppurchaseContractId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual AppurchaseContract FkAppurchaseContract { get; set; }

    [ForeignKey("FkAppurchasingStaffId")]
    [InverseProperty("AppurchaseOrderFkAppurchasingStaffs")]
    public virtual Hremployee FkAppurchasingStaff { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsellerId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Arseller FkArseller { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkGeterminalId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Geterminal FkGeterminal { get; set; }

    [ForeignKey("FkGevatregionId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Gevatregion FkGevatregion { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AppurchaseOrderFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("AppurchaseOrders")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AppurchaseOrders")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkAppurchaseOrder")]
    public virtual ICollection<Ictransfer> Ictransfers { get; set; } = new List<Ictransfer>();
}
