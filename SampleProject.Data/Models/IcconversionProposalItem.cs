using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICConversionProposalItems")]
public partial class IcconversionProposalItem
{
    [Key]
    [Column("ICConversionProposalItemID")]
    public int IcconversionProposalItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICConversionProposalID")]
    public int? FkIcconversionProposalId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICConversionProposalItemSortOrder")]
    public int? IcconversionProposalItemSortOrder { get; set; }

    [Column("ICConversionProposalItemProductType")]
    [StringLength(50)]
    public string IcconversionProposalItemProductType { get; set; }

    [Column("ICConversionProposalItemProductSerialNo")]
    [StringLength(50)]
    public string IcconversionProposalItemProductSerialNo { get; set; }

    [Column("ICConversionProposalItemProductName")]
    [StringLength(256)]
    public string IcconversionProposalItemProductName { get; set; }

    [Column("ICConversionProposalItemProductDesc")]
    [StringLength(512)]
    public string IcconversionProposalItemProductDesc { get; set; }

    [Column("ICConversionProposalItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? IcconversionProposalItemProductQty { get; set; }

    [Column("ICConversionProposalItemComment")]
    [StringLength(512)]
    public string IcconversionProposalItemComment { get; set; }

    [Column("ICConversionProposalItemProductNoOfOldSys")]
    [StringLength(100)]
    public string IcconversionProposalItemProductNoOfOldSys { get; set; }

    [Column("ICConversionProposalItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcconversionProposalItemProductHeight { get; set; }

    [Column("ICConversionProposalItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcconversionProposalItemProductWidth { get; set; }

    [Column("ICConversionProposalItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcconversionProposalItemProductLength { get; set; }

    [Column("ICConversionProposalItemProductNo")]
    [StringLength(50)]
    public string IcconversionProposalItemProductNo { get; set; }

    [Column("ICConversionProposalItemProductLotNo")]
    [StringLength(50)]
    public string IcconversionProposalItemProductLotNo { get; set; }

    [Column("ICConversionProposalItemSupplierName")]
    [StringLength(256)]
    public string IcconversionProposalItemSupplierName { get; set; }

    [Column("ICConversionProposalItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? IcconversionProposalItemWoodQty { get; set; }

    [Column("ICConversionProposalItemLocation")]
    [StringLength(256)]
    public string IcconversionProposalItemLocation { get; set; }

    [Column("FK_MMAllocationPlanID")]
    public int? FkMmallocationPlanId { get; set; }

    [Column("FK_MMAllocationPlanItemID")]
    public int? FkMmallocationPlanItemId { get; set; }

    [Column("ICConversionProposalItemRemainQty", TypeName = "decimal(18, 5)")]
    public decimal? IcconversionProposalItemRemainQty { get; set; }

    [Column("ICConversionProposalItemSplitRate", TypeName = "decimal(18, 5)")]
    public decimal? IcconversionProposalItemSplitRate { get; set; }

    [Column("ICConversionProposalItemAllocationPlanLength", TypeName = "decimal(18, 5)")]
    public decimal? IcconversionProposalItemAllocationPlanLength { get; set; }

    [ForeignKey("FkIcconversionProposalId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual IcconversionProposal FkIcconversionProposal { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmallocationPlanId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual MmallocationPlan FkMmallocationPlan { get; set; }

    [ForeignKey("FkMmallocationPlanItemId")]
    [InverseProperty("IcconversionProposalItems")]
    public virtual MmallocationPlanItem FkMmallocationPlanItem { get; set; }

    [InverseProperty("FkIcconversionProposalItem")]
    public virtual ICollection<IcproductConversionItem> IcproductConversionItems { get; set; } = new List<IcproductConversionItem>();
}
