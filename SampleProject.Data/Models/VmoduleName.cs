using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class VmoduleName
{
    [Required]
    [Column("STModuleDescriptionDescription")]
    [StringLength(255)]
    public string StmoduleDescriptionDescription { get; set; }

    [Required]
    [Column("STModuleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StmoduleName { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }
}
