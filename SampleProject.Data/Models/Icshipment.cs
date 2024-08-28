using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipments")]
[Microsoft.EntityFrameworkCore.Index("IcshipmentNo", "IcshipmentDate", "FkBrbranchId", "FkIcstockId", "IcshipmentReference", "IcshipmentTypeCombo", Name = "Idx_ICShipments")]
public partial class Icshipment
{
    [Key]
    [Column("ICShipmentID")]
    public int IcshipmentId { get; set; }

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

    [Column("FK_GELanguageID")]
    public int FkGelanguageId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_GEVATRegionID")]
    public int? FkGevatregionId { get; set; }

    [Column("FK_ARPriceLevelID")]
    public int? FkArpriceLevelId { get; set; }

    [Column("FK_ARSellerID")]
    public int? FkArsellerId { get; set; }

    [Column("FK_ARAssociatedSellerID")]
    public int? FkArassociatedSellerId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ICShipmentStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentStatus { get; set; }

    [Required]
    [Column("ICShipmentNo")]
    [StringLength(50)]
    public string IcshipmentNo { get; set; }

    [Column("ICShipmentName")]
    [StringLength(100)]
    public string IcshipmentName { get; set; }

    [Column("ICShipmentDesc")]
    [StringLength(512)]
    public string IcshipmentDesc { get; set; }

    [Column("ICShipmentDate", TypeName = "datetime")]
    public DateTime? IcshipmentDate { get; set; }

    [Column("ICShipmentValidateDate", TypeName = "datetime")]
    public DateTime? IcshipmentValidateDate { get; set; }

    [Column("ICShipmentDeliveryDate", TypeName = "datetime")]
    public DateTime? IcshipmentDeliveryDate { get; set; }

