using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartmentRoomGroupTeams")]
public partial class HrdepartmentRoomGroupTeam
{
    [Key]
    [Column("HRDepartmentRoomGroupTeamID")]
    public int HrdepartmentRoomGroupTeamId { get; set; }

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

    [Column("FK_HRDepartmentRoomID")]
    public int FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int FkHrdepartmentId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Required]
    [Column("HRDepartmentRoomGroupTeamNo")]
    [StringLength(50)]
    public string HrdepartmentRoomGroupTeamNo { get; set; }

    [Required]
    [Column("HRDepartmentRoomGroupTeamName")]
    [StringLength(50)]
    public string HrdepartmentRoomGroupTeamName { get; set; }

    [Column("HRDepartmentRoomGroupTeamDesc")]
    [StringLength(512)]
    public string HrdepartmentRoomGroupTeamDesc { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int FkHrdepartmentRoomGroupItemId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HrdepartmentRoomGroupTeams")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrdepartmentRoomGroupTeams")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HrdepartmentRoomGroupTeams")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("HrdepartmentRoomGroupTeams")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HrdepartmentRoomGroupTeams")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [InverseProperty("FkHrdepartmentRoomGroupTeam")]
    public virtual ICollection<HrdepartmentRoomGroupTeamItem> HrdepartmentRoomGroupTeamItems { get; set; } = new List<HrdepartmentRoomGroupTeamItem>();
}
