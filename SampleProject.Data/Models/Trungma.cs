using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("trungma")]
public partial class Trungma
{
    [Required]
    [Column("ICProductNo")]
    [StringLength(50)]
    public string IcproductNo { get; set; }

    public int? Sluong { get; set; }

    public int? ChiSo { get; set; }
}
