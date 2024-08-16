using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostFormulaOperationItems")]
public partial class MmproductionCostFormulaOperationItem
{
    [Key]
    [Column("MMProductionCostFormulaOperationItemID")]
    public int MmproductionCostFormulaOperationItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
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

    [Column("FK_MMProductionCostFormulaID")]
    public int? FkMmproductionCostFormulaId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostFormulaOperationItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostFormulaId")]
    [InverseProperty("MmproductionCostFormulaOperationItems")]
    public virtual MmproductionCostFormula FkMmproductionCostFormula { get; set; }
}
