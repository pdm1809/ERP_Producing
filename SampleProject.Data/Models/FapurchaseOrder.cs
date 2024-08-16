using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrders")]
public partial class FapurchaseOrder
{
    [Key]
    [Column("FAPurchaseOrderID")]
    public int FapurchaseOrderId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FALanguageIDCombo")]
    public int FalanguageIdcombo { get; set; }

    [Column("FACurrencyIDCombo")]
    public int FacurrencyIdcombo { get; set; }

    [Column("FASupplierIDCombo")]
    public int? FasupplierIdcombo { get; set; }

    [Column("FAShippingMethodID")]
    public int? FashippingMethodId { get; set; }

    [Column("FAStockIDCombo")]
    public int FastockIdcombo { get; set; }

    [Column("FAStockSlotIDCombo")]
    public int? FastockSlotIdcombo { get; set; }

    [Column("FAVATRegionIDCombo")]
    public int? FavatregionIdcombo { get; set; }

    [Column("FABuyPriceCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FabuyPriceCombo { get; set; }

    [Column("FAPurchaseOrderStatus")]
    [StringLength(100)]
    public string FapurchaseOrderStatus { get; set; }

    [Column("FAPurchaseOrderSkonto")]
    [StringLength(50)]
    public string FapurchaseOrderSkonto { get; set; }

    [Column("FAPurchaseOrderSupplierBonus", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderSupplierBonus { get; set; }

    [Column("FAPaymentMethodCombo")]
    [StringLength(50)]
    public string FapaymentMethodCombo { get; set; }

    [Column("FAPurchaseOrderName")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderName { get; set; }

    [Column("FAPurchaseOrderDesc")]
    [StringLength(500)]
    public string FapurchaseOrderDesc { get; set; }

    [Column("FAPurchaseOrderText", TypeName = "ntext")]
    public string FapurchaseOrderText { get; set; }

    [Column("FAPurchaseOrderCulture")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderCulture { get; set; }

    [Column("FAPurchaseOrderStartDate", TypeName = "datetime")]
    public DateTime? FapurchaseOrderStartDate { get; set; }

    [Column("FAPurchaseOrderValidateDate", TypeName = "datetime")]
    public DateTime? FapurchaseOrderValidateDate { get; set; }

    [Column("FAPurchaseOrderDeliveryDate", TypeName = "datetime")]
    public DateTime? FapurchaseOrderDeliveryDate { get; set; }

    [Column("FAPurchaseOrderDeliveryDate1", TypeName = "datetime")]
    public DateTime? FapurchaseOrderDeliveryDate1 { get; set; }

    [Column("FAPurchaseOrderDeliveryDate2", TypeName = "datetime")]
    public DateTime? FapurchaseOrderDeliveryDate2 { get; set; }

    [Column("FAPurchaseOrderIsDiscountPercentCheck")]
    public bool? FapurchaseOrderIsDiscountPercentCheck { get; set; }

    [Column("FAPurchaseOrderDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderDiscountPerCent { get; set; }

    [Column("FAPurchaseOrderDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderDiscountFix { get; set; }

    [Column("FAPurchaseOrderOurReference")]
    [StringLength(150)]
    public string FapurchaseOrderOurReference { get; set; }

    [Column("FAPurchaseOrderYourReference")]
    [StringLength(150)]
    public string FapurchaseOrderYourReference { get; set; }

    [Column("FAPurchaseOrderRemark")]
    [StringLength(255)]
    public string FapurchaseOrderRemark { get; set; }

    [Column("FAPurchaseOrderRemark1")]
    [StringLength(255)]
    public string FapurchaseOrderRemark1 { get; set; }

    [Column("FAPurchaseOrderPerson")]
    public int? FapurchaseOrderPerson { get; set; }

    [Column("FAPurchaseOrderQuantity")]
    public int? FapurchaseOrderQuantity { get; set; }

    [Column("FAPurchaseOrderWeight", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderWeight { get; set; }

    [Column("FAPurchaseOrderVolume", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderVolume { get; set; }

    [Column("FAPurchaseOrderStornoCheck")]
    public bool? FapurchaseOrderStornoCheck { get; set; }

    [Column("FAPurchaseOrderSaveStatusInSession")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderSaveStatusInSession { get; set; }

    [Column("FAPurchaseOrderTaxNumberEWG")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderTaxNumberEwg { get; set; }

    [Column("FAPurchaseOrderTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderTaxNumber { get; set; }

    [Column("FAPurchaseOrderTaxNumberReserve")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderTaxNumberReserve { get; set; }

    [Column("FAPurchaseOrderTypeCombo")]
    [StringLength(50)]
    public string FapurchaseOrderTypeCombo { get; set; }

    [Column("FAPurchaseOrderMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode01Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode02Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode03Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode04Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode05Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode06Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode07Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode08Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode09Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode10Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode11Combo { get; set; }

    [Column("FAPurchaseOrderMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderMatchCode12Combo { get; set; }

    [Column("FAPurchaseOrderInfo", TypeName = "ntext")]
    public string FapurchaseOrderInfo { get; set; }

    [Column("FAPurchaseOrderProject")]
    [StringLength(50)]
    public string FapurchaseOrderProject { get; set; }

    [Column("FAPurchaseOrderInvoiceContactID")]
    public int? FapurchaseOrderInvoiceContactId { get; set; }

    [Column("FAPurchaseOrderInvoiceContactName")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceContactName { get; set; }

    [Column("FAPurchaseOrderInvoiceContactFirstName")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceContactFirstName { get; set; }

    [Column("FAPurchaseOrderInvoiceContactLastName")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceContactLastName { get; set; }

    [Column("FAPurchaseOrderInvoiceContactTitle")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceContactTitle { get; set; }

    [Column("FAPurchaseOrderInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string FapurchaseOrderInvoiceContactHeaderLetter { get; set; }

    [Column("FAPurchaseOrderInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string FapurchaseOrderInvoiceContactHeaderMessage { get; set; }

    [Column("FAPurchaseOrderInvoiceContactEmail1")]
    [StringLength(100)]
    public string FapurchaseOrderInvoiceContactEmail1 { get; set; }

    [Column("FAPurchaseOrderInvoiceContactEmail2")]
    [StringLength(100)]
    public string FapurchaseOrderInvoiceContactEmail2 { get; set; }

    [Column("FAPurchaseOrderInvoiceContactWebsite")]
    [StringLength(100)]
    public string FapurchaseOrderInvoiceContactWebsite { get; set; }

    [Column("FAPurchaseOrderInvoiceContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderInvoiceContactPhonePrivat { get; set; }

    [Column("FAPurchaseOrderInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderInvoiceContactPhone { get; set; }

    [Column("FAPurchaseOrderInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderInvoiceContactPhone1 { get; set; }

    [Column("FAPurchaseOrderInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderInvoiceContactCellPhone { get; set; }

    [Column("FAPurchaseOrderInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderInvoiceContactCellPhone1 { get; set; }

    [Column("FAPurchaseOrderInvoiceContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderInvoiceContactCellPhonePrivat { get; set; }

    [Column("FAPurchaseOrderInvoiceContactFax")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceContactFax { get; set; }

    [Column("FAPurchaseOrderInvoiceContactType")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceContactType { get; set; }

    [Column("FAPurchaseOrderInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FapurchaseOrderInvoiceContactInformation { get; set; }

    [Column("FAPurchaseOrderInvoiceContactDepartment")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceContactDepartment { get; set; }

    [Column("FAPurchaseOrderInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FapurchaseOrderInvoiceContactRoom { get; set; }

    [Column("FAPurchaseOrderInvoiceContactImage")]
    public byte[] FapurchaseOrderInvoiceContactImage { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressName")]
    [StringLength(100)]
    public string FapurchaseOrderInvoiceAddressName { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressDesc1")]
    [StringLength(250)]
    public string FapurchaseOrderInvoiceAddressDesc1 { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressDesc2")]
    [StringLength(250)]
    public string FapurchaseOrderInvoiceAddressDesc2 { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressDesc3")]
    [StringLength(200)]
    public string FapurchaseOrderInvoiceAddressDesc3 { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressStreet")]
    [StringLength(200)]
    public string FapurchaseOrderInvoiceAddressStreet { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressHouseNumber")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressHouseNumber { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressCity")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressCity { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressPostalCode { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressStateProvince { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressZipCode")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressZipCode { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressCountry")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressCountry { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressEmail")]
    [StringLength(100)]
    public string FapurchaseOrderInvoiceAddressEmail { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressWebsite")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressWebsite { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressPhone")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressPhone { get; set; }

    [Column("FAPurchaseOrderInvoiceAddresssFax")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddresssFax { get; set; }

    [Column("FAPurchaseOrderInvoiceAddresssInfo")]
    [StringLength(255)]
    public string FapurchaseOrderInvoiceAddresssInfo { get; set; }

    [Column("FAPurchaseOrderInvoiceAddresssCarZip")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddresssCarZip { get; set; }

    [Column("FAPurchaseOrderInvoiceAddressILNNumber")]
    [StringLength(50)]
    public string FapurchaseOrderInvoiceAddressIlnnumber { get; set; }

    [Column("FAPurchaseOrderCommandContactID")]
    public int? FapurchaseOrderCommandContactId { get; set; }

    [Column("FAPurchaseOrderCommandContactName")]
    [StringLength(50)]
    public string FapurchaseOrderCommandContactName { get; set; }

    [Column("FAPurchaseOrderCommandContactBirthday", TypeName = "datetime")]
    public DateTime? FapurchaseOrderCommandContactBirthday { get; set; }

    [Column("FAPurchaseOrderCommandContactFirstName")]
    [StringLength(50)]
    public string FapurchaseOrderCommandContactFirstName { get; set; }

    [Column("FAPurchaseOrderCommandContactLastName")]
    [StringLength(50)]
    public string FapurchaseOrderCommandContactLastName { get; set; }

    [Column("FAPurchaseOrderCommandContactTitle")]
    [StringLength(50)]
    public string FapurchaseOrderCommandContactTitle { get; set; }

    [Column("FAPurchaseOrderCommandContactHeaderLetter")]
    [StringLength(100)]
    public string FapurchaseOrderCommandContactHeaderLetter { get; set; }

    [Column("FAPurchaseOrderCommandContactHeaderMessage")]
    [StringLength(255)]
    public string FapurchaseOrderCommandContactHeaderMessage { get; set; }

    [Column("FAPurchaseOrderCommandContactEmail1")]
    [StringLength(100)]
    public string FapurchaseOrderCommandContactEmail1 { get; set; }

    [Column("FAPurchaseOrderCommandContactEmail2")]
    [StringLength(100)]
    public string FapurchaseOrderCommandContactEmail2 { get; set; }

    [Column("FAPurchaseOrderCommandContactWebsite")]
    [StringLength(100)]
    public string FapurchaseOrderCommandContactWebsite { get; set; }

    [Column("FAPurchaseOrderCommandContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderCommandContactPhonePrivat { get; set; }

    [Column("FAPurchaseOrderCommandContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderCommandContactPhone { get; set; }

    [Column("FAPurchaseOrderCommandContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderCommandContactPhone1 { get; set; }

    [Column("FAPurchaseOrderCommandContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderCommandContactCellPhone { get; set; }

    [Column("FAPurchaseOrderCommandContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderCommandContactCellPhone1 { get; set; }

    [Column("FAPurchaseOrderCommandContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderCommandContactCellPhonePrivat { get; set; }

    [Column("FAPurchaseOrderCommandContactFax")]
    [StringLength(50)]
    public string FapurchaseOrderCommandContactFax { get; set; }

    [Column("FAPurchaseOrderCommandContactType")]
    [StringLength(50)]
    public string FapurchaseOrderCommandContactType { get; set; }

    [Column("FAPurchaseOrderCommandContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FapurchaseOrderCommandContactInformation { get; set; }

    [Column("FAPurchaseOrderCommandContactDepartment")]
    [StringLength(50)]
    public string FapurchaseOrderCommandContactDepartment { get; set; }

    [Column("FAPurchaseOrderCommandContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FapurchaseOrderCommandContactRoom { get; set; }

    [Column("FAPurchaseOrderCommandContactImage")]
    public byte[] FapurchaseOrderCommandContactImage { get; set; }

    [Column("FAPurchaseOrderCommandAddressName")]
    [StringLength(100)]
    public string FapurchaseOrderCommandAddressName { get; set; }

    [Column("FAPurchaseOrderCommandAddressDesc1")]
    [StringLength(250)]
    public string FapurchaseOrderCommandAddressDesc1 { get; set; }

    [Column("FAPurchaseOrderCommandAddressDesc2")]
    [StringLength(250)]
    public string FapurchaseOrderCommandAddressDesc2 { get; set; }

    [Column("FAPurchaseOrderCommandAddressDesc3")]
    [StringLength(250)]
    public string FapurchaseOrderCommandAddressDesc3 { get; set; }

    [Column("FAPurchaseOrderCommandAddressStreet")]
    [StringLength(200)]
    public string FapurchaseOrderCommandAddressStreet { get; set; }

    [Column("FAPurchaseOrderCommandAddressHouseNumber")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressHouseNumber { get; set; }

    [Column("FAPurchaseOrderCommandAddressCity")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressCity { get; set; }

    [Column("FAPurchaseOrderCommandAddressPostalCode")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressPostalCode { get; set; }

    [Column("FAPurchaseOrderCommandAddressStateProvince")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressStateProvince { get; set; }

    [Column("FAPurchaseOrderCommandAddressZipCode")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressZipCode { get; set; }

    [Column("FAPurchaseOrderCommandAddressCountry")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressCountry { get; set; }

    [Column("FAPurchaseOrderCommandAddressEmail")]
    [StringLength(100)]
    public string FapurchaseOrderCommandAddressEmail { get; set; }

    [Column("FAPurchaseOrderCommandAddressWebsite")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressWebsite { get; set; }

    [Column("FAPurchaseOrderCommandAddressPhone")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressPhone { get; set; }

    [Column("FAPurchaseOrderCommandAddresssFax")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddresssFax { get; set; }

    [Column("FAPurchaseOrderCommandAddresssInfo")]
    [StringLength(255)]
    public string FapurchaseOrderCommandAddresssInfo { get; set; }

    [Column("FAPurchaseOrderCommandAddresssCarZip")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddresssCarZip { get; set; }

    [Column("FAPurchaseOrderCommandAddressILNNumber")]
    [StringLength(50)]
    public string FapurchaseOrderCommandAddressIlnnumber { get; set; }

    [Column("FAPurchaseOrderStockContactName")]
    [StringLength(50)]
    public string FapurchaseOrderStockContactName { get; set; }

    [Column("FAPurchaseOrderStockContactBirthday", TypeName = "datetime")]
    public DateTime? FapurchaseOrderStockContactBirthday { get; set; }

    [Column("FAPurchaseOrderStockContactFirstName")]
    [StringLength(50)]
    public string FapurchaseOrderStockContactFirstName { get; set; }

    [Column("FAPurchaseOrderStockContactLastName")]
    [StringLength(50)]
    public string FapurchaseOrderStockContactLastName { get; set; }

    [Column("FAPurchaseOrderStockContactTitle")]
    [StringLength(50)]
    public string FapurchaseOrderStockContactTitle { get; set; }

    [Column("FAPurchaseOrderStockContactHeaderLetter")]
    [StringLength(100)]
    public string FapurchaseOrderStockContactHeaderLetter { get; set; }

    [Column("FAPurchaseOrderStockContactHeaderMessage")]
    [StringLength(255)]
    public string FapurchaseOrderStockContactHeaderMessage { get; set; }

    [Column("FAPurchaseOrderStockContactEmail1")]
    [StringLength(100)]
    public string FapurchaseOrderStockContactEmail1 { get; set; }

    [Column("FAPurchaseOrderStockContactEmail2")]
    [StringLength(100)]
    public string FapurchaseOrderStockContactEmail2 { get; set; }

    [Column("FAPurchaseOrderStockContactWebsite")]
    [StringLength(100)]
    public string FapurchaseOrderStockContactWebsite { get; set; }

    [Column("FAPurchaseOrderStockContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderStockContactPhonePrivat { get; set; }

    [Column("FAPurchaseOrderStockContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderStockContactPhone { get; set; }

    [Column("FAPurchaseOrderStockContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderStockContactPhone1 { get; set; }

    [Column("FAPurchaseOrderStockContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderStockContactCellPhone { get; set; }

    [Column("FAPurchaseOrderStockContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderStockContactCellPhone1 { get; set; }

    [Column("FAPurchaseOrderStockContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FapurchaseOrderStockContactCellPhonePrivat { get; set; }

    [Column("FAPurchaseOrderStockContactFax")]
    [StringLength(50)]
    public string FapurchaseOrderStockContactFax { get; set; }

    [Column("FAPurchaseOrderStockContactType")]
    [StringLength(50)]
    public string FapurchaseOrderStockContactType { get; set; }

    [Column("FAPurchaseOrderStockContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FapurchaseOrderStockContactInformation { get; set; }

    [Column("FAPurchaseOrderStockContactDepartment")]
    [StringLength(50)]
    public string FapurchaseOrderStockContactDepartment { get; set; }

    [Column("FAPurchaseOrderStockContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FapurchaseOrderStockContactRoom { get; set; }

    [Column("FAPurchaseOrderStockContactImage")]
    public byte[] FapurchaseOrderStockContactImage { get; set; }

    [Column("FAPurchaseOrderStockAddressName")]
    [StringLength(100)]
    public string FapurchaseOrderStockAddressName { get; set; }

    [Column("FAPurchaseOrderStockAddressDesc1")]
    [StringLength(250)]
    public string FapurchaseOrderStockAddressDesc1 { get; set; }

    [Column("FAPurchaseOrderStockAddressDesc2")]
    [StringLength(250)]
    public string FapurchaseOrderStockAddressDesc2 { get; set; }

    [Column("FAPurchaseOrderStockAddressDesc3")]
    [StringLength(250)]
    public string FapurchaseOrderStockAddressDesc3 { get; set; }

    [Column("FAPurchaseOrderStockAddressStreet")]
    [StringLength(200)]
    public string FapurchaseOrderStockAddressStreet { get; set; }

    [Column("FAPurchaseOrderStockAddressHouseNumber")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressHouseNumber { get; set; }

    [Column("FAPurchaseOrderStockAddressCity")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressCity { get; set; }

    [Column("FAPurchaseOrderStockAddressPostalCode")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressPostalCode { get; set; }

    [Column("FAPurchaseOrderStockAddressStateProvince")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressStateProvince { get; set; }

    [Column("FAPurchaseOrderStockAddressZipCode")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressZipCode { get; set; }

    [Column("FAPurchaseOrderStockAddressCountry")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressCountry { get; set; }

    [Column("FAPurchaseOrderStockAddressEmail")]
    [StringLength(100)]
    public string FapurchaseOrderStockAddressEmail { get; set; }

    [Column("FAPurchaseOrderStockAddressWebsite")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressWebsite { get; set; }

    [Column("FAPurchaseOrderStockAddressPhone")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressPhone { get; set; }

    [Column("FAPurchaseOrderStockAddresssFax")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddresssFax { get; set; }

    [Column("FAPurchaseOrderStockAddresssInfo")]
    [StringLength(255)]
    public string FapurchaseOrderStockAddresssInfo { get; set; }

    [Column("FAPurchaseOrderStockAddresssCarZip")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddresssCarZip { get; set; }

    [Column("FAPurchaseOrderStockAddressILNNumber")]
    [StringLength(50)]
    public string FapurchaseOrderStockAddressIlnnumber { get; set; }

    [Column("FAPurchaseOrderSearchString1")]
    [StringLength(50)]
    public string FapurchaseOrderSearchString1 { get; set; }

    [Column("FAPurchaseOrderSearchString2")]
    [StringLength(50)]
    public string FapurchaseOrderSearchString2 { get; set; }

    [Column("FAPurchaseOrderSearchString3")]
    [StringLength(50)]
    public string FapurchaseOrderSearchString3 { get; set; }

    [Column("FAPurchaseOrderKalkuExcel1")]
    [StringLength(50)]
    public string FapurchaseOrderKalkuExcel1 { get; set; }

    [Column("FAPurchaseOrderKalkuExcel2")]
    [StringLength(50)]
    public string FapurchaseOrderKalkuExcel2 { get; set; }

    [Column("FAPurchaseOrderShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderShippingFees { get; set; }

    [Column("FAPurchaseOrderShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderShippingExtraFees { get; set; }

    [Column("FAPurchaseOrderShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderShippingInsuranceFees { get; set; }

    [Column("FAPurchaseOrderShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderShippingPackagingFees { get; set; }

    [Column("FAPurchaseOrderShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderShippingReservedFees1 { get; set; }

    [Column("FAPurchaseOrderShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderShippingReservedFees2 { get; set; }

    [Column("FAPurchaseOrderShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderShippingReservedFees3 { get; set; }

    [Column("FAPurchaseOrderShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? FapurchaseOrderShippingReservedFees4 { get; set; }

    [Column("FAPurchaseOrderShippingMethodDesc")]
    [StringLength(255)]
    public string FapurchaseOrderShippingMethodDesc { get; set; }

    [Column("FAPurchaseOrderShippingMethodName")]
    [StringLength(50)]
    public string FapurchaseOrderShippingMethodName { get; set; }

    [Column("NEWFAPurchaseOrder")]
    public int? NewfapurchaseOrder { get; set; }

    [ForeignKey("FacurrencyIdcombo")]
    [InverseProperty("FapurchaseOrders")]
    public virtual Gecurrency FacurrencyIdcomboNavigation { get; set; }

    [ForeignKey("FalanguageIdcombo")]
    [InverseProperty("FapurchaseOrders")]
    public virtual Gelanguage FalanguageIdcomboNavigation { get; set; }

    [InverseProperty("FapurchaseOrder")]
    public virtual ICollection<FapurchaseOrderContact> FapurchaseOrderContacts { get; set; } = new List<FapurchaseOrderContact>();

    [InverseProperty("FapurchaseOrder")]
    public virtual ICollection<FapurchaseOrderDiscount> FapurchaseOrderDiscounts { get; set; } = new List<FapurchaseOrderDiscount>();

    [InverseProperty("FapurchaseOrder")]
    public virtual ICollection<FapurchaseOrderHistory> FapurchaseOrderHistories { get; set; } = new List<FapurchaseOrderHistory>();

    [InverseProperty("FapurchaseOrder")]
    public virtual ICollection<FapurchaseOrderItem> FapurchaseOrderItems { get; set; } = new List<FapurchaseOrderItem>();

    [InverseProperty("FapurchaseOrder")]
    public virtual ICollection<FapurchaseOrderReceipt> FapurchaseOrderReceipts { get; set; } = new List<FapurchaseOrderReceipt>();

    [InverseProperty("FapurchaseOrder")]
    public virtual ICollection<FapurchaseOrderSellOrder> FapurchaseOrderSellOrders { get; set; } = new List<FapurchaseOrderSellOrder>();

    [ForeignKey("FashippingMethodId")]
    [InverseProperty("FapurchaseOrders")]
    public virtual GeshippingMethod FashippingMethod { get; set; }

    [ForeignKey("FastockIdcombo")]
    [InverseProperty("FapurchaseOrders")]
    public virtual Icstock FastockIdcomboNavigation { get; set; }

    [ForeignKey("FastockSlotIdcombo")]
    [InverseProperty("FapurchaseOrders")]
    public virtual IcstockSlot FastockSlotIdcomboNavigation { get; set; }

    [ForeignKey("FasupplierIdcombo")]
    [InverseProperty("FapurchaseOrders")]
    public virtual Apsupplier FasupplierIdcomboNavigation { get; set; }

    [ForeignKey("FavatregionIdcombo")]
    [InverseProperty("FapurchaseOrders")]
    public virtual Gevatregion FavatregionIdcomboNavigation { get; set; }
}
