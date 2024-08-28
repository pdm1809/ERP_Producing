using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceipts")]
[Microsoft.EntityFrameworkCore.Index("IcreceiptNo", "IcreceiptDate", "FkBrbranchId", "FkIcstockId", "IcreceiptReference", "IcreceiptTypeCombo", Name = "Idx_ICReceipts")]
public partial class Icreceipt
{
    [Key]
    [Column("ICReceiptID")]
    public int IcreceiptId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_GELanguageID")]
    public int FkGelanguageId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_BRTransferredBranchID")]
    public int? FkBrtransferredBranchId { get; set; }

    [Required]
    [Column("ICReceiptNo")]
    [StringLength(50)]
    public string IcreceiptNo { get; set; }

    [Column("ICReceiptName")]
    [StringLength(100)]
    public string IcreceiptName { get; set; }

    [Column("ICReceiptDesc")]
    [StringLength(512)]
    public string IcreceiptDesc { get; set; }

    [Column("ICReceiptComment")]
    [StringLength(512)]
    public string IcreceiptComment { get; set; }

    [Required]
    [Column("ICReceiptPackNo")]
    [StringLength(50)]
    public string IcreceiptPackNo { get; set; }

    [Column("ICReceiptDate", TypeName = "datetime")]
    public DateTime? IcreceiptDate { get; set; }

    [Column("ICReceiptValidateDate", TypeName = "datetime")]
    public DateTime? IcreceiptValidateDate { get; set; }

    [Column("ICReceiptDeliveryDate", TypeName = "datetime")]
    public DateTime? IcreceiptDeliveryDate { get; set; }

