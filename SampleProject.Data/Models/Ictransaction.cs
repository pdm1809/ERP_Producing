using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTransactions")]
public partial class Ictransaction
{
    [Key]
    [Column("ICTransactionID")]
    public int IctransactionId { get; set; }

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

    [Column("ICTransactionReferenceID")]
    public int? IctransactionReferenceId { get; set; }

    [Column("ICTransactionReferenceNo")]
    [StringLength(50)]
    public string IctransactionReferenceNo { get; set; }

    [Column("ICTransactionModuleName")]
    [StringLength(50)]
    public string IctransactionModuleName { get; set; }

    [Column("ICTransactionModuleType")]
    [StringLength(50)]
    public string IctransactionModuleType { get; set; }

    [Column("ICTransactionDate", TypeName = "datetime")]
    public DateTime IctransactionDate { get; set; }

    [Column("ICTransactionRefItemID")]
    public int? IctransactionRefItemId { get; set; }

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

    [Column("ICTransactionDesc")]
    [StringLength(1024)]
    public string IctransactionDesc { get; set; }

    [Column("ICTransactionDetailDesc")]
    [StringLength(1024)]
    public string IctransactionDetailDesc { get; set; }

    [Column("FK_GECurrencyID")]
    public int FkGecurrencyId { get; set; }

    [Column("ICTransactionExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionExchangeRate { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ICTransactionType")]
    [StringLength(256)]
    public string IctransactionType { get; set; }

    [Column("FK_ICImportAndExportReasonID")]
    public int? FkIcimportAndExportReasonId { get; set; }

    [Column("ICTransactionIsSpecificCalculation")]
    public bool? IctransactionIsSpecificCalculation { get; set; }

    [Column("ICTransactionIsAverageCalculation")]
    public bool? IctransactionIsAverageCalculation { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICTransactionReceiptLotNo")]
    [StringLength(50)]
    public string IctransactionReceiptLotNo { get; set; }

    [Column("ICTransactionReceiptSerialNo")]
    [StringLength(50)]
    public string IctransactionReceiptSerialNo { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICTransactionQty", TypeName = "decimal(18, 6)")]
    public decimal? IctransactionQty { get; set; }

    [Column("ICTransactionFactor", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionFactor { get; set; }

    [Column("ICTransactionExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? IctransactionExchangeQty { get; set; }

    [Column("ICTransactionQty1", TypeName = "decimal(18, 6)")]
    public decimal? IctransactionQty1 { get; set; }

    [Column("ICTransactionQty2", TypeName = "decimal(18, 6)")]
    public decimal? IctransactionQty2 { get; set; }

    [Column("ICTransactionQty3", TypeName = "decimal(18, 6)")]
    public decimal? IctransactionQty3 { get; set; }

    [Column("ICTransactionFeePaymentType")]
    [StringLength(256)]
    public string IctransactionFeePaymentType { get; set; }

    [Column("ICTransactionUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionUnitCost { get; set; }

    [Column("ICTransactionTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionTotalCost { get; set; }

    [Column("ICTransactionExchangeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionExchangeUnitCost { get; set; }

    [Column("ICTransactionExchangeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionExchangeTotalCost { get; set; }

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

    [Column("ICTransactionCode01Combo")]
    [StringLength(50)]
    public string IctransactionCode01Combo { get; set; }

    [Column("ICTransactionCode02Combo")]
    [StringLength(50)]
    public string IctransactionCode02Combo { get; set; }

    [Column("ICTransactionCode03Combo")]
    [StringLength(256)]
    public string IctransactionCode03Combo { get; set; }

    [Column("ICTransactionCode04Combo")]
    [StringLength(256)]
    public string IctransactionCode04Combo { get; set; }

    [Column("ICTransactionCode05Combo")]
    [StringLength(256)]
    public string IctransactionCode05Combo { get; set; }

    [Column("ICTransactionCode06Combo")]
    [StringLength(256)]
    public string IctransactionCode06Combo { get; set; }

    [Column("ICTransactionCode07Combo")]
    [StringLength(256)]
    public string IctransactionCode07Combo { get; set; }

    [Column("ICTransactionCode08Combo")]
    [StringLength(256)]
    public string IctransactionCode08Combo { get; set; }

    [Column("ICTransactionCode09Combo")]
    [StringLength(256)]
    public string IctransactionCode09Combo { get; set; }

    [Column("ICTransactionCode10Combo")]
    [StringLength(256)]
    public string IctransactionCode10Combo { get; set; }

    [Column("FK_ICPerimeterGroupID")]
    public int? FkIcperimeterGroupId { get; set; }

    [Column("FK_ICLengthGroupID")]
    public int? FkIclengthGroupId { get; set; }

    [Column("ICTransactionLength", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionLength { get; set; }

    [Column("ICTransactionWidth", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionWidth { get; set; }

    [Column("ICTransactionHeight", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionHeight { get; set; }

    [Column("ICTransactionPurposeType")]
    [StringLength(64)]
    public string IctransactionPurposeType { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("ICTransactionExpiryDate", TypeName = "datetime")]
    public DateTime? IctransactionExpiryDate { get; set; }

    [Column("ICTransactionLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionLengthMin { get; set; }

    [Column("ICTransactionWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionWidthMin { get; set; }

    [Column("ICTransactionHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionHeightMin { get; set; }

    [Column("ICTransactionLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionLengthMax { get; set; }

    [Column("ICTransactionWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionWidthMax { get; set; }

    [Column("ICTransactionHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionHeightMax { get; set; }

    [Column("ICTransactionPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IctransactionPerimeter { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("Ictransactions")]
    public virtual Icstock FkIcstock { get; set; }
}
