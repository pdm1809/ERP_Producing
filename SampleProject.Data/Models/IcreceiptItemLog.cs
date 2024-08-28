using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptItemLogs")]
[Microsoft.EntityFrameworkCore.Index("FkIcreceiptItemId", Name = "Idx_ICReceiptItemLogs")]
public partial class IcreceiptItemLog
{
    [Key]
    [Column("ICReceiptItemLogID")]
    public int IcreceiptItemLogId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GEObjectHistoryID")]
    public int FkGeobjectHistoryId { get; set; }

    [Column("FK_ICReceiptID")]
    public int FkIcreceiptId { get; set; }

    [Column("FK_ICReceiptItemID")]
    public int FkIcreceiptItemId { get; set; }

    [Column("ICObjectHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcobjectHistoryAction { get; set; }

    [Column("ICReceiptItemLogColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string IcreceiptItemLogColumnName { get; set; }

    [Column("ICReceiptItemLogOldValue")]
    [StringLength(512)]
    public string IcreceiptItemLogOldValue { get; set; }

    [Column("ICReceiptItemLogNewValue")]
    [StringLength(512)]
    public string IcreceiptItemLogNewValue { get; set; }

    [ForeignKey("FkGeobjectHistoryId")]
    [InverseProperty("IcreceiptItemLogs")]
    public virtual GeobjectHistory FkGeobjectHistory { get; set; }

    [ForeignKey("FkIcreceiptId")]
    [InverseProperty("IcreceiptItemLogs")]
    public virtual Icreceipt FkIcreceipt { get; set; }

    [ForeignKey("FkIcreceiptItemId")]
    [InverseProperty("IcreceiptItemLogs")]
    public virtual IcreceiptItem FkIcreceiptItem { get; set; }
}
