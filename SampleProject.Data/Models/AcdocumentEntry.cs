using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDocumentEntrys")]
[Microsoft.EntityFrameworkCore.Index("FkAcobjectId", "AcobjectType", "FkAcdocumentId", "FkAcdebitAccountId", "FkAccreditAccountId", Name = "Idx_ACDocumentEntrys")]
public partial class AcdocumentEntry
{
    [Key]
    [Column("ACDocumentEntryID")]
    public int AcdocumentEntryId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int? FkAcentryTypeId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("FK_BRCostedBranchID")]
    public int? FkBrcostedBranchId { get; set; }

    [Column("ACDocumentEntryDesc")]
    [StringLength(512)]
    public string AcdocumentEntryDesc { get; set; }

    [Column("ACDocumentEntryAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentEntryAmount { get; set; }

    [Column("ACDocumentEntryExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentEntryExchangeAmount { get; set; }

    [Column("ACDocumentEntryAllocatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcdocumentEntryAllocatedAmount { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("ACAssObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcassObjectType { get; set; }

    [Column("ACAssetID")]
    public int? AcassetId { get; set; }

    [Column("ACAssetDepreciatedQty", TypeName = "decimal(18, 5)")]
    public decimal? AcassetDepreciatedQty { get; set; }

    [Column("ICEquipmentShipmentItemID")]
    public int? IcequipmentShipmentItemId { get; set; }

    [Column("ACEquipmentTransferItemID")]
    public int? AcequipmentTransferItemId { get; set; }

    [Column("ICEquipmentDepreciatedQty", TypeName = "decimal(18, 5)")]
    public decimal? IcequipmentDepreciatedQty { get; set; }

    [Column("ACAllocatedDocumentEntryID")]
    public int? AcallocatedDocumentEntryId { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ICProductIdentifiedEquipmentID")]
    public int? FkIcproductIdentifiedEquipmentId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AcdocumentEntryFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AcdocumentEntryFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual AcentryType FkAcentryType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkBrcostedBranchId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual Brbranch FkBrcostedBranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkIcproductIdentifiedEquipmentId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual IcproductIdentifiedEquipment FkIcproductIdentifiedEquipment { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("AcdocumentEntries")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
