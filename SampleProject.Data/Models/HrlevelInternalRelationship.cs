using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevelInternalRelationships")]
public partial class HrlevelInternalRelationship
{
    [Key]
    [Column("HRLevelInternalRelationshipID")]
    public int HrlevelInternalRelationshipId { get; set; }

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

    [Column("HRLevelInternalRelationshipDirectlyReport")]
    [StringLength(512)]
    public string HrlevelInternalRelationshipDirectlyReport { get; set; }

    [Column("HRLevelInternalRelationshipSupervisionReport")]
    [StringLength(512)]
    public string HrlevelInternalRelationshipSupervisionReport { get; set; }

    [Column("HRLevelInternalRelationshipCombinationReport")]
    [StringLength(512)]
    public string HrlevelInternalRelationshipCombinationReport { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrlevelInternalRelationships")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
