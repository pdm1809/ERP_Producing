using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ImportAttribute")]
public partial class ImportAttribute
{
    [StringLength(10)]
    public string No { get; set; }

    [Column("value")]
    [StringLength(50)]
    public string Value { get; set; }
}
