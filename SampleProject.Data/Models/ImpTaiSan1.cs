using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ImpTaiSan")]
public partial class ImpTaiSan1
{
    [StringLength(50)]
    public string MaTaiSan { get; set; }

    [StringLength(512)]
    public string TenTaiSan { get; set; }

    [Column("DVT")]
    [StringLength(50)]
    public string Dvt { get; set; }

    [StringLength(100)]
    public string LoaiTaiSan { get; set; }

    [StringLength(100)]
    public string NgayMua { get; set; }

    [StringLength(100)]
    public string NgaySuDung { get; set; }

    [StringLength(512)]
    public string NhomTaiKhoan { get; set; }

    [Column("TKChiPhi")]
    [StringLength(512)]
    public string TkchiPhi { get; set; }

    [Column("TKTaiSan")]
    [StringLength(512)]
    public string TktaiSan { get; set; }

    [Column("TKKhauHao")]
    [StringLength(512)]
    public string TkkhauHao { get; set; }

    [StringLength(512)]
    public string TinhTrang { get; set; }

    [StringLength(512)]
    public string NgayDung { get; set; }

    [StringLength(512)]
    public string PhongBan { get; set; }

    [StringLength(512)]
    public string Xuong { get; set; }

    [StringLength(512)]
    public string SoThangKhauHao { get; set; }

    [StringLength(512)]
    public string NgayKhauHao { get; set; }

    [Column("PPKhauHao")]
    [StringLength(512)]
    public string PpkhauHao { get; set; }

    [StringLength(512)]
    public string NguyenGia { get; set; }

    [StringLength(512)]
    public string GiaTriKhauHao { get; set; }

    [StringLength(512)]
    public string HaoMonLuyKe { get; set; }

    [StringLength(512)]
    public string SoKyKhauHaoConLai { get; set; }

    [StringLength(512)]
    public string GaiTriConLai { get; set; }
}
