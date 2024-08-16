using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInvBalances")]
public partial class IcinvBalance
{
    [Key]
    [Column("ICInvBalanceID")]
    public int IcinvBalanceId { get; set; }

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

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_ICProductEquipmentID")]
    public int? FkIcproductEquipmentId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_ACLoanReceiptID")]
    public int? FkAcloanReceiptId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICInvBalanceDate", TypeName = "datetime")]
    public DateTime IcinvBalanceDate { get; set; }

    [Column("ICInvBalanceReceiptLotNo")]
    [StringLength(50)]
    public string IcinvBalanceReceiptLotNo { get; set; }

    [Column("ICInvBalanceReceiptSerialNo")]
    [StringLength(50)]
    public string IcinvBalanceReceiptSerialNo { get; set; }

    [Column("ICInvBalanceExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? IcinvBalanceExchangeRate { get; set; }

    [Column("ICInvBalanceQty", TypeName = "decimal(18, 6)")]
    public decimal? IcinvBalanceQty { get; set; }

    [Column("ICInvBalanceFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcinvBalanceFactor { get; set; }

    [Column("ICInvBalanceExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? IcinvBalanceExchangeQty { get; set; }

    [Column("ICInvBalanceQty1", TypeName = "decimal(18, 6)")]
    public decimal? IcinvBalanceQty1 { get; set; }

    [Column("ICInvBalanceQty2", TypeName = "decimal(18, 6)")]
    public decimal? IcinvBalanceQty2 { get; set; }

    [Column("ICInvBalanceQty3", TypeName = "decimal(18, 6)")]
    public decimal? IcinvBalanceQty3 { get; set; }

    [Column("ICInvBalanceUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcinvBalanceUnitCost { get; set; }

    [Column("ICInvBalanceTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcinvBalanceTotalCost { get; set; }

    [Column("ICInvBalanceExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcinvBalanceExchangeUnitCost { get; set; }

    [Column("ICInvBalanceExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcinvBalanceExchangeTotalCost { get; set; }

    [Column("ICInvBalanceCode01Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode01Combo { get; set; }

    [Column("ICInvBalanceCode02Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode02Combo { get; set; }

    [Column("ICInvBalanceCode03Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode03Combo { get; set; }

    [Column("ICInvBalanceCode04Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode04Combo { get; set; }

    [Column("ICInvBalanceCode05Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode05Combo { get; set; }

    [Column("ICInvBalanceCode06Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode06Combo { get; set; }

    [Column("ICInvBalanceCode07Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode07Combo { get; set; }

    [Column("ICInvBalanceCode08Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode08Combo { get; set; }

    [Column("ICInvBalanceCode09Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode09Combo { get; set; }

    [Column("ICInvBalanceCode10Combo")]
    [StringLength(256)]
    public string IcinvBalanceCode10Combo { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinvBalances")]
    public virtual Icstock FkIcstock { get; set; }
}
