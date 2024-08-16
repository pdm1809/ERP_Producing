using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_CongDoan")]
public partial class ImpCongDoan
{
    [StringLength(1000)]
    public string ThuocCongDoan { get; set; }

    [StringLength(1000)]
    public string MaCongDoan { get; set; }

    [StringLength(1000)]
    public string TenCongDoan { get; set; }

    [StringLength(1000)]
    public string ThuTu { get; set; }

    [StringLength(1000)]
    public string NhomCongDoan { get; set; }

    [Column("TKBTP")]
    [StringLength(1000)]
    public string Tkbtp { get; set; }

    [Column("TKChiPhi")]
    [StringLength(1000)]
    public string TkchiPhi { get; set; }

    [Column("TKDoDang")]
    [StringLength(1000)]
    public string TkdoDang { get; set; }

    [StringLength(1000)]
    public string Serie { get; set; }

    [StringLength(1000)]
    public string ChiNhanh { get; set; }

    [StringLength(1000)]
    public string TinhGiaThanh { get; set; }

    [StringLength(1000)]
    public string NhapKho { get; set; }

    [Column("CoKHSX")]
    [StringLength(1000)]
    public string CoKhsx { get; set; }

    [Column("CDBatDau")]
    [StringLength(1000)]
    public string CdbatDau { get; set; }

    [Column("CDKiemTra")]
    [StringLength(1000)]
    public string CdkiemTra { get; set; }

    [Column("SuDungSLDBH")]
    [StringLength(1000)]
    public string SuDungSldbh { get; set; }

    [Column("CDSuDungSL")]
    [StringLength(1000)]
    public string CdsuDungSl { get; set; }
}
