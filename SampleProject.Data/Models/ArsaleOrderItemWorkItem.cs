using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderItemWorkItems")]
public partial class ArsaleOrderItemWorkItem
{
    [Key]
    [Column("ARSaleOrderItemWorkItemID")]
    public int ArsaleOrderItemWorkItemId { get; set; }

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

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemWorkID")]
    public int? FkArsaleOrderItemWorkId { get; set; }

    [Column("ARSaleOrderItemWorkItemProductNo")]
    [StringLength(50)]
    public string ArsaleOrderItemWorkItemProductNo { get; set; }

    [Column("ARSaleOrderItemWorkItemProductName")]
    [StringLength(256)]
    public string ArsaleOrderItemWorkItemProductName { get; set; }

    [Column("ARSaleOrderItemWorkItemProductDesc")]
    [StringLength(512)]
    public string ArsaleOrderItemWorkItemProductDesc { get; set; }

    [Column("ARSaleOrderItemWorkItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkItemProductQty { get; set; }

    [Column("ARSaleOrderItemWorkItemProductType")]
    [StringLength(50)]
    public string ArsaleOrderItemWorkItemProductType { get; set; }

    [Column("ARSaleOrderItemWorkItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkItemProductUnitPrice { get; set; }

    [Column("ARSaleOrderItemWorkItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkItemTotalAmount { get; set; }

    [Column("ARSaleOrderItemWorkItemSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkItemSubTotalAmount { get; set; }

    [Column("ARSaleOrderItemWorkItemProductChargeCheck")]
    public bool? ArsaleOrderItemWorkItemProductChargeCheck { get; set; }

    [Column("ARSaleOrderItemWorkItemStatus")]
    [StringLength(50)]
    public string ArsaleOrderItemWorkItemStatus { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderItemWorkItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArsaleOrderItemWorkItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkArsaleOrderItemWorkId")]
    [InverseProperty("ArsaleOrderItemWorkItems")]
    public virtual ArsaleOrderItemWork FkArsaleOrderItemWork { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArsaleOrderItemWorkItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArsaleOrderItemWorkItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleOrderItemWorkItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArsaleOrderItemWorkItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
