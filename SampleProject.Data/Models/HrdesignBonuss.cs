using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDesignBonuss")]
public partial class HrdesignBonuss
{
    [Key]
    [Column("HRDesignBonusID")]
    public int HrdesignBonusId { get; set; }

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

    [Column("HRDesignBonusGroup")]
    [StringLength(255)]
    public string HrdesignBonusGroup { get; set; }

    [Column("HRDesignBonusLevel", TypeName = "decimal(18, 5)")]
    public decimal? HrdesignBonusLevel { get; set; }

    [Column("HRConfigureAccording")]
    [StringLength(255)]
    public string HrconfigureAccording { get; set; }
}
