using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRFormAllowances")]
public partial class HrformAllowance
{
    [Key]
    [Column("HRFormAllowanceID")]
    public int HrformAllowanceId { get; set; }

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

    [Column("HRFormAllowanceNo")]
    [StringLength(50)]
    public string HrformAllowanceNo { get; set; }

    [Required]
    [Column("HRFormAllowanceName")]
    [StringLength(50)]
    public string HrformAllowanceName { get; set; }

    [Column("HRFormAllowanceDesc")]
    [StringLength(512)]
    public string HrformAllowanceDesc { get; set; }

    [Column("HRFormAllowanceType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrformAllowanceType { get; set; }

    [Column("HRFormAllowanceNameType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrformAllowanceNameType { get; set; }
}
