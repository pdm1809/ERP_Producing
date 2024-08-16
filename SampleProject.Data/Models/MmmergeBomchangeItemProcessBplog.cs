using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMergeBOMChangeItemProcessBPLogs")]
public partial class MmmergeBomchangeItemProcessBplog
{
    [Key]
    [Column("MMMergeBOMChangeItemProcessBPLogID")]
    public int MmmergeBomchangeItemProcessBplogId { get; set; }

    [Column("FK_MMMergeBOMChangeID")]
    public int? FkMmmergeBomchangeId { get; set; }

    [Column("ICProductItemProcessLogID")]
    public int? IcproductItemProcessLogId { get; set; }

    [Column("FK_MMProductionNormApproveLogID")]
    public int? FkMmproductionNormApproveLogId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("ICProductItemProcessID")]
    public int? IcproductItemProcessId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductCarcassID")]
    public int? FkIcproductCarcassId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("ICProductItemProcessPeriod")]
    public int? IcproductItemProcessPeriod { get; set; }

    [Column("FK_MMProcessID")]
    public int? FkMmprocessId { get; set; }

    [Column("ICMachineGroup")]
    [StringLength(50)]
    public string IcmachineGroup { get; set; }

    [Column("MMMergeBOMChangeActionType")]
    [StringLength(50)]
    public string MmmergeBomchangeActionType { get; set; }

    [Column("ICProductItemProcessCapacity")]
    public bool? IcproductItemProcessCapacity { get; set; }

    [Column("ICProductItemProcessInOutStockCheck")]
    public bool? IcproductItemProcessInOutStockCheck { get; set; }

    [Column("ICProductItemProcessIsBeginOperation")]
    public bool? IcproductItemProcessIsBeginOperation { get; set; }

    [Column("ICProductItemProcessIsPlan")]
    public bool? IcproductItemProcessIsPlan { get; set; }

    [Column("MMMergeBOMChangeItemProcessBPLogSyncProductCheck")]
    public bool? MmmergeBomchangeItemProcessBplogSyncProductCheck { get; set; }

    [Column("FK_MMOperationSynID")]
    public int? FkMmoperationSynId { get; set; }

    [Column("MMMergeBOMChangeItemProcessBPLogForParentSyncCheck")]
    public bool? MmmergeBomchangeItemProcessBplogForParentSyncCheck { get; set; }

    [Column("MMMergeBOMChangeItemProcessBPLogIsOutSourcing")]
    public bool? MmmergeBomchangeItemProcessBplogIsOutSourcing { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmmergeBomchangeItemProcessBplogs")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmmergeBomchangeItemProcessBplogs")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmmergeBomchangeId")]
    [InverseProperty("MmmergeBomchangeItemProcessBplogs")]
    public virtual MmmergeBomchange FkMmmergeBomchange { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmmergeBomchangeItemProcessBplogs")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmprocessId")]
    [InverseProperty("MmmergeBomchangeItemProcessBplogs")]
    public virtual Mmprocesss FkMmprocess { get; set; }
}
