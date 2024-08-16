﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ImpTaiSan2")]
public partial class ImpTaiSan2
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

    [Column(TypeName = "date")]
    public DateTime? NgayMua { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgaySuDung { get; set; }

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

    [Column(TypeName = "date")]
    public DateTime? NgayDung { get; set; }

    [StringLength(512)]
    public string PhongBan { get; set; }

    [StringLength(512)]
    public string Xuong { get; set; }

    [StringLength(512)]
    public string SoThangKhauHao { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayKhauHao { get; set; }

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
