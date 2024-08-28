using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("import_products")]
public partial class ImportProduct
{
    [Column("no")]
    [StringLength(50)]
    public string No { get; set; }

    [Column("nhomhang1")]
    [StringLength(50)]
    public string Nhomhang1 { get; set; }

    [Column("nhomhang2")]
    [StringLength(50)]
    public string Nhomhang2 { get; set; }

    [Column("name")]
    [StringLength(500)]
    public string Name { get; set; }

    [Column("desc")]
    [StringLength(500)]
    public string Desc { get; set; }

    [Column("code")]
    [StringLength(50)]
    public string Code { get; set; }

    [Column("old_code")]
    [StringLength(50)]
    public string OldCode { get; set; }

    [Column("chatlieu")]
    [StringLength(50)]
    public string Chatlieu { get; set; }

    [Column("heren")]
    [StringLength(50)]
    public string Heren { get; set; }

    [Column("mausac")]
    [StringLength(50)]
    public string Mausac { get; set; }

    [Column("hinhdang")]
    [StringLength(50)]
    public string Hinhdang { get; set; }

    [Column("dvt")]
    [StringLength(50)]
    public string Dvt { get; set; }

    [Column("productGroupId")]
    public int? ProductGroupId { get; set; }

    [Column("measureUnitId")]
    public int? MeasureUnitId { get; set; }

    [Column("chatlieuid")]
    public int? Chatlieuid { get; set; }

    [Column("chatlieuno")]
    public int? Chatlieuno { get; set; }

    [Column("herenid")]
    public int? Herenid { get; set; }

    [Column("herenno")]
    public int? Herenno { get; set; }

    [Column("mausacid")]
    public int? Mausacid { get; set; }

    [Column("mausacno")]
    public int? Mausacno { get; set; }

    [Column("hinhdangid")]
    public int? Hinhdangid { get; set; }

    [Column("hinhdangno")]
    public int? Hinhdangno { get; set; }
}
