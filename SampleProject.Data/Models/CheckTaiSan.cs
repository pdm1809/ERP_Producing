using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("CheckTaiSan")]
public partial class CheckTaiSan
{
    [StringLength(100)]
    public string MaSanPham { get; set; }

    [StringLength(100)]
    public string MaDinhDanh { get; set; }

    [StringLength(1000)]
    public string MoTa { get; set; }
}
