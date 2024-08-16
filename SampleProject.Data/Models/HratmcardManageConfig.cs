using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRATMCardManageConfigs")]
public partial class HratmcardManageConfig
{
    [Key]
    [Column("HRATMCardManageConfigID")]
    public int HratmcardManageConfigId { get; set; }

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

    [Required]
    [Column("HREmployeeATMCardManageStatus")]
    [StringLength(100)]
    public string HremployeeAtmcardManageStatus { get; set; }

    [Column("HRATMCardManageConfigAmount", TypeName = "decimal(18, 5)")]
    public decimal? HratmcardManageConfigAmount { get; set; }
}
