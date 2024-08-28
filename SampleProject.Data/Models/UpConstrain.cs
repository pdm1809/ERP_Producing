using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class UpConstrain
{
    [StringLength(128)]
    public string ForeignSchemaName { get; set; }

    [Required]
    [StringLength(128)]
    public string ForeignTableName { get; set; }

    [StringLength(128)]
    public string ForeignColumnName { get; set; }

    [StringLength(128)]
    public string PrimarySchemaName { get; set; }

    [Required]
    [StringLength(128)]
    public string PrimaryTableName { get; set; }

    [StringLength(128)]
    public string PrimaryColumnName { get; set; }

    [Required]
    [StringLength(128)]
    public string ConstraintName { get; set; }
}
