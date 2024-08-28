using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationDetailPlanItemDateDetails")]
public partial class MmoperationDetailPlanItemDateDetail
{
    [Key]
    [Column("MMOperationDetailPlanItemDateDetailID")]
    public int MmoperationDetailPlanItemDateDetailId { get; set; }

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

    [Column("FK_MMOperationDetailPlanItemID")]
    public int FkMmoperationDetailPlanItemId { get; set; }

    [Column("MMOperationDetailPlanItemDateDetailPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemDateDetailPlanProductQty { get; set; }

    [Column("MMOperationDetailPlanItemDateDetailPlanBlock", TypeName = "decimal(18, 5)")]
    public decimal? MmoperationDetailPlanItemDateDetailPlanBlock { get; set; }

    [Column("MMOperationDetailPlanItemDateDetailPlanDate", TypeName = "datetime")]
    public DateTime? MmoperationDetailPlanItemDateDetailPlanDate { get; set; }

    [ForeignKey("FkMmoperationDetailPlanItemId")]
    [InverseProperty("MmoperationDetailPlanItemDateDetails")]
    public virtual MmoperationDetailPlanItem FkMmoperationDetailPlanItem { get; set; }
}
