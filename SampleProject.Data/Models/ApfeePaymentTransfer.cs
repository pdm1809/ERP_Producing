using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFeePaymentTransfers")]
public partial class ApfeePaymentTransfer
{
    [Key]
    [Column("APFeePaymentTransferID")]
    public int ApfeePaymentTransferId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ICTransferID")]
    public int FkIctransferId { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApfeePaymentTransfers")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkIctransferId")]
    [InverseProperty("ApfeePaymentTransfers")]
    public virtual Ictransfer FkIctransfer { get; set; }
}
