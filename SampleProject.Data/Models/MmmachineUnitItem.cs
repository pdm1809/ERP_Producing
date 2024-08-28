using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMachineUnitItems")]
public partial class MmmachineUnitItem
{
    [Key]
    [Column("MMMachineUnitItemID")]
    public int MmmachineUnitItemId { get; set; }

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

    [Column("FK_MMMachineUnitID")]
    public int? FkMmmachineUnitId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("MMMachineUnitItemName")]
    [StringLength(512)]
    public string MmmachineUnitItemName { get; set; }

    [Column("MMMachineUnitEmployeeQty", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitEmployeeQty { get; set; }

    [Column("MMMachineUnitItemDesc")]
    [StringLength(512)]
    public string MmmachineUnitItemDesc { get; set; }

    [Column("MMMachineUnitItemSetupTime", TypeName = "decimal(18, 5)")]
    public decimal? MmmachineUnitItemSetupTime { get; set; }

    [ForeignKey("FkMmmachineUnitId")]
    [InverseProperty("MmmachineUnitItems")]
    public virtual MmmachineUnit FkMmmachineUnit { get; set; }
}
