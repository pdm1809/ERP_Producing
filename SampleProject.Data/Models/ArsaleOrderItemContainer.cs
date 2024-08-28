using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderItemContainers")]
public partial class ArsaleOrderItemContainer
{
    [Key]
    [Column("ARSaleOrderItemContainerID")]
    public int ArsaleOrderItemContainerId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ARSaleOrderItemContainerProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArsaleOrderItemContainerProductQty { get; set; }

    [Column("ARSaleOrderItemContainerComment")]
    [StringLength(512)]
    public string ArsaleOrderItemContainerComment { get; set; }

    [Column("FK_GEContainerID")]
    public int? FkGecontainerId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderItemContainers")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkGecontainerId")]
    [InverseProperty("ArsaleOrderItemContainers")]
    public virtual Gecontainer FkGecontainer { get; set; }
}
