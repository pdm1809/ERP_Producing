using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Import_NCC")]
public partial class ImportNcc
{
    [Column("MaNCC")]
    [StringLength(100)]
    public string MaNcc { get; set; }

    [Column("MaHTCu")]
    [StringLength(100)]
    public string MaHtcu { get; set; }

    [Column("TenNCC")]
    [StringLength(500)]
    public string TenNcc { get; set; }

    [StringLength(500)]
    public string TenKhac { get; set; }

    [Column("LoaiNCC")]
    [StringLength(100)]
    public string LoaiNcc { get; set; }

    [StringLength(100)]
    public string ChiNhanh { get; set; }

    [Column("NhomTK")]
    [StringLength(100)]
    public string NhomTk { get; set; }

    [StringLength(100)]
    public string DienThoai1 { get; set; }

    [StringLength(100)]
    public string DienThoai2 { get; set; }

    [StringLength(100)]
    public string Fax { get; set; }

    [StringLength(100)]
    public string Email { get; set; }

    public string DiaChi { get; set; }

    [StringLength(100)]
    public string Website { get; set; }

    [StringLength(100)]
    public string Phuong { get; set; }

    [StringLength(100)]
    public string ThanhPho { get; set; }

    [StringLength(100)]
    public string Tinh { get; set; }

    [StringLength(100)]
    public string QuocGia { get; set; }

    [StringLength(100)]
    public string MaVung { get; set; }

    [Column("PTTT")]
    [StringLength(100)]
    public string Pttt { get; set; }

    [Column("DKTT")]
    [StringLength(100)]
    public string Dktt { get; set; }

    [StringLength(100)]
    public string LoaiTienTe { get; set; }

    [Column("MST")]
    [StringLength(100)]
    public string Mst { get; set; }

    [StringLength(100)]
    public string TenNganHang { get; set; }

    [Column("STK1")]
    [StringLength(100)]
    public string Stk1 { get; set; }

    [Column("STK2")]
    [StringLength(100)]
    public string Stk2 { get; set; }

    [StringLength(100)]
    public string DanhXung { get; set; }

    [StringLength(100)]
    public string TenLienHe { get; set; }

    [StringLength(100)]
    public string DienThoaiLienHe { get; set; }

    [Column("DTDDLienHe")]
    [StringLength(100)]
    public string DtddlienHe { get; set; }

    [StringLength(100)]
    public string FaxLienHe { get; set; }

    [StringLength(100)]
    public string EmailLienHe { get; set; }

    public string DiaChiLienHe { get; set; }

    [StringLength(100)]
    public string WebsiteLienHe { get; set; }
}
