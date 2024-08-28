using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Imp_ThuocTinhKhac")]
public partial class ImpThuocTinhKhac
{
    [StringLength(50)]
    public string MaThuocTinh { get; set; }

    [StringLength(100)]
    public string GiaTri { get; set; }
}
