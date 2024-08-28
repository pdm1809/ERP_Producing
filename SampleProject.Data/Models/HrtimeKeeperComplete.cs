using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeKeeperCompletes")]
public partial class HrtimeKeeperComplete
{
    [Key]
    [Column("HRTimeKeeperCompleteID")]
    public int HrtimeKeeperCompleteId { get; set; }

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

    [Column("HRTimeKeeperCompletesEmployeeCardNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrtimeKeeperCompletesEmployeeCardNo { get; set; }

    [Column("HRTimeKeeperCompleteDate", TypeName = "datetime")]
    public DateTime? HrtimeKeeperCompleteDate { get; set; }

    [Column("HRTimeKeeperCompleteTimeCheck", TypeName = "datetime")]
    public DateTime? HrtimeKeeperCompleteTimeCheck { get; set; }

    [Column("FK_HRMachineTimeKeeperID")]
    public int FkHrmachineTimeKeeperId { get; set; }

    [Column("HRTimeKeeperCompleteInOutMode")]
    public int? HrtimeKeeperCompleteInOutMode { get; set; }

    [Column("HRTimeKeeperCompleteComment")]
    [StringLength(500)]
    public string HrtimeKeeperCompleteComment { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("HRTimeKeeperCompleteDateCheck", TypeName = "datetime")]
    public DateTime? HrtimeKeeperCompleteDateCheck { get; set; }

    [Column("FK_HRTimeKeeperID")]
    public int? FkHrtimeKeeperId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrtimeKeeperCompletes")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrtimeKeeperCompletes")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkHrmachineTimeKeeperId")]
    [InverseProperty("HrtimeKeeperCompletes")]
    public virtual HrmachineTimeKeeper FkHrmachineTimeKeeper { get; set; }

    [ForeignKey("FkHrtimeKeeperId")]
    [InverseProperty("HrtimeKeeperCompletes")]
    public virtual HrtimeKeeper FkHrtimeKeeper { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("HrtimeKeeperCompletes")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkHrtimeKeeperComplete")]
    public virtual ICollection<HrtimeKeeperHistory> HrtimeKeeperHistories { get; set; } = new List<HrtimeKeeperHistory>();
}
