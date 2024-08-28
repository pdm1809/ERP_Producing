using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlanItems")]
public partial class MmoperationDetailPlanItem
{
    [Key]
    [Column("MMOperationDetailPlanItemID")]
    public int MmoperationDetailPlanItemId { get; set; }

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
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_MMOperationDetailPlanID")]
    public int FkMmoperationDetailPlanId { get; set; }

    [Column("MMOperationDetailPlanItemSaleOrdeNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemSaleOrdeNo { get; set; }

    [Column("MMOperationDetailPlanItemProductNo")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemProductNo { get; set; }

    [Column("MMOperationDetailPlanItemProductName")]
    [StringLength(512)]
    public string MmoperationDetailPlanItemProductName { get; set; }

    [Column("MMOperationDetailPlanItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemProductQty { get; set; }

    [Column("MMOperationDetailPlanItemPIProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemPiproductQty { get; set; }

    [Column("MMOperationDetailPlanItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemProductHeight { get; set; }

    [Column("MMOperationDetailPlanItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemProductWidth { get; set; }

    [Column("MMOperationDetailPlanItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemProductLength { get; set; }

    [Column("MMOperationDetailPlanItemPlanNeededTime", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanItemPlanNeededTime { get; set; }

    [Column("MMOperationDetailPlanItemPlanDesc")]
    [StringLength(512)]
    public string MmoperationDetailPlanItemPlanDesc { get; set; }

    [Column("MMOperationDetailPlanItemProductSerial")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemProductSerial { get; set; }

    [Column("MMOperationDetailPlanItemPlanBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemPlanBlock { get; set; }

    [Column("MMOperationDetailPlanItemPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemPlanProductQty { get; set; }

    [Column("MMOperationDetailPlanItemProductWoodType")]
    [StringLength(50)]
    public string MmoperationDetailPlanItemProductWoodType { get; set; }

    [Column("MMOperationDetailPlanItemCartonBlocks", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemCartonBlocks { get; set; }

    [Column("MMOperationDetailPlanItemRemainProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemRemainProductQty { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("MMOperationDetailPlanItemCancelProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemCancelProductQty { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmoperationDetailPlanId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual MmoperationDetailPlan FkMmoperationDetailPlan { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmoperationDetailPlanItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmoperationDetailPlanItem")]
    public virtual ICollection<MmoperationDetailPlanCancelItem> MmoperationDetailPlanCancelItems { get; set; } = new List<MmoperationDetailPlanCancelItem>();

    [InverseProperty("FkMmoperationDetailPlanItem")]
    public virtual ICollection<MmoperationDetailPlanItemDateDetail> MmoperationDetailPlanItemDateDetails { get; set; } = new List<MmoperationDetailPlanItemDateDetail>();

    [InverseProperty("FkMmoperationDetailPlanItem")]
    public virtual ICollection<MmpurchasePlanItemTotal> MmpurchasePlanItemTotals { get; set; } = new List<MmpurchasePlanItemTotal>();
}
