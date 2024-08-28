using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostOveralls")]
public partial class MmproductionCostOverall
{
    [Key]
    [Column("MMProductionCostOverallID")]
    public int MmproductionCostOverallId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(256)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(256)]
    public string AaupdatedUser { get; set; }

    [Column("FK_MMProductionCostID")]
    public int FkMmproductionCostId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_MMProposalID")]
    public int? FkMmproposalId { get; set; }

    [Column("MMProductionCostOverallProductNo")]
    [StringLength(50)]
    public string MmproductionCostOverallProductNo { get; set; }

    [Column("MMProductionCostOverallProductName")]
    [StringLength(256)]
    public string MmproductionCostOverallProductName { get; set; }

    [Column("MMProductionCostOverallProductDesc")]
    [StringLength(512)]
    public string MmproductionCostOverallProductDesc { get; set; }

    [Column("MMProductionCostOverallBatchComponent")]
    public int? MmproductionCostOverallBatchComponent { get; set; }

    [Column("MMProductionCostOverallCostTypeCombo")]
    [StringLength(256)]
    public string MmproductionCostOverallCostTypeCombo { get; set; }

    [Column("MMProductionCostOverallTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOverallTotalCost { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("MMProductionCostOverallShipmentNo")]
    [StringLength(50)]
    public string MmproductionCostOverallShipmentNo { get; set; }

    [Column("MMProductionCostOverallShipmentDesc")]
    [StringLength(512)]
    public string MmproductionCostOverallShipmentDesc { get; set; }

    [Column("MMProductionCostOverallShipmentDate", TypeName = "datetime")]
    public DateTime? MmproductionCostOverallShipmentDate { get; set; }

    [Column("MMProductionCostOverallShipmentItemID")]
    public int? MmproductionCostOverallShipmentItemId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("MMProductionCostOverallProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostOverallProductSerialNo { get; set; }

    [Column("MMProductionCostOverallProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOverallProductUnitPrice { get; set; }

    [Column("MMProductionCostOverallProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOverallProductUnitCost { get; set; }

    [Column("MMProductionCostOverallShipmentItemComment")]
    [StringLength(512)]
    public string MmproductionCostOverallShipmentItemComment { get; set; }

    [Column("MMProductionCostOverallProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOverallProductQty { get; set; }

    [Column("MMProductionCostOverallShipmentItemNetAmount", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOverallShipmentItemNetAmount { get; set; }

    [Column("MMProductionCostOverallShipmentItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOverallShipmentItemTotalAmount { get; set; }

    [Column("MMProductionCostOverallShipmentItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOverallShipmentItemTotalCost { get; set; }

    [Column("MMProductionCostOverallProductSupplierNo")]
    [StringLength(50)]
    public string MmproductionCostOverallProductSupplierNo { get; set; }

    [Column("MMProductionCostOverallProductBatchQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOverallProductBatchQty { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductionCostOveralls")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionCostOveralls")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostOveralls")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostOveralls")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostOveralls")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmproductionCostOveralls")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmproductionCostOveralls")]
    public virtual Mmproposal FkMmproposal { get; set; }
}
