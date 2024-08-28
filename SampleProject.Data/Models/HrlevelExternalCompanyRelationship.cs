using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevelExternalCompanyRelationships")]
public partial class HrlevelExternalCompanyRelationship
{
    [Key]
    [Column("HRLevelExternalCompanyRelationshipID")]
    public int HrlevelExternalCompanyRelationshipId { get; set; }

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

    [Column("HRLevelExternalCompanyRelationshipObjectName")]
    [StringLength(100)]
    public string HrlevelExternalCompanyRelationshipObjectName { get; set; }

    [Column("HRLevelExternalCompanyRelationshipEssence")]
    [StringLength(1024)]
    public string HrlevelExternalCompanyRelationshipEssence { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrlevelExternalCompanyRelationships")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
