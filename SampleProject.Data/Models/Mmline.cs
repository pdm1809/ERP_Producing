using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMLines")]
public partial class Mmline
{
    [Key]
    [Column("MMLineID")]
    public int MmlineId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Required]
    [Column("MMLineNo")]
    [StringLength(50)]
    public string MmlineNo { get; set; }

    [Required]
    [Column("MMLineName")]
    [StringLength(100)]
    public string MmlineName { get; set; }

    [Column("MMLineDesc")]
    [StringLength(512)]
    public string MmlineDesc { get; set; }

    [Column("MMLineContactName")]
    [StringLength(50)]
    public string MmlineContactName { get; set; }

    [Column("MMLineContactBirthday", TypeName = "datetime")]
    public DateTime? MmlineContactBirthday { get; set; }

    [Column("MMLineContactFirstName")]
    [StringLength(50)]
    public string MmlineContactFirstName { get; set; }

    [Column("MMLineContactLastName")]
    [StringLength(50)]
    public string MmlineContactLastName { get; set; }

    [Column("MMLineContactTitle")]
    [StringLength(50)]
    public string MmlineContactTitle { get; set; }

    [Column("MMLineContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmlineContactPhone { get; set; }

    [Column("MMLineContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmlineContactCellPhone { get; set; }

    [Column("MMLineContactEmail")]
    [StringLength(100)]
    public string MmlineContactEmail { get; set; }

    [Column("MMLineContactFax")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmlineContactFax { get; set; }

    [Column("MMLineContactDepartment")]
    [StringLength(50)]
    public string MmlineContactDepartment { get; set; }

    [Column("MMLineContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string MmlineContactRoom { get; set; }

    [Column("MMLineActiveCheck")]
    public bool MmlineActiveCheck { get; set; }

    [Column("MMLineOrder")]
    public int? MmlineOrder { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcendingAllocationItem> AcendingAllocationItems { get; set; } = new List<AcendingAllocationItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("Mmlines")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmline")]
    public virtual ICollection<HrdepartmentRoomGroupTeamItem> HrdepartmentRoomGroupTeamItems { get; set; } = new List<HrdepartmentRoomGroupTeamItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<IcconversionProposal> IcconversionProposals { get; set; } = new List<IcconversionProposal>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmallocationPlanItem> MmallocationPlanItems { get; set; } = new List<MmallocationPlanItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmallocationProposal> MmallocationProposals { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmbatchProductItemGeneralPlan> MmbatchProductItemGeneralPlans { get; set; } = new List<MmbatchProductItemGeneralPlan>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmbpoperationDepartment> MmbpoperationDepartments { get; set; } = new List<MmbpoperationDepartment>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmdepartmentCapacityConfig> MmdepartmentCapacityConfigs { get; set; } = new List<MmdepartmentCapacityConfig>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmdepartmentCapacityDetail> MmdepartmentCapacityDetails { get; set; } = new List<MmdepartmentCapacityDetail>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmjobTicket> MmjobTickets { get; set; } = new List<MmjobTicket>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmlabourProductivityTargetConfig> MmlabourProductivityTargetConfigs { get; set; } = new List<MmlabourProductivityTargetConfig>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmlineOperation> MmlineOperations { get; set; } = new List<MmlineOperation>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmmachineUnit> MmmachineUnits { get; set; } = new List<MmmachineUnit>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmoperationDetailPlanCancel> MmoperationDetailPlanCancels { get; set; } = new List<MmoperationDetailPlanCancel>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmoperationDetailPlanCapacity> MmoperationDetailPlanCapacities { get; set; } = new List<MmoperationDetailPlanCapacity>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItems { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmoperationDetailPlanItem> MmoperationDetailPlanItems { get; set; } = new List<MmoperationDetailPlanItem>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmoperationDetailPlan> MmoperationDetailPlans { get; set; } = new List<MmoperationDetailPlan>();

    [InverseProperty("FkMmline")]
    public virtual ICollection<MmwoodPlan> MmwoodPlans { get; set; } = new List<MmwoodPlan>();
}
