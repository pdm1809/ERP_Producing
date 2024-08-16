using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptItemConts")]
public partial class IcreceiptItemCont
{
    [Key]
    [Column("ICReceiptItemContID")]
    public int IcreceiptItemContId { get; set; }

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

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_GEContainerID")]
    public int? FkGecontainerId { get; set; }

    [Column("ICReceiptItemContQty")]
    public int? IcreceiptItemContQty { get; set; }

    [Column("ICReceiptItemContTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemContTotalAmount { get; set; }

    [Column("ICReceiptItemContUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemContUnitPrice { get; set; }

    [ForeignKey("FkGecontainerId")]
    [InverseProperty("IcreceiptItemConts")]
    public virtual Gecontainer FkGecontainer { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("IcreceiptItemConts")]
    public virtual Icreceipt FkIcreceipt { get; set; }
}
