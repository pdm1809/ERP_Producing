using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class BysTable
{
    [StringLength(128)]
    public string Database { get; set; }

    [StringLength(128)]
    public string Owner { get; set; }

    [Required]
    [StringLength(128)]
    public string TableName { get; set; }

    [StringLength(128)]
    public string ColumnName { get; set; }

    public int? OrdinalPosition { get; set; }

    [StringLength(4000)]
    public string DefaultSetting { get; set; }

    [StringLength(128)]
    public string DataType { get; set; }

    public int? MaxLength { get; set; }

    public short? DatePrecision { get; set; }

    public byte? NumberPrecision { get; set; }

    public int? NumberScale { get; set; }

    public bool? IsNullable { get; set; }

    public int? IsIdentity { get; set; }

    public int? IsComputed { get; set; }

    public bool? IsPrimaryKey { get; set; }
}
