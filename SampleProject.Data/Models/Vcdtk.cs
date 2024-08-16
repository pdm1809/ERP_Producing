using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class Vcdtk
{
    [Column("ACBalanceID")]
    public int AcbalanceId { get; set; }

    [Column("ngay_ct", TypeName = "date")]
    public DateTime? NgayCt { get; set; }

    [Column("ma_tk")]
    public int? MaTk { get; set; }

    [Column("tk")]
    [StringLength(50)]
    public string Tk { get; set; }

    [Column("loai_tk")]
    public int LoaiTk { get; set; }

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
}
