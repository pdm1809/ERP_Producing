using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptComponentItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcstockId", "IcreceiptComponentItemType", Name = "Idx_ICReceiptComponentItems")]
public partial class IcreceiptComponentItem
{
    [Key]
    [Column("ICReceiptComponentItemID")]
    public int IcreceiptComponentItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICReceiptItemID")]
    public int FkIcreceiptItemId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("ICReceiptComponentItemProductSupplierNo")]
    [StringLength(50)]
    public string IcreceiptComponentItemProductSupplierNo { get; set; }

    [Column("ICReceiptComponentItemProductName")]
    [StringLength(100)]
    public string IcreceiptComponentItemProductName { get; set; }

    [Column("ICReceiptComponentItemProductDesc")]
    [StringLength(512)]
    public string IcreceiptComponentItemProductDesc { get; set; }

    [Column("ICReceiptComponentItemProductAttribute")]
    [StringLength(200)]
    public string IcreceiptComponentItemProductAttribute { get; set; }

    [Column("ICReceiptComponentItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreceiptComponentItemType { get; set; }

    [Column("ICReceiptComponentItemPackageQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptComponentItemPackageQty { get; set; }

    [Column("ICReceiptComponentItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptComponentItemProductQty { get; set; }

    public bool? IsPackageGroup { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcreceiptComponentItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcreceiptComponentItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcreceiptComponentItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcreceiptComponentItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcreceiptItemId")]
    [InverseProperty("IcreceiptComponentItems")]
    public virtual IcreceiptItem FkIcreceiptItem { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcreceiptComponentItems")]
    public virtual Icstock FkIcstock { get; set; }

    [InverseProperty("FkIcreceiptComponentItem")]
    public virtual ICollection<IcreceiptItemPackage> IcreceiptItemPackages { get; set; } = new List<IcreceiptItemPackage>();
}
