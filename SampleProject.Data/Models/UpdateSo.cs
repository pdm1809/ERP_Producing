using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("Update_SO")]
public partial class UpdateSo
{
    [StringLength(50)]
    public string SaleOrderNo { get; set; }
}
