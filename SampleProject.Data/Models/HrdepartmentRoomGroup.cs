using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartmentRoomGroups")]
public partial class HrdepartmentRoomGroup
{
    [Key]
    [Column("HRDepartmentRoomGroupID")]
    public int HrdepartmentRoomGroupId { get; set; }

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

    [Column("FK_HRDepartmentRoomID")]
    public int FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int FkHrdepartmentId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("HRDepartmentRoomGroupNo")]
    [StringLength(50)]
    public string HrdepartmentRoomGroupNo { get; set; }

    [Required]
    [Column("HRDepartmentRoomGroupName")]
    [StringLength(50)]
    public string HrdepartmentRoomGroupName { get; set; }

    [Column("HRDepartmentRoomGroupDesc")]
    [StringLength(512)]
    public string HrdepartmentRoomGroupDesc { get; set; }

    [Column("FK_BRBranchID2")]
    public int FkBrbranchId2 { get; set; }

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrdepartmentRoomGroupFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrbranchId2")]
    [InverseProperty("HrdepartmentRoomGroupFkBrbranchId2Navigations")]
    public virtual Brbranch FkBrbranchId2Navigation { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrdepartmentRoomGroups")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HrdepartmentRoomGroups")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<HrdepartmentRoomGroupItem> HrdepartmentRoomGroupItems { get; set; } = new List<HrdepartmentRoomGroupItem>();

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<HrdepartmentRoomGroupTeam> HrdepartmentRoomGroupTeams { get; set; } = new List<HrdepartmentRoomGroupTeam>();

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkHrdepartmentRoomGroup")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
