using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_DanhMucTaiKhoan")]
public partial class ImpDanhMucTaiKhoan
{
    [StringLength(50)]
    public string Cap1 { get; set; }

    [StringLength(50)]
    public string Cap2 { get; set; }

    [StringLength(50)]
    public string Cap3 { get; set; }

    [StringLength(500)]
    public string TenTaiKhoan { get; set; }

    [StringLength(500)]
    public string TinhChat { get; set; }

    [StringLength(500)]
    public string CachDinhKhoan { get; set; }
}
