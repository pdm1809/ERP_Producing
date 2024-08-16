using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("BRTransferLogs")]
[Microsoft.EntityFrameworkCore.Index("BrtransferLogNo", Name = "Idx_BRTransferLogs")]
public partial class BrtransferLog
{
    [Key]
    [Column("BRTransferLogID")]
    public int BrtransferLogId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("BRTransferLogNo")]
    [StringLength(50)]
    public string BrtransferLogNo { get; set; }

    [Column("BRTransferLogName")]
    [StringLength(50)]
    public string BrtransferLogName { get; set; }

    [Column("BRTransferLogDesc")]
    [StringLength(255)]
    public string BrtransferLogDesc { get; set; }

    [Column("BRBranchServerName")]
    [StringLength(50)]
    public string BrbranchServerName { get; set; }

    [Column("BRBranchTransferLog", TypeName = "ntext")]
    public string BrbranchTransferLog { get; set; }
}
