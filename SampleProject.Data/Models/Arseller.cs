using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSellers")]
[Microsoft.EntityFrameworkCore.Index("ArsellerNo", Name = "Idx_ARSellers")]
public partial class Arseller
{
    [Key]
    [Column("ARSellerID")]
    public int ArsellerId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ARSellerParentID")]
    public int? FkArsellerParentId { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Required]
    [Column("ARSellerNo")]
    [StringLength(50)]
    public string ArsellerNo { get; set; }

    [Column("ARSellerName")]
    [StringLength(50)]
    public string ArsellerName { get; set; }

    [Column("ARSellerDesc")]
    [StringLength(250)]
    public string ArsellerDesc { get; set; }

    /// <summary>
    /// Active
    /// Inactive
    /// Deleted
    /// Dummy
    /// </summary>
    [Required]
    [Column("ARSellerActiveCheck")]
    public bool? ArsellerActiveCheck { get; set; }

    [Column("ARSellerProvison", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerProvison { get; set; }

    [Column("ARSellerParentProvison", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerParentProvison { get; set; }

    [Column("ARSellerMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerMatchCode01Combo { get; set; }

    [Column("ARSellerMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerMatchCode02Combo { get; set; }

    [Column("ARSellerMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerMatchCode03Combo { get; set; }

    [Column("ARSellerMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerMatchCode04Combo { get; set; }

    [Column("ARSellerMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerMatchCode05Combo { get; set; }

    [Column("ARSellerMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerMatchCode06Combo { get; set; }

    [Column("ARSellerContactName")]
    [StringLength(50)]
    public string ArsellerContactName { get; set; }

    [Column("FK_ARSellerContactLanguageIDCombo")]
    public int? FkArsellerContactLanguageIdcombo { get; set; }

    [Column("ARSellerContactBirthday", TypeName = "datetime")]
    public DateTime? ArsellerContactBirthday { get; set; }

    [Column("ARSellerContactFirstName")]
    [StringLength(50)]
    public string ArsellerContactFirstName { get; set; }

    [Column("ARSellerContactLastName")]
    [StringLength(50)]
    public string ArsellerContactLastName { get; set; }

    [Column("ARSellerContactTitle")]
    [StringLength(50)]
    public string ArsellerContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARSellerContactHeaderLetter")]
    [StringLength(100)]
    public string ArsellerContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARSellerContactHeaderMessage")]
    [StringLength(255)]
    public string ArsellerContactHeaderMessage { get; set; }

    [Column("ARSellerContactEmail1")]
    [StringLength(100)]
    public string ArsellerContactEmail1 { get; set; }

    [Column("ARSellerContactEmail2")]
    [StringLength(100)]
    public string ArsellerContactEmail2 { get; set; }

    [Column("ARSellerContactWebsite")]
    [StringLength(100)]
    public string ArsellerContactWebsite { get; set; }

    [Column("ARSellerContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactPhonePrivate { get; set; }

    [Column("ARSellerContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactPhone { get; set; }

    [Column("ARSellerContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactPhone1 { get; set; }

    [Column("ARSellerContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactCellPhone1 { get; set; }

    [Column("ARSellerContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactCellPhone { get; set; }

    [Column("ARSellerContactFax")]
    [StringLength(50)]
    public string ArsellerContactFax { get; set; }

    [Column("ARSellerContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsellerContactInformation { get; set; }

    [Column("ARSellerContactDepartment")]
    [StringLength(50)]
    public string ArsellerContactDepartment { get; set; }

    [Column("ARSellerContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsellerContactRoom { get; set; }

    [Column("ARSellerAddressName")]
    [StringLength(100)]
    public string ArsellerAddressName { get; set; }

    [Column("ARSellerAddressDesc1")]
    [StringLength(250)]
    public string ArsellerAddressDesc1 { get; set; }

    [Column("ARSellerAddressDesc2")]
    [StringLength(250)]
    public string ArsellerAddressDesc2 { get; set; }

    [Column("ARSellerAddressDesc3")]
    [StringLength(250)]
    public string ArsellerAddressDesc3 { get; set; }

    [Column("ARSellerAddressStreet")]
    [StringLength(200)]
    public string ArsellerAddressStreet { get; set; }

    [Column("ARSellerAddressHouseNumber")]
    [StringLength(50)]
    public string ArsellerAddressHouseNumber { get; set; }

    [Column("ARSellerAddressCity")]
    [StringLength(50)]
    public string ArsellerAddressCity { get; set; }

    [Column("ARSellerAddressPostalCode")]
    [StringLength(50)]
    public string ArsellerAddressPostalCode { get; set; }

    [Column("ARSellerAddressStateProvince")]
    [StringLength(50)]
    public string ArsellerAddressStateProvince { get; set; }

    [Column("ARSellerAddressZipCode")]
    [StringLength(50)]
    public string ArsellerAddressZipCode { get; set; }

    [Column("ARSellerAddressCountry")]
    [StringLength(50)]
    public string ArsellerAddressCountry { get; set; }

    [Column("ARSellerAddresssInfo")]
    [StringLength(255)]
    public string ArsellerAddresssInfo { get; set; }

    [Column("ARSellerBankAccount1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerBankAccount1 { get; set; }

    [Column("ARSellerBankAccountCurrency1")]
    public int? ArsellerBankAccountCurrency1 { get; set; }

    [Column("ARSellerBankAccount2")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerBankAccount2 { get; set; }

    [Column("ARSellerBankAccountCurrency2")]
    public int? ArsellerBankAccountCurrency2 { get; set; }

    [Column("ARSellerBankAccount3")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerBankAccount3 { get; set; }

    [Column("ARSellerBankAccountCurrency3")]
    public int? ArsellerBankAccountCurrency3 { get; set; }

    [Column("ARSellerBankAccount4")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerBankAccount4 { get; set; }

    [Column("ARSellerBankAccountCurrency4")]
    public int? ArsellerBankAccountCurrency4 { get; set; }

    [Column("ARSellerBankName")]
    [StringLength(50)]
    public string ArsellerBankName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ArSellerBankCode { get; set; }

    [Column("ARSellerBankDesc")]
    [StringLength(255)]
    public string ArsellerBankDesc { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("ARSellerShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerShippingFees { get; set; }

    [Column("ARSellerShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerShippingExtraFees { get; set; }

    [Column("ARSellerShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerShippingInsuranceFees { get; set; }

    [Column("ARSellerShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerShippingPackagingFees { get; set; }

    [Column("ARSellerShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerShippingReservedFees1 { get; set; }

    [Column("ARSellerShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerShippingReservedFees2 { get; set; }

    [Column("ARSellerShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerShippingReservedFees3 { get; set; }

    [Column("ARSellerShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerShippingReservedFees4 { get; set; }

    [InverseProperty("FkArseller")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkArseller")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [ForeignKey("ArsellerBankAccountCurrency1")]
    [InverseProperty("ArsellerArsellerBankAccountCurrency1Navigations")]
    public virtual Gecurrency ArsellerBankAccountCurrency1Navigation { get; set; }

    [ForeignKey("ArsellerBankAccountCurrency2")]
    [InverseProperty("ArsellerArsellerBankAccountCurrency2Navigations")]
    public virtual Gecurrency ArsellerBankAccountCurrency2Navigation { get; set; }

    [ForeignKey("ArsellerBankAccountCurrency3")]
    [InverseProperty("ArsellerArsellerBankAccountCurrency3Navigations")]
    public virtual Gecurrency ArsellerBankAccountCurrency3Navigation { get; set; }

    [ForeignKey("ArsellerBankAccountCurrency4")]
    [InverseProperty("ArsellerArsellerBankAccountCurrency4Navigations")]
    public virtual Gecurrency ArsellerBankAccountCurrency4Navigation { get; set; }

    [InverseProperty("FkArseller")]
    public virtual ICollection<ArsellerContact> ArsellerContacts { get; set; } = new List<ArsellerContact>();

    [InverseProperty("Arseller")]
    public virtual ICollection<ArsellerProductGroup> ArsellerProductGroups { get; set; } = new List<ArsellerProductGroup>();

    [InverseProperty("Arseller")]
    public virtual ICollection<ArsellerProduct> ArsellerProducts { get; set; } = new List<ArsellerProduct>();

    [InverseProperty("FasellerIdcomboNavigation")]
    public virtual ICollection<FacreditNote> FacreditNotes { get; set; } = new List<FacreditNote>();

    [InverseProperty("FasellerIdcomboNavigation")]
    public virtual ICollection<FareturnSupplier> FareturnSuppliers { get; set; } = new List<FareturnSupplier>();

    [InverseProperty("FasellerIdcomboNavigation")]
    public virtual ICollection<FasellReturn> FasellReturns { get; set; } = new List<FasellReturn>();

    [ForeignKey("FkArsellerContactLanguageIdcombo")]
    [InverseProperty("ArsellerFkArsellerContactLanguageIdcomboNavigations")]
    public virtual Gelanguage FkArsellerContactLanguageIdcomboNavigation { get; set; }

    [ForeignKey("FkArsellerParentId")]
    [InverseProperty("InverseFkArsellerParent")]
    public virtual Arseller FkArsellerParent { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArsellerFkGecurrencies")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("ArsellerFkGelanguages")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("Arsellers")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [InverseProperty("FkArsellerParent")]
    public virtual ICollection<Arseller> InverseFkArsellerParent { get; set; } = new List<Arseller>();

    [InverseProperty("Arseller")]
    public virtual ICollection<Oeproposal> Oeproposals { get; set; } = new List<Oeproposal>();
}
