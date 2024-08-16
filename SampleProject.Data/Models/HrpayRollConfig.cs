using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRPayRollConfigs")]
public partial class HrpayRollConfig
{
    [Key]
    [Column("HRPayRollConfigID")]
    public int HrpayRollConfigId { get; set; }

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

    [Column("HRPayRollConfigNo")]
    [StringLength(50)]
    public string HrpayRollConfigNo { get; set; }

    [Required]
    [Column("HRPayRollConfigName")]
    [StringLength(50)]
    public string HrpayRollConfigName { get; set; }

    [Column("HRPayRollConfigDesc")]
    [StringLength(512)]
    public string HrpayRollConfigDesc { get; set; }

    [Column("HRPayRollConfigType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrpayRollConfigType { get; set; }

    [Column("HRPayRollConfigMin", TypeName = "decimal(18, 5)")]
    public decimal? HrpayRollConfigMin { get; set; }

    [Column("HRPayRollConfigMax", TypeName = "decimal(18, 5)")]
    public decimal? HrpayRollConfigMax { get; set; }

    [InverseProperty("FkHrpayRollConfig")]
    public virtual ICollection<HremployeePayRollConfig> HremployeePayRollConfigs { get; set; } = new List<HremployeePayRollConfig>();
}
