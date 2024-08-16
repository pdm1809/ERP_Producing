using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePayRollConfigs")]
public partial class HremployeePayRollConfig
{
    [Key]
    [Column("HREmployeePayRollConfigID")]
    public int HremployeePayRollConfigId { get; set; }

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

    [Column("HREmployeePayRollConfigNo")]
    [StringLength(50)]
    public string HremployeePayRollConfigNo { get; set; }

    [Column("HREmployeePayRollConfigName")]
    [StringLength(50)]
    public string HremployeePayRollConfigName { get; set; }

    [Column("HREmployeePayRollConfigDesc")]
    [StringLength(512)]
    public string HremployeePayRollConfigDesc { get; set; }

    [Column("FK_HRPayRollConfigID")]
    public int? FkHrpayRollConfigId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeePayRollConfigs")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrpayRollConfigId")]
    [InverseProperty("HremployeePayRollConfigs")]
    public virtual HrpayRollConfig FkHrpayRollConfig { get; set; }
}
