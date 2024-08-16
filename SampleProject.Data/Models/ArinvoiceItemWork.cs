using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceItemWorks")]
public partial class ArinvoiceItemWork
{
    [Key]
    [Column("ARInvoiceItemWorkID")]
    public int ArinvoiceItemWorkId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARInvoiceItemID")]
    public int? FkArinvoiceItemId { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("ARInvoiceItemWorkProductNo")]
    [StringLength(50)]
    public string ArinvoiceItemWorkProductNo { get; set; }

    [Column("ARInvoiceItemWorkProductName")]
    [StringLength(256)]
    public string ArinvoiceItemWorkProductName { get; set; }

    [Column("ARInvoiceItemWorkProductDesc")]
    [StringLength(512)]
    public string ArinvoiceItemWorkProductDesc { get; set; }

    [Column("ARInvoiceItemWorkProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWorkProductQty { get; set; }

    [Column("ARInvoiceItemWorkProductType")]
    [StringLength(50)]
    public string ArinvoiceItemWorkProductType { get; set; }

    [Column("ARInvoiceItemWorkProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWorkProductUnitPrice { get; set; }

    [Column("ARInvoiceItemWorkTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWorkTotalAmount { get; set; }

    [Column("ARInvoiceItemWorkSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWorkSubTotalAmount { get; set; }

    [Column("ARInvoiceItemWorkProductChargeCheck")]
    public bool? ArinvoiceItemWorkProductChargeCheck { get; set; }

    [Column("ARInvoiceItemWorkStatus")]
    [StringLength(50)]
    public string ArinvoiceItemWorkStatus { get; set; }

    [Column("ARInvoiceItemWorkIsCost")]
    public bool? ArinvoiceItemWorkIsCost { get; set; }

    [Column("ARInvoiceItemWorkParentID")]
    public int? ArinvoiceItemWorkParentId { get; set; }

    [Column("ARInvoiceItemWorkComment")]
    [StringLength(256)]
    public string ArinvoiceItemWorkComment { get; set; }

    [Column("ARInvoiceItemWorkDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWorkDiscountAmount { get; set; }

    [Column("ARInvoiceItemWorkDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceItemWorkDiscountPerCent { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemWorkID")]
    public int? FkArsaleOrderItemWorkId { get; set; }

    [Column("FK_ARAcceptanceItemWorkID")]
    public int? FkAracceptanceItemWorkId { get; set; }

    [ForeignKey("FkAracceptanceItemWorkId")]
    [InverseProperty("ArinvoiceItemWorks")]
    public virtual AracceptanceItemWork FkAracceptanceItemWork { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArinvoiceItemWorks")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkArinvoiceItemId")]
    [InverseProperty("ArinvoiceItemWorks")]
    public virtual ArinvoiceItem FkArinvoiceItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArinvoiceItemWorks")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArinvoiceItemWorks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArinvoiceItemWorks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArinvoiceItemWorks")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
