using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAdjustIncreaseOrDecreaseAssets")]
public partial class AcadjustIncreaseOrDecreaseAsset
{
    [Key]
    [Column("ACAdjustIncreaseOrDecreaseAssetID")]
    public int AcadjustIncreaseOrDecreaseAssetId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("ACAdjustIncreaseOrDecreaseAssetNo")]
    [StringLength(50)]
    public string AcadjustIncreaseOrDecreaseAssetNo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetDate", TypeName = "datetime")]
    public DateTime? AcadjustIncreaseOrDecreaseAssetDate { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetType")]
    [StringLength(50)]
    public string AcadjustIncreaseOrDecreaseAssetType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    public string AcobjectType { get; set; }

    [Column("ACObjectContactAddressLine3")]
    [StringLength(512)]
    public string AcobjectContactAddressLine3 { get; set; }

    [Column("ACObjectTaxNumber")]
    [StringLength(50)]
    public string AcobjectTaxNumber { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcadjustIncreaseOrDecreaseAssetExchangeRate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_BRInvoiceBranchID")]
    public int? FkBrinvoiceBranchId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(50)]
    public string SttoolbarActionName { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetPostedStatus")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetPostedStatus { get; set; }

    [InverseProperty("FkAcadjustIncreaseOrDecreaseAsset")]
    public virtual ICollection<AcadjustIncreaseOrDecreaseAssetItem> AcadjustIncreaseOrDecreaseAssetItems { get; set; } = new List<AcadjustIncreaseOrDecreaseAssetItem>();

    [InverseProperty("FkAcadjustIncreaseOrDecreaseAsset")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcadjustIncreaseOrDecreaseAssetFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrinvoiceBranchId")]
    [InverseProperty("AcadjustIncreaseOrDecreaseAssetFkBrinvoiceBranches")]
    public virtual Brbranch FkBrinvoiceBranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcadjustIncreaseOrDecreaseAssets")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
