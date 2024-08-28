using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanWorks")]
public partial class ArdeliveryPlanWork
{
    [Key]
    [Column("ARDeliveryPlanWorkID")]
    public int ArdeliveryPlanWorkId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Column("FK_ARDeliveryPlanItemID")]
    public int? FkArdeliveryPlanItemId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ARDeliveryPlanWorkProductNo")]
    [StringLength(50)]
    public string ArdeliveryPlanWorkProductNo { get; set; }

    [Column("ARDeliveryPlanWorkProductName")]
    [StringLength(256)]
    public string ArdeliveryPlanWorkProductName { get; set; }

    [Column("ARDeliveryPlanWorkProductDesc")]
    [StringLength(512)]
    public string ArdeliveryPlanWorkProductDesc { get; set; }

    [Column("ARDeliveryPlanWorkProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkProductQty { get; set; }

    [Column("ARDeliveryPlanWorkProductType")]
    [StringLength(50)]
    public string ArdeliveryPlanWorkProductType { get; set; }

    [Column("ARDeliveryPlanWorkProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkProductUnitPrice { get; set; }

    [Column("ARDeliveryPlanWorkTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkTotalAmount { get; set; }

    [Column("ARDeliveryPlanWorkSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkSubTotalAmount { get; set; }

    [Column("ARDeliveryPlanWorkProductChargeCheck")]
    public bool? ArdeliveryPlanWorkProductChargeCheck { get; set; }

    [Column("ARDeliveryPlanWorkStatus")]
    [StringLength(50)]
    public string ArdeliveryPlanWorkStatus { get; set; }

    [Column("ARDeliveryPlanWorkParentID")]
    public int? ArdeliveryPlanWorkParentId { get; set; }

    [Column("ARDeliveryPlanWorkAllocationQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanWorkAllocationQty { get; set; }

    [Column("FK_ARSaleOrderItemWorkID")]
    public int? FkArsaleOrderItemWorkId { get; set; }

    [InverseProperty("FkArdeliveryPlanWork")]
    public virtual ICollection<ArallocationItem> ArallocationItems { get; set; } = new List<ArallocationItem>();

    [InverseProperty("FkArdeliveryPlanWork")]
    public virtual ICollection<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; } = new List<ArdeliveryPlanFile>();

    [InverseProperty("FkArdeliveryPlanWork")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTasks { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanWorks")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanItemId")]
    [InverseProperty("ArdeliveryPlanWorks")]
    public virtual ArdeliveryPlanItem FkArdeliveryPlanItem { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArdeliveryPlanWorks")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArdeliveryPlanWorks")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkArsaleOrderItemWorkId")]
    [InverseProperty("ArdeliveryPlanWorks")]
    public virtual ArsaleOrderItemWork FkArsaleOrderItemWork { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArdeliveryPlanWorks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArdeliveryPlanWorks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [InverseProperty("FkArdeliveryPlanWork")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkArdeliveryPlanWork")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();
}
