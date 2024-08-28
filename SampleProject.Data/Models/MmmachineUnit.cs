using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMachineUnits")]
public partial class MmmachineUnit
{
    [Key]
    [Column("MMMachineUnitID")]
    public int MmmachineUnitId { get; set; }

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

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("MMMachineUnitParentID")]
    public int? MmmachineUnitParentId { get; set; }

    [Column("MMMachineUnitNo")]
    [StringLength(50)]
    public string MmmachineUnitNo { get; set; }

    [Column("MMMachineUnitName")]
    [StringLength(50)]
    public string MmmachineUnitName { get; set; }

    [Column("MMMachineUnitDesc")]
    [StringLength(512)]
    public string MmmachineUnitDesc { get; set; }

    [Column("MMMachineUnitStatus")]
    [StringLength(50)]
    public string MmmachineUnitStatus { get; set; }

    [Column("MMMachineUnitCapacity", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitCapacity { get; set; }

    [Column("MMCapacityUnit")]
    [StringLength(50)]
    public string MmcapacityUnit { get; set; }

    [Column("MMMachineUnitQty", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitQty { get; set; }

    [Column("MMMachineUnitSetupTime", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitSetupTime { get; set; }

    [Column("MMMachineUnitCapacityCoefficient", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitCapacityCoefficient { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmmachineUnits")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmmachineUnits")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmmachineUnit")]
    public virtual ICollection<MmmachineUnitCapacity> MmmachineUnitCapacities { get; set; } = new List<MmmachineUnitCapacity>();

    [InverseProperty("FkMmmachineUnit")]
    public virtual ICollection<MmmachineUnitItem> MmmachineUnitItems { get; set; } = new List<MmmachineUnitItem>();

    [InverseProperty("FkMmmachineUnit")]
    public virtual ICollection<MmmachineUnitOperation> MmmachineUnitOperations { get; set; } = new List<MmmachineUnitOperation>();
}
