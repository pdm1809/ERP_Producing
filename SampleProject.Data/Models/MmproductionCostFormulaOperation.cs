using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostFormulaOperations")]
public partial class MmproductionCostFormulaOperation
{
    [Key]
    [Column("MMProductionCostFormulaOperationID")]
    public int MmproductionCostFormulaOperationId { get; set; }

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

    [Column("MMProductionCostFormulaOperationNo")]
    [StringLength(50)]
    public string MmproductionCostFormulaOperationNo { get; set; }

    [Column("MMProductionCostFormulaOperationName")]
    [StringLength(512)]
    public string MmproductionCostFormulaOperationName { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostFormulaOperations")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostFormulaId")]
    [InverseProperty("MmproductionCostFormulaOperations")]
    public virtual MmproductionCostFormula FkMmproductionCostFormula { get; set; }
}
