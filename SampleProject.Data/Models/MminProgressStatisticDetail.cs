using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMInProgressStatisticDetails")]
public partial class MminProgressStatisticDetail
{
    [Key]
    [Column("MMInProgressStatisticDetailID")]
    public int MminProgressStatisticDetailId { get; set; }

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

    [Column("FK_MMInProgressStatisticID")]
    public int? FkMminProgressStatisticId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_MMProductionCostFactorID")]
    public int? FkMmproductionCostFactorId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("MMInProgressStatisticDetailProductNo")]
    [StringLength(50)]
    public string MminProgressStatisticDetailProductNo { get; set; }

    [Column("MMInProgressStatisticDetailProductName")]
    [StringLength(512)]
    public string MminProgressStatisticDetailProductName { get; set; }

    [Column("MMInProgressStatisticDetailQty", TypeName = "decimal(18, 6)")]
    public decimal? MminProgressStatisticDetailQty { get; set; }

    [Column("MMInProgressStatisticDetailValue", TypeName = "decimal(18, 6)")]
    public decimal? MminProgressStatisticDetailValue { get; set; }

    [Column("MMInProgressStatisticDetailProductQty", TypeName = "decimal(18, 6)")]
    public decimal? MminProgressStatisticDetailProductQty { get; set; }

    [Column("MMInProgressStatisticDetailPercent", TypeName = "decimal(18, 6)")]
    public decimal? MminProgressStatisticDetailPercent { get; set; }

    [Column("MMInProgressStatisticDetailReceiptSerialNo")]
    [StringLength(100)]
    public string MminProgressStatisticDetailReceiptSerialNo { get; set; }

    [Column("MMInProgressStatisticDetailUnitCost", TypeName = "decimal(18, 6)")]
    public decimal? MminProgressStatisticDetailUnitCost { get; set; }

    [Column("MMInProgressStatisticDetailGroupType")]
    [StringLength(100)]
    public string MminProgressStatisticDetailGroupType { get; set; }

    [Column("MMProductionCostInProgressCalType")]
    [StringLength(100)]
    public string MmproductionCostInProgressCalType { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("MminProgressStatisticDetailFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcoffsetAccountId")]
    [InverseProperty("MminProgressStatisticDetailFkAcoffsetAccounts")]
    public virtual Acaccount FkAcoffsetAccount { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MminProgressStatisticDetails")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MminProgressStatisticDetailFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("MminProgressStatisticDetailFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MminProgressStatisticDetails")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MminProgressStatisticDetails")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MminProgressStatisticDetails")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMminProgressStatisticId")]
    [InverseProperty("MminProgressStatisticDetails")]
    public virtual MminProgressStatistic FkMminProgressStatistic { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MminProgressStatisticDetails")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostFactorId")]
    [InverseProperty("MminProgressStatisticDetails")]
    public virtual MmproductionCostFactor FkMmproductionCostFactor { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MminProgressStatisticDetails")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
