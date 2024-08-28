using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTransferLogs")]
[Microsoft.EntityFrameworkCore.Index("IctransferLogDate", "FkBrbranchId", Name = "Idx_ICTransferLogs")]
public partial class IctransferLog
{
    [Key]
    [Column("ICTransferLogID")]
    public int IctransferLogId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ICTransferLogDate", TypeName = "datetime")]
    public DateTime? IctransferLogDate { get; set; }

    [Column("ICTransferReceiptNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferReceiptNo { get; set; }

    [Column("ICReferenceTransferNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreferenceTransferNo { get; set; }

    [Column("FK_ICFromStockID")]
    public int? FkIcfromStockId { get; set; }

    [Column("FK_ICToStockID")]
    public int? FkIctoStockId { get; set; }

    [Column("FK_ICTransitStockID")]
    public int? FkIctransitStockId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ICTransferLogStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferLogStatus { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IctransferLogs")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcfromStockId")]
    [InverseProperty("IctransferLogFkIcfromStocks")]
    public virtual Icstock FkIcfromStock { get; set; }

    [ForeignKey("FkIctoStockId")]
    [InverseProperty("IctransferLogFkIctoStocks")]
    public virtual Icstock FkIctoStock { get; set; }

    [ForeignKey("FkIctransitStockId")]
    [InverseProperty("IctransferLogFkIctransitStocks")]
    public virtual Icstock FkIctransitStock { get; set; }

    [InverseProperty("FkIctransferLog")]
    public virtual ICollection<IctransferLogItem> IctransferLogItems { get; set; } = new List<IctransferLogItem>();
}
