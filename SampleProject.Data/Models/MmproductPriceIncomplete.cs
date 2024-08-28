using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductPriceIncompletes")]
public partial class MmproductPriceIncomplete
{
    [Key]
    [Column("MMProductPriceIncompleteID")]
    public int MmproductPriceIncompleteId { get; set; }

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

    [Column("FK_MMProductionCostID")]
    public int FkMmproductionCostId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_ICProductIDForBatch")]
    public int? FkIcproductIdforBatch { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_MMProposalID")]
    public int? FkMmproposalId { get; set; }

    [Column("MMProductPriceIncompleteProductDesc")]
    [StringLength(512)]
    public string MmproductPriceIncompleteProductDesc { get; set; }

    [Column("MMProductPriceIncompleteBatchComponent")]
    public int? MmproductPriceIncompleteBatchComponent { get; set; }

    [Column("MMProductPriceIncompleteProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteProductQty { get; set; }

    [Column("MMProductPriceIncompleteProductPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteProductPrice { get; set; }

    [Column("MMProductPriceIncompleteUnfinishedPercent", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteUnfinishedPercent { get; set; }

    [Column("MMProductPriceIncompleteUnfinishedProductPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteUnfinishedProductPrice { get; set; }

    [Column("MMProductPriceIncompleteIngredientReceipt", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteIngredientReceipt { get; set; }

    [Column("MMProductPriceIncompleteIngredientShipment", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteIngredientShipment { get; set; }

    [Column("MMProductPriceIncompleteDirectLabor", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteDirectLabor { get; set; }

    [Column("MMProductPriceIncompleteOverallProduction6271", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteOverallProduction6271 { get; set; }

    [Column("MMProductPriceIncompleteOverallProduction6272", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteOverallProduction6272 { get; set; }

    [Column("MMProductPriceIncompleteOverallProduction6273", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteOverallProduction6273 { get; set; }

    [Column("MMProductPriceIncompleteOverallProduction6274", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteOverallProduction6274 { get; set; }

    [Column("MMProductPriceIncompleteOverallProduction6277", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteOverallProduction6277 { get; set; }

    [Column("MMProductPriceIncompleteOverallProduction6278", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIncompleteOverallProduction6278 { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductIdforBatch")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual Icproduct FkIcproductIdforBatchNavigation { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmproductPriceIncompletes")]
    public virtual Mmproposal FkMmproposal { get; set; }
}
