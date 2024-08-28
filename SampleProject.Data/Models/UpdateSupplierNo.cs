using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("UpdateSupplierNo")]
public partial class UpdateSupplierNo
{
    [StringLength(100)]
    public string MaCu { get; set; }

    [StringLength(100)]
    public string MaMoi { get; set; }

    [Column("TenNCC")]
    [StringLength(255)]
    public string TenNcc { get; set; }

    [Column("MaHTCu")]
    [StringLength(255)]
    public string MaHtcu { get; set; }

    [Column("PTTT")]
    [StringLength(255)]
    public string Pttt { get; set; }

    [Column("MST")]
    [StringLength(50)]
    [Unicode(false)]
    public string Mst { get; set; }
}
