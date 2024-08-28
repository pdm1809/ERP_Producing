using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_NhomHang")]
public partial class ImpNhomHang
{
    [StringLength(50)]
    public string NhommHang1 { get; set; }

    [StringLength(500)]
    public string TenNhommHang1 { get; set; }

    [StringLength(50)]
    public string NhommHang2 { get; set; }

    [StringLength(500)]
    public string TenNhommHang2 { get; set; }
}
