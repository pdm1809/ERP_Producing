using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMFormulaConfigurations")]
public partial class MmformulaConfiguration
{
    [Key]
    [Column("MMFormulaConfigurationID")]
    public int MmformulaConfigurationId { get; set; }

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

    [Column("FK_MMFormulaID")]
    public int FkMmformulaId { get; set; }

    [Column("MMFormulaConfigurationTopQty", TypeName = "decimal(18, 5)")]
    public decimal? MmformulaConfigurationTopQty { get; set; }

    [Column("MMFormulaConfigurationShortEdgeQty", TypeName = "decimal(18, 5)")]
    public decimal? MmformulaConfigurationShortEdgeQty { get; set; }

    [Column("MMFormulaConfigurationLongEdgeQty", TypeName = "decimal(18, 5)")]
    public decimal? MmformulaConfigurationLongEdgeQty { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("MmformulaConfigurations")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkMmformulaId")]
    [InverseProperty("MmformulaConfigurations")]
    public virtual Mmformula FkMmformula { get; set; }
}
