using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierProductNumbers")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkApsupplierId", Name = "Idx_APSupplierProductNumbers")]
public partial class ApsupplierProductNumber
{
    [Key]
    [Column("APSupplierProductNumberID")]
    public int ApsupplierProductNumberId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Required]
    [Column("APSupplierProductNumber")]
    [StringLength(50)]
    public string ApsupplierProductNumber1 { get; set; }

    [Column("APSupplierProductNumberDesc")]
    [StringLength(255)]
    public string ApsupplierProductNumberDesc { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApsupplierProductNumbers")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApsupplierProductNumbers")]
    public virtual Icproduct FkIcproduct { get; set; }
}
