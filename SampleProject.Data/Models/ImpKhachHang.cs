using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_KhachHang")]
public partial class ImpKhachHang
{
    [StringLength(1000)]
    public string MaKhachHang { get; set; }

    [StringLength(1000)]
    public string TenKhachHang { get; set; }

    [Column("MaHTCu")]
    [StringLength(1000)]
    public string MaHtcu { get; set; }

    [StringLength(1000)]
    public string LoaiKhachHang { get; set; }

    [StringLength(1000)]
    public string MaSoThue { get; set; }

    [StringLength(1000)]
    public string NhomTaiKhoan { get; set; }

    [StringLength(1000)]
    public string DiaChi { get; set; }
}
