using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductProductionNormItemProcesss")]
public partial class MmbatchProductProductionNormItemProcesss
{
    [Key]
    [Column("MMBatchProductProductionNormItemProcessID")]
    public int MmbatchProductProductionNormItemProcessId { get; set; }

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

    [Column("MMBatchProductProductionNormItemProcessPeriod")]
    public int? MmbatchProductProductionNormItemProcessPeriod { get; set; }

    [Column("FK_MMProcessID")]
    public int? FkMmprocessId { get; set; }

    [Column("ICMachineGroup")]
    [StringLength(50)]
    public string IcmachineGroup { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_MMProductionNormApproveLogID")]
    public int? FkMmproductionNormApproveLogId { get; set; }

    [Column("FK_ICProductItemProcessID")]
    public int? FkIcproductItemProcessId { get; set; }

    [Column("MMBatchProductProductionNormItemProcessCapacity")]
    public bool? MmbatchProductProductionNormItemProcessCapacity { get; set; }

    [Column("MMBatchProductProductionNormItemProcessInOutStockCheck")]
    public bool? MmbatchProductProductionNormItemProcessInOutStockCheck { get; set; }

    [Column("MMBatchProductProductionNormItemProcessIsBeginOperation")]
    public bool? MmbatchProductProductionNormItemProcessIsBeginOperation { get; set; }

    [Column("MMBatchProductProductionNormItemProcessIsPlan")]
    public bool? MmbatchProductProductionNormItemProcessIsPlan { get; set; }

    [Column("MMBatchProductProductionNormItemProcessSyncProductCheck")]
    public bool? MmbatchProductProductionNormItemProcessSyncProductCheck { get; set; }

    [Column("FK_MMOperationSynID")]
    public int? FkMmoperationSynId { get; set; }

    [Column("MMBatchProductProductionNormItemProcessForParentSyncCheck")]
    public bool? MmbatchProductProductionNormItemProcessForParentSyncCheck { get; set; }

    [Column("MMBatchProductProductionNormItemProcessIsOutSourcing")]
    public bool? MmbatchProductProductionNormItemProcessIsOutSourcing { get; set; }

    [Column("MMBatchProductProductionNormItemProcessIsEndProcess")]
    public bool? MmbatchProductProductionNormItemProcessIsEndProcess { get; set; }

    [Column("MMBatchProductProductionNormItemProcessNeedQC")]
    public bool? MmbatchProductProductionNormItemProcessNeedQc { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbatchProductProductionNormItemProcesssFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductCarcassId")]
    [InverseProperty("MmbatchProductProductionNormItemProcesssFkIcproductCarcasses")]
    public virtual Icproduct FkIcproductCarcass { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmbatchProductProductionNormItemProcessses")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmprocessId")]
    [InverseProperty("MmbatchProductProductionNormItemProcessses")]
    public virtual Mmprocesss FkMmprocess { get; set; }
}
