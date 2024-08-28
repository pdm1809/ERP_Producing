using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormApproveLogs")]
public partial class MmproductionNormApproveLog
{
    [Key]
    [Column("MMProductionNormApproveLogID")]
    public int MmproductionNormApproveLogId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("MMProductionNormApproveLogUserName")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproductionNormApproveLogUserName { get; set; }

    [Column("MMProductionNormApproveLogDate", TypeName = "datetime")]
    public DateTime? MmproductionNormApproveLogDate { get; set; }

    [Column("MMProductionNormApproveLogDesc")]
    [StringLength(512)]
    public string MmproductionNormApproveLogDesc { get; set; }

    [Column("MMProductionNormApproveLogType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproductionNormApproveLogType { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("MMProductionNormBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormBlock { get; set; }

    [Column("MMProductionNormApproveLogUpdateType")]
    [StringLength(50)]
    public string MmproductionNormApproveLogUpdateType { get; set; }

    [Column("MMProductionNormApproveLogBPIDReference")]
    [StringLength(2000)]
    public string MmproductionNormApproveLogBpidreference { get; set; }
}
