using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlanItemChildDateDetails")]
public partial class MmoperationDetailPlanItemChildDateDetail
{
    [Key]
    [Column("MMOperationDetailPlanItemChildDateDetailID")]
    public int MmoperationDetailPlanItemChildDateDetailId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("MMOperationDetailPlanItemChildDateDetailPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildDateDetailPlanProductQty { get; set; }

    [Column("MMOperationDetailPlanItemChildDateDetailPlanBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemChildDateDetailPlanBlock { get; set; }

    [Column("MMOperationDetailPlanItemChildDateDetailPlanDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanItemChildDateDetailPlanDate { get; set; }

    [ForeignKey("FkMmoperationDetailPlanItemChildId")]
    [InverseProperty("MmoperationDetailPlanItemChildDateDetails")]
    public virtual MmoperationDetailPlanItemChild FkMmoperationDetailPlanItemChild { get; set; }
}
