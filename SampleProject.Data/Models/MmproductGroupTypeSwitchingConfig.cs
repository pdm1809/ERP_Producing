using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductGroupTypeSwitchingConfigs")]
public partial class MmproductGroupTypeSwitchingConfig
{
    [Key]
    [Column("MMProductGroupTypeSwitchingConfigID")]
    public int MmproductGroupTypeSwitchingConfigId { get; set; }

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

    [Column("MMProductGroupType")]
    [StringLength(50)]
    public string MmproductGroupType { get; set; }

    [Column("MMProductGroupTypeSwitching")]
    [StringLength(50)]
    public string MmproductGroupTypeSwitching { get; set; }

    [Column("MMProductGroupTypeSwitchingConfigPercent", TypeName = "decimal(18, 5)")]
    public decimal? MmproductGroupTypeSwitchingConfigPercent { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductGroupTypeSwitchingConfigs")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
