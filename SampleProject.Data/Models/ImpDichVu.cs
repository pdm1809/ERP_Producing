using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_DichVu")]
public partial class ImpDichVu
{
    [Column("MaSPKhac")]
    [StringLength(1000)]
    public string MaSpkhac { get; set; }

    [StringLength(1000)]
    public string NganhHang { get; set; }

    [StringLength(1000)]
    public string NhomHang1 { get; set; }

    [StringLength(1000)]
    public string NhomHang2 { get; set; }

    [Column("STT")]
    [StringLength(1000)]
    public string Stt { get; set; }

    [Column("TenSPKhac")]
    [StringLength(1000)]
    public string TenSpkhac { get; set; }

    [StringLength(1000)]
    public string MoTa { get; set; }

    [Column("DVT")]
    [StringLength(1000)]
    public string Dvt { get; set; }

    [StringLength(1000)]
    public string MaVach { get; set; }

    [Column("HinhThucSD")]
    [StringLength(1000)]
    public string HinhThucSd { get; set; }

    [Column("MaNCC")]
    [StringLength(1000)]
    public string MaNcc { get; set; }

    [StringLength(1000)]
    public string LoaiHinhThucHien { get; set; }

    [StringLength(1000)]
    public string Loai { get; set; }

    [StringLength(1000)]
    public string TaKhoan { get; set; }

    [StringLength(1000)]
    public string KhoanMucChiPhi { get; set; }

    [StringLength(1000)]
    public string DinhMucCoDinh { get; set; }

    [StringLength(1000)]
    public string KhoaMuaHang { get; set; }

    [StringLength(1000)]
    public string TinhPhi { get; set; }

    [StringLength(1000)]
    public string HoatDong { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? GiaMua { get; set; }

    [StringLength(1000)]
    public string Thue { get; set; }

    [Column("PPTinhGia")]
    [StringLength(1000)]
    public string PptinhGia { get; set; }

    [Column("TKDoanhThu")]
    [StringLength(1000)]
    public string TkdoanhThu { get; set; }

    [Column("TKHangBanTraLai")]
    [StringLength(1000)]
    public string TkhangBanTraLai { get; set; }

    [Column("TKGiaVon")]
    [StringLength(1000)]
    public string TkgiaVon { get; set; }

    [Column("TKChietKhau")]
    [StringLength(1000)]
    public string TkchietKhau { get; set; }
}
