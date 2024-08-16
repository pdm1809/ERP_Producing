using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRConfigScales")]
public partial class HrconfigScale
{
    [Key]
    [Column("HRConfigScaleID")]
    public int HrconfigScaleId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("HRConfigScaleNo")]
    [StringLength(50)]
    public string HrconfigScaleNo { get; set; }

    [Required]
    [Column("HRConfigScaleName")]
    [StringLength(256)]
    public string HrconfigScaleName { get; set; }

    [Column("HRConfigScaleDesc")]
    [StringLength(512)]
    public string HrconfigScaleDesc { get; set; }

    [InverseProperty("FkHrconfigScale")]
    public virtual ICollection<HrconfigRank> HrconfigRanks { get; set; } = new List<HrconfigRank>();

    [InverseProperty("FkHrconfigScale")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();
}
