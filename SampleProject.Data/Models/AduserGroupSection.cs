using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADUserGroupSections")]
public partial class AduserGroupSection
{
    [Key]
    [Column("ADUserGroupSectionID")]
    public int AduserGroupSectionId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADUserGroupID")]
    public int AduserGroupId { get; set; }

    [Required]
    [Column("ADUserGroupSectionName")]
    [StringLength(50)]
    public string AduserGroupSectionName { get; set; }

    [Column("ADUserGroupSectionDesc")]
    [StringLength(250)]
    public string AduserGroupSectionDesc { get; set; }

    [Column("ADUserGroupSectionSortOrder")]
    public int AduserGroupSectionSortOrder { get; set; }

    [ForeignKey("AduserGroupId")]
    [InverseProperty("AduserGroupSections")]
    public virtual AduserGroup AduserGroup { get; set; }

    [InverseProperty("StuserGroupSection")]
    public virtual ICollection<StmoduleToUserGroupSection> StmoduleToUserGroupSections { get; set; } = new List<StmoduleToUserGroupSection>();
}
