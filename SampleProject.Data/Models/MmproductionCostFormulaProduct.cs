using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostFormulaProducts")]
public partial class MmproductionCostFormulaProduct
{
    [Key]
    [Column("MMProductionCostFormulaProductID")]
    public int MmproductionCostFormulaProductId { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("MMProductionCostFormulaProductName")]
    [StringLength(512)]
    public string MmproductionCostFormulaProductName { get; set; }

    [Column("MMProductionCostFormulaProductDesc")]
    [StringLength(512)]
    public string MmproductionCostFormulaProductDesc { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmproductionCostFormulaProducts")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionCostFormulaProducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductionCostFormulaProducts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmproductionCostFormulaId")]
    [InverseProperty("MmproductionCostFormulaProducts")]
    public virtual MmproductionCostFormula FkMmproductionCostFormula { get; set; }
}
