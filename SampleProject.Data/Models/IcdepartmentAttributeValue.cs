using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICDepartmentAttributeValues")]
[Microsoft.EntityFrameworkCore.Index("IcdepartmentAttributeValueNo", "FkIcdepartmentAttributeId", Name = "Idx_ICDepartmentAttributeValues")]
public partial class IcdepartmentAttributeValue
{
    [Key]
    [Column("ICDepartmentAttributeValueID")]
    public int IcdepartmentAttributeValueId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ICDepartmentAttributeValueNo")]
    [StringLength(50)]
    public string IcdepartmentAttributeValueNo { get; set; }

    [Required]
    [Column("ICDepartmentAttributeValueValue")]
    [StringLength(100)]
    public string IcdepartmentAttributeValueValue { get; set; }

    [Column("FK_ICDepartmentAttributeID")]
    public int FkIcdepartmentAttributeId { get; set; }

    [ForeignKey("FkIcdepartmentAttributeId")]
    [InverseProperty("IcdepartmentAttributeValues")]
    public virtual IcdepartmentAttribute FkIcdepartmentAttribute { get; set; }
}
