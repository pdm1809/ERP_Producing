using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFeePaymentPurchaseOrders")]
public partial class ApfeePaymentPurchaseOrder
{
    [Key]
    [Column("APFeePaymentPurchaseOrderID")]
    public int ApfeePaymentPurchaseOrderId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int FkAppurchaseOrderId { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApfeePaymentPurchaseOrders")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("ApfeePaymentPurchaseOrders")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }
}
