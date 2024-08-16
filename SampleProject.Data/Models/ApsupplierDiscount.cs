using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("APSupplierDiscounts")]
[Microsoft.EntityFrameworkCore.Index("FkApsupplierId", Name = "Idx_APSupplierDiscounts")]
public partial class ApsupplierDiscount
{
    [Column("APSupplierDiscountID")]
    public int ApsupplierDiscountId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Column("FK_ADDiscountID")]
    public int FkAddiscountId { get; set; }

    [ForeignKey("FkAddiscountId")]
    public virtual Addiscount FkAddiscount { get; set; }

    [ForeignKey("FkApsupplierId")]
    public virtual Apsupplier FkApsupplier { get; set; }
}
