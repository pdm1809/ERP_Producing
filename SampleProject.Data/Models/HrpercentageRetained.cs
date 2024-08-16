using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRPercentageRetaineds")]
public partial class HrpercentageRetained
{
    [Key]
    [Column("HRPercentageRetainedID")]
    public int HrpercentageRetainedId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("HRPercentageRetainedRate", TypeName = "decimal(18, 5)")]
    public decimal? HrpercentageRetainedRate { get; set; }

    [Column("HRPercentageRetainedType")]
    [StringLength(50)]
    public string HrpercentageRetainedType { get; set; }

    [Column("HRPercentageRetainedName")]
    [StringLength(50)]
    public string HrpercentageRetainedName { get; set; }

    [Column("HRPercentageRetainedNo")]
    [StringLength(50)]
    public string HrpercentageRetainedNo { get; set; }

    [Column("HRPercentageRetainedDesc")]
    [StringLength(500)]
    public string HrpercentageRetainedDesc { get; set; }

    [Column("HRPercentageRetainedDate", TypeName = "datetime")]
    public DateTime? HrpercentageRetainedDate { get; set; }
}
