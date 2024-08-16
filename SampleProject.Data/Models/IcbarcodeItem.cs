using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICBarcodeItems")]
public partial class IcbarcodeItem
{
    [Key]
    [Column("ICBarcodeItemID")]
    public int IcbarcodeItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICBarcodeID")]
    public int? FkIcbarcodeId { get; set; }

    [Column("ICBarCodeItemBarcode")]
    [StringLength(50)]
    public string IcbarCodeItemBarcode { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductSupplierNumber")]
    [StringLength(50)]
    public string IcproductSupplierNumber { get; set; }

    [Column("ICBarCodeItemDesc")]
    [StringLength(512)]
    public string IcbarCodeItemDesc { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("ICBarCodeItemInventoryQty", TypeName = "decimal(18, 5)")]
    public decimal? IcbarCodeItemInventoryQty { get; set; }

    [Column("ICBarCodeItemBarcodeQty", TypeName = "decimal(18, 5)")]
    public decimal? IcbarCodeItemBarcodeQty { get; set; }

    [Column("ICBarCodeItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcbarCodeItemPrice { get; set; }

    [Column("ICBarCodeItemProductName")]
    [StringLength(256)]
    public string IcbarCodeItemProductName { get; set; }

    [ForeignKey("FkIcbarcodeId")]
    [InverseProperty("IcbarcodeItems")]
    public virtual Icbarcode FkIcbarcode { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcbarcodeItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcbarcodeItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
