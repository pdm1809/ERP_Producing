using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FATransfers")]
public partial class Fatransfer
{
    [Key]
    [Column("FATransferID")]
    public int FatransferId { get; set; }

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

    [Column("FATransferStatus")]
    [StringLength(100)]
    public string FatransferStatus { get; set; }

    [Required]
    [Column("FATransferName")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferName { get; set; }

    [Column("FATransferDesc")]
    [StringLength(500)]
    public string FatransferDesc { get; set; }

    [Column("FATransferText", TypeName = "ntext")]
    public string FatransferText { get; set; }

    [Column("FATransferCulture")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferCulture { get; set; }

    [Column("FATransferStartDate", TypeName = "datetime")]
    public DateTime? FatransferStartDate { get; set; }

    [Column("FATransferValidateDate", TypeName = "datetime")]
    public DateTime? FatransferValidateDate { get; set; }

    [Column("FATransferStockOutDate", TypeName = "datetime")]
    public DateTime? FatransferStockOutDate { get; set; }

    [Column("FATransferStockInDate", TypeName = "datetime")]
    public DateTime? FatransferStockInDate { get; set; }

    [Column("FATransferStockOutDate2", TypeName = "datetime")]
    public DateTime? FatransferStockOutDate2 { get; set; }

    [Column("FATransferRemark")]
    [StringLength(255)]
    public string FatransferRemark { get; set; }

    [Column("FATransferRemark1")]
    [StringLength(255)]
    public string FatransferRemark1 { get; set; }

    [Column("FATransferLevel")]
    public int? FatransferLevel { get; set; }

    [Column("FATransferWeight", TypeName = "decimal(18, 5)")]
    public decimal? FatransferWeight { get; set; }

    [Column("FATransferVolume", TypeName = "decimal(18, 5)")]
    public decimal? FatransferVolume { get; set; }

    [Column("FATransferStornoCheck")]
    public bool? FatransferStornoCheck { get; set; }

    [Column("FATransferSaveStatusInSession")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferSaveStatusInSession { get; set; }

    [Column("FATransferTypeCombo")]
    [StringLength(50)]
    public string FatransferTypeCombo { get; set; }

    [Column("FATransferMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode01Combo { get; set; }

    [Column("FATransferMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode02Combo { get; set; }

    [Column("FATransferMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode03Combo { get; set; }

    [Column("FATransferMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode04Combo { get; set; }

    [Column("FATransferMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode05Combo { get; set; }

    [Column("FATransferMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode06Combo { get; set; }

    [Column("FATransferMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode07Combo { get; set; }

    [Column("FATransferMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode08Combo { get; set; }

    [Column("FATransferMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode09Combo { get; set; }

    [Column("FATransferMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode10Combo { get; set; }

    [Column("FATransferMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode11Combo { get; set; }

    [Column("FATransferMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferMatchCode12Combo { get; set; }

    [Column("FATransferInfo", TypeName = "ntext")]
    public string FatransferInfo { get; set; }

    [Column("FATransferProject")]
    [StringLength(50)]
    public string FatransferProject { get; set; }

    [Column("FATransferWorkingContactID")]
    public int? FatransferWorkingContactId { get; set; }

    [Column("FATransferWorkingContactName")]
    [StringLength(50)]
    public string FatransferWorkingContactName { get; set; }

    [Column("FATransferWorkingContactFirstName")]
    [StringLength(50)]
    public string FatransferWorkingContactFirstName { get; set; }

    [Column("FATransferWorkingContactLastName")]
    [StringLength(50)]
    public string FatransferWorkingContactLastName { get; set; }

    [Column("FATransferWorkingContactTitle")]
    [StringLength(50)]
    public string FatransferWorkingContactTitle { get; set; }

    [Column("FATransferWorkingContactHeaderLetter")]
    [StringLength(100)]
    public string FatransferWorkingContactHeaderLetter { get; set; }

    [Column("FATransferWorkingContactHeaderMessage")]
    [StringLength(255)]
    public string FatransferWorkingContactHeaderMessage { get; set; }

    [Column("FATransferWorkingContactEmail1")]
    [StringLength(100)]
    public string FatransferWorkingContactEmail1 { get; set; }

    [Column("FATransferWorkingContactEmail2")]
    [StringLength(100)]
    public string FatransferWorkingContactEmail2 { get; set; }

    [Column("FATransferWorkingContactWebsite")]
    [StringLength(100)]
    public string FatransferWorkingContactWebsite { get; set; }

    [Column("FATransferWorkingContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferWorkingContactPhonePrivat { get; set; }

    [Column("FATransferWorkingContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferWorkingContactPhone { get; set; }

    [Column("FATransferWorkingContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferWorkingContactPhone1 { get; set; }

    [Column("FATransferWorkingContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferWorkingContactCellPhone { get; set; }

    [Column("FATransferWorkingContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferWorkingContactCellPhone1 { get; set; }

    [Column("FATransferWorkingContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferWorkingContactCellPhonePrivat { get; set; }

    [Column("FATransferWorkingContactFax")]
    [StringLength(50)]
    public string FatransferWorkingContactFax { get; set; }

    [Column("FATransferWorkingContactType")]
    [StringLength(50)]
    public string FatransferWorkingContactType { get; set; }

    [Column("FATransferWorkingContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FatransferWorkingContactInformation { get; set; }

    [Column("FATransferWorkingContactDepartment")]
    [StringLength(50)]
    public string FatransferWorkingContactDepartment { get; set; }

    [Column("FATransferWorkingContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FatransferWorkingContactRoom { get; set; }

    [Column("FATransferWorkingContactImage")]
    public byte[] FatransferWorkingContactImage { get; set; }

    [Column("FATransferWorkingAddressName")]
    [StringLength(100)]
    public string FatransferWorkingAddressName { get; set; }

    [Column("FATransferWorkingAddressDesc1")]
    [StringLength(250)]
    public string FatransferWorkingAddressDesc1 { get; set; }

    [Column("FATransferWorkingAddressDesc2")]
    [StringLength(250)]
    public string FatransferWorkingAddressDesc2 { get; set; }

    [Column("FATransferWorkingAddressDesc3")]
    [StringLength(250)]
    public string FatransferWorkingAddressDesc3 { get; set; }

    [Column("FATransferWorkingAddressStreet")]
    [StringLength(200)]
    public string FatransferWorkingAddressStreet { get; set; }

    [Column("FATransferWorkingAddressHouseNumber")]
    [StringLength(50)]
    public string FatransferWorkingAddressHouseNumber { get; set; }

    [Column("FATransferWorkingAddressCity")]
    [StringLength(50)]
    public string FatransferWorkingAddressCity { get; set; }

    [Column("FATransferWorkingAddressPostalCode")]
    [StringLength(50)]
    public string FatransferWorkingAddressPostalCode { get; set; }

    [Column("FATransferWorkingAddressStateProvince")]
    [StringLength(50)]
    public string FatransferWorkingAddressStateProvince { get; set; }

    [Column("FATransferWorkingAddressZipCode")]
    [StringLength(50)]
    public string FatransferWorkingAddressZipCode { get; set; }

    [Column("FATransferWorkingAddressCountry")]
    [StringLength(50)]
    public string FatransferWorkingAddressCountry { get; set; }

    [Column("FATransferWorkingAddressEmail")]
    [StringLength(100)]
    public string FatransferWorkingAddressEmail { get; set; }

    [Column("FATransferWorkingAddressWebsite")]
    [StringLength(50)]
    public string FatransferWorkingAddressWebsite { get; set; }

    [Column("FATransferWorkingAddressPhone")]
    [StringLength(50)]
    public string FatransferWorkingAddressPhone { get; set; }

    [Column("FATransferWorkingAddresssFax")]
    [StringLength(50)]
    public string FatransferWorkingAddresssFax { get; set; }

    [Column("FATransferWorkingAddresssInfo")]
    [StringLength(255)]
    public string FatransferWorkingAddresssInfo { get; set; }

    [Column("FATransferWorkingAddresssCarZip")]
    [StringLength(50)]
    public string FatransferWorkingAddresssCarZip { get; set; }

    [Column("FATransferWorkingAddressILNNumber")]
    [StringLength(50)]
    public string FatransferWorkingAddressIlnnumber { get; set; }

    [Column("FATransferStockInContactID")]
    public int? FatransferStockInContactId { get; set; }

    [Column("FATransferStockInContactName")]
    [StringLength(50)]
    public string FatransferStockInContactName { get; set; }

    [Column("FATransferStockInContactBirthday", TypeName = "datetime")]
    public DateTime? FatransferStockInContactBirthday { get; set; }

    [Column("FATransferStockInContactFirstName")]
    [StringLength(50)]
    public string FatransferStockInContactFirstName { get; set; }

    [Column("FATransferStockInContactLastName")]
    [StringLength(50)]
    public string FatransferStockInContactLastName { get; set; }

    [Column("FATransferStockInContactTitle")]
    [StringLength(50)]
    public string FatransferStockInContactTitle { get; set; }

    [Column("FATransferStockInContactHeaderLetter")]
    [StringLength(100)]
    public string FatransferStockInContactHeaderLetter { get; set; }

    [Column("FATransferStockInContactHeaderMessage")]
    [StringLength(255)]
    public string FatransferStockInContactHeaderMessage { get; set; }

    [Column("FATransferStockInContactEmail1")]
    [StringLength(100)]
    public string FatransferStockInContactEmail1 { get; set; }

    [Column("FATransferStockInContactEmail2")]
    [StringLength(100)]
    public string FatransferStockInContactEmail2 { get; set; }

    [Column("FATransferStockInContactWebsite")]
    [StringLength(100)]
    public string FatransferStockInContactWebsite { get; set; }

    [Column("FATransferStockInContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockInContactPhonePrivat { get; set; }

    [Column("FATransferStockInContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockInContactPhone { get; set; }

    [Column("FATransferStockInContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockInContactPhone1 { get; set; }

    [Column("FATransferStockInContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockInContactCellPhone { get; set; }

    [Column("FATransferStockInContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockInContactCellPhone1 { get; set; }

    [Column("FATransferStockInContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockInContactCellPhonePrivat { get; set; }

    [Column("FATransferStockInContactFax")]
    [StringLength(50)]
    public string FatransferStockInContactFax { get; set; }

    [Column("FATransferStockInContactType")]
    [StringLength(50)]
    public string FatransferStockInContactType { get; set; }

    [Column("FATransferStockInContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FatransferStockInContactInformation { get; set; }

    [Column("FATransferStockInContactDepartment")]
    [StringLength(50)]
    public string FatransferStockInContactDepartment { get; set; }

    [Column("FATransferStockInContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FatransferStockInContactRoom { get; set; }

    [Column("FATransferStockInContactImage")]
    public byte[] FatransferStockInContactImage { get; set; }

    [Column("FATransferStockInAddressName")]
    [StringLength(100)]
    public string FatransferStockInAddressName { get; set; }

    [Column("FATransferStockInAddressDesc1")]
    [StringLength(250)]
    public string FatransferStockInAddressDesc1 { get; set; }

    [Column("FATransferStockInAddressDesc2")]
    [StringLength(250)]
    public string FatransferStockInAddressDesc2 { get; set; }

    [Column("FATransferStockInAddressDesc3")]
    [StringLength(250)]
    public string FatransferStockInAddressDesc3 { get; set; }

    [Column("FATransferStockInAddressStreet")]
    [StringLength(200)]
    public string FatransferStockInAddressStreet { get; set; }

    [Column("FATransferStockInAddressHouseNumber")]
    [StringLength(50)]
    public string FatransferStockInAddressHouseNumber { get; set; }

    [Column("FATransferStockInAddressCity")]
    [StringLength(50)]
    public string FatransferStockInAddressCity { get; set; }

    [Column("FATransferStockInAddressPostalCode")]
    [StringLength(50)]
    public string FatransferStockInAddressPostalCode { get; set; }

    [Column("FATransferStockInAddressStateProvince")]
    [StringLength(50)]
    public string FatransferStockInAddressStateProvince { get; set; }

    [Column("FATransferStockInAddressZipCode")]
    [StringLength(50)]
    public string FatransferStockInAddressZipCode { get; set; }

    [Column("FATransferStockInAddressCountry")]
    [StringLength(50)]
    public string FatransferStockInAddressCountry { get; set; }

    [Column("FATransferStockInAddressEmail")]
    [StringLength(100)]
    public string FatransferStockInAddressEmail { get; set; }

    [Column("FATransferStockInAddressWebsite")]
    [StringLength(50)]
    public string FatransferStockInAddressWebsite { get; set; }

    [Column("FATransferStockInAddressPhone")]
    [StringLength(50)]
    public string FatransferStockInAddressPhone { get; set; }

    [Column("FATransferStockInAddresssFax")]
    [StringLength(50)]
    public string FatransferStockInAddresssFax { get; set; }

    [Column("FATransferStockInAddresssInfo")]
    [StringLength(255)]
    public string FatransferStockInAddresssInfo { get; set; }

    [Column("FATransferStockInAddresssCarZip")]
    [StringLength(50)]
    public string FatransferStockInAddresssCarZip { get; set; }

    [Column("FATransferStockInAddressILNNumber")]
    [StringLength(50)]
    public string FatransferStockInAddressIlnnumber { get; set; }

    [Column("FATransferStockOutContactID")]
    public int? FatransferStockOutContactId { get; set; }

    [Column("FATransferStockOutContactName")]
    [StringLength(50)]
    public string FatransferStockOutContactName { get; set; }

    [Column("FATransferStockOutContactBirthday", TypeName = "datetime")]
    public DateTime? FatransferStockOutContactBirthday { get; set; }

    [Column("FATransferStockOutContactFirstName")]
    [StringLength(50)]
    public string FatransferStockOutContactFirstName { get; set; }

    [Column("FATransferStockOutContactLastName")]
    [StringLength(50)]
    public string FatransferStockOutContactLastName { get; set; }

    [Column("FATransferStockOutContactTitle")]
    [StringLength(50)]
    public string FatransferStockOutContactTitle { get; set; }

    [Column("FATransferStockOutContactHeaderLetter")]
    [StringLength(100)]
    public string FatransferStockOutContactHeaderLetter { get; set; }

    [Column("FATransferStockOutContactHeaderMessage")]
    [StringLength(255)]
    public string FatransferStockOutContactHeaderMessage { get; set; }

    [Column("FATransferStockOutContactEmail1")]
    [StringLength(100)]
    public string FatransferStockOutContactEmail1 { get; set; }

    [Column("FATransferStockOutContactEmail2")]
    [StringLength(100)]
    public string FatransferStockOutContactEmail2 { get; set; }

    [Column("FATransferStockOutContactWebsite")]
    [StringLength(100)]
    public string FatransferStockOutContactWebsite { get; set; }

    [Column("FATransferStockOutContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockOutContactPhonePrivat { get; set; }

    [Column("FATransferStockOutContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockOutContactPhone { get; set; }

    [Column("FATransferStockOutContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockOutContactPhone1 { get; set; }

    [Column("FATransferStockOutContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockOutContactCellPhone { get; set; }

    [Column("FATransferStockOutContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockOutContactCellPhone1 { get; set; }

    [Column("FATransferStockOutContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FatransferStockOutContactCellPhonePrivat { get; set; }

    [Column("FATransferStockOutContactFax")]
    [StringLength(50)]
    public string FatransferStockOutContactFax { get; set; }

    [Column("FATransferStockOutContactType")]
    [StringLength(50)]
    public string FatransferStockOutContactType { get; set; }

    [Column("FATransferStockOutContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FatransferStockOutContactInformation { get; set; }

    [Column("FATransferStockOutContactDepartment")]
    [StringLength(50)]
    public string FatransferStockOutContactDepartment { get; set; }

    [Column("FATransferStockOutContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FatransferStockOutContactRoom { get; set; }

    [Column("FATransferStockOutContactImage")]
    public byte[] FatransferStockOutContactImage { get; set; }

    [Column("FATransferStockOutAddressName")]
    [StringLength(100)]
    public string FatransferStockOutAddressName { get; set; }

    [Column("FATransferStockOutAddressDesc1")]
    [StringLength(250)]
    public string FatransferStockOutAddressDesc1 { get; set; }

    [Column("FATransferStockOutAddressDesc2")]
    [StringLength(250)]
    public string FatransferStockOutAddressDesc2 { get; set; }

    [Column("FATransferStockOutAddressDesc3")]
    [StringLength(250)]
    public string FatransferStockOutAddressDesc3 { get; set; }

    [Column("FATransferStockOutAddressStreet")]
    [StringLength(200)]
    public string FatransferStockOutAddressStreet { get; set; }

    [Column("FATransferStockOutAddressHouseNumber")]
    [StringLength(50)]
    public string FatransferStockOutAddressHouseNumber { get; set; }

    [Column("FATransferStockOutAddressCity")]
    [StringLength(50)]
    public string FatransferStockOutAddressCity { get; set; }

    [Column("FATransferStockOutAddressPostalCode")]
    [StringLength(50)]
    public string FatransferStockOutAddressPostalCode { get; set; }

    [Column("FATransferStockOutAddressStateProvince")]
    [StringLength(50)]
    public string FatransferStockOutAddressStateProvince { get; set; }

    [Column("FATransferStockOutAddressZipCode")]
    [StringLength(50)]
    public string FatransferStockOutAddressZipCode { get; set; }

    [Column("FATransferStockOutAddressCountry")]
    [StringLength(50)]
    public string FatransferStockOutAddressCountry { get; set; }

    [Column("FATransferStockOutAddressEmail")]
    [StringLength(100)]
    public string FatransferStockOutAddressEmail { get; set; }

    [Column("FATransferStockOutAddressWebsite")]
    [StringLength(50)]
    public string FatransferStockOutAddressWebsite { get; set; }

    [Column("FATransferStockOutAddressPhone")]
    [StringLength(50)]
    public string FatransferStockOutAddressPhone { get; set; }

    [Column("FATransferStockOutAddresssFax")]
    [StringLength(50)]
    public string FatransferStockOutAddresssFax { get; set; }

    [Column("FATransferStockOutAddresssInfo")]
    [StringLength(255)]
    public string FatransferStockOutAddresssInfo { get; set; }

    [Column("FATransferStockOutAddresssCarZip")]
    [StringLength(50)]
    public string FatransferStockOutAddresssCarZip { get; set; }

    [Column("FATransferStockOutAddressILNNumber")]
    [StringLength(50)]
    public string FatransferStockOutAddressIlnnumber { get; set; }

    [Column("FATransferSearchString1")]
    [StringLength(50)]
    public string FatransferSearchString1 { get; set; }

    [Column("FATransferSearchString2")]
    [StringLength(50)]
    public string FatransferSearchString2 { get; set; }

    [Column("FATransferSearchString3")]
    [StringLength(50)]
    public string FatransferSearchString3 { get; set; }

    [Column("FATransferCalcuExcel1")]
    [StringLength(50)]
    public string FatransferCalcuExcel1 { get; set; }

    [Column("FATransferCalcuExcel2")]
    [StringLength(50)]
    public string FatransferCalcuExcel2 { get; set; }

    [Column("FATransferShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? FatransferShippingFees { get; set; }

    [Column("FATransferShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? FatransferShippingExtraFees { get; set; }

    [Column("FATransferShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? FatransferShippingInsuranceFees { get; set; }

    [Column("FATransferShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? FatransferShippingPackagingFees { get; set; }

    [Column("FATransferShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? FatransferShippingReservedFees1 { get; set; }

    [Column("FATransferShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? FatransferShippingReservedFees2 { get; set; }

    [Column("FATransferShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? FatransferShippingReservedFees3 { get; set; }

    [Column("FATransferShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? FatransferShippingReservedFees4 { get; set; }

    [Column("FATransferShippingMethodDesc")]
    [StringLength(255)]
    public string FatransferShippingMethodDesc { get; set; }

    [Column("FATransferShippingMethodName")]
    [StringLength(50)]
    public string FatransferShippingMethodName { get; set; }

    [Column("NEWFATransfer")]
    public int? Newfatransfer { get; set; }

    [InverseProperty("Fatransfer")]
    public virtual ICollection<FatransferHistory> FatransferHistories { get; set; } = new List<FatransferHistory>();

    [ForeignKey("FatransferStockInContactId")]
    [InverseProperty("FatransferFatransferStockInContacts")]
    public virtual Icstock FatransferStockInContact { get; set; }

    [InverseProperty("Fatransfer")]
    public virtual ICollection<FatransferStockInItem> FatransferStockInItems { get; set; } = new List<FatransferStockInItem>();

    [ForeignKey("FatransferStockOutContactId")]
    [InverseProperty("FatransferFatransferStockOutContacts")]
    public virtual Icstock FatransferStockOutContact { get; set; }

    [InverseProperty("Fatransfer")]
    public virtual ICollection<FatransferStockOutItem> FatransferStockOutItems { get; set; } = new List<FatransferStockOutItem>();

    [ForeignKey("FatransferWorkingContactId")]
    [InverseProperty("FatransferFatransferWorkingContacts")]
    public virtual Icstock FatransferWorkingContact { get; set; }
}
