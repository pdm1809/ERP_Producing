using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRMachineTimeKeepers")]
public partial class HrmachineTimeKeeper
{
    [Key]
    [Column("HRMachineTimeKeeperID")]
    public int HrmachineTimeKeeperId { get; set; }

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

    [Required]
    [Column("HRMachineTimeKeeperNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrmachineTimeKeeperNo { get; set; }

    [Column("HRMachineTimeKeeperName")]
    [StringLength(100)]
    public string HrmachineTimeKeeperName { get; set; }

    [Column("HRMachineTimeKeeperPortType")]
    [StringLength(50)]
    public string HrmachineTimeKeeperPortType { get; set; }

    [Column("HRMachineTimeKeeperPortID")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrmachineTimeKeeperPortId { get; set; }

    [Column("HRMachineTimeKeeperIP")]
    [StringLength(50)]
    public string HrmachineTimeKeeperIp { get; set; }

    [Column("HRMachineTimeKeeperPassword")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrmachineTimeKeeperPassword { get; set; }

    [Column("HRMachineTimeKeeperCom")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrmachineTimeKeeperCom { get; set; }

    [Column("HRMachineTimeKeeperIsConnected")]
    public bool? HrmachineTimeKeeperIsConnected { get; set; }

    [Column("HRMachineTimeKeeperType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrmachineTimeKeeperType { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("HrmachineTimeKeepers")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkHrmachineTimeKeeper")]
    public virtual ICollection<HrtimeKeeperComplete> HrtimeKeeperCompletes { get; set; } = new List<HrtimeKeeperComplete>();

    [InverseProperty("FkHrmachineTimeKeeper")]
    public virtual ICollection<HrtimeKeeper> HrtimeKeepers { get; set; } = new List<HrtimeKeeper>();
}
