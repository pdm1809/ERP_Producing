using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMSaleWorkItems")]
public partial class PmsaleWorkItem
{
    [Key]
    [Column("PMSaleWorkItemID")]
    public int PmsaleWorkItemId { get; set; }

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

    [Column("FK_PMSaleWorkID")]
    public int? FkPmsaleWorkId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("PMSaleWorkItemDate", TypeName = "datetime")]
    public DateTime? PmsaleWorkItemDate { get; set; }

    [Column("PMSaleWorkItemNo")]
    [StringLength(50)]
    public string PmsaleWorkItemNo { get; set; }

    [Column("PMSaleWorkItemProductName")]
    [StringLength(256)]
    public string PmsaleWorkItemProductName { get; set; }

    [Column("PMSaleWorkItemProductDesc")]
    [StringLength(512)]
    public string PmsaleWorkItemProductDesc { get; set; }

    [Column("PMSaleWorkItemProductType")]
    [StringLength(256)]
    public string PmsaleWorkItemProductType { get; set; }

    [Column("PMSaleWorkItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? PmsaleWorkItemProductQty { get; set; }

    [Column("PMSaleWorkItemAddress")]
    [StringLength(512)]
    public string PmsaleWorkItemAddress { get; set; }

    [Column("PMSaleWorkItemCommand")]
    [StringLength(512)]
    public string PmsaleWorkItemCommand { get; set; }

    [Column("PMSaleWorkItemStatus")]
    [StringLength(50)]
    public string PmsaleWorkItemStatus { get; set; }

    [Column("PMSaleWorkItemActualDate", TypeName = "datetime")]
    public DateTime? PmsaleWorkItemActualDate { get; set; }

    [Column("PMSaleWorkItemCancelReason")]
    [StringLength(256)]
    public string PmsaleWorkItemCancelReason { get; set; }

    [Column("PMSaleWorkItemCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? PmsaleWorkItemCancelQty { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("PMObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmobjectType { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmsaleWorkItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmsaleWorkItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkPmsaleWorkId")]
    [InverseProperty("PmsaleWorkItems")]
    public virtual PmsaleWork FkPmsaleWork { get; set; }
}
