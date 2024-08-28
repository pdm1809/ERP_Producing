using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_TaiSan")]
public partial class ImpTaiSan
{
    [StringLength(1000)]
    public string MaTaiSan { get; set; }

    [Column("STT")]
    [StringLength(1000)]
    public string Stt { get; set; }

    [StringLength(1000)]
    public string TenTaiSan { get; set; }

    [StringLength(1000)]
    public string MoTa { get; set; }

    [Column("DVT")]
    [StringLength(1000)]
    public string Dvt { get; set; }

    [StringLength(1000)]
    public string LoaiTaiSan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayMua { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgaySuDung { get; set; }

    [StringLength(1000)]
    public string NguoiSuDung { get; set; }

    [StringLength(1000)]
    public string NhomTaiKhoan { get; set; }

    [Column("TKChiPhi")]
    [StringLength(1000)]
    public string TkchiPhi { get; set; }

    [Column("TKTaiSan")]
    [StringLength(1000)]
    public string TktaiSan { get; set; }

    [Column("TKKhauHao")]
    [StringLength(1000)]
    public string TkkhauHao { get; set; }

    [StringLength(1000)]
    public string GhiChu { get; set; }

    [StringLength(1000)]
    public string TinhTrang { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgaySuDung2 { get; set; }

    [StringLength(1000)]
    public string PhongBan { get; set; }

    [StringLength(1000)]
    public string BoPhan { get; set; }

    [StringLength(1000)]
    public string Xuong { get; set; }

    [StringLength(1000)]
    public string Chuyen { get; set; }

    [Column("ToSX")]
    [StringLength(1000)]
    public string ToSx { get; set; }

    [Column("MaNhanVienSD")]
    [StringLength(1000)]
    public string MaNhanVienSd { get; set; }

    [Column("TTCP")]
    [StringLength(1000)]
    public string Ttcp { get; set; }

    [Column("KMCP")]
    [StringLength(1000)]
    public string Kmcp { get; set; }

    [StringLength(1000)]
    public string SoThangKhauHao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayKhauHao { get; set; }

    [Column("PPKhauHao")]
    [StringLength(1000)]
    public string PpkhauHao { get; set; }

    [StringLength(1000)]
    public string NguyenGia { get; set; }

    [StringLength(1000)]
    public string GiaTriKhauHaoBanDau { get; set; }

    [StringLength(1000)]
    public string GiaTriKhauHao { get; set; }

    [StringLength(1000)]
    public string HaoMonLuyKe { get; set; }

    [StringLength(1000)]
    public string SoKyKhauHaoConLai { get; set; }

    [StringLength(1000)]
    public string GiaTriConLai { get; set; }
}
