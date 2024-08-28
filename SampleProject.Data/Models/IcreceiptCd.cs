using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptCDs")]
public partial class IcreceiptCd
{
    [Key]
    [Column("ICReceiptCDID")]
    public int IcreceiptCdid { get; set; }

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
    public int FkApsupplierId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_BRTransferredBranchID")]
    public int? FkBrtransferredBranchId { get; set; }

    [Required]
    [Column("ICReceiptCDNo")]
    [StringLength(50)]
    public string IcreceiptCdno { get; set; }

    [Column("ICReceiptCDName")]
    [StringLength(100)]
    public string IcreceiptCdname { get; set; }

    [Column("ICReceiptCDDesc")]
    [StringLength(512)]
    public string IcreceiptCddesc { get; set; }

    [Column("ICReceiptCDComment")]
    [StringLength(512)]
    public string IcreceiptCdcomment { get; set; }

    [Required]
    [Column("ICReceiptCDPackNo")]
    [StringLength(50)]
    public string IcreceiptCdpackNo { get; set; }

    [Column("ICReceiptCDDate", TypeName = "datetime")]
    public DateTime? IcreceiptCddate { get; set; }

    [Column("ICReceiptCDValidateDate", TypeName = "datetime")]
    public DateTime? IcreceiptCdvalidateDate { get; set; }

    [Column("ICReceiptCDDeliveryDate", TypeName = "datetime")]
    public DateTime? IcreceiptCddeliveryDate { get; set; }

