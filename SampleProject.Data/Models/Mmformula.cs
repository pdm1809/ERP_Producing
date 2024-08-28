using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMFormulas")]
public partial class Mmformula
{
    [Key]
    [Column("MMFormulaID")]
    public int MmformulaId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("MMFormulaNo")]
    [StringLength(50)]
    public string MmformulaNo { get; set; }

    [Column("MMFormulaName")]
    [StringLength(100)]
    public string MmformulaName { get; set; }

    [Column("MMFormulaDesc")]
    [StringLength(512)]
    public string MmformulaDesc { get; set; }

    [Column("MMFormulaType")]
    [StringLength(50)]
    public string MmformulaType { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Mmformulas")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkMmformula")]
    public virtual ICollection<MmbatchProductProductionNormItemMeterial> MmbatchProductProductionNormItemMeterials { get; set; } = new List<MmbatchProductProductionNormItemMeterial>();

    [InverseProperty("FkMmformula")]
    public virtual ICollection<MmformulaConfiguration> MmformulaConfigurations { get; set; } = new List<MmformulaConfiguration>();

    [InverseProperty("FkMmformulaIdpaintANavigation")]
    public virtual ICollection<MmpaintProcessConfigItem> MmpaintProcessConfigItemFkMmformulaIdpaintANavigations { get; set; } = new List<MmpaintProcessConfigItem>();

    [InverseProperty("FkMmformulaIdpaintBNavigation")]
    public virtual ICollection<MmpaintProcessConfigItem> MmpaintProcessConfigItemFkMmformulaIdpaintBNavigations { get; set; } = new List<MmpaintProcessConfigItem>();

    [InverseProperty("FkMmformulaIdpaintCNavigation")]
    public virtual ICollection<MmpaintProcessConfigItem> MmpaintProcessConfigItemFkMmformulaIdpaintCNavigations { get; set; } = new List<MmpaintProcessConfigItem>();
}
