using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Query")]
public partial class Query
{
    [Column("ICDepartmentAttributeID")]
    public int IcdepartmentAttributeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate")]
    [Precision(3)]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate")]
    [Precision(3)]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("ICDepartmentAttributeNo")]
    [StringLength(50)]
    public string IcdepartmentAttributeNo { get; set; }

    [Required]
    [Column("ICDepartmentAttributeName")]
    [StringLength(50)]
    public string IcdepartmentAttributeName { get; set; }

    [Column("ICDepartmentAttributeDesc")]
    [StringLength(512)]
    public string IcdepartmentAttributeDesc { get; set; }

    [Column("ICDepartmentAttributeLevel")]
    public int IcdepartmentAttributeLevel { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }
}
