using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCompletionTimeConfigs")]
public partial class MmproductionCompletionTimeConfig
{
    [Key]
    [Column("MMProductionCompletionTimeConfigID")]
    public int MmproductionCompletionTimeConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMProductionCompletionTimeConfigType")]
    [StringLength(50)]
    public string MmproductionCompletionTimeConfigType { get; set; }

    [Column("MMProductionCompletionTimeConfigDateNumber", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCompletionTimeConfigDateNumber { get; set; }

    [Column("MMProductionCompletionTimeConfigDateType")]
    [StringLength(50)]
    public string MmproductionCompletionTimeConfigDateType { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCompletionTimeConfigs")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
