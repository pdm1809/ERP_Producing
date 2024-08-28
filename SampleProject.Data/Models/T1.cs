using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("t1")]
public partial class T1
{
    [Column("c1")]
    public int? C1 { get; set; }

    [Column("c2", TypeName = "text")]
    public string C2 { get; set; }
}
