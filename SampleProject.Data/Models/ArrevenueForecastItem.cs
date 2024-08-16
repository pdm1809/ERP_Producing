using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARRevenueForecastItems")]
public partial class ArrevenueForecastItem
{
    [Key]
    [Column("ARRevenueForecastItemID")]
    public int ArrevenueForecastItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ARRevenueForecastID")]
    public int FkArrevenueForecastId { get; set; }

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("ARRevenueForecastItemCustomerNo")]
    [StringLength(50)]
    public string ArrevenueForecastItemCustomerNo { get; set; }

    [Column("ARRevenueForecastItemCustomerName")]
    [StringLength(200)]
    public string ArrevenueForecastItemCustomerName { get; set; }

    [Column("ARRevenueForecastItemCustomerAddressLine3")]
    [StringLength(500)]
    public string ArrevenueForecastItemCustomerAddressLine3 { get; set; }

    [Column("ARRevenueForecastItemCustomerEmail")]
    [StringLength(50)]
    public string ArrevenueForecastItemCustomerEmail { get; set; }

    [Column("ARRevenueForecastItemCustomerTel")]
    [StringLength(20)]
    public string ArrevenueForecastItemCustomerTel { get; set; }

    [Column("ARRevenueForecastItemPreJanuary", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreJanuary { get; set; }

    [Column("ARRevenueForecastItemPreFebuary", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreFebuary { get; set; }

    [Column("ARRevenueForecastItemPreMarch", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreMarch { get; set; }

    [Column("ARRevenueForecastItemPreApril", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreApril { get; set; }

    [Column("ARRevenueForecastItemPreMay", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreMay { get; set; }

    [Column("ARRevenueForecastItemPreJune", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreJune { get; set; }

    [Column("ARRevenueForecastItemPreJuly", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreJuly { get; set; }

    [Column("ARRevenueForecastItemPreAugust", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreAugust { get; set; }

    [Column("ARRevenueForecastItemPreSeptember", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreSeptember { get; set; }

    [Column("ARRevenueForecastItemPreOctober", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreOctober { get; set; }

    [Column("ARRevenueForecastItemPreNovember", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreNovember { get; set; }

    [Column("ARRevenueForecastItemPreDecember", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPreDecember { get; set; }

    [Column("ARRevenueForecastItemPre1January", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1January { get; set; }

    [Column("ARRevenueForecastItemPre1Febuary", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1Febuary { get; set; }

    [Column("ARRevenueForecastItemPre1March", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1March { get; set; }

    [Column("ARRevenueForecastItemPre1April", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1April { get; set; }

    [Column("ARRevenueForecastItemPre1May", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1May { get; set; }

    [Column("ARRevenueForecastItemPre1June", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1June { get; set; }

    [Column("ARRevenueForecastItemPre1July", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1July { get; set; }

    [Column("ARRevenueForecastItemPre1August", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1August { get; set; }

    [Column("ARRevenueForecastItemPre1September", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1September { get; set; }

    [Column("ARRevenueForecastItemPre1October", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1October { get; set; }

    [Column("ARRevenueForecastItemPre1November", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1November { get; set; }

    [Column("ARRevenueForecastItemPre1December", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre1December { get; set; }

    [Column("ARRevenueForecastItemPre2January", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2January { get; set; }

    [Column("ARRevenueForecastItemPre2Febuary", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2Febuary { get; set; }

    [Column("ARRevenueForecastItemPre2March", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2March { get; set; }

    [Column("ARRevenueForecastItemPre2April", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2April { get; set; }

    [Column("ARRevenueForecastItemPre2May", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2May { get; set; }

    [Column("ARRevenueForecastItemPre2June", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2June { get; set; }

    [Column("ARRevenueForecastItemPre2July", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2July { get; set; }

    [Column("ARRevenueForecastItemPre2August", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2August { get; set; }

    [Column("ARRevenueForecastItemPre2September", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2September { get; set; }

    [Column("ARRevenueForecastItemPre2October", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2October { get; set; }

    [Column("ARRevenueForecastItemPre2November", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2November { get; set; }

    [Column("ARRevenueForecastItemPre2December", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPre2December { get; set; }

    [Column("ARRevenueForecastItemPredictAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictAmount { get; set; }

    [Column("ARRevenueForecastItemPredictSalePercent", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictSalePercent { get; set; }

    [Column("ARRevenueForecastItemPredictSaleAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictSaleAmount { get; set; }

    [Column("ARRevenueForecastItemPredictAcceptPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictAcceptPercent { get; set; }

    [Column("ARRevenueForecastItemPredictAcceptAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictAcceptAmount { get; set; }

    [Column("ARRevenueForecastItemPredictJanuary", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictJanuary { get; set; }

    [Column("ARRevenueForecastItemPredictFebuary", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictFebuary { get; set; }

    [Column("ARRevenueForecastItemPredictMarch", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictMarch { get; set; }

    [Column("ARRevenueForecastItemPredictApril", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictApril { get; set; }

    [Column("ARRevenueForecastItemPredictMay", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictMay { get; set; }

    [Column("ARRevenueForecastItemPredictJune", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictJune { get; set; }

    [Column("ARRevenueForecastItemPredictJuly", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictJuly { get; set; }

    [Column("ARRevenueForecastItemPredictAugust", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictAugust { get; set; }

    [Column("ARRevenueForecastItemPredictSeptember", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictSeptember { get; set; }

    [Column("ARRevenueForecastItemPredictOctober", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictOctober { get; set; }

    [Column("ARRevenueForecastItemPredictNovember", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictNovember { get; set; }

    [Column("ARRevenueForecastItemPredictDecember", TypeName = "decimal(18, 5)")]
    public decimal? ArrevenueForecastItemPredictDecember { get; set; }

    [Column("ARRevenueForecastItemPredictComment")]
    [StringLength(500)]
    public string ArrevenueForecastItemPredictComment { get; set; }

    [Column("ARRevenueForecastItemPredictRealComment")]
    [StringLength(500)]
    public string ArrevenueForecastItemPredictRealComment { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArrevenueForecastItems")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArrevenueForecastId")]
    [InverseProperty("ArrevenueForecastItems")]
    public virtual ArrevenueForecast FkArrevenueForecast { get; set; }
}
