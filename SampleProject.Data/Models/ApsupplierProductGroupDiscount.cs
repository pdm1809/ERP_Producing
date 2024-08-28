using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierProductGroupDiscounts")]
[Microsoft.EntityFrameworkCore.Index("FkApsupplierId", Name = "Idx_APSupplierProductGroupDiscounts")]
public partial class ApsupplierProductGroupDiscount
{
    [Key]
    [Column("APSupplierProductGroupDiscountID")]
    public int ApsupplierProductGroupDiscountId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("APSupplierProductGroupDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierProductGroupDiscountPercent { get; set; }

    [Column("APSupplierProductGroupDiscountDesc")]
    [StringLength(100)]
    public string ApsupplierProductGroupDiscountDesc { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApsupplierProductGroupDiscounts")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ApsupplierProductGroupDiscounts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
