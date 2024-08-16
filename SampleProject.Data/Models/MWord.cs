using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("M_Words")]
public partial class MWord
{
    public int? Code { get; set; }

    [Column("WNumber")]
    public int? Wnumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Wwords { get; set; }
}
