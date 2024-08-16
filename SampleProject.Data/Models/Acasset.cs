using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAssets")]
[Microsoft.EntityFrameworkCore.Index("AcassetNo", "FkBrbranchId", "AcassetType", Name = "Idx_ACAssets")]
public partial class Acasset
{
    [Key]
    [Column("ACAssetID")]
    public int AcassetId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRInitRoomID")]
    public int? FkHrinitRoomId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Required]
    [Column("ACAssetNo")]
    [StringLength(50)]
    public string AcassetNo { get; set; }

    [Required]
    [Column("ACAssetName")]
    [StringLength(100)]
    public string AcassetName { get; set; }

    [Column("ACAssetDesc")]
    [StringLength(512)]
    public string AcassetDesc { get; set; }

    [Column("ACAssetComment")]
    [StringLength(512)]
    public string AcassetComment { get; set; }

    [Required]
    [Column("ACAssetType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcassetType { get; set; }

    [Column("ACAssetStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcassetStatus { get; set; }

    [Column("ACAssetPurchasedDate", TypeName = "datetime")]
    public DateTime? AcassetPurchasedDate { get; set; }

    [Column("ACAssetUsedDate", TypeName = "datetime")]
    public DateTime? AcassetUsedDate { get; set; }

    [Column("ACAssetExpiryMonths")]
    public int? AcassetExpiryMonths { get; set; }

    [Column("ACAssetDepreciationMethod")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcassetDepreciationMethod { get; set; }

    [Column("ACAssetDepreciationPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcassetDepreciationPercent { get; set; }

    [Column("ACAssetDepreciationAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetDepreciationAmount { get; set; }

    [Column("ACAssetModelNo")]
    [StringLength(50)]
    public string AcassetModelNo { get; set; }

    [Column("ACAssetGuaranteeMonths")]
    public int? AcassetGuaranteeMonths { get; set; }

    [Column("ACAssetGuaranteeTerm")]
    [StringLength(256)]
    public string AcassetGuaranteeTerm { get; set; }

    [Column("ACAssetInitQty", TypeName = "decimal(18, 5)")]
    public decimal? AcassetInitQty { get; set; }

    [Column("ACAssetInitDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetInitDepreciatedAmount { get; set; }

    [Column("ACAssetCost", TypeName = "decimal(18, 5)")]
    public decimal? AcassetCost { get; set; }

    [Column("ACAssetOriginalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetOriginalAmount { get; set; }

    [Column("ACAssetDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetDepreciatedAmount { get; set; }

    [Column("ACAssetRemainedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetRemainedAmount { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ACAssetTransferredDate", TypeName = "datetime")]
    public DateTime? AcassetTransferredDate { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACDepreciationAccountID")]
    public int? FkAcdepreciationAccountId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_HRDepartmentRoomGroupID")]
    public int? FkHrdepartmentRoomGroupId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_HREmployeeUserID")]
    public int? FkHremployeeUserId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("ACAssetDepreciationDate", TypeName = "datetime")]
    public DateTime? AcassetDepreciationDate { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ACAssetNoOfOldSys")]
    [StringLength(100)]
    public string AcassetNoOfOldSys { get; set; }

    [Column("FK_ACAssetTypeAccountConfigID")]
    public int? FkAcassetTypeAccountConfigId { get; set; }

    [Column("ACAssetIsInventory")]
    public bool? AcassetIsInventory { get; set; }

    [InverseProperty("FkAcasset")]
    public virtual ICollection<AcadjustIncreaseOrDecreaseAssetItem> AcadjustIncreaseOrDecreaseAssetItems { get; set; } = new List<AcadjustIncreaseOrDecreaseAssetItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<AcstopDepreciationAsset> AcstopDepreciationAssets { get; set; } = new List<AcstopDepreciationAsset>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<ApcancelPurchaseProposalItem> ApcancelPurchaseProposalItems { get; set; } = new List<ApcancelPurchaseProposalItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<ApproposalItemTotal> ApproposalItemTotals { get; set; } = new List<ApproposalItemTotal>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<ArallocationItem> ArallocationItems { get; set; } = new List<ArallocationItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<ArreceptionItem> ArreceptionItems { get; set; } = new List<ArreceptionItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcassetFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcassetTypeAccountConfigId")]
    [InverseProperty("Acassets")]
    public virtual AcassetTypeAccountConfig FkAcassetTypeAccountConfig { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("Acassets")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdepreciationAccountId")]
    [InverseProperty("AcassetFkAcdepreciationAccounts")]
    public virtual Acaccount FkAcdepreciationAccount { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("AcassetFkAcdepreciationCostAccounts")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("Acassets")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("Acassets")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("Acassets")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Acassets")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Acassets")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcassetFkHrdepartmentRooms")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("Acassets")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("Acassets")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("Acassets")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkHrinitRoomId")]
    [InverseProperty("AcassetFkHrinitRooms")]
    public virtual HrdepartmentRoom FkHrinitRoom { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("Acassets")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("Acassets")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("Acassets")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("Acassets")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("Acassets")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("Acassets")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("Acassets")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkAcasset")]
    public virtual ICollection<IcmachineGroup> IcmachineGroups { get; set; } = new List<IcmachineGroup>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkAcasset")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();
}
