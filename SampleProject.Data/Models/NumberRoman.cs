using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("NumberRoman")]
public partial class NumberRoman
{
    public int? Number { get; set; }

    [StringLength(10)]
    public string Roman { get; set; }
}
