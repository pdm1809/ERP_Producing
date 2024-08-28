using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellReturns")]
public partial class FasellReturn
{
    [Key]
    [Column("FASellReturnID")]
    public int FasellReturnId { get; set; }

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

    [Column("FACustomerIDCombo")]
    public int? FacustomerIdcombo { get; set; }

    [Column("FAShippingMethodID")]
    public int? FashippingMethodId { get; set; }

    [Column("FAVATRegionIDCombo")]
    public int? FavatregionIdcombo { get; set; }

    [Column("FASellerIDCombo")]
    public int? FasellerIdcombo { get; set; }

    [Column("FASellerProvisionFix", TypeName = "decimal(18, 5)")]
    public decimal? FasellerProvisionFix { get; set; }

    [Column("FASellerProvisionPerCent", TypeName = "decimal(18, 5)")]
    public decimal? FasellerProvisionPerCent { get; set; }

    [Column("FASellPriceCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellPriceCombo { get; set; }

    [Column("FASellReturnStatus")]
    [StringLength(100)]
    public string FasellReturnStatus { get; set; }

    [Column("FASellReturnSkonto")]
    [StringLength(50)]
    public string FasellReturnSkonto { get; set; }

    [Column("FASellReturnCustomerBonus", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnCustomerBonus { get; set; }

    [Column("FAPaymentMethodCombo")]
    [StringLength(50)]
    public string FapaymentMethodCombo { get; set; }

    [Column("FASellReturnName")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnName { get; set; }

    [Column("FASellReturnDesc")]
    [StringLength(500)]
    public string FasellReturnDesc { get; set; }

    [Column("FASellReturnText", TypeName = "ntext")]
    public string FasellReturnText { get; set; }

    [Column("FASellReturnCulture")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnCulture { get; set; }

    [Column("FASellReturnStartDate", TypeName = "datetime")]
    public DateTime? FasellReturnStartDate { get; set; }

    [Column("FASellReturnValidateDate", TypeName = "datetime")]
    public DateTime? FasellReturnValidateDate { get; set; }

    [Column("FASellReturnDeliveryDate", TypeName = "datetime")]
    public DateTime? FasellReturnDeliveryDate { get; set; }

    [Column("FASellReturnDeliveryDate1", TypeName = "datetime")]
    public DateTime? FasellReturnDeliveryDate1 { get; set; }

    [Column("FASellReturnDeliveryDate2", TypeName = "datetime")]
    public DateTime? FasellReturnDeliveryDate2 { get; set; }

    [Column("FASellReturnIsDiscountPercentCheck")]
    public bool? FasellReturnIsDiscountPercentCheck { get; set; }

    [Column("FASellReturnDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnDiscountPerCent { get; set; }

    [Column("FASellReturnDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnDiscountFix { get; set; }

    [Column("FASellReturnOurReference")]
    [StringLength(150)]
    public string FasellReturnOurReference { get; set; }

    [Column("FASellReturnYourReference")]
    [StringLength(150)]
    public string FasellReturnYourReference { get; set; }

    [Column("FASellReturnRemark")]
    [StringLength(255)]
    public string FasellReturnRemark { get; set; }

    [Column("FASellReturnRemark1")]
    [StringLength(255)]
    public string FasellReturnRemark1 { get; set; }

    [Column("FASellReturnPerson")]
    public int? FasellReturnPerson { get; set; }

    [Column("FASellReturnQuantity")]
    public int? FasellReturnQuantity { get; set; }

    [Column("FASellReturnWeight", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnWeight { get; set; }

    [Column("FASellReturnVolume", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnVolume { get; set; }

    [Column("FASellReturnStornoCheck")]
    public bool? FasellReturnStornoCheck { get; set; }

    [Column("FASellReturnSaveStatusInSession")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnSaveStatusInSession { get; set; }

    [Column("FASellReturnTaxNumberEWG")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnTaxNumberEwg { get; set; }

    [Column("FASellReturnTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnTaxNumber { get; set; }

    [Column("FASellReturnTaxNumberReserve")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnTaxNumberReserve { get; set; }

    [Column("FASellReturnTypeCombo")]
    [StringLength(50)]
    public string FasellReturnTypeCombo { get; set; }

    [Column("FASellReturnMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode01Combo { get; set; }

    [Column("FASellReturnMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode02Combo { get; set; }

    [Column("FASellReturnMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode03Combo { get; set; }

    [Column("FASellReturnMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode04Combo { get; set; }

    [Column("FASellReturnMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode05Combo { get; set; }

    [Column("FASellReturnMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode06Combo { get; set; }

    [Column("FASellReturnMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode07Combo { get; set; }

    [Column("FASellReturnMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode08Combo { get; set; }

    [Column("FASellReturnMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode09Combo { get; set; }

    [Column("FASellReturnMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode10Combo { get; set; }

    [Column("FASellReturnMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode11Combo { get; set; }

    [Column("FASellReturnMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnMatchCode12Combo { get; set; }

    [Column("FASellReturnInfo", TypeName = "ntext")]
    public string FasellReturnInfo { get; set; }

    [Column("FASellReturnProject")]
    [StringLength(50)]
    public string FasellReturnProject { get; set; }

    [Column("FASellReturnInvoiceContactID")]
    public int? FasellReturnInvoiceContactId { get; set; }

    [Column("FASellReturnInvoiceContactName")]
    [StringLength(50)]
    public string FasellReturnInvoiceContactName { get; set; }

    [Column("FASellReturnInvoiceContactFirstName")]
    [StringLength(50)]
    public string FasellReturnInvoiceContactFirstName { get; set; }

    [Column("FASellReturnInvoiceContactLastName")]
    [StringLength(50)]
    public string FasellReturnInvoiceContactLastName { get; set; }

    [Column("FASellReturnInvoiceContactTitle")]
    [StringLength(50)]
    public string FasellReturnInvoiceContactTitle { get; set; }

    [Column("FASellReturnInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string FasellReturnInvoiceContactHeaderLetter { get; set; }

    [Column("FASellReturnInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string FasellReturnInvoiceContactHeaderMessage { get; set; }

    [Column("FASellReturnInvoiceContactEmail1")]
    [StringLength(100)]
    public string FasellReturnInvoiceContactEmail1 { get; set; }

    [Column("FASellReturnInvoiceContactEmail2")]
    [StringLength(100)]
    public string FasellReturnInvoiceContactEmail2 { get; set; }

    [Column("FASellReturnInvoiceContactWebsite")]
    [StringLength(100)]
    public string FasellReturnInvoiceContactWebsite { get; set; }

    [Column("FASellReturnInvoiceContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnInvoiceContactPhonePrivat { get; set; }

    [Column("FASellReturnInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnInvoiceContactPhone { get; set; }

    [Column("FASellReturnInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnInvoiceContactPhone1 { get; set; }

    [Column("FASellReturnInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnInvoiceContactCellPhone { get; set; }

    [Column("FASellReturnInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnInvoiceContactCellPhone1 { get; set; }

    [Column("FASellReturnInvoiceContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnInvoiceContactCellPhonePrivat { get; set; }

    [Column("FASellReturnInvoiceContactFax")]
    [StringLength(50)]
    public string FasellReturnInvoiceContactFax { get; set; }

    [Column("FASellReturnInvoiceContactType")]
    [StringLength(50)]
    public string FasellReturnInvoiceContactType { get; set; }

    [Column("FASellReturnInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FasellReturnInvoiceContactInformation { get; set; }

    [Column("FASellReturnInvoiceContactDepartment")]
    [StringLength(50)]
    public string FasellReturnInvoiceContactDepartment { get; set; }

    [Column("FASellReturnInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FasellReturnInvoiceContactRoom { get; set; }

    [Column("FASellReturnInvoiceContactImage")]
    public byte[] FasellReturnInvoiceContactImage { get; set; }

    [Column("FASellReturnInvoiceAddressName")]
    [StringLength(100)]
    public string FasellReturnInvoiceAddressName { get; set; }

    [Column("FASellReturnInvoiceAddressDesc1")]
    [StringLength(250)]
    public string FasellReturnInvoiceAddressDesc1 { get; set; }

    [Column("FASellReturnInvoiceAddressDesc2")]
    [StringLength(250)]
    public string FasellReturnInvoiceAddressDesc2 { get; set; }

    [Column("FASellReturnInvoiceAddressDesc3")]
    [StringLength(250)]
    public string FasellReturnInvoiceAddressDesc3 { get; set; }

    [Column("FASellReturnInvoiceAddressStreet")]
    [StringLength(200)]
    public string FasellReturnInvoiceAddressStreet { get; set; }

    [Column("FASellReturnInvoiceAddressHouseNumber")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressHouseNumber { get; set; }

    [Column("FASellReturnInvoiceAddressCity")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressCity { get; set; }

    [Column("FASellReturnInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressPostalCode { get; set; }

    [Column("FASellReturnInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressStateProvince { get; set; }

    [Column("FASellReturnInvoiceAddressZipCode")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressZipCode { get; set; }

    [Column("FASellReturnInvoiceAddressCountry")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressCountry { get; set; }

    [Column("FASellReturnInvoiceAddressEmail")]
    [StringLength(100)]
    public string FasellReturnInvoiceAddressEmail { get; set; }

    [Column("FASellReturnInvoiceAddressWebsite")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressWebsite { get; set; }

    [Column("FASellReturnInvoiceAddressPhone")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressPhone { get; set; }

    [Column("FASellReturnInvoiceAddresssFax")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddresssFax { get; set; }

    [Column("FASellReturnInvoiceAddresssInfo")]
    [StringLength(255)]
    public string FasellReturnInvoiceAddresssInfo { get; set; }

    [Column("FASellReturnInvoiceAddresssCarZip")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddresssCarZip { get; set; }

    [Column("FASellReturnInvoiceAddressILNNumber")]
    [StringLength(50)]
    public string FasellReturnInvoiceAddressIlnnumber { get; set; }

    [Column("FASellReturnCommandContactID")]
    public int? FasellReturnCommandContactId { get; set; }

    [Column("FASellReturnCommandContactName")]
    [StringLength(50)]
    public string FasellReturnCommandContactName { get; set; }

    [Column("FASellReturnCommandContactBirthday", TypeName = "datetime")]
    public DateTime? FasellReturnCommandContactBirthday { get; set; }

    [Column("FASellReturnCommandContactFirstName")]
    [StringLength(50)]
    public string FasellReturnCommandContactFirstName { get; set; }

    [Column("FASellReturnCommandContactLastName")]
    [StringLength(50)]
    public string FasellReturnCommandContactLastName { get; set; }

    [Column("FASellReturnCommandContactTitle")]
    [StringLength(50)]
    public string FasellReturnCommandContactTitle { get; set; }

    [Column("FASellReturnCommandContactHeaderLetter")]
    [StringLength(100)]
    public string FasellReturnCommandContactHeaderLetter { get; set; }

    [Column("FASellReturnCommandContactHeaderMessage")]
    [StringLength(255)]
    public string FasellReturnCommandContactHeaderMessage { get; set; }

    [Column("FASellReturnCommandContactEmail1")]
    [StringLength(100)]
    public string FasellReturnCommandContactEmail1 { get; set; }

    [Column("FASellReturnCommandContactEmail2")]
    [StringLength(100)]
    public string FasellReturnCommandContactEmail2 { get; set; }

    [Column("FASellReturnCommandContactWebsite")]
    [StringLength(100)]
    public string FasellReturnCommandContactWebsite { get; set; }

    [Column("FASellReturnCommandContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnCommandContactPhonePrivat { get; set; }

    [Column("FASellReturnCommandContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnCommandContactPhone { get; set; }

    [Column("FASellReturnCommandContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnCommandContactPhone1 { get; set; }

    [Column("FASellReturnCommandContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnCommandContactCellPhone { get; set; }

    [Column("FASellReturnCommandContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnCommandContactCellPhone1 { get; set; }

    [Column("FASellReturnCommandContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnCommandContactCellPhonePrivat { get; set; }

    [Column("FASellReturnCommandContactFax")]
    [StringLength(50)]
    public string FasellReturnCommandContactFax { get; set; }

    [Column("FASellReturnCommandContactType")]
    [StringLength(50)]
    public string FasellReturnCommandContactType { get; set; }

    [Column("FASellReturnCommandContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FasellReturnCommandContactInformation { get; set; }

    [Column("FASellReturnCommandContactDepartment")]
    [StringLength(50)]
    public string FasellReturnCommandContactDepartment { get; set; }

    [Column("FASellReturnCommandContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FasellReturnCommandContactRoom { get; set; }

    [Column("FASellReturnCommandContactImage")]
    public byte[] FasellReturnCommandContactImage { get; set; }

    [Column("FASellReturnCommandAddressName")]
    [StringLength(100)]
    public string FasellReturnCommandAddressName { get; set; }

    [Column("FASellReturnCommandAddressDesc1")]
    [StringLength(250)]
    public string FasellReturnCommandAddressDesc1 { get; set; }

    [Column("FASellReturnCommandAddressDesc2")]
    [StringLength(250)]
    public string FasellReturnCommandAddressDesc2 { get; set; }

    [Column("FASellReturnCommandAddressDesc3")]
    [StringLength(250)]
    public string FasellReturnCommandAddressDesc3 { get; set; }

    [Column("FASellReturnCommandAddressStreet")]
    [StringLength(200)]
    public string FasellReturnCommandAddressStreet { get; set; }

    [Column("FASellReturnCommandAddressHouseNumber")]
    [StringLength(50)]
    public string FasellReturnCommandAddressHouseNumber { get; set; }

    [Column("FASellReturnCommandAddressCity")]
    [StringLength(50)]
    public string FasellReturnCommandAddressCity { get; set; }

    [Column("FASellReturnCommandAddressPostalCode")]
    [StringLength(50)]
    public string FasellReturnCommandAddressPostalCode { get; set; }

    [Column("FASellReturnCommandAddressStateProvince")]
    [StringLength(50)]
    public string FasellReturnCommandAddressStateProvince { get; set; }

    [Column("FASellReturnCommandAddressZipCode")]
    [StringLength(50)]
    public string FasellReturnCommandAddressZipCode { get; set; }

    [Column("FASellReturnCommandAddressCountry")]
    [StringLength(50)]
    public string FasellReturnCommandAddressCountry { get; set; }

    [Column("FASellReturnCommandAddressEmail")]
    [StringLength(100)]
    public string FasellReturnCommandAddressEmail { get; set; }

    [Column("FASellReturnCommandAddressWebsite")]
    [StringLength(50)]
    public string FasellReturnCommandAddressWebsite { get; set; }

    [Column("FASellReturnCommandAddressPhone")]
    [StringLength(50)]
    public string FasellReturnCommandAddressPhone { get; set; }

    [Column("FASellReturnCommandAddresssFax")]
    [StringLength(50)]
    public string FasellReturnCommandAddresssFax { get; set; }

    [Column("FASellReturnCommandAddresssInfo")]
    [StringLength(255)]
    public string FasellReturnCommandAddresssInfo { get; set; }

    [Column("FASellReturnCommandAddresssCarZip")]
    [StringLength(50)]
    public string FasellReturnCommandAddresssCarZip { get; set; }

    [Column("FASellReturnCommandAddressILNNumber")]
    [StringLength(50)]
    public string FasellReturnCommandAddressIlnnumber { get; set; }

    [Column("FASellReturnDeliveryContactID")]
    public int? FasellReturnDeliveryContactId { get; set; }

    [Column("FASellReturnDeliveryContactName")]
    [StringLength(50)]
    public string FasellReturnDeliveryContactName { get; set; }

    [Column("FASellReturnDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? FasellReturnDeliveryContactBirthday { get; set; }

    [Column("FASellReturnDeliveryContactFirstName")]
    [StringLength(50)]
    public string FasellReturnDeliveryContactFirstName { get; set; }

    [Column("FASellReturnDeliveryContactLastName")]
    [StringLength(50)]
    public string FasellReturnDeliveryContactLastName { get; set; }

    [Column("FASellReturnDeliveryContactTitle")]
    [StringLength(50)]
    public string FasellReturnDeliveryContactTitle { get; set; }

    [Column("FASellReturnDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string FasellReturnDeliveryContactHeaderLetter { get; set; }

    [Column("FASellReturnDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string FasellReturnDeliveryContactHeaderMessage { get; set; }

    [Column("FASellReturnDeliveryContactEmail1")]
    [StringLength(100)]
    public string FasellReturnDeliveryContactEmail1 { get; set; }

    [Column("FASellReturnDeliveryContactEmail2")]
    [StringLength(100)]
    public string FasellReturnDeliveryContactEmail2 { get; set; }

    [Column("FASellReturnDeliveryContactWebsite")]
    [StringLength(100)]
    public string FasellReturnDeliveryContactWebsite { get; set; }

    [Column("FASellReturnDeliveryContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnDeliveryContactPhonePrivat { get; set; }

    [Column("FASellReturnDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnDeliveryContactPhone { get; set; }

    [Column("FASellReturnDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnDeliveryContactPhone1 { get; set; }

    [Column("FASellReturnDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnDeliveryContactCellPhone { get; set; }

    [Column("FASellReturnDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnDeliveryContactCellPhone1 { get; set; }

    [Column("FASellReturnDeliveryContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FasellReturnDeliveryContactCellPhonePrivat { get; set; }

    [Column("FASellReturnDeliveryContactFax")]
    [StringLength(50)]
    public string FasellReturnDeliveryContactFax { get; set; }

    [Column("FASellReturnDeliveryContactType")]
    [StringLength(50)]
    public string FasellReturnDeliveryContactType { get; set; }

    [Column("FASellReturnDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FasellReturnDeliveryContactInformation { get; set; }

    [Column("FASellReturnDeliveryContactDepartment")]
    [StringLength(50)]
    public string FasellReturnDeliveryContactDepartment { get; set; }

    [Column("FASellReturnDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FasellReturnDeliveryContactRoom { get; set; }

    [Column("FASellReturnDeliveryContactImage")]
    public byte[] FasellReturnDeliveryContactImage { get; set; }

    [Column("FASellReturnDeliveryAddressName")]
    [StringLength(100)]
    public string FasellReturnDeliveryAddressName { get; set; }

    [Column("FASellReturnDeliveryAddressDesc1")]
    [StringLength(250)]
    public string FasellReturnDeliveryAddressDesc1 { get; set; }

    [Column("FASellReturnDeliveryAddressDesc2")]
    [StringLength(250)]
    public string FasellReturnDeliveryAddressDesc2 { get; set; }

    [Column("FASellReturnDeliveryAddressDesc3")]
    [StringLength(250)]
    public string FasellReturnDeliveryAddressDesc3 { get; set; }

    [Column("FASellReturnDeliveryAddressStreet")]
    [StringLength(200)]
    public string FasellReturnDeliveryAddressStreet { get; set; }

    [Column("FASellReturnDeliveryAddressHouseNumber")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressHouseNumber { get; set; }

    [Column("FASellReturnDeliveryAddressCity")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressCity { get; set; }

    [Column("FASellReturnDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressPostalCode { get; set; }

    [Column("FASellReturnDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressStateProvince { get; set; }

    [Column("FASellReturnDeliveryAddressZipCode")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressZipCode { get; set; }

    [Column("FASellReturnDeliveryAddressCountry")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressCountry { get; set; }

    [Column("FASellReturnDeliveryAddressEmail")]
    [StringLength(100)]
    public string FasellReturnDeliveryAddressEmail { get; set; }

    [Column("FASellReturnDeliveryAddressWebsite")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressWebsite { get; set; }

    [Column("FASellReturnDeliveryAddressPhone")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressPhone { get; set; }

    [Column("FASellReturnDeliveryAddresssFax")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddresssFax { get; set; }

    [Column("FASellReturnDeliveryAddresssInfo")]
    [StringLength(255)]
    public string FasellReturnDeliveryAddresssInfo { get; set; }

    [Column("FASellReturnDeliveryAddresssCarZip")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddresssCarZip { get; set; }

    [Column("FASellReturnDeliveryAddressILNNumber")]
    [StringLength(50)]
    public string FasellReturnDeliveryAddressIlnnumber { get; set; }

    [Column("FASellReturnSearchString1")]
    [StringLength(50)]
    public string FasellReturnSearchString1 { get; set; }

    [Column("FASellReturnSearchString2")]
    [StringLength(50)]
    public string FasellReturnSearchString2 { get; set; }

    [Column("FASellReturnSearchString3")]
    [StringLength(50)]
    public string FasellReturnSearchString3 { get; set; }

    [Column("FASellReturnKalkuExcel1")]
    [StringLength(50)]
    public string FasellReturnKalkuExcel1 { get; set; }

    [Column("FASellReturnKalkuExcel2")]
    [StringLength(50)]
    public string FasellReturnKalkuExcel2 { get; set; }

    [Column("FASellReturnShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnShippingFees { get; set; }

    [Column("FASellReturnShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnShippingExtraFees { get; set; }

    [Column("FASellReturnShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnShippingInsuranceFees { get; set; }

    [Column("FASellReturnShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnShippingPackagingFees { get; set; }

    [Column("FASellReturnShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnShippingReservedFees1 { get; set; }

    [Column("FASellReturnShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnShippingReservedFees2 { get; set; }

    [Column("FASellReturnShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnShippingReservedFees3 { get; set; }

    [Column("FASellReturnShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? FasellReturnShippingReservedFees4 { get; set; }

    [Column("FASellReturnShippingMethodDesc")]
    [StringLength(255)]
    public string FasellReturnShippingMethodDesc { get; set; }

    [Column("FASellReturnShippingMethodName")]
    [StringLength(50)]
    public string FasellReturnShippingMethodName { get; set; }

    [Column("NEWFASellReturn")]
    public int? NewfasellReturn { get; set; }

    [ForeignKey("FacurrencyIdcombo")]
    [InverseProperty("FasellReturns")]
    public virtual Gecurrency FacurrencyIdcomboNavigation { get; set; }

    [ForeignKey("FacustomerIdcombo")]
    [InverseProperty("FasellReturns")]
    public virtual Arcustomer FacustomerIdcomboNavigation { get; set; }

    [InverseProperty("FasellReturn")]
    public virtual ICollection<FainvoiceSellReturn> FainvoiceSellReturns { get; set; } = new List<FainvoiceSellReturn>();

    [ForeignKey("FalanguageIdcombo")]
    [InverseProperty("FasellReturns")]
    public virtual Gelanguage FalanguageIdcomboNavigation { get; set; }

    [InverseProperty("FasellReturn")]
    public virtual ICollection<FasellReturnContact> FasellReturnContacts { get; set; } = new List<FasellReturnContact>();

    [InverseProperty("FasellReturn")]
    public virtual ICollection<FasellReturnDiscount> FasellReturnDiscounts { get; set; } = new List<FasellReturnDiscount>();

    [InverseProperty("FasellReturn")]
    public virtual ICollection<FasellReturnHistory> FasellReturnHistories { get; set; } = new List<FasellReturnHistory>();

    [InverseProperty("FasellReturn")]
    public virtual ICollection<FasellReturnItem> FasellReturnItems { get; set; } = new List<FasellReturnItem>();

    [InverseProperty("FasellReturn")]
    public virtual ICollection<FasellReturnReceipt> FasellReturnReceipts { get; set; } = new List<FasellReturnReceipt>();

    [ForeignKey("FasellerIdcombo")]
    [InverseProperty("FasellReturns")]
    public virtual Arseller FasellerIdcomboNavigation { get; set; }

    [ForeignKey("FavatregionIdcombo")]
    [InverseProperty("FasellReturns")]
    public virtual Gevatregion FavatregionIdcomboNavigation { get; set; }
}
