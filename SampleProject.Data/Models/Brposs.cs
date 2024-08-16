using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("BRPOSs")]
[Microsoft.EntityFrameworkCore.Index("Brposno", "Brposdate", "FkArcustomerId", "BrpostypeCombo", Name = "Idx_BRPOSs")]
public partial class Brposs
{
    [Key]
    [Column("BRPOSID")]
    public int Brposid { get; set; }

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

    [Column("AAIsPrinted")]
    public bool? AaisPrinted { get; set; }

    [Required]
    [Column("BRPOSNo")]
    [StringLength(50)]
    public string Brposno { get; set; }

    [Column("BRPOSName")]
    [StringLength(50)]
    public string Brposname { get; set; }

    [Column("BRPOSStartDate", TypeName = "datetime")]
    public DateTime? BrposstartDate { get; set; }

    [Column("BRPOSDate", TypeName = "datetime")]
    public DateTime? Brposdate { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_ARPriceLevelID")]
    public int? FkArpriceLevelId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("BRPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrpaymentMethodCombo { get; set; }

    [Column("BRPOSPaymentTerm")]
    [StringLength(50)]
    public string BrpospaymentTerm { get; set; }

    [Column("BRPOSStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Brposstatus { get; set; }

    [Column("BRPOSRemark")]
    [StringLength(255)]
    public string Brposremark { get; set; }

    [Column("BRPOSDesc")]
    [StringLength(255)]
    public string Brposdesc { get; set; }

    [Column("BRPOSWeight", TypeName = "decimal(18, 5)")]
    public decimal? Brposweight { get; set; }

    [Column("BRPOSVolumn", TypeName = "decimal(18, 5)")]
    public decimal? Brposvolumn { get; set; }

    [Column("BRPOSActiveCheck")]
    public bool BrposactiveCheck { get; set; }

    [Column("BRPOSTypeCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrpostypeCombo { get; set; }

    [Column("BRPOSDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? BrposdiscountPerCent { get; set; }

    [Column("BRPOSDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrposdiscountAmount { get; set; }

    [Column("BRPOSNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrposnetAmount { get; set; }

    [Column("BRPOSTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrpostaxAmount { get; set; }

    [Column("BRPOSSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrpossubTotalAmount { get; set; }

    [Column("BRPOSTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? BrpostotalAmount { get; set; }

    [Column("BRPOSMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode01Combo { get; set; }

    [Column("BRPOSMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode02Combo { get; set; }

    [Column("BRPOSMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode03Combo { get; set; }

    [Column("BRPOSMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode04Combo { get; set; }

    [Column("BRPOSMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode05Combo { get; set; }

    [Column("BRPOSMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode06Combo { get; set; }

    [Column("BRPOSMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode07Combo { get; set; }

    [Column("BRPOSMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode08Combo { get; set; }

    [Column("BRPOSMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode09Combo { get; set; }

    [Column("BRPOSMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode10Combo { get; set; }

    [Column("BRPOSMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode11Combo { get; set; }

    [Column("BRPOSMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposmatchCode12Combo { get; set; }

    [Column("BRPOSCustomerNo")]
    [StringLength(50)]
    public string BrposcustomerNo { get; set; }

    [Column("BRPOSCustomerName")]
    [StringLength(50)]
    public string BrposcustomerName { get; set; }

    [Column("BRPOSCustomerDesc")]
    [StringLength(255)]
    public string BrposcustomerDesc { get; set; }

    [Column("BRPOSCustomerWebsite")]
    [StringLength(100)]
    public string BrposcustomerWebsite { get; set; }

    [Column("BRPOSCustomerTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposcustomerTaxNumber { get; set; }

    [Column("BRPOSCustomerCreditLimit", TypeName = "decimal(18, 5)")]
    public decimal? BrposcustomerCreditLimit { get; set; }

    [Column("BRPOSCustomerTel1")]
    [StringLength(50)]
    public string BrposcustomerTel1 { get; set; }

    [Column("BRPOSCustomerTel2")]
    [StringLength(50)]
    public string BrposcustomerTel2 { get; set; }

    [Column("BRPOSCustomerTel3")]
    [StringLength(50)]
    public string BrposcustomerTel3 { get; set; }

    [Column("BRPOSCustomerAddressStreet")]
    [StringLength(200)]
    public string BrposcustomerAddressStreet { get; set; }

    [Column("BRPOSCustomerAddressLine1")]
    [StringLength(200)]
    public string BrposcustomerAddressLine1 { get; set; }

    [Column("BRPOSCustomerAddressLine2")]
    [StringLength(200)]
    public string BrposcustomerAddressLine2 { get; set; }

    [Column("BRPOSCustomerAddressLine3")]
    [StringLength(200)]
    public string BrposcustomerAddressLine3 { get; set; }

    [Column("BRPOSCustomerAddressCity")]
    [StringLength(50)]
    public string BrposcustomerAddressCity { get; set; }

    [Column("BRPOSCustomerAddressPostalCode")]
    [StringLength(50)]
    public string BrposcustomerAddressPostalCode { get; set; }

    [Column("BRPOSCustomerAddressStateProvince")]
    [StringLength(50)]
    public string BrposcustomerAddressStateProvince { get; set; }

    [Column("BRPOSCustomerAddressZipCode")]
    [StringLength(50)]
    public string BrposcustomerAddressZipCode { get; set; }

    [Column("BRPOSCustomerAddressCountry")]
    [StringLength(50)]
    public string BrposcustomerAddressCountry { get; set; }

    [Column("BRPOSCustomerBankCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposcustomerBankCode { get; set; }

    [Column("BRPOSCustomerBankAccount1")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposcustomerBankAccount1 { get; set; }

    [Column("BRPOSCustomerBankAccountCurrency1")]
    public int? BrposcustomerBankAccountCurrency1 { get; set; }

    [Column("BRPOSCustomerBankAccount2")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposcustomerBankAccount2 { get; set; }

    [Column("BRPOSCustomerBankAccountCurrency2")]
    public int? BrposcustomerBankAccountCurrency2 { get; set; }

    [Column("BRPOSCustomerBankAccount3")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposcustomerBankAccount3 { get; set; }

    [Column("BRPOSCustomerBankAccountCurrency3")]
    public int? BrposcustomerBankAccountCurrency3 { get; set; }

    [Column("BRPOSCustomerBankAccount4")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrposcustomerBankAccount4 { get; set; }

    [Column("BRPOSCustomerBankAccountCurrency4")]
    public int? BrposcustomerBankAccountCurrency4 { get; set; }

    [Column("BRPOSCustomerBankName")]
    [StringLength(50)]
    public string BrposcustomerBankName { get; set; }

    [InverseProperty("FkBrpos")]
    public virtual ICollection<Brpositem> Brpositems { get; set; } = new List<Brpositem>();

    [InverseProperty("FkBrpos")]
    public virtual ICollection<BrposredemptionItem> BrposredemptionItems { get; set; } = new List<BrposredemptionItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Brposses")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArpriceLevelId")]
    [InverseProperty("Brposses")]
    public virtual ArpriceLevel FkArpriceLevel { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Brposses")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("Brposses")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Brposses")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Brposses")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("Brposses")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }
}