    [Column("ICReceiptDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptDiscountPerCent { get; set; }

    [Column("ICReceiptDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptDiscountFix { get; set; }

    [Column("ICReceiptReference")]
    [StringLength(50)]
    public string IcreceiptReference { get; set; }

    [Column("ICReceiptActiveCheck")]
    public bool? IcreceiptActiveCheck { get; set; }

    [Column("ICReceiptTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptTaxNumber { get; set; }

    [Column("ICReceiptTypeCombo")]
    [StringLength(50)]
    public string IcreceiptTypeCombo { get; set; }

    [Column("ICReceiptStatus")]
    [StringLength(100)]
    public string IcreceiptStatus { get; set; }

    [Column("ICReceiptTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptTaxPercent { get; set; }

    [Column("ICReceiptTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptTaxAmount { get; set; }

    [Column("ICReceiptSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptSubTotalCost { get; set; }

    [Column("ICReceiptTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptTotalCost { get; set; }

    [Column("ICReceiptMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode01Combo { get; set; }

    [Column("ICReceiptMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode02Combo { get; set; }

    [Column("ICReceiptMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode03Combo { get; set; }

    [Column("ICReceiptMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode04Combo { get; set; }

    [Column("ICReceiptMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode05Combo { get; set; }

    [Column("ICReceiptMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode06Combo { get; set; }

    [Column("ICReceiptMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode07Combo { get; set; }

    [Column("ICReceiptMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode08Combo { get; set; }

    [Column("ICReceiptMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode09Combo { get; set; }

    [Column("ICReceiptMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode10Combo { get; set; }

    [Column("ICReceiptMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode11Combo { get; set; }

    [Column("ICReceiptMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptMatchCode12Combo { get; set; }

    [Column("ICReceiptProject")]
    [StringLength(50)]
    public string IcreceiptProject { get; set; }

    [Column("FK_APSupplierContactInvoiceID")]
    public int? FkApsupplierContactInvoiceId { get; set; }

    [Column("ICReceiptInvoiceContactName")]
    [StringLength(50)]
    public string IcreceiptInvoiceContactName { get; set; }

    [Column("ICReceiptInvoiceContactFirstName")]
    [StringLength(50)]
    public string IcreceiptInvoiceContactFirstName { get; set; }

    [Column("ICReceiptInvoiceContactLastName")]
    [StringLength(50)]
    public string IcreceiptInvoiceContactLastName { get; set; }

    [Column("ICReceiptInvoiceContactTitle")]
    [StringLength(50)]
    public string IcreceiptInvoiceContactTitle { get; set; }

    [Column("ICReceiptInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string IcreceiptInvoiceContactHeaderLetter { get; set; }

    [Column("ICReceiptInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string IcreceiptInvoiceContactHeaderMessage { get; set; }

    [Column("ICReceiptInvoiceContactEmail1")]
    [StringLength(100)]
    public string IcreceiptInvoiceContactEmail1 { get; set; }

    [Column("ICReceiptInvoiceContactEmail2")]
    [StringLength(100)]
    public string IcreceiptInvoiceContactEmail2 { get; set; }

    [Column("ICReceiptInvoiceContactWebsite")]
    [StringLength(100)]
    public string IcreceiptInvoiceContactWebsite { get; set; }

    [Column("ICReceiptInvoiceContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptInvoiceContactPhonePrivate { get; set; }

    [Column("ICReceiptInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptInvoiceContactPhone { get; set; }

    [Column("ICReceiptInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptInvoiceContactPhone1 { get; set; }

    [Column("ICReceiptInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptInvoiceContactCellPhone { get; set; }

    [Column("ICReceiptInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptInvoiceContactCellPhone1 { get; set; }

    [Column("ICReceiptInvoiceContactFax")]
    [StringLength(50)]
    public string IcreceiptInvoiceContactFax { get; set; }

    [Column("ICReceiptInvoiceContactType")]
    [StringLength(50)]
    public string IcreceiptInvoiceContactType { get; set; }

    [Column("ICReceiptInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcreceiptInvoiceContactInformation { get; set; }

    [Column("ICReceiptInvoiceContactDepartment")]
    [StringLength(50)]
    public string IcreceiptInvoiceContactDepartment { get; set; }

    [Column("ICReceiptInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcreceiptInvoiceContactRoom { get; set; }

    [Column("ICReceiptInvoiceAddressLine1")]
    [StringLength(250)]
    public string IcreceiptInvoiceAddressLine1 { get; set; }

    [Column("ICReceiptInvoiceAddressLine2")]
    [StringLength(250)]
    public string IcreceiptInvoiceAddressLine2 { get; set; }

    [Column("ICReceiptInvoiceAddressLine3")]
    [StringLength(250)]
    public string IcreceiptInvoiceAddressLine3 { get; set; }

    [Column("ICReceiptInvoiceAddressStreet")]
    [StringLength(200)]
    public string IcreceiptInvoiceAddressStreet { get; set; }

    [Column("ICReceiptInvoiceAddressCity")]
    [StringLength(50)]
    public string IcreceiptInvoiceAddressCity { get; set; }

    [Column("ICReceiptInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string IcreceiptInvoiceAddressPostalCode { get; set; }

    [Column("ICReceiptInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string IcreceiptInvoiceAddressStateProvince { get; set; }

    [Column("ICReceiptInvoiceAddressZipCode")]
    [StringLength(50)]
    public string IcreceiptInvoiceAddressZipCode { get; set; }

    [Column("ICReceiptInvoiceAddressCountry")]
    [StringLength(50)]
    public string IcreceiptInvoiceAddressCountry { get; set; }

    [Column("FK_APSupplierContactPOID")]
    public int? FkApsupplierContactPoid { get; set; }

    [Column("ICReceiptPOContactName")]
    [StringLength(50)]
    public string IcreceiptPocontactName { get; set; }

    [Column("ICReceiptPOContactBirthday", TypeName = "datetime")]
    public DateTime? IcreceiptPocontactBirthday { get; set; }

    [Column("ICReceiptPOContactFirstName")]
    [StringLength(50)]
    public string IcreceiptPocontactFirstName { get; set; }

    [Column("ICReceiptPOContactLastName")]
    [StringLength(50)]
    public string IcreceiptPocontactLastName { get; set; }

    [Column("ICReceiptPOContactTitle")]
    [StringLength(50)]
    public string IcreceiptPocontactTitle { get; set; }

    [Column("ICReceiptPOContactHeaderLetter")]
    [StringLength(100)]
    public string IcreceiptPocontactHeaderLetter { get; set; }

    [Column("ICReceiptPOContactHeaderMessage")]
    [StringLength(255)]
    public string IcreceiptPocontactHeaderMessage { get; set; }

    [Column("ICReceiptPOContactEmail1")]
    [StringLength(100)]
    public string IcreceiptPocontactEmail1 { get; set; }

    [Column("ICReceiptPOContactEmail2")]
    [StringLength(100)]
    public string IcreceiptPocontactEmail2 { get; set; }

    [Column("ICReceiptPOContactWebsite")]
    [StringLength(100)]
    public string IcreceiptPocontactWebsite { get; set; }

    [Column("ICReceiptPOContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptPocontactPhonePrivate { get; set; }

    [Column("ICReceiptPOContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptPocontactPhone { get; set; }

    [Column("ICReceiptPOContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptPocontactPhone1 { get; set; }

    [Column("ICReceiptPOContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptPocontactCellPhone { get; set; }

    [Column("ICReceiptPOContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptPocontactCellPhone1 { get; set; }

    [Column("ICReceiptPOContactFax")]
    [StringLength(50)]
    public string IcreceiptPocontactFax { get; set; }

    [Column("ICReceiptPOContactType")]
    [StringLength(50)]
    public string IcreceiptPocontactType { get; set; }

    [Column("ICReceiptPOContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcreceiptPocontactInformation { get; set; }

    [Column("ICReceiptPOContactDepartment")]
    [StringLength(50)]
    public string IcreceiptPocontactDepartment { get; set; }

    [Column("ICReceiptPOContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcreceiptPocontactRoom { get; set; }

    [Column("ICReceiptPOAddressLine1")]
    [StringLength(250)]
    public string IcreceiptPoaddressLine1 { get; set; }

    [Column("ICReceiptPOAddressLine2")]
    [StringLength(250)]
    public string IcreceiptPoaddressLine2 { get; set; }

    [Column("ICReceiptPOAddressLine3")]
    [StringLength(250)]
    public string IcreceiptPoaddressLine3 { get; set; }

    [Column("ICReceiptPOAddressStreet")]
    [StringLength(200)]
    public string IcreceiptPoaddressStreet { get; set; }

    [Column("ICReceiptPOAddressCity")]
    [StringLength(50)]
    public string IcreceiptPoaddressCity { get; set; }

    [Column("ICReceiptPOAddressPostalCode")]
    [StringLength(50)]
    public string IcreceiptPoaddressPostalCode { get; set; }

    [Column("ICReceiptPOAddressStateProvince")]
    [StringLength(50)]
    public string IcreceiptPoaddressStateProvince { get; set; }

    [Column("ICReceiptPOAddressZipCode")]
    [StringLength(50)]
    public string IcreceiptPoaddressZipCode { get; set; }

    [Column("ICReceiptPOAddressCountry")]
    [StringLength(50)]
    public string IcreceiptPoaddressCountry { get; set; }

    [Column("ICReceiptDeliveryContactName")]
    [StringLength(100)]
    public string IcreceiptDeliveryContactName { get; set; }

    [Column("ICReceiptDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? IcreceiptDeliveryContactBirthday { get; set; }

    [Column("ICReceiptDeliveryContactFirstName")]
    [StringLength(50)]
    public string IcreceiptDeliveryContactFirstName { get; set; }

    [Column("ICReceiptDeliveryContactLastName")]
    [StringLength(50)]
    public string IcreceiptDeliveryContactLastName { get; set; }

    [Column("ICReceiptDeliveryContactTitle")]
    [StringLength(50)]
    public string IcreceiptDeliveryContactTitle { get; set; }

    [Column("ICReceiptDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string IcreceiptDeliveryContactHeaderLetter { get; set; }

    [Column("ICReceiptDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string IcreceiptDeliveryContactHeaderMessage { get; set; }

    [Column("ICReceiptDeliveryContactEmail1")]
    [StringLength(100)]
    public string IcreceiptDeliveryContactEmail1 { get; set; }

    [Column("ICReceiptDeliveryContactEmail2")]
    [StringLength(100)]
    public string IcreceiptDeliveryContactEmail2 { get; set; }

    [Column("ICReceiptDeliveryContactWebsite")]
    [StringLength(100)]
    public string IcreceiptDeliveryContactWebsite { get; set; }

    [Column("ICReceiptDeliveryContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptDeliveryContactPhonePrivate { get; set; }

    [Column("ICReceiptDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptDeliveryContactPhone { get; set; }

    [Column("ICReceiptDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptDeliveryContactPhone1 { get; set; }

    [Column("ICReceiptDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptDeliveryContactCellPhone { get; set; }

    [Column("ICReceiptDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptDeliveryContactCellPhone1 { get; set; }

    [Column("ICReceiptDeliveryContactFax")]
    [StringLength(50)]
    public string IcreceiptDeliveryContactFax { get; set; }

    [Column("ICReceiptDeliveryContactType")]
    [StringLength(50)]
    public string IcreceiptDeliveryContactType { get; set; }

    [Column("ICReceiptDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcreceiptDeliveryContactInformation { get; set; }

    [Column("ICReceiptDeliveryContactDepartment")]
    [StringLength(50)]
    public string IcreceiptDeliveryContactDepartment { get; set; }

    [Column("ICReceiptDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcreceiptDeliveryContactRoom { get; set; }

    [Column("ICReceiptDeliveryAddressLine1")]
    [StringLength(250)]
    public string IcreceiptDeliveryAddressLine1 { get; set; }

    [Column("ICReceiptDeliveryAddressLine2")]
    [StringLength(250)]
    public string IcreceiptDeliveryAddressLine2 { get; set; }

    [Column("ICReceiptDeliveryAddressLine3")]
    [StringLength(250)]
    public string IcreceiptDeliveryAddressLine3 { get; set; }

    [Column("ICReceiptDeliveryAddressStreet")]
    [StringLength(200)]
    public string IcreceiptDeliveryAddressStreet { get; set; }

    [Column("ICReceiptDeliveryAddressCity")]
    [StringLength(50)]
    public string IcreceiptDeliveryAddressCity { get; set; }

    [Column("ICReceiptDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string IcreceiptDeliveryAddressPostalCode { get; set; }

    [Column("ICReceiptDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string IcreceiptDeliveryAddressStateProvince { get; set; }

    [Column("ICReceiptDeliveryAddressZipCode")]
    [StringLength(50)]
    public string IcreceiptDeliveryAddressZipCode { get; set; }

    [Column("ICReceiptDeliveryAddressCountry")]
    [StringLength(50)]
    public string IcreceiptDeliveryAddressCountry { get; set; }

    [Column("ICReceiptShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptShippingFees { get; set; }

    [Column("ICReceiptShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptShippingExtraFees { get; set; }

    [Column("ICReceiptShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptShippingInsuranceFees { get; set; }

    [Column("ICReceiptShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptShippingPackagingFees { get; set; }

    [Column("ICReceiptShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptShippingReservedFees1 { get; set; }

    [Column("ICReceiptShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptShippingReservedFees2 { get; set; }

    [Column("ICReceiptShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptShippingReservedFees3 { get; set; }

    [Column("ICReceiptShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptShippingReservedFees4 { get; set; }

    [Column("ICReceiptShippingMethodDesc")]
    [StringLength(255)]
    public string IcreceiptShippingMethodDesc { get; set; }

    [Column("ICReceiptShippingMethodName")]
    [StringLength(50)]
    public string IcreceiptShippingMethodName { get; set; }

    [Column("ICReceiptInvoiceInNo")]
    [StringLength(50)]
    public string IcreceiptInvoiceInNo { get; set; }

    [Column("ICReceiptInvoiceInDate", TypeName = "datetime")]
    public DateTime? IcreceiptInvoiceInDate { get; set; }

    [Column("ICReceiptExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ICReceiptTransferredDate", TypeName = "datetime")]
    public DateTime? IcreceiptTransferredDate { get; set; }

    [Column("ICObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcobjectType { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("ICReceiptTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptTotalQty { get; set; }

    [Column("ICReceiptTotalWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptTotalWoodQty { get; set; }

    [Column("ICReceiptContainerNo")]
    [StringLength(50)]
    public string IcreceiptContainerNo { get; set; }

    [Column("ICReceiptReceiptType")]
    [StringLength(50)]
    public string IcreceiptReceiptType { get; set; }

    [Column("ICReceiptCreateFrom")]
    [StringLength(100)]
    public string IcreceiptCreateFrom { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICInputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string IcinputVatinvoiceNoCombo { get; set; }

    [Column("ICInputVATDocumentType")]
    [StringLength(1000)]
    public string IcinputVatdocumentType { get; set; }

    [Column("ICReceiptFormNo")]
    [StringLength(50)]
    public string IcreceiptFormNo { get; set; }

    [Column("ICReceiptSymbol")]
    [StringLength(50)]
    public string IcreceiptSymbol { get; set; }

    [Column("ICReceiptVoucherNo")]
    [StringLength(50)]
    public string IcreceiptVoucherNo { get; set; }

    [Column("ICReceiptObjectTaxNumber")]
    [StringLength(50)]
    public string IcreceiptObjectTaxNumber { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("ICReceiptAcceptanceType")]
    [StringLength(100)]
    public string IcreceiptAcceptanceType { get; set; }

    [Column("ICReceiptPONo")]
    [StringLength(50)]
    public string IcreceiptPono { get; set; }

    [Column("ICReceiptHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptHeight { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ICReceiptSerialPrefix")]
    [StringLength(50)]
    public string IcreceiptSerialPrefix { get; set; }

    [Column("FK_MMBatchProductTransferID")]
    public int? FkMmbatchProductTransferId { get; set; }

    [Column("FK_ICProductTransferID")]
    public int? FkIcproductTransferId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("ICAssObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcassObjectType { get; set; }

    [Column("FK_ICImportAndExportReasonID")]
    public int FkIcimportAndExportReasonId { get; set; }

    [Column("ICReceiptSupplerTaxNumber")]
    [StringLength(50)]
    public string IcreceiptSupplerTaxNumber { get; set; }

    [Column("ICReceiptSupplierAddress")]
    [StringLength(200)]
    public string IcreceiptSupplierAddress { get; set; }

    [Column("ICReceiptSemiProductType")]
    [StringLength(255)]
    public string IcreceiptSemiProductType { get; set; }

    [Column("ICReceiptPaymentTermDate", TypeName = "datetime")]
    public DateTime? IcreceiptPaymentTermDate { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ICReceiptPostedStatus")]
    [StringLength(64)]
    public string IcreceiptPostedStatus { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("FK_APPurchaseContractID")]
    public int? FkAppurchaseContractId { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("ICReceiptVATFormNo")]
    [StringLength(50)]
    public string IcreceiptVatformNo { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMMachineUnitID")]
    public int? FkMmmachineUnitId { get; set; }

    [Column("ICReceiptPurposeType")]
    [StringLength(100)]
    public string IcreceiptPurposeType { get; set; }

    [Column("FK_GETerminalID")]
    public int? FkGeterminalId { get; set; }

    [Column("ACDocumentAllocationCriteria")]
    [StringLength(50)]
    public string AcdocumentAllocationCriteria { get; set; }

    [Column("ICReceiptProportion", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptProportion { get; set; }

    [Column("FK_HRDeliveryEmployeeID")]
    public int? FkHrdeliveryEmployeeId { get; set; }

    [Column("ICReceiptSaleContract")]
    [StringLength(100)]
    public string IcreceiptSaleContract { get; set; }

    [Column("ICReceiptProposedEmployeeID")]
    public int? IcreceiptProposedEmployeeId { get; set; }

    [Column("MMUpdatePositionItemPositionName")]
    [StringLength(500)]
    public string MmupdatePositionItemPositionName { get; set; }

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<ApallocationCostItem> ApallocationCostItems { get; set; } = new List<ApallocationCostItem>();

    [InverseProperty("FkIcinvoiceInternalReceipt")]
    public virtual ICollection<ApfeePaymentInvoiceInternalReceipt> ApfeePaymentInvoiceInternalReceipts { get; set; } = new List<ApfeePaymentInvoiceInternalReceipt>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<ApfeePaymentReceipt> ApfeePaymentReceipts { get; set; } = new List<ApfeePaymentReceipt>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<AppaymentProposalItem> AppaymentProposalItems { get; set; } = new List<AppaymentProposalItem>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<AppaymentProposalPayment> AppaymentProposalPayments { get; set; } = new List<AppaymentProposalPayment>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<AppaymentVoucherInvoice> AppaymentVoucherInvoices { get; set; } = new List<AppaymentVoucherInvoice>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<ArpaymentProposalItem> ArpaymentProposalItems { get; set; } = new List<ArpaymentProposalItem>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("Fareceipt")]
    public virtual ICollection<FapurchaseOrderReceipt> FapurchaseOrderReceipts { get; set; } = new List<FapurchaseOrderReceipt>();

    [InverseProperty("Fareceipt")]
    public virtual ICollection<FareceiptContact> FareceiptContacts { get; set; } = new List<FareceiptContact>();

    [InverseProperty("Fareceipt")]
    public virtual ICollection<FareceiptCreditNote> FareceiptCreditNotes { get; set; } = new List<FareceiptCreditNote>();

    [InverseProperty("Fareceipt")]
    public virtual ICollection<FareceiptDiscount> FareceiptDiscounts { get; set; } = new List<FareceiptDiscount>();

    [InverseProperty("Fareceipt")]
    public virtual ICollection<FareceiptHistory> FareceiptHistories { get; set; } = new List<FareceiptHistory>();

    [InverseProperty("Fareceipt")]
    public virtual ICollection<FasellReturnReceipt> FasellReturnReceipts { get; set; } = new List<FasellReturnReceipt>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("Icreceipts")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("Icreceipts")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("Icreceipts")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAppurchaseContractId")]
    [InverseProperty("Icreceipts")]
    public virtual AppurchaseContract FkAppurchaseContract { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("Icreceipts")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("Icreceipts")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Icreceipts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("Icreceipts")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("Icreceipts")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Icreceipts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("Icreceipts")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Icreceipts")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("Icreceipts")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkGeterminalId")]
    [InverseProperty("Icreceipts")]
    public virtual Geterminal FkGeterminal { get; set; }

    [ForeignKey("FkHrdeliveryEmployeeId")]
    [InverseProperty("IcreceiptFkHrdeliveryEmployees")]
    public virtual Hremployee FkHrdeliveryEmployee { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Icreceipts")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Icreceipts")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("Icreceipts")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcreceiptFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcimportAndExportReasonId")]
    [InverseProperty("Icreceipts")]
    public virtual IcimportAndExportReason FkIcimportAndExportReason { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcreceiptFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcreceiptFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcreceiptFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcreceiptFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductTransferId")]
    [InverseProperty("IcreceiptFkIcproductTransfers")]
    public virtual Icproduct FkIcproductTransfer { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Icreceipts")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcreceiptFkMmbatchProducts")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("Icreceipts")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductTransferId")]
    [InverseProperty("IcreceiptFkMmbatchProductTransfers")]
    public virtual MmbatchProduct FkMmbatchProductTransfer { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("Icreceipts")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("Icreceipts")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<IcreceiptItemContFee> IcreceiptItemContFees { get; set; } = new List<IcreceiptItemContFee>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<IcreceiptItemCont> IcreceiptItemConts { get; set; } = new List<IcreceiptItemCont>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<IcreceiptItemLog> IcreceiptItemLogs { get; set; } = new List<IcreceiptItemLog>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<IcreceiptPackageItem> IcreceiptPackageItems { get; set; } = new List<IcreceiptPackageItem>();

    [ForeignKey("IcreceiptProposedEmployeeId")]
    [InverseProperty("IcreceiptIcreceiptProposedEmployees")]
    public virtual Hremployee IcreceiptProposedEmployee { get; set; }

    [InverseProperty("FkIcreceipt")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
