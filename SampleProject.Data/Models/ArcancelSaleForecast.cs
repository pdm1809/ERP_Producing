using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCancelSaleForecasts")]
public partial class ArcancelSaleForecast
{
    [Key]
    [Column("ARCancelSaleForecastID")]
    public int ArcancelSaleForecastId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ARSaleForecastID")]
    public int? FkArsaleForecastId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ARCancelSaleForecastNo")]
    [StringLength(50)]
    public string ArcancelSaleForecastNo { get; set; }

    [Column("ARCancelSaleForecastName")]
    [StringLength(100)]
    public string ArcancelSaleForecastName { get; set; }

    [Column("ARCancelSaleForecastDesc")]
    [StringLength(512)]
    public string ArcancelSaleForecastDesc { get; set; }

    [Column("ARCancelSaleForecastDate", TypeName = "datetime")]
    public DateTime? ArcancelSaleForecastDate { get; set; }

    [Column("ARCancelSaleForecastType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcancelSaleForecastType { get; set; }

    [Column("ARCancelSaleForecastStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcancelSaleForecastStatus { get; set; }

    [Column("ARCancelSaleForecastDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastDiscountPerCent { get; set; }

    [Column("ARCancelSaleForecastDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastDiscountFix { get; set; }

    [Column("ARCancelSaleForecastNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastNetAmount { get; set; }

    [Column("ARCancelSaleForecastTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastTaxPercent { get; set; }

    [Column("ARCancelSaleForecastTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastTaxAmount { get; set; }

    [Column("ARCancelSaleForecastSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastSubTotalAmount { get; set; }

    [Column("ARCancelSaleForecastTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastTotalAmount { get; set; }

    [Column("ARCancelSaleForecastExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelSaleForecastExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARCancelSaleForecastTransferredDate", TypeName = "datetime")]
    public DateTime? ArcancelSaleForecastTransferredDate { get; set; }

    [Column("ARCancelSaleForecastComment")]
    public byte[] ArcancelSaleForecastComment { get; set; }

    [InverseProperty("FkArcancelSaleForecast")]
    public virtual ICollection<ArcancelSaleForecastItem> ArcancelSaleForecastItems { get; set; } = new List<ArcancelSaleForecastItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcancelSaleForecasts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleForecastId")]
    [InverseProperty("ArcancelSaleForecasts")]
    public virtual ArsaleForecast FkArsaleForecast { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArcancelSaleForecasts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArcancelSaleForecasts")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcancelSaleForecasts")]
    public virtual Hremployee FkHremployee { get; set; }
}
