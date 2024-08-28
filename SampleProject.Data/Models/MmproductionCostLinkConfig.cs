using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostLinkConfigs")]
public partial class MmproductionCostLinkConfig
{
    [Key]
    [Column("MMProductionCostLinkConfigID")]
    public int MmproductionCostLinkConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("MMProductionCostInProgressClassifyType")]
    [StringLength(50)]
    public string MmproductionCostInProgressClassifyType { get; set; }

    [Column("MMProductionCostInProgressCalType")]
    [StringLength(100)]
    public string MmproductionCostInProgressCalType { get; set; }
}
