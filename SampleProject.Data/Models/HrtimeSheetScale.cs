using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimeSheetScales")]
public partial class HrtimeSheetScale
{
    [Key]
    [Column("HRTimeSheetScaleID")]
    public int HrtimeSheetScaleId { get; set; }

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
    [Column("HRTimeSheetScaleNo")]
    [StringLength(50)]
    public string HrtimeSheetScaleNo { get; set; }

    [Required]
    [Column("HRTimeSheetScaleDesc")]
    [StringLength(512)]
    public string HrtimeSheetScaleDesc { get; set; }

    [InverseProperty("FkHrtimeSheetScale")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkHrtimeSheetScale")]
    public virtual ICollection<HrtimeSheetLevel> HrtimeSheetLevels { get; set; } = new List<HrtimeSheetLevel>();
}
