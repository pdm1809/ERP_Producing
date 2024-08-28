using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("CheckPhuLieu")]
public partial class CheckPhuLieu
{
    [StringLength(100)]
    public string MaPhuLieu { get; set; }

    [StringLength(50)]
    public string NganhHang { get; set; }

    [StringLength(50)]
    public string NhomHang1 { get; set; }

    [StringLength(50)]
    public string NhomHang2 { get; set; }

    [Column("STT")]
    [StringLength(50)]
    public string Stt { get; set; }

    [StringLength(1000)]
    public string Ten { get; set; }

    [StringLength(1000)]
    public string MoTa { get; set; }
}
