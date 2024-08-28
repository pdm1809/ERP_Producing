using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPaintProcessConfigs")]
public partial class MmpaintProcessConfig
{
    [Key]
    [Column("MMPaintProcessConfigID")]
    public int MmpaintProcessConfigId { get; set; }

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
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("MMPaintProcessConfigName")]
    [StringLength(512)]
    public string MmpaintProcessConfigName { get; set; }

    [Column("MMPaintProcessConfigNo")]
    [StringLength(50)]
    public string MmpaintProcessConfigNo { get; set; }

    [Column("MMPaintProcessConfigDesc")]
    [StringLength(512)]
    public string MmpaintProcessConfigDesc { get; set; }

    [Column("MMPaintProcessConfigDate", TypeName = "datetime")]
    public DateTime? MmpaintProcessConfigDate { get; set; }

    [Column("MMPaintProcessConfigStatus")]
    [StringLength(50)]
    public string MmpaintProcessConfigStatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmpaintProcessConfigs")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkMmpaintProcessConfig")]
    public virtual ICollection<MmpaintProcessConfigItem> MmpaintProcessConfigItems { get; set; } = new List<MmpaintProcessConfigItem>();
}
