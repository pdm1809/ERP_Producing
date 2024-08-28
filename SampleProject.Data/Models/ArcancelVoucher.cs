using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCancelVouchers")]
[Microsoft.EntityFrameworkCore.Index("ArcancelVoucherNo", "ArcancelVoucherDate", "FkBrbranchId", "FkArcustomerId", "ArcancelVoucherType", Name = "Idx_ARCancelVouchers")]
public partial class ArcancelVoucher
{
    [Key]
    [Column("ARCancelVoucherID")]
    public int ArcancelVoucherId { get; set; }

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
    public int? FkArcustomerId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("ARCancelVoucherNo")]
    [StringLength(50)]
    public string ArcancelVoucherNo { get; set; }

    [Column("ARCancelVoucherName")]
    [StringLength(100)]
    public string ArcancelVoucherName { get; set; }

    [Column("ARCancelVoucherDesc")]
    [StringLength(512)]
    public string ArcancelVoucherDesc { get; set; }

    [Column("ARCancelVoucherDate", TypeName = "datetime")]
    public DateTime? ArcancelVoucherDate { get; set; }

    [Column("ARCancelVoucherType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcancelVoucherType { get; set; }

    [Column("ARCancelVoucherStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcancelVoucherStatus { get; set; }

    [Column("ARCancelVoucherDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherDiscountPerCent { get; set; }

    [Column("ARCancelVoucherDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherDiscountFix { get; set; }

    [Column("ARCancelVoucherNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherNetAmount { get; set; }

    [Column("ARCancelVoucherTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherTaxPercent { get; set; }

    [Column("ARCancelVoucherTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherTaxAmount { get; set; }

    [Column("ARCancelVoucherSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherSubTotalAmount { get; set; }

    [Column("ARCancelVoucherTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherTotalAmount { get; set; }

    [Column("ARCancelVoucherExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? ArcancelVoucherExchangeRate { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ARCancelVoucherTransferredDate", TypeName = "datetime")]
    public DateTime? ArcancelVoucherTransferredDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("ARCancelVoucherReason")]
    [StringLength(50)]
    public string ArcancelVoucherReason { get; set; }

    [Column("ARCancelVoucherProject")]
    [StringLength(100)]
    public string ArcancelVoucherProject { get; set; }

    [Column("ARCancelVoucherSaleContract")]
    [StringLength(100)]
    public string ArcancelVoucherSaleContract { get; set; }

    [Column("ARCancelVoucherComment")]
    public byte[] ArcancelVoucherComment { get; set; }

    [InverseProperty("FkArcancelVoucher")]
    public virtual ICollection<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; } = new List<ArcancelVoucherItemCost>();

    [InverseProperty("FkArcancelVoucher")]
    public virtual ICollection<ArcancelVoucherItem> ArcancelVoucherItems { get; set; } = new List<ArcancelVoucherItem>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ArcancelVouchers")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcancelVouchers")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("ArcancelVouchers")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArcancelVouchers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArcancelVouchers")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcancelVouchers")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("ArcancelVouchers")]
    public virtual Pmproject FkPmproject { get; set; }
}
