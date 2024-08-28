using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("ICProductPackageBackups")]
public partial class IcproductPackageBackup
{
    [Column("ICProductPackageID")]
    public int IcproductPackageId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ICProductPackageNo")]
    [StringLength(50)]
    public string IcproductPackageNo { get; set; }

    [Column("ICProductPackageName")]
    [StringLength(256)]
    public string IcproductPackageName { get; set; }

    [Column("ICProductPackageMethodType")]
    [StringLength(256)]
    public string IcproductPackageMethodType { get; set; }

    [Column("ICProductPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackageQty { get; set; }

    [Column("ICProductPackageDesc")]
    [StringLength(512)]
    public string IcproductPackageDesc { get; set; }

    [Column("ICProductPackageStatus")]
    [StringLength(50)]
    public string IcproductPackageStatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }
}
