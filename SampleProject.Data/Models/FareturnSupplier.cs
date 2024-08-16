using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReturnSuppliers")]
public partial class FareturnSupplier
{
    [Key]
    [Column("FAReturnSupplierID")]
    public int FareturnSupplierId { get; set; }

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

    [Column("FAReturnSupplierStatus")]
    [StringLength(100)]
    public string FareturnSupplierStatus { get; set; }

    [Column("FAReturnSupplierSkonto")]
    [StringLength(50)]
    public string FareturnSupplierSkonto { get; set; }

    [Column("FAReturnSupplierCustomerBonus", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierCustomerBonus { get; set; }

    [Column("FAPaymentMethodCombo")]
    [StringLength(50)]
    public string FapaymentMethodCombo { get; set; }

    [Required]
    [Column("FAReturnSupplierName")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierName { get; set; }

    [Required]
    [Column("FAReturnSupplierDesc")]
    [StringLength(500)]
    public string FareturnSupplierDesc { get; set; }

    [Column("FAReturnSupplierText", TypeName = "ntext")]
    public string FareturnSupplierText { get; set; }

    [Column("FAReturnSupplierCulture")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierCulture { get; set; }

    [Column("FAReturnSupplierStartDate", TypeName = "datetime")]
    public DateTime FareturnSupplierStartDate { get; set; }

    [Column("FAReturnSupplierValidateDate", TypeName = "datetime")]
    public DateTime? FareturnSupplierValidateDate { get; set; }

    [Column("FAReturnSupplierDeliveryDate", TypeName = "datetime")]
    public DateTime? FareturnSupplierDeliveryDate { get; set; }

    [Column("FAReturnSupplierDeliveryDate1", TypeName = "datetime")]
    public DateTime? FareturnSupplierDeliveryDate1 { get; set; }

    [Column("FAReturnSupplierDeliveryDate2", TypeName = "datetime")]
    public DateTime? FareturnSupplierDeliveryDate2 { get; set; }

    [Column("FAReturnSupplierIsDiscountPercentCheck")]
    public bool? FareturnSupplierIsDiscountPercentCheck { get; set; }

    [Column("FAReturnSupplierDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierDiscountPerCent { get; set; }

    [Column("FAReturnSupplierDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierDiscountFix { get; set; }

    [Column("FAReturnSupplierOurReference")]
    [StringLength(150)]
    public string FareturnSupplierOurReference { get; set; }

    [Column("FAReturnSupplierYourReference")]
    [StringLength(150)]
    public string FareturnSupplierYourReference { get; set; }

    [Column("FAReturnSupplierRemark")]
    [StringLength(255)]
    public string FareturnSupplierRemark { get; set; }

    [Column("FAReturnSupplierRemark1")]
    [StringLength(255)]
    public string FareturnSupplierRemark1 { get; set; }

    [Column("FAReturnSupplierPerson")]
    public int? FareturnSupplierPerson { get; set; }

    [Column("FAReturnSupplierQuantity")]
    public int? FareturnSupplierQuantity { get; set; }

    [Column("FAReturnSupplierWeight", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierWeight { get; set; }

    [Column("FAReturnSupplierVolume", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierVolume { get; set; }

    [Column("FAReturnSupplierStornoCheck")]
    public bool? FareturnSupplierStornoCheck { get; set; }

    [Column("FAReturnSupplierSaveStatusInSession")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierSaveStatusInSession { get; set; }

    [Column("FAReturnSupplierTaxNumberEWG")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierTaxNumberEwg { get; set; }

    [Column("FAReturnSupplierTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierTaxNumber { get; set; }

    [Column("FAReturnSupplierTaxNumberReserve")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierTaxNumberReserve { get; set; }

    [Column("FAReturnSupplierTypeCombo")]
    [StringLength(50)]
    public string FareturnSupplierTypeCombo { get; set; }

    [Column("FAReturnSupplierMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode01Combo { get; set; }

    [Column("FAReturnSupplierMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode02Combo { get; set; }

    [Column("FAReturnSupplierMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode03Combo { get; set; }

    [Column("FAReturnSupplierMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode04Combo { get; set; }

    [Column("FAReturnSupplierMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode05Combo { get; set; }

    [Column("FAReturnSupplierMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode06Combo { get; set; }

    [Column("FAReturnSupplierMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode07Combo { get; set; }

    [Column("FAReturnSupplierMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode08Combo { get; set; }

    [Column("FAReturnSupplierMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode09Combo { get; set; }

    [Column("FAReturnSupplierMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode10Combo { get; set; }

    [Column("FAReturnSupplierMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode11Combo { get; set; }

    [Column("FAReturnSupplierMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierMatchCode12Combo { get; set; }

    [Column("FAReturnSupplierInfo", TypeName = "ntext")]
    public string FareturnSupplierInfo { get; set; }

    [Column("FAReturnSupplierProject")]
    [StringLength(50)]
    public string FareturnSupplierProject { get; set; }

    [Column("FAReturnSupplierInvoiceContactID")]
    public int? FareturnSupplierInvoiceContactId { get; set; }

    [Column("FAReturnSupplierInvoiceContactName")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceContactName { get; set; }

    [Column("FAReturnSupplierInvoiceContactFirstName")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceContactFirstName { get; set; }

    [Column("FAReturnSupplierInvoiceContactLastName")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceContactLastName { get; set; }

    [Column("FAReturnSupplierInvoiceContactTitle")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceContactTitle { get; set; }

    [Column("FAReturnSupplierInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string FareturnSupplierInvoiceContactHeaderLetter { get; set; }

    [Column("FAReturnSupplierInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string FareturnSupplierInvoiceContactHeaderMessage { get; set; }

    [Column("FAReturnSupplierInvoiceContactEmail1")]
    [StringLength(100)]
    public string FareturnSupplierInvoiceContactEmail1 { get; set; }

    [Column("FAReturnSupplierInvoiceContactEmail2")]
    [StringLength(100)]
    public string FareturnSupplierInvoiceContactEmail2 { get; set; }

    [Column("FAReturnSupplierInvoiceContactWebsite")]
    [StringLength(100)]
    public string FareturnSupplierInvoiceContactWebsite { get; set; }

    [Column("FAReturnSupplierInvoiceContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierInvoiceContactPhonePrivat { get; set; }

    [Column("FAReturnSupplierInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierInvoiceContactPhone { get; set; }

    [Column("FAReturnSupplierInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierInvoiceContactPhone1 { get; set; }

    [Column("FAReturnSupplierInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierInvoiceContactCellPhone { get; set; }

    [Column("FAReturnSupplierInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierInvoiceContactCellPhone1 { get; set; }

    [Column("FAReturnSupplierInvoiceContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierInvoiceContactCellPhonePrivat { get; set; }

    [Column("FAReturnSupplierInvoiceContactFax")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceContactFax { get; set; }

    [Column("FAReturnSupplierInvoiceContactType")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceContactType { get; set; }

    [Column("FAReturnSupplierInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FareturnSupplierInvoiceContactInformation { get; set; }

    [Column("FAReturnSupplierInvoiceContactDepartment")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceContactDepartment { get; set; }

    [Column("FAReturnSupplierInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FareturnSupplierInvoiceContactRoom { get; set; }

    [Column("FAReturnSupplierInvoiceContactImage")]
    public byte[] FareturnSupplierInvoiceContactImage { get; set; }

    [Column("FAReturnSupplierInvoiceAddressName")]
    [StringLength(100)]
    public string FareturnSupplierInvoiceAddressName { get; set; }

    [Column("FAReturnSupplierInvoiceAddressDesc1")]
    [StringLength(250)]
    public string FareturnSupplierInvoiceAddressDesc1 { get; set; }

    [Column("FAReturnSupplierInvoiceAddressDesc2")]
    [StringLength(250)]
    public string FareturnSupplierInvoiceAddressDesc2 { get; set; }

    [Column("FAReturnSupplierInvoiceAddressDesc3")]
    [StringLength(250)]
    public string FareturnSupplierInvoiceAddressDesc3 { get; set; }

    [Column("FAReturnSupplierInvoiceAddressStreet")]
    [StringLength(200)]
    public string FareturnSupplierInvoiceAddressStreet { get; set; }

    [Column("FAReturnSupplierInvoiceAddressHouseNumber")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressHouseNumber { get; set; }

    [Column("FAReturnSupplierInvoiceAddressCity")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressCity { get; set; }

    [Column("FAReturnSupplierInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressPostalCode { get; set; }

    [Column("FAReturnSupplierInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressStateProvince { get; set; }

    [Column("FAReturnSupplierInvoiceAddressZipCode")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressZipCode { get; set; }

    [Column("FAReturnSupplierInvoiceAddressCountry")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressCountry { get; set; }

    [Column("FAReturnSupplierInvoiceAddressEmail")]
    [StringLength(100)]
    public string FareturnSupplierInvoiceAddressEmail { get; set; }

    [Column("FAReturnSupplierInvoiceAddressWebsite")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressWebsite { get; set; }

    [Column("FAReturnSupplierInvoiceAddressPhone")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressPhone { get; set; }

    [Column("FAReturnSupplierInvoiceAddresssFax")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddresssFax { get; set; }

    [Column("FAReturnSupplierInvoiceAddresssInfo")]
    [StringLength(255)]
    public string FareturnSupplierInvoiceAddresssInfo { get; set; }

    [Column("FAReturnSupplierInvoiceAddresssCarZip")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddresssCarZip { get; set; }

    [Column("FAReturnSupplierInvoiceAddressILNNumber")]
    [StringLength(50)]
    public string FareturnSupplierInvoiceAddressIlnnumber { get; set; }

    [Column("FAReturnSupplierCommandContactID")]
    public int? FareturnSupplierCommandContactId { get; set; }

    [Column("FAReturnSupplierCommandContactName")]
    [StringLength(50)]
    public string FareturnSupplierCommandContactName { get; set; }

    [Column("FAReturnSupplierCommandContactBirthday", TypeName = "datetime")]
    public DateTime? FareturnSupplierCommandContactBirthday { get; set; }

    [Column("FAReturnSupplierCommandContactFirstName")]
    [StringLength(50)]
    public string FareturnSupplierCommandContactFirstName { get; set; }

    [Column("FAReturnSupplierCommandContactLastName")]
    [StringLength(50)]
    public string FareturnSupplierCommandContactLastName { get; set; }

    [Column("FAReturnSupplierCommandContactTitle")]
    [StringLength(50)]
    public string FareturnSupplierCommandContactTitle { get; set; }

    [Column("FAReturnSupplierCommandContactHeaderLetter")]
    [StringLength(100)]
    public string FareturnSupplierCommandContactHeaderLetter { get; set; }

    [Column("FAReturnSupplierCommandContactHeaderMessage")]
    [StringLength(255)]
    public string FareturnSupplierCommandContactHeaderMessage { get; set; }

    [Column("FAReturnSupplierCommandContactEmail1")]
    [StringLength(100)]
    public string FareturnSupplierCommandContactEmail1 { get; set; }

    [Column("FAReturnSupplierCommandContactEmail2")]
    [StringLength(100)]
    public string FareturnSupplierCommandContactEmail2 { get; set; }

    [Column("FAReturnSupplierCommandContactWebsite")]
    [StringLength(100)]
    public string FareturnSupplierCommandContactWebsite { get; set; }

    [Column("FAReturnSupplierCommandContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierCommandContactPhonePrivat { get; set; }

    [Column("FAReturnSupplierCommandContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierCommandContactPhone { get; set; }

    [Column("FAReturnSupplierCommandContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierCommandContactPhone1 { get; set; }

    [Column("FAReturnSupplierCommandContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierCommandContactCellPhone { get; set; }

    [Column("FAReturnSupplierCommandContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierCommandContactCellPhone1 { get; set; }

    [Column("FAReturnSupplierCommandContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierCommandContactCellPhonePrivat { get; set; }

    [Column("FAReturnSupplierCommandContactFax")]
    [StringLength(50)]
    public string FareturnSupplierCommandContactFax { get; set; }

    [Column("FAReturnSupplierCommandContactType")]
    [StringLength(50)]
    public string FareturnSupplierCommandContactType { get; set; }

    [Column("FAReturnSupplierCommandContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FareturnSupplierCommandContactInformation { get; set; }

    [Column("FAReturnSupplierCommandContactDepartment")]
    [StringLength(50)]
    public string FareturnSupplierCommandContactDepartment { get; set; }

    [Column("FAReturnSupplierCommandContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FareturnSupplierCommandContactRoom { get; set; }

    [Column("FAReturnSupplierCommandContactImage")]
    public byte[] FareturnSupplierCommandContactImage { get; set; }

    [Column("FAReturnSupplierCommandAddressName")]
    [StringLength(100)]
    public string FareturnSupplierCommandAddressName { get; set; }

    [Column("FAReturnSupplierCommandAddressDesc1")]
    [StringLength(250)]
    public string FareturnSupplierCommandAddressDesc1 { get; set; }

    [Column("FAReturnSupplierCommandAddressDesc2")]
    [StringLength(250)]
    public string FareturnSupplierCommandAddressDesc2 { get; set; }

    [Column("FAReturnSupplierCommandAddressDesc3")]
    [StringLength(250)]
    public string FareturnSupplierCommandAddressDesc3 { get; set; }

    [Column("FAReturnSupplierCommandAddressStreet")]
    [StringLength(200)]
    public string FareturnSupplierCommandAddressStreet { get; set; }

    [Column("FAReturnSupplierCommandAddressHouseNumber")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressHouseNumber { get; set; }

    [Column("FAReturnSupplierCommandAddressCity")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressCity { get; set; }

    [Column("FAReturnSupplierCommandAddressPostalCode")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressPostalCode { get; set; }

    [Column("FAReturnSupplierCommandAddressStateProvince")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressStateProvince { get; set; }

    [Column("FAReturnSupplierCommandAddressZipCode")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressZipCode { get; set; }

    [Column("FAReturnSupplierCommandAddressCountry")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressCountry { get; set; }

    [Column("FAReturnSupplierCommandAddressEmail")]
    [StringLength(100)]
    public string FareturnSupplierCommandAddressEmail { get; set; }

    [Column("FAReturnSupplierCommandAddressWebsite")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressWebsite { get; set; }

    [Column("FAReturnSupplierCommandAddressPhone")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressPhone { get; set; }

    [Column("FAReturnSupplierCommandAddresssFax")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddresssFax { get; set; }

    [Column("FAReturnSupplierCommandAddresssInfo")]
    [StringLength(255)]
    public string FareturnSupplierCommandAddresssInfo { get; set; }

    [Column("FAReturnSupplierCommandAddresssCarZip")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddresssCarZip { get; set; }

    [Column("FAReturnSupplierCommandAddressILNNumber")]
    [StringLength(50)]
    public string FareturnSupplierCommandAddressIlnnumber { get; set; }

    [Column("FAReturnSupplierDeliveryContactID")]
    public int? FareturnSupplierDeliveryContactId { get; set; }

    [Column("FAReturnSupplierDeliveryContactName")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryContactName { get; set; }

    [Column("FAReturnSupplierDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? FareturnSupplierDeliveryContactBirthday { get; set; }

    [Column("FAReturnSupplierDeliveryContactFirstName")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryContactFirstName { get; set; }

    [Column("FAReturnSupplierDeliveryContactLastName")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryContactLastName { get; set; }

    [Column("FAReturnSupplierDeliveryContactTitle")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryContactTitle { get; set; }

    [Column("FAReturnSupplierDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string FareturnSupplierDeliveryContactHeaderLetter { get; set; }

    [Column("FAReturnSupplierDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string FareturnSupplierDeliveryContactHeaderMessage { get; set; }

    [Column("FAReturnSupplierDeliveryContactEmail1")]
    [StringLength(100)]
    public string FareturnSupplierDeliveryContactEmail1 { get; set; }

    [Column("FAReturnSupplierDeliveryContactEmail2")]
    [StringLength(100)]
    public string FareturnSupplierDeliveryContactEmail2 { get; set; }

    [Column("FAReturnSupplierDeliveryContactWebsite")]
    [StringLength(100)]
    public string FareturnSupplierDeliveryContactWebsite { get; set; }

    [Column("FAReturnSupplierDeliveryContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierDeliveryContactPhonePrivat { get; set; }

    [Column("FAReturnSupplierDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierDeliveryContactPhone { get; set; }

    [Column("FAReturnSupplierDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierDeliveryContactPhone1 { get; set; }

    [Column("FAReturnSupplierDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierDeliveryContactCellPhone { get; set; }

    [Column("FAReturnSupplierDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierDeliveryContactCellPhone1 { get; set; }

    [Column("FAReturnSupplierDeliveryContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FareturnSupplierDeliveryContactCellPhonePrivat { get; set; }

    [Column("FAReturnSupplierDeliveryContactFax")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryContactFax { get; set; }

    [Column("FAReturnSupplierDeliveryContactType")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryContactType { get; set; }

    [Column("FAReturnSupplierDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FareturnSupplierDeliveryContactInformation { get; set; }

    [Column("FAReturnSupplierDeliveryContactDepartment")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryContactDepartment { get; set; }

    [Column("FAReturnSupplierDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FareturnSupplierDeliveryContactRoom { get; set; }

    [Column("FAReturnSupplierDeliveryContactImage")]
    public byte[] FareturnSupplierDeliveryContactImage { get; set; }

    [Column("FAReturnSupplierDeliveryAddressName")]
    [StringLength(100)]
    public string FareturnSupplierDeliveryAddressName { get; set; }

    [Column("FAReturnSupplierDeliveryAddressDesc1")]
    [StringLength(250)]
    public string FareturnSupplierDeliveryAddressDesc1 { get; set; }

    [Column("FAReturnSupplierDeliveryAddressDesc2")]
    [StringLength(250)]
    public string FareturnSupplierDeliveryAddressDesc2 { get; set; }

    [Column("FAReturnSupplierDeliveryAddressDesc3")]
    [StringLength(250)]
    public string FareturnSupplierDeliveryAddressDesc3 { get; set; }

    [Column("FAReturnSupplierDeliveryAddressStreet")]
    [StringLength(200)]
    public string FareturnSupplierDeliveryAddressStreet { get; set; }

    [Column("FAReturnSupplierDeliveryAddressHouseNumber")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressHouseNumber { get; set; }

    [Column("FAReturnSupplierDeliveryAddressCity")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressCity { get; set; }

    [Column("FAReturnSupplierDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressPostalCode { get; set; }

    [Column("FAReturnSupplierDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressStateProvince { get; set; }

    [Column("FAReturnSupplierDeliveryAddressZipCode")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressZipCode { get; set; }

    [Column("FAReturnSupplierDeliveryAddressCountry")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressCountry { get; set; }

    [Column("FAReturnSupplierDeliveryAddressEmail")]
    [StringLength(100)]
    public string FareturnSupplierDeliveryAddressEmail { get; set; }

    [Column("FAReturnSupplierDeliveryAddressWebsite")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressWebsite { get; set; }

    [Column("FAReturnSupplierDeliveryAddressPhone")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressPhone { get; set; }

    [Column("FAReturnSupplierDeliveryAddresssFax")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddresssFax { get; set; }

    [Column("FAReturnSupplierDeliveryAddresssInfo")]
    [StringLength(255)]
    public string FareturnSupplierDeliveryAddresssInfo { get; set; }

    [Column("FAReturnSupplierDeliveryAddresssCarZip")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddresssCarZip { get; set; }

    [Column("FAReturnSupplierDeliveryAddressILNNumber")]
    [StringLength(50)]
    public string FareturnSupplierDeliveryAddressIlnnumber { get; set; }

    [Column("FAReturnSupplierSearchString1")]
    [StringLength(50)]
    public string FareturnSupplierSearchString1 { get; set; }

    [Column("FAReturnSupplierSearchString2")]
    [StringLength(50)]
    public string FareturnSupplierSearchString2 { get; set; }

    [Column("FAReturnSupplierSearchString3")]
    [StringLength(50)]
    public string FareturnSupplierSearchString3 { get; set; }

    [Column("FAReturnSupplierKalkuExcel1")]
    [StringLength(50)]
    public string FareturnSupplierKalkuExcel1 { get; set; }

    [Column("FAReturnSupplierKalkuExcel2")]
    [StringLength(50)]
    public string FareturnSupplierKalkuExcel2 { get; set; }

    [Column("FAReturnSupplierShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierShippingFees { get; set; }

    [Column("FAReturnSupplierShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierShippingExtraFees { get; set; }

    [Column("FAReturnSupplierShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierShippingInsuranceFees { get; set; }

    [Column("FAReturnSupplierShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierShippingPackagingFees { get; set; }

    [Column("FAReturnSupplierShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierShippingReservedFees1 { get; set; }

    [Column("FAReturnSupplierShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierShippingReservedFees2 { get; set; }

    [Column("FAReturnSupplierShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierShippingReservedFees3 { get; set; }

    [Column("FAReturnSupplierShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? FareturnSupplierShippingReservedFees4 { get; set; }

    [Column("FAReturnSupplierShippingMethodDesc")]
    [StringLength(255)]
    public string FareturnSupplierShippingMethodDesc { get; set; }

    [Column("FAReturnSupplierShippingMethodName")]
    [StringLength(50)]
    public string FareturnSupplierShippingMethodName { get; set; }

    [Column("NEWFAReturnSupplier")]
    [StringLength(10)]
    public string NewfareturnSupplier { get; set; }

    [ForeignKey("FacurrencyIdcombo")]
    [InverseProperty("FareturnSuppliers")]
    public virtual Gecurrency FacurrencyIdcomboNavigation { get; set; }

    [ForeignKey("FacustomerIdcombo")]
    [InverseProperty("FareturnSuppliers")]
    public virtual Arcustomer FacustomerIdcomboNavigation { get; set; }

    [ForeignKey("FalanguageIdcombo")]
    [InverseProperty("FareturnSuppliers")]
    public virtual Gelanguage FalanguageIdcomboNavigation { get; set; }

    [InverseProperty("FareturnSupplier")]
    public virtual ICollection<FareturnSupplierContact> FareturnSupplierContacts { get; set; } = new List<FareturnSupplierContact>();

    [InverseProperty("FareturnSupplier")]
    public virtual ICollection<FareturnSupplierHistory> FareturnSupplierHistories { get; set; } = new List<FareturnSupplierHistory>();

    [InverseProperty("FareturnSupplier")]
    public virtual ICollection<FareturnSupplierInvoice> FareturnSupplierInvoices { get; set; } = new List<FareturnSupplierInvoice>();

    [InverseProperty("FareturnSupplier")]
    public virtual ICollection<FareturnSupplierItem> FareturnSupplierItems { get; set; } = new List<FareturnSupplierItem>();

    [ForeignKey("FasellerIdcombo")]
    [InverseProperty("FareturnSuppliers")]
    public virtual Arseller FasellerIdcomboNavigation { get; set; }

    [ForeignKey("FashippingMethodId")]
    [InverseProperty("FareturnSuppliers")]
    public virtual GeshippingMethod FashippingMethod { get; set; }

    [ForeignKey("FavatregionIdcombo")]
    [InverseProperty("FareturnSuppliers")]
    public virtual Gevatregion FavatregionIdcomboNavigation { get; set; }
}
