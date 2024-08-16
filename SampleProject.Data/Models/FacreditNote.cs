using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FACreditNotes")]
public partial class FacreditNote
{
    [Key]
    [Column("FACreditNoteID")]
    public int FacreditNoteId { get; set; }

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

    [Column("FACreditNoteStatus")]
    [StringLength(100)]
    public string FacreditNoteStatus { get; set; }

    [Column("FACreditNoteSkonto")]
    [StringLength(50)]
    public string FacreditNoteSkonto { get; set; }

    [Column("FACreditNoteCustomerBonus", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteCustomerBonus { get; set; }

    [Column("FAPaymentMethodCombo")]
    [StringLength(50)]
    public string FapaymentMethodCombo { get; set; }

    [Column("FACreditNoteName")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteName { get; set; }

    [Column("FACreditNoteDesc")]
    [StringLength(500)]
    public string FacreditNoteDesc { get; set; }

    [Column("FACreditNoteText", TypeName = "ntext")]
    public string FacreditNoteText { get; set; }

    [Column("FACreditNoteCulture")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteCulture { get; set; }

    [Column("FACreditNoteStartDate", TypeName = "datetime")]
    public DateTime? FacreditNoteStartDate { get; set; }

    [Column("FACreditNoteValidateDate", TypeName = "datetime")]
    public DateTime? FacreditNoteValidateDate { get; set; }

    [Column("FACreditNoteDeliveryDate", TypeName = "datetime")]
    public DateTime? FacreditNoteDeliveryDate { get; set; }

    [Column("FACreditNoteDeliveryDate1", TypeName = "datetime")]
    public DateTime? FacreditNoteDeliveryDate1 { get; set; }

    [Column("FACreditNoteDeliveryDate2", TypeName = "datetime")]
    public DateTime? FacreditNoteDeliveryDate2 { get; set; }

    [Column("FACreditNoteIsDiscountPercentCheck")]
    public bool? FacreditNoteIsDiscountPercentCheck { get; set; }

    [Column("FACreditNoteDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteDiscountPerCent { get; set; }

    [Column("FACreditNoteDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteDiscountFix { get; set; }

    [Column("FACreditNoteOurReference")]
    [StringLength(150)]
    public string FacreditNoteOurReference { get; set; }

    [Column("FACreditNoteYourReference")]
    [StringLength(150)]
    public string FacreditNoteYourReference { get; set; }

    [Column("FACreditNoteRemark")]
    [StringLength(255)]
    public string FacreditNoteRemark { get; set; }

    [Column("FACreditNoteRemark1")]
    [StringLength(255)]
    public string FacreditNoteRemark1 { get; set; }

    [Column("FACreditNotePerson")]
    public int? FacreditNotePerson { get; set; }

    [Column("FACreditNoteQuantity")]
    public int? FacreditNoteQuantity { get; set; }

    [Column("FACreditNoteWeight", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteWeight { get; set; }

    [Column("FACreditNoteVolume", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteVolume { get; set; }

    [Column("FACreditNoteStornoCheck")]
    public bool? FacreditNoteStornoCheck { get; set; }

    [Column("FACreditNoteSaveStatusInSession")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteSaveStatusInSession { get; set; }

    [Column("FACreditNoteTaxNumberEWG")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteTaxNumberEwg { get; set; }

    [Column("FACreditNoteTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteTaxNumber { get; set; }

    [Column("FACreditNoteTaxNumberReserve")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteTaxNumberReserve { get; set; }

    [Column("FACreditNoteTypeCombo")]
    [StringLength(50)]
    public string FacreditNoteTypeCombo { get; set; }

    [Column("FACreditNoteMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode01Combo { get; set; }

    [Column("FACreditNoteMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode02Combo { get; set; }

    [Column("FACreditNoteMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode03Combo { get; set; }

    [Column("FACreditNoteMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode04Combo { get; set; }

    [Column("FACreditNoteMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode05Combo { get; set; }

    [Column("FACreditNoteMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode06Combo { get; set; }

    [Column("FACreditNoteMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode07Combo { get; set; }

    [Column("FACreditNoteMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode08Combo { get; set; }

    [Column("FACreditNoteMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode09Combo { get; set; }

    [Column("FACreditNoteMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode10Combo { get; set; }

    [Column("FACreditNoteMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode11Combo { get; set; }

    [Column("FACreditNoteMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteMatchCode12Combo { get; set; }

    [Column("FACreditNoteInfo", TypeName = "ntext")]
    public string FacreditNoteInfo { get; set; }

    [Column("FACreditNoteProject")]
    [StringLength(50)]
    public string FacreditNoteProject { get; set; }

    [Column("FACreditNoteInvoiceContactID")]
    public int? FacreditNoteInvoiceContactId { get; set; }

    [Column("FACreditNoteInvoiceContactName")]
    [StringLength(50)]
    public string FacreditNoteInvoiceContactName { get; set; }

    [Column("FACreditNoteInvoiceContactFirstName")]
    [StringLength(50)]
    public string FacreditNoteInvoiceContactFirstName { get; set; }

    [Column("FACreditNoteInvoiceContactLastName")]
    [StringLength(50)]
    public string FacreditNoteInvoiceContactLastName { get; set; }

    [Column("FACreditNoteInvoiceContactTitle")]
    [StringLength(50)]
    public string FacreditNoteInvoiceContactTitle { get; set; }

    [Column("FACreditNoteInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string FacreditNoteInvoiceContactHeaderLetter { get; set; }

    [Column("FACreditNoteInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string FacreditNoteInvoiceContactHeaderMessage { get; set; }

    [Column("FACreditNoteInvoiceContactEmail1")]
    [StringLength(100)]
    public string FacreditNoteInvoiceContactEmail1 { get; set; }

    [Column("FACreditNoteInvoiceContactEmail2")]
    [StringLength(100)]
    public string FacreditNoteInvoiceContactEmail2 { get; set; }

    [Column("FACreditNoteInvoiceContactWebsite")]
    [StringLength(100)]
    public string FacreditNoteInvoiceContactWebsite { get; set; }

    [Column("FACreditNoteInvoiceContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteInvoiceContactPhonePrivat { get; set; }

    [Column("FACreditNoteInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteInvoiceContactPhone { get; set; }

    [Column("FACreditNoteInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteInvoiceContactPhone1 { get; set; }

    [Column("FACreditNoteInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteInvoiceContactCellPhone { get; set; }

    [Column("FACreditNoteInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteInvoiceContactCellPhone1 { get; set; }

    [Column("FACreditNoteInvoiceContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteInvoiceContactCellPhonePrivat { get; set; }

    [Column("FACreditNoteInvoiceContactFax")]
    [StringLength(50)]
    public string FacreditNoteInvoiceContactFax { get; set; }

    [Column("FACreditNoteInvoiceContactType")]
    [StringLength(50)]
    public string FacreditNoteInvoiceContactType { get; set; }

    [Column("FACreditNoteInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FacreditNoteInvoiceContactInformation { get; set; }

    [Column("FACreditNoteInvoiceContactDepartment")]
    [StringLength(50)]
    public string FacreditNoteInvoiceContactDepartment { get; set; }

    [Column("FACreditNoteInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FacreditNoteInvoiceContactRoom { get; set; }

    [Column("FACreditNoteInvoiceContactImage")]
    public byte[] FacreditNoteInvoiceContactImage { get; set; }

    [Column("FACreditNoteInvoiceAddressName")]
    [StringLength(100)]
    public string FacreditNoteInvoiceAddressName { get; set; }

    [Column("FACreditNoteInvoiceAddressDesc1")]
    [StringLength(250)]
    public string FacreditNoteInvoiceAddressDesc1 { get; set; }

    [Column("FACreditNoteInvoiceAddressDesc2")]
    [StringLength(250)]
    public string FacreditNoteInvoiceAddressDesc2 { get; set; }

    [Column("FACreditNoteInvoiceAddressDesc3")]
    [StringLength(250)]
    public string FacreditNoteInvoiceAddressDesc3 { get; set; }

    [Column("FACreditNoteInvoiceAddressStreet")]
    [StringLength(200)]
    public string FacreditNoteInvoiceAddressStreet { get; set; }

    [Column("FACreditNoteInvoiceAddressHouseNumber")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressHouseNumber { get; set; }

    [Column("FACreditNoteInvoiceAddressCity")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressCity { get; set; }

    [Column("FACreditNoteInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressPostalCode { get; set; }

    [Column("FACreditNoteInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressStateProvince { get; set; }

    [Column("FACreditNoteInvoiceAddressZipCode")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressZipCode { get; set; }

    [Column("FACreditNoteInvoiceAddressCountry")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressCountry { get; set; }

    [Column("FACreditNoteInvoiceAddressEmail")]
    [StringLength(100)]
    public string FacreditNoteInvoiceAddressEmail { get; set; }

    [Column("FACreditNoteInvoiceAddressWebsite")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressWebsite { get; set; }

    [Column("FACreditNoteInvoiceAddressPhone")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressPhone { get; set; }

    [Column("FACreditNoteInvoiceAddresssFax")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddresssFax { get; set; }

    [Column("FACreditNoteInvoiceAddresssInfo")]
    [StringLength(255)]
    public string FacreditNoteInvoiceAddresssInfo { get; set; }

    [Column("FACreditNoteInvoiceAddresssCarZip")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddresssCarZip { get; set; }

    [Column("FACreditNoteInvoiceAddressILNNumber")]
    [StringLength(50)]
    public string FacreditNoteInvoiceAddressIlnnumber { get; set; }

    [Column("FACreditNoteCommandContactID")]
    public int? FacreditNoteCommandContactId { get; set; }

    [Column("FACreditNoteCommandContactName")]
    [StringLength(50)]
    public string FacreditNoteCommandContactName { get; set; }

    [Column("FACreditNoteCommandContactBirthday", TypeName = "datetime")]
    public DateTime? FacreditNoteCommandContactBirthday { get; set; }

    [Column("FACreditNoteCommandContactFirstName")]
    [StringLength(50)]
    public string FacreditNoteCommandContactFirstName { get; set; }

    [Column("FACreditNoteCommandContactLastName")]
    [StringLength(50)]
    public string FacreditNoteCommandContactLastName { get; set; }

    [Column("FACreditNoteCommandContactTitle")]
    [StringLength(50)]
    public string FacreditNoteCommandContactTitle { get; set; }

    [Column("FACreditNoteCommandContactHeaderLetter")]
    [StringLength(100)]
    public string FacreditNoteCommandContactHeaderLetter { get; set; }

    [Column("FACreditNoteCommandContactHeaderMessage")]
    [StringLength(255)]
    public string FacreditNoteCommandContactHeaderMessage { get; set; }

    [Column("FACreditNoteCommandContactEmail1")]
    [StringLength(100)]
    public string FacreditNoteCommandContactEmail1 { get; set; }

    [Column("FACreditNoteCommandContactEmail2")]
    [StringLength(100)]
    public string FacreditNoteCommandContactEmail2 { get; set; }

    [Column("FACreditNoteCommandContactWebsite")]
    [StringLength(100)]
    public string FacreditNoteCommandContactWebsite { get; set; }

    [Column("FACreditNoteCommandContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteCommandContactPhonePrivat { get; set; }

    [Column("FACreditNoteCommandContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteCommandContactPhone { get; set; }

    [Column("FACreditNoteCommandContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteCommandContactPhone1 { get; set; }

    [Column("FACreditNoteCommandContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteCommandContactCellPhone { get; set; }

    [Column("FACreditNoteCommandContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteCommandContactCellPhone1 { get; set; }

    [Column("FACreditNoteCommandContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteCommandContactCellPhonePrivat { get; set; }

    [Column("FACreditNoteCommandContactFax")]
    [StringLength(50)]
    public string FacreditNoteCommandContactFax { get; set; }

    [Column("FACreditNoteCommandContactType")]
    [StringLength(50)]
    public string FacreditNoteCommandContactType { get; set; }

    [Column("FACreditNoteCommandContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FacreditNoteCommandContactInformation { get; set; }

    [Column("FACreditNoteCommandContactDepartment")]
    [StringLength(50)]
    public string FacreditNoteCommandContactDepartment { get; set; }

    [Column("FACreditNoteCommandContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FacreditNoteCommandContactRoom { get; set; }

    [Column("FACreditNoteCommandContactImage")]
    public byte[] FacreditNoteCommandContactImage { get; set; }

    [Column("FACreditNoteCommandAddressName")]
    [StringLength(100)]
    public string FacreditNoteCommandAddressName { get; set; }

    [Column("FACreditNoteCommandAddressDesc1")]
    [StringLength(250)]
    public string FacreditNoteCommandAddressDesc1 { get; set; }

    [Column("FACreditNoteCommandAddressDesc2")]
    [StringLength(250)]
    public string FacreditNoteCommandAddressDesc2 { get; set; }

    [Column("FACreditNoteCommandAddressDesc3")]
    [StringLength(250)]
    public string FacreditNoteCommandAddressDesc3 { get; set; }

    [Column("FACreditNoteCommandAddressStreet")]
    [StringLength(200)]
    public string FacreditNoteCommandAddressStreet { get; set; }

    [Column("FACreditNoteCommandAddressHouseNumber")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressHouseNumber { get; set; }

    [Column("FACreditNoteCommandAddressCity")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressCity { get; set; }

    [Column("FACreditNoteCommandAddressPostalCode")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressPostalCode { get; set; }

    [Column("FACreditNoteCommandAddressStateProvince")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressStateProvince { get; set; }

    [Column("FACreditNoteCommandAddressZipCode")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressZipCode { get; set; }

    [Column("FACreditNoteCommandAddressCountry")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressCountry { get; set; }

    [Column("FACreditNoteCommandAddressEmail")]
    [StringLength(100)]
    public string FacreditNoteCommandAddressEmail { get; set; }

    [Column("FACreditNoteCommandAddressWebsite")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressWebsite { get; set; }

    [Column("FACreditNoteCommandAddressPhone")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressPhone { get; set; }

    [Column("FACreditNoteCommandAddresssFax")]
    [StringLength(50)]
    public string FacreditNoteCommandAddresssFax { get; set; }

    [Column("FACreditNoteCommandAddresssInfo")]
    [StringLength(255)]
    public string FacreditNoteCommandAddresssInfo { get; set; }

    [Column("FACreditNoteCommandAddresssCarZip")]
    [StringLength(50)]
    public string FacreditNoteCommandAddresssCarZip { get; set; }

    [Column("FACreditNoteCommandAddressILNNumber")]
    [StringLength(50)]
    public string FacreditNoteCommandAddressIlnnumber { get; set; }

    [Column("FACreditNoteDeliveryContactID")]
    public int? FacreditNoteDeliveryContactId { get; set; }

    [Column("FACreditNoteDeliveryContactName")]
    [StringLength(50)]
    public string FacreditNoteDeliveryContactName { get; set; }

    [Column("FACreditNoteDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? FacreditNoteDeliveryContactBirthday { get; set; }

    [Column("FACreditNoteDeliveryContactFirstName")]
    [StringLength(50)]
    public string FacreditNoteDeliveryContactFirstName { get; set; }

    [Column("FACreditNoteDeliveryContactLastName")]
    [StringLength(50)]
    public string FacreditNoteDeliveryContactLastName { get; set; }

    [Column("FACreditNoteDeliveryContactTitle")]
    [StringLength(50)]
    public string FacreditNoteDeliveryContactTitle { get; set; }

    [Column("FACreditNoteDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string FacreditNoteDeliveryContactHeaderLetter { get; set; }

    [Column("FACreditNoteDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string FacreditNoteDeliveryContactHeaderMessage { get; set; }

    [Column("FACreditNoteDeliveryContactEmail1")]
    [StringLength(100)]
    public string FacreditNoteDeliveryContactEmail1 { get; set; }

    [Column("FACreditNoteDeliveryContactEmail2")]
    [StringLength(100)]
    public string FacreditNoteDeliveryContactEmail2 { get; set; }

    [Column("FACreditNoteDeliveryContactWebsite")]
    [StringLength(100)]
    public string FacreditNoteDeliveryContactWebsite { get; set; }

    [Column("FACreditNoteDeliveryContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteDeliveryContactPhonePrivat { get; set; }

    [Column("FACreditNoteDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteDeliveryContactPhone { get; set; }

    [Column("FACreditNoteDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteDeliveryContactPhone1 { get; set; }

    [Column("FACreditNoteDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteDeliveryContactCellPhone { get; set; }

    [Column("FACreditNoteDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteDeliveryContactCellPhone1 { get; set; }

    [Column("FACreditNoteDeliveryContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacreditNoteDeliveryContactCellPhonePrivat { get; set; }

    [Column("FACreditNoteDeliveryContactFax")]
    [StringLength(50)]
    public string FacreditNoteDeliveryContactFax { get; set; }

    [Column("FACreditNoteDeliveryContactType")]
    [StringLength(50)]
    public string FacreditNoteDeliveryContactType { get; set; }

    [Column("FACreditNoteDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FacreditNoteDeliveryContactInformation { get; set; }

    [Column("FACreditNoteDeliveryContactDepartment")]
    [StringLength(50)]
    public string FacreditNoteDeliveryContactDepartment { get; set; }

    [Column("FACreditNoteDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FacreditNoteDeliveryContactRoom { get; set; }

    [Column("FACreditNoteDeliveryContactImage")]
    public byte[] FacreditNoteDeliveryContactImage { get; set; }

    [Column("FACreditNoteDeliveryAddressName")]
    [StringLength(100)]
    public string FacreditNoteDeliveryAddressName { get; set; }

    [Column("FACreditNoteDeliveryAddressDesc1")]
    [StringLength(250)]
    public string FacreditNoteDeliveryAddressDesc1 { get; set; }

    [Column("FACreditNoteDeliveryAddressDesc2")]
    [StringLength(250)]
    public string FacreditNoteDeliveryAddressDesc2 { get; set; }

    [Column("FACreditNoteDeliveryAddressDesc3")]
    [StringLength(250)]
    public string FacreditNoteDeliveryAddressDesc3 { get; set; }

    [Column("FACreditNoteDeliveryAddressStreet")]
    [StringLength(200)]
    public string FacreditNoteDeliveryAddressStreet { get; set; }

    [Column("FACreditNoteDeliveryAddressHouseNumber")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressHouseNumber { get; set; }

    [Column("FACreditNoteDeliveryAddressCity")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressCity { get; set; }

    [Column("FACreditNoteDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressPostalCode { get; set; }

    [Column("FACreditNoteDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressStateProvince { get; set; }

    [Column("FACreditNoteDeliveryAddressZipCode")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressZipCode { get; set; }

    [Column("FACreditNoteDeliveryAddressCountry")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressCountry { get; set; }

    [Column("FACreditNoteDeliveryAddressEmail")]
    [StringLength(100)]
    public string FacreditNoteDeliveryAddressEmail { get; set; }

    [Column("FACreditNoteDeliveryAddressWebsite")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressWebsite { get; set; }

    [Column("FACreditNoteDeliveryAddressPhone")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressPhone { get; set; }

    [Column("FACreditNoteDeliveryAddresssFax")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddresssFax { get; set; }

    [Column("FACreditNoteDeliveryAddresssInfo")]
    [StringLength(255)]
    public string FacreditNoteDeliveryAddresssInfo { get; set; }

    [Column("FACreditNoteDeliveryAddresssCarZip")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddresssCarZip { get; set; }

    [Column("FACreditNoteDeliveryAddressILNNumber")]
    [StringLength(50)]
    public string FacreditNoteDeliveryAddressIlnnumber { get; set; }

    [Column("FACreditNoteSearchString1")]
    [StringLength(50)]
    public string FacreditNoteSearchString1 { get; set; }

    [Column("FACreditNoteSearchString2")]
    [StringLength(50)]
    public string FacreditNoteSearchString2 { get; set; }

    [Column("FACreditNoteSearchString3")]
    [StringLength(50)]
    public string FacreditNoteSearchString3 { get; set; }

    [Column("FACreditNoteKalkuExcel1")]
    [StringLength(50)]
    public string FacreditNoteKalkuExcel1 { get; set; }

    [Column("FACreditNoteKalkuExcel2")]
    [StringLength(50)]
    public string FacreditNoteKalkuExcel2 { get; set; }

    [Column("FACreditNoteShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteShippingFees { get; set; }

    [Column("FACreditNoteShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteShippingExtraFees { get; set; }

    [Column("FACreditNoteShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteShippingInsuranceFees { get; set; }

    [Column("FACreditNoteShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteShippingPackagingFees { get; set; }

    [Column("FACreditNoteShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteShippingReservedFees1 { get; set; }

    [Column("FACreditNoteShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteShippingReservedFees2 { get; set; }

    [Column("FACreditNoteShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteShippingReservedFees3 { get; set; }

    [Column("FACreditNoteShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? FacreditNoteShippingReservedFees4 { get; set; }

    [Column("FACreditNoteShippingMethodDesc")]
    [StringLength(255)]
    public string FacreditNoteShippingMethodDesc { get; set; }

    [Column("FACreditNoteShippingMethodName")]
    [StringLength(50)]
    public string FacreditNoteShippingMethodName { get; set; }

    [Column("NEWFACreditNote")]
    public int? NewfacreditNote { get; set; }

    [InverseProperty("FacreditNote")]
    public virtual ICollection<FacreditNoteContact> FacreditNoteContacts { get; set; } = new List<FacreditNoteContact>();

    [InverseProperty("FacreditNote")]
    public virtual ICollection<FacreditNoteDiscount> FacreditNoteDiscounts { get; set; } = new List<FacreditNoteDiscount>();

    [InverseProperty("FacreditNote")]
    public virtual ICollection<FacreditNoteHistory> FacreditNoteHistories { get; set; } = new List<FacreditNoteHistory>();

    [InverseProperty("FacreditNote")]
    public virtual ICollection<FacreditNoteItem> FacreditNoteItems { get; set; } = new List<FacreditNoteItem>();

    [ForeignKey("FacurrencyIdcombo")]
    [InverseProperty("FacreditNotes")]
    public virtual Gecurrency FacurrencyIdcomboNavigation { get; set; }

    [ForeignKey("FacustomerIdcombo")]
    [InverseProperty("FacreditNotes")]
    public virtual Arcustomer FacustomerIdcomboNavigation { get; set; }

    [InverseProperty("FacreditNote")]
    public virtual ICollection<FainvoiceCreditNote> FainvoiceCreditNotes { get; set; } = new List<FainvoiceCreditNote>();

    [ForeignKey("FalanguageIdcombo")]
    [InverseProperty("FacreditNotes")]
    public virtual Gelanguage FalanguageIdcomboNavigation { get; set; }

    [InverseProperty("FacreditNote")]
    public virtual ICollection<FareceiptCreditNote> FareceiptCreditNotes { get; set; } = new List<FareceiptCreditNote>();

    [ForeignKey("FasellerIdcombo")]
    [InverseProperty("FacreditNotes")]
    public virtual Arseller FasellerIdcomboNavigation { get; set; }

    [ForeignKey("FashippingMethodId")]
    [InverseProperty("FacreditNotes")]
    public virtual GeshippingMethod FashippingMethod { get; set; }

    [ForeignKey("FavatregionIdcombo")]
    [InverseProperty("FacreditNotes")]
    public virtual Gevatregion FavatregionIdcomboNavigation { get; set; }
}
