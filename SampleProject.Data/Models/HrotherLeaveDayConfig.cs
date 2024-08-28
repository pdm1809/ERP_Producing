using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HROtherLeaveDayConfigs")]
public partial class HrotherLeaveDayConfig
{
    [Key]
    [Column("HROtherLeaveDayConfigID")]
    public int HrotherLeaveDayConfigId { get; set; }

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

    [Column("HROtherLeaveDayConfigNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrotherLeaveDayConfigNo { get; set; }

    [Column("HROtherLeaveDayConfigName")]
    [StringLength(100)]
    public string HrotherLeaveDayConfigName { get; set; }

    [Column("HROtherLeaveDayConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? HrotherLeaveDayConfigQty { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrotherLeaveDayConfigs")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrotherLeaveDayConfigs")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrotherLeaveDayConfigs")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
