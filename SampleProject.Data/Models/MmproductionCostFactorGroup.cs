using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostFactorGroups")]
public partial class MmproductionCostFactorGroup
{
    [Key]
    [Column("MMProductionCostFactorGroupID")]
    public int MmproductionCostFactorGroupId { get; set; }

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

    [Column("MMProductionCostFactorGroupNo")]
    [StringLength(50)]
    public string MmproductionCostFactorGroupNo { get; set; }

    [Column("MMProductionCostFactorGroupName")]
    [StringLength(100)]
    public string MmproductionCostFactorGroupName { get; set; }

    [InverseProperty("FkMmproductionCostFactorGroup")]
    public virtual ICollection<MmproductionCostFormulaDetail> MmproductionCostFormulaDetails { get; set; } = new List<MmproductionCostFormulaDetail>();
}
