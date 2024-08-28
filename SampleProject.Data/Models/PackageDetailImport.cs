using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class PackageDetailImport
{
    [StringLength(100)]
    public string ProductNo { get; set; }

    [StringLength(100)]
    public string PackageNo { get; set; }

    [StringLength(250)]
    public string PackageName { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? PackageQty { get; set; }

    [StringLength(250)]
    public string PackageStyleName { get; set; }

    [StringLength(250)]
    public string PackageStyleType { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? PackageStyleQty { get; set; }

    [StringLength(50)]
    public string PackageDetailImportNo { get; set; }

    [StringLength(50)]
    public string PackageDetailImportNoFull { get; set; }
}
