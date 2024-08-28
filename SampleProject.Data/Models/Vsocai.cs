using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class Vsocai
{
    [Column("ACTransactionID")]
    public int ActransactionId { get; set; }

    [Column("loai_ct")]
    [StringLength(50)]
    public string LoaiCt { get; set; }

    [Column("ten_ct")]
    [StringLength(50)]
    public string TenCt { get; set; }

    [Required]
    [Column("ma_ct")]
    [StringLength(50)]
    public string MaCt { get; set; }

    [Column("ngay_ct", TypeName = "date")]
    public DateTime? NgayCt { get; set; }

    [Column("ma_tk")]
    public int? MaTk { get; set; }

    [Column("loai_tk")]
    public int LoaiTk { get; set; }

    [StringLength(50)]
    public string Tk { get; set; }

    [Column("ma_tk_du")]
    public int? MaTkDu { get; set; }

    [Column("tk_du")]
    [StringLength(50)]
    public string TkDu { get; set; }

    [Column("ma_dt")]
    public int? MaDt { get; set; }

    [Column("loai_dt")]
    [StringLength(50)]
    [Unicode(false)]
    public string LoaiDt { get; set; }

    [Column("ma_nt")]
    public int MaNt { get; set; }

    [Column("ty_gia", TypeName = "decimal(18, 5)")]
    public decimal? TyGia { get; set; }

    [Column("no_nt", TypeName = "decimal(18, 5)")]
    public decimal? NoNt { get; set; }

    [Column("co_nt", TypeName = "decimal(18, 5)")]
    public decimal? CoNt { get; set; }

    [Column("no", TypeName = "decimal(18, 5)")]
    public decimal? No { get; set; }

    [Column("co", TypeName = "decimal(18, 5)")]
    public decimal? Co { get; set; }

    [Column("ma_dv")]
    public int? MaDv { get; set; }

    [Column("BRBranchParentID")]
    public int? BrbranchParentId { get; set; }

    [Column("dien_giai")]
    [StringLength(1024)]
    public string DienGiai { get; set; }

    public int IsCredit { get; set; }

    [Required]
    [Column("ma_hd")]
    [StringLength(50)]
    public string MaHd { get; set; }
}
