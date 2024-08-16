using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACBalances")]
public partial class Acbalance
{
    [Key]
    [Column("ACBalanceID")]
    public int AcbalanceId { get; set; }

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

    [Column("ACBalanceDate", TypeName = "datetime")]
    public DateTime? AcbalanceDate { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_CSCompanyBankID")]
    public int? FkCscompanyBankId { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ACBalanceExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceExchangeRate { get; set; }

    [Column("ACBalanceDebitAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceDebitAmount { get; set; }

    [Column("ACBalanceDebitExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceDebitExchangeAmount { get; set; }

    [Column("ACBalanceCreditAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceCreditAmount { get; set; }

    [Column("ACBalanceCreditExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcbalanceCreditExchangeAmount { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ACBalanceReceiptLotNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcbalanceReceiptLotNo { get; set; }

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

    [Column("ACBalanceCode01Combo")]
    [StringLength(256)]
    public string AcbalanceCode01Combo { get; set; }

    [Column("ACBalanceCode02Combo")]
    [StringLength(256)]
    public string AcbalanceCode02Combo { get; set; }

    [Column("ACBalanceCode03Combo")]
    [StringLength(256)]
    public string AcbalanceCode03Combo { get; set; }

    [Column("ACBalanceCode04Combo")]
    [StringLength(256)]
    public string AcbalanceCode04Combo { get; set; }

    [Column("ACBalanceCode05Combo")]
    [StringLength(256)]
    public string AcbalanceCode05Combo { get; set; }

    [Column("ACBalanceCode06Combo")]
    [StringLength(256)]
    public string AcbalanceCode06Combo { get; set; }

    [Column("ACBalanceCode07Combo")]
    [StringLength(256)]
    public string AcbalanceCode07Combo { get; set; }

    [Column("ACBalanceCode08Combo")]
    [StringLength(256)]
    public string AcbalanceCode08Combo { get; set; }

    [Column("ACBalanceCode09Combo")]
    [StringLength(256)]
    public string AcbalanceCode09Combo { get; set; }

    [Column("ACBalanceCode10Combo")]
    [StringLength(256)]
    public string AcbalanceCode10Combo { get; set; }
}
