using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAdjustIncreaseOrDecreaseAssetItems")]
public partial class AcadjustIncreaseOrDecreaseAssetItem
{
    [Key]
    [Column("ACAdjustIncreaseOrDecreaseAssetItemID")]
    public int AcadjustIncreaseOrDecreaseAssetItemId { get; set; }

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

    [Column("FK_ACAdjustIncreaseOrDecreaseAssetID")]
    public int FkAcadjustIncreaseOrDecreaseAssetId { get; set; }

    [Column("FK_ACAssetID")]
    public int FkAcassetId { get; set; }

    [Required]
    [Column("ACAdjustIncreaseOrDecreaseAssetItemNo")]
    [StringLength(50)]
    public string AcadjustIncreaseOrDecreaseAssetItemNo { get; set; }

    [Required]
    [Column("ACAdjustIncreaseOrDecreaseAssetItemName")]
    [StringLength(100)]
    public string AcadjustIncreaseOrDecreaseAssetItemName { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemDesc")]
    [StringLength(512)]
    public string AcadjustIncreaseOrDecreaseAssetItemDesc { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemRemainDepreciation")]
    public int? AcadjustIncreaseOrDecreaseAssetItemRemainDepreciation { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemBeginDate", TypeName = "datetime")]
    public DateTime? AcadjustIncreaseOrDecreaseAssetItemBeginDate { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcadjustIncreaseOrDecreaseAssetItemAmount { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcadjustIncreaseOrDecreaseAssetItemTaxPercent { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcadjustIncreaseOrDecreaseAssetItemTaxAmount { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcadjustIncreaseOrDecreaseAssetItemTotalAmount { get; set; }

    [Column("ACInputVATDocumentType")]
    [StringLength(1000)]
    public string AcinputVatdocumentType { get; set; }

    [Column("ACInputVATStatus")]
    [StringLength(50)]
    public string AcinputVatstatus { get; set; }

    [Column("ACInvoiceInSupplierNo")]
    [StringLength(50)]
    public string AcinvoiceInSupplierNo { get; set; }

    [Column("ACInvoiceInVATSymbol")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcinvoiceInVatsymbol { get; set; }

    [Column("ACInvoiceInVATDate", TypeName = "datetime")]
    public DateTime? AcinvoiceInVatdate { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode01Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode01Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode02Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode02Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode03Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode03Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode04Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode04Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode05Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode05Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode06Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode06Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode07Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode07Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode08Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode08Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode09Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode09Combo { get; set; }

    [Column("ACAdjustIncreaseOrDecreaseAssetItemCode10Combo")]
    [StringLength(256)]
    public string AcadjustIncreaseOrDecreaseAssetItemCode10Combo { get; set; }

    [ForeignKey("FkAcadjustIncreaseOrDecreaseAssetId")]
    [InverseProperty("AcadjustIncreaseOrDecreaseAssetItems")]
    public virtual AcadjustIncreaseOrDecreaseAsset FkAcadjustIncreaseOrDecreaseAsset { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("AcadjustIncreaseOrDecreaseAssetItems")]
    public virtual Acasset FkAcasset { get; set; }
}
