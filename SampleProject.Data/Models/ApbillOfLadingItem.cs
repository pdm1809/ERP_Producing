using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APBillOfLadingItems")]
public partial class ApbillOfLadingItem
{
    [Key]
    [Column("APBillOfLadingItemID")]
    public int ApbillOfLadingItemId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APBillOfLadingID")]
    public int? FkApbillOfLadingId { get; set; }

    [Column("APBillOfLadingItemProductDesc")]
    [StringLength(500)]
    public string ApbillOfLadingItemProductDesc { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("APBillOfLadingItemHSCode")]
    [StringLength(50)]
    public string ApbillOfLadingItemHscode { get; set; }

    [Column("APBillOfLadingItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemProductQty { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("APBillOfLadingItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemProductUnitCost { get; set; }

    [Column("APBillOfLadingItemProductUnitCostExchange", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemProductUnitCostExchange { get; set; }

    [Column("APBillOfLadingItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemTotalCost { get; set; }

    [Column("APBillOfLadingItemTotalCostExchange", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemTotalCostExchange { get; set; }

    [Column("APBillOfLadingItemImportTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemImportTaxPercent { get; set; }

    [Column("APBillOfLadingItemImportTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemImportTaxAmount { get; set; }

    [Column("APBillOfLadingItemConsumptionTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemConsumptionTaxPercent { get; set; }

    [Column("APBillOfLadingItemConsumptionTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemConsumptionTaxAmount { get; set; }

    [Column("APBillOfLadingItemEnviromentTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemEnviromentTaxPercent { get; set; }

    [Column("APBillOfLadingItemEnviromentTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemEnviromentTaxAmount { get; set; }

    [Column("APBillOfLadingItemVATTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemVattaxPercent { get; set; }

    [Column("APBillOfLadingItemVATTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemVattaxAmount { get; set; }

    [Column("APBillOfLadingItemTotalTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemTotalTaxAmount { get; set; }

    [Column("APBillOfLadingItemDOFee", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemDofee { get; set; }

    [Column("APBillOfLadingItemCleaningContFee", TypeName = "decimal(18, 5)")]
    public decimal? ApbillOfLadingItemCleaningContFee { get; set; }

    [ForeignKey("FkApbillOfLadingId")]
    [InverseProperty("ApbillOfLadingItems")]
    public virtual ApbillOfLading FkApbillOfLading { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ApbillOfLadingItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApbillOfLadingItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [InverseProperty("FkApbillOfLadingItem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();
}
