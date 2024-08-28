using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeKeepers")]
public partial class HrtimeKeeper
{
    [Key]
    [Column("HRTimeKeeperID")]
    public int HrtimeKeeperId { get; set; }

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

    [Column("HRTimeKeeperNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrtimeKeeperNo { get; set; }

    [Column("HRTimeKeeperEmployeeNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrtimeKeeperEmployeeNo { get; set; }

    [Column("HRTimeKeeperEmployeeCardNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrtimeKeeperEmployeeCardNo { get; set; }

    [Column("HRTimeKeeperDate", TypeName = "datetime")]
    public DateTime? HrtimeKeeperDate { get; set; }

    [Column("HRTimeKeeperSymbol")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrtimeKeeperSymbol { get; set; }

    [Column("HRTimeKeeperTimeIn", TypeName = "datetime")]
    public DateTime? HrtimeKeeperTimeIn { get; set; }

    [Column("HRTimeKeeperTimeOut", TypeName = "datetime")]
    public DateTime? HrtimeKeeperTimeOut { get; set; }

    [Column("FK_HRMachineTimeKeeperID")]
    public int FkHrmachineTimeKeeperId { get; set; }

    [Column("HRTimeKeeperTimeInOutMode")]
    public int? HrtimeKeeperTimeInOutMode { get; set; }

    [Column("HRMachineTimeKeeperType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrmachineTimeKeeperType { get; set; }

    [Column("HRTimeKeeperDateCheck", TypeName = "datetime")]
    public DateTime? HrtimeKeeperDateCheck { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkHrmachineTimeKeeperId")]
    [InverseProperty("HrtimeKeepers")]
    public virtual HrmachineTimeKeeper FkHrmachineTimeKeeper { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("HrtimeKeepers")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkHrtimeKeeper")]
    public virtual ICollection<HrtimeKeeperComplete> HrtimeKeeperCompletes { get; set; } = new List<HrtimeKeeperComplete>();
}
