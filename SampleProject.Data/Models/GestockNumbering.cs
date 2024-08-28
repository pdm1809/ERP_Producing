using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEStockNumberings")]
public partial class GestockNumbering
{
    [Key]
    [Column("GEStockNumberingID")]
    public int GestockNumberingId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("GEStockNumberingModuleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string GestockNumberingModuleName { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("GEStockNumberingStart")]
    public int? GestockNumberingStart { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("GestockNumberings")]
    public virtual Icstock FkIcstock { get; set; }
}
