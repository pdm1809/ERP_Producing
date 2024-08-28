using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_NguyenLieu3")]
public partial class ImpNguyenLieu3
{
    [StringLength(1000)]
    public string MaNguyenLieu { get; set; }

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
    public string TenNguyenLieu { get; set; }

    [StringLength(1000)]
    public string MoTa { get; set; }

    [Column("DVT")]
    [StringLength(1000)]
    public string Dvt { get; set; }

    [Column("TTDai")]
    [StringLength(1000)]
    public string Ttdai { get; set; }

    [Column("TTRong")]
    [StringLength(1000)]
    public string Ttrong { get; set; }

    [Column("TTCao")]
    [StringLength(1000)]
    public string Ttcao { get; set; }

    [Column("TTDay")]
    [StringLength(1000)]
    public string Ttday { get; set; }

    [Column("TTLoaiGo")]
    [StringLength(1000)]
    public string TtloaiGo { get; set; }

    [Column("TTChatLuong")]
    [StringLength(1000)]
    public string TtchatLuong { get; set; }

    [Column("TTKichThuocKhac")]
    [StringLength(1000)]
    public string TtkichThuocKhac { get; set; }

    [Column("TTDoAm")]
    [StringLength(1000)]
    public string TtdoAm { get; set; }

    [Column("TTChungNhan")]
    [StringLength(1000)]
    public string TtchungNhan { get; set; }

    [Column("TTTieuChuanHoaHoc")]
    [StringLength(1000)]
    public string TttieuChuanHoaHoc { get; set; }

    [Column("TTBienDang")]
    [StringLength(1000)]
    public string TtbienDang { get; set; }

    [StringLength(1000)]
    public string LoaiMuaHang { get; set; }

    [StringLength(1000)]
    public string GiaMua { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Thue { get; set; }

    [StringLength(1000)]
    public string CongThucTinhGia { get; set; }

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
}
