using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("AREstimates")]
public partial class Arestimate
{
    [Key]
    [Column("AREstimateID")]
    public int ArestimateId { get; set; }

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

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_ARPriceLevelID")]
    public int? FkArpriceLevelId { get; set; }

    [Column("FK_GEShippingMethodID")]
    public int? FkGeshippingMethodId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICStockSlotID")]
    public int? FkIcstockSlotId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("AREstimateNo")]
    [StringLength(50)]
    public string ArestimateNo { get; set; }

    [Column("AREstimateName")]
    [StringLength(50)]
    public string ArestimateName { get; set; }

    [Column("AREstimateDesc")]
    [StringLength(512)]
    public string ArestimateDesc { get; set; }

    [Column("AREstimateDate", TypeName = "datetime")]
    public DateTime? ArestimateDate { get; set; }

    [Column("AREstimateValidateDate", TypeName = "datetime")]
    public DateTime? ArestimateValidateDate { get; set; }

    [Column("AREstimateDeliveryDate", TypeName = "datetime")]
    public DateTime? ArestimateDeliveryDate { get; set; }

    [Column("AREstimateStatus")]
    [StringLength(50)]
    public string ArestimateStatus { get; set; }

    [Column("AREstimateType")]
    [StringLength(50)]
    public string ArestimateType { get; set; }

    [Column("AREstimatePaymentTerm")]
    [StringLength(50)]
    public string ArestimatePaymentTerm { get; set; }

    [Column("AREstimatePaymentMethod")]
    [StringLength(50)]
    public string ArestimatePaymentMethod { get; set; }

    [Column("AREstimateDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateDiscountPercent { get; set; }

    [Column("AREstimateTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateTaxPercent { get; set; }

    [Column("AREstimateDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateDiscountFix { get; set; }

    [Column("AREstimateNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateNetAmount { get; set; }

    [Column("AREstimateTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateTaxAmount { get; set; }

    [Column("AREstimateSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateSubTotalAmount { get; set; }

    [Column("AREstimateTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArestimateTotalAmount { get; set; }

    [InverseProperty("FkArestimate")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkArestimate")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Arestimates")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArpriceLevelId")]
    [InverseProperty("Arestimates")]
    public virtual ArpriceLevel FkArpriceLevel { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Arestimates")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkGeshippingMethodId")]
    [InverseProperty("Arestimates")]
    public virtual GeshippingMethod FkGeshippingMethod { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Arestimates")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Arestimates")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockSlotId")]
    [InverseProperty("Arestimates")]
    public virtual IcstockSlot FkIcstockSlot { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("Arestimates")]
    public virtual Pmproject FkPmproject { get; set; }
}
