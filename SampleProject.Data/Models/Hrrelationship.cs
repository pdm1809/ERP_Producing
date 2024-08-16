using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRelationships")]
public partial class Hrrelationship
{
    [Key]
    [Column("HRRelationshipID")]
    public int HrrelationshipId { get; set; }

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

    [Column("HRRelationshipCode")]
    [StringLength(50)]
    public string HrrelationshipCode { get; set; }

    [Column("HRRelationshipName")]
    [StringLength(512)]
    public string HrrelationshipName { get; set; }

    [InverseProperty("FkHrrelationship")]
    public virtual ICollection<HremployeeContactPerson> HremployeeContactPeople { get; set; } = new List<HremployeeContactPerson>();

    [InverseProperty("FkHrrelationship")]
    public virtual ICollection<HrregisterDormitoryItem> HrregisterDormitoryItems { get; set; } = new List<HrregisterDormitoryItem>();
}
