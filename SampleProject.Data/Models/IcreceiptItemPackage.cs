using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptItemPackages")]
public partial class IcreceiptItemPackage
{
    [Key]
    [Column("ICReceiptItemPackageID")]
    public int IcreceiptItemPackageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICReceiptComponentItemID")]
    public int FkIcreceiptComponentItemId { get; set; }

    [Column("ICReceiptItemPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemPackageQty { get; set; }

    [Column("ICReceiptItemPackageSupplierNo")]
    [StringLength(50)]
    public string IcreceiptItemPackageSupplierNo { get; set; }

    [ForeignKey("FkIcreceiptComponentItemId")]
    [InverseProperty("IcreceiptItemPackages")]
    public virtual IcreceiptComponentItem FkIcreceiptComponentItem { get; set; }
}
