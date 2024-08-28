using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLevelExternalDepartmentRelationships")]
public partial class HrlevelExternalDepartmentRelationship
{
    [Key]
    [Column("HRLevelExternalDepartmentRelationshipID")]
    public int HrlevelExternalDepartmentRelationshipId { get; set; }

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

    [Column("HRLevelExternalDepartmentRelationshipObjectName")]
    [StringLength(100)]
    public string HrlevelExternalDepartmentRelationshipObjectName { get; set; }

    [Column("HRLevelExternalDepartmentRelationshipEssence")]
    [StringLength(1024)]
    public string HrlevelExternalDepartmentRelationshipEssence { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrlevelExternalDepartmentRelationships")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
