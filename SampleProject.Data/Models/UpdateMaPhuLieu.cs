using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("UpdateMaPhuLieu")]
public partial class UpdateMaPhuLieu
{
    [StringLength(100)]
    public string MaMoi { get; set; }

    [StringLength(100)]
    public string MaCu { get; set; }

    [StringLength(100)]
    public string NganhHang { get; set; }

    [StringLength(100)]
    public string NhomHang1 { get; set; }

    [StringLength(100)]
    public string NhomHang2 { get; set; }

    [Column("STT")]
    [StringLength(100)]
    public string Stt { get; set; }

    [StringLength(1000)]
    public string Ten { get; set; }

    [StringLength(100)]
    public string MaVach { get; set; }

    [Column("MaHTCu")]
    [StringLength(100)]
    public string MaHtcu { get; set; }
}
