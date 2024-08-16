using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartmentRoomGroupTeamItems")]
public partial class HrdepartmentRoomGroupTeamItem
{
    [Key]
    [Column("HRDepartmentRoomGroupTeamItemID")]
    public int HrdepartmentRoomGroupTeamItemId { get; set; }

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

    [Column("FK_HRDepartmentRoomGroupTeamID")]
    public int FkHrdepartmentRoomGroupTeamId { get; set; }

    [Required]
    [Column("HRDepartmentRoomGroupTeamItemNo")]
    [StringLength(50)]
    public string HrdepartmentRoomGroupTeamItemNo { get; set; }

    [Required]
    [Column("HRDepartmentRoomGroupTeamItemName")]
    [StringLength(50)]
    public string HrdepartmentRoomGroupTeamItemName { get; set; }

    [Column("HRDepartmentRoomGroupTeamItemDesc")]
    [StringLength(512)]
    public string HrdepartmentRoomGroupTeamItemDesc { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupTeamId")]
    [InverseProperty("HrdepartmentRoomGroupTeamItems")]
    public virtual HrdepartmentRoomGroupTeam FkHrdepartmentRoomGroupTeam { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("HrdepartmentRoomGroupTeamItems")]
    public virtual Mmline FkMmline { get; set; }

    [InverseProperty("FkHrdepartmentRoomGroupTeamItem")]
    public virtual ICollection<HremployeeContract> HremployeeContracts { get; set; } = new List<HremployeeContract>();

    [InverseProperty("FkHrdepartmentRoomGroupTeamItem")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranfers { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("FkHrdepartmentRoomGroupTeamItem")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();
}
