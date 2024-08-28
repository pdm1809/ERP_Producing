using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_Hardware2")]
public partial class ImpHardware2
{
    [StringLength(1000)]
    public string MaHardware { get; set; }

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
    public string TenHardware { get; set; }

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

    [Column("TTDai", TypeName = "decimal(18, 5)")]
    public decimal? Ttdai { get; set; }

    [Column("TTRong", TypeName = "decimal(18, 5)")]
    public decimal? Ttrong { get; set; }

    [Column("TTCao", TypeName = "decimal(18, 5)")]
    public decimal? Ttcao { get; set; }

    [Column("TTDay", TypeName = "decimal(18, 5)")]
    public decimal? Ttday { get; set; }

    [Column("TTDuongKinhNgoai", TypeName = "decimal(18, 5)")]
    public decimal? TtduongKinhNgoai { get; set; }

    [Column("TTDuongKinhTrong", TypeName = "decimal(18, 5)")]
    public decimal? TtduongKinhTrong { get; set; }

    [Column("TTChatLieu")]
    [StringLength(1000)]
    public string TtchatLieu { get; set; }

    [Column("TTHeGen")]
    [StringLength(1000)]
    public string TtheGen { get; set; }

    [Column("TTMauSac")]
    [StringLength(1000)]
    public string TtmauSac { get; set; }

    [Column("TTHinhDang")]
    [StringLength(1000)]
    public string TthinhDang { get; set; }

    [StringLength(1000)]
    public string LoaiMuaHang { get; set; }

    [Column("PPTinhGia")]
    [StringLength(1000)]
    public string PptinhGia { get; set; }

    [StringLength(1000)]
    public string TheoDoiTonKho { get; set; }

    [StringLength(1000)]
    public string NhomTaiKhoan { get; set; }

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
