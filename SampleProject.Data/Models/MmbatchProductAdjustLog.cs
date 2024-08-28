using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductAdjustLogs")]
public partial class MmbatchProductAdjustLog
{
    [Key]
    [Column("MMBatchProductAdjustLogID")]
    public int MmbatchProductAdjustLogId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_HREmployeeEditID")]
    public int? FkHremployeeEditId { get; set; }

    [Column("MMBatchProductAdjustLogOldQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductAdjustLogOldQty { get; set; }

    [Column("MMBatchProductAdjustLogQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductAdjustLogQty { get; set; }

    [Column("MMBatchProductAdjustLogType")]
    [StringLength(50)]
    public string MmbatchProductAdjustLogType { get; set; }

    [Column("MMBatchProductAdjustLogDate", TypeName = "datetime")]
    public DateTime? MmbatchProductAdjustLogDate { get; set; }

    [Column("MMBatchProductAdjustLogDesc")]
    [StringLength(2056)]
    public string MmbatchProductAdjustLogDesc { get; set; }

    [Column("FK_HREmployeeRequestEditID")]
    public int? FkHremployeeRequestEditId { get; set; }

    [Column("FK_MMProductionNormOldID")]
    public int? FkMmproductionNormOldId { get; set; }

    [Column("FK_MMProductionNormNewID")]
    public int? FkMmproductionNormNewId { get; set; }

    [Column("MMBatchProductAdjustLogIsMaterialChanged")]
    public bool? MmbatchProductAdjustLogIsMaterialChanged { get; set; }
}
