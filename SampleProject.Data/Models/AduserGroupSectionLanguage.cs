using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADUserGroupSectionLanguages")]
public partial class AduserGroupSectionLanguage
{
    [Key]
    [Column("ADUserGroupSectionLanguageID")]
    public int AduserGroupSectionLanguageId { get; set; }

    [Column("ADUserGroupID")]
    public int AduserGroupId { get; set; }

    [Required]
    [Column("ADUserGroupSectionName")]
    [StringLength(50)]
    public string AduserGroupSectionName { get; set; }

    [Column("STLanguageID")]
    public int StlanguageId { get; set; }

    [Column("ADUserGroupSectionLanguageDesc")]
    [StringLength(250)]
    public string AduserGroupSectionLanguageDesc { get; set; }
}
