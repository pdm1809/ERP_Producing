using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptItemContFees")]
public partial class IcreceiptItemContFee
{
    [Key]
    [Column("ICReceiptItemContFeeID")]
    public int IcreceiptItemContFeeId { get; set; }

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

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_GEContainerID")]
    public int? FkGecontainerId { get; set; }

    [Column("FK_GEUnitCostID")]
    public int? FkGeunitCostId { get; set; }

    [Column("ICReceiptItemContFeeUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemContFeeUnitCost { get; set; }

    [Column("ICReceiptItemContFeeTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemContFeeTotalCost { get; set; }

    [Column("ICReceiptItemContFeeContQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemContFeeContQty { get; set; }

    [ForeignKey("FkGecontainerId")]
    [InverseProperty("IcreceiptItemContFees")]
    public virtual Gecontainer FkGecontainer { get; set; }

    [ForeignKey("FkGeunitCostId")]
    [InverseProperty("IcreceiptItemContFees")]
    public virtual GeunitCost FkGeunitCost { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("IcreceiptItemContFees")]
    public virtual Icreceipt FkIcreceipt { get; set; }
}
