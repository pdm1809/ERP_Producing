using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GECorrespondences")]
public partial class Gecorrespondence
{
    [Key]
    [Column("GECorrespondenceID")]
    public int GecorrespondenceId { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AAStat")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("GEModuleID")]
    public int GemoduleId { get; set; }

    [Required]
    [Column("GECorrespondenceName")]
    [StringLength(50)]
    [Unicode(false)]
    public string GecorrespondenceName { get; set; }

    [Required]
    [Column("GECorrespondenceFile")]
    [StringLength(50)]
    public string GecorrespondenceFile { get; set; }

    [Column("GECorrspondenceDate", TypeName = "datetime")]
    public DateTime GecorrspondenceDate { get; set; }

    [Required]
    [Column("GECorrespondenceRelatedObjectNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string GecorrespondenceRelatedObjectNumber { get; set; }

    [Column("GECorrespondenceInfo")]
    [StringLength(100)]
    public string GecorrespondenceInfo { get; set; }

    [Column("GECorrespondenceType")]
    [StringLength(50)]
    public string GecorrespondenceType { get; set; }

    [ForeignKey("GemoduleId")]
    [InverseProperty("Gecorrespondences")]
    public virtual Stmodule Gemodule { get; set; }
}
