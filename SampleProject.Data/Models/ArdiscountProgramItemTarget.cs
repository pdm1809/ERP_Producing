using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDiscountProgramItemTargets")]
public partial class ArdiscountProgramItemTarget
{
    [Key]
    [Column("ARDiscountProgramItemTargetID")]
    public int ArdiscountProgramItemTargetId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ARDiscountProgramID")]
    public int? FkArdiscountProgramId { get; set; }

    [Column("ARDiscountProgramItemTargetType")]
    [StringLength(50)]
    public string ArdiscountProgramItemTargetType { get; set; }

    [Column("ARDiscountProgramItemTargetFromDate", TypeName = "datetime")]
    public DateTime? ArdiscountProgramItemTargetFromDate { get; set; }

    [Column("ARDiscountProgramItemTargetToDate", TypeName = "datetime")]
    public DateTime? ArdiscountProgramItemTargetToDate { get; set; }

    [Column("ARDiscountProgramItemTargetValue", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemTargetValue { get; set; }

    [Column("ARDiscountProgramItemTargetBonus01", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemTargetBonus01 { get; set; }

    [Column("ARDiscountProgramItemTargetBonus02", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemTargetBonus02 { get; set; }

    [Column("ARDiscountProgramItemTargetRate", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemTargetRate { get; set; }

    [Column("ARDiscountProgramItemTargetRemark")]
    [StringLength(1024)]
    public string ArdiscountProgramItemTargetRemark { get; set; }

    [ForeignKey("FkArdiscountProgramId")]
    [InverseProperty("ArdiscountProgramItemTargets")]
    public virtual ArdiscountProgram FkArdiscountProgram { get; set; }
}
