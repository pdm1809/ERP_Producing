using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEAccountingFormulas")]
public partial class GeaccountingFormula
{
    [Key]
    [Column("GEAccountingFormulaID")]
    public int GeaccountingFormulaId { get; set; }

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

    [Required]
    [Column("GEAccountingFormulaNo")]
    [StringLength(50)]
    public string GeaccountingFormulaNo { get; set; }

    [Column("GEAccountingFormulaName")]
    [StringLength(256)]
    public string GeaccountingFormulaName { get; set; }

    [Column("GEAccountingFormulaDesc")]
    [StringLength(512)]
    public string GeaccountingFormulaDesc { get; set; }

    [Column("GEAccountingFormulaDate", TypeName = "datetime")]
    public DateTime? GeaccountingFormulaDate { get; set; }

    [Column("GEAccountingFormulaType")]
    [StringLength(50)]
    public string GeaccountingFormulaType { get; set; }

    [InverseProperty("FkGeaccountingFormula")]
    public virtual ICollection<GeaccountingFormulaItem> GeaccountingFormulaItems { get; set; } = new List<GeaccountingFormulaItem>();
}
