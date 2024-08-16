using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("UpdateCCDC")]
public partial class UpdateCcdc
{
    [Column("MaCCDC")]
    [StringLength(50)]
    public string MaCcdc { get; set; }

    [Column("TenCCDC")]
    [StringLength(1000)]
    public string TenCcdc { get; set; }

    [StringLength(50)]
    public string MaVach { get; set; }

    [Column("MaHTCu")]
    [StringLength(50)]
    public string MaHtcu { get; set; }
}
