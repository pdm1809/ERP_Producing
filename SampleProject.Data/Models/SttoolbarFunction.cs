using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STToolbarFunctions")]
public partial class SttoolbarFunction
{
    [Key]
    [Column("STToolbarFunctionID")]
    public int SttoolbarFunctionId { get; set; }

    [Required]
    [Column("STToolbarFunctionIDString")]
    [StringLength(50)]
    [Unicode(false)]
    public string SttoolbarFunctionIdstring { get; set; }

    [Column("STToolbarID")]
    public int SttoolbarId { get; set; }

    [Required]
    [Column("STToolbarFunctionName")]
    [StringLength(250)]
    [Unicode(false)]
    public string SttoolbarFunctionName { get; set; }

    [Required]
    [Column("STToolbarFunctionFullName")]
    [StringLength(500)]
    [Unicode(false)]
    public string SttoolbarFunctionFullName { get; set; }

    [Required]
    [Column("STToolbarFunctionClass")]
    [StringLength(250)]
    [Unicode(false)]
    public string SttoolbarFunctionClass { get; set; }

    [Column("STToolbarFunctionSortOrder")]
    public int SttoolbarFunctionSortOrder { get; set; }

    [ForeignKey("SttoolbarId")]
    [InverseProperty("SttoolbarFunctions")]
    public virtual Sttoolbar Sttoolbar { get; set; }

    [InverseProperty("SttoolbarFunction")]
    public virtual ICollection<SttoolbarFunctionParameter> SttoolbarFunctionParameters { get; set; } = new List<SttoolbarFunctionParameter>();
}