    [Column("ICShipmentDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentDiscountPerCent { get; set; }

    [Column("ICShipmentDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentDiscountFix { get; set; }

    [Column("ICShipmentReference")]
    [StringLength(150)]
    public string IcshipmentReference { get; set; }

    [Column("ICShipmentActiveCheck")]
    public bool? IcshipmentActiveCheck { get; set; }

    [Column("ICShipmentTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentTaxNumber { get; set; }

    [Column("ICShipmentTypeCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentTypeCombo { get; set; }

    [Column("ICShipmentNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentNetAmount { get; set; }

    [Column("ICShipmentTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentTaxPercent { get; set; }

    [Column("ICShipmentTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentTaxAmount { get; set; }

    [Column("ICShipmentSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentSubTotalAmount { get; set; }

    [Column("ICShipmentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentTotalAmount { get; set; }

    [Column("ICShipmentDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentDepositBalance { get; set; }

    [Column("ICShipmentBalanceDue", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentBalanceDue { get; set; }

    [Column("ICShipmentMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode01Combo { get; set; }

    [Column("ICShipmentMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode02Combo { get; set; }

    [Column("ICShipmentMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode03Combo { get; set; }

    [Column("ICShipmentMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode04Combo { get; set; }

    [Column("ICShipmentMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode05Combo { get; set; }

    [Column("ICShipmentMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode06Combo { get; set; }

    [Column("ICShipmentMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode07Combo { get; set; }

    [Column("ICShipmentMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode08Combo { get; set; }

    [Column("ICShipmentMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode09Combo { get; set; }

    [Column("ICShipmentMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode10Combo { get; set; }

    [Column("ICShipmentMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode11Combo { get; set; }

    [Column("ICShipmentMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentMatchCode12Combo { get; set; }

    [Column("ICShipmentProject")]
    [StringLength(50)]
    public string IcshipmentProject { get; set; }

    [Column("ICShipmentCustomerName")]
    [StringLength(50)]
    public string IcshipmentCustomerName { get; set; }

    [Column("ICShipmentCustomerDesc")]
    [StringLength(500)]
    public string IcshipmentCustomerDesc { get; set; }

    [Column("FK_ARCustomerContactInvoiceID")]
    public int? FkArcustomerContactInvoiceId { get; set; }

    [Column("ICShipmentInvoiceContactName")]
    [StringLength(50)]
    public string IcshipmentInvoiceContactName { get; set; }

    [Column("ICShipmentInvoiceContactFirstName")]
    [StringLength(50)]
    public string IcshipmentInvoiceContactFirstName { get; set; }

    [Column("ICShipmentInvoiceContactLastName")]
    [StringLength(50)]
    public string IcshipmentInvoiceContactLastName { get; set; }

    [Column("ICShipmentInvoiceContactTitle")]
    [StringLength(50)]
    public string IcshipmentInvoiceContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ICShipmentInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string IcshipmentInvoiceContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ICShipmentInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string IcshipmentInvoiceContactHeaderMessage { get; set; }

    [Column("ICShipmentInvoiceContactEmail1")]
    [StringLength(100)]
    public string IcshipmentInvoiceContactEmail1 { get; set; }

    [Column("ICShipmentInvoiceContactEmail2")]
    [StringLength(100)]
    public string IcshipmentInvoiceContactEmail2 { get; set; }

    [Column("ICShipmentInvoiceContactWebsite")]
    [StringLength(100)]
    public string IcshipmentInvoiceContactWebsite { get; set; }

    [Column("ICShipmentInvoiceContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentInvoiceContactPhonePrivate { get; set; }

    [Column("ICShipmentInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentInvoiceContactPhone { get; set; }

    [Column("ICShipmentInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentInvoiceContactPhone1 { get; set; }

    [Column("ICShipmentInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentInvoiceContactCellPhone { get; set; }

    [Column("ICShipmentInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentInvoiceContactCellPhone1 { get; set; }

    [Column("ICShipmentInvoiceContactFax")]
    [StringLength(50)]
    public string IcshipmentInvoiceContactFax { get; set; }

    [Column("ICShipmentInvoiceContactType")]
    [StringLength(50)]
    public string IcshipmentInvoiceContactType { get; set; }

    [Column("ICShipmentInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcshipmentInvoiceContactInformation { get; set; }

    [Column("ICShipmentInvoiceContactDepartment")]
    [StringLength(50)]
    public string IcshipmentInvoiceContactDepartment { get; set; }

    [Column("ICShipmentInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcshipmentInvoiceContactRoom { get; set; }

    [Column("ICShipmentInvoiceAddressLine1")]
    [StringLength(200)]
    public string IcshipmentInvoiceAddressLine1 { get; set; }

    [Column("ICShipmentInvoiceAddressLine2")]
    [StringLength(200)]
    public string IcshipmentInvoiceAddressLine2 { get; set; }

    [Column("ICShipmentInvoiceAddressLine3")]
    [StringLength(200)]
    public string IcshipmentInvoiceAddressLine3 { get; set; }

    [Column("ICShipmentInvoiceAddressStreet")]
    [StringLength(200)]
    public string IcshipmentInvoiceAddressStreet { get; set; }

    [Column("ICShipmentInvoiceAddressCity")]
    [StringLength(50)]
    public string IcshipmentInvoiceAddressCity { get; set; }

    [Column("ICShipmentInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string IcshipmentInvoiceAddressPostalCode { get; set; }

    [Column("ICShipmentInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string IcshipmentInvoiceAddressStateProvince { get; set; }

    [Column("ICShipmentInvoiceAddressZipCode")]
    [StringLength(50)]
    public string IcshipmentInvoiceAddressZipCode { get; set; }

    [Column("ICShipmentInvoiceAddressCountry")]
    [StringLength(50)]
    public string IcshipmentInvoiceAddressCountry { get; set; }

    [Column("FK_ARCustomerContactSOID")]
    public int? FkArcustomerContactSoid { get; set; }

    [Column("ICShipmentSOContactName")]
    [StringLength(50)]
    public string IcshipmentSocontactName { get; set; }

    [Column("ICShipmentSOContactBirthday", TypeName = "datetime")]
    public DateTime? IcshipmentSocontactBirthday { get; set; }

    [Column("ICShipmentSOContactFirstName")]
    [StringLength(50)]
    public string IcshipmentSocontactFirstName { get; set; }

    [Column("ICShipmentSOContactLastName")]
    [StringLength(50)]
    public string IcshipmentSocontactLastName { get; set; }

    [Column("ICShipmentSOContactTitle")]
    [StringLength(50)]
    public string IcshipmentSocontactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ICShipmentSOContactHeaderLetter")]
    [StringLength(100)]
    public string IcshipmentSocontactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ICShipmentSOContactHeaderMessage")]
    [StringLength(255)]
    public string IcshipmentSocontactHeaderMessage { get; set; }

    [Column("ICShipmentSOContactEmail1")]
    [StringLength(100)]
    public string IcshipmentSocontactEmail1 { get; set; }

    [Column("ICShipmentSOContactEmail2")]
    [StringLength(100)]
    public string IcshipmentSocontactEmail2 { get; set; }

    [Column("ICShipmentSOContactWebsite")]
    [StringLength(100)]
    public string IcshipmentSocontactWebsite { get; set; }

    [Column("ICShipmentSOContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentSocontactPhonePrivate { get; set; }

    [Column("ICShipmentSOContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentSocontactPhone { get; set; }

    [Column("ICShipmentSOContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentSocontactPhone1 { get; set; }

    [Column("ICShipmentSOContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentSocontactCellPhone { get; set; }

    [Column("ICShipmentSOContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentSocontactCellPhone1 { get; set; }

    [Column("ICShipmentSOContactFax")]
    [StringLength(50)]
    public string IcshipmentSocontactFax { get; set; }

    [Column("ICShipmentSOContactType")]
    [StringLength(50)]
    public string IcshipmentSocontactType { get; set; }

    [Column("ICShipmentSOContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcshipmentSocontactInformation { get; set; }

    [Column("ICShipmentSOContactDepartment")]
    [StringLength(50)]
    public string IcshipmentSocontactDepartment { get; set; }

    [Column("ICShipmentSOContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcshipmentSocontactRoom { get; set; }

    [Column("ICShipmentSOAddressLine1")]
    [StringLength(200)]
    public string IcshipmentSoaddressLine1 { get; set; }

    [Column("ICShipmentSOAddressLine2")]
    [StringLength(200)]
    public string IcshipmentSoaddressLine2 { get; set; }

    [Column("ICShipmentSOAddressLine3")]
    [StringLength(200)]
    public string IcshipmentSoaddressLine3 { get; set; }

    [Column("ICShipmentSOAddressStreet")]
    [StringLength(200)]
    public string IcshipmentSoaddressStreet { get; set; }

    [Column("ICShipmentSOAddressCity")]
    [StringLength(50)]
    public string IcshipmentSoaddressCity { get; set; }

    [Column("ICShipmentSOAddressPostalCode")]
    [StringLength(50)]
    public string IcshipmentSoaddressPostalCode { get; set; }

    [Column("ICShipmentSOAddressStateProvince")]
    [StringLength(50)]
    public string IcshipmentSoaddressStateProvince { get; set; }

    [Column("ICShipmentSOAddressZipCode")]
    [StringLength(50)]
    public string IcshipmentSoaddressZipCode { get; set; }

    [Column("ICShipmentSOAddressCountry")]
    [StringLength(50)]
    public string IcshipmentSoaddressCountry { get; set; }

    [Column("FK_ARCustomerContactDeliveryID")]
    public int? FkArcustomerContactDeliveryId { get; set; }

    [Column("ICShipmentDeliveryContactName")]
    [StringLength(100)]
    public string IcshipmentDeliveryContactName { get; set; }

    [Column("ICShipmentDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? IcshipmentDeliveryContactBirthday { get; set; }

    [Column("ICShipmentDeliveryContactFirstName")]
    [StringLength(50)]
    public string IcshipmentDeliveryContactFirstName { get; set; }

    [Column("ICShipmentDeliveryContactLastName")]
    [StringLength(50)]
    public string IcshipmentDeliveryContactLastName { get; set; }

    [Column("ICShipmentDeliveryContactTitle")]
    [StringLength(50)]
    public string IcshipmentDeliveryContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ICShipmentDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string IcshipmentDeliveryContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ICShipmentDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string IcshipmentDeliveryContactHeaderMessage { get; set; }

    [Column("ICShipmentDeliveryContactEmail1")]
    [StringLength(100)]
    public string IcshipmentDeliveryContactEmail1 { get; set; }

    [Column("ICShipmentDeliveryContactEmail2")]
    [StringLength(100)]
    public string IcshipmentDeliveryContactEmail2 { get; set; }

    [Column("ICShipmentDeliveryContactWebsite")]
    [StringLength(100)]
    public string IcshipmentDeliveryContactWebsite { get; set; }

    [Column("ICShipmentDeliveryContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentDeliveryContactPhonePrivate { get; set; }

    [Column("ICShipmentDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentDeliveryContactPhone { get; set; }

    [Column("ICShipmentDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentDeliveryContactPhone1 { get; set; }

    [Column("ICShipmentDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentDeliveryContactCellPhone { get; set; }

    [Column("ICShipmentDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentDeliveryContactCellPhone1 { get; set; }

    [Column("ICShipmentDeliveryContactFax")]
    [StringLength(50)]
    public string IcshipmentDeliveryContactFax { get; set; }

    [Column("ICShipmentDeliveryContactType")]
    [StringLength(50)]
    public string IcshipmentDeliveryContactType { get; set; }

    [Column("ICShipmentDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcshipmentDeliveryContactInformation { get; set; }

    [Column("ICShipmentDeliveryContactDepartment")]
    [StringLength(50)]
    public string IcshipmentDeliveryContactDepartment { get; set; }

    [Column("ICShipmentDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcshipmentDeliveryContactRoom { get; set; }

    [Column("ICShipmentDeliveryAddressLine1")]
    [StringLength(200)]
    public string IcshipmentDeliveryAddressLine1 { get; set; }

    [Column("ICShipmentDeliveryAddressLine2")]
    [StringLength(200)]
    public string IcshipmentDeliveryAddressLine2 { get; set; }

    [Column("ICShipmentDeliveryAddressLine3")]
    [StringLength(200)]
    public string IcshipmentDeliveryAddressLine3 { get; set; }

    [Column("ICShipmentDeliveryAddressStreet")]
    [StringLength(200)]
    public string IcshipmentDeliveryAddressStreet { get; set; }

    [Column("ICShipmentDeliveryAddressCity")]
    [StringLength(50)]
    public string IcshipmentDeliveryAddressCity { get; set; }

    [Column("ICShipmentDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string IcshipmentDeliveryAddressPostalCode { get; set; }

    [Column("ICShipmentDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string IcshipmentDeliveryAddressStateProvince { get; set; }

    [Column("ICShipmentDeliveryAddressZipCode")]
    [StringLength(50)]
    public string IcshipmentDeliveryAddressZipCode { get; set; }

    [Column("ICShipmentDeliveryAddressCountry")]
    [StringLength(50)]
    public string IcshipmentDeliveryAddressCountry { get; set; }

    [Column("ICShipmentShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentShippingFees { get; set; }

    [Column("ICShipmentShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentShippingExtraFees { get; set; }

    [Column("ICShipmentShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentShippingInsuranceFees { get; set; }

    [Column("ICShipmentShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentShippingPackagingFees { get; set; }

    [Column("ICShipmentShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentShippingReservedFees1 { get; set; }

    [Column("ICShipmentShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentShippingReservedFees2 { get; set; }

    [Column("ICShipmentShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentShippingReservedFees3 { get; set; }

    [Column("ICShipmentShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentShippingReservedFees4 { get; set; }

    [Column("ICShipmentShippingMethodDesc")]
    [StringLength(255)]
    public string IcshipmentShippingMethodDesc { get; set; }

    [Column("ICShipmentShippingMethodName")]
    [StringLength(50)]
    public string IcshipmentShippingMethodName { get; set; }

    [Column("ICShipmentExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ICShipmentTransferredDate", TypeName = "datetime")]
    public DateTime? IcshipmentTransferredDate { get; set; }

    [Column("ICObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcobjectType { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("ICShipmentContainerNo")]
    [StringLength(50)]
    public string IcshipmentContainerNo { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICShipmentShipmentType")]
    [StringLength(50)]
    public string IcshipmentShipmentType { get; set; }

    [Column("ICOutputVATInvoiceNoCombo")]
    [StringLength(50)]
    public string IcoutputVatinvoiceNoCombo { get; set; }

    [Column("ICOutputVATDocumentType")]
    [StringLength(1000)]
    public string IcoutputVatdocumentType { get; set; }

    [Column("ICShipmentFormNo")]
    [StringLength(50)]
    public string IcshipmentFormNo { get; set; }

    [Column("ICShipmentSymbol")]
    [StringLength(50)]
    public string IcshipmentSymbol { get; set; }

    [Column("ICShipmentVoucherNo")]
    [StringLength(50)]
    public string IcshipmentVoucherNo { get; set; }

    [Column("ICShipmentObjectTaxNumber")]
    [StringLength(50)]
    public string IcshipmentObjectTaxNumber { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("ICShipmentInvoiceDate", TypeName = "datetime")]
    public DateTime? IcshipmentInvoiceDate { get; set; }

    [Column("FK_MMAllocationProposalID")]
    public int? FkMmallocationProposalId { get; set; }

    [Column("ICShipmentAcceptanceType")]
    [StringLength(50)]
    public string IcshipmentAcceptanceType { get; set; }

    [Column("ICShipmentPONo")]
    [StringLength(50)]
    public string IcshipmentPono { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("ICShipmentSerialPrefix")]
    [StringLength(50)]
    public string IcshipmentSerialPrefix { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_MMBatchProductTransferID")]
    public int? FkMmbatchProductTransferId { get; set; }

    [Column("FK_ICProductTransferID")]
    public int? FkIcproductTransferId { get; set; }

    [Column("FK_ICImportAndExportReasonID")]
    public int FkIcimportAndExportReasonId { get; set; }

    [Column("ICShipmentType")]
    [StringLength(50)]
    public string IcshipmentType { get; set; }

    [Column("FK_HREmployeeReceverID")]
    public int? FkHremployeeReceverId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ICShipmentPostedStatus")]
    [StringLength(64)]
    public string IcshipmentPostedStatus { get; set; }

    [Column("ICShipmentPurposeType")]
    [StringLength(50)]
    public string IcshipmentPurposeType { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("ICShipmentIsReceiveBill")]
    public bool? IcshipmentIsReceiveBill { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_ARInvoiceRequestID")]
    public int? FkArinvoiceRequestId { get; set; }

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Column("ICShipmentTotalTruck")]
    public int? IcshipmentTotalTruck { get; set; }

    [Column("ICShipmentTotalM3", TypeName = "decimal(18, 5)")]
    public decimal? IcshipmentTotalM3 { get; set; }

    [Column("ICShipmentVehicleGroupID")]
    [StringLength(512)]
    public string IcshipmentVehicleGroupId { get; set; }

    [Column("FK_ACEquipmentShipmentReasonID")]
    public int? FkAcequipmentShipmentReasonId { get; set; }

    [Column("ICShipmentChannel")]
    [StringLength(50)]
    public string IcshipmentChannel { get; set; }

    [Column("FK_MMReceiveOperationID")]
    public int? FkMmreceiveOperationId { get; set; }

    [Column("FK_MMMachineUnitID")]
    public int? FkMmmachineUnitId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("ICShipmentProductType")]
    [StringLength(100)]
    public string IcshipmentProductType { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("ICShipmentContainerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentContainerNumber { get; set; }

    [Column("ICShipmentContainerSealNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentContainerSealNumber { get; set; }

    [Column("ICShipmentTractorTrailerNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentTractorTrailerNumber { get; set; }

    [Column("ICShipmentShipNumber")]
    [StringLength(50)]
    public string IcshipmentShipNumber { get; set; }

    [Column("ICShipmentETDDate", TypeName = "datetime")]
    public DateTime? IcshipmentEtddate { get; set; }

    [Column("ICShipmentInvoiceRequest")]
    [StringLength(100)]
    public string IcshipmentInvoiceRequest { get; set; }

    [Column("ICShipmentSaleContract")]
    [StringLength(100)]
    public string IcshipmentSaleContract { get; set; }

    [Column("ICListOfSalesChannelType")]
    [StringLength(50)]
    public string IclistOfSalesChannelType { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("ICShipmentInternalSeal")]
    [StringLength(100)]
    public string IcshipmentInternalSeal { get; set; }

    [Column("ICShipmentPOD")]
    [StringLength(100)]
    public string IcshipmentPod { get; set; }

    [Column("MMUpdatePositionItemPositionName")]
    [StringLength(500)]
    public string MmupdatePositionItemPositionName { get; set; }

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<ApallocationCostItemShipment> ApallocationCostItemShipments { get; set; } = new List<ApallocationCostItemShipment>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<ArinvoiceShipment> ArinvoiceShipments { get; set; } = new List<ArinvoiceShipment>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("Fashipment")]
    public virtual ICollection<FashipmentContact> FashipmentContacts { get; set; } = new List<FashipmentContact>();

    [InverseProperty("Fashipment")]
    public virtual ICollection<FashipmentDiscount> FashipmentDiscounts { get; set; } = new List<FashipmentDiscount>();

    [InverseProperty("Fashipment")]
    public virtual ICollection<FashipmentHistory> FashipmentHistories { get; set; } = new List<FashipmentHistory>();

    [InverseProperty("Fashipment")]
    public virtual ICollection<FashipmentInvoice> FashipmentInvoices { get; set; } = new List<FashipmentInvoice>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("Icshipments")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("Icshipments")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("Icshipments")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("Icshipments")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("Icshipments")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArassociatedSellerId")]
    [InverseProperty("IcshipmentFkArassociatedSellers")]
    public virtual Hremployee FkArassociatedSeller { get; set; }

    [ForeignKey("FkArinvoiceRequestId")]
    [InverseProperty("Icshipments")]
    public virtual ArinvoiceRequest FkArinvoiceRequest { get; set; }

    [ForeignKey("FkArpriceLevelId")]
    [InverseProperty("Icshipments")]
    public virtual ArpriceLevel FkArpriceLevel { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("Icshipments")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkArsellerId")]
    [InverseProperty("IcshipmentFkArsellers")]
    public virtual Hremployee FkArseller { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Icshipments")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("Icshipments")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Icshipments")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("Icshipments")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("Icshipments")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkGevatregionId")]
    [InverseProperty("Icshipments")]
    public virtual Gevatregion FkGevatregion { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Icshipments")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Icshipments")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcshipmentFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeReceverId")]
    [InverseProperty("IcshipmentFkHremployeeRecevers")]
    public virtual Hremployee FkHremployeeRecever { get; set; }

    [ForeignKey("FkIcimportAndExportReasonId")]
    [InverseProperty("Icshipments")]
    public virtual IcimportAndExportReason FkIcimportAndExportReason { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcshipmentFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcshipmentFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcshipmentFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcshipmentFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductTransferId")]
    [InverseProperty("IcshipmentFkIcproductTransfers")]
    public virtual Icproduct FkIcproductTransfer { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Icshipments")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("Icshipments")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmallocationProposalId")]
    [InverseProperty("Icshipments")]
    public virtual MmallocationProposal FkMmallocationProposal { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcshipmentFkMmbatchProducts")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductTransferId")]
    [InverseProperty("IcshipmentFkMmbatchProductTransfers")]
    public virtual MmbatchProduct FkMmbatchProductTransfer { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("Icshipments")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("Icshipments")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("Icshipments")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("Icshipments")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("Icshipments")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();

    [InverseProperty("FkIcshipmentSaleOrder")]
    public virtual ICollection<IcreturnShipping> IcreturnShippings { get; set; } = new List<IcreturnShipping>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<IcshipmentPackageItem> IcshipmentPackageItems { get; set; } = new List<IcshipmentPackageItem>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<IcshipmentPackage> IcshipmentPackages { get; set; } = new List<IcshipmentPackage>();

    [InverseProperty("FkIcshipment")]
    public virtual ICollection<IcshipmentSaleOrder> IcshipmentSaleOrders { get; set; } = new List<IcshipmentSaleOrder>();
}
