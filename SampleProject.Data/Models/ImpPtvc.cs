using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_PTVC")]
public partial class ImpPtvc
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
    public string LoaiXe { get; set; }

    [StringLength(1000)]
    public string DieuKienBaoHanh { get; set; }

    [StringLength(1000)]
    public string TrangThai { get; set; }

    [StringLength(1000)]
    public string LoaiTaiSan { get; set; }

    [Column("TKTaiSan")]
    [StringLength(1000)]
    public string TktaiSan { get; set; }

    [Column("TKKhauHao")]
    [StringLength(1000)]
    public string TkkhauHao { get; set; }

    [StringLength(1000)]
    public string GhiChu { get; set; }
}
