using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevelJurisdictions")]
public partial class HrlevelJurisdiction
{
    [Key]
    [Column("HRLevelJurisdictionID")]
    public int HrlevelJurisdictionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("HRLevelJurisdictionName")]
    [StringLength(512)]
    public string HrlevelJurisdictionName { get; set; }

    [Column("HRLevelJurisdictionDetails")]
    [StringLength(1024)]
    public string HrlevelJurisdictionDetails { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrlevelJurisdictions")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
