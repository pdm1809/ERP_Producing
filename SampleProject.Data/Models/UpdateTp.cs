using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("UpdateTP")]
public partial class UpdateTp
{
    [Column("MMProductionNormID")]
    public int? MmproductionNormId { get; set; }

    [Column("ICProductDetailID")]
    public int? IcproductDetailId { get; set; }

    [Column("ICProductItemID")]
    public int? IcproductItemId { get; set; }
}
