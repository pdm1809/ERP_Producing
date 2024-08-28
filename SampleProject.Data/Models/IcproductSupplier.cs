using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSuppliers")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkApsupplierId", Name = "Idx_ICProductSuppliers")]
public partial class IcproductSupplier
{
    [Key]
    [Column("ICProductSupplierID")]
    public int IcproductSupplierId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICProductSupplierPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSupplierPrice { get; set; }

    /// <summary>
    /// Bestell-Nr , ASrtikelnummer des Lieferant
    /// </summary>
    [Column("ICProductSupplierNumber")]
    [StringLength(50)]
    public string IcproductSupplierNumber { get; set; }

    [Column("ICProductSupplierBarcode")]
    [StringLength(50)]
    public string IcproductSupplierBarcode { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("IcproductSuppliers")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductSuppliers")]
    public virtual Icproduct FkIcproduct { get; set; }
}
