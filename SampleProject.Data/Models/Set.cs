using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("Key", "Value")]
[Table("Set", Schema = "HangFire")]
public partial class Set
{
    [Key]
    [StringLength(100)]
    public string Key { get; set; }

    public double Score { get; set; }

    [Key]
    [StringLength(256)]
    public string Value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireAt { get; set; }
}
