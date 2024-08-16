﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_VPP")]
public partial class ImpVpp
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

    [StringLength(1000)]
    public string MaThuocTinh { get; set; }

    [Column("MaSPNCC")]
    [StringLength(1000)]
    public string MaSpncc { get; set; }

    [StringLength(1000)]
    public string NguonGoc { get; set; }

    [Column("HinhThucSD")]
    [StringLength(1000)]
    public string HinhThucSd { get; set; }

    [StringLength(1000)]
    public string XuatXu { get; set; }

    [Column("MaNCC")]
    [StringLength(1000)]
    public string MaNcc { get; set; }

    [StringLength(1000)]
    public string ThuongHieu { get; set; }

    [StringLength(1000)]
    public string LoaiHang { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Dai { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Rong { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Cao { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? DoDay { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? DuongKinh { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? GiaMua { get; set; }

    [StringLength(1000)]
    public string Thue { get; set; }

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

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? SlToiThieu { get; set; }

    [Column("SLToiDa", TypeName = "decimal(18, 5)")]
    public decimal? SltoiDa { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? ThoiGianTon { get; set; }

    [StringLength(1000)]
    public string ChoPhepSua { get; set; }

    [StringLength(1000)]
    public string HoatDong { get; set; }

    [Column("HienThiWWeb")]
    [StringLength(1000)]
    public string HienThiWweb { get; set; }

    [StringLength(1000)]
    public string KhuyenMai { get; set; }
}