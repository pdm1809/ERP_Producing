using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeSheetLevels")]
public partial class HrtimeSheetLevel
{
    [Key]
    [Column("HRTimeSheetLevelID")]
    public int HrtimeSheetLevelId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRTimeSheetScaleID")]
    public int? FkHrtimeSheetScaleId { get; set; }

    [Column("HRTimeSheetLevelFrom", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetLevelFrom { get; set; }

    [Column("HRTimeSheetLevelTo", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetLevelTo { get; set; }

    [Column("HRTimeSheetLevelValue", TypeName = "decimal(18, 5)")]
    public decimal? HrtimeSheetLevelValue { get; set; }

    [ForeignKey("FkHrtimeSheetScaleId")]
    [InverseProperty("HrtimeSheetLevels")]
    public virtual HrtimeSheetScale FkHrtimeSheetScale { get; set; }
}