    [Column("ICReceiptCDDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCddiscountPerCent { get; set; }

    [Column("ICReceiptCDDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCddiscountFix { get; set; }

    [Column("ICReceiptCDReference")]
    [StringLength(50)]
    public string IcreceiptCdreference { get; set; }

    [Column("ICReceiptCDActiveCheck")]
    public bool? IcreceiptCdactiveCheck { get; set; }

    [Column("ICReceiptCDTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdtaxNumber { get; set; }

    [Column("ICReceiptCDTypeCombo")]
    [StringLength(50)]
    public string IcreceiptCdtypeCombo { get; set; }

    [Column("ICReceiptCDStatus")]
    [StringLength(100)]
    public string IcreceiptCdstatus { get; set; }

    [Column("ICReceiptCDTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdtaxPercent { get; set; }

    [Column("ICReceiptCDTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdtaxAmount { get; set; }

    [Column("ICReceiptCDSubTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdsubTotalCost { get; set; }

    [Column("ICReceiptCDTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdtotalCost { get; set; }

    [Column("ICReceiptCDMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode01Combo { get; set; }

    [Column("ICReceiptCDMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode02Combo { get; set; }

    [Column("ICReceiptCDMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode03Combo { get; set; }

    [Column("ICReceiptCDMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode04Combo { get; set; }

    [Column("ICReceiptCDMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode05Combo { get; set; }

    [Column("ICReceiptCDMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode06Combo { get; set; }

    [Column("ICReceiptCDMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode07Combo { get; set; }

    [Column("ICReceiptCDMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode08Combo { get; set; }

    [Column("ICReceiptCDMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode09Combo { get; set; }

    [Column("ICReceiptCDMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode10Combo { get; set; }

    [Column("ICReceiptCDMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode11Combo { get; set; }

    [Column("ICReceiptCDMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdmatchCode12Combo { get; set; }

    [Column("ICReceiptCDProject")]
    [StringLength(50)]
    public string IcreceiptCdproject { get; set; }

    [Column("FK_APSupplierContactInvoiceID")]
    public int? FkApsupplierContactInvoiceId { get; set; }

    [Column("ICReceiptCDInvoiceContactName")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceContactName { get; set; }

    [Column("ICReceiptCDInvoiceContactFirstName")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceContactFirstName { get; set; }

    [Column("ICReceiptCDInvoiceContactLastName")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceContactLastName { get; set; }

    [Column("ICReceiptCDInvoiceContactTitle")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceContactTitle { get; set; }

    [Column("ICReceiptCDInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string IcreceiptCdinvoiceContactHeaderLetter { get; set; }

    [Column("ICReceiptCDInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string IcreceiptCdinvoiceContactHeaderMessage { get; set; }

    [Column("ICReceiptCDInvoiceContactEmail1")]
    [StringLength(100)]
    public string IcreceiptCdinvoiceContactEmail1 { get; set; }

    [Column("ICReceiptCDInvoiceContactEmail2")]
    [StringLength(100)]
    public string IcreceiptCdinvoiceContactEmail2 { get; set; }

    [Column("ICReceiptCDInvoiceContactWebsite")]
    [StringLength(100)]
    public string IcreceiptCdinvoiceContactWebsite { get; set; }

    [Column("ICReceiptCDInvoiceContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdinvoiceContactPhonePrivate { get; set; }

    [Column("ICReceiptCDInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdinvoiceContactPhone { get; set; }

    [Column("ICReceiptCDInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdinvoiceContactPhone1 { get; set; }

    [Column("ICReceiptCDInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdinvoiceContactCellPhone { get; set; }

    [Column("ICReceiptCDInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdinvoiceContactCellPhone1 { get; set; }

    [Column("ICReceiptCDInvoiceContactFax")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceContactFax { get; set; }

    [Column("ICReceiptCDInvoiceContactType")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceContactType { get; set; }

    [Column("ICReceiptCDInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcreceiptCdinvoiceContactInformation { get; set; }

    [Column("ICReceiptCDInvoiceContactDepartment")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceContactDepartment { get; set; }

    [Column("ICReceiptCDInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcreceiptCdinvoiceContactRoom { get; set; }

    [Column("ICReceiptCDInvoiceAddressLine1")]
    [StringLength(250)]
    public string IcreceiptCdinvoiceAddressLine1 { get; set; }

    [Column("ICReceiptCDInvoiceAddressLine2")]
    [StringLength(250)]
    public string IcreceiptCdinvoiceAddressLine2 { get; set; }

    [Column("ICReceiptCDInvoiceAddressLine3")]
    [StringLength(250)]
    public string IcreceiptCdinvoiceAddressLine3 { get; set; }

    [Column("ICReceiptCDInvoiceAddressStreet")]
    [StringLength(200)]
    public string IcreceiptCdinvoiceAddressStreet { get; set; }

    [Column("ICReceiptCDInvoiceAddressCity")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceAddressCity { get; set; }

    [Column("ICReceiptCDInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceAddressPostalCode { get; set; }

    [Column("ICReceiptCDInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceAddressStateProvince { get; set; }

    [Column("ICReceiptCDInvoiceAddressZipCode")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceAddressZipCode { get; set; }

    [Column("ICReceiptCDInvoiceAddressCountry")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceAddressCountry { get; set; }

    [Column("FK_APSupplierContactPOID")]
    public int? FkApsupplierContactPoid { get; set; }

    [Column("ICReceiptCDPOContactName")]
    [StringLength(50)]
    public string IcreceiptCdpocontactName { get; set; }

    [Column("ICReceiptCDPOContactBirthday", TypeName = "datetime")]
    public DateTime? IcreceiptCdpocontactBirthday { get; set; }

    [Column("ICReceiptCDPOContactFirstName")]
    [StringLength(50)]
    public string IcreceiptCdpocontactFirstName { get; set; }

    [Column("ICReceiptCDPOContactLastName")]
    [StringLength(50)]
    public string IcreceiptCdpocontactLastName { get; set; }

    [Column("ICReceiptCDPOContactTitle")]
    [StringLength(50)]
    public string IcreceiptCdpocontactTitle { get; set; }

    [Column("ICReceiptCDPOContactHeaderLetter")]
    [StringLength(100)]
    public string IcreceiptCdpocontactHeaderLetter { get; set; }

    [Column("ICReceiptCDPOContactHeaderMessage")]
    [StringLength(255)]
    public string IcreceiptCdpocontactHeaderMessage { get; set; }

    [Column("ICReceiptCDPOContactEmail1")]
    [StringLength(100)]
    public string IcreceiptCdpocontactEmail1 { get; set; }

    [Column("ICReceiptCDPOContactEmail2")]
    [StringLength(100)]
    public string IcreceiptCdpocontactEmail2 { get; set; }

    [Column("ICReceiptCDPOContactWebsite")]
    [StringLength(100)]
    public string IcreceiptCdpocontactWebsite { get; set; }

    [Column("ICReceiptCDPOContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdpocontactPhonePrivate { get; set; }

    [Column("ICReceiptCDPOContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdpocontactPhone { get; set; }

    [Column("ICReceiptCDPOContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdpocontactPhone1 { get; set; }

    [Column("ICReceiptCDPOContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdpocontactCellPhone { get; set; }

    [Column("ICReceiptCDPOContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCdpocontactCellPhone1 { get; set; }

    [Column("ICReceiptCDPOContactFax")]
    [StringLength(50)]
    public string IcreceiptCdpocontactFax { get; set; }

    [Column("ICReceiptCDPOContactType")]
    [StringLength(50)]
    public string IcreceiptCdpocontactType { get; set; }

    [Column("ICReceiptCDPOContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcreceiptCdpocontactInformation { get; set; }

    [Column("ICReceiptCDPOContactDepartment")]
    [StringLength(50)]
    public string IcreceiptCdpocontactDepartment { get; set; }

    [Column("ICReceiptCDPOContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcreceiptCdpocontactRoom { get; set; }

    [Column("ICReceiptCDPOAddressLine1")]
    [StringLength(250)]
    public string IcreceiptCdpoaddressLine1 { get; set; }

    [Column("ICReceiptCDPOAddressLine2")]
    [StringLength(250)]
    public string IcreceiptCdpoaddressLine2 { get; set; }

    [Column("ICReceiptCDPOAddressLine3")]
    [StringLength(250)]
    public string IcreceiptCdpoaddressLine3 { get; set; }

    [Column("ICReceiptCDPOAddressStreet")]
    [StringLength(200)]
    public string IcreceiptCdpoaddressStreet { get; set; }

    [Column("ICReceiptCDPOAddressCity")]
    [StringLength(50)]
    public string IcreceiptCdpoaddressCity { get; set; }

    [Column("ICReceiptCDPOAddressPostalCode")]
    [StringLength(50)]
    public string IcreceiptCdpoaddressPostalCode { get; set; }

    [Column("ICReceiptCDPOAddressStateProvince")]
    [StringLength(50)]
    public string IcreceiptCdpoaddressStateProvince { get; set; }

    [Column("ICReceiptCDPOAddressZipCode")]
    [StringLength(50)]
    public string IcreceiptCdpoaddressZipCode { get; set; }

    [Column("ICReceiptCDPOAddressCountry")]
    [StringLength(50)]
    public string IcreceiptCdpoaddressCountry { get; set; }

    [Column("ICReceiptCDDeliveryContactName")]
    [StringLength(100)]
    public string IcreceiptCddeliveryContactName { get; set; }

    [Column("ICReceiptCDDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? IcreceiptCddeliveryContactBirthday { get; set; }

    [Column("ICReceiptCDDeliveryContactFirstName")]
    [StringLength(50)]
    public string IcreceiptCddeliveryContactFirstName { get; set; }

    [Column("ICReceiptCDDeliveryContactLastName")]
    [StringLength(50)]
    public string IcreceiptCddeliveryContactLastName { get; set; }

    [Column("ICReceiptCDDeliveryContactTitle")]
    [StringLength(50)]
    public string IcreceiptCddeliveryContactTitle { get; set; }

    [Column("ICReceiptCDDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string IcreceiptCddeliveryContactHeaderLetter { get; set; }

    [Column("ICReceiptCDDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string IcreceiptCddeliveryContactHeaderMessage { get; set; }

    [Column("ICReceiptCDDeliveryContactEmail1")]
    [StringLength(100)]
    public string IcreceiptCddeliveryContactEmail1 { get; set; }

    [Column("ICReceiptCDDeliveryContactEmail2")]
    [StringLength(100)]
    public string IcreceiptCddeliveryContactEmail2 { get; set; }

    [Column("ICReceiptCDDeliveryContactWebsite")]
    [StringLength(100)]
    public string IcreceiptCddeliveryContactWebsite { get; set; }

    [Column("ICReceiptCDDeliveryContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCddeliveryContactPhonePrivate { get; set; }

    [Column("ICReceiptCDDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCddeliveryContactPhone { get; set; }

    [Column("ICReceiptCDDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCddeliveryContactPhone1 { get; set; }

    [Column("ICReceiptCDDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCddeliveryContactCellPhone { get; set; }

    [Column("ICReceiptCDDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptCddeliveryContactCellPhone1 { get; set; }

    [Column("ICReceiptCDDeliveryContactFax")]
    [StringLength(50)]
    public string IcreceiptCddeliveryContactFax { get; set; }

    [Column("ICReceiptCDDeliveryContactType")]
    [StringLength(50)]
    public string IcreceiptCddeliveryContactType { get; set; }

    [Column("ICReceiptCDDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string IcreceiptCddeliveryContactInformation { get; set; }

    [Column("ICReceiptCDDeliveryContactDepartment")]
    [StringLength(50)]
    public string IcreceiptCddeliveryContactDepartment { get; set; }

    [Column("ICReceiptCDDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string IcreceiptCddeliveryContactRoom { get; set; }

    [Column("ICReceiptCDDeliveryAddressLine1")]
    [StringLength(250)]
    public string IcreceiptCddeliveryAddressLine1 { get; set; }

    [Column("ICReceiptCDDeliveryAddressLine2")]
    [StringLength(250)]
    public string IcreceiptCddeliveryAddressLine2 { get; set; }

    [Column("ICReceiptCDDeliveryAddressLine3")]
    [StringLength(250)]
    public string IcreceiptCddeliveryAddressLine3 { get; set; }

    [Column("ICReceiptCDDeliveryAddressStreet")]
    [StringLength(200)]
    public string IcreceiptCddeliveryAddressStreet { get; set; }

    [Column("ICReceiptCDDeliveryAddressCity")]
    [StringLength(50)]
    public string IcreceiptCddeliveryAddressCity { get; set; }

    [Column("ICReceiptCDDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string IcreceiptCddeliveryAddressPostalCode { get; set; }

    [Column("ICReceiptCDDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string IcreceiptCddeliveryAddressStateProvince { get; set; }

    [Column("ICReceiptCDDeliveryAddressZipCode")]
    [StringLength(50)]
    public string IcreceiptCddeliveryAddressZipCode { get; set; }

    [Column("ICReceiptCDDeliveryAddressCountry")]
    [StringLength(50)]
    public string IcreceiptCddeliveryAddressCountry { get; set; }

    [Column("ICReceiptCDShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdshippingFees { get; set; }

    [Column("ICReceiptCDShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdshippingExtraFees { get; set; }

    [Column("ICReceiptCDShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdshippingInsuranceFees { get; set; }

    [Column("ICReceiptCDShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdshippingPackagingFees { get; set; }

    [Column("ICReceiptCDShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdshippingReservedFees1 { get; set; }

    [Column("ICReceiptCDShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdshippingReservedFees2 { get; set; }

    [Column("ICReceiptCDShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdshippingReservedFees3 { get; set; }

    [Column("ICReceiptCDShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdshippingReservedFees4 { get; set; }

    [Column("ICReceiptCDShippingMethodDesc")]
    [StringLength(255)]
    public string IcreceiptCdshippingMethodDesc { get; set; }

    [Column("ICReceiptCDShippingMethodName")]
    [StringLength(50)]
    public string IcreceiptCdshippingMethodName { get; set; }

    [Column("ICReceiptCDInvoiceInNo")]
    [StringLength(50)]
    public string IcreceiptCdinvoiceInNo { get; set; }

    [Column("ICReceiptCDInvoiceInDate", TypeName = "datetime")]
    public DateTime? IcreceiptCdinvoiceInDate { get; set; }

    [Column("ICReceiptCDExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdexchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ICReceiptCDTransferredDate", TypeName = "datetime")]
    public DateTime? IcreceiptCdtransferredDate { get; set; }

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

    [Column("ICReceiptCDTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdtotalQty { get; set; }

    [Column("ICReceiptCDTotalWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptCdtotalWoodQty { get; set; }

    [Column("ICReceiptCDContainerNo")]
    [StringLength(50)]
    public string IcreceiptCdcontainerNo { get; set; }

    [Column("ICReceiptCDReceiptType")]
    [StringLength(50)]
    public string IcreceiptCdreceiptType { get; set; }

    [Column("ICReceiptCDCreateFrom")]
    [StringLength(100)]
    public string IcreceiptCdcreateFrom { get; set; }

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

    [Column("ICReceiptCDFormNo")]
    [StringLength(50)]
    public string IcreceiptCdformNo { get; set; }

    [Column("ICReceiptCDSymbol")]
    [StringLength(50)]
    public string IcreceiptCdsymbol { get; set; }

    [Column("ICReceiptCDVoucherNo")]
    [StringLength(50)]
    public string IcreceiptCdvoucherNo { get; set; }

    [Column("ICReceiptCDObjectTaxNumber")]
    [StringLength(50)]
    public string IcreceiptCdobjectTaxNumber { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("ICReceiptCDAcceptanceType")]
    [StringLength(100)]
    public string IcreceiptCdacceptanceType { get; set; }

    [Column("ICReceiptCDPONo")]
    [StringLength(50)]
    public string IcreceiptCdpono { get; set; }

    [Column("ICReceiptCDLotNo")]
    [StringLength(50)]
    public string IcreceiptCdlotNo { get; set; }

    [Column("ICReceiptCDSerieNo")]
    [StringLength(50)]
    public string IcreceiptCdserieNo { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("ICReceiptCDHeight")]
    public int? IcreceiptCdheight { get; set; }

    [Column("ICReceiptCDWoodNo")]
    [StringLength(50)]
    public string IcreceiptCdwoodNo { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("IcreceiptCds")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("IcreceiptCds")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("IcreceiptCdFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcreceiptCdFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcreceiptCdFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("IcreceiptCds")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcreceiptCds")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("IcreceiptCds")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("IcreceiptCds")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [InverseProperty("FkIcreceiptCd")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcreceiptCd")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();
}
