using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReceiptItemErrors")]
public partial class IcreceiptItemError
{
    [Key]
    [Column("ICReceiptItemErrorID")]
    public int IcreceiptItemErrorId { get; set; }

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

    [Column("ICReceiptItemErrorReceiptNo")]
    [StringLength(50)]
    public string IcreceiptItemErrorReceiptNo { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICReceiptItemErrorProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemErrorProductQty { get; set; }

    [Column("ICReceiptItemErrorProductBlock", TypeName = "decimal(18, 5)")]
    public decimal? IcreceiptItemErrorProductBlock { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("ICReceiptItemErrorReferenceID")]
    public int? IcreceiptItemErrorReferenceId { get; set; }
}
