using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartmentRoomGroupItems")]
public partial class HrdepartmentRoomGroupItem
{
    [Key]
    [Column("HRDepartmentRoomGroupItemID")]
    public int HrdepartmentRoomGroupItemId { get; set; }

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

    [Column("FK_HRDepartmentRoomGroupID")]
    public int FkHrdepartmentRoomGroupId { get; set; }

    [Required]
    [Column("HRDepartmentRoomGroupItemNo")]
    [StringLength(50)]
    public string HrdepartmentRoomGroupItemNo { get; set; }

    [Required]
    [Column("HRDepartmentRoomGroupItemName")]
    [StringLength(50)]
    public string HrdepartmentRoomGroupItemName { get; set; }

    [Column("HRDepartmentRoomGroupItemDesc")]
    [StringLength(512)]
    public string HrdepartmentRoomGroupItemDesc { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("HRDepartmentRoomGroupItemParentID")]
    public int? HrdepartmentRoomGroupItemParentId { get; set; }

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("HrdepartmentRoomGroupItems")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HrdepartmentGroupCapacity> HrdepartmentGroupCapacities { get; set; } = new List<HrdepartmentGroupCapacity>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HrdepartmentGroupOperation> HrdepartmentGroupOperations { get; set; } = new List<HrdepartmentGroupOperation>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HrdepartmentRoomGroupTeam> HrdepartmentRoomGroupTeams { get; set; } = new List<HrdepartmentRoomGroupTeam>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HremployeeContract> HremployeeContracts { get; set; } = new List<HremployeeContract>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HremployeeOt> HremployeeOts { get; set; } = new List<HremployeeOt>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HremployeePieceWageItem> HremployeePieceWageItems { get; set; } = new List<HremployeePieceWageItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HremployeeSalaryConfig> HremployeeSalaryConfigs { get; set; } = new List<HremployeeSalaryConfig>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranfers { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HremployeeTransmitItem> HremployeeTransmitItems { get; set; } = new List<HremployeeTransmitItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HremployeeTransmit> HremployeeTransmits { get; set; } = new List<HremployeeTransmit>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<HrlabouringConfigItem> HrlabouringConfigItems { get; set; } = new List<HrlabouringConfigItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<IcconversionProposal> IcconversionProposals { get; set; } = new List<IcconversionProposal>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<MmjobTicket> MmjobTickets { get; set; } = new List<MmjobTicket>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItems { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkHrdepartmentRoomGroupItem")]
    public virtual ICollection<MmoperationDetailPlan> MmoperationDetailPlans { get; set; } = new List<MmoperationDetailPlan>();
}
