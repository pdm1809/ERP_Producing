using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARAdjustSaleOrderQuantitys")]
public partial class AradjustSaleOrderQuantity
{
    [Key]
    [Column("ARAdjustSaleOrderQuantityID")]
    public int AradjustSaleOrderQuantityId { get; set; }

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

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ARAdjustSaleOrderQuantityNo")]
    [StringLength(50)]
    public string AradjustSaleOrderQuantityNo { get; set; }

    [Column("ARAdjustSaleOrderQuantityName")]
    [StringLength(100)]
    public string AradjustSaleOrderQuantityName { get; set; }

    [Column("ARAdjustSaleOrderQuantityDesc")]
    [StringLength(512)]
    public string AradjustSaleOrderQuantityDesc { get; set; }

    [Column("ARAdjustSaleOrderQuantityComment")]
    [StringLength(512)]
    public string AradjustSaleOrderQuantityComment { get; set; }

    [Column("ARAdjustSaleOrderQuantityDate", TypeName = "datetime")]
    public DateTime? AradjustSaleOrderQuantityDate { get; set; }

    [Column("ARAdjustSaleOrderQuantityType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AradjustSaleOrderQuantityType { get; set; }

    [Column("ARAdjustSaleOrderQuantityStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AradjustSaleOrderQuantityStatus { get; set; }

    [Column("ARAdjustSaleOrderQuantityDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityDiscountPerCent { get; set; }

    [Column("ARAdjustSaleOrderQuantityDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityDiscountFix { get; set; }

    [Column("ARAdjustSaleOrderQuantityNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityNetAmount { get; set; }

    [Column("ARAdjustSaleOrderQuantityTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityTaxPercent { get; set; }

    [Column("ARAdjustSaleOrderQuantityTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityTaxAmount { get; set; }

    [Column("ARAdjustSaleOrderQuantitySubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantitySubTotalAmount { get; set; }

    [Column("ARAdjustSaleOrderQuantityTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityTotalAmount { get; set; }

    [Column("ARAdjustSaleOrderQuantityExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AradjustSaleOrderQuantityExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARAdjustSaleOrderQuantityTransferredDate", TypeName = "datetime")]
    public DateTime? AradjustSaleOrderQuantityTransferredDate { get; set; }

    [InverseProperty("FkAradjustSaleOrderQuantity")]
    public virtual ICollection<AradjustSaleOrderQuantityItem> AradjustSaleOrderQuantityItems { get; set; } = new List<AradjustSaleOrderQuantityItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("AradjustSaleOrderQuantities")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AradjustSaleOrderQuantities")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AradjustSaleOrderQuantities")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AradjustSaleOrderQuantities")]
    public virtual Hremployee FkHremployee { get; set; }
}
