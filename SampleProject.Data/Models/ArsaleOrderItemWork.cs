using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderItemWorks")]
public partial class ArsaleOrderItemWork
{
    [Key]
    [Column("ARSaleOrderItemWorkID")]
    public int ArsaleOrderItemWorkId { get; set; }

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

    [Column("ARSaleOrderItemWorkProductNo")]
    [StringLength(50)]
    public string ArsaleOrderItemWorkProductNo { get; set; }

    [Column("ARSaleOrderItemWorkProductName")]
    [StringLength(256)]
    public string ArsaleOrderItemWorkProductName { get; set; }

    [Column("ARSaleOrderItemWorkProductDesc")]
    [StringLength(512)]
    public string ArsaleOrderItemWorkProductDesc { get; set; }

    [Column("ARSaleOrderItemWorkProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkProductQty { get; set; }

    [Column("ARSaleOrderItemWorkProductType")]
    [StringLength(50)]
    public string ArsaleOrderItemWorkProductType { get; set; }

    [Column("ARSaleOrderItemWorkProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkProductUnitPrice { get; set; }

    [Column("ARSaleOrderItemWorkTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkTotalAmount { get; set; }

    [Column("ARSaleOrderItemWorkSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkSubTotalAmount { get; set; }

    [Column("ARSaleOrderItemWorkProductChargeCheck")]
    public bool? ArsaleOrderItemWorkProductChargeCheck { get; set; }

    [Column("ARSaleOrderItemWorkStatus")]
    [StringLength(50)]
    public string ArsaleOrderItemWorkStatus { get; set; }

    [Column("ARSaleOrderItemWorkIsCost")]
    public bool? ArsaleOrderItemWorkIsCost { get; set; }

    [Column("ARSaleOrderItemWorkParentID")]
    public int? ArsaleOrderItemWorkParentId { get; set; }

    [Column("ARSaleOrderItemWorkComment")]
    [StringLength(256)]
    public string ArsaleOrderItemWorkComment { get; set; }

    [Column("ARSaleOrderItemWorkDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkDiscountAmount { get; set; }

    [Column("ARSaleOrderItemWorkDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkDiscountPerCent { get; set; }

    [Column("ARSaleOrderItemWorkCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemWorkCancelQty { get; set; }

    [InverseProperty("FkArsaleOrderItemWork")]
    public virtual ICollection<AracceptanceItemWork> AracceptanceItemWorks { get; set; } = new List<AracceptanceItemWork>();

    [InverseProperty("FkArsaleOrderItemWork")]
    public virtual ICollection<ArcancelVoucherItemCost> ArcancelVoucherItemCosts { get; set; } = new List<ArcancelVoucherItemCost>();

    [InverseProperty("FkArsaleOrderItemWork")]
    public virtual ICollection<ArdeliveryPlanWork> ArdeliveryPlanWorks { get; set; } = new List<ArdeliveryPlanWork>();

    [InverseProperty("FkArsaleOrderItemWork")]
    public virtual ICollection<ArsaleOrderItemWorkItem> ArsaleOrderItemWorkItems { get; set; } = new List<ArsaleOrderItemWorkItem>();

    [InverseProperty("FkArsaleOrderItemWork")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderItemWorks")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArsaleOrderItemWorks")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArsaleOrderItemWorks")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArsaleOrderItemWorks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArsaleOrderItemWorks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArsaleOrderItemWorks")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [InverseProperty("FkArsaleOrderItemWork")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();
}
