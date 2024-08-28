using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_CCDC2")]
public partial class ImpCcdc2
{
    [Column("MaCCDC")]
    [StringLength(1000)]
    public string MaCcdc { get; set; }

    [StringLength(1000)]
    public string NganhHang { get; set; }

    [StringLength(1000)]
    public string NhomHang1 { get; set; }

    [StringLength(1000)]
    public string NhomHang2 { get; set; }

    [Column("STT")]
    [StringLength(1000)]
    public string Stt { get; set; }

    [Column("TenCCDC")]
    [StringLength(1000)]
    public string TenCcdc { get; set; }

    [Column("MoTaCCDC")]
    [StringLength(1000)]
    public string MoTaCcdc { get; set; }

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

    [Column("HinhThucSD")]
    [StringLength(1000)]
    public string HinhThucSd { get; set; }

    [StringLength(1000)]
    public string XuatXu { get; set; }

    [StringLength(1000)]
    public string ThuongHieu { get; set; }

    [StringLength(1000)]
    public string DieuKienBaoQuan { get; set; }

    [Column("THoiGianBaoHanh")]
    [StringLength(1000)]
    public string ThoiGianBaoHanh { get; set; }

    [StringLength(1000)]
    public string GiaMua { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Dai { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Rong { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Cao { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? DoDay { get; set; }

    [StringLength(1000)]
    public string CongSuat { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? DuongKinh { get; set; }

    [Column("TTDuongKinhTrong")]
    [StringLength(1000)]
    public string TtduongKinhTrong { get; set; }

    [Column("TTDuongKinhCot")]
    [StringLength(1000)]
    public string TtduongKinhCot { get; set; }

    [Column("TTChieuDaiCot")]
    [StringLength(1000)]
    public string TtchieuDaiCot { get; set; }

    [Column("TTVatLieu")]
    [StringLength(1000)]
    public string TtvatLieu { get; set; }

    [Column("TTApSuatHoi")]
    [StringLength(1000)]
    public string TtapSuatHoi { get; set; }

    [Column("TTTheTich")]
    [StringLength(1000)]
    public string TttheTich { get; set; }

    [Column("TTNguonDien")]
    [StringLength(1000)]
    public string TtnguonDien { get; set; }

    [Column("TTKhoiLuong")]
    [StringLength(1000)]
    public string TtkhoiLuong { get; set; }

    [Column("TTTocDoQuay")]
    [StringLength(1000)]
    public string TttocDoQuay { get; set; }

    [Column("TTChieuQuay")]
    [StringLength(1000)]
    public string TtchieuQuay { get; set; }

    [Column("TTVatLieuThan")]
    [StringLength(1000)]
    public string TtvatLieuThan { get; set; }

    [Column("TTVatLieuMui")]
    [StringLength(1000)]
    public string TtvatLieuMui { get; set; }

    [Column("TTSoCanh")]
    [StringLength(1000)]
    public string TtsoCanh { get; set; }

    [Column("TTKieuRang")]
    [StringLength(1000)]
    public string TtkieuRang { get; set; }

    [Column("TTChieuDaiRang")]
    [StringLength(1000)]
    public string TtchieuDaiRang { get; set; }

    [Column("TTLuuLuong")]
    [StringLength(1000)]
    public string TtluuLuong { get; set; }

    [Column("TTMain")]
    [StringLength(1000)]
    public string Ttmain { get; set; }

    [Column("TTCPU")]
    [StringLength(1000)]
    public string Ttcpu { get; set; }

    [Column("TTRam")]
    [StringLength(1000)]
    public string Ttram { get; set; }

    [Column("TTDoPhanGiai")]
    [StringLength(1000)]
    public string TtdoPhanGiai { get; set; }

    [Column("TTNguon")]
    [StringLength(1000)]
    public string Ttnguon { get; set; }

    [Column("TTKichThuocManHinh")]
    [StringLength(1000)]
    public string TtkichThuocManHinh { get; set; }

    [Column("TTDungLuong")]
    [StringLength(1000)]
    public string TtdungLuong { get; set; }

    [Column("TTLoaiDay")]
    [StringLength(1000)]
    public string TtloaiDay { get; set; }

    [Column("TTDoRongBangThong")]
    [StringLength(1000)]
    public string TtdoRongBangThong { get; set; }

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

    [Column("HienThiWWeb")]
    [StringLength(1000)]
    public string HienThiWweb { get; set; }

    [StringLength(1000)]
    public string KhuyenMai { get; set; }
}
