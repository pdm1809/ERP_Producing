using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("CSCompanys")]
[Microsoft.EntityFrameworkCore.Index("FkBrbranchId", Name = "Idx_CSCompanys")]
public partial class Cscompany
{
    [Key]
    [Column("CSCompanyID")]
    public int CscompanyId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GEPurchaseCurrencyID")]
    public int? FkGepurchaseCurrencyId { get; set; }

    [Column("FK_GESaleCurrencyID")]
    public int? FkGesaleCurrencyId { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("CSCompanyDesc")]
    [StringLength(200)]
    public string CscompanyDesc { get; set; }

    [Required]
    [Column("CSCompanyLicenceNumber")]
    [StringLength(50)]
    public string CscompanyLicenceNumber { get; set; }

    [Column("CSCompanyLicenceDate", TypeName = "datetime")]
    public DateTime? CscompanyLicenceDate { get; set; }

    [Required]
    [Column("CSCompanyVersionNumber")]
    [StringLength(50)]
    public string CscompanyVersionNumber { get; set; }

    [Column("CSCompanyVersionDate", TypeName = "datetime")]
    public DateTime CscompanyVersionDate { get; set; }

    [Required]
    [Column("CSCompanyAddressStreet")]
    [StringLength(255)]
    public string CscompanyAddressStreet { get; set; }

    [Column("CSCompanyAddressLine1")]
    [StringLength(255)]
    public string CscompanyAddressLine1 { get; set; }

    [Column("CSCompanyAddressLine2")]
    [StringLength(255)]
    public string CscompanyAddressLine2 { get; set; }

    [Column("CSCompanyAddressLine3")]
    [StringLength(255)]
    public string CscompanyAddressLine3 { get; set; }

    [Required]
    [Column("CSCompanyAddressCity")]
    [StringLength(50)]
    public string CscompanyAddressCity { get; set; }

    [Required]
    [Column("CSCompanyAddressPostalCode")]
    [StringLength(50)]
    public string CscompanyAddressPostalCode { get; set; }

    [Required]
    [Column("CSCompanyAddressStateProvince")]
    [StringLength(50)]
    public string CscompanyAddressStateProvince { get; set; }

    [Required]
    [Column("CSCompanyAddressZipCode")]
    [StringLength(50)]
    public string CscompanyAddressZipCode { get; set; }

    [Required]
    [Column("CSCompanyAddressCountry")]
    [StringLength(50)]
    public string CscompanyAddressCountry { get; set; }

    [Column("CSCompanyEmail")]
    [StringLength(100)]
    public string CscompanyEmail { get; set; }

    [Column("CSCompanyWebsite")]
    [StringLength(50)]
    public string CscompanyWebsite { get; set; }

    [Column("CSCompanyCellPhone")]
    [StringLength(50)]
    public string CscompanyCellPhone { get; set; }

    [Column("CSCompanyPhone")]
    [StringLength(50)]
    public string CscompanyPhone { get; set; }

    [Column("CSCompanyFax")]
    [StringLength(50)]
    public string CscompanyFax { get; set; }

    [Column("CSCompanyInformation")]
    [StringLength(255)]
    public string CscompanyInformation { get; set; }

    [Column("CSCompanyLogo")]
    [StringLength(512)]
    public string CscompanyLogo { get; set; }

    [Column("CSCompanyTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string CscompanyTaxNumber { get; set; }

    [Column("CSCompanyBankName")]
    [StringLength(50)]
    public string CscompanyBankName { get; set; }

    [Column("CSCompanyBankCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string CscompanyBankCode { get; set; }

    [Column("CSCompanyManager")]
    [StringLength(100)]
    public string CscompanyManager { get; set; }

    [Column("CSCompanyAllowNegativeInventory")]
    public bool? CscompanyAllowNegativeInventory { get; set; }

    [Column("CSCompanyPurchaseExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? CscompanyPurchaseExchangeRate { get; set; }

    [Column("CSCompanySaleExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? CscompanySaleExchangeRate { get; set; }

    [Column("CSCostMethod")]
    [StringLength(50)]
    [Unicode(false)]
    public string CscostMethod { get; set; }

    [Column("CSCompanyReportPeriod")]
    public byte? CscompanyReportPeriod { get; set; }

    [Column("CSCompanyStartMonth")]
    public byte? CscompanyStartMonth { get; set; }

    [Column("CSCompanyIncomeTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? CscompanyIncomeTaxPercent { get; set; }

    [Column("CSCompanySocialInsPercent", TypeName = "decimal(18, 5)")]
    public decimal? CscompanySocialInsPercent { get; set; }

    [Column("CSCompanyHealthInsPercent", TypeName = "decimal(18, 5)")]
    public decimal? CscompanyHealthInsPercent { get; set; }

    [Column("CSCompanyOutOfWorkInsPercent", TypeName = "decimal(18, 5)")]
    public decimal? CscompanyOutOfWorkInsPercent { get; set; }

    [Column("CSCompanySyndicatePercent", TypeName = "decimal(18, 5)")]
    public decimal? CscompanySyndicatePercent { get; set; }

    [Column("CSCompanyAccountingBeginDateConfig", TypeName = "datetime")]
    public DateTime? CscompanyAccountingBeginDateConfig { get; set; }

    [Column("CSCompanyStartDate", TypeName = "datetime")]
    public DateTime? CscompanyStartDate { get; set; }

    [Column("CSCompanyIsShowDataByBranch")]
    public bool? CscompanyIsShowDataByBranch { get; set; }

    [Column("CSCompanyExceededDay")]
    public int? CscompanyExceededDay { get; set; }

    [Column("CSCompanyDesc1")]
    [StringLength(256)]
    public string CscompanyDesc1 { get; set; }

    [Column("CSCompanyAddressStreet1")]
    [StringLength(256)]
    public string CscompanyAddressStreet1 { get; set; }

    [Column("CSSourceSellingPriceMethod")]
    [StringLength(50)]
    [Unicode(false)]
    public string CssourceSellingPriceMethod { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Cscompanies")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("Cscompanies")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkGepurchaseCurrencyId")]
    [InverseProperty("CscompanyFkGepurchaseCurrencies")]
    public virtual Gecurrency FkGepurchaseCurrency { get; set; }

    [ForeignKey("FkGesaleCurrencyId")]
    [InverseProperty("CscompanyFkGesaleCurrencies")]
    public virtual Gecurrency FkGesaleCurrency { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Cscompanies")]
    public virtual Icstock FkIcstock { get; set; }

    [InverseProperty("FkCscompany")]
    public virtual ICollection<HrconfigSalesTarget> HrconfigSalesTargets { get; set; } = new List<HrconfigSalesTarget>();

    [InverseProperty("FkCscompany")]
    public virtual ICollection<HrsplitRatio> HrsplitRatios { get; set; } = new List<HrsplitRatio>();
}
