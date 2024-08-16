using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICDepartmentAttributes")]
[Microsoft.EntityFrameworkCore.Index("IcdepartmentAttributeNo", Name = "Idx_ICDepartmentAttributes")]
public partial class IcdepartmentAttribute
{
    [Key]
    [Column("ICDepartmentAttributeID")]
    public int IcdepartmentAttributeId { get; set; }

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

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcdepartmentAttributes")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [InverseProperty("FkIcdepartmentAttribute")]
    public virtual ICollection<IcdepartmentAttributeValue> IcdepartmentAttributeValues { get; set; } = new List<IcdepartmentAttributeValue>();
}
