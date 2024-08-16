using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("UpdateNguyenLieu")]
public partial class UpdateNguyenLieu
{
    [StringLength(50)]
    public string MaNguyenLieu { get; set; }

    [StringLength(500)]
    public string TenNguyenLieu { get; set; }

    [StringLength(1024)]
    public string MoTa { get; set; }
}
