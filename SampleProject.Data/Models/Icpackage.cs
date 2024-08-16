using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPackages")]
[Microsoft.EntityFrameworkCore.Index("IcpackageNo", Name = "Idx_ICPackages")]
public partial class Icpackage
{
    [Key]
    [Column("ICPackageID")]
    public int IcpackageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Required]
    [Column("ICPackageNo")]
    [StringLength(50)]
    public string IcpackageNo { get; set; }

    [Column("ICPackageSupplierNo")]
    [StringLength(50)]
    public string IcpackageSupplierNo { get; set; }

    [Column("ICPackageDesc")]
    [StringLength(512)]
    public string IcpackageDesc { get; set; }

    [Required]
    [Column("ICPackagePackNo")]
    [StringLength(50)]
    public string IcpackagePackNo { get; set; }

    [Column("ICPackageCount", TypeName = "decimal(18, 5)")]
    public decimal? IcpackageCount { get; set; }

    [Column("ICPackageProductCount", TypeName = "decimal(18, 5)")]
    public decimal? IcpackageProductCount { get; set; }

    [Column("ICPackageOrder")]
    public int? IcpackageOrder { get; set; }

    [Column("ICPackageReceiptDate", TypeName = "datetime")]
    public DateTime? IcpackageReceiptDate { get; set; }

    public bool? IsPrinted { get; set; }

    [Column("ICProductSupplierNo")]
    [StringLength(256)]
    public string IcproductSupplierNo { get; set; }

    [Column("ICProductDesc")]
    [StringLength(512)]
    public string IcproductDesc { get; set; }

    [InverseProperty("FkIcpackage")]
    public virtual ICollection<ArinvoiceItemPackage> ArinvoiceItemPackages { get; set; } = new List<ArinvoiceItemPackage>();

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("Icpackages")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [InverseProperty("FkIcpackage")]
    public virtual ICollection<IcinventoryPackage> IcinventoryPackages { get; set; } = new List<IcinventoryPackage>();

    [InverseProperty("FkIcpackage")]
    public virtual ICollection<IcpackageProduct> IcpackageProducts { get; set; } = new List<IcpackageProduct>();

    [InverseProperty("FkIcpackage")]
    public virtual ICollection<IctransferItemPackage> IctransferItemPackages { get; set; } = new List<IctransferItemPackage>();
}
