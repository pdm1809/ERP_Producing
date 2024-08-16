using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APAllocationCostItemShipments")]
public partial class ApallocationCostItemShipment
{
    [Key]
    [Column("APAllocationCostItemShipmentID")]
    public int ApallocationCostItemShipmentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_APAllocationCostID")]
    public int? FkApallocationCostId { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [Column("APAllocationCostItemShipmentTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApallocationCostItemShipmentTotalAmount { get; set; }

    [Column("FK_ICProductAttributeValueQualityID")]
    public int? FkIcproductAttributeValueQualityId { get; set; }

    [ForeignKey("FkApallocationCostId")]
    [InverseProperty("ApallocationCostItemShipments")]
    public virtual ApallocationCost FkApallocationCost { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("ApallocationCostItemShipments")]
    public virtual Icshipment FkIcshipment { get; set; }
}
