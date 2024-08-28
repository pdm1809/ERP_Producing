using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARRevenueForecasts")]
public partial class ArrevenueForecast
{
    [Key]
    [Column("ARRevenueForecastID")]
    public int ArrevenueForecastId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("ARRevenueForecastDate", TypeName = "datetime")]
    public DateTime ArrevenueForecastDate { get; set; }

    [Required]
    [Column("ARRevenueForecastStatus")]
    [StringLength(50)]
    public string ArrevenueForecastStatus { get; set; }

    [Required]
    [Column("ARRevenueForecastNo")]
    [StringLength(50)]
    public string ArrevenueForecastNo { get; set; }

    [Column("ARRevenueForecastYear")]
    public int ArrevenueForecastYear { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ARCustomerType")]
    [StringLength(100)]
    public string ArcustomerType { get; set; }

    [Column("ARRevenueForecastRate", TypeName = "decimal(18, 5)")]
    public decimal ArrevenueForecastRate { get; set; }

    [InverseProperty("FkArrevenueForecast")]
    public virtual ICollection<ArrevenueForecastItem> ArrevenueForecastItems { get; set; } = new List<ArrevenueForecastItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArrevenueForecasts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArrevenueForecasts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArrevenueForecasts")]
    public virtual Hremployee FkHremployee { get; set; }
}
