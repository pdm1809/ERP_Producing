using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_PhuLieuDongGoi")]
public partial class ImpPhuLieuDongGoi
{
    [StringLength(1000)]
    public string MaPhuLieu { get; set; }

    [StringLength(1000)]
    public string NganhHang { get; set; }

    [StringLength(1000)]
    public string NhomHang1 { get; set; }

    [StringLength(1000)]
    public string NhomHang2 { get; set; }

    [Column("STT")]
    [StringLength(1000)]
    public string Stt { get; set; }

    [StringLength(1000)]
    public string TenPhuLieu { get; set; }

    [StringLength(1000)]
    public string MoTa { get; set; }

    [Column("DVT")]
    [StringLength(1000)]
    public string Dvt { get; set; }

    [StringLength(1000)]
    public string MaVach { get; set; }

    [Column("MaHTCu")]
    [StringLength(1000)]
    public string MaHtcu { get; set; }

    [StringLength(1000)]
    public string NguonGoc { get; set; }

    [StringLength(1000)]
    public string HinhThucSuDung { get; set; }

    [StringLength(1000)]
    public string XuatXu { get; set; }

    [Column("TTPhuBiDai", TypeName = "decimal(18, 5)")]
    public decimal? TtphuBiDai { get; set; }

    [Column("TTPhuBiRong", TypeName = "decimal(18, 5)")]
    public decimal? TtphuBiRong { get; set; }

    [Column("TTPhuBiCao", TypeName = "decimal(18, 5)")]
    public decimal? TtphuBiCao { get; set; }

    [Column("TTKichThuocKhac")]
    [StringLength(1000)]
    public string TtkichThuocKhac { get; set; }

    [Column("TTDinhLuong")]
    [StringLength(1000)]
    public string TtdinhLuong { get; set; }

    [Column("TTDoBuc")]
    [StringLength(1000)]
    public string TtdoBuc { get; set; }

    [Column("TTSoLop")]
    [StringLength(1000)]
    public string TtsoLop { get; set; }

    [Column("TTMauSac")]
    [StringLength(1000)]
    public string TtmauSac { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? GiaMua { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Thue { get; set; }

    [Column("PPTinhGia")]
    [StringLength(1000)]
    public string PptinhGia { get; set; }

    [StringLength(1000)]
    public string TheoDoiTonKho { get; set; }

    [Column("TKTonKho")]
    [StringLength(1000)]
    public string TktonKho { get; set; }

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

    [StringLength(1000)]
    public string HoatDong { get; set; }

    [StringLength(1000)]
    public string KhuyenMai { get; set; }
}
