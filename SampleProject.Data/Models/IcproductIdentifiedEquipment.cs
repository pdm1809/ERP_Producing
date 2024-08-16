using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductIdentifiedEquipments")]
public partial class IcproductIdentifiedEquipment
{
    [Key]
    [Column("ICProductIdentifiedEquipmentID")]
    public int IcproductIdentifiedEquipmentId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ICProductIdentifiedEquipmentNo")]
    [StringLength(50)]
    public string IcproductIdentifiedEquipmentNo { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("ICProductIdentifiedEquipmentOriginalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductIdentifiedEquipmentOriginalAmount { get; set; }

    [Column("ICProductIdentifiedEquipmentInitDepriciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductIdentifiedEquipmentInitDepriciatedAmount { get; set; }

    [Column("ICProductIdentifiedEquipmentDepriciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductIdentifiedEquipmentDepriciatedAmount { get; set; }

    [Column("ICProductIdentifiedEquipmentInitDepriciationMonths")]
    public int? IcproductIdentifiedEquipmentInitDepriciationMonths { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeUserID")]
    public int? FkHremployeeUserId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("ICProductIdentifiedEquipmentInitDepriciationDate", TypeName = "datetime")]
    public DateTime? IcproductIdentifiedEquipmentInitDepriciationDate { get; set; }

    [Column("ICProductIdentifiedEquipmenteTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductIdentifiedEquipmenteTotalAmount { get; set; }

    [Column("ICProductIdentifiedEquipmentStatus")]
    [StringLength(50)]
    public string IcproductIdentifiedEquipmentStatus { get; set; }

    [Column("ICProductIdentifiedEquipmentDesc")]
    [StringLength(400)]
    public string IcproductIdentifiedEquipmentDesc { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ICProductIdentifiedEquipmentIsOpening")]
    public bool? IcproductIdentifiedEquipmentIsOpening { get; set; }

    [InverseProperty("FkIcproductIdentifiedEquipment")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkIcproductIdentifiedEquipment")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkIcproductIdentifiedEquipment")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkIcproductIdentifiedEquipment")]
    public virtual ICollection<AcstopAllocationEquipment> AcstopAllocationEquipments { get; set; } = new List<AcstopAllocationEquipment>();

    [InverseProperty("FkIcproductIdentifiedEquipment")]
    public virtual ICollection<ArallocationItem> ArallocationItems { get; set; } = new List<ArallocationItem>();

    [InverseProperty("FkIcproductIdentifiedEquipment")]
    public virtual ICollection<ArreceptionItem> ArreceptionItems { get; set; } = new List<ArreceptionItem>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("IcproductIdentifiedEquipments")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkIcproductIdentifiedEquipment")]
    public virtual ICollection<IcmachineGroup> IcmachineGroups { get; set; } = new List<IcmachineGroup>();

    [InverseProperty("FkIcproductIdentifiedEquipment")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
