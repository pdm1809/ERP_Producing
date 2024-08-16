using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostItems")]
public partial class MmproductionCostItem
{
    [Key]
    [Column("MMProductionCostItemID")]
    public int MmproductionCostItemId { get; set; }

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

    [Column("MMProductionCostItemProductDesc")]
    [StringLength(512)]
    public string MmproductionCostItemProductDesc { get; set; }

    [Column("MMProductionCostItemBatchComponent")]
    public int? MmproductionCostItemBatchComponent { get; set; }

    [Column("MMProductionCostItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostItemProductQty { get; set; }

    [Column("MMProductionCostItemCompletedProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostItemCompletedProductQty { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductIdforBatch")]
    [InverseProperty("MmproductionCostItems")]
    public virtual Icproduct FkIcproductIdforBatchNavigation { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmproductionCostItems")]
    public virtual Mmproposal FkMmproposal { get; set; }
}
