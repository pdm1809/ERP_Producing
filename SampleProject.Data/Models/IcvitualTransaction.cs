using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICVitualTransactions")]
public partial class IcvitualTransaction
{
    [Key]
    [Column("ICVitualTransactionID")]
    public int IcvitualTransactionId { get; set; }

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

    [Column("ICVitualTransactionReferenceID")]
    public int? IcvitualTransactionReferenceId { get; set; }

    [Column("ICVitualTransactionReferenceNo")]
    [StringLength(50)]
    public string IcvitualTransactionReferenceNo { get; set; }

    [Column("ICVitualTransactionModuleName")]
    [StringLength(50)]
    public string IcvitualTransactionModuleName { get; set; }

    [Column("ICVitualTransactionModuleType")]
    [StringLength(50)]
    public string IcvitualTransactionModuleType { get; set; }

    [Column("ICVitualTransactionDate", TypeName = "datetime")]
    public DateTime IcvitualTransactionDate { get; set; }

    [Column("ICVitualTransactionRefItemID")]
    public int? IcvitualTransactionRefItemId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("ACObjectRepName")]
    [StringLength(512)]
    public string AcobjectRepName { get; set; }

    [Column("ICVitualTransactionDesc")]
    [StringLength(1024)]
    public string IcvitualTransactionDesc { get; set; }

    [Column("ICVitualTransactionDetailDesc")]
    [StringLength(1024)]
    public string IcvitualTransactionDetailDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ICVitualTransactionExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionExchangeRate { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ICVitualTransactionType")]
    [StringLength(256)]
    public string IcvitualTransactionType { get; set; }

    [Column("FK_ICImportAndExportReasonID")]
    public int? FkIcimportAndExportReasonId { get; set; }

    [Column("ICVitualTransactionIsSpecificCalculation")]
    public bool? IcvitualTransactionIsSpecificCalculation { get; set; }

    [Column("ICVitualTransactionIsAverageCalculation")]
    public bool? IcvitualTransactionIsAverageCalculation { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICVitualTransactionReceiptLotNo")]
    [StringLength(50)]
    public string IcvitualTransactionReceiptLotNo { get; set; }

    [Column("ICVitualTransactionReceiptSerialNo")]
    [StringLength(50)]
    public string IcvitualTransactionReceiptSerialNo { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICVitualTransactionQty", TypeName = "decimal(18, 6)")]
    public decimal? IcvitualTransactionQty { get; set; }

    [Column("ICVitualTransactionFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionFactor { get; set; }

    [Column("ICVitualTransactionExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? IcvitualTransactionExchangeQty { get; set; }

    [Column("ICVitualTransactionQty1", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionQty1 { get; set; }

    [Column("ICVitualTransactionQty2", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionQty2 { get; set; }

    [Column("ICVitualTransactionQty3", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionQty3 { get; set; }

    [Column("ICVitualTransactionFeePaymentType")]
    [StringLength(256)]
    public string IcvitualTransactionFeePaymentType { get; set; }

    [Column("ICVitualTransactionUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionUnitCost { get; set; }

    [Column("ICVitualTransactionTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionTotalCost { get; set; }

    [Column("ICVitualTransactionExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionExchangeUnitCost { get; set; }

    [Column("ICVitualTransactionExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionExchangeTotalCost { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACOffsetAccountID")]
    public int? FkAcoffsetAccountId { get; set; }

    [Column("FK_ACTransitInAccountID")]
    public int? FkActransitInAccountId { get; set; }

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

    [Column("ICVitualTransactionCode01Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode01Combo { get; set; }

    [Column("ICVitualTransactionCode02Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode02Combo { get; set; }

    [Column("ICVitualTransactionCode03Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode03Combo { get; set; }

    [Column("ICVitualTransactionCode04Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode04Combo { get; set; }

    [Column("ICVitualTransactionCode05Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode05Combo { get; set; }

    [Column("ICVitualTransactionCode06Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode06Combo { get; set; }

    [Column("ICVitualTransactionCode07Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode07Combo { get; set; }

    [Column("ICVitualTransactionCode08Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode08Combo { get; set; }

    [Column("ICVitualTransactionCode09Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode09Combo { get; set; }

    [Column("ICVitualTransactionCode10Combo")]
    [StringLength(256)]
    public string IcvitualTransactionCode10Combo { get; set; }

    [Column("FK_ICPerimeterGroupID")]
    public int? FkIcperimeterGroupId { get; set; }

    [Column("FK_ICLengthGroupID")]
    public int? FkIclengthGroupId { get; set; }

    [Column("ICVitualTransactionLength", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionLength { get; set; }

    [Column("ICVitualTransactionWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionWidth { get; set; }

    [Column("ICVitualTransactionHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcvitualTransactionHeight { get; set; }

    [Column("ICVitualTransactionPurposeType")]
    [StringLength(64)]
    public string IcvitualTransactionPurposeType { get; set; }

    [Column("FK_ICStockExtID")]
    public int? FkIcstockExtId { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcvitualTransactionFkIcstocks")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkIcstockExtId")]
    [InverseProperty("IcvitualTransactionFkIcstockExts")]
    public virtual Icstock FkIcstockExt { get; set; }
}
