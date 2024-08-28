using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleToUserGroupSections")]
public partial class StmoduleToUserGroupSection
{
    [Key]
    [Column("STModuleToUserGroupSectionID")]
    public int StmoduleToUserGroupSectionId { get; set; }

    [Column("STUserGroupSectionID")]
    public int StuserGroupSectionId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("STModuleToUserGroupSectionSortOrder")]
    public int StmoduleToUserGroupSectionSortOrder { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("StmoduleToUserGroupSections")]
    public virtual Stmodule Stmodule { get; set; }

    [ForeignKey("StuserGroupSectionId")]
    [InverseProperty("StmoduleToUserGroupSections")]
    public virtual AduserGroupSection StuserGroupSection { get; set; }
}
