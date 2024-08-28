using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEUnitCostContainers")]
public partial class GeunitCostContainer
{
    [Key]
    [Column("GEUnitCostContainerID")]
    public int GeunitCostContainerId { get; set; }

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

    [Column("FK_GEUnitCostID")]
    public int? FkGeunitCostId { get; set; }

    [Column("FK_GEContainerID")]
    public int? FkGecontainerId { get; set; }

    [Column("fk_GETerminalID")]
    public int? FkGeterminalId { get; set; }

    [Column("GEUnitCostContainerUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? GeunitCostContainerUnitCost { get; set; }

    [Column("GEUnitCostContainerDesc")]
    [StringLength(50)]
    public string GeunitCostContainerDesc { get; set; }

    [ForeignKey("FkGecontainerId")]
    [InverseProperty("GeunitCostContainers")]
    public virtual Gecontainer FkGecontainer { get; set; }
}
