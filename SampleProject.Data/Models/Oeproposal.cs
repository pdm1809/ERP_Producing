using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("OEProposals")]
[Microsoft.EntityFrameworkCore.Index("OeproposalTypeCombo", Name = "Idx_OEProposals")]
public partial class Oeproposal
{
    [Key]
    [Column("OEProposalID")]
    public int OeproposalId { get; set; }

    [Column("OEProposalName")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalName { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("GELanguageID")]
    public int GelanguageId { get; set; }

    [Column("GECurrencyID")]
    public int GecurrencyId { get; set; }

    [Column("ARCustomerID")]
    public int? ArcustomerId { get; set; }

    [Column("GEShippingMethodID")]
    public int? GeshippingMethodId { get; set; }

    [Column("GEVATRegionID")]
    public int? GevatregionId { get; set; }

    [Column("ARSellerID")]
    public int? ArsellerId { get; set; }

    [Column("OESellerProvisionFix", TypeName = "decimal(18, 5)")]
    public decimal? OesellerProvisionFix { get; set; }

    [Column("OESellerProvisionPercent", TypeName = "decimal(18, 5)")]
    public decimal? OesellerProvisionPercent { get; set; }

    [Column("OESellPriceCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OesellPriceCombo { get; set; }

    [Column("OEProposalStatus")]
    [StringLength(100)]
    public string OeproposalStatus { get; set; }

    [Column("OEProposalPaymentTerm")]
    [StringLength(50)]
    public string OeproposalPaymentTerm { get; set; }

    [Column("OEPaymentMethodCombo")]
    [StringLength(50)]
    public string OepaymentMethodCombo { get; set; }

    [Column("OEProposalDesc")]
    [StringLength(500)]
    public string OeproposalDesc { get; set; }

    [Column("OEProposalText", TypeName = "ntext")]
    public string OeproposalText { get; set; }

    [Column("OEProposalCulture")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalCulture { get; set; }

    [Column("OEProposalStartDate", TypeName = "datetime")]
    public DateTime? OeproposalStartDate { get; set; }

    [Column("OEProposalValidateDate", TypeName = "datetime")]
    public DateTime? OeproposalValidateDate { get; set; }

    [Column("OEProposalDeliveryDate", TypeName = "datetime")]
    public DateTime? OeproposalDeliveryDate { get; set; }

    [Column("OEProposalDeliveryDate1", TypeName = "datetime")]
    public DateTime? OeproposalDeliveryDate1 { get; set; }

    [Column("OEProposalDeliveryDate2", TypeName = "datetime")]
    public DateTime? OeproposalDeliveryDate2 { get; set; }

    [Column("OEProposalExpireDate", TypeName = "datetime")]
    public DateTime? OeproposalExpireDate { get; set; }

    [Column("OEProposalIsDiscountPercentCheck")]
    public bool? OeproposalIsDiscountPercentCheck { get; set; }

    [Column("OEProposalDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? OeproposalDiscountPercent { get; set; }

    [Column("OEProposalDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? OeproposalDiscountFix { get; set; }

    [Column("OEProposalOurReference")]
    [StringLength(150)]
    public string OeproposalOurReference { get; set; }

    [Column("OEProposalYourReference")]
    [StringLength(150)]
    public string OeproposalYourReference { get; set; }

    [Column("OEProposalRemark")]
    [StringLength(255)]
    public string OeproposalRemark { get; set; }

    [Column("OEProposalRemark1")]
    [StringLength(255)]
    public string OeproposalRemark1 { get; set; }

    [Column("OEProposalWeight", TypeName = "decimal(18, 5)")]
    public decimal? OeproposalWeight { get; set; }

    [Column("OEProposalVolume", TypeName = "decimal(18, 5)")]
    public decimal? OeproposalVolume { get; set; }

    [Column("OEProposalInactiveCheck")]
    public bool? OeproposalInactiveCheck { get; set; }

    [Column("OEProposalSaveStatusInSession")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalSaveStatusInSession { get; set; }

    [Column("FAProposalTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalTaxNumber { get; set; }

    [Column("OEProposalTypeCombo")]
    [StringLength(50)]
    public string OeproposalTypeCombo { get; set; }

    [Column("OEProposalMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode01Combo { get; set; }

    [Column("OEProposalMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode02Combo { get; set; }

    [Column("OEProposalMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode03Combo { get; set; }

    [Column("OEProposalMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode04Combo { get; set; }

    [Column("OEProposalMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode05Combo { get; set; }

    [Column("OEProposalMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode06Combo { get; set; }

    [Column("OEProposalMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode07Combo { get; set; }

    [Column("OEProposalMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode08Combo { get; set; }

    [Column("OEProposalMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode09Combo { get; set; }

    [Column("OEProposalMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode10Combo { get; set; }

    [Column("OEProposalMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode11Combo { get; set; }

    [Column("OEProposalMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string OeproposalMatchCode12Combo { get; set; }

    [Column("OEProposalInfo", TypeName = "ntext")]
    public string OeproposalInfo { get; set; }

    [Column("OEProposalProject")]
    [StringLength(50)]
    public string OeproposalProject { get; set; }

    [Column("FAProposalInvoiceContactID")]
    public int? FaproposalInvoiceContactId { get; set; }

    [Column("FAProposalInvoiceContactName")]
    [StringLength(50)]
    public string FaproposalInvoiceContactName { get; set; }

    [Column("FAProposalInvoiceContactFirstName")]
    [StringLength(50)]
    public string FaproposalInvoiceContactFirstName { get; set; }

    [Column("FAProposalInvoiceContactLastName")]
    [StringLength(50)]
    public string FaproposalInvoiceContactLastName { get; set; }

    [Column("FAProposalInvoiceContactTitle")]
    [StringLength(50)]
    public string FaproposalInvoiceContactTitle { get; set; }

    [Column("FAProposalInvoiceContactHeaderLetter")]
    [StringLength(100)]
    public string FaproposalInvoiceContactHeaderLetter { get; set; }

    [Column("FAProposalInvoiceContactHeaderMessage")]
    [StringLength(255)]
    public string FaproposalInvoiceContactHeaderMessage { get; set; }

    [Column("FAProposalInvoiceContactEmail1")]
    [StringLength(100)]
    public string FaproposalInvoiceContactEmail1 { get; set; }

    [Column("FAProposalInvoiceContactEmail2")]
    [StringLength(100)]
    public string FaproposalInvoiceContactEmail2 { get; set; }

    [Column("FAProposalInvoiceContactWebsite")]
    [StringLength(100)]
    public string FaproposalInvoiceContactWebsite { get; set; }

    [Column("FAProposalInvoiceContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalInvoiceContactPhonePrivat { get; set; }

    [Column("FAProposalInvoiceContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalInvoiceContactPhone { get; set; }

    [Column("FAProposalInvoiceContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalInvoiceContactPhone1 { get; set; }

    [Column("FAProposalInvoiceContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalInvoiceContactCellPhone { get; set; }

    [Column("FAProposalInvoiceContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalInvoiceContactCellPhone1 { get; set; }

    [Column("FAProposalInvoiceContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalInvoiceContactCellPhonePrivat { get; set; }

    [Column("FAProposalInvoiceContactFax")]
    [StringLength(50)]
    public string FaproposalInvoiceContactFax { get; set; }

    [Column("FAProposalInvoiceContactType")]
    [StringLength(50)]
    public string FaproposalInvoiceContactType { get; set; }

    [Column("FAProposalInvoiceContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FaproposalInvoiceContactInformation { get; set; }

    [Column("FAProposalInvoiceContactDepartment")]
    [StringLength(50)]
    public string FaproposalInvoiceContactDepartment { get; set; }

    [Column("FAProposalInvoiceContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FaproposalInvoiceContactRoom { get; set; }

    [Column("FAProposalInvoiceContactImage")]
    public byte[] FaproposalInvoiceContactImage { get; set; }

    [Column("FAProposalInvoiceAddressName")]
    [StringLength(100)]
    public string FaproposalInvoiceAddressName { get; set; }

    [Column("FAProposalInvoiceAddressDesc1")]
    [StringLength(250)]
    public string FaproposalInvoiceAddressDesc1 { get; set; }

    [Column("FAProposalInvoiceAddressDesc2")]
    [StringLength(250)]
    public string FaproposalInvoiceAddressDesc2 { get; set; }

    [Column("FAProposalInvoiceAddressDesc3")]
    [StringLength(250)]
    public string FaproposalInvoiceAddressDesc3 { get; set; }

    [Column("FAProposalInvoiceAddressStreet")]
    [StringLength(200)]
    public string FaproposalInvoiceAddressStreet { get; set; }

    [Column("FAProposalInvoiceAddressHouseNumber")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressHouseNumber { get; set; }

    [Column("FAProposalInvoiceAddressCity")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressCity { get; set; }

    [Column("FAProposalInvoiceAddressPostalCode")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressPostalCode { get; set; }

    [Column("FAProposalInvoiceAddressStateProvince")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressStateProvince { get; set; }

    [Column("FAProposalInvoiceAddressZipCode")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressZipCode { get; set; }

    [Column("FAProposalInvoiceAddressCountry")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressCountry { get; set; }

    [Column("FAProposalInvoiceAddressEmail")]
    [StringLength(100)]
    public string FaproposalInvoiceAddressEmail { get; set; }

    [Column("FAProposalInvoiceAddressWebsite")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressWebsite { get; set; }

    [Column("FAProposalInvoiceAddressPhone")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressPhone { get; set; }

    [Column("FAProposalInvoiceAddresssFax")]
    [StringLength(50)]
    public string FaproposalInvoiceAddresssFax { get; set; }

    [Column("FAProposalInvoiceAddresssInfo")]
    [StringLength(255)]
    public string FaproposalInvoiceAddresssInfo { get; set; }

    [Column("FAProposalInvoiceAddresssCarZip")]
    [StringLength(50)]
    public string FaproposalInvoiceAddresssCarZip { get; set; }

    [Column("FAProposalInvoiceAddressILNNumber")]
    [StringLength(50)]
    public string FaproposalInvoiceAddressIlnnumber { get; set; }

    [Column("FAProposalCommandContactID")]
    public int? FaproposalCommandContactId { get; set; }

    [Column("FAProposalCommandContactName")]
    [StringLength(50)]
    public string FaproposalCommandContactName { get; set; }

    [Column("FAProposalCommandContactBirthday", TypeName = "datetime")]
    public DateTime? FaproposalCommandContactBirthday { get; set; }

    [Column("FAProposalCommandContactFirstName")]
    [StringLength(50)]
    public string FaproposalCommandContactFirstName { get; set; }

    [Column("FAProposalCommandContactLastName")]
    [StringLength(50)]
    public string FaproposalCommandContactLastName { get; set; }

    [Column("FAProposalCommandContactTitle")]
    [StringLength(50)]
    public string FaproposalCommandContactTitle { get; set; }

    [Column("FAProposalCommandContactHeaderLetter")]
    [StringLength(100)]
    public string FaproposalCommandContactHeaderLetter { get; set; }

    [Column("FAProposalCommandContactHeaderMessage")]
    [StringLength(255)]
    public string FaproposalCommandContactHeaderMessage { get; set; }

    [Column("FAProposalCommandContactEmail1")]
    [StringLength(100)]
    public string FaproposalCommandContactEmail1 { get; set; }

    [Column("FAProposalCommandContactEmail2")]
    [StringLength(100)]
    public string FaproposalCommandContactEmail2 { get; set; }

    [Column("FAProposalCommandContactWebsite")]
    [StringLength(100)]
    public string FaproposalCommandContactWebsite { get; set; }

    [Column("FAProposalCommandContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalCommandContactPhonePrivat { get; set; }

    [Column("FAProposalCommandContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalCommandContactPhone { get; set; }

    [Column("FAProposalCommandContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalCommandContactPhone1 { get; set; }

    [Column("FAProposalCommandContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalCommandContactCellPhone { get; set; }

    [Column("FAProposalCommandContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalCommandContactCellPhone1 { get; set; }

    [Column("FAProposalCommandContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalCommandContactCellPhonePrivat { get; set; }

    [Column("FAProposalCommandContactFax")]
    [StringLength(50)]
    public string FaproposalCommandContactFax { get; set; }

    [Column("FAProposalCommandContactType")]
    [StringLength(50)]
    public string FaproposalCommandContactType { get; set; }

    [Column("FAProposalCommandContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FaproposalCommandContactInformation { get; set; }

    [Column("FAProposalCommandContactDepartment")]
    [StringLength(50)]
    public string FaproposalCommandContactDepartment { get; set; }

    [Column("FAProposalCommandContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FaproposalCommandContactRoom { get; set; }

    [Column("FAProposalCommandContactImage")]
    public byte[] FaproposalCommandContactImage { get; set; }

    [Column("FAProposalCommandAddressName")]
    [StringLength(100)]
    public string FaproposalCommandAddressName { get; set; }

    [Column("FAProposalCommandAddressDesc1")]
    [StringLength(250)]
    public string FaproposalCommandAddressDesc1 { get; set; }

    [Column("FAProposalCommandAddressDesc2")]
    [StringLength(250)]
    public string FaproposalCommandAddressDesc2 { get; set; }

    [Column("FAProposalCommandAddressDesc3")]
    [StringLength(250)]
    public string FaproposalCommandAddressDesc3 { get; set; }

    [Column("FAProposalCommandAddressStreet")]
    [StringLength(200)]
    public string FaproposalCommandAddressStreet { get; set; }

    [Column("FAProposalCommandAddressHouseNumber")]
    [StringLength(50)]
    public string FaproposalCommandAddressHouseNumber { get; set; }

    [Column("FAProposalCommandAddressCity")]
    [StringLength(50)]
    public string FaproposalCommandAddressCity { get; set; }

    [Column("FAProposalCommandAddressPostalCode")]
    [StringLength(50)]
    public string FaproposalCommandAddressPostalCode { get; set; }

    [Column("FAProposalCommandAddressStateProvince")]
    [StringLength(50)]
    public string FaproposalCommandAddressStateProvince { get; set; }

    [Column("FAProposalCommandAddressZipCode")]
    [StringLength(50)]
    public string FaproposalCommandAddressZipCode { get; set; }

    [Column("FAProposalCommandAddressCountry")]
    [StringLength(50)]
    public string FaproposalCommandAddressCountry { get; set; }

    [Column("FAProposalCommandAddressEmail")]
    [StringLength(100)]
    public string FaproposalCommandAddressEmail { get; set; }

    [Column("FAProposalCommandAddressWebsite")]
    [StringLength(50)]
    public string FaproposalCommandAddressWebsite { get; set; }

    [Column("FAProposalCommandAddressPhone")]
    [StringLength(50)]
    public string FaproposalCommandAddressPhone { get; set; }

    [Column("FAProposalCommandAddresssFax")]
    [StringLength(50)]
    public string FaproposalCommandAddresssFax { get; set; }

    [Column("FAProposalCommandAddresssInfo")]
    [StringLength(255)]
    public string FaproposalCommandAddresssInfo { get; set; }

    [Column("FAProposalCommandAddresssCarZip")]
    [StringLength(50)]
    public string FaproposalCommandAddresssCarZip { get; set; }

    [Column("FAProposalCommandAddressILNNumber")]
    [StringLength(50)]
    public string FaproposalCommandAddressIlnnumber { get; set; }

    [Column("FAProposalDeliveryContactID")]
    public int? FaproposalDeliveryContactId { get; set; }

    [Column("FAProposalDeliveryContactName")]
    [StringLength(50)]
    public string FaproposalDeliveryContactName { get; set; }

    [Column("FAProposalDeliveryContactBirthday", TypeName = "datetime")]
    public DateTime? FaproposalDeliveryContactBirthday { get; set; }

    [Column("FAProposalDeliveryContactFirstName")]
    [StringLength(50)]
    public string FaproposalDeliveryContactFirstName { get; set; }

    [Column("FAProposalDeliveryContactLastName")]
    [StringLength(50)]
    public string FaproposalDeliveryContactLastName { get; set; }

    [Column("FAProposalDeliveryContactTitle")]
    [StringLength(50)]
    public string FaproposalDeliveryContactTitle { get; set; }

    [Column("FAProposalDeliveryContactHeaderLetter")]
    [StringLength(100)]
    public string FaproposalDeliveryContactHeaderLetter { get; set; }

    [Column("FAProposalDeliveryContactHeaderMessage")]
    [StringLength(255)]
    public string FaproposalDeliveryContactHeaderMessage { get; set; }

    [Column("FAProposalDeliveryContactEmail1")]
    [StringLength(100)]
    public string FaproposalDeliveryContactEmail1 { get; set; }

    [Column("FAProposalDeliveryContactEmail2")]
    [StringLength(100)]
    public string FaproposalDeliveryContactEmail2 { get; set; }

    [Column("FAProposalDeliveryContactWebsite")]
    [StringLength(100)]
    public string FaproposalDeliveryContactWebsite { get; set; }

    [Column("FAProposalDeliveryContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalDeliveryContactPhonePrivat { get; set; }

    [Column("FAProposalDeliveryContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalDeliveryContactPhone { get; set; }

    [Column("FAProposalDeliveryContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalDeliveryContactPhone1 { get; set; }

    [Column("FAProposalDeliveryContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalDeliveryContactCellPhone { get; set; }

    [Column("FAProposalDeliveryContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalDeliveryContactCellPhone1 { get; set; }

    [Column("FAProposalDeliveryContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FaproposalDeliveryContactCellPhonePrivat { get; set; }

    [Column("FAProposalDeliveryContactFax")]
    [StringLength(50)]
    public string FaproposalDeliveryContactFax { get; set; }

    [Column("FAProposalDeliveryContactType")]
    [StringLength(50)]
    public string FaproposalDeliveryContactType { get; set; }

    [Column("FAProposalDeliveryContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FaproposalDeliveryContactInformation { get; set; }

    [Column("FAProposalDeliveryContactDepartment")]
    [StringLength(50)]
    public string FaproposalDeliveryContactDepartment { get; set; }

    [Column("FAProposalDeliveryContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FaproposalDeliveryContactRoom { get; set; }

    [Column("FAProposalDeliveryContactImage")]
    public byte[] FaproposalDeliveryContactImage { get; set; }

    [Column("FAProposalDeliveryAddressName")]
    [StringLength(100)]
    public string FaproposalDeliveryAddressName { get; set; }

    [Column("FAProposalDeliveryAddressDesc1")]
    [StringLength(250)]
    public string FaproposalDeliveryAddressDesc1 { get; set; }

    [Column("FAProposalDeliveryAddressDesc2")]
    [StringLength(250)]
    public string FaproposalDeliveryAddressDesc2 { get; set; }

    [Column("FAProposalDeliveryAddressDesc3")]
    [StringLength(250)]
    public string FaproposalDeliveryAddressDesc3 { get; set; }

    [Column("FAProposalDeliveryAddressStreet")]
    [StringLength(200)]
    public string FaproposalDeliveryAddressStreet { get; set; }

    [Column("FAProposalDeliveryAddressHouseNumber")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressHouseNumber { get; set; }

    [Column("FAProposalDeliveryAddressCity")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressCity { get; set; }

    [Column("FAProposalDeliveryAddressPostalCode")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressPostalCode { get; set; }

    [Column("FAProposalDeliveryAddressStateProvince")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressStateProvince { get; set; }

    [Column("FAProposalDeliveryAddressZipCode")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressZipCode { get; set; }

    [Column("FAProposalDeliveryAddressCountry")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressCountry { get; set; }

    [Column("FAProposalDeliveryAddressEmail")]
    [StringLength(100)]
    public string FaproposalDeliveryAddressEmail { get; set; }

    [Column("FAProposalDeliveryAddressWebsite")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressWebsite { get; set; }

    [Column("FAProposalDeliveryAddressPhone")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressPhone { get; set; }

    [Column("FAProposalDeliveryAddresssFax")]
    [StringLength(50)]
    public string FaproposalDeliveryAddresssFax { get; set; }

    [Column("FAProposalDeliveryAddresssInfo")]
    [StringLength(255)]
    public string FaproposalDeliveryAddresssInfo { get; set; }

    [Column("FAProposalDeliveryAddresssCarZip")]
    [StringLength(50)]
    public string FaproposalDeliveryAddresssCarZip { get; set; }

    [Column("FAProposalDeliveryAddressILNNumber")]
    [StringLength(50)]
    public string FaproposalDeliveryAddressIlnnumber { get; set; }

    [Column("FAProposalSearchString1")]
    [StringLength(50)]
    public string FaproposalSearchString1 { get; set; }

    [Column("FAProposalSearchString2")]
    [StringLength(50)]
    public string FaproposalSearchString2 { get; set; }

    [Column("FAProposalSearchString3")]
    [StringLength(50)]
    public string FaproposalSearchString3 { get; set; }

    [Column("FAProposalKalkuExcel1")]
    [StringLength(50)]
    public string FaproposalKalkuExcel1 { get; set; }

    [Column("FAProposalKalkuExcel2")]
    [StringLength(50)]
    public string FaproposalKalkuExcel2 { get; set; }

    [Column("FAProposalShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalShippingFees { get; set; }

    [Column("FAProposalShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalShippingExtraFees { get; set; }

    [Column("FAProposalShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalShippingInsuranceFees { get; set; }

    [Column("FAProposalShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalShippingPackagingFees { get; set; }

    [Column("FAProposalShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalShippingReservedFees1 { get; set; }

    [Column("FAProposalShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalShippingReservedFees2 { get; set; }

    [Column("FAProposalShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalShippingReservedFees3 { get; set; }

    [Column("FAProposalShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? FaproposalShippingReservedFees4 { get; set; }

    [Column("FAProposalShippingMethodDesc")]
    [StringLength(255)]
    public string FaproposalShippingMethodDesc { get; set; }

    [Column("FAProposalShippingMethodName")]
    [StringLength(50)]
    public string FaproposalShippingMethodName { get; set; }

    [ForeignKey("ArcustomerId")]
    [InverseProperty("Oeproposals")]
    public virtual Arcustomer Arcustomer { get; set; }

    [ForeignKey("ArsellerId")]
    [InverseProperty("Oeproposals")]
    public virtual Arseller Arseller { get; set; }

    [InverseProperty("Faproposal")]
    public virtual ICollection<FaproposalContact> FaproposalContacts { get; set; } = new List<FaproposalContact>();

    [InverseProperty("Faproposal")]
    public virtual ICollection<FaproposalDiscount> FaproposalDiscounts { get; set; } = new List<FaproposalDiscount>();

    [InverseProperty("Faproposal")]
    public virtual ICollection<FaproposalHistory> FaproposalHistories { get; set; } = new List<FaproposalHistory>();

    [InverseProperty("Faproposal")]
    public virtual ICollection<FaproposalItem> FaproposalItems { get; set; } = new List<FaproposalItem>();

    [InverseProperty("Faproposal")]
    public virtual ICollection<FaproposalSellOrder> FaproposalSellOrders { get; set; } = new List<FaproposalSellOrder>();

    [ForeignKey("GecurrencyId")]
    [InverseProperty("Oeproposals")]
    public virtual Gecurrency Gecurrency { get; set; }

    [ForeignKey("GelanguageId")]
    [InverseProperty("Oeproposals")]
    public virtual Gelanguage Gelanguage { get; set; }

    [ForeignKey("GevatregionId")]
    [InverseProperty("Oeproposals")]
    public virtual Gevatregion Gevatregion { get; set; }
}
