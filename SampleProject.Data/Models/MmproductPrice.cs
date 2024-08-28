using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductPrices")]
public partial class MmproductPrice
{
    [Key]
    [Column("MMProductPriceID")]
    public int MmproductPriceId { get; set; }

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

    [Column("MMProductPriceProductDesc")]
    [StringLength(512)]
    public string MmproductPriceProductDesc { get; set; }

    [Column("MMProductPriceBatchComponent")]
    public int? MmproductPriceBatchComponent { get; set; }

    [Column("MMProductPriceProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceProductQty { get; set; }

    [Column("MMProductPriceProductPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceProductPrice { get; set; }

    [Column("MMProductPriceIngredientReceipt", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIngredientReceipt { get; set; }

    [Column("MMProductPriceIngredientShipment", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceIngredientShipment { get; set; }

    [Column("MMProductPriceDirectLabor", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceDirectLabor { get; set; }

    [Column("MMProductPriceOverallProduction6271", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceOverallProduction6271 { get; set; }

    [Column("MMProductPriceOverallProduction6272", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceOverallProduction6272 { get; set; }

    [Column("MMProductPriceOverallProduction6273", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceOverallProduction6273 { get; set; }

    [Column("MMProductPriceOverallProduction6274", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceOverallProduction6274 { get; set; }

    [Column("MMProductPriceOverallProduction6277", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceOverallProduction6277 { get; set; }

    [Column("MMProductPriceOverallProduction6278", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceOverallProduction6278 { get; set; }

    [Column("MMProductPriceProductSeriesNo")]
    [StringLength(50)]
    public string MmproductPriceProductSeriesNo { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("MMProductPriceProductCompletedQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductPriceProductCompletedQty { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductPrices")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmproductPrices")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproductPrices")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductPrices")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductIdforBatch")]
    [InverseProperty("MmproductPrices")]
    public virtual Icproduct FkIcproductIdforBatchNavigation { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("MmproductPrices")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductPrices")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductPrices")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductPrices")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmproductPrices")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmproductPrices")]
    public virtual Mmproposal FkMmproposal { get; set; }
}
